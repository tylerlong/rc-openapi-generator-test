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
    /// MessageStoreReport
    /// </summary>
    [DataContract]
    public partial class MessageStoreReport :  IEquatable<MessageStoreReport>, IValidatableObject
    {
        /// <summary>
        /// Status of a message store report task
        /// </summary>
        /// <value>Status of a message store report task</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Accepted for value: Accepted
            /// </summary>
            [EnumMember(Value = "Accepted")]
            Accepted = 1,

            /// <summary>
            /// Enum Pending for value: Pending
            /// </summary>
            [EnumMember(Value = "Pending")]
            Pending = 2,

            /// <summary>
            /// Enum InProgress for value: InProgress
            /// </summary>
            [EnumMember(Value = "InProgress")]
            InProgress = 3,

            /// <summary>
            /// Enum AttemptFailed for value: AttemptFailed
            /// </summary>
            [EnumMember(Value = "AttemptFailed")]
            AttemptFailed = 4,

            /// <summary>
            /// Enum Failed for value: Failed
            /// </summary>
            [EnumMember(Value = "Failed")]
            Failed = 5,

            /// <summary>
            /// Enum Completed for value: Completed
            /// </summary>
            [EnumMember(Value = "Completed")]
            Completed = 6,

            /// <summary>
            /// Enum Cancelled for value: Cancelled
            /// </summary>
            [EnumMember(Value = "Cancelled")]
            Cancelled = 7

        }

        /// <summary>
        /// Status of a message store report task
        /// </summary>
        /// <value>Status of a message store report task</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageStoreReport" /> class.
        /// </summary>
        /// <param name="id">Internal identifier of a message store report task.</param>
        /// <param name="uri">Canonical URI of a task.</param>
        /// <param name="status">Status of a message store report task.</param>
        /// <param name="accountId">Internal identifier of an account.</param>
        /// <param name="extensionId">Internal identifier of an extension.</param>
        /// <param name="dateTo">The end of the time range to collect message records in ISO 8601 format including timezone.</param>
        /// <param name="dateFrom">The beginning of the time range to collect call log records in ISO 8601 format including timezone.</param>
        /// <param name="startTime">The time when this task was started.</param>
        /// <param name="finishTime">The time when this task was finished.</param>
        /// <param name="messageTypes">Type of messages to be collected..</param>
        public MessageStoreReport(string id = default(string), string uri = default(string), StatusEnum? status = default(StatusEnum?), string accountId = default(string), string extensionId = default(string), DateTime dateTo = default(DateTime), DateTime dateFrom = default(DateTime), DateTime startTime = default(DateTime), DateTime finishTime = default(DateTime), List<MessageTypeEnum> messageTypes = default(List<MessageTypeEnum>))
        {
            this.Id = id;
            this.Uri = uri;
            this.Status = status;
            this.AccountId = accountId;
            this.ExtensionId = extensionId;
            this.DateTo = dateTo;
            this.DateFrom = dateFrom;
            this.StartTime = startTime;
            this.FinishTime = finishTime;
            this.MessageTypes = messageTypes;
        }

        /// <summary>
        /// Internal identifier of a message store report task
        /// </summary>
        /// <value>Internal identifier of a message store report task</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Canonical URI of a task
        /// </summary>
        /// <value>Canonical URI of a task</value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }


        /// <summary>
        /// Internal identifier of an account
        /// </summary>
        /// <value>Internal identifier of an account</value>
        [DataMember(Name="accountId", EmitDefaultValue=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// Internal identifier of an extension
        /// </summary>
        /// <value>Internal identifier of an extension</value>
        [DataMember(Name="extensionId", EmitDefaultValue=false)]
        public string ExtensionId { get; set; }

        /// <summary>
        /// The end of the time range to collect message records in ISO 8601 format including timezone
        /// </summary>
        /// <value>The end of the time range to collect message records in ISO 8601 format including timezone</value>
        [DataMember(Name="dateTo", EmitDefaultValue=false)]
        public DateTime DateTo { get; set; }

        /// <summary>
        /// The beginning of the time range to collect call log records in ISO 8601 format including timezone
        /// </summary>
        /// <value>The beginning of the time range to collect call log records in ISO 8601 format including timezone</value>
        [DataMember(Name="dateFrom", EmitDefaultValue=false)]
        public DateTime DateFrom { get; set; }

        /// <summary>
        /// The time when this task was started
        /// </summary>
        /// <value>The time when this task was started</value>
        [DataMember(Name="startTime", EmitDefaultValue=false)]
        public DateTime StartTime { get; set; }

        /// <summary>
        /// The time when this task was finished
        /// </summary>
        /// <value>The time when this task was finished</value>
        [DataMember(Name="finishTime", EmitDefaultValue=false)]
        public DateTime FinishTime { get; set; }

        /// <summary>
        /// Type of messages to be collected.
        /// </summary>
        /// <value>Type of messages to be collected.</value>
        [DataMember(Name="messageTypes", EmitDefaultValue=false)]
        public List<MessageTypeEnum> MessageTypes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessageStoreReport {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  ExtensionId: ").Append(ExtensionId).Append("\n");
            sb.Append("  DateTo: ").Append(DateTo).Append("\n");
            sb.Append("  DateFrom: ").Append(DateFrom).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  FinishTime: ").Append(FinishTime).Append("\n");
            sb.Append("  MessageTypes: ").Append(MessageTypes).Append("\n");
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
            return this.Equals(input as MessageStoreReport);
        }

        /// <summary>
        /// Returns true if MessageStoreReport instances are equal
        /// </summary>
        /// <param name="input">Instance of MessageStoreReport to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessageStoreReport input)
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
                    this.Uri == input.Uri ||
                    (this.Uri != null &&
                    this.Uri.Equals(input.Uri))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.ExtensionId == input.ExtensionId ||
                    (this.ExtensionId != null &&
                    this.ExtensionId.Equals(input.ExtensionId))
                ) && 
                (
                    this.DateTo == input.DateTo ||
                    (this.DateTo != null &&
                    this.DateTo.Equals(input.DateTo))
                ) && 
                (
                    this.DateFrom == input.DateFrom ||
                    (this.DateFrom != null &&
                    this.DateFrom.Equals(input.DateFrom))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.FinishTime == input.FinishTime ||
                    (this.FinishTime != null &&
                    this.FinishTime.Equals(input.FinishTime))
                ) && 
                (
                    this.MessageTypes == input.MessageTypes ||
                    this.MessageTypes != null &&
                    input.MessageTypes != null &&
                    this.MessageTypes.SequenceEqual(input.MessageTypes)
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
                if (this.Uri != null)
                    hashCode = hashCode * 59 + this.Uri.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.AccountId != null)
                    hashCode = hashCode * 59 + this.AccountId.GetHashCode();
                if (this.ExtensionId != null)
                    hashCode = hashCode * 59 + this.ExtensionId.GetHashCode();
                if (this.DateTo != null)
                    hashCode = hashCode * 59 + this.DateTo.GetHashCode();
                if (this.DateFrom != null)
                    hashCode = hashCode * 59 + this.DateFrom.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.FinishTime != null)
                    hashCode = hashCode * 59 + this.FinishTime.GetHashCode();
                if (this.MessageTypes != null)
                    hashCode = hashCode * 59 + this.MessageTypes.GetHashCode();
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
