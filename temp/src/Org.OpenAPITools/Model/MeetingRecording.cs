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
    /// MeetingRecording
    /// </summary>
    [DataContract]
    public partial class MeetingRecording :  IEquatable<MeetingRecording>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MeetingRecording" /> class.
        /// </summary>
        /// <param name="meeting">meeting.</param>
        /// <param name="recording">recording.</param>
        public MeetingRecording(MeetingInfo meeting = default(MeetingInfo), List<MeetingRecordingInfo> recording = default(List<MeetingRecordingInfo>))
        {
            this.Meeting = meeting;
            this.Recording = recording;
        }

        /// <summary>
        /// Gets or Sets Meeting
        /// </summary>
        [DataMember(Name="meeting", EmitDefaultValue=false)]
        public MeetingInfo Meeting { get; set; }

        /// <summary>
        /// Gets or Sets Recording
        /// </summary>
        [DataMember(Name="recording", EmitDefaultValue=false)]
        public List<MeetingRecordingInfo> Recording { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MeetingRecording {\n");
            sb.Append("  Meeting: ").Append(Meeting).Append("\n");
            sb.Append("  Recording: ").Append(Recording).Append("\n");
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
            return this.Equals(input as MeetingRecording);
        }

        /// <summary>
        /// Returns true if MeetingRecording instances are equal
        /// </summary>
        /// <param name="input">Instance of MeetingRecording to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MeetingRecording input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Meeting == input.Meeting ||
                    (this.Meeting != null &&
                    this.Meeting.Equals(input.Meeting))
                ) && 
                (
                    this.Recording == input.Recording ||
                    this.Recording != null &&
                    input.Recording != null &&
                    this.Recording.SequenceEqual(input.Recording)
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
                if (this.Meeting != null)
                    hashCode = hashCode * 59 + this.Meeting.GetHashCode();
                if (this.Recording != null)
                    hashCode = hashCode * 59 + this.Recording.GetHashCode();
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
