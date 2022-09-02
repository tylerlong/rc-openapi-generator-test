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
    /// GlipCreateTask
    /// </summary>
    [DataContract]
    public partial class GlipCreateTask :  IEquatable<GlipCreateTask>, IValidatableObject
    {
        /// <summary>
        /// Defines CompletenessCondition
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CompletenessConditionEnum
        {
            /// <summary>
            /// Enum Simple for value: Simple
            /// </summary>
            [EnumMember(Value = "Simple")]
            Simple = 1,

            /// <summary>
            /// Enum AllAssignees for value: AllAssignees
            /// </summary>
            [EnumMember(Value = "AllAssignees")]
            AllAssignees = 2,

            /// <summary>
            /// Enum Percentage for value: Percentage
            /// </summary>
            [EnumMember(Value = "Percentage")]
            Percentage = 3

        }

        /// <summary>
        /// Gets or Sets CompletenessCondition
        /// </summary>
        [DataMember(Name="completenessCondition", EmitDefaultValue=false)]
        public CompletenessConditionEnum? CompletenessCondition { get; set; }
        /// <summary>
        /// Defines Color
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ColorEnum
        {
            /// <summary>
            /// Enum Black for value: Black
            /// </summary>
            [EnumMember(Value = "Black")]
            Black = 1,

            /// <summary>
            /// Enum Red for value: Red
            /// </summary>
            [EnumMember(Value = "Red")]
            Red = 2,

            /// <summary>
            /// Enum Orange for value: Orange
            /// </summary>
            [EnumMember(Value = "Orange")]
            Orange = 3,

            /// <summary>
            /// Enum Yellow for value: Yellow
            /// </summary>
            [EnumMember(Value = "Yellow")]
            Yellow = 4,

            /// <summary>
            /// Enum Green for value: Green
            /// </summary>
            [EnumMember(Value = "Green")]
            Green = 5,

            /// <summary>
            /// Enum Blue for value: Blue
            /// </summary>
            [EnumMember(Value = "Blue")]
            Blue = 6,

            /// <summary>
            /// Enum Purple for value: Purple
            /// </summary>
            [EnumMember(Value = "Purple")]
            Purple = 7,

            /// <summary>
            /// Enum Magenta for value: Magenta
            /// </summary>
            [EnumMember(Value = "Magenta")]
            Magenta = 8

        }

        /// <summary>
        /// Gets or Sets Color
        /// </summary>
        [DataMember(Name="color", EmitDefaultValue=false)]
        public ColorEnum? Color { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GlipCreateTask" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GlipCreateTask() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GlipCreateTask" /> class.
        /// </summary>
        /// <param name="subject">Task name/subject. Max allowed length is 250 characters. (required).</param>
        /// <param name="assignees">assignees (required).</param>
        /// <param name="completenessCondition">completenessCondition (default to CompletenessConditionEnum.Simple).</param>
        /// <param name="startDate">Task start date in UTC time zone..</param>
        /// <param name="dueDate">Task due date/time in UTC time zone..</param>
        /// <param name="color">color (default to ColorEnum.Black).</param>
        /// <param name="section">Task section to group / search by. Max allowed length is 100 characters..</param>
        /// <param name="description">Task details. Max allowed length is 102400 characters (100kB)..</param>
        /// <param name="recurrence">recurrence.</param>
        /// <param name="attachments">attachments.</param>
        public GlipCreateTask(string subject = default(string), List<AssigneeInfo> assignees = default(List<AssigneeInfo>), CompletenessConditionEnum? completenessCondition = CompletenessConditionEnum.Simple, DateTime startDate = default(DateTime), DateTime dueDate = default(DateTime), ColorEnum? color = ColorEnum.Black, string section = default(string), string description = default(string), GlipTaskRecurrenceInfo recurrence = default(GlipTaskRecurrenceInfo), List<GlipAttachmentInfoRequest> attachments = default(List<GlipAttachmentInfoRequest>))
        {
            // to ensure "subject" is required (not null)
            if (subject == null)
            {
                throw new InvalidDataException("subject is a required property for GlipCreateTask and cannot be null");
            }
            else
            {
                this.Subject = subject;
            }

            // to ensure "assignees" is required (not null)
            if (assignees == null)
            {
                throw new InvalidDataException("assignees is a required property for GlipCreateTask and cannot be null");
            }
            else
            {
                this.Assignees = assignees;
            }

            // use default value if no "completenessCondition" provided
            if (completenessCondition == null)
            {
                this.CompletenessCondition = CompletenessConditionEnum.Simple;
            }
            else
            {
                this.CompletenessCondition = completenessCondition;
            }
            this.StartDate = startDate;
            this.DueDate = dueDate;
            // use default value if no "color" provided
            if (color == null)
            {
                this.Color = ColorEnum.Black;
            }
            else
            {
                this.Color = color;
            }
            this.Section = section;
            this.Description = description;
            this.Recurrence = recurrence;
            this.Attachments = attachments;
        }

        /// <summary>
        /// Task name/subject. Max allowed length is 250 characters.
        /// </summary>
        /// <value>Task name/subject. Max allowed length is 250 characters.</value>
        [DataMember(Name="subject", EmitDefaultValue=true)]
        public string Subject { get; set; }

        /// <summary>
        /// Gets or Sets Assignees
        /// </summary>
        [DataMember(Name="assignees", EmitDefaultValue=true)]
        public List<AssigneeInfo> Assignees { get; set; }


        /// <summary>
        /// Task start date in UTC time zone.
        /// </summary>
        /// <value>Task start date in UTC time zone.</value>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Task due date/time in UTC time zone.
        /// </summary>
        /// <value>Task due date/time in UTC time zone.</value>
        [DataMember(Name="dueDate", EmitDefaultValue=false)]
        public DateTime DueDate { get; set; }


        /// <summary>
        /// Task section to group / search by. Max allowed length is 100 characters.
        /// </summary>
        /// <value>Task section to group / search by. Max allowed length is 100 characters.</value>
        [DataMember(Name="section", EmitDefaultValue=false)]
        public string Section { get; set; }

        /// <summary>
        /// Task details. Max allowed length is 102400 characters (100kB).
        /// </summary>
        /// <value>Task details. Max allowed length is 102400 characters (100kB).</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Recurrence
        /// </summary>
        [DataMember(Name="recurrence", EmitDefaultValue=false)]
        public GlipTaskRecurrenceInfo Recurrence { get; set; }

        /// <summary>
        /// Gets or Sets Attachments
        /// </summary>
        [DataMember(Name="attachments", EmitDefaultValue=false)]
        public List<GlipAttachmentInfoRequest> Attachments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GlipCreateTask {\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  Assignees: ").Append(Assignees).Append("\n");
            sb.Append("  CompletenessCondition: ").Append(CompletenessCondition).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  DueDate: ").Append(DueDate).Append("\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
            sb.Append("  Section: ").Append(Section).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Recurrence: ").Append(Recurrence).Append("\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
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
            return this.Equals(input as GlipCreateTask);
        }

        /// <summary>
        /// Returns true if GlipCreateTask instances are equal
        /// </summary>
        /// <param name="input">Instance of GlipCreateTask to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GlipCreateTask input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.Assignees == input.Assignees ||
                    this.Assignees != null &&
                    input.Assignees != null &&
                    this.Assignees.SequenceEqual(input.Assignees)
                ) && 
                (
                    this.CompletenessCondition == input.CompletenessCondition ||
                    (this.CompletenessCondition != null &&
                    this.CompletenessCondition.Equals(input.CompletenessCondition))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.DueDate == input.DueDate ||
                    (this.DueDate != null &&
                    this.DueDate.Equals(input.DueDate))
                ) && 
                (
                    this.Color == input.Color ||
                    (this.Color != null &&
                    this.Color.Equals(input.Color))
                ) && 
                (
                    this.Section == input.Section ||
                    (this.Section != null &&
                    this.Section.Equals(input.Section))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Recurrence == input.Recurrence ||
                    (this.Recurrence != null &&
                    this.Recurrence.Equals(input.Recurrence))
                ) && 
                (
                    this.Attachments == input.Attachments ||
                    this.Attachments != null &&
                    input.Attachments != null &&
                    this.Attachments.SequenceEqual(input.Attachments)
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
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.Assignees != null)
                    hashCode = hashCode * 59 + this.Assignees.GetHashCode();
                if (this.CompletenessCondition != null)
                    hashCode = hashCode * 59 + this.CompletenessCondition.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.DueDate != null)
                    hashCode = hashCode * 59 + this.DueDate.GetHashCode();
                if (this.Color != null)
                    hashCode = hashCode * 59 + this.Color.GetHashCode();
                if (this.Section != null)
                    hashCode = hashCode * 59 + this.Section.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Recurrence != null)
                    hashCode = hashCode * 59 + this.Recurrence.GetHashCode();
                if (this.Attachments != null)
                    hashCode = hashCode * 59 + this.Attachments.GetHashCode();
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