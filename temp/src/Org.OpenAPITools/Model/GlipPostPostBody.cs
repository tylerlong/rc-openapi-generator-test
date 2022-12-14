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
    /// Post data. At least one attribute should be provided (text or attachments)
    /// </summary>
    [DataContract]
    public partial class GlipPostPostBody :  IEquatable<GlipPostPostBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlipPostPostBody" /> class.
        /// </summary>
        /// <param name="text">Text of a post. Maximum length is 10000 symbols. Mentions can be added in .md format &#x60;![:Type](id)&#x60;.</param>
        /// <param name="attachments">Identifier(s) of attachments. Maximum number of attachments is 25.</param>
        public GlipPostPostBody(string text = default(string), List<GlipAttachmentInfoRequest> attachments = default(List<GlipAttachmentInfoRequest>))
        {
            this.Text = text;
            this.Attachments = attachments;
        }

        /// <summary>
        /// Text of a post. Maximum length is 10000 symbols. Mentions can be added in .md format &#x60;![:Type](id)&#x60;
        /// </summary>
        /// <value>Text of a post. Maximum length is 10000 symbols. Mentions can be added in .md format &#x60;![:Type](id)&#x60;</value>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }

        /// <summary>
        /// Identifier(s) of attachments. Maximum number of attachments is 25
        /// </summary>
        /// <value>Identifier(s) of attachments. Maximum number of attachments is 25</value>
        [DataMember(Name="attachments", EmitDefaultValue=false)]
        public List<GlipAttachmentInfoRequest> Attachments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GlipPostPostBody {\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
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
            return this.Equals(input as GlipPostPostBody);
        }

        /// <summary>
        /// Returns true if GlipPostPostBody instances are equal
        /// </summary>
        /// <param name="input">Instance of GlipPostPostBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GlipPostPostBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
                ) && 
                (
                    this.Attachments == input.Attachments ||
                    this.Attachments != null &&
                    input.Attachments != null &&
                    this.Attachments.SequenceEqual(input.Attachments)
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
                if (this.Text != null)
                    hashCode = hashCode * 59 + this.Text.GetHashCode();
                if (this.Attachments != null)
                    hashCode = hashCode * 59 + this.Attachments.GetHashCode();
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
