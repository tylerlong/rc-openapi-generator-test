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
    /// ListCompanyAnsweringRuleInfo
    /// </summary>
    [DataContract]
    public partial class ListCompanyAnsweringRuleInfo :  IEquatable<ListCompanyAnsweringRuleInfo>, IValidatableObject
    {
        /// <summary>
        /// Type of an answering rule, the default value is &#39;Custom&#39; &#x3D; [&#39;BusinessHours&#39;, &#39;AfterHours&#39;, &#39;Custom&#39;]
        /// </summary>
        /// <value>Type of an answering rule, the default value is &#39;Custom&#39; &#x3D; [&#39;BusinessHours&#39;, &#39;AfterHours&#39;, &#39;Custom&#39;]</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum BusinessHours for value: BusinessHours
            /// </summary>
            [EnumMember(Value = "BusinessHours")]
            BusinessHours = 1,

            /// <summary>
            /// Enum AfterHours for value: AfterHours
            /// </summary>
            [EnumMember(Value = "AfterHours")]
            AfterHours = 2,

            /// <summary>
            /// Enum Custom for value: Custom
            /// </summary>
            [EnumMember(Value = "Custom")]
            Custom = 3

        }

        /// <summary>
        /// Type of an answering rule, the default value is &#39;Custom&#39; &#x3D; [&#39;BusinessHours&#39;, &#39;AfterHours&#39;, &#39;Custom&#39;]
        /// </summary>
        /// <value>Type of an answering rule, the default value is &#39;Custom&#39; &#x3D; [&#39;BusinessHours&#39;, &#39;AfterHours&#39;, &#39;Custom&#39;]</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListCompanyAnsweringRuleInfo" /> class.
        /// </summary>
        /// <param name="id">Internal identifier of an answering rule.</param>
        /// <param name="uri">Canonical URI of an answering rule.</param>
        /// <param name="enabled">Specifies if the rule is active or inactive. The default value is &#39;True&#39; (default to true).</param>
        /// <param name="type">Type of an answering rule, the default value is &#39;Custom&#39; &#x3D; [&#39;BusinessHours&#39;, &#39;AfterHours&#39;, &#39;Custom&#39;].</param>
        /// <param name="name">Name of an answering rule specified by user. Max number of symbols is 30. The default value is &#39;My Rule N&#39; where &#39;N&#39; is the first free number.</param>
        /// <param name="calledNumbers">Answering rules are applied when calling to selected number(s).</param>
        /// <param name="extension">extension.</param>
        public ListCompanyAnsweringRuleInfo(string id = default(string), string uri = default(string), bool enabled = true, TypeEnum? type = default(TypeEnum?), string name = default(string), List<CalledNumberInfo> calledNumbers = default(List<CalledNumberInfo>), CompanyAnsweringRuleExtensionInfo extension = default(CompanyAnsweringRuleExtensionInfo))
        {
            this.Id = id;
            this.Uri = uri;
            // use default value if no "enabled" provided
            if (enabled == null)
            {
                this.Enabled = true;
            }
            else
            {
                this.Enabled = enabled;
            }
            this.Type = type;
            this.Name = name;
            this.CalledNumbers = calledNumbers;
            this.Extension = extension;
        }

        /// <summary>
        /// Internal identifier of an answering rule
        /// </summary>
        /// <value>Internal identifier of an answering rule</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Canonical URI of an answering rule
        /// </summary>
        /// <value>Canonical URI of an answering rule</value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }

        /// <summary>
        /// Specifies if the rule is active or inactive. The default value is &#39;True&#39;
        /// </summary>
        /// <value>Specifies if the rule is active or inactive. The default value is &#39;True&#39;</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool Enabled { get; set; }


        /// <summary>
        /// Name of an answering rule specified by user. Max number of symbols is 30. The default value is &#39;My Rule N&#39; where &#39;N&#39; is the first free number
        /// </summary>
        /// <value>Name of an answering rule specified by user. Max number of symbols is 30. The default value is &#39;My Rule N&#39; where &#39;N&#39; is the first free number</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Answering rules are applied when calling to selected number(s)
        /// </summary>
        /// <value>Answering rules are applied when calling to selected number(s)</value>
        [DataMember(Name="calledNumbers", EmitDefaultValue=false)]
        public List<CalledNumberInfo> CalledNumbers { get; set; }

        /// <summary>
        /// Gets or Sets Extension
        /// </summary>
        [DataMember(Name="extension", EmitDefaultValue=false)]
        public CompanyAnsweringRuleExtensionInfo Extension { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListCompanyAnsweringRuleInfo {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CalledNumbers: ").Append(CalledNumbers).Append("\n");
            sb.Append("  Extension: ").Append(Extension).Append("\n");
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
            return this.Equals(input as ListCompanyAnsweringRuleInfo);
        }

        /// <summary>
        /// Returns true if ListCompanyAnsweringRuleInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ListCompanyAnsweringRuleInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListCompanyAnsweringRuleInfo input)
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
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.CalledNumbers == input.CalledNumbers ||
                    this.CalledNumbers != null &&
                    input.CalledNumbers != null &&
                    this.CalledNumbers.SequenceEqual(input.CalledNumbers)
                ) && 
                (
                    this.Extension == input.Extension ||
                    (this.Extension != null &&
                    this.Extension.Equals(input.Extension))
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
                if (this.Enabled != null)
                    hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.CalledNumbers != null)
                    hashCode = hashCode * 59 + this.CalledNumbers.GetHashCode();
                if (this.Extension != null)
                    hashCode = hashCode * 59 + this.Extension.GetHashCode();
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