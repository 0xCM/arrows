/* file: spatial_average_pooling2d_layer_types.h */
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
//  Implementation of spatial pyramid average 2D pooling layer.
//--
*/

#ifndef __SPATIAL_AVERAGE_POOLING2D_LAYER_TYPES_H__
#define __SPATIAL_AVERAGE_POOLING2D_LAYER_TYPES_H__

#include "algorithms/algorithm.h"
#include "data_management/data/tensor.h"
#include "data_management/data/homogen_tensor.h"
#include "services/daal_defines.h"
#include "algorithms/neural_networks/layers/spatial_pooling2d/spatial_pooling2d_layer_types.h"

namespace daal
{
namespace algorithms
{
namespace neural_networks
{
namespace layers
{
/**
 * @defgroup spatial_average_pooling2d Two-dimensional Spatial pyramid average Pooling Layer
 * \copydoc daal::algorithms::neural_networks::layers::spatial_average_pooling2d
 * @ingroup spatial_pooling2d
 * @{
 */
namespace spatial_average_pooling2d
{
/**
 * <a name="DAAL-ENUM-ALGORITHMS__NEURAL_NETWORKS__LAYERS__SPATIAL_AVERAGE_POOLING2D__METHOD"></a>
 * \brief Computation methods for the spatial pyramid average 2D pooling layer
 */
enum Method
{
    defaultDense = 0    /*!< Default: performance-oriented method */
};

/**
 * \brief Identifiers of input tensors for the backward spatial pyramid average 2D pooling layer
 *        and results for the forward spatial pyramid average 2D pooling layer
 */
enum LayerDataId
{
    auxInputDimensions,         /*!< Numeric table of size 1 x p that contains the sizes
                                          of the dimensions of the input data tensor */
    lastLayerDataId = auxInputDimensions
};

/**
 * \brief Contains version 1.0 of Intel(R) Data Analytics Acceleration Library (Intel(R) DAAL) interface.
 */
namespace interface1
{
/**
 * <a name="DAAL-STRUCT-ALGORITHMS__NEURAL_NETWORKS__LAYERS__SPATIAL_AVERAGE_POOLING2D__PARAMETER"></a>
 * \brief Parameters for the spatial pyramid average 2D pooling layer
 *
 * \snippet neural_networks/layers/spatial_pooling2d/spatial_average_pooling2d_layer_types.h Parameter source code
 */
/* [Parameter source code] */
struct DAAL_EXPORT Parameter: public spatial_pooling2d::Parameter
{
    Parameter(size_t pyramidHeight, size_t firstIndex, size_t secondIndex);
};
/* [Parameter source code] */

} // interface1
using interface1::Parameter;

} // namespace spatial_average_pooling2d
/** @} */
} // namespace layers
} // namespace neural_networks
} // namespace algorithm
} // namespace daal

#endif