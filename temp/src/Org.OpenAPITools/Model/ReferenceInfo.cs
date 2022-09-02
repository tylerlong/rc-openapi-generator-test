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
    /// ReferenceInfo
    /// </summary>
    [DataContract]
    public partial class ReferenceInfo :  IEquatable<ReferenceInfo>, IValidatableObject
    {
        /// <summary>
        /// Type of external identifier
        /// </summary>
        /// <value>Type of external identifier</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum PartnerId for value: PartnerId
            /// </summary>
            [EnumMember(Value = "PartnerId")]
            PartnerId = 1,

            /// <summary>
            /// Enum CustomerDirectoryId for value: CustomerDirectoryId
            /// </summary>
            [EnumMember(Value = "CustomerDirectoryId")]
            CustomerDirectoryId = 2

        }

        /// <summary>
        /// Type of external identifier
        /// </summary>
        /// <value>Type of external identifier</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReferenceInfo" /> class.
        /// </summary>
        /// <param name="_ref">Non-RC identifier of an extension.</param>
        /// <param name="type">Type of external identifier.</param>
        public ReferenceInfo(string _ref = default(string), TypeEnum? type = default(TypeEnum?))
        {
            this.Ref = _ref;
            this.Type = type;
        }

        /// <summary>
        /// Non-RC identifier of an extension
        /// </summary>
        /// <value>Non-RC identifier of an extension</value>
        [DataMember(Name="ref", EmitDefaultValue=false)]
        public string Ref { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReferenceInfo {\n");
            sb.Append("  Ref: ").Append(Ref).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as ReferenceInfo);
        }

        /// <summary>
        /// Returns true if ReferenceInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ReferenceInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReferenceInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Ref == input.Ref ||
                    (this.Ref != null &&
                    this.Ref.Equals(input.Ref))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Ref != null)
                    hashCode = hashCode * 59 + this.Ref.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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