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
    /// The selected data scope
    /// </summary>
    /// <value>The selected data scope</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum MembersGroupingOptions
    {
        /// <summary>
        /// Enum Department for value: Department
        /// </summary>
        [EnumMember(Value = "Department")]
        Department = 1,

        /// <summary>
        /// Enum UserGroup for value: UserGroup
        /// </summary>
        [EnumMember(Value = "UserGroup")]
        UserGroup = 2,

        /// <summary>
        /// Enum Queue for value: Queue
        /// </summary>
        [EnumMember(Value = "Queue")]
        Queue = 3,

        /// <summary>
        /// Enum Site for value: Site
        /// </summary>
        [EnumMember(Value = "Site")]
        Site = 4

    }

}
