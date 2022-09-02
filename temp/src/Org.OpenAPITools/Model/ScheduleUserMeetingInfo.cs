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
    /// Scheduling meeting settings locked on account level || Settings defining how to schedule user meetingsxs
    /// </summary>
    [DataContract]
    public partial class ScheduleUserMeetingInfo :  IEquatable<ScheduleUserMeetingInfo>, IValidatableObject
    {
        /// <summary>
        /// Defines AudioOptions
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AudioOptionsEnum
        {
            /// <summary>
            /// Enum Phone for value: Phone
            /// </summary>
            [EnumMember(Value = "Phone")]
            Phone = 1,

            /// <summary>
            /// Enum ComputerAudio for value: ComputerAudio
            /// </summary>
            [EnumMember(Value = "ComputerAudio")]
            ComputerAudio = 2,

            /// <summary>
            /// Enum ThirdParty for value: ThirdParty
            /// </summary>
            [EnumMember(Value = "ThirdParty")]
            ThirdParty = 3

        }


        /// <summary>
        /// Determines how participants can join the audio channel of a meeting
        /// </summary>
        /// <value>Determines how participants can join the audio channel of a meeting</value>
        [DataMember(Name="audioOptions", EmitDefaultValue=false)]
        public List<AudioOptionsEnum> AudioOptions { get; set; }
        /// <summary>
        /// Specifies whether to require a password for meetings using Personal Meeting ID (PMI). The supported values are: &#39;none&#39;, &#39;all&#39; and &#39;jbhOnly&#39; (joined before host only)
        /// </summary>
        /// <value>Specifies whether to require a password for meetings using Personal Meeting ID (PMI). The supported values are: &#39;none&#39;, &#39;all&#39; and &#39;jbhOnly&#39; (joined before host only)</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RequirePasswordForPmiMeetingsEnum
        {
            /// <summary>
            /// Enum All for value: all
            /// </summary>
            [EnumMember(Value = "all")]
            All = 1,

            /// <summary>
            /// Enum None for value: none
            /// </summary>
            [EnumMember(Value = "none")]
            None = 2,

            /// <summary>
            /// Enum JbhOnly for value: jbhOnly
            /// </summary>
            [EnumMember(Value = "jbhOnly")]
            JbhOnly = 3

        }

        /// <summary>
        /// Specifies whether to require a password for meetings using Personal Meeting ID (PMI). The supported values are: &#39;none&#39;, &#39;all&#39; and &#39;jbhOnly&#39; (joined before host only)
        /// </summary>
        /// <value>Specifies whether to require a password for meetings using Personal Meeting ID (PMI). The supported values are: &#39;none&#39;, &#39;all&#39; and &#39;jbhOnly&#39; (joined before host only)</value>
        [DataMember(Name="requirePasswordForPmiMeetings", EmitDefaultValue=false)]
        public RequirePasswordForPmiMeetingsEnum? RequirePasswordForPmiMeetings { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleUserMeetingInfo" /> class.
        /// </summary>
        /// <param name="enforceLogin">If true, then only signed-in users can join this meeting.</param>
        /// <param name="startHostVideo">Starting meetings with host video on/off (true/false).</param>
        /// <param name="startParticipantsVideo">Starting meetings with participant video on/off (true/false).</param>
        /// <param name="audioOptions">Determines how participants can join the audio channel of a meeting.</param>
        /// <param name="allowJoinBeforeHost">Allows participants to join the meeting before the host arrives.</param>
        /// <param name="usePmiForScheduledMeetings">Determines whether to use Personal Meeting ID (PMI) when scheduling a meeting.</param>
        /// <param name="usePmiForInstantMeetings">Determines whether to use Personal Meeting ID (PMI) when starting an instant meeting.</param>
        /// <param name="requirePasswordForSchedulingNewMeetings">A password will be generated when scheduling a meeting and participants will require password to join a meeting. The Personal Meeting ID (PMI) meetings are not included.</param>
        /// <param name="requirePasswordForScheduledMeetings">Specifies whether to require a password for meetings which have already been scheduled.</param>
        /// <param name="defaultPasswordForScheduledMeetings">Password for already scheduled meetings. Users can set it individually.</param>
        /// <param name="requirePasswordForInstantMeetings">A random password will be generated for an instant meeting, if set to &#39;True&#39;. If you use PMI for your instant meetings, this option will be disabled.</param>
        /// <param name="requirePasswordForPmiMeetings">Specifies whether to require a password for meetings using Personal Meeting ID (PMI). The supported values are: &#39;none&#39;, &#39;all&#39; and &#39;jbhOnly&#39; (joined before host only).</param>
        /// <param name="pmiPassword">The default password for Personal Meeting ID (PMI) meetings.</param>
        /// <param name="pstnPasswordProtected">Specifies whether to generate and require a password for participants joining by phone.</param>
        public ScheduleUserMeetingInfo(bool enforceLogin = default(bool), bool startHostVideo = default(bool), bool startParticipantsVideo = default(bool), List<AudioOptionsEnum> audioOptions = default(List<AudioOptionsEnum>), bool allowJoinBeforeHost = default(bool), bool usePmiForScheduledMeetings = default(bool), bool usePmiForInstantMeetings = default(bool), bool requirePasswordForSchedulingNewMeetings = default(bool), bool requirePasswordForScheduledMeetings = default(bool), string defaultPasswordForScheduledMeetings = default(string), bool requirePasswordForInstantMeetings = default(bool), RequirePasswordForPmiMeetingsEnum? requirePasswordForPmiMeetings = default(RequirePasswordForPmiMeetingsEnum?), string pmiPassword = default(string), bool pstnPasswordProtected = default(bool))
        {
            this.EnforceLogin = enforceLogin;
            this.StartHostVideo = startHostVideo;
            this.StartParticipantsVideo = startParticipantsVideo;
            this.AudioOptions = audioOptions;
            this.AllowJoinBeforeHost = allowJoinBeforeHost;
            this.UsePmiForScheduledMeetings = usePmiForScheduledMeetings;
            this.UsePmiForInstantMeetings = usePmiForInstantMeetings;
            this.RequirePasswordForSchedulingNewMeetings = requirePasswordForSchedulingNewMeetings;
            this.RequirePasswordForScheduledMeetings = requirePasswordForScheduledMeetings;
            this.DefaultPasswordForScheduledMeetings = defaultPasswordForScheduledMeetings;
            this.RequirePasswordForInstantMeetings = requirePasswordForInstantMeetings;
            this.RequirePasswordForPmiMeetings = requirePasswordForPmiMeetings;
            this.PmiPassword = pmiPassword;
            this.PstnPasswordProtected = pstnPasswordProtected;
        }

        /// <summary>
        /// If true, then only signed-in users can join this meeting
        /// </summary>
        /// <value>If true, then only signed-in users can join this meeting</value>
        [DataMember(Name="enforceLogin", EmitDefaultValue=false)]
        public bool EnforceLogin { get; set; }

        /// <summary>
        /// Starting meetings with host video on/off (true/false)
        /// </summary>
        /// <value>Starting meetings with host video on/off (true/false)</value>
        [DataMember(Name="startHostVideo", EmitDefaultValue=false)]
        public bool StartHostVideo { get; set; }

        /// <summary>
        /// Starting meetings with participant video on/off (true/false)
        /// </summary>
        /// <value>Starting meetings with participant video on/off (true/false)</value>
        [DataMember(Name="startParticipantsVideo", EmitDefaultValue=false)]
        public bool StartParticipantsVideo { get; set; }


        /// <summary>
        /// Allows participants to join the meeting before the host arrives
        /// </summary>
        /// <value>Allows participants to join the meeting before the host arrives</value>
        [DataMember(Name="allowJoinBeforeHost", EmitDefaultValue=false)]
        public bool AllowJoinBeforeHost { get; set; }

        /// <summary>
        /// Determines whether to use Personal Meeting ID (PMI) when scheduling a meeting
        /// </summary>
        /// <value>Determines whether to use Personal Meeting ID (PMI) when scheduling a meeting</value>
        [DataMember(Name="usePmiForScheduledMeetings", EmitDefaultValue=false)]
        public bool UsePmiForScheduledMeetings { get; set; }

        /// <summary>
        /// Determines whether to use Personal Meeting ID (PMI) when starting an instant meeting
        /// </summary>
        /// <value>Determines whether to use Personal Meeting ID (PMI) when starting an instant meeting</value>
        [DataMember(Name="usePmiForInstantMeetings", EmitDefaultValue=false)]
        public bool UsePmiForInstantMeetings { get; set; }

        /// <summary>
        /// A password will be generated when scheduling a meeting and participants will require password to join a meeting. The Personal Meeting ID (PMI) meetings are not included
        /// </summary>
        /// <value>A password will be generated when scheduling a meeting and participants will require password to join a meeting. The Personal Meeting ID (PMI) meetings are not included</value>
        [DataMember(Name="requirePasswordForSchedulingNewMeetings", EmitDefaultValue=false)]
        public bool RequirePasswordForSchedulingNewMeetings { get; set; }

        /// <summary>
        /// Specifies whether to require a password for meetings which have already been scheduled
        /// </summary>
        /// <value>Specifies whether to require a password for meetings which have already been scheduled</value>
        [DataMember(Name="requirePasswordForScheduledMeetings", EmitDefaultValue=false)]
        public bool RequirePasswordForScheduledMeetings { get; set; }

        /// <summary>
        /// Password for already scheduled meetings. Users can set it individually
        /// </summary>
        /// <value>Password for already scheduled meetings. Users can set it individually</value>
        [DataMember(Name="defaultPasswordForScheduledMeetings", EmitDefaultValue=false)]
        public string DefaultPasswordForScheduledMeetings { get; set; }

        /// <summary>
        /// A random password will be generated for an instant meeting, if set to &#39;True&#39;. If you use PMI for your instant meetings, this option will be disabled
        /// </summary>
        /// <value>A random password will be generated for an instant meeting, if set to &#39;True&#39;. If you use PMI for your instant meetings, this option will be disabled</value>
        [DataMember(Name="requirePasswordForInstantMeetings", EmitDefaultValue=false)]
        public bool RequirePasswordForInstantMeetings { get; set; }


        /// <summary>
        /// The default password for Personal Meeting ID (PMI) meetings
        /// </summary>
        /// <value>The default password for Personal Meeting ID (PMI) meetings</value>
        [DataMember(Name="pmiPassword", EmitDefaultValue=false)]
        public string PmiPassword { get; set; }

        /// <summary>
        /// Specifies whether to generate and require a password for participants joining by phone
        /// </summary>
        /// <value>Specifies whether to generate and require a password for participants joining by phone</value>
        [DataMember(Name="pstnPasswordProtected", EmitDefaultValue=false)]
        public bool PstnPasswordProtected { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScheduleUserMeetingInfo {\n");
            sb.Append("  EnforceLogin: ").Append(EnforceLogin).Append("\n");
            sb.Append("  StartHostVideo: ").Append(StartHostVideo).Append("\n");
            sb.Append("  StartParticipantsVideo: ").Append(StartParticipantsVideo).Append("\n");
            sb.Append("  AudioOptions: ").Append(AudioOptions).Append("\n");
            sb.Append("  AllowJoinBeforeHost: ").Append(AllowJoinBeforeHost).Append("\n");
            sb.Append("  UsePmiForScheduledMeetings: ").Append(UsePmiForScheduledMeetings).Append("\n");
            sb.Append("  UsePmiForInstantMeetings: ").Append(UsePmiForInstantMeetings).Append("\n");
            sb.Append("  RequirePasswordForSchedulingNewMeetings: ").Append(RequirePasswordForSchedulingNewMeetings).Append("\n");
            sb.Append("  RequirePasswordForScheduledMeetings: ").Append(RequirePasswordForScheduledMeetings).Append("\n");
            sb.Append("  DefaultPasswordForScheduledMeetings: ").Append(DefaultPasswordForScheduledMeetings).Append("\n");
            sb.Append("  RequirePasswordForInstantMeetings: ").Append(RequirePasswordForInstantMeetings).Append("\n");
            sb.Append("  RequirePasswordForPmiMeetings: ").Append(RequirePasswordForPmiMeetings).Append("\n");
            sb.Append("  PmiPassword: ").Append(PmiPassword).Append("\n");
            sb.Append("  PstnPasswordProtected: ").Append(PstnPasswordProtected).Append("\n");
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
            return this.Equals(input as ScheduleUserMeetingInfo);
        }

        /// <summary>
        /// Returns true if ScheduleUserMeetingInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ScheduleUserMeetingInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScheduleUserMeetingInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EnforceLogin == input.EnforceLogin ||
                    (this.EnforceLogin != null &&
                    this.EnforceLogin.Equals(input.EnforceLogin))
                ) && 
                (
                    this.StartHostVideo == input.StartHostVideo ||
                    (this.StartHostVideo != null &&
                    this.StartHostVideo.Equals(input.StartHostVideo))
                ) && 
                (
                    this.StartParticipantsVideo == input.StartParticipantsVideo ||
                    (this.StartParticipantsVideo != null &&
                    this.StartParticipantsVideo.Equals(input.StartParticipantsVideo))
                ) && 
                (
                    this.AudioOptions == input.AudioOptions ||
                    this.AudioOptions != null &&
                    input.AudioOptions != null &&
                    this.AudioOptions.SequenceEqual(input.AudioOptions)
                ) && 
                (
                    this.AllowJoinBeforeHost == input.AllowJoinBeforeHost ||
                    (this.AllowJoinBeforeHost != null &&
                    this.AllowJoinBeforeHost.Equals(input.AllowJoinBeforeHost))
                ) && 
                (
                    this.UsePmiForScheduledMeetings == input.UsePmiForScheduledMeetings ||
                    (this.UsePmiForScheduledMeetings != null &&
                    this.UsePmiForScheduledMeetings.Equals(input.UsePmiForScheduledMeetings))
                ) && 
                (
                    this.UsePmiForInstantMeetings == input.UsePmiForInstantMeetings ||
                    (this.UsePmiForInstantMeetings != null &&
                    this.UsePmiForInstantMeetings.Equals(input.UsePmiForInstantMeetings))
                ) && 
                (
                    this.RequirePasswordForSchedulingNewMeetings == input.RequirePasswordForSchedulingNewMeetings ||
                    (this.RequirePasswordForSchedulingNewMeetings != null &&
                    this.RequirePasswordForSchedulingNewMeetings.Equals(input.RequirePasswordForSchedulingNewMeetings))
                ) && 
                (
                    this.RequirePasswordForScheduledMeetings == input.RequirePasswordForScheduledMeetings ||
                    (this.RequirePasswordForScheduledMeetings != null &&
                    this.RequirePasswordForScheduledMeetings.Equals(input.RequirePasswordForScheduledMeetings))
                ) && 
                (
                    this.DefaultPasswordForScheduledMeetings == input.DefaultPasswordForScheduledMeetings ||
                    (this.DefaultPasswordForScheduledMeetings != null &&
                    this.DefaultPasswordForScheduledMeetings.Equals(input.DefaultPasswordForScheduledMeetings))
                ) && 
                (
                    this.RequirePasswordForInstantMeetings == input.RequirePasswordForInstantMeetings ||
                    (this.RequirePasswordForInstantMeetings != null &&
                    this.RequirePasswordForInstantMeetings.Equals(input.RequirePasswordForInstantMeetings))
                ) && 
                (
                    this.RequirePasswordForPmiMeetings == input.RequirePasswordForPmiMeetings ||
                    (this.RequirePasswordForPmiMeetings != null &&
                    this.RequirePasswordForPmiMeetings.Equals(input.RequirePasswordForPmiMeetings))
                ) && 
                (
                    this.PmiPassword == input.PmiPassword ||
                    (this.PmiPassword != null &&
                    this.PmiPassword.Equals(input.PmiPassword))
                ) && 
                (
                    this.PstnPasswordProtected == input.PstnPasswordProtected ||
                    (this.PstnPasswordProtected != null &&
                    this.PstnPasswordProtected.Equals(input.PstnPasswordProtected))
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
                if (this.EnforceLogin != null)
                    hashCode = hashCode * 59 + this.EnforceLogin.GetHashCode();
                if (this.StartHostVideo != null)
                    hashCode = hashCode * 59 + this.StartHostVideo.GetHashCode();
                if (this.StartParticipantsVideo != null)
                    hashCode = hashCode * 59 + this.StartParticipantsVideo.GetHashCode();
                if (this.AudioOptions != null)
                    hashCode = hashCode * 59 + this.AudioOptions.GetHashCode();
                if (this.AllowJoinBeforeHost != null)
                    hashCode = hashCode * 59 + this.AllowJoinBeforeHost.GetHashCode();
                if (this.UsePmiForScheduledMeetings != null)
                    hashCode = hashCode * 59 + this.UsePmiForScheduledMeetings.GetHashCode();
                if (this.UsePmiForInstantMeetings != null)
                    hashCode = hashCode * 59 + this.UsePmiForInstantMeetings.GetHashCode();
                if (this.RequirePasswordForSchedulingNewMeetings != null)
                    hashCode = hashCode * 59 + this.RequirePasswordForSchedulingNewMeetings.GetHashCode();
                if (this.RequirePasswordForScheduledMeetings != null)
                    hashCode = hashCode * 59 + this.RequirePasswordForScheduledMeetings.GetHashCode();
                if (this.DefaultPasswordForScheduledMeetings != null)
                    hashCode = hashCode * 59 + this.DefaultPasswordForScheduledMeetings.GetHashCode();
                if (this.RequirePasswordForInstantMeetings != null)
                    hashCode = hashCode * 59 + this.RequirePasswordForInstantMeetings.GetHashCode();
                if (this.RequirePasswordForPmiMeetings != null)
                    hashCode = hashCode * 59 + this.RequirePasswordForPmiMeetings.GetHashCode();
                if (this.PmiPassword != null)
                    hashCode = hashCode * 59 + this.PmiPassword.GetHashCode();
                if (this.PstnPasswordProtected != null)
                    hashCode = hashCode * 59 + this.PstnPasswordProtected.GetHashCode();
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
