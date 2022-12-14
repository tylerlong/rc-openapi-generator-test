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
    /// Information on a task for updating multiple extensions
    /// </summary>
    [DataContract]
    public partial class ExtensionBulkUpdateTaskResource :  IEquatable<ExtensionBulkUpdateTaskResource>, IValidatableObject
    {
        /// <summary>
        /// Task status
        /// </summary>
        /// <value>Task status</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Accepted for value: Accepted
            /// </summary>
            [EnumMember(Value = "Accepted")]
            Accepted = 1,

            /// <summary>
            /// Enum InProgress for value: InProgress
            /// </summary>
            [EnumMember(Value = "InProgress")]
            InProgress = 2,

            /// <summary>
            /// Enum Completed for value: Completed
            /// </summary>
            [EnumMember(Value = "Completed")]
            Completed = 3,

            /// <summary>
            /// Enum Failed for value: Failed
            /// </summary>
            [EnumMember(Value = "Failed")]
            Failed = 4

        }

        /// <summary>
        /// Task status
        /// </summary>
        /// <value>Task status</value>
        [DataMember(Name="status", EmitDefaultValue=true)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExtensionBulkUpdateTaskResource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ExtensionBulkUpdateTaskResource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExtensionBulkUpdateTaskResource" /> class.
        /// </summary>
        /// <param name="uri">Link to a task resource (required).</param>
        /// <param name="id">Internal identifier of a task (required).</param>
        /// <param name="status">Task status (required).</param>
        /// <param name="creationTime">Task creation datetime (required).</param>
        /// <param name="lastModifiedTime">Task latest update datetime (required).</param>
        /// <param name="result">result.</param>
        public ExtensionBulkUpdateTaskResource(string uri = default(string), string id = default(string), StatusEnum status = default(StatusEnum), string creationTime = default(string), string lastModifiedTime = default(string), ExtensionBulkUpdateTaskResult result = default(ExtensionBulkUpdateTaskResult))
        {
            // to ensure "uri" is required (not null)
            if (uri == null)
            {
                throw new InvalidDataException("uri is a required property for ExtensionBulkUpdateTaskResource and cannot be null");
            }
            else
            {
                this.Uri = uri;
            }

            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for ExtensionBulkUpdateTaskResource and cannot be null");
            }
            else
            {
                this.Id = id;
            }

            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new InvalidDataException("status is a required property for ExtensionBulkUpdateTaskResource and cannot be null");
            }
            else
            {
                this.Status = status;
            }

            // to ensure "creationTime" is required (not null)
            if (creationTime == null)
            {
                throw new InvalidDataException("creationTime is a required property for ExtensionBulkUpdateTaskResource and cannot be null");
            }
            else
            {
                this.CreationTime = creationTime;
            }

            // to ensure "lastModifiedTime" is required (not null)
            if (lastModifiedTime == null)
            {
                throw new InvalidDataException("lastModifiedTime is a required property for ExtensionBulkUpdateTaskResource and cannot be null");
            }
            else
            {
                this.LastModifiedTime = lastModifiedTime;
            }

            this.Result = result;
        }

        /// <summary>
        /// Link to a task resource
        /// </summary>
        /// <value>Link to a task resource</value>
        [DataMember(Name="uri", EmitDefaultValue=true)]
        public string Uri { get; set; }

        /// <summary>
        /// Internal identifier of a task
        /// </summary>
        /// <value>Internal identifier of a task</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public string Id { get; set; }


        /// <summary>
        /// Task creation datetime
        /// </summary>
        /// <value>Task creation datetime</value>
        [DataMember(Name="creationTime", EmitDefaultValue=true)]
        public string CreationTime { get; set; }

        /// <summary>
        /// Task latest update datetime
        /// </summary>
        /// <value>Task latest update datetime</value>
        [DataMember(Name="lastModifiedTime", EmitDefaultValue=true)]
        public string LastModifiedTime { get; set; }

        /// <summary>
        /// Gets or Sets Result
        /// </summary>
        [DataMember(Name="result", EmitDefaultValue=false)]
        public ExtensionBulkUpdateTaskResult Result { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExtensionBulkUpdateTaskResource {\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  CreationTime: ").Append(CreationTime).Append("\n");
            sb.Append("  LastModifiedTime: ").Append(LastModifiedTime).Append("\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
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
            return this.Equals(input as ExtensionBulkUpdateTaskResource);
        }

        /// <summary>
        /// Returns true if ExtensionBulkUpdateTaskResource instances are equal
        /// </summary>
        /// <param name="input">Instance of ExtensionBulkUpdateTaskResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExtensionBulkUpdateTaskResource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Uri == input.Uri ||
                    (this.Uri != null &&
                    this.Uri.Equals(input.Uri))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.CreationTime == input.CreationTime ||
                    (this.CreationTime != null &&
                    this.CreationTime.Equals(input.CreationTime))
                ) && 
                (
                    this.LastModifiedTime == input.LastModifiedTime ||
                    (this.LastModifiedTime != null &&
                    this.LastModifiedTime.Equals(input.LastModifiedTime))
                ) && 
                (
                    this.Result == input.Result ||
                    (this.Result != null &&
                    this.Result.Equals(input.Result))
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
                if (this.Uri != null)
                    hashCode = hashCode * 59 + this.Uri.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.CreationTime != null)
                    hashCode = hashCode * 59 + this.CreationTime.GetHashCode();
                if (this.LastModifiedTime != null)
                    hashCode = hashCode * 59 + this.LastModifiedTime.GetHashCode();
                if (this.Result != null)
                    hashCode = hashCode * 59 + this.Result.GetHashCode();
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
