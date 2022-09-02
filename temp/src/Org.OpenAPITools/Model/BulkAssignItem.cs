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
    /// BulkAssignItem
    /// </summary>
    [DataContract]
    public partial class BulkAssignItem :  IEquatable<BulkAssignItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BulkAssignItem" /> class.
        /// </summary>
        /// <param name="departmentId">departmentId.</param>
        /// <param name="addedExtensionIds">addedExtensionIds.</param>
        /// <param name="removedExtensionIds">removedExtensionIds.</param>
        public BulkAssignItem(string departmentId = default(string), List<string> addedExtensionIds = default(List<string>), List<string> removedExtensionIds = default(List<string>))
        {
            this.DepartmentId = departmentId;
            this.AddedExtensionIds = addedExtensionIds;
            this.RemovedExtensionIds = removedExtensionIds;
        }

        /// <summary>
        /// Gets or Sets DepartmentId
        /// </summary>
        [DataMember(Name="departmentId", EmitDefaultValue=false)]
        public string DepartmentId { get; set; }

        /// <summary>
        /// Gets or Sets AddedExtensionIds
        /// </summary>
        [DataMember(Name="addedExtensionIds", EmitDefaultValue=false)]
        public List<string> AddedExtensionIds { get; set; }

        /// <summary>
        /// Gets or Sets RemovedExtensionIds
        /// </summary>
        [DataMember(Name="removedExtensionIds", EmitDefaultValue=false)]
        public List<string> RemovedExtensionIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BulkAssignItem {\n");
            sb.Append("  DepartmentId: ").Append(DepartmentId).Append("\n");
            sb.Append("  AddedExtensionIds: ").Append(AddedExtensionIds).Append("\n");
            sb.Append("  RemovedExtensionIds: ").Append(RemovedExtensionIds).Append("\n");
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
            return this.Equals(input as BulkAssignItem);
        }

        /// <summary>
        /// Returns true if BulkAssignItem instances are equal
        /// </summary>
        /// <param name="input">Instance of BulkAssignItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BulkAssignItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DepartmentId == input.DepartmentId ||
                    (this.DepartmentId != null &&
                    this.DepartmentId.Equals(input.DepartmentId))
                ) && 
                (
                    this.AddedExtensionIds == input.AddedExtensionIds ||
                    this.AddedExtensionIds != null &&
                    input.AddedExtensionIds != null &&
                    this.AddedExtensionIds.SequenceEqual(input.AddedExtensionIds)
                ) && 
                (
                    this.RemovedExtensionIds == input.RemovedExtensionIds ||
                    this.RemovedExtensionIds != null &&
                    input.RemovedExtensionIds != null &&
                    this.RemovedExtensionIds.SequenceEqual(input.RemovedExtensionIds)
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
                if (this.DepartmentId != null)
                    hashCode = hashCode * 59 + this.DepartmentId.GetHashCode();
                if (this.AddedExtensionIds != null)
                    hashCode = hashCode * 59 + this.AddedExtensionIds.GetHashCode();
                if (this.RemovedExtensionIds != null)
                    hashCode = hashCode * 59 + this.RemovedExtensionIds.GetHashCode();
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