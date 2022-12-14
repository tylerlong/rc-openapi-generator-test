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
    /// Information about the author
    /// </summary>
    [DataContract]
    public partial class GlipMessageAttachmentAuthorInfo :  IEquatable<GlipMessageAttachmentAuthorInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlipMessageAttachmentAuthorInfo" /> class.
        /// </summary>
        /// <param name="name">Name of a message author.</param>
        /// <param name="uri">Link to an author&#39;s name.</param>
        /// <param name="iconUri">Link to an image displayed to the left of an author&#39;s name; sized 82x82px.</param>
        public GlipMessageAttachmentAuthorInfo(string name = default(string), string uri = default(string), string iconUri = default(string))
        {
            this.Name = name;
            this.Uri = uri;
            this.IconUri = iconUri;
        }

        /// <summary>
        /// Name of a message author
        /// </summary>
        /// <value>Name of a message author</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Link to an author&#39;s name
        /// </summary>
        /// <value>Link to an author&#39;s name</value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }

        /// <summary>
        /// Link to an image displayed to the left of an author&#39;s name; sized 82x82px
        /// </summary>
        /// <value>Link to an image displayed to the left of an author&#39;s name; sized 82x82px</value>
        [DataMember(Name="iconUri", EmitDefaultValue=false)]
        public string IconUri { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GlipMessageAttachmentAuthorInfo {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  IconUri: ").Append(IconUri).Append("\n");
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
            return this.Equals(input as GlipMessageAttachmentAuthorInfo);
        }

        /// <summary>
        /// Returns true if GlipMessageAttachmentAuthorInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of GlipMessageAttachmentAuthorInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GlipMessageAttachmentAuthorInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Uri == input.Uri ||
                    (this.Uri != null &&
                    this.Uri.Equals(input.Uri))
                ) && 
                (
                    this.IconUri == input.IconUri ||
                    (this.IconUri != null &&
                    this.IconUri.Equals(input.IconUri))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Uri != null)
                    hashCode = hashCode * 59 + this.Uri.GetHashCode();
                if (this.IconUri != null)
                    hashCode = hashCode * 59 + this.IconUri.GetHashCode();
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
