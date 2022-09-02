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
    /// OrderBy
    /// </summary>
    [DataContract]
    public partial class OrderBy :  IEquatable<OrderBy>, IValidatableObject
    {
        /// <summary>
        /// Field name by which to sort the contacts
        /// </summary>
        /// <value>Field name by which to sort the contacts</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FieldNameEnum
        {
            /// <summary>
            /// Enum FirstName for value: firstName
            /// </summary>
            [EnumMember(Value = "firstName")]
            FirstName = 1,

            /// <summary>
            /// Enum LastName for value: lastName
            /// </summary>
            [EnumMember(Value = "lastName")]
            LastName = 2,

            /// <summary>
            /// Enum ExtensionNumber for value: extensionNumber
            /// </summary>
            [EnumMember(Value = "extensionNumber")]
            ExtensionNumber = 3,

            /// <summary>
            /// Enum PhoneNumber for value: phoneNumber
            /// </summary>
            [EnumMember(Value = "phoneNumber")]
            PhoneNumber = 4,

            /// <summary>
            /// Enum Email for value: email
            /// </summary>
            [EnumMember(Value = "email")]
            Email = 5,

            /// <summary>
            /// Enum JobTitle for value: jobTitle
            /// </summary>
            [EnumMember(Value = "jobTitle")]
            JobTitle = 6,

            /// <summary>
            /// Enum Department for value: department
            /// </summary>
            [EnumMember(Value = "department")]
            Department = 7

        }

        /// <summary>
        /// Field name by which to sort the contacts
        /// </summary>
        /// <value>Field name by which to sort the contacts</value>
        [DataMember(Name="fieldName", EmitDefaultValue=false)]
        public FieldNameEnum? FieldName { get; set; }
        /// <summary>
        /// Sorting direction
        /// </summary>
        /// <value>Sorting direction</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DirectionEnum
        {
            /// <summary>
            /// Enum Asc for value: Asc
            /// </summary>
            [EnumMember(Value = "Asc")]
            Asc = 1,

            /// <summary>
            /// Enum Desc for value: Desc
            /// </summary>
            [EnumMember(Value = "Desc")]
            Desc = 2

        }

        /// <summary>
        /// Sorting direction
        /// </summary>
        /// <value>Sorting direction</value>
        [DataMember(Name="direction", EmitDefaultValue=false)]
        public DirectionEnum? Direction { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderBy" /> class.
        /// </summary>
        /// <param name="index">Sorting priority index, starting from &#39;1&#39;. Optional if only one element in &#x60;orderBy&#x60; array is specified.</param>
        /// <param name="fieldName">Field name by which to sort the contacts.</param>
        /// <param name="direction">Sorting direction.</param>
        public OrderBy(int index = default(int), FieldNameEnum? fieldName = default(FieldNameEnum?), DirectionEnum? direction = default(DirectionEnum?))
        {
            this.Index = index;
            this.FieldName = fieldName;
            this.Direction = direction;
        }

        /// <summary>
        /// Sorting priority index, starting from &#39;1&#39;. Optional if only one element in &#x60;orderBy&#x60; array is specified
        /// </summary>
        /// <value>Sorting priority index, starting from &#39;1&#39;. Optional if only one element in &#x60;orderBy&#x60; array is specified</value>
        [DataMember(Name="index", EmitDefaultValue=false)]
        public int Index { get; set; }



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderBy {\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  FieldName: ").Append(FieldName).Append("\n");
            sb.Append("  Direction: ").Append(Direction).Append("\n");
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
            return this.Equals(input as OrderBy);
        }

        /// <summary>
        /// Returns true if OrderBy instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderBy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderBy input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Index == input.Index ||
                    (this.Index != null &&
                    this.Index.Equals(input.Index))
                ) && 
                (
                    this.FieldName == input.FieldName ||
                    (this.FieldName != null &&
                    this.FieldName.Equals(input.FieldName))
                ) && 
                (
                    this.Direction == input.Direction ||
                    (this.Direction != null &&
                    this.Direction.Equals(input.Direction))
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
                if (this.Index != null)
                    hashCode = hashCode * 59 + this.Index.GetHashCode();
                if (this.FieldName != null)
                    hashCode = hashCode * 59 + this.FieldName.GetHashCode();
                if (this.Direction != null)
                    hashCode = hashCode * 59 + this.Direction.GetHashCode();
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
