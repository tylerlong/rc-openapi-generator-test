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
    /// CallRecordingExtensionInfo
    /// </summary>
    [DataContract]
    public partial class CallRecordingExtensionInfo :  IEquatable<CallRecordingExtensionInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CallRecordingExtensionInfo" /> class.
        /// </summary>
        /// <param name="id">Internal identifier of an extension.</param>
        /// <param name="uri">Link to an extension resource.</param>
        /// <param name="extensionNumber">Number of an extension.</param>
        /// <param name="name">Name of an extension.</param>
        public CallRecordingExtensionInfo(string id = default(string), string uri = default(string), string extensionNumber = default(string), string name = default(string))
        {
            this.Id = id;
            this.Uri = uri;
            this.ExtensionNumber = extensionNumber;
            this.Name = name;
        }

        /// <summary>
        /// Internal identifier of an extension
        /// </summary>
        /// <value>Internal identifier of an extension</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Link to an extension resource
        /// </summary>
        /// <value>Link to an extension resource</value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }

        /// <summary>
        /// Number of an extension
        /// </summary>
        /// <value>Number of an extension</value>
        [DataMember(Name="extensionNumber", EmitDefaultValue=false)]
        public string ExtensionNumber { get; set; }

        /// <summary>
        /// Name of an extension
        /// </summary>
        /// <value>Name of an extension</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CallRecordingExtensionInfo {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  ExtensionNumber: ").Append(ExtensionNumber).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as CallRecordingExtensionInfo);
        }

        /// <summary>
        /// Returns true if CallRecordingExtensionInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of CallRecordingExtensionInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CallRecordingExtensionInfo input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
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