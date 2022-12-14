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
    /// CallRecordingExtensionResource
    /// </summary>
    [DataContract]
    public partial class CallRecordingExtensionResource :  IEquatable<CallRecordingExtensionResource>, IValidatableObject
    {
        /// <summary>
        /// Direction of call
        /// </summary>
        /// <value>Direction of call</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CallDirectionEnum
        {
            /// <summary>
            /// Enum Outbound for value: Outbound
            /// </summary>
            [EnumMember(Value = "Outbound")]
            Outbound = 1,

            /// <summary>
            /// Enum Inbound for value: Inbound
            /// </summary>
            [EnumMember(Value = "Inbound")]
            Inbound = 2,

            /// <summary>
            /// Enum All for value: All
            /// </summary>
            [EnumMember(Value = "All")]
            All = 3

        }

        /// <summary>
        /// Direction of call
        /// </summary>
        /// <value>Direction of call</value>
        [DataMember(Name="callDirection", EmitDefaultValue=false)]
        public CallDirectionEnum? CallDirection { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CallRecordingExtensionResource" /> class.
        /// </summary>
        /// <param name="id">Internal identifier of an extension.</param>
        /// <param name="uri">uri.</param>
        /// <param name="extensionNumber">extensionNumber.</param>
        /// <param name="type">type.</param>
        /// <param name="callDirection">Direction of call.</param>
        public CallRecordingExtensionResource(string id = default(string), string uri = default(string), string extensionNumber = default(string), string type = default(string), CallDirectionEnum? callDirection = default(CallDirectionEnum?))
        {
            this.Id = id;
            this.Uri = uri;
            this.ExtensionNumber = extensionNumber;
            this.Type = type;
            this.CallDirection = callDirection;
        }

        /// <summary>
        /// Internal identifier of an extension
        /// </summary>
        /// <value>Internal identifier of an extension</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Uri
        /// </summary>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }

        /// <summary>
        /// Gets or Sets ExtensionNumber
        /// </summary>
        [DataMember(Name="extensionNumber", EmitDefaultValue=false)]
        public string ExtensionNumber { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CallRecordingExtensionResource {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  ExtensionNumber: ").Append(ExtensionNumber).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  CallDirection: ").Append(CallDirection).Append("\n");
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
            return this.Equals(input as CallRecordingExtensionResource);
        }

        /// <summary>
        /// Returns true if CallRecordingExtensionResource instances are equal
        /// </summary>
        /// <param name="input">Instance of CallRecordingExtensionResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CallRecordingExtensionResource input)
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
                    this.Uri == input.Uri ||
                    (this.Uri != null &&
                    this.Uri.Equals(input.Uri))
                ) && 
                (
                    this.ExtensionNumber == input.ExtensionNumber ||
                    (this.ExtensionNumber != null &&
                    this.ExtensionNumber.Equals(input.ExtensionNumber))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.CallDirection == input.CallDirection ||
                    (this.CallDirection != null &&
                    this.CallDirection.Equals(input.CallDirection))
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
                if (this.Uri != null)
                    hashCode = hashCode * 59 + this.Uri.GetHashCode();
                if (this.ExtensionNumber != null)
                    hashCode = hashCode * 59 + this.ExtensionNumber.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.CallDirection != null)
                    hashCode = hashCode * 59 + this.CallDirection.GetHashCode();
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
