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
    /// MeetingUserSettingsResponse
    /// </summary>
    [DataContract]
    public partial class MeetingUserSettingsResponse :  IEquatable<MeetingUserSettingsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MeetingUserSettingsResponse" /> class.
        /// </summary>
        /// <param name="recording">recording.</param>
        /// <param name="scheduleMeeting">scheduleMeeting.</param>
        /// <param name="telephony">telephony.</param>
        public MeetingUserSettingsResponse(UserMeetingRecordingSetting recording = default(UserMeetingRecordingSetting), ScheduleUserMeetingInfo scheduleMeeting = default(ScheduleUserMeetingInfo), TelephonyUserMeetingSettings telephony = default(TelephonyUserMeetingSettings))
        {
            this.Recording = recording;
            this.ScheduleMeeting = scheduleMeeting;
            this.Telephony = telephony;
        }

        /// <summary>
        /// Gets or Sets Recording
        /// </summary>
        [DataMember(Name="recording", EmitDefaultValue=false)]
        public UserMeetingRecordingSetting Recording { get; set; }

        /// <summary>
        /// Gets or Sets ScheduleMeeting
        /// </summary>
        [DataMember(Name="scheduleMeeting", EmitDefaultValue=false)]
        public ScheduleUserMeetingInfo ScheduleMeeting { get; set; }

        /// <summary>
        /// Gets or Sets Telephony
        /// </summary>
        [DataMember(Name="telephony", EmitDefaultValue=false)]
        public TelephonyUserMeetingSettings Telephony { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MeetingUserSettingsResponse {\n");
            sb.Append("  Recording: ").Append(Recording).Append("\n");
            sb.Append("  ScheduleMeeting: ").Append(ScheduleMeeting).Append("\n");
            sb.Append("  Telephony: ").Append(Telephony).Append("\n");
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
            return this.Equals(input as MeetingUserSettingsResponse);
        }

        /// <summary>
        /// Returns true if MeetingUserSettingsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of MeetingUserSettingsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MeetingUserSettingsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Recording == input.Recording ||
                    (this.Recording != null &&
                    this.Recording.Equals(input.Recording))
                ) && 
                (
                    this.ScheduleMeeting == input.ScheduleMeeting ||
                    (this.ScheduleMeeting != null &&
                    this.ScheduleMeeting.Equals(input.ScheduleMeeting))
                ) && 
                (
                    this.Telephony == input.Telephony ||
                    (this.Telephony != null &&
                    this.Telephony.Equals(input.Telephony))
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
                if (this.Recording != null)
                    hashCode = hashCode * 59 + this.Recording.GetHashCode();
                if (this.ScheduleMeeting != null)
                    hashCode = hashCode * 59 + this.ScheduleMeeting.GetHashCode();
                if (this.Telephony != null)
                    hashCode = hashCode * 59 + this.Telephony.GetHashCode();
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
