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
    /// Defines AnalyticsLegacyValueTypes
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum AnalyticsLegacyValueTypes
    {
        /// <summary>
        /// Enum Percent for value: Percent
        /// </summary>
        [EnumMember(Value = "Percent")]
        Percent = 1,

        /// <summary>
        /// Enum Seconds for value: Seconds
        /// </summary>
        [EnumMember(Value = "Seconds")]
        Seconds = 2,

        /// <summary>
        /// Enum Instances for value: Instances
        /// </summary>
        [EnumMember(Value = "Instances")]
        Instances = 3

    }

}
