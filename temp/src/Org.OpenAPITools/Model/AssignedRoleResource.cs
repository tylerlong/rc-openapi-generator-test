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
    /// AssignedRoleResource
    /// </summary>
    [DataContract]
    public partial class AssignedRoleResource :  IEquatable<AssignedRoleResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssignedRoleResource" /> class.
        /// </summary>
        /// <param name="id">Internal identifier of a role.</param>
        /// <param name="autoAssigned">Specifies if a role can be auto assigned (default to false).</param>
        /// <param name="displayName">Name of a default role.</param>
        /// <param name="siteCompatible">Site compatibility flag.</param>
        /// <param name="siteRestricted">Site restricted flag.</param>
        public AssignedRoleResource(string id = default(string), bool autoAssigned = false, string displayName = default(string), bool siteCompatible = default(bool), bool siteRestricted = default(bool))
        {
            this.Id = id;
            // use default value if no "autoAssigned" provided
            if (autoAssigned == null)
            {
                this.AutoAssigned = false;
            }
            else
            {
                this.AutoAssigned = autoAssigned;
            }
            this.DisplayName = displayName;
            this.SiteCompatible = siteCompatible;
            this.SiteRestricted = siteRestricted;
        }

        /// <summary>
        /// Internal identifier of a role
        /// </summary>
        /// <value>Internal identifier of a role</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Specifies if a role can be auto assigned
        /// </summary>
        /// <value>Specifies if a role can be auto assigned</value>
        [DataMember(Name="autoAssigned", EmitDefaultValue=false)]
        public bool AutoAssigned { get; set; }

        /// <summary>
        /// Name of a default role
        /// </summary>
        /// <value>Name of a default role</value>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Site compatibility flag
        /// </summary>
        /// <value>Site compatibility flag</value>
        [DataMember(Name="siteCompatible", EmitDefaultValue=false)]
        public bool SiteCompatible { get; set; }

        /// <summary>
        /// Site restricted flag
        /// </summary>
        /// <value>Site restricted flag</value>
        [DataMember(Name="siteRestricted", EmitDefaultValue=false)]
        public bool SiteRestricted { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssignedRoleResource {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AutoAssigned: ").Append(AutoAssigned).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  SiteCompatible: ").Append(SiteCompatible).Append("\n");
            sb.Append("  SiteRestricted: ").Append(SiteRestricted).Append("\n");
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
            return this.Equals(input as AssignedRoleResource);
        }

        /// <summary>
        /// Returns true if AssignedRoleResource instances are equal
        /// </summary>
        /// <param name="input">Instance of AssignedRoleResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AssignedRoleResource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.AutoAssigned == input.AutoAssigned ||
                    (this.AutoAssigned != null &&
                    this.AutoAssigned.Equals(input.AutoAssigned))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.SiteCompatible == input.SiteCompatible ||
                    (this.SiteCompatible != null &&
                    this.SiteCompatible.Equals(input.SiteCompatible))
                ) && 
                (
                    this.SiteRestricted == input.SiteRestricted ||
                    (this.SiteRestricted != null &&
                    this.SiteRestricted.Equals(input.SiteRestricted))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.AutoAssigned != null)
                    hashCode = hashCode * 59 + this.AutoAssigned.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.SiteCompatible != null)
                    hashCode = hashCode * 59 + this.SiteCompatible.GetHashCode();
                if (this.SiteRestricted != null)
                    hashCode = hashCode * 59 + this.SiteRestricted.GetHashCode();
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
