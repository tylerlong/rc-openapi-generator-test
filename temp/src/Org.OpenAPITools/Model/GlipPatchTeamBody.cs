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
    /// GlipPatchTeamBody
    /// </summary>
    [DataContract]
    public partial class GlipPatchTeamBody :  IEquatable<GlipPatchTeamBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlipPatchTeamBody" /> class.
        /// </summary>
        /// <param name="_public">Team access level.</param>
        /// <param name="name">Team name. Maximum number of characters supported is 250.</param>
        /// <param name="description">Team description. Maximum number of characters supported is 1000.</param>
        public GlipPatchTeamBody(bool _public = default(bool), string name = default(string), string description = default(string))
        {
            this.Public = _public;
            this.Name = name;
            this.Description = description;
        }

        /// <summary>
        /// Team access level
        /// </summary>
        /// <value>Team access level</value>
        [DataMember(Name="public", EmitDefaultValue=false)]
        public bool Public { get; set; }

        /// <summary>
        /// Team name. Maximum number of characters supported is 250
        /// </summary>
        /// <value>Team name. Maximum number of characters supported is 250</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Team description. Maximum number of characters supported is 1000
        /// </summary>
        /// <value>Team description. Maximum number of characters supported is 1000</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GlipPatchTeamBody {\n");
            sb.Append("  Public: ").Append(Public).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as GlipPatchTeamBody);
        }

        /// <summary>
        /// Returns true if GlipPatchTeamBody instances are equal
        /// </summary>
        /// <param name="input">Instance of GlipPatchTeamBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GlipPatchTeamBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Public == input.Public ||
                    (this.Public != null &&
                    this.Public.Equals(input.Public))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Public != null)
                    hashCode = hashCode * 59 + this.Public.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
