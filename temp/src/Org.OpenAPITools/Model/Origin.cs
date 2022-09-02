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
    /// Defines Origin
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum Origin
    {
        /// <summary>
        /// Enum Internal for value: Internal
        /// </summary>
        [EnumMember(Value = "Internal")]
        Internal = 1,

        /// <summary>
        /// Enum External for value: External
        /// </summary>
        [EnumMember(Value = "External")]
        External = 2

    }

}
