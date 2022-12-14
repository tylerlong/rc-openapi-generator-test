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
    /// TelephonyUserMeetingSettings
    /// </summary>
    [DataContract]
    public partial class TelephonyUserMeetingSettings :  IEquatable<TelephonyUserMeetingSettings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TelephonyUserMeetingSettings" /> class.
        /// </summary>
        /// <param name="thirdPartyAudio">ThirdParty audio option.</param>
        /// <param name="audioConferenceInfo">Users can join the meeting using the existing 3rd party audio configuration.</param>
        public TelephonyUserMeetingSettings(bool thirdPartyAudio = default(bool), bool audioConferenceInfo = default(bool))
        {
            this.ThirdPartyAudio = thirdPartyAudio;
            this.AudioConferenceInfo = audioConferenceInfo;
        }

        /// <summary>
        /// ThirdParty audio option
        /// </summary>
        /// <value>ThirdParty audio option</value>
        [DataMember(Name="thirdPartyAudio", EmitDefaultValue=false)]
        public bool ThirdPartyAudio { get; set; }

        /// <summary>
        /// Users can join the meeting using the existing 3rd party audio configuration
        /// </summary>
        /// <value>Users can join the meeting using the existing 3rd party audio configuration</value>
        [DataMember(Name="audioConferenceInfo", EmitDefaultValue=false)]
        public bool AudioConferenceInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TelephonyUserMeetingSettings {\n");
            sb.Append("  ThirdPartyAudio: ").Append(ThirdPartyAudio).Append("\n");
            sb.Append("  AudioConferenceInfo: ").Append(AudioConferenceInfo).Append("\n");
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
            return this.Equals(input as TelephonyUserMeetingSettings);
        }

        /// <summary>
        /// Returns true if TelephonyUserMeetingSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of TelephonyUserMeetingSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TelephonyUserMeetingSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ThirdPartyAudio == input.ThirdPartyAudio ||
                    (this.ThirdPartyAudio != null &&
                    this.ThirdPartyAudio.Equals(input.ThirdPartyAudio))
                ) && 
                (
                    this.AudioConferenceInfo == input.AudioConferenceInfo ||
                    (this.AudioConferenceInfo != null &&
                    this.AudioConferenceInfo.Equals(input.AudioConferenceInfo))
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
                if (this.AudioConferenceInfo != null)
                    hashCode = hashCode * 59 + this.AudioConferenceInfo.GetHashCode();
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
