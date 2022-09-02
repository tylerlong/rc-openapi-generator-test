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
    /// Data for all calls
    /// </summary>
    [DataContract]
    public partial class AllCalls :  IEquatable<AllCalls>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets ValueType
        /// </summary>
        [DataMember(Name="valueType", EmitDefaultValue=true)]
        public ValueType ValueType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AllCalls" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AllCalls() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AllCalls" /> class.
        /// </summary>
        /// <param name="valueType">valueType (required).</param>
        /// <param name="values">Value for all calls (required).</param>
        public AllCalls(ValueType valueType = default(ValueType), double values = default(double))
        {
            // to ensure "valueType" is required (not null)
            if (valueType == null)
            {
                throw new InvalidDataException("valueType is a required property for AllCalls and cannot be null");
            }
            else
            {
                this.ValueType = valueType;
            }

            // to ensure "values" is required (not null)
            if (values == null)
            {
                throw new InvalidDataException("values is a required property for AllCalls and cannot be null");
            }
            else
            {
                this.Values = values;
            }

        }


        /// <summary>
        /// Value for all calls
        /// </summary>
        /// <value>Value for all calls</value>
        [DataMember(Name="values", EmitDefaultValue=true)]
        public double Values { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AllCalls {\n");
            sb.Append("  ValueType: ").Append(ValueType).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
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
            return this.Equals(input as AllCalls);
        }

        /// <summary>
        /// Returns true if AllCalls instances are equal
        /// </summary>
        /// <param name="input">Instance of AllCalls to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AllCalls input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ValueType == input.ValueType ||
                    (this.ValueType != null &&
                    this.ValueType.Equals(input.ValueType))
                ) && 
                (
                    this.Values == input.Values ||
                    (this.Values != null &&
                    this.Values.Equals(input.Values))
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
                if (this.ValueType != null)
                    hashCode = hashCode * 59 + this.ValueType.GetHashCode();
                if (this.Values != null)
                    hashCode = hashCode * 59 + this.Values.GetHashCode();
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
