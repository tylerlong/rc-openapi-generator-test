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
    /// Contains successful and failed opt-outs
    /// </summary>
    [DataContract]
    public partial class OptOutBulkAssignResponseOptOuts :  IEquatable<OptOutBulkAssignResponseOptOuts>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OptOutBulkAssignResponseOptOuts" /> class.
        /// </summary>
        /// <param name="successful">Recipients&#39; phone numbers which opt-outs were successfully added for..</param>
        /// <param name="failed">Recipients&#39; phone numbers which opt-outs were failed to be added for. Plus, error messages.</param>
        public OptOutBulkAssignResponseOptOuts(List<string> successful = default(List<string>), List<OptOutBulkAssignFailedEntry> failed = default(List<OptOutBulkAssignFailedEntry>))
        {
            this.Successful = successful;
            this.Failed = failed;
        }

        /// <summary>
        /// Recipients&#39; phone numbers which opt-outs were successfully added for.
        /// </summary>
        /// <value>Recipients&#39; phone numbers which opt-outs were successfully added for.</value>
        [DataMember(Name="successful", EmitDefaultValue=false)]
        public List<string> Successful { get; set; }

        /// <summary>
        /// Recipients&#39; phone numbers which opt-outs were failed to be added for. Plus, error messages
        /// </summary>
        /// <value>Recipients&#39; phone numbers which opt-outs were failed to be added for. Plus, error messages</value>
        [DataMember(Name="failed", EmitDefaultValue=false)]
        public List<OptOutBulkAssignFailedEntry> Failed { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OptOutBulkAssignResponseOptOuts {\n");
            sb.Append("  Successful: ").Append(Successful).Append("\n");
            sb.Append("  Failed: ").Append(Failed).Append("\n");
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
            return this.Equals(input as OptOutBulkAssignResponseOptOuts);
        }

        /// <summary>
        /// Returns true if OptOutBulkAssignResponseOptOuts instances are equal
        /// </summary>
        /// <param name="input">Instance of OptOutBulkAssignResponseOptOuts to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OptOutBulkAssignResponseOptOuts input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Successful == input.Successful ||
                    this.Successful != null &&
                    input.Successful != null &&
                    this.Successful.SequenceEqual(input.Successful)
                ) && 
                (
                    this.Failed == input.Failed ||
                    this.Failed != null &&
                    input.Failed != null &&
                    this.Failed.SequenceEqual(input.Failed)
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
                if (this.Successful != null)
                    hashCode = hashCode * 59 + this.Successful.GetHashCode();
                if (this.Failed != null)
                    hashCode = hashCode * 59 + this.Failed.GetHashCode();
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
