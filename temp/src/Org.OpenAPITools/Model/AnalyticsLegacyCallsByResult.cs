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
    /// AnalyticsLegacyCallsByResult
    /// </summary>
    [DataContract]
    public partial class AnalyticsLegacyCallsByResult :  IEquatable<AnalyticsLegacyCallsByResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsLegacyCallsByResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AnalyticsLegacyCallsByResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsLegacyCallsByResult" /> class.
        /// </summary>
        /// <param name="completed">completed (required).</param>
        /// <param name="abandoned">abandoned (required).</param>
        /// <param name="voicemail">voicemail (required).</param>
        /// <param name="missed">missed (required).</param>
        /// <param name="accepted">accepted (required).</param>
        /// <param name="unknown">unknown (required).</param>
        public AnalyticsLegacyCallsByResult(double completed = default(double), double abandoned = default(double), double voicemail = default(double), double missed = default(double), double accepted = default(double), double unknown = default(double))
        {
            // to ensure "completed" is required (not null)
            if (completed == null)
            {
                throw new InvalidDataException("completed is a required property for AnalyticsLegacyCallsByResult and cannot be null");
            }
            else
            {
                this.Completed = completed;
            }

            // to ensure "abandoned" is required (not null)
            if (abandoned == null)
            {
                throw new InvalidDataException("abandoned is a required property for AnalyticsLegacyCallsByResult and cannot be null");
            }
            else
            {
                this.Abandoned = abandoned;
            }

            // to ensure "voicemail" is required (not null)
            if (voicemail == null)
            {
                throw new InvalidDataException("voicemail is a required property for AnalyticsLegacyCallsByResult and cannot be null");
            }
            else
            {
                this.Voicemail = voicemail;
            }

            // to ensure "missed" is required (not null)
            if (missed == null)
            {
                throw new InvalidDataException("missed is a required property for AnalyticsLegacyCallsByResult and cannot be null");
            }
            else
            {
                this.Missed = missed;
            }

            // to ensure "accepted" is required (not null)
            if (accepted == null)
            {
                throw new InvalidDataException("accepted is a required property for AnalyticsLegacyCallsByResult and cannot be null");
            }
            else
            {
                this.Accepted = accepted;
            }

            // to ensure "unknown" is required (not null)
            if (unknown == null)
            {
                throw new InvalidDataException("unknown is a required property for AnalyticsLegacyCallsByResult and cannot be null");
            }
            else
            {
                this.Unknown = unknown;
            }

        }

        /// <summary>
        /// Gets or Sets Completed
        /// </summary>
        [DataMember(Name="completed", EmitDefaultValue=true)]
        public double Completed { get; set; }

        /// <summary>
        /// Gets or Sets Abandoned
        /// </summary>
        [DataMember(Name="abandoned", EmitDefaultValue=true)]
        public double Abandoned { get; set; }

        /// <summary>
        /// Gets or Sets Voicemail
        /// </summary>
        [DataMember(Name="voicemail", EmitDefaultValue=true)]
        public double Voicemail { get; set; }

        /// <summary>
        /// Gets or Sets Missed
        /// </summary>
        [DataMember(Name="missed", EmitDefaultValue=true)]
        public double Missed { get; set; }

        /// <summary>
        /// Gets or Sets Accepted
        /// </summary>
        [DataMember(Name="accepted", EmitDefaultValue=true)]
        public double Accepted { get; set; }

        /// <summary>
        /// Gets or Sets Unknown
        /// </summary>
        [DataMember(Name="unknown", EmitDefaultValue=true)]
        public double Unknown { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnalyticsLegacyCallsByResult {\n");
            sb.Append("  Completed: ").Append(Completed).Append("\n");
            sb.Append("  Abandoned: ").Append(Abandoned).Append("\n");
            sb.Append("  Voicemail: ").Append(Voicemail).Append("\n");
            sb.Append("  Missed: ").Append(Missed).Append("\n");
            sb.Append("  Accepted: ").Append(Accepted).Append("\n");
            sb.Append("  Unknown: ").Append(Unknown).Append("\n");
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
            return this.Equals(input as AnalyticsLegacyCallsByResult);
        }

        /// <summary>
        /// Returns true if AnalyticsLegacyCallsByResult instances are equal
        /// </summary>
        /// <param name="input">Instance of AnalyticsLegacyCallsByResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AnalyticsLegacyCallsByResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Completed == input.Completed ||
                    (this.Completed != null &&
                    this.Completed.Equals(input.Completed))
                ) && 
                (
                    this.Abandoned == input.Abandoned ||
                    (this.Abandoned != null &&
                    this.Abandoned.Equals(input.Abandoned))
                ) && 
                (
                    this.Voicemail == input.Voicemail ||
                    (this.Voicemail != null &&
                    this.Voicemail.Equals(input.Voicemail))
                ) && 
                (
                    this.Missed == input.Missed ||
                    (this.Missed != null &&
                    this.Missed.Equals(input.Missed))
                ) && 
                (
                    this.Accepted == input.Accepted ||
                    (this.Accepted != null &&
                    this.Accepted.Equals(input.Accepted))
                ) && 
                (
                    this.Unknown == input.Unknown ||
                    (this.Unknown != null &&
                    this.Unknown.Equals(input.Unknown))
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
                if (this.Completed != null)
                    hashCode = hashCode * 59 + this.Completed.GetHashCode();
                if (this.Abandoned != null)
                    hashCode = hashCode * 59 + this.Abandoned.GetHashCode();
                if (this.Voicemail != null)
                    hashCode = hashCode * 59 + this.Voicemail.GetHashCode();
                if (this.Missed != null)
                    hashCode = hashCode * 59 + this.Missed.GetHashCode();
                if (this.Accepted != null)
                    hashCode = hashCode * 59 + this.Accepted.GetHashCode();
                if (this.Unknown != null)
                    hashCode = hashCode * 59 + this.Unknown.GetHashCode();
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