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
    /// DisabledFilterInfo
    /// </summary>
    [DataContract]
    public partial class DisabledFilterInfo :  IEquatable<DisabledFilterInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DisabledFilterInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DisabledFilterInfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DisabledFilterInfo" /> class.
        /// </summary>
        /// <param name="filter">Event filter that is disabled for the user (required).</param>
        /// <param name="reason">Reason why the filter is disabled for the user (required).</param>
        /// <param name="message">Error message.</param>
        public DisabledFilterInfo(string filter = default(string), string reason = default(string), string message = default(string))
        {
            // to ensure "filter" is required (not null)
            if (filter == null)
            {
                throw new InvalidDataException("filter is a required property for DisabledFilterInfo and cannot be null");
            }
            else
            {
                this.Filter = filter;
            }

            // to ensure "reason" is required (not null)
            if (reason == null)
            {
                throw new InvalidDataException("reason is a required property for DisabledFilterInfo and cannot be null");
            }
            else
            {
                this.Reason = reason;
            }

            this.Message = message;
        }

        /// <summary>
        /// Event filter that is disabled for the user
        /// </summary>
        /// <value>Event filter that is disabled for the user</value>
        [DataMember(Name="filter", EmitDefaultValue=true)]
        public string Filter { get; set; }

        /// <summary>
        /// Reason why the filter is disabled for the user
        /// </summary>
        /// <value>Reason why the filter is disabled for the user</value>
        [DataMember(Name="reason", EmitDefaultValue=true)]
        public string Reason { get; set; }

        /// <summary>
        /// Error message
        /// </summary>
        /// <value>Error message</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DisabledFilterInfo {\n");
            sb.Append("  Filter: ").Append(Filter).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
            return this.Equals(input as DisabledFilterInfo);
        }

        /// <summary>
        /// Returns true if DisabledFilterInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of DisabledFilterInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DisabledFilterInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Filter == input.Filter ||
                    (this.Filter != null &&
                    this.Filter.Equals(input.Filter))
                ) && 
                (
                    this.Reason == input.Reason ||
                    (this.Reason != null &&
                    this.Reason.Equals(input.Reason))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
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
                if (this.Filter != null)
                    hashCode = hashCode * 59 + this.Filter.GetHashCode();
                if (this.Reason != null)
                    hashCode = hashCode * 59 + this.Reason.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
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
