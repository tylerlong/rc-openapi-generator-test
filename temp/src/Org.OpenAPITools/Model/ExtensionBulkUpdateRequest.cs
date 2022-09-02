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
    /// List of extensions to be updated
    /// </summary>
    [DataContract]
    public partial class ExtensionBulkUpdateRequest :  IEquatable<ExtensionBulkUpdateRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExtensionBulkUpdateRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ExtensionBulkUpdateRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExtensionBulkUpdateRequest" /> class.
        /// </summary>
        /// <param name="records">records (required).</param>
        public ExtensionBulkUpdateRequest(List<ExtensionBulkUpdateInfo> records = default(List<ExtensionBulkUpdateInfo>))
        {
            // to ensure "records" is required (not null)
            if (records == null)
            {
                throw new InvalidDataException("records is a required property for ExtensionBulkUpdateRequest and cannot be null");
            }
            else
            {
                this.Records = records;
            }

        }

        /// <summary>
        /// Gets or Sets Records
        /// </summary>
        [DataMember(Name="records", EmitDefaultValue=true)]
        public List<ExtensionBulkUpdateInfo> Records { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExtensionBulkUpdateRequest {\n");
            sb.Append("  Records: ").Append(Records).Append("\n");
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
            return this.Equals(input as ExtensionBulkUpdateRequest);
        }

        /// <summary>
        /// Returns true if ExtensionBulkUpdateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ExtensionBulkUpdateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExtensionBulkUpdateRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Records == input.Records ||
                    this.Records != null &&
                    input.Records != null &&
                    this.Records.SequenceEqual(input.Records)
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
                if (this.Records != null)
                    hashCode = hashCode * 59 + this.Records.GetHashCode();
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
