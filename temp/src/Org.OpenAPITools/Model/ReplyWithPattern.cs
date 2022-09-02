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
    /// ReplyWithPattern
    /// </summary>
    [DataContract]
    public partial class ReplyWithPattern :  IEquatable<ReplyWithPattern>, IValidatableObject
    {
        /// <summary>
        /// Predefined reply pattern name.
        /// </summary>
        /// <value>Predefined reply pattern name.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PatternEnum
        {
            /// <summary>
            /// Enum WillCallYouBack for value: WillCallYouBack
            /// </summary>
            [EnumMember(Value = "WillCallYouBack")]
            WillCallYouBack = 1,

            /// <summary>
            /// Enum CallMeBack for value: CallMeBack
            /// </summary>
            [EnumMember(Value = "CallMeBack")]
            CallMeBack = 2,

            /// <summary>
            /// Enum OnMyWay for value: OnMyWay
            /// </summary>
            [EnumMember(Value = "OnMyWay")]
            OnMyWay = 3,

            /// <summary>
            /// Enum OnTheOtherLine for value: OnTheOtherLine
            /// </summary>
            [EnumMember(Value = "OnTheOtherLine")]
            OnTheOtherLine = 4,

            /// <summary>
            /// Enum WillCallYouBackLater for value: WillCallYouBackLater
            /// </summary>
            [EnumMember(Value = "WillCallYouBackLater")]
            WillCallYouBackLater = 5,

            /// <summary>
            /// Enum CallMeBackLater for value: CallMeBackLater
            /// </summary>
            [EnumMember(Value = "CallMeBackLater")]
            CallMeBackLater = 6,

            /// <summary>
            /// Enum InAMeeting for value: InAMeeting
            /// </summary>
            [EnumMember(Value = "InAMeeting")]
            InAMeeting = 7,

            /// <summary>
            /// Enum OnTheOtherLineNoCall for value: OnTheOtherLineNoCall
            /// </summary>
            [EnumMember(Value = "OnTheOtherLineNoCall")]
            OnTheOtherLineNoCall = 8

        }

        /// <summary>
        /// Predefined reply pattern name.
        /// </summary>
        /// <value>Predefined reply pattern name.</value>
        [DataMember(Name="pattern", EmitDefaultValue=false)]
        public PatternEnum? Pattern { get; set; }
        /// <summary>
        /// Time unit name.
        /// </summary>
        /// <value>Time unit name.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TimeUnitEnum
        {
            /// <summary>
            /// Enum Minute for value: Minute
            /// </summary>
            [EnumMember(Value = "Minute")]
            Minute = 1,

            /// <summary>
            /// Enum Hour for value: Hour
            /// </summary>
            [EnumMember(Value = "Hour")]
            Hour = 2,

            /// <summary>
            /// Enum Day for value: Day
            /// </summary>
            [EnumMember(Value = "Day")]
            Day = 3

        }

        /// <summary>
        /// Time unit name.
        /// </summary>
        /// <value>Time unit name.</value>
        [DataMember(Name="timeUnit", EmitDefaultValue=false)]
        public TimeUnitEnum? TimeUnit { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReplyWithPattern" /> class.
        /// </summary>
        /// <param name="pattern">Predefined reply pattern name..</param>
        /// <param name="time">Number of time units. Applicable only to WillCallYouBack, CallMeBack patterns..</param>
        /// <param name="timeUnit">Time unit name..</param>
        public ReplyWithPattern(PatternEnum? pattern = default(PatternEnum?), int time = default(int), TimeUnitEnum? timeUnit = default(TimeUnitEnum?))
        {
            this.Pattern = pattern;
            this.Time = time;
            this.TimeUnit = timeUnit;
        }


        /// <summary>
        /// Number of time units. Applicable only to WillCallYouBack, CallMeBack patterns.
        /// </summary>
        /// <value>Number of time units. Applicable only to WillCallYouBack, CallMeBack patterns.</value>
        [DataMember(Name="time", EmitDefaultValue=false)]
        public int Time { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReplyWithPattern {\n");
            sb.Append("  Pattern: ").Append(Pattern).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  TimeUnit: ").Append(TimeUnit).Append("\n");
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
            return this.Equals(input as ReplyWithPattern);
        }

        /// <summary>
        /// Returns true if ReplyWithPattern instances are equal
        /// </summary>
        /// <param name="input">Instance of ReplyWithPattern to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReplyWithPattern input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Pattern == input.Pattern ||
                    (this.Pattern != null &&
                    this.Pattern.Equals(input.Pattern))
                ) && 
                (
                    this.Time == input.Time ||
                    (this.Time != null &&
                    this.Time.Equals(input.Time))
                ) && 
                (
                    this.TimeUnit == input.TimeUnit ||
                    (this.TimeUnit != null &&
                    this.TimeUnit.Equals(input.TimeUnit))
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
                if (this.Pattern != null)
                    hashCode = hashCode * 59 + this.Pattern.GetHashCode();
                if (this.Time != null)
                    hashCode = hashCode * 59 + this.Time.GetHashCode();
                if (this.TimeUnit != null)
                    hashCode = hashCode * 59 + this.TimeUnit.GetHashCode();
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