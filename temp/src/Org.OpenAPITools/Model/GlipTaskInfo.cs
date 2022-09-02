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
    /// GlipTaskInfo
    /// </summary>
    [DataContract]
    public partial class GlipTaskInfo :  IEquatable<GlipTaskInfo>, IValidatableObject
    {
        /// <summary>
        /// Type of a task
        /// </summary>
        /// <value>Type of a task</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Task for value: Task
            /// </summary>
            [EnumMember(Value = "Task")]
            Task = 1

        }

        /// <summary>
        /// Type of a task
        /// </summary>
        /// <value>Type of a task</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Status of task execution
        /// </summary>
        /// <value>Status of task execution</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Pending for value: Pending
            /// </summary>
            [EnumMember(Value = "Pending")]
            Pending = 1,

            /// <summary>
            /// Enum InProgress for value: InProgress
            /// </summary>
            [EnumMember(Value = "InProgress")]
            InProgress = 2,

            /// <summary>
            /// Enum Completed for value: Completed
            /// </summary>
            [EnumMember(Value = "Completed")]
            Completed = 3

        }

        /// <summary>
        /// Status of task execution
        /// </summary>
        /// <value>Status of task execution</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Specifies how to determine task completeness
        /// </summary>
        /// <value>Specifies how to determine task completeness</value>
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
        /// Specifies how to determine task completeness
        /// </summary>
        /// <value>Specifies how to determine task completeness</value>
        [DataMember(Name="completenessCondition", EmitDefaultValue=false)]
        public CompletenessConditionEnum? CompletenessCondition { get; set; }
        /// <summary>
        /// Font color of a post with the current task
        /// </summary>
        /// <value>Font color of a post with the current task</value>
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
        /// Font color of a post with the current task
        /// </summary>
        /// <value>Font color of a post with the current task</value>
        [DataMember(Name="color", EmitDefaultValue=false)]
        public ColorEnum? Color { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GlipTaskInfo" /> class.
        /// </summary>
        /// <param name="id">Internal identifier of a task.</param>
        /// <param name="creationTime">Datetime of the task creation in UTC time zone..</param>
        /// <param name="lastModifiedTime">Datetime of the last modification of the task in UTC time zone..</param>
        /// <param name="type">Type of a task.</param>
        /// <param name="creator">creator.</param>
        /// <param name="chatIds">Chat IDs where the task is posted or shared..</param>
        /// <param name="status">Status of task execution.</param>
        /// <param name="subject">Name/subject of a task.</param>
        /// <param name="assignees">assignees.</param>
        /// <param name="completenessCondition">Specifies how to determine task completeness.</param>
        /// <param name="completenessPercentage">Current completeness percentage of the task with the specified percentage completeness condition.</param>
        /// <param name="startDate">Task start date.</param>
        /// <param name="dueDate">Task due date/time.</param>
        /// <param name="color">Font color of a post with the current task.</param>
        /// <param name="section">Task section to group/search by.</param>
        /// <param name="description">Task details.</param>
        /// <param name="recurrence">recurrence.</param>
        /// <param name="attachments">attachments.</param>
        public GlipTaskInfo(string id = default(string), string creationTime = default(string), string lastModifiedTime = default(string), TypeEnum? type = default(TypeEnum?), GlipCreatorInfo creator = default(GlipCreatorInfo), List<string> chatIds = default(List<string>), StatusEnum? status = default(StatusEnum?), string subject = default(string), List<TaskAssigneeInfo> assignees = default(List<TaskAssigneeInfo>), CompletenessConditionEnum? completenessCondition = default(CompletenessConditionEnum?), int completenessPercentage = default(int), DateTime startDate = default(DateTime), DateTime dueDate = default(DateTime), ColorEnum? color = default(ColorEnum?), string section = default(string), string description = default(string), GlipTaskRecurrenceInfo recurrence = default(GlipTaskRecurrenceInfo), List<TaskAttachment> attachments = default(List<TaskAttachment>))
        {
            this.Id = id;
            this.CreationTime = creationTime;
            this.LastModifiedTime = lastModifiedTime;
            this.Type = type;
            this.Creator = creator;
            this.ChatIds = chatIds;
            this.Status = status;
            this.Subject = subject;
            this.Assignees = assignees;
            this.CompletenessCondition = completenessCondition;
            this.CompletenessPercentage = completenessPercentage;
            this.StartDate = startDate;
            this.DueDate = dueDate;
            this.Color = color;
            this.Section = section;
            this.Description = description;
            this.Recurrence = recurrence;
            this.Attachments = attachments;
        }

        /// <summary>
        /// Internal identifier of a task
        /// </summary>
        /// <value>Internal identifier of a task</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Datetime of the task creation in UTC time zone.
        /// </summary>
        /// <value>Datetime of the task creation in UTC time zone.</value>
        [DataMember(Name="creationTime", EmitDefaultValue=false)]
        public string CreationTime { get; set; }

        /// <summary>
        /// Datetime of the last modification of the task in UTC time zone.
        /// </summary>
        /// <value>Datetime of the last modification of the task in UTC time zone.</value>
        [DataMember(Name="lastModifiedTime", EmitDefaultValue=false)]
        public string LastModifiedTime { get; set; }


        /// <summary>
        /// Gets or Sets Creator
        /// </summary>
        [DataMember(Name="creator", EmitDefaultValue=false)]
        public GlipCreatorInfo Creator { get; set; }

        /// <summary>
        /// Chat IDs where the task is posted or shared.
        /// </summary>
        /// <value>Chat IDs where the task is posted or shared.</value>
        [DataMember(Name="chatIds", EmitDefaultValue=false)]
        public List<string> ChatIds { get; set; }


        /// <summary>
        /// Name/subject of a task
        /// </summary>
        /// <value>Name/subject of a task</value>
        [DataMember(Name="subject", EmitDefaultValue=false)]
        public string Subject { get; set; }

        /// <summary>
        /// Gets or Sets Assignees
        /// </summary>
        [DataMember(Name="assignees", EmitDefaultValue=false)]
        public List<TaskAssigneeInfo> Assignees { get; set; }


        /// <summary>
        /// Current completeness percentage of the task with the specified percentage completeness condition
        /// </summary>
        /// <value>Current completeness percentage of the task with the specified percentage completeness condition</value>
        [DataMember(Name="completenessPercentage", EmitDefaultValue=false)]
        public int CompletenessPercentage { get; set; }

        /// <summary>
        /// Task start date
        /// </summary>
        /// <value>Task start date</value>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Task due date/time
        /// </summary>
        /// <value>Task due date/time</value>
        [DataMember(Name="dueDate", EmitDefaultValue=false)]
        public DateTime DueDate { get; set; }


        /// <summary>
        /// Task section to group/search by
        /// </summary>
        /// <value>Task section to group/search by</value>
        [DataMember(Name="section", EmitDefaultValue=false)]
        public string Section { get; set; }

        /// <summary>
        /// Task details
        /// </summary>
        /// <value>Task details</value>
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
        public List<TaskAttachment> Attachments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GlipTaskInfo {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreationTime: ").Append(CreationTime).Append("\n");
            sb.Append("  LastModifiedTime: ").Append(LastModifiedTime).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Creator: ").Append(Creator).Append("\n");
            sb.Append("  ChatIds: ").Append(ChatIds).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  Assignees: ").Append(Assignees).Append("\n");
            sb.Append("  CompletenessCondition: ").Append(CompletenessCondition).Append("\n");
            sb.Append("  CompletenessPercentage: ").Append(CompletenessPercentage).Append("\n");
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
            return this.Equals(input as GlipTaskInfo);
        }

        /// <summary>
        /// Returns true if GlipTaskInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of GlipTaskInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GlipTaskInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.CreationTime == input.CreationTime ||
                    (this.CreationTime != null &&
                    this.CreationTime.Equals(input.CreationTime))
                ) && 
                (
                    this.LastModifiedTime == input.LastModifiedTime ||
                    (this.LastModifiedTime != null &&
                    this.LastModifiedTime.Equals(input.LastModifiedTime))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Creator == input.Creator ||
                    (this.Creator != null &&
                    this.Creator.Equals(input.Creator))
                ) && 
                (
                    this.ChatIds == input.ChatIds ||
                    this.ChatIds != null &&
                    input.ChatIds != null &&
                    this.ChatIds.SequenceEqual(input.ChatIds)
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
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
                    this.CompletenessPercentage == input.CompletenessPercentage ||
                    (this.CompletenessPercentage != null &&
                    this.CompletenessPercentage.Equals(input.CompletenessPercentage))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.CreationTime != null)
                    hashCode = hashCode * 59 + this.CreationTime.GetHashCode();
                if (this.LastModifiedTime != null)
                    hashCode = hashCode * 59 + this.LastModifiedTime.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Creator != null)
                    hashCode = hashCode * 59 + this.Creator.GetHashCode();
                if (this.ChatIds != null)
                    hashCode = hashCode * 59 + this.ChatIds.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.Assignees != null)
                    hashCode = hashCode * 59 + this.Assignees.GetHashCode();
                if (this.CompletenessCondition != null)
                    hashCode = hashCode * 59 + this.CompletenessCondition.GetHashCode();
                if (this.CompletenessPercentage != null)
                    hashCode = hashCode * 59 + this.CompletenessPercentage.GetHashCode();
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


            // CompletenessPercentage (int) maximum
            if(this.CompletenessPercentage > (int)100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CompletenessPercentage, must be a value less than or equal to 100.", new [] { "CompletenessPercentage" });
            }

            // CompletenessPercentage (int) minimum
            if(this.CompletenessPercentage < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CompletenessPercentage, must be a value greater than or equal to 0.", new [] { "CompletenessPercentage" });
            }

            yield break;
        }
    }

}