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
    /// SwitchValidated
    /// </summary>
    [DataContract]
    public partial class SwitchValidated :  IEquatable<SwitchValidated>, IValidatableObject
    {
        /// <summary>
        /// Validation result status
        /// </summary>
        /// <value>Validation result status</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Valid for value: Valid
            /// </summary>
            [EnumMember(Value = "Valid")]
            Valid = 1,

            /// <summary>
            /// Enum Invalid for value: Invalid
            /// </summary>
            [EnumMember(Value = "Invalid")]
            Invalid = 2

        }

        /// <summary>
        /// Validation result status
        /// </summary>
        /// <value>Validation result status</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SwitchValidated" /> class.
        /// </summary>
        /// <param name="id">Internal identifier of a switch.</param>
        /// <param name="chassisId">Unique identifier of a network switch.</param>
        /// <param name="status">Validation result status.</param>
        /// <param name="errors">errors.</param>
        public SwitchValidated(string id = default(string), string chassisId = default(string), StatusEnum? status = default(StatusEnum?), List<ValidationError> errors = default(List<ValidationError>))
        {
            this.Id = id;
            this.ChassisId = chassisId;
            this.Status = status;
            this.Errors = errors;
        }

        /// <summary>
        /// Internal identifier of a switch
        /// </summary>
        /// <value>Internal identifier of a switch</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Unique identifier of a network switch
        /// </summary>
        /// <value>Unique identifier of a network switch</value>
        [DataMember(Name="chassisId", EmitDefaultValue=false)]
        public string ChassisId { get; set; }


        /// <summary>
        /// Gets or Sets Errors
        /// </summary>
        [DataMember(Name="errors", EmitDefaultValue=false)]
        public List<ValidationError> Errors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SwitchValidated {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ChassisId: ").Append(ChassisId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
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
            return this.Equals(input as SwitchValidated);
        }

        /// <summary>
        /// Returns true if SwitchValidated instances are equal
        /// </summary>
        /// <param name="input">Instance of SwitchValidated to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SwitchValidated input)
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
                    this.ChassisId == input.ChassisId ||
                    (this.ChassisId != null &&
                    this.ChassisId.Equals(input.ChassisId))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Errors == input.Errors ||
                    this.Errors != null &&
                    input.Errors != null &&
                    this.Errors.SequenceEqual(input.Errors)
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
                if (this.ChassisId != null)
                    hashCode = hashCode * 59 + this.ChassisId.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Errors != null)
                    hashCode = hashCode * 59 + this.Errors.GetHashCode();
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
