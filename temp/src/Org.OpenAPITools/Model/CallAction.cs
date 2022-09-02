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
    /// Defines CallAction
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum CallAction
    {
        /// <summary>
        /// Enum HoldOff for value: HoldOff
        /// </summary>
        [EnumMember(Value = "HoldOff")]
        HoldOff = 1,

        /// <summary>
        /// Enum HoldOn for value: HoldOn
        /// </summary>
        [EnumMember(Value = "HoldOn")]
        HoldOn = 2,

        /// <summary>
        /// Enum ParkOn for value: ParkOn
        /// </summary>
        [EnumMember(Value = "ParkOn")]
        ParkOn = 3,

        /// <summary>
        /// Enum ParkOff for value: ParkOff
        /// </summary>
        [EnumMember(Value = "ParkOff")]
        ParkOff = 4,

        /// <summary>
        /// Enum BlindTransfer for value: BlindTransfer
        /// </summary>
        [EnumMember(Value = "BlindTransfer")]
        BlindTransfer = 5,

        /// <summary>
        /// Enum WarmTransfer for value: WarmTransfer
        /// </summary>
        [EnumMember(Value = "WarmTransfer")]
        WarmTransfer = 6,

        /// <summary>
        /// Enum DTMFTransfer for value: DTMFTransfer
        /// </summary>
        [EnumMember(Value = "DTMFTransfer")]
        DTMFTransfer = 7

    }

}
