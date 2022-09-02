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
    /// Options for selecting breakdown for calls duration
    /// </summary>
    [DataContract]
    public partial class TimelineResponseOptionsTimers :  IEquatable<TimelineResponseOptionsTimers>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TimelineResponseOptionsTimers" /> class.
        /// </summary>
        /// <param name="allCallsDuration">Include data for all calls duration.</param>
        /// <param name="callsDurationByDirection">Include breakdown of calls duration by direction (Inbound, Outbound).</param>
        /// <param name="callsDurationByOrigin">Include breakdown of calls duration by origin (Internal, External).</param>
        /// <param name="callsDurationByResponse">Include breakdown of calls duration by response (Answered, NotAnswered, Connected, NotConnected).</param>
        /// <param name="callsSegmentsDuration">Include breakdown of calls duration by segments (Ringing, LiveTalk, Hold, Park, Transfer, IvrPrompt, Voicemail, VmGreeting, Setup) .</param>
        /// <param name="callsDurationByResult">Include breakdown of calls duration by result (Completed, Abandoned, Voicemail, Unknown, Missed, Accepted).</param>
        /// <param name="callsDurationByCompanyHours">Include breakdown of calls duration by company hours (BusinessHours, AfterHours).</param>
        /// <param name="callsDurationByQueueSla">Include breakdown of calls duration by queue SLA (InSLA, OutSLA). This timer is only applicable to Queues grouping.</param>
        /// <param name="callsDurationByType">Include breakdown of calls duration by type (Direct, FromQueue, ParkRetrieval, Transferred, Outbound).</param>
        public TimelineResponseOptionsTimers(bool allCallsDuration = default(bool), bool callsDurationByDirection = default(bool), bool callsDurationByOrigin = default(bool), bool callsDurationByResponse = default(bool), bool callsSegmentsDuration = default(bool), bool callsDurationByResult = default(bool), bool callsDurationByCompanyHours = default(bool), bool callsDurationByQueueSla = default(bool), bool callsDurationByType = default(bool))
        {
            this.AllCallsDuration = allCallsDuration;
            this.CallsDurationByDirection = callsDurationByDirection;
            this.CallsDurationByOrigin = callsDurationByOrigin;
            this.CallsDurationByResponse = callsDurationByResponse;
            this.CallsSegmentsDuration = callsSegmentsDuration;
            this.CallsDurationByResult = callsDurationByResult;
            this.CallsDurationByCompanyHours = callsDurationByCompanyHours;
            this.CallsDurationByQueueSla = callsDurationByQueueSla;
            this.CallsDurationByType = callsDurationByType;
        }

        /// <summary>
        /// Include data for all calls duration
        /// </summary>
        /// <value>Include data for all calls duration</value>
        [DataMember(Name="allCallsDuration", EmitDefaultValue=false)]
        public bool AllCallsDuration { get; set; }

        /// <summary>
        /// Include breakdown of calls duration by direction (Inbound, Outbound)
        /// </summary>
        /// <value>Include breakdown of calls duration by direction (Inbound, Outbound)</value>
        [DataMember(Name="callsDurationByDirection", EmitDefaultValue=false)]
        public bool CallsDurationByDirection { get; set; }

        /// <summary>
        /// Include breakdown of calls duration by origin (Internal, External)
        /// </summary>
        /// <value>Include breakdown of calls duration by origin (Internal, External)</value>
        [DataMember(Name="callsDurationByOrigin", EmitDefaultValue=false)]
        public bool CallsDurationByOrigin { get; set; }

        /// <summary>
        /// Include breakdown of calls duration by response (Answered, NotAnswered, Connected, NotConnected)
        /// </summary>
        /// <value>Include breakdown of calls duration by response (Answered, NotAnswered, Connected, NotConnected)</value>
        [DataMember(Name="callsDurationByResponse", EmitDefaultValue=false)]
        public bool CallsDurationByResponse { get; set; }

        /// <summary>
        /// Include breakdown of calls duration by segments (Ringing, LiveTalk, Hold, Park, Transfer, IvrPrompt, Voicemail, VmGreeting, Setup) 
        /// </summary>
        /// <value>Include breakdown of calls duration by segments (Ringing, LiveTalk, Hold, Park, Transfer, IvrPrompt, Voicemail, VmGreeting, Setup) </value>
        [DataMember(Name="callsSegmentsDuration", EmitDefaultValue=false)]
        public bool CallsSegmentsDuration { get; set; }

        /// <summary>
        /// Include breakdown of calls duration by result (Completed, Abandoned, Voicemail, Unknown, Missed, Accepted)
        /// </summary>
        /// <value>Include breakdown of calls duration by result (Completed, Abandoned, Voicemail, Unknown, Missed, Accepted)</value>
        [DataMember(Name="callsDurationByResult", EmitDefaultValue=false)]
        public bool CallsDurationByResult { get; set; }

        /// <summary>
        /// Include breakdown of calls duration by company hours (BusinessHours, AfterHours)
        /// </summary>
        /// <value>Include breakdown of calls duration by company hours (BusinessHours, AfterHours)</value>
        [DataMember(Name="callsDurationByCompanyHours", EmitDefaultValue=false)]
        public bool CallsDurationByCompanyHours { get; set; }

        /// <summary>
        /// Include breakdown of calls duration by queue SLA (InSLA, OutSLA). This timer is only applicable to Queues grouping
        /// </summary>
        /// <value>Include breakdown of calls duration by queue SLA (InSLA, OutSLA). This timer is only applicable to Queues grouping</value>
        [DataMember(Name="callsDurationByQueueSla", EmitDefaultValue=false)]
        public bool CallsDurationByQueueSla { get; set; }

        /// <summary>
        /// Include breakdown of calls duration by type (Direct, FromQueue, ParkRetrieval, Transferred, Outbound)
        /// </summary>
        /// <value>Include breakdown of calls duration by type (Direct, FromQueue, ParkRetrieval, Transferred, Outbound)</value>
        [DataMember(Name="callsDurationByType", EmitDefaultValue=false)]
        public bool CallsDurationByType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TimelineResponseOptionsTimers {\n");
            sb.Append("  AllCallsDuration: ").Append(AllCallsDuration).Append("\n");
            sb.Append("  CallsDurationByDirection: ").Append(CallsDurationByDirection).Append("\n");
            sb.Append("  CallsDurationByOrigin: ").Append(CallsDurationByOrigin).Append("\n");
            sb.Append("  CallsDurationByResponse: ").Append(CallsDurationByResponse).Append("\n");
            sb.Append("  CallsSegmentsDuration: ").Append(CallsSegmentsDuration).Append("\n");
            sb.Append("  CallsDurationByResult: ").Append(CallsDurationByResult).Append("\n");
            sb.Append("  CallsDurationByCompanyHours: ").Append(CallsDurationByCompanyHours).Append("\n");
            sb.Append("  CallsDurationByQueueSla: ").Append(CallsDurationByQueueSla).Append("\n");
            sb.Append("  CallsDurationByType: ").Append(CallsDurationByType).Append("\n");
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
            return this.Equals(input as TimelineResponseOptionsTimers);
        }

        /// <summary>
        /// Returns true if TimelineResponseOptionsTimers instances are equal
        /// </summary>
        /// <param name="input">Instance of TimelineResponseOptionsTimers to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TimelineResponseOptionsTimers input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AllCallsDuration == input.AllCallsDuration ||
                    (this.AllCallsDuration != null &&
                    this.AllCallsDuration.Equals(input.AllCallsDuration))
                ) && 
                (
                    this.CallsDurationByDirection == input.CallsDurationByDirection ||
                    (this.CallsDurationByDirection != null &&
                    this.CallsDurationByDirection.Equals(input.CallsDurationByDirection))
                ) && 
                (
                    this.CallsDurationByOrigin == input.CallsDurationByOrigin ||
                    (this.CallsDurationByOrigin != null &&
                    this.CallsDurationByOrigin.Equals(input.CallsDurationByOrigin))
                ) && 
                (
                    this.CallsDurationByResponse == input.CallsDurationByResponse ||
                    (this.CallsDurationByResponse != null &&
                    this.CallsDurationByResponse.Equals(input.CallsDurationByResponse))
                ) && 
                (
                    this.CallsSegmentsDuration == input.CallsSegmentsDuration ||
                    (this.CallsSegmentsDuration != null &&
                    this.CallsSegmentsDuration.Equals(input.CallsSegmentsDuration))
                ) && 
                (
                    this.CallsDurationByResult == input.CallsDurationByResult ||
                    (this.CallsDurationByResult != null &&
                    this.CallsDurationByResult.Equals(input.CallsDurationByResult))
                ) && 
                (
                    this.CallsDurationByCompanyHours == input.CallsDurationByCompanyHours ||
                    (this.CallsDurationByCompanyHours != null &&
                    this.CallsDurationByCompanyHours.Equals(input.CallsDurationByCompanyHours))
                ) && 
                (
                    this.CallsDurationByQueueSla == input.CallsDurationByQueueSla ||
                    (this.CallsDurationByQueueSla != null &&
                    this.CallsDurationByQueueSla.Equals(input.CallsDurationByQueueSla))
                ) && 
                (
                    this.CallsDurationByType == input.CallsDurationByType ||
                    (this.CallsDurationByType != null &&
                    this.CallsDurationByType.Equals(input.CallsDurationByType))
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
                if (this.AllCallsDuration != null)
                    hashCode = hashCode * 59 + this.AllCallsDuration.GetHashCode();
                if (this.CallsDurationByDirection != null)
                    hashCode = hashCode * 59 + this.CallsDurationByDirection.GetHashCode();
                if (this.CallsDurationByOrigin != null)
                    hashCode = hashCode * 59 + this.CallsDurationByOrigin.GetHashCode();
                if (this.CallsDurationByResponse != null)
                    hashCode = hashCode * 59 + this.CallsDurationByResponse.GetHashCode();
                if (this.CallsSegmentsDuration != null)
                    hashCode = hashCode * 59 + this.CallsSegmentsDuration.GetHashCode();
                if (this.CallsDurationByResult != null)
                    hashCode = hashCode * 59 + this.CallsDurationByResult.GetHashCode();
                if (this.CallsDurationByCompanyHours != null)
                    hashCode = hashCode * 59 + this.CallsDurationByCompanyHours.GetHashCode();
                if (this.CallsDurationByQueueSla != null)
                    hashCode = hashCode * 59 + this.CallsDurationByQueueSla.GetHashCode();
                if (this.CallsDurationByType != null)
                    hashCode = hashCode * 59 + this.CallsDurationByType.GetHashCode();
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