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
    /// Defines AnalyticsLegacyInterval
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum AnalyticsLegacyInterval
    {
        /// <summary>
        /// Enum Hour for value: Hour
        /// </summary>
        [EnumMember(Value = "Hour")]
        Hour = 1,

        /// <summary>
        /// Enum Day for value: Day
        /// </summary>
        [EnumMember(Value = "Day")]
        Day = 2,

        /// <summary>
        /// Enum Week for value: Week
        /// </summary>
        [EnumMember(Value = "Week")]
        Week = 3,

        /// <summary>
        /// Enum Month for value: Month
        /// </summary>
        [EnumMember(Value = "Month")]
        Month = 4

    }

}
