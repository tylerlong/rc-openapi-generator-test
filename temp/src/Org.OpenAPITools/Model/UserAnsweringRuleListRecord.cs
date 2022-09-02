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
    /// UserAnsweringRuleListRecord
    /// </summary>
    [DataContract]
    public partial class UserAnsweringRuleListRecord :  IEquatable<UserAnsweringRuleListRecord>, IValidatableObject
    {
        /// <summary>
        /// Type of an answering rule
        /// </summary>
        /// <value>Type of an answering rule</value>
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
        /// Type of an answering rule
        /// </summary>
        /// <value>Type of an answering rule</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserAnsweringRuleListRecord" /> class.
        /// </summary>
        /// <param name="uri">Canonical URI to an answering rule resource.</param>
        /// <param name="id">Internal identifier of an answering rule.</param>
        /// <param name="type">Type of an answering rule.</param>
        /// <param name="name">Name of an answering rule specified by user.</param>
        /// <param name="enabled">Specifies if an answering rule is active or inactive.</param>
        /// <param name="sharedLines">sharedLines.</param>
        public UserAnsweringRuleListRecord(string uri = default(string), string id = default(string), TypeEnum? type = default(TypeEnum?), string name = default(string), bool enabled = default(bool), SharedLinesInfo sharedLines = default(SharedLinesInfo))
        {
            this.Uri = uri;
            this.Id = id;
            this.Type = type;
            this.Name = name;
            this.Enabled = enabled;
            this.SharedLines = sharedLines;
        }

        /// <summary>
        /// Canonical URI to an answering rule resource
        /// </summary>
        /// <value>Canonical URI to an answering rule resource</value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }

        /// <summary>
        /// Internal identifier of an answering rule
        /// </summary>
        /// <value>Internal identifier of an answering rule</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }


        /// <summary>
        /// Name of an answering rule specified by user
        /// </summary>
        /// <value>Name of an answering rule specified by user</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies if an answering rule is active or inactive
        /// </summary>
        /// <value>Specifies if an answering rule is active or inactive</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Gets or Sets SharedLines
        /// </summary>
        [DataMember(Name="sharedLines", EmitDefaultValue=false)]
        public SharedLinesInfo SharedLines { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserAnsweringRuleListRecord {\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  SharedLines: ").Append(SharedLines).Append("\n");
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
            return this.Equals(input as UserAnsweringRuleListRecord);
        }

        /// <summary>
        /// Returns true if UserAnsweringRuleListRecord instances are equal
        /// </summary>
        /// <param name="input">Instance of UserAnsweringRuleListRecord to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserAnsweringRuleListRecord input)
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
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
                ) && 
                (
                    this.SharedLines == input.SharedLines ||
                    (this.SharedLines != null &&
                    this.SharedLines.Equals(input.SharedLines))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Enabled != null)
                    hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.SharedLines != null)
                    hashCode = hashCode * 59 + this.SharedLines.GetHashCode();
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