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
    /// BlockedCallerGreetingInfo
    /// </summary>
    [DataContract]
    public partial class BlockedCallerGreetingInfo :  IEquatable<BlockedCallerGreetingInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BlockedCallerGreetingInfo" /> class.
        /// </summary>
        /// <param name="type">Type of a greeting.</param>
        /// <param name="preset">preset.</param>
        public BlockedCallerGreetingInfo(string type = default(string), PresetInfo preset = default(PresetInfo))
        {
            this.Type = type;
            this.Preset = preset;
        }

        /// <summary>
        /// Type of a greeting
        /// </summary>
        /// <value>Type of a greeting</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Preset
        /// </summary>
        [DataMember(Name="preset", EmitDefaultValue=false)]
        public PresetInfo Preset { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BlockedCallerGreetingInfo {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Preset: ").Append(Preset).Append("\n");
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
            return this.Equals(input as BlockedCallerGreetingInfo);
        }

        /// <summary>
        /// Returns true if BlockedCallerGreetingInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of BlockedCallerGreetingInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BlockedCallerGreetingInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Preset == input.Preset ||
                    (this.Preset != null &&
                    this.Preset.Equals(input.Preset))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Preset != null)
                    hashCode = hashCode * 59 + this.Preset.GetHashCode();
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
