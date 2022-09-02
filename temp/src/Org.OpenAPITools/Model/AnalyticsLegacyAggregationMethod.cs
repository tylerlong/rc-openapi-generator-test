/*
 * RingCentral Connect Platform API
 *
 * RingCentral Connect Platform API
 *
 * The version of the OpenAPI document: 1.0.48
 * Contact: platform@ringcentral.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Defines AnalyticsLegacyAggregationMethod
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum AnalyticsLegacyAggregationMethod
    {
        /// <summary>
        /// Enum Sum for value: Sum
        /// </summary>
        [EnumMember(Value = "Sum")]
        Sum = 1,

        /// <summary>
        /// Enum Average for value: Average
        /// </summary>
        [EnumMember(Value = "Average")]
        Average = 2,

        /// <summary>
        /// Enum Max for value: Max
        /// </summary>
        [EnumMember(Value = "Max")]
        Max = 3,

        /// <summary>
        /// Enum Min for value: Min
        /// </summary>
        [EnumMember(Value = "Min")]
        Min = 4,

        /// <summary>
        /// Enum Percent for value: Percent
        /// </summary>
        [EnumMember(Value = "Percent")]
        Percent = 5

    }

}
