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
    /// Deprecated. Information on call owner
    /// </summary>
    [DataContract]
    public partial class OwnerInfo :  IEquatable<OwnerInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OwnerInfo" /> class.
        /// </summary>
        /// <param name="accountId">Internal identifier of an account that monitors a call.</param>
        /// <param name="extensionId">Internal identifier of an extension that monitors a call.</param>
        public OwnerInfo(string accountId = default(string), string extensionId = default(string))
        {
            this.AccountId = accountId;
            this.ExtensionId = extensionId;
        }

        /// <summary>
        /// Internal identifier of an account that monitors a call
        /// </summary>
        /// <value>Internal identifier of an account that monitors a call</value>
        [DataMember(Name="accountId", EmitDefaultValue=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// Internal identifier of an extension that monitors a call
        /// </summary>
        /// <value>Internal identifier of an extension that monitors a call</value>
        [DataMember(Name="extensionId", EmitDefaultValue=false)]
        public string ExtensionId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OwnerInfo {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  ExtensionId: ").Append(ExtensionId).Append("\n");
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
            return this.Equals(input as OwnerInfo);
        }

        /// <summary>
        /// Returns true if OwnerInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of OwnerInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OwnerInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.ExtensionId == input.ExtensionId ||
                    (this.ExtensionId != null &&
                    this.ExtensionId.Equals(input.ExtensionId))
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
                if (this.AccountId != null)
                    hashCode = hashCode * 59 + this.AccountId.GetHashCode();
                if (this.ExtensionId != null)
                    hashCode = hashCode * 59 + this.ExtensionId.GetHashCode();
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
