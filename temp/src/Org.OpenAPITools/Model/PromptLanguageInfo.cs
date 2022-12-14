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
    /// For &#39;TextToSpeech&#39; mode only. Prompt language metadata
    /// </summary>
    [DataContract]
    public partial class PromptLanguageInfo :  IEquatable<PromptLanguageInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PromptLanguageInfo" /> class.
        /// </summary>
        /// <param name="uri">Link to a prompt language.</param>
        /// <param name="id">Internal identifier of a language.</param>
        /// <param name="name">Language name.</param>
        /// <param name="localeCode">Language locale code.</param>
        public PromptLanguageInfo(string uri = default(string), string id = default(string), string name = default(string), string localeCode = default(string))
        {
            this.Uri = uri;
            this.Id = id;
            this.Name = name;
            this.LocaleCode = localeCode;
        }

        /// <summary>
        /// Link to a prompt language
        /// </summary>
        /// <value>Link to a prompt language</value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }

        /// <summary>
        /// Internal identifier of a language
        /// </summary>
        /// <value>Internal identifier of a language</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Language name
        /// </summary>
        /// <value>Language name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Language locale code
        /// </summary>
        /// <value>Language locale code</value>
        [DataMember(Name="localeCode", EmitDefaultValue=false)]
        public string LocaleCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PromptLanguageInfo {\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  LocaleCode: ").Append(LocaleCode).Append("\n");
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
            return this.Equals(input as PromptLanguageInfo);
        }

        /// <summary>
        /// Returns true if PromptLanguageInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of PromptLanguageInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PromptLanguageInfo input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.LocaleCode == input.LocaleCode ||
                    (this.LocaleCode != null &&
                    this.LocaleCode.Equals(input.LocaleCode))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.LocaleCode != null)
                    hashCode = hashCode * 59 + this.LocaleCode.GetHashCode();
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
