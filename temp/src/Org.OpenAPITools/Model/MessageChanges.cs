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
    /// MessageChanges
    /// </summary>
    [DataContract]
    public partial class MessageChanges :  IEquatable<MessageChanges>, IValidatableObject
    {
        /// <summary>
        /// Message type
        /// </summary>
        /// <value>Message type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Voicemail for value: Voicemail
            /// </summary>
            [EnumMember(Value = "Voicemail")]
            Voicemail = 1,

            /// <summary>
            /// Enum SMS for value: SMS
            /// </summary>
            [EnumMember(Value = "SMS")]
            SMS = 2,

            /// <summary>
            /// Enum Fax for value: Fax
            /// </summary>
            [EnumMember(Value = "Fax")]
            Fax = 3,

            /// <summary>
            /// Enum Pager for value: Pager
            /// </summary>
            [EnumMember(Value = "Pager")]
            Pager = 4

        }

        /// <summary>
        /// Message type
        /// </summary>
        /// <value>Message type</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageChanges" /> class.
        /// </summary>
        /// <param name="type">Message type.</param>
        /// <param name="newCount">The number of new messages. Can be omitted if the value is zero.</param>
        /// <param name="updatedCount">The number of updated messages. Can be omitted if the value is zero.</param>
        public MessageChanges(TypeEnum? type = default(TypeEnum?), int newCount = default(int), int updatedCount = default(int))
        {
            this.Type = type;
            this.NewCount = newCount;
            this.UpdatedCount = updatedCount;
        }


        /// <summary>
        /// The number of new messages. Can be omitted if the value is zero
        /// </summary>
        /// <value>The number of new messages. Can be omitted if the value is zero</value>
        [DataMember(Name="newCount", EmitDefaultValue=false)]
        public int NewCount { get; set; }

        /// <summary>
        /// The number of updated messages. Can be omitted if the value is zero
        /// </summary>
        /// <value>The number of updated messages. Can be omitted if the value is zero</value>
        [DataMember(Name="updatedCount", EmitDefaultValue=false)]
        public int UpdatedCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessageChanges {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  NewCount: ").Append(NewCount).Append("\n");
            sb.Append("  UpdatedCount: ").Append(UpdatedCount).Append("\n");
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
            return this.Equals(input as MessageChanges);
        }

        /// <summary>
        /// Returns true if MessageChanges instances are equal
        /// </summary>
        /// <param name="input">Instance of MessageChanges to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessageChanges input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.NewCount == input.NewCount ||
                    (this.NewCount != null &&
                    this.NewCount.Equals(input.NewCount))
                ) && 
                (
                    this.UpdatedCount == input.UpdatedCount ||
                    (this.UpdatedCount != null &&
                    this.UpdatedCount.Equals(input.UpdatedCount))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.NewCount != null)
                    hashCode = hashCode * 59 + this.NewCount.GetHashCode();
                if (this.UpdatedCount != null)
                    hashCode = hashCode * 59 + this.UpdatedCount.GetHashCode();
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
