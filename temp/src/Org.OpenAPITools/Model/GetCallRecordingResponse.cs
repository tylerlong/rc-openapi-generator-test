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
    /// GetCallRecordingResponse
    /// </summary>
    [DataContract]
    public partial class GetCallRecordingResponse :  IEquatable<GetCallRecordingResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCallRecordingResponse" /> class.
        /// </summary>
        /// <param name="id">Internal identifier of a call recording.</param>
        /// <param name="contentUri">Link to a call recording binary content.</param>
        /// <param name="contentType">Call recording file format. Supported format is audio/x-wav.</param>
        /// <param name="duration">Recorded call duration.</param>
        public GetCallRecordingResponse(string id = default(string), string contentUri = default(string), string contentType = default(string), int duration = default(int))
        {
            this.Id = id;
            this.ContentUri = contentUri;
            this.ContentType = contentType;
            this.Duration = duration;
        }

        /// <summary>
        /// Internal identifier of a call recording
        /// </summary>
        /// <value>Internal identifier of a call recording</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Link to a call recording binary content
        /// </summary>
        /// <value>Link to a call recording binary content</value>
        [DataMember(Name="contentUri", EmitDefaultValue=false)]
        public string ContentUri { get; set; }

        /// <summary>
        /// Call recording file format. Supported format is audio/x-wav
        /// </summary>
        /// <value>Call recording file format. Supported format is audio/x-wav</value>
        [DataMember(Name="contentType", EmitDefaultValue=false)]
        public string ContentType { get; set; }

        /// <summary>
        /// Recorded call duration
        /// </summary>
        /// <value>Recorded call duration</value>
        [DataMember(Name="duration", EmitDefaultValue=false)]
        public int Duration { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetCallRecordingResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ContentUri: ").Append(ContentUri).Append("\n");
            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
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
            return this.Equals(input as GetCallRecordingResponse);
        }

        /// <summary>
        /// Returns true if GetCallRecordingResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetCallRecordingResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCallRecordingResponse input)
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
                    this.ContentUri == input.ContentUri ||
                    (this.ContentUri != null &&
                    this.ContentUri.Equals(input.ContentUri))
                ) && 
                (
                    this.ContentType == input.ContentType ||
                    (this.ContentType != null &&
                    this.ContentType.Equals(input.ContentType))
                ) && 
                (
                    this.Duration == input.Duration ||
                    (this.Duration != null &&
                    this.Duration.Equals(input.Duration))
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
                if (this.ContentUri != null)
                    hashCode = hashCode * 59 + this.ContentUri.GetHashCode();
                if (this.ContentType != null)
                    hashCode = hashCode * 59 + this.ContentType.GetHashCode();
                if (this.Duration != null)
                    hashCode = hashCode * 59 + this.Duration.GetHashCode();
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
