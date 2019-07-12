/* file: algorithm_base_mode_impl.h */
/*******************************************************************************
* Copyright 2014-2018 Intel Corporation.
*
* This software and the related documents are Intel copyrighted  materials,  and
* your use of  them is  governed by the  express license  under which  they were
* provided to you (License).  Unless the License provides otherwise, you may not
* use, modify, copy, publish, distribute,  disclose or transmit this software or
* the related documents without Intel's prior written permission.
*
* This software and the related documents  are provided as  is,  with no express
* or implied  warranties,  other  than those  that are  expressly stated  in the
* License.
*******************************************************************************/

/*
//++
//  Implementation of base classes defining algorithm interface.
//--
*/

#ifndef __ALGORITHM_BASE_MODE_IMPL_H__
#define __ALGORITHM_BASE_MODE_IMPL_H__

#include "services/daal_defines.h"
#include "algorithms/algorithm_base_common.h"
#include "algorithms/algorithm_base_mode_batch.h"
#include "services/host_app.h"

namespace daal
{
namespace algorithms
{

/**
 * \brief Contains version 1.0 of Intel(R) Data Analytics Acceleration Library (Intel(R) DAAL) interface.
 */
namespace interface1
{

/**
 * <a name="DAAL-CLASS-ALGORITHMS__ALGORITHMIMPL"></a>
 * \brief Provides implementations of the compute and finalizeCompute methods of the Algorithm class.
 *        The methods of the class support different computation modes: batch, distributed and online(see \ref ComputeMode)
 * \tparam mode Computation mode of the algorithm, \ref ComputeMode
 */
template<ComputeMode mode>
class DAAL_EXPORT AlgorithmImpl : public Algorithm<mode>
{
public:
    /** Deafult constructor */
    AlgorithmImpl() : wasSetup(false), resetFlag(true), wasFinalizeSetup(false), resetFinalizeFlag(true) {}

    AlgorithmImpl(const AlgorithmImpl& other) : wasSetup(false), resetFlag(true), wasFinalizeSetup(false), resetFinalizeFlag(true) {}

    virtual ~AlgorithmImpl()
    {
        resetCompute();
        resetFinalizeCompute();
    }

    /**
     * Computes final results of the algorithm in the %batch mode,
     * or partial results of the algorithm in %online and %distributed modes without possibility of throwing an exception.
     */
    services::Status computeNoThrow();

    /**
     * Computes final results of the algorithm in the %batch mode,
     * or partial results of the algorithm in %online and %distributed modes.
     */
    services::Status compute()
    {
        this->_status = computeNoThrow();
        return services::throwIfPossible(this->_status);
    }

    /**
     * Computes final results of the algorithm using partial results in %online and %distributed modes.
     */
    services::Status finalizeComputeNoThrow()
    {
        if(this->isChecksEnabled())
        {
            services::Status s = this->checkPartialResult();
            if(!s)
                return s;
        }

        services::Status s = this->allocateResultMemory();
        if(!s)
            return s.add(services::ErrorMemoryAllocationFailed);

        this->_ac->setPartialResult(this->_pres);
        this->_ac->setResult(this->_res);

        if(this->isChecksEnabled())
        {
            s = this->checkFinalizeComputeParams();
            if(!s)
                return s;
        }

        s = setupFinalizeCompute();
        if(s)
            s |= this->_ac->finalizeCompute();
        if(resetFinalizeFlag)
            s |= resetFinalizeCompute();
        return s;
    }

    /**
     * Computes final results of the algorithm using partial results in %online and %distributed modes.
     */
    services::Status finalizeCompute()
    {
        this->_status = finalizeComputeNoThrow();
        return services::throwIfPossible(this->_status);
    }

    /**
     * Validates parameters of the compute method
     */
    virtual services::Status checkComputeParams() DAAL_C11_OVERRIDE
    {
        services::Status s;
        if (this->_par)
            s = this->_par->check();
        return s.add(this->_in->check(this->_par, this->getMethod()));
    }

    /**
     * Validates result parameters of the compute method
     */
    virtual services::Status checkResult() DAAL_C11_OVERRIDE
    {
        return this->_pres ? this->_pres->check(this->_in, this->_par, this->getMethod()) :
            services::Status(services::ErrorNullPartialResult);
    }

    /**
     * Validates result parameters of the finalizeCompute method
     */
    virtual services::Status checkPartialResult() DAAL_C11_OVERRIDE
    {
        return this->_pres ? this->_pres->check(this->_par, this->getMethod()) :
            services::Status(services::ErrorNullPartialResult);
    }

    /**
     * Validates parameters of the finalizeCompute method
     */
    virtual services::Status checkFinalizeComputeParams() DAAL_C11_OVERRIDE
    {
        return this->_res ? this->_res->check(this->_pres, this->_par, this->getMethod()) : services::Status();
    }

    services::Status setupCompute()
    {
        services::Status s;
        if(!wasSetup)
        {
            s = this->_ac->setupCompute();
            wasSetup = true;
        }
        return s;
    }

    services::Status resetCompute()
    {
        services::Status s;
        if(wasSetup)
        {
            s = this->_ac->resetCompute();
            wasSetup = false;
        }
        return s;
    }

    void enableResetOnCompute(bool flag)
    {
        resetFlag = flag;
    }

    services::Status setupFinalizeCompute()
    {
        services::Status s;
        if(!wasFinalizeSetup)
        {
            s = this->_ac->setupFinalizeCompute();
            wasFinalizeSetup = true;
        }
        return s;
    }

    services::Status resetFinalizeCompute()
    {
        services::Status s;
        if(wasFinalizeSetup)
        {
            s = this->_ac->resetFinalizeCompute();
            wasFinalizeSetup = false;
        }
        return s;
    }

    void enableResetOnFinalizeCompute(bool flag)
    {
        resetFinalizeFlag = flag;
    }
    /**
    * Returns HostAppIface used by the class
    * \return HostAppIface used by the class
    */
    services::HostAppIfacePtr hostApp();

    /**
    * Sets HostAppIface to be used by the class
    * \param pHost to be used by the class
    */
    void setHostApp(const services::HostAppIfacePtr& pHost);

private:
    bool wasSetup;
    bool resetFlag;
    bool wasFinalizeSetup;
    bool resetFinalizeFlag;
};

/**
 * <a name="DAAL-CLASS-ALGORITHMS__ALGORITHMIMPL_BATCH"></a>
 * \brief Provides implementations of the compute and checkComputeParams methods of the Algorithm<batch> class
 */
template<>
class DAAL_EXPORT AlgorithmImpl<batch> : public Algorithm<batch>
{
public:
    /** Deafult constructor */
    AlgorithmImpl() : wasSetup(false), resetFlag(true) {}

    AlgorithmImpl(const AlgorithmImpl& other) : wasSetup(false), resetFlag(true) {}

    virtual ~AlgorithmImpl()
    {
        resetCompute();
    }

    /**
     * Computes final results of the algorithm in the %batch mode without possibility of throwing an exception.
     */
    services::Status computeNoThrow();

    /**
     * Computes final results of the algorithm in the %batch mode.
     */
    services::Status compute()
    {
        this->_status = computeNoThrow();
        return services::throwIfPossible(this->_status);
    }

    /**
     * Validates parameters of the compute method
     */
    virtual services::Status checkComputeParams() DAAL_C11_OVERRIDE
    {
        services::Status s;
        if (_par)
        {
            s = _par->check();
            if(!s)
                return s;
        }

        return _in->check(_par, getMethod());
    }

    /**
     * Validates result parameters of the compute method
     */
    virtual services::Status checkResult() DAAL_C11_OVERRIDE
    {
        if (_res)
            return _res->check(_in, _par, getMethod());
        return services::Status(services::ErrorNullResult);
    }

    services::Status setupCompute()
    {
        services::Status s;
        if(!wasSetup)
        {
            s = this->_ac->setupCompute();
            wasSetup = true;
        }
        return s;
    }

    services::Status resetCompute()
    {
        services::Status s;
        if(wasSetup)
        {
            s = this->_ac->resetCompute();
            wasSetup = false;
        }
        return s;
    }

    void enableResetOnCompute(bool flag)
    {
        resetFlag = flag;
    }

    /**
    * Returns HostAppIface used by the class
    * \return HostAppIface used by the class
    */
    services::HostAppIfacePtr hostApp();

    /**
    * Sets HostAppIface to be used by the class
    * \param pHost to be used by the class
    */
    void setHostApp(const services::HostAppIfacePtr& pHost);

private:
    bool wasSetup;
    bool resetFlag;
};
/** @} */
} // namespace interface1
using interface1::AlgorithmImpl;

}
}
#endif
