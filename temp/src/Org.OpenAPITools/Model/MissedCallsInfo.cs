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
    /// MissedCallsInfo
    /// </summary>
    [DataContract]
    public partial class MissedCallsInfo :  IEquatable<MissedCallsInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MissedCallsInfo" /> class.
        /// </summary>
        /// <param name="notifyByEmail">Email notification flag.</param>
        /// <param name="notifyBySms">SMS notification flag.</param>
        /// <param name="advancedEmailAddresses">List of recipient email addresses for missed call notifications. Returned if specified, in both modes (advanced/basic). Applied in advanced mode only.</param>
        /// <param name="advancedSmsEmailAddresses">List of recipient phone numbers for missed call notifications. Returned if specified, in both modes (advanced/basic). Applied in advanced mode only.</param>
        public MissedCallsInfo(bool notifyByEmail = default(bool), bool notifyBySms = default(bool), List<string> advancedEmailAddresses = default(List<string>), List<string> advancedSmsEmailAddresses = default(List<string>))
        {
            this.NotifyByEmail = notifyByEmail;
            this.NotifyBySms = notifyBySms;
            this.AdvancedEmailAddresses = advancedEmailAddresses;
            this.AdvancedSmsEmailAddresses = advancedSmsEmailAddresses;
        }

        /// <summary>
        /// Email notification flag
        /// </summary>
        /// <value>Email notification flag</value>
        [DataMember(Name="notifyByEmail", EmitDefaultValue=false)]
        public bool NotifyByEmail { get; set; }

        /// <summary>
        /// SMS notification flag
        /// </summary>
        /// <value>SMS notification flag</value>
        [DataMember(Name="notifyBySms", EmitDefaultValue=false)]
        public bool NotifyBySms { get; set; }

        /// <summary>
        /// List of recipient email addresses for missed call notifications. Returned if specified, in both modes (advanced/basic). Applied in advanced mode only
        /// </summary>
        /// <value>List of recipient email addresses for missed call notifications. Returned if specified, in both modes (advanced/basic). Applied in advanced mode only</value>
        [DataMember(Name="advancedEmailAddresses", EmitDefaultValue=false)]
        public List<string> AdvancedEmailAddresses { get; set; }

        /// <summary>
        /// List of recipient phone numbers for missed call notifications. Returned if specified, in both modes (advanced/basic). Applied in advanced mode only
        /// </summary>
        /// <value>List of recipient phone numbers for missed call notifications. Returned if specified, in both modes (advanced/basic). Applied in advanced mode only</value>
        [DataMember(Name="advancedSmsEmailAddresses", EmitDefaultValue=false)]
        public List<string> AdvancedSmsEmailAddresses { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MissedCallsInfo {\n");
            sb.Append("  NotifyByEmail: ").Append(NotifyByEmail).Append("\n");
            sb.Append("  NotifyBySms: ").Append(NotifyBySms).Append("\n");
            sb.Append("  AdvancedEmailAddresses: ").Append(AdvancedEmailAddresses).Append("\n");
            sb.Append("  AdvancedSmsEmailAddresses: ").Append(AdvancedSmsEmailAddresses).Append("\n");
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
            return this.Equals(input as MissedCallsInfo);
        }

        /// <summary>
        /// Returns true if MissedCallsInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of MissedCallsInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MissedCallsInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NotifyByEmail == input.NotifyByEmail ||
                    (this.NotifyByEmail != null &&
                    this.NotifyByEmail.Equals(input.NotifyByEmail))
                ) && 
                (
                    this.NotifyBySms == input.NotifyBySms ||
                    (this.NotifyBySms != null &&
                    this.NotifyBySms.Equals(input.NotifyBySms))
                ) && 
                (
                    this.AdvancedEmailAddresses == input.AdvancedEmailAddresses ||
                    this.AdvancedEmailAddresses != null &&
                    input.AdvancedEmailAddresses != null &&
                    this.AdvancedEmailAddresses.SequenceEqual(input.AdvancedEmailAddresses)
                ) && 
                (
                    this.AdvancedSmsEmailAddresses == input.AdvancedSmsEmailAddresses ||
                    this.AdvancedSmsEmailAddresses != null &&
                    input.AdvancedSmsEmailAddresses != null &&
                    this.AdvancedSmsEmailAddresses.SequenceEqual(input.AdvancedSmsEmailAddresses)
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
                if (this.NotifyByEmail != null)
                    hashCode = hashCode * 59 + this.NotifyByEmail.GetHashCode();
                if (this.NotifyBySms != null)
                    hashCode = hashCode * 59 + this.NotifyBySms.GetHashCode();
                if (this.AdvancedEmailAddresses != null)
                    hashCode = hashCode * 59 + this.AdvancedEmailAddresses.GetHashCode();
                if (this.AdvancedSmsEmailAddresses != null)
                    hashCode = hashCode * 59 + this.AdvancedSmsEmailAddresses.GetHashCode();
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
