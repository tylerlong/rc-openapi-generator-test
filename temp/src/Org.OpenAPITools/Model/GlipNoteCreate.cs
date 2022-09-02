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
    /// GlipNoteCreate
    /// </summary>
    [DataContract]
    public partial class GlipNoteCreate :  IEquatable<GlipNoteCreate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlipNoteCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GlipNoteCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GlipNoteCreate" /> class.
        /// </summary>
        /// <param name="title">Title of a note. Max allowed length is 250 characters (required).</param>
        /// <param name="body">Contents of a note; HTML-markuped text. Max allowed length is 1048576 characters (1 Mb)..</param>
        public GlipNoteCreate(string title = default(string), string body = default(string))
        {
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new InvalidDataException("title is a required property for GlipNoteCreate and cannot be null");
            }
            else
            {
                this.Title = title;
            }

            this.Body = body;
        }

        /// <summary>
        /// Title of a note. Max allowed length is 250 characters
        /// </summary>
        /// <value>Title of a note. Max allowed length is 250 characters</value>
        [DataMember(Name="title", EmitDefaultValue=true)]
        public string Title { get; set; }

        /// <summary>
        /// Contents of a note; HTML-markuped text. Max allowed length is 1048576 characters (1 Mb).
        /// </summary>
        /// <value>Contents of a note; HTML-markuped text. Max allowed length is 1048576 characters (1 Mb).</value>
        [DataMember(Name="body", EmitDefaultValue=false)]
        public string Body { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GlipNoteCreate {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
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
            return this.Equals(input as GlipNoteCreate);
        }

        /// <summary>
        /// Returns true if GlipNoteCreate instances are equal
        /// </summary>
        /// <param name="input">Instance of GlipNoteCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GlipNoteCreate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
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
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Body != null)
                    hashCode = hashCode * 59 + this.Body.GetHashCode();
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