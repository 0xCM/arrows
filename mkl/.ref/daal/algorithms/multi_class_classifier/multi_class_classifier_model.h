/* file: multi_class_classifier_model.h */
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
//  Multiclass tcc parameter structure
//--
*/

#ifndef __MULTI_CLASS_CLASSIFIER_MODEL_H__
#define __MULTI_CLASS_CLASSIFIER_MODEL_H__

#include "services/daal_defines.h"
#include "algorithms/model.h"
#include "algorithms/classifier/classifier_model.h"
#include "algorithms/classifier/classifier_predict.h"
#include "algorithms/classifier/classifier_training_batch.h"

namespace daal
{
namespace algorithms
{
/**
 * @defgroup multi_class_classifier Multi-class Classifier
 * \copydoc daal::algorithms::multi_class_classifier
 * @ingroup classification
 * @{
 */
/**
 * \brief Contains classes for computing the results of the multi-class classifier algorithm
 */
namespace multi_class_classifier
{

/**
 * \brief Contains version 1.0 of Intel(R) Data Analytics Acceleration Library (Intel(R) DAAL) interface.
 */
namespace interface1
{
/**
 * @ingroup multi_class_classifier
 * @{
 */
/**
 * <a name="DAAL-STRUCT-ALGORITHMS__MULTI_CLASS_CLASSIFIER__PARAMETERBASE"></a>
 * \brief Parameters of the multi-class classifier algorithm
 *
 * \snippet multi_class_classifier/multi_class_classifier_model.h ParameterBase source code
 */
/* [ParameterBase source code] */
struct DAAL_EXPORT ParameterBase : public daal::algorithms::classifier::Parameter
{
    ParameterBase(size_t nClasses): daal::algorithms::classifier::Parameter(nClasses), training(), prediction() {}
    services::SharedPtr<algorithms::classifier::training::Batch> training;          /*!< Two-class classifier training stage */
    services::SharedPtr<algorithms::classifier::prediction::Batch> prediction;      /*!< Two-class classifier prediction stage */
};
/* [ParameterBase source code] */

/**
 * <a name="DAAL-STRUCT-ALGORITHMS__MULTI_CLASS_CLASSIFIER__PARAMETER"></a>
 * \brief Optional multi-class classifier algorithm  parameters that are used with the MultiClassClassifierWu prediction method
 *
 * \snippet multi_class_classifier/multi_class_classifier_model.h Parameter source code
 */
/* [Parameter source code] */
struct DAAL_EXPORT Parameter : public ParameterBase
{
    Parameter(size_t nClasses, size_t maxIterations = 100, double accuracyThreshold = 1.0e-12) :
        ParameterBase(nClasses), maxIterations(maxIterations), accuracyThreshold(accuracyThreshold) {}

    size_t maxIterations;     /*!< Maximum number of iterations */
    double accuracyThreshold; /*!< Convergence threshold */

    services::Status check() const DAAL_C11_OVERRIDE;
};
/* [Parameter source code] */

/**
 * <a name="DAAL-CLASS-ALGORITHMS__MULTI_CLASS_CLASSIFIER__MODEL"></a>
 * \brief Model of the classifier trained by the multi_class_classifier::training::Batch algorithm.
 */
class DAAL_EXPORT Model : public daal::algorithms::classifier::Model
{
public:
    DECLARE_MODEL(Model, classifier::Model);

    /**
     * Constructs multi-class classifier model
     * \param[in] nFeatures Number of features in the dataset
     * \param[in] par       Parameters of the multi-class classifier algorithm
     * \DAAL_DEPRECATED_USE{ Model::create }
     */
    Model(size_t nFeatures, const ParameterBase *par);

    /**
     * Empty constructor for deserialization
     * \DAAL_DEPRECATED_USE{ Model::create }
     */
    Model();

    /**
     * Constructs multi-class classifier model
     * \param[in] nFeatures Number of features in the dataset
     * \param[in] par       Parameters of the multi-class classifier algorithm
     * \param[out] stat     Status of the model construction
     * \return Multi-class classifier model
     */
    static services::SharedPtr<Model> create(size_t nFeatures, const ParameterBase *par, services::Status* stat = NULL);

    virtual ~Model();

    /**
     * Returns a collection of two-class classifier models in a multi-class classifier model
     * \return  Collection of two-class classifier models
     */
    data_management::DataCollectionPtr getMultiClassClassifierModel()
    {
        return _models;
    }

    /**
     * Returns a pointer to the array of two-class classifier models in a multi-class classifier model
     * \return Pointer to the array of two-class classifier models
     * \DAAL_DEPRECATED_USE{ Model::getTwoClassClassifierModel }
     */
    DAAL_DEPRECATED classifier::ModelPtr *getTwoClassClassifierModels();

    /**
     * Set two-class classifier model into a multi-class classifier model
     * \param[in] idx    Index of two-class classifier model in a collection
     * \param[in] model  Two-class classifier model to add into collection
     */
    void setTwoClassClassifierModel(size_t idx, const classifier::ModelPtr& model);

    /**
     * Returns a two-class classifier model in a multi-class classifier model
     * \param[in]  idx   Index of the two-class classifier model in a multi-class classifier model
     * \return             Two-class classifier model
     */
    classifier::ModelPtr getTwoClassClassifierModel(size_t idx) const;

    /**
     * Returns a number of two-class classifiers associated with the model
     * \return        Number of two-class classifiers associated with the model
     */
    size_t getNumberOfTwoClassClassifierModels() const
    {
        return _models->size();
    }

    /**
     * Retrieves the number of features in the dataset was used on the training stage
     * \return Number of features in the dataset was used on the training stage
     */
    size_t getNumberOfFeatures() const DAAL_C11_OVERRIDE { return _nFeatures; }

protected:
    size_t _nFeatures;
    data_management::DataCollectionPtr _models;              /* Collection of two-class classifiers associated with the model */
    classifier::ModelPtr *_modelsArray;

    Model(size_t nFeatures, const ParameterBase *par, services::Status &st);

    template<typename Archive, bool onDeserialize>
    services::Status serialImpl(Archive *arch)
    {
        services::Status st = classifier::Model::serialImpl<Archive, onDeserialize>(arch);
        if (!st)
            return st;
        arch->set(_nFeatures);
        arch->setSharedPtrObj(_models);

        return st;
    }
};
typedef services::SharedPtr<Model> ModelPtr;
} // namespace interface1
using interface1::ParameterBase;
using interface1::Parameter;
using interface1::Model;
using interface1::ModelPtr;

} // namespace multi_class_classifier
/** @} */
} // namespace algorithms
} // namespace daal
#endif
