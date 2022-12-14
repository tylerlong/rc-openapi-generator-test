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
    /// Meeting recurrence information
    /// </summary>
    [DataContract]
    public partial class RecurrenceInfo :  IEquatable<RecurrenceInfo>, IValidatableObject
    {
        /// <summary>
        /// Recurrence time frame
        /// </summary>
        /// <value>Recurrence time frame</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FrequencyEnum
        {
            /// <summary>
            /// Enum Daily for value: Daily
            /// </summary>
            [EnumMember(Value = "Daily")]
            Daily = 1,

            /// <summary>
            /// Enum Weekly for value: Weekly
            /// </summary>
            [EnumMember(Value = "Weekly")]
            Weekly = 2,

            /// <summary>
            /// Enum Monthly for value: Monthly
            /// </summary>
            [EnumMember(Value = "Monthly")]
            Monthly = 3

        }

        /// <summary>
        /// Recurrence time frame
        /// </summary>
        /// <value>Recurrence time frame</value>
        [DataMember(Name="frequency", EmitDefaultValue=false)]
        public FrequencyEnum? Frequency { get; set; }
        /// <summary>
        /// Supported together with &#x60;weeklyByDay&#x60;
        /// </summary>
        /// <value>Supported together with &#x60;weeklyByDay&#x60;</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MonthlyByWeekEnum
        {
            /// <summary>
            /// Enum Last for value: Last
            /// </summary>
            [EnumMember(Value = "Last")]
            Last = 1,

            /// <summary>
            /// Enum First for value: First
            /// </summary>
            [EnumMember(Value = "First")]
            First = 2,

            /// <summary>
            /// Enum Second for value: Second
            /// </summary>
            [EnumMember(Value = "Second")]
            Second = 3,

            /// <summary>
            /// Enum Third for value: Third
            /// </summary>
            [EnumMember(Value = "Third")]
            Third = 4,

            /// <summary>
            /// Enum Fourth for value: Fourth
            /// </summary>
            [EnumMember(Value = "Fourth")]
            Fourth = 5

        }

        /// <summary>
        /// Supported together with &#x60;weeklyByDay&#x60;
        /// </summary>
        /// <value>Supported together with &#x60;weeklyByDay&#x60;</value>
        [DataMember(Name="monthlyByWeek", EmitDefaultValue=false)]
        public MonthlyByWeekEnum? MonthlyByWeek { get; set; }
        /// <summary>
        /// This field is used only if you&#39;re scheduling a recurring meeting of type &#x60;3&#x60; to state which day in a month the meeting should recur. The value range is 1 - 31. For instance, if the meeting should recur each month on 23rd, provide &#x60;23&#x60; as the value of this field and &#x60;1&#x60; as the value of the recurrence &#x60;interval&#x60; field. And if the meeting should recur every three months, on 23rd of the month, change the value of the recurrence &#x60;interval&#x60; field to &#x60;3&#x60;.
        /// </summary>
        /// <value>This field is used only if you&#39;re scheduling a recurring meeting of type &#x60;3&#x60; to state which day in a month the meeting should recur. The value range is 1 - 31. For instance, if the meeting should recur each month on 23rd, provide &#x60;23&#x60; as the value of this field and &#x60;1&#x60; as the value of the recurrence &#x60;interval&#x60; field. And if the meeting should recur every three months, on 23rd of the month, change the value of the recurrence &#x60;interval&#x60; field to &#x60;3&#x60;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum WeeklyByDayEnum
        {
            /// <summary>
            /// Enum Sunday for value: Sunday
            /// </summary>
            [EnumMember(Value = "Sunday")]
            Sunday = 1,

            /// <summary>
            /// Enum Monday for value: Monday
            /// </summary>
            [EnumMember(Value = "Monday")]
            Monday = 2,

            /// <summary>
            /// Enum Tuesday for value: Tuesday
            /// </summary>
            [EnumMember(Value = "Tuesday")]
            Tuesday = 3,

            /// <summary>
            /// Enum Wednesday for value: Wednesday
            /// </summary>
            [EnumMember(Value = "Wednesday")]
            Wednesday = 4,

            /// <summary>
            /// Enum Thursday for value: Thursday
            /// </summary>
            [EnumMember(Value = "Thursday")]
            Thursday = 5,

            /// <summary>
            /// Enum Friday for value: Friday
            /// </summary>
            [EnumMember(Value = "Friday")]
            Friday = 6,

            /// <summary>
            /// Enum Saturday for value: Saturday
            /// </summary>
            [EnumMember(Value = "Saturday")]
            Saturday = 7

        }

        /// <summary>
        /// This field is used only if you&#39;re scheduling a recurring meeting of type &#x60;3&#x60; to state which day in a month the meeting should recur. The value range is 1 - 31. For instance, if the meeting should recur each month on 23rd, provide &#x60;23&#x60; as the value of this field and &#x60;1&#x60; as the value of the recurrence &#x60;interval&#x60; field. And if the meeting should recur every three months, on 23rd of the month, change the value of the recurrence &#x60;interval&#x60; field to &#x60;3&#x60;.
        /// </summary>
        /// <value>This field is used only if you&#39;re scheduling a recurring meeting of type &#x60;3&#x60; to state which day in a month the meeting should recur. The value range is 1 - 31. For instance, if the meeting should recur each month on 23rd, provide &#x60;23&#x60; as the value of this field and &#x60;1&#x60; as the value of the recurrence &#x60;interval&#x60; field. And if the meeting should recur every three months, on 23rd of the month, change the value of the recurrence &#x60;interval&#x60; field to &#x60;3&#x60;.</value>
        [DataMember(Name="weeklyByDay", EmitDefaultValue=false)]
        public WeeklyByDayEnum? WeeklyByDay { get; set; }
        /// <summary>
        /// This field is used only if you&#39;re scheduling a recurring meeting of type &#x60;2&#x60; to state which day(s) of the week the meeting should recur. The values are: 1 - Sunday; 2 - Monday; 3- Tuesday; 4 - Wednesday; 5 - Thursday; 6 - Friday; 7 - Saturday. Multiple values are supported, should be specified separated by comma
        /// </summary>
        /// <value>This field is used only if you&#39;re scheduling a recurring meeting of type &#x60;2&#x60; to state which day(s) of the week the meeting should recur. The values are: 1 - Sunday; 2 - Monday; 3- Tuesday; 4 - Wednesday; 5 - Thursday; 6 - Friday; 7 - Saturday. Multiple values are supported, should be specified separated by comma</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum WeeklyByDaysEnum
        {
            /// <summary>
            /// Enum Sunday for value: Sunday
            /// </summary>
            [EnumMember(Value = "Sunday")]
            Sunday = 1,

            /// <summary>
            /// Enum Monday for value: Monday
            /// </summary>
            [EnumMember(Value = "Monday")]
            Monday = 2,

            /// <summary>
            /// Enum Tuesday for value: Tuesday
            /// </summary>
            [EnumMember(Value = "Tuesday")]
            Tuesday = 3,

            /// <summary>
            /// Enum Wednesday for value: Wednesday
            /// </summary>
            [EnumMember(Value = "Wednesday")]
            Wednesday = 4,

            /// <summary>
            /// Enum Thursday for value: Thursday
            /// </summary>
            [EnumMember(Value = "Thursday")]
            Thursday = 5,

            /// <summary>
            /// Enum Friday for value: Friday
            /// </summary>
            [EnumMember(Value = "Friday")]
            Friday = 6,

            /// <summary>
            /// Enum Saturday for value: Saturday
            /// </summary>
            [EnumMember(Value = "Saturday")]
            Saturday = 7

        }

        /// <summary>
        /// This field is used only if you&#39;re scheduling a recurring meeting of type &#x60;2&#x60; to state which day(s) of the week the meeting should recur. The values are: 1 - Sunday; 2 - Monday; 3- Tuesday; 4 - Wednesday; 5 - Thursday; 6 - Friday; 7 - Saturday. Multiple values are supported, should be specified separated by comma
        /// </summary>
        /// <value>This field is used only if you&#39;re scheduling a recurring meeting of type &#x60;2&#x60; to state which day(s) of the week the meeting should recur. The values are: 1 - Sunday; 2 - Monday; 3- Tuesday; 4 - Wednesday; 5 - Thursday; 6 - Friday; 7 - Saturday. Multiple values are supported, should be specified separated by comma</value>
        [DataMember(Name="weeklyByDays", EmitDefaultValue=false)]
        public WeeklyByDaysEnum? WeeklyByDays { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RecurrenceInfo" /> class.
        /// </summary>
        /// <param name="frequency">Recurrence time frame.</param>
        /// <param name="interval">Reccurence interval. The supported ranges are: 1-90 for &#x60;Daily&#x60;; 1-12 for &#x60;Weekly&#x60;; 1-3 for &#x60;Monthly&#x60;.</param>
        /// <param name="monthlyByWeek">Supported together with &#x60;weeklyByDay&#x60;.</param>
        /// <param name="weeklyByDay">This field is used only if you&#39;re scheduling a recurring meeting of type &#x60;3&#x60; to state which day in a month the meeting should recur. The value range is 1 - 31. For instance, if the meeting should recur each month on 23rd, provide &#x60;23&#x60; as the value of this field and &#x60;1&#x60; as the value of the recurrence &#x60;interval&#x60; field. And if the meeting should recur every three months, on 23rd of the month, change the value of the recurrence &#x60;interval&#x60; field to &#x60;3&#x60;..</param>
        /// <param name="weeklyByDays">This field is used only if you&#39;re scheduling a recurring meeting of type &#x60;2&#x60; to state which day(s) of the week the meeting should recur. The values are: 1 - Sunday; 2 - Monday; 3- Tuesday; 4 - Wednesday; 5 - Thursday; 6 - Friday; 7 - Saturday. Multiple values are supported, should be specified separated by comma.</param>
        /// <param name="monthlyByDay">The supported range is 1-31.</param>
        /// <param name="monthlyByWeekDay">This field is used only if you&#39;re scheduling a recurring meeting of type &#x60;3&#x60; to state a specific day in a week when the monthly meeting should recur; it works together with &#x60;MonthlyByWeek&#x60; field. The values are: 1 - Sunday; 2 - Monday; 3 - Tuesday; 4 - Wednesday; 5 - Thursday; 6 - Friday; 7- Saturday.</param>
        /// <param name="count">Number of meeting occurrences.</param>
        /// <param name="until">Meeting expiration datetime.</param>
        public RecurrenceInfo(FrequencyEnum? frequency = default(FrequencyEnum?), int interval = default(int), MonthlyByWeekEnum? monthlyByWeek = default(MonthlyByWeekEnum?), WeeklyByDayEnum? weeklyByDay = default(WeeklyByDayEnum?), WeeklyByDaysEnum? weeklyByDays = default(WeeklyByDaysEnum?), int monthlyByDay = default(int), int monthlyByWeekDay = default(int), int count = default(int), string until = default(string))
        {
            this.Frequency = frequency;
            this.Interval = interval;
            this.MonthlyByWeek = monthlyByWeek;
            this.WeeklyByDay = weeklyByDay;
            this.WeeklyByDays = weeklyByDays;
            this.MonthlyByDay = monthlyByDay;
            this.MonthlyByWeekDay = monthlyByWeekDay;
            this.Count = count;
            this.Until = until;
        }


        /// <summary>
        /// Reccurence interval. The supported ranges are: 1-90 for &#x60;Daily&#x60;; 1-12 for &#x60;Weekly&#x60;; 1-3 for &#x60;Monthly&#x60;
        /// </summary>
        /// <value>Reccurence interval. The supported ranges are: 1-90 for &#x60;Daily&#x60;; 1-12 for &#x60;Weekly&#x60;; 1-3 for &#x60;Monthly&#x60;</value>
        [DataMember(Name="interval", EmitDefaultValue=false)]
        public int Interval { get; set; }




        /// <summary>
        /// The supported range is 1-31
        /// </summary>
        /// <value>The supported range is 1-31</value>
        [DataMember(Name="monthlyByDay", EmitDefaultValue=false)]
        public int MonthlyByDay { get; set; }

        /// <summary>
        /// This field is used only if you&#39;re scheduling a recurring meeting of type &#x60;3&#x60; to state a specific day in a week when the monthly meeting should recur; it works together with &#x60;MonthlyByWeek&#x60; field. The values are: 1 - Sunday; 2 - Monday; 3 - Tuesday; 4 - Wednesday; 5 - Thursday; 6 - Friday; 7- Saturday
        /// </summary>
        /// <value>This field is used only if you&#39;re scheduling a recurring meeting of type &#x60;3&#x60; to state a specific day in a week when the monthly meeting should recur; it works together with &#x60;MonthlyByWeek&#x60; field. The values are: 1 - Sunday; 2 - Monday; 3 - Tuesday; 4 - Wednesday; 5 - Thursday; 6 - Friday; 7- Saturday</value>
        [DataMember(Name="monthlyByWeekDay", EmitDefaultValue=false)]
        public int MonthlyByWeekDay { get; set; }

        /// <summary>
        /// Number of meeting occurrences
        /// </summary>
        /// <value>Number of meeting occurrences</value>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public int Count { get; set; }

        /// <summary>
        /// Meeting expiration datetime
        /// </summary>
        /// <value>Meeting expiration datetime</value>
        [DataMember(Name="until", EmitDefaultValue=false)]
        public string Until { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecurrenceInfo {\n");
            sb.Append("  Frequency: ").Append(Frequency).Append("\n");
            sb.Append("  Interval: ").Append(Interval).Append("\n");
            sb.Append("  MonthlyByWeek: ").Append(MonthlyByWeek).Append("\n");
            sb.Append("  WeeklyByDay: ").Append(WeeklyByDay).Append("\n");
            sb.Append("  WeeklyByDays: ").Append(WeeklyByDays).Append("\n");
            sb.Append("  MonthlyByDay: ").Append(MonthlyByDay).Append("\n");
            sb.Append("  MonthlyByWeekDay: ").Append(MonthlyByWeekDay).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Until: ").Append(Until).Append("\n");
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
            return this.Equals(input as RecurrenceInfo);
        }

        /// <summary>
        /// Returns true if RecurrenceInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of RecurrenceInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecurrenceInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Frequency == input.Frequency ||
                    (this.Frequency != null &&
                    this.Frequency.Equals(input.Frequency))
                ) && 
                (
                    this.Interval == input.Interval ||
                    (this.Interval != null &&
                    this.Interval.Equals(input.Interval))
                ) && 
                (
                    this.MonthlyByWeek == input.MonthlyByWeek ||
                    (this.MonthlyByWeek != null &&
                    this.MonthlyByWeek.Equals(input.MonthlyByWeek))
                ) && 
                (
                    this.WeeklyByDay == input.WeeklyByDay ||
                    (this.WeeklyByDay != null &&
                    this.WeeklyByDay.Equals(input.WeeklyByDay))
                ) && 
                (
                    this.WeeklyByDays == input.WeeklyByDays ||
                    (this.WeeklyByDays != null &&
                    this.WeeklyByDays.Equals(input.WeeklyByDays))
                ) && 
                (
                    this.MonthlyByDay == input.MonthlyByDay ||
                    (this.MonthlyByDay != null &&
                    this.MonthlyByDay.Equals(input.MonthlyByDay))
                ) && 
                (
                    this.MonthlyByWeekDay == input.MonthlyByWeekDay ||
                    (this.MonthlyByWeekDay != null &&
                    this.MonthlyByWeekDay.Equals(input.MonthlyByWeekDay))
                ) && 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
                ) && 
                (
                    this.Until == input.Until ||
                    (this.Until != null &&
                    this.Until.Equals(input.Until))
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
                if (this.Frequency != null)
                    hashCode = hashCode * 59 + this.Frequency.GetHashCode();
                if (this.Interval != null)
                    hashCode = hashCode * 59 + this.Interval.GetHashCode();
                if (this.MonthlyByWeek != null)
                    hashCode = hashCode * 59 + this.MonthlyByWeek.GetHashCode();
                if (this.WeeklyByDay != null)
                    hashCode = hashCode * 59 + this.WeeklyByDay.GetHashCode();
                if (this.WeeklyByDays != null)
                    hashCode = hashCode * 59 + this.WeeklyByDays.GetHashCode();
                if (this.MonthlyByDay != null)
                    hashCode = hashCode * 59 + this.MonthlyByDay.GetHashCode();
                if (this.MonthlyByWeekDay != null)
                    hashCode = hashCode * 59 + this.MonthlyByWeekDay.GetHashCode();
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.Until != null)
                    hashCode = hashCode * 59 + this.Until.GetHashCode();
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
