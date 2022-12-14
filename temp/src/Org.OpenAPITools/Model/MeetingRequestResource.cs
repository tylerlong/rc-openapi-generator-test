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
    /// MeetingRequestResource
    /// </summary>
    [DataContract]
    public partial class MeetingRequestResource :  IEquatable<MeetingRequestResource>, IValidatableObject
    {
        /// <summary>
        /// Defines MeetingType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MeetingTypeEnum
        {
            /// <summary>
            /// Enum Instant for value: Instant
            /// </summary>
            [EnumMember(Value = "Instant")]
            Instant = 1,

            /// <summary>
            /// Enum Scheduled for value: Scheduled
            /// </summary>
            [EnumMember(Value = "Scheduled")]
            Scheduled = 2,

            /// <summary>
            /// Enum ScheduledRecurring for value: ScheduledRecurring
            /// </summary>
            [EnumMember(Value = "ScheduledRecurring")]
            ScheduledRecurring = 3,

            /// <summary>
            /// Enum Recurring for value: Recurring
            /// </summary>
            [EnumMember(Value = "Recurring")]
            Recurring = 4

        }

        /// <summary>
        /// Gets or Sets MeetingType
        /// </summary>
        [DataMember(Name="meetingType", EmitDefaultValue=false)]
        public MeetingTypeEnum? MeetingType { get; set; }
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
            ComputerAudio = 2

        }


        /// <summary>
        /// Gets or Sets AudioOptions
        /// </summary>
        [DataMember(Name="audioOptions", EmitDefaultValue=false)]
        public List<AudioOptionsEnum> AudioOptions { get; set; }
        /// <summary>
        /// Automatic record type
        /// </summary>
        /// <value>Automatic record type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AutoRecordTypeEnum
        {
            /// <summary>
            /// Enum Local for value: local
            /// </summary>
            [EnumMember(Value = "local")]
            Local = 1,

            /// <summary>
            /// Enum Cloud for value: cloud
            /// </summary>
            [EnumMember(Value = "cloud")]
            Cloud = 2,

            /// <summary>
            /// Enum None for value: none
            /// </summary>
            [EnumMember(Value = "none")]
            None = 3

        }

        /// <summary>
        /// Automatic record type
        /// </summary>
        /// <value>Automatic record type</value>
        [DataMember(Name="autoRecordType", EmitDefaultValue=false)]
        public AutoRecordTypeEnum? AutoRecordType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MeetingRequestResource" /> class.
        /// </summary>
        /// <param name="topic">Custom topic of a meeting.</param>
        /// <param name="meetingType">meetingType.</param>
        /// <param name="schedule">schedule.</param>
        /// <param name="password">Meeting password.</param>
        /// <param name="host">host.</param>
        /// <param name="allowJoinBeforeHost">allowJoinBeforeHost (default to false).</param>
        /// <param name="startHostVideo">startHostVideo (default to false).</param>
        /// <param name="startParticipantsVideo">Starting meetings with participant video on/off (true/false) (default to false).</param>
        /// <param name="usePersonalMeetingId">If true, then personal user&#39;s meeting ID is applied for creation of this meeting.</param>
        /// <param name="audioOptions">audioOptions.</param>
        /// <param name="recurrence">recurrence.</param>
        /// <param name="autoRecordType">Automatic record type (default to AutoRecordTypeEnum.None).</param>
        /// <param name="enforceLogin">If true, then only signed-in users can join this meeting.</param>
        /// <param name="muteParticipantsOnEntry">If true, then participants are muted on entry.</param>
        /// <param name="enableWaitingRoom">If true, then the waiting room for participants is enabled.</param>
        /// <param name="globalDialInCountries">List of global dial-in countries (eg. US, UK, AU, etc.).</param>
        public MeetingRequestResource(string topic = default(string), MeetingTypeEnum? meetingType = default(MeetingTypeEnum?), MeetingScheduleResource schedule = default(MeetingScheduleResource), string password = default(string), HostInfoRequest host = default(HostInfoRequest), bool allowJoinBeforeHost = false, bool startHostVideo = false, bool startParticipantsVideo = false, bool usePersonalMeetingId = default(bool), List<AudioOptionsEnum> audioOptions = default(List<AudioOptionsEnum>), RecurrenceInfo recurrence = default(RecurrenceInfo), AutoRecordTypeEnum? autoRecordType = AutoRecordTypeEnum.None, bool enforceLogin = default(bool), bool muteParticipantsOnEntry = default(bool), bool enableWaitingRoom = default(bool), List<string> globalDialInCountries = default(List<string>))
        {
            this.Topic = topic;
            this.MeetingType = meetingType;
            this.Schedule = schedule;
            this.Password = password;
            this.Host = host;
            // use default value if no "allowJoinBeforeHost" provided
            if (allowJoinBeforeHost == null)
            {
                this.AllowJoinBeforeHost = false;
            }
            else
            {
                this.AllowJoinBeforeHost = allowJoinBeforeHost;
            }
            // use default value if no "startHostVideo" provided
            if (startHostVideo == null)
            {
                this.StartHostVideo = false;
            }
            else
            {
                this.StartHostVideo = startHostVideo;
            }
            // use default value if no "startParticipantsVideo" provided
            if (startParticipantsVideo == null)
            {
                this.StartParticipantsVideo = false;
            }
            else
            {
                this.StartParticipantsVideo = startParticipantsVideo;
            }
            this.UsePersonalMeetingId = usePersonalMeetingId;
            this.AudioOptions = audioOptions;
            this.Recurrence = recurrence;
            // use default value if no "autoRecordType" provided
            if (autoRecordType == null)
            {
                this.AutoRecordType = AutoRecordTypeEnum.None;
            }
            else
            {
                this.AutoRecordType = autoRecordType;
            }
            this.EnforceLogin = enforceLogin;
            this.MuteParticipantsOnEntry = muteParticipantsOnEntry;
            this.EnableWaitingRoom = enableWaitingRoom;
            this.GlobalDialInCountries = globalDialInCountries;
        }

        /// <summary>
        /// Custom topic of a meeting
        /// </summary>
        /// <value>Custom topic of a meeting</value>
        [DataMember(Name="topic", EmitDefaultValue=false)]
        public string Topic { get; set; }


        /// <summary>
        /// Gets or Sets Schedule
        /// </summary>
        [DataMember(Name="schedule", EmitDefaultValue=false)]
        public MeetingScheduleResource Schedule { get; set; }

        /// <summary>
        /// Meeting password
        /// </summary>
        /// <value>Meeting password</value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// Gets or Sets Host
        /// </summary>
        [DataMember(Name="host", EmitDefaultValue=false)]
        public HostInfoRequest Host { get; set; }

        /// <summary>
        /// Gets or Sets AllowJoinBeforeHost
        /// </summary>
        [DataMember(Name="allowJoinBeforeHost", EmitDefaultValue=false)]
        public bool AllowJoinBeforeHost { get; set; }

        /// <summary>
        /// Gets or Sets StartHostVideo
        /// </summary>
        [DataMember(Name="startHostVideo", EmitDefaultValue=false)]
        public bool StartHostVideo { get; set; }

        /// <summary>
        /// Starting meetings with participant video on/off (true/false)
        /// </summary>
        /// <value>Starting meetings with participant video on/off (true/false)</value>
        [DataMember(Name="startParticipantsVideo", EmitDefaultValue=false)]
        public bool StartParticipantsVideo { get; set; }

        /// <summary>
        /// If true, then personal user&#39;s meeting ID is applied for creation of this meeting
        /// </summary>
        /// <value>If true, then personal user&#39;s meeting ID is applied for creation of this meeting</value>
        [DataMember(Name="usePersonalMeetingId", EmitDefaultValue=false)]
        public bool UsePersonalMeetingId { get; set; }


        /// <summary>
        /// Gets or Sets Recurrence
        /// </summary>
        [DataMember(Name="recurrence", EmitDefaultValue=false)]
        public RecurrenceInfo Recurrence { get; set; }


        /// <summary>
        /// If true, then only signed-in users can join this meeting
        /// </summary>
        /// <value>If true, then only signed-in users can join this meeting</value>
        [DataMember(Name="enforceLogin", EmitDefaultValue=false)]
        public bool EnforceLogin { get; set; }

        /// <summary>
        /// If true, then participants are muted on entry
        /// </summary>
        /// <value>If true, then participants are muted on entry</value>
        [DataMember(Name="muteParticipantsOnEntry", EmitDefaultValue=false)]
        public bool MuteParticipantsOnEntry { get; set; }

        /// <summary>
        /// If true, then the waiting room for participants is enabled
        /// </summary>
        /// <value>If true, then the waiting room for participants is enabled</value>
        [DataMember(Name="enableWaitingRoom", EmitDefaultValue=false)]
        public bool EnableWaitingRoom { get; set; }

        /// <summary>
        /// List of global dial-in countries (eg. US, UK, AU, etc.)
        /// </summary>
        /// <value>List of global dial-in countries (eg. US, UK, AU, etc.)</value>
        [DataMember(Name="globalDialInCountries", EmitDefaultValue=false)]
        public List<string> GlobalDialInCountries { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MeetingRequestResource {\n");
            sb.Append("  Topic: ").Append(Topic).Append("\n");
            sb.Append("  MeetingType: ").Append(MeetingType).Append("\n");
            sb.Append("  Schedule: ").Append(Schedule).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Host: ").Append(Host).Append("\n");
            sb.Append("  AllowJoinBeforeHost: ").Append(AllowJoinBeforeHost).Append("\n");
            sb.Append("  StartHostVideo: ").Append(StartHostVideo).Append("\n");
            sb.Append("  StartParticipantsVideo: ").Append(StartParticipantsVideo).Append("\n");
            sb.Append("  UsePersonalMeetingId: ").Append(UsePersonalMeetingId).Append("\n");
            sb.Append("  AudioOptions: ").Append(AudioOptions).Append("\n");
            sb.Append("  Recurrence: ").Append(Recurrence).Append("\n");
            sb.Append("  AutoRecordType: ").Append(AutoRecordType).Append("\n");
            sb.Append("  EnforceLogin: ").Append(EnforceLogin).Append("\n");
            sb.Append("  MuteParticipantsOnEntry: ").Append(MuteParticipantsOnEntry).Append("\n");
            sb.Append("  EnableWaitingRoom: ").Append(EnableWaitingRoom).Append("\n");
            sb.Append("  GlobalDialInCountries: ").Append(GlobalDialInCountries).Append("\n");
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
            return this.Equals(input as MeetingRequestResource);
        }

        /// <summary>
        /// Returns true if MeetingRequestResource instances are equal
        /// </summary>
        /// <param name="input">Instance of MeetingRequestResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MeetingRequestResource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Topic == input.Topic ||
                    (this.Topic != null &&
                    this.Topic.Equals(input.Topic))
                ) && 
                (
                    this.MeetingType == input.MeetingType ||
                    (this.MeetingType != null &&
                    this.MeetingType.Equals(input.MeetingType))
                ) && 
                (
                    this.Schedule == input.Schedule ||
                    (this.Schedule != null &&
                    this.Schedule.Equals(input.Schedule))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.Host == input.Host ||
                    (this.Host != null &&
                    this.Host.Equals(input.Host))
                ) && 
                (
                    this.AllowJoinBeforeHost == input.AllowJoinBeforeHost ||
                    (this.AllowJoinBeforeHost != null &&
                    this.AllowJoinBeforeHost.Equals(input.AllowJoinBeforeHost))
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
                    this.UsePersonalMeetingId == input.UsePersonalMeetingId ||
                    (this.UsePersonalMeetingId != null &&
                    this.UsePersonalMeetingId.Equals(input.UsePersonalMeetingId))
                ) && 
                (
                    this.AudioOptions == input.AudioOptions ||
                    this.AudioOptions != null &&
                    input.AudioOptions != null &&
                    this.AudioOptions.SequenceEqual(input.AudioOptions)
                ) && 
                (
                    this.Recurrence == input.Recurrence ||
                    (this.Recurrence != null &&
                    this.Recurrence.Equals(input.Recurrence))
                ) && 
                (
                    this.AutoRecordType == input.AutoRecordType ||
                    (this.AutoRecordType != null &&
                    this.AutoRecordType.Equals(input.AutoRecordType))
                ) && 
                (
                    this.EnforceLogin == input.EnforceLogin ||
                    (this.EnforceLogin != null &&
                    this.EnforceLogin.Equals(input.EnforceLogin))
                ) && 
                (
                    this.MuteParticipantsOnEntry == input.MuteParticipantsOnEntry ||
                    (this.MuteParticipantsOnEntry != null &&
                    this.MuteParticipantsOnEntry.Equals(input.MuteParticipantsOnEntry))
                ) && 
                (
                    this.EnableWaitingRoom == input.EnableWaitingRoom ||
                    (this.EnableWaitingRoom != null &&
                    this.EnableWaitingRoom.Equals(input.EnableWaitingRoom))
                ) && 
                (
                    this.GlobalDialInCountries == input.GlobalDialInCountries ||
                    this.GlobalDialInCountries != null &&
                    input.GlobalDialInCountries != null &&
                    this.GlobalDialInCountries.SequenceEqual(input.GlobalDialInCountries)
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
                if (this.Topic != null)
                    hashCode = hashCode * 59 + this.Topic.GetHashCode();
                if (this.MeetingType != null)
                    hashCode = hashCode * 59 + this.MeetingType.GetHashCode();
                if (this.Schedule != null)
                    hashCode = hashCode * 59 + this.Schedule.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.Host != null)
                    hashCode = hashCode * 59 + this.Host.GetHashCode();
                if (this.AllowJoinBeforeHost != null)
                    hashCode = hashCode * 59 + this.AllowJoinBeforeHost.GetHashCode();
                if (this.StartHostVideo != null)
                    hashCode = hashCode * 59 + this.StartHostVideo.GetHashCode();
                if (this.StartParticipantsVideo != null)
                    hashCode = hashCode * 59 + this.StartParticipantsVideo.GetHashCode();
                if (this.UsePersonalMeetingId != null)
                    hashCode = hashCode * 59 + this.UsePersonalMeetingId.GetHashCode();
                if (this.AudioOptions != null)
                    hashCode = hashCode * 59 + this.AudioOptions.GetHashCode();
                if (this.Recurrence != null)
                    hashCode = hashCode * 59 + this.Recurrence.GetHashCode();
                if (this.AutoRecordType != null)
                    hashCode = hashCode * 59 + this.AutoRecordType.GetHashCode();
                if (this.EnforceLogin != null)
                    hashCode = hashCode * 59 + this.EnforceLogin.GetHashCode();
                if (this.MuteParticipantsOnEntry != null)
                    hashCode = hashCode * 59 + this.MuteParticipantsOnEntry.GetHashCode();
                if (this.EnableWaitingRoom != null)
                    hashCode = hashCode * 59 + this.EnableWaitingRoom.GetHashCode();
                if (this.GlobalDialInCountries != null)
                    hashCode = hashCode * 59 + this.GlobalDialInCountries.GetHashCode();
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
