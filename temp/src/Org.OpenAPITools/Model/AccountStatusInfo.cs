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
    /// Status information (reason, comment, lifetime). Returned for &#39;Disabled&#39; status only
    /// </summary>
    [DataContract]
    public partial class AccountStatusInfo :  IEquatable<AccountStatusInfo>, IValidatableObject
    {
        /// <summary>
        /// Type of suspension
        /// </summary>
        /// <value>Type of suspension</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ReasonEnum
        {
            /// <summary>
            /// Enum SuspendedVoluntarily for value: SuspendedVoluntarily
            /// </summary>
            [EnumMember(Value = "SuspendedVoluntarily")]
            SuspendedVoluntarily = 1,

            /// <summary>
            /// Enum SuspendedInvoluntarily for value: SuspendedInvoluntarily
            /// </summary>
            [EnumMember(Value = "SuspendedInvoluntarily")]
            SuspendedInvoluntarily = 2,

            /// <summary>
            /// Enum UserResumed for value: UserResumed
            /// </summary>
            [EnumMember(Value = "UserResumed")]
            UserResumed = 3

        }

        /// <summary>
        /// Type of suspension
        /// </summary>
        /// <value>Type of suspension</value>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public ReasonEnum? Reason { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountStatusInfo" /> class.
        /// </summary>
        /// <param name="comment">A free-form user comment, describing the status change reason.</param>
        /// <param name="reason">Type of suspension.</param>
        /// <param name="till">Date until which the account will get deleted. The default value is 30 days since current date.</param>
        public AccountStatusInfo(string comment = default(string), ReasonEnum? reason = default(ReasonEnum?), string till = default(string))
        {
            this.Comment = comment;
            this.Reason = reason;
            this.Till = till;
        }

        /// <summary>
        /// A free-form user comment, describing the status change reason
        /// </summary>
        /// <value>A free-form user comment, describing the status change reason</value>
        [DataMember(Name="comment", EmitDefaultValue=false)]
        public string Comment { get; set; }


        /// <summary>
        /// Date until which the account will get deleted. The default value is 30 days since current date
        /// </summary>
        /// <value>Date until which the account will get deleted. The default value is 30 days since current date</value>
        [DataMember(Name="till", EmitDefaultValue=false)]
        public string Till { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountStatusInfo {\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  Till: ").Append(Till).Append("\n");
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
            return this.Equals(input as AccountStatusInfo);
        }

        /// <summary>
        /// Returns true if AccountStatusInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountStatusInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountStatusInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Comment == input.Comment ||
                    (this.Comment != null &&
                    this.Comment.Equals(input.Comment))
                ) && 
                (
                    this.Reason == input.Reason ||
                    (this.Reason != null &&
                    this.Reason.Equals(input.Reason))
                ) && 
                (
                    this.Till == input.Till ||
                    (this.Till != null &&
                    this.Till.Equals(input.Till))
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
                if (this.Comment != null)
                    hashCode = hashCode * 59 + this.Comment.GetHashCode();
                if (this.Reason != null)
                    hashCode = hashCode * 59 + this.Reason.GetHashCode();
                if (this.Till != null)
                    hashCode = hashCode * 59 + this.Till.GetHashCode();
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
