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
    /// CallMonitoringBulkAssign
    /// </summary>
    [DataContract]
    public partial class CallMonitoringBulkAssign :  IEquatable<CallMonitoringBulkAssign>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CallMonitoringBulkAssign" /> class.
        /// </summary>
        /// <param name="addedExtensions">addedExtensions.</param>
        /// <param name="updatedExtensions">updatedExtensions.</param>
        /// <param name="removedExtensions">removedExtensions.</param>
        public CallMonitoringBulkAssign(List<CallMonitoringExtensionInfo> addedExtensions = default(List<CallMonitoringExtensionInfo>), List<CallMonitoringExtensionInfo> updatedExtensions = default(List<CallMonitoringExtensionInfo>), List<CallMonitoringExtensionInfo> removedExtensions = default(List<CallMonitoringExtensionInfo>))
        {
            this.AddedExtensions = addedExtensions;
            this.UpdatedExtensions = updatedExtensions;
            this.RemovedExtensions = removedExtensions;
        }

        /// <summary>
        /// Gets or Sets AddedExtensions
        /// </summary>
        [DataMember(Name="addedExtensions", EmitDefaultValue=false)]
        public List<CallMonitoringExtensionInfo> AddedExtensions { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedExtensions
        /// </summary>
        [DataMember(Name="updatedExtensions", EmitDefaultValue=false)]
        public List<CallMonitoringExtensionInfo> UpdatedExtensions { get; set; }

        /// <summary>
        /// Gets or Sets RemovedExtensions
        /// </summary>
        [DataMember(Name="removedExtensions", EmitDefaultValue=false)]
        public List<CallMonitoringExtensionInfo> RemovedExtensions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CallMonitoringBulkAssign {\n");
            sb.Append("  AddedExtensions: ").Append(AddedExtensions).Append("\n");
            sb.Append("  UpdatedExtensions: ").Append(UpdatedExtensions).Append("\n");
            sb.Append("  RemovedExtensions: ").Append(RemovedExtensions).Append("\n");
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
            return this.Equals(input as CallMonitoringBulkAssign);
        }

        /// <summary>
        /// Returns true if CallMonitoringBulkAssign instances are equal
        /// </summary>
        /// <param name="input">Instance of CallMonitoringBulkAssign to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CallMonitoringBulkAssign input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AddedExtensions == input.AddedExtensions ||
                    this.AddedExtensions != null &&
                    input.AddedExtensions != null &&
                    this.AddedExtensions.SequenceEqual(input.AddedExtensions)
                ) && 
                (
                    this.UpdatedExtensions == input.UpdatedExtensions ||
                    this.UpdatedExtensions != null &&
                    input.UpdatedExtensions != null &&
                    this.UpdatedExtensions.SequenceEqual(input.UpdatedExtensions)
                ) && 
                (
                    this.RemovedExtensions == input.RemovedExtensions ||
                    this.RemovedExtensions != null &&
                    input.RemovedExtensions != null &&
                    this.RemovedExtensions.SequenceEqual(input.RemovedExtensions)
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
                if (this.AddedExtensions != null)
                    hashCode = hashCode * 59 + this.AddedExtensions.GetHashCode();
                if (this.UpdatedExtensions != null)
                    hashCode = hashCode * 59 + this.UpdatedExtensions.GetHashCode();
                if (this.RemovedExtensions != null)
                    hashCode = hashCode * 59 + this.RemovedExtensions.GetHashCode();
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
