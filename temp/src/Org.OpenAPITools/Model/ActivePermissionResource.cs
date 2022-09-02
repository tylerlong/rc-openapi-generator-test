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
    /// ActivePermissionResource
    /// </summary>
    [DataContract]
    public partial class ActivePermissionResource :  IEquatable<ActivePermissionResource>, IValidatableObject
    {
        /// <summary>
        /// Defines Scopes
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ScopesEnum
        {
            /// <summary>
            /// Enum Account for value: Account
            /// </summary>
            [EnumMember(Value = "Account")]
            Account = 1,

            /// <summary>
            /// Enum AllExtensions for value: AllExtensions
            /// </summary>
            [EnumMember(Value = "AllExtensions")]
            AllExtensions = 2,

            /// <summary>
            /// Enum Federation for value: Federation
            /// </summary>
            [EnumMember(Value = "Federation")]
            Federation = 3,

            /// <summary>
            /// Enum NonUserExtensions for value: NonUserExtensions
            /// </summary>
            [EnumMember(Value = "NonUserExtensions")]
            NonUserExtensions = 4,

            /// <summary>
            /// Enum RoleBased for value: RoleBased
            /// </summary>
            [EnumMember(Value = "RoleBased")]
            RoleBased = 5,

            /// <summary>
            /// Enum Self for value: Self
            /// </summary>
            [EnumMember(Value = "Self")]
            Self = 6,

            /// <summary>
            /// Enum UserExtensions for value: UserExtensions
            /// </summary>
            [EnumMember(Value = "UserExtensions")]
            UserExtensions = 7

        }


        /// <summary>
        /// Gets or Sets Scopes
        /// </summary>
        [DataMember(Name="scopes", EmitDefaultValue=false)]
        public List<ScopesEnum> Scopes { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ActivePermissionResource" /> class.
        /// </summary>
        /// <param name="permission">permission.</param>
        /// <param name="effectiveRole">effectiveRole.</param>
        /// <param name="scopes">scopes.</param>
        public ActivePermissionResource(PermissionIdResource permission = default(PermissionIdResource), RoleIdResource effectiveRole = default(RoleIdResource), List<ScopesEnum> scopes = default(List<ScopesEnum>))
        {
            this.Permission = permission;
            this.EffectiveRole = effectiveRole;
            this.Scopes = scopes;
        }

        /// <summary>
        /// Gets or Sets Permission
        /// </summary>
        [DataMember(Name="permission", EmitDefaultValue=false)]
        public PermissionIdResource Permission { get; set; }

        /// <summary>
        /// Gets or Sets EffectiveRole
        /// </summary>
        [DataMember(Name="effectiveRole", EmitDefaultValue=false)]
        public RoleIdResource EffectiveRole { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActivePermissionResource {\n");
            sb.Append("  Permission: ").Append(Permission).Append("\n");
            sb.Append("  EffectiveRole: ").Append(EffectiveRole).Append("\n");
            sb.Append("  Scopes: ").Append(Scopes).Append("\n");
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
            return this.Equals(input as ActivePermissionResource);
        }

        /// <summary>
        /// Returns true if ActivePermissionResource instances are equal
        /// </summary>
        /// <param name="input">Instance of ActivePermissionResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActivePermissionResource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Permission == input.Permission ||
                    (this.Permission != null &&
                    this.Permission.Equals(input.Permission))
                ) && 
                (
                    this.EffectiveRole == input.EffectiveRole ||
                    (this.EffectiveRole != null &&
                    this.EffectiveRole.Equals(input.EffectiveRole))
                ) && 
                (
                    this.Scopes == input.Scopes ||
                    this.Scopes != null &&
                    input.Scopes != null &&
                    this.Scopes.SequenceEqual(input.Scopes)
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
                if (this.Permission != null)
                    hashCode = hashCode * 59 + this.Permission.GetHashCode();
                if (this.EffectiveRole != null)
                    hashCode = hashCode * 59 + this.EffectiveRole.GetHashCode();
                if (this.Scopes != null)
                    hashCode = hashCode * 59 + this.Scopes.GetHashCode();
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
