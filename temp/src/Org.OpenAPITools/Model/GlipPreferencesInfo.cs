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
    /// GlipPreferencesInfo
    /// </summary>
    [DataContract]
    public partial class GlipPreferencesInfo :  IEquatable<GlipPreferencesInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlipPreferencesInfo" /> class.
        /// </summary>
        /// <param name="chats">chats.</param>
        public GlipPreferencesInfo(GlipPreferencesChats chats = default(GlipPreferencesChats))
        {
            this.Chats = chats;
        }

        /// <summary>
        /// Gets or Sets Chats
        /// </summary>
        [DataMember(Name="chats", EmitDefaultValue=false)]
        public GlipPreferencesChats Chats { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GlipPreferencesInfo {\n");
            sb.Append("  Chats: ").Append(Chats).Append("\n");
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
            return this.Equals(input as GlipPreferencesInfo);
        }

        /// <summary>
        /// Returns true if GlipPreferencesInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of GlipPreferencesInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GlipPreferencesInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Chats == input.Chats ||
                    (this.Chats != null &&
                    this.Chats.Equals(input.Chats))
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
                if (this.Chats != null)
                    hashCode = hashCode * 59 + this.Chats.GetHashCode();
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
