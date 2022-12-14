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
    /// Defines HorizontalAlignment_anyOf
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum HorizontalAlignmentAnyOf
    {
        /// <summary>
        /// Enum Left for value: left
        /// </summary>
        [EnumMember(Value = "left")]
        Left = 1,

        /// <summary>
        /// Enum Center for value: center
        /// </summary>
        [EnumMember(Value = "center")]
        Center = 2,

        /// <summary>
        /// Enum Right for value: right
        /// </summary>
        [EnumMember(Value = "right")]
        Right = 3

    }

}
