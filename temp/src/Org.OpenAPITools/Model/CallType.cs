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
    /// Defines CallType
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum CallType
    {
        /// <summary>
        /// Enum Direct for value: Direct
        /// </summary>
        [EnumMember(Value = "Direct")]
        Direct = 1,

        /// <summary>
        /// Enum FromQueue for value: FromQueue
        /// </summary>
        [EnumMember(Value = "FromQueue")]
        FromQueue = 2,

        /// <summary>
        /// Enum ParkRetrieval for value: ParkRetrieval
        /// </summary>
        [EnumMember(Value = "ParkRetrieval")]
        ParkRetrieval = 3,

        /// <summary>
        /// Enum Transferred for value: Transferred
        /// </summary>
        [EnumMember(Value = "Transferred")]
        Transferred = 4,

        /// <summary>
        /// Enum Outbound for value: Outbound
        /// </summary>
        [EnumMember(Value = "Outbound")]
        Outbound = 5

    }

}
