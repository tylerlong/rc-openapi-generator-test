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
    /// TelephonyLockedSettings
    /// </summary>
    [DataContract]
    public partial class TelephonyLockedSettings :  IEquatable<TelephonyLockedSettings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TelephonyLockedSettings" /> class.
        /// </summary>
        /// <param name="thirdPartyAudio">ThirdParty audio option.</param>
        public TelephonyLockedSettings(bool thirdPartyAudio = default(bool))
        {
            this.ThirdPartyAudio = thirdPartyAudio;
        }

        /// <summary>
        /// ThirdParty audio option
        /// </summary>
        /// <value>ThirdParty audio option</value>
        [DataMember(Name="thirdPartyAudio", EmitDefaultValue=false)]
        public bool ThirdPartyAudio { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TelephonyLockedSettings {\n");
            sb.Append("  ThirdPartyAudio: ").Append(ThirdPartyAudio).Append("\n");
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
            return this.Equals(input as TelephonyLockedSettings);
        }

        /// <summary>
        /// Returns true if TelephonyLockedSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of TelephonyLockedSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TelephonyLockedSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ThirdPartyAudio == input.ThirdPartyAudio ||
                    (this.ThirdPartyAudio != null &&
                    this.ThirdPartyAudio.Equals(input.ThirdPartyAudio))
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
                if (this.ThirdPartyAudio != null)
                    hashCode = hashCode * 59 + this.ThirdPartyAudio.GetHashCode();
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
