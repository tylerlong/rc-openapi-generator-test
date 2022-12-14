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
    /// GetInternalTextMessageInfoResponse
    /// </summary>
    [DataContract]
    public partial class GetInternalTextMessageInfoResponse :  IEquatable<GetInternalTextMessageInfoResponse>, IValidatableObject
    {
        /// <summary>
        /// Message availability status. Message in &#39;Deleted&#39; state is still preserved with all its attachments and can be restored. &#39;Purged&#39; means that all attachments are already deleted and the message itself is about to be physically deleted shortly
        /// </summary>
        /// <value>Message availability status. Message in &#39;Deleted&#39; state is still preserved with all its attachments and can be restored. &#39;Purged&#39; means that all attachments are already deleted and the message itself is about to be physically deleted shortly</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AvailabilityEnum
        {
            /// <summary>
            /// Enum Alive for value: Alive
            /// </summary>
            [EnumMember(Value = "Alive")]
            Alive = 1,

            /// <summary>
            /// Enum Deleted for value: Deleted
            /// </summary>
            [EnumMember(Value = "Deleted")]
            Deleted = 2,

            /// <summary>
            /// Enum Purged for value: Purged
            /// </summary>
            [EnumMember(Value = "Purged")]
            Purged = 3

        }

        /// <summary>
        /// Message availability status. Message in &#39;Deleted&#39; state is still preserved with all its attachments and can be restored. &#39;Purged&#39; means that all attachments are already deleted and the message itself is about to be physically deleted shortly
        /// </summary>
        /// <value>Message availability status. Message in &#39;Deleted&#39; state is still preserved with all its attachments and can be restored. &#39;Purged&#39; means that all attachments are already deleted and the message itself is about to be physically deleted shortly</value>
        [DataMember(Name="availability", EmitDefaultValue=false)]
        public AvailabilityEnum? Availability { get; set; }
        /// <summary>
        /// Message direction. Note that for some message types not all directions are allowed. For example voicemail messages can be only inbound
        /// </summary>
        /// <value>Message direction. Note that for some message types not all directions are allowed. For example voicemail messages can be only inbound</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DirectionEnum
        {
            /// <summary>
            /// Enum Inbound for value: Inbound
            /// </summary>
            [EnumMember(Value = "Inbound")]
            Inbound = 1,

            /// <summary>
            /// Enum Outbound for value: Outbound
            /// </summary>
            [EnumMember(Value = "Outbound")]
            Outbound = 2

        }

        /// <summary>
        /// Message direction. Note that for some message types not all directions are allowed. For example voicemail messages can be only inbound
        /// </summary>
        /// <value>Message direction. Note that for some message types not all directions are allowed. For example voicemail messages can be only inbound</value>
        [DataMember(Name="direction", EmitDefaultValue=false)]
        public DirectionEnum? Direction { get; set; }
        /// <summary>
        /// Message status. Different message types may have different allowed status values. For outbound faxes the aggregated message status is returned: If status for at least one recipient is &#39;Queued&#39;, then &#39;Queued&#39; value is returned If status for at least one recipient is &#39;SendingFailed&#39;, then &#39;SendingFailed&#39; value is returned In other cases Sent status is returned
        /// </summary>
        /// <value>Message status. Different message types may have different allowed status values. For outbound faxes the aggregated message status is returned: If status for at least one recipient is &#39;Queued&#39;, then &#39;Queued&#39; value is returned If status for at least one recipient is &#39;SendingFailed&#39;, then &#39;SendingFailed&#39; value is returned In other cases Sent status is returned</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MessageStatusEnum
        {
            /// <summary>
            /// Enum Queued for value: Queued
            /// </summary>
            [EnumMember(Value = "Queued")]
            Queued = 1,

            /// <summary>
            /// Enum Sent for value: Sent
            /// </summary>
            [EnumMember(Value = "Sent")]
            Sent = 2,

            /// <summary>
            /// Enum Delivered for value: Delivered
            /// </summary>
            [EnumMember(Value = "Delivered")]
            Delivered = 3,

            /// <summary>
            /// Enum DeliveryFailed for value: DeliveryFailed
            /// </summary>
            [EnumMember(Value = "DeliveryFailed")]
            DeliveryFailed = 4,

            /// <summary>
            /// Enum SendingFailed for value: SendingFailed
            /// </summary>
            [EnumMember(Value = "SendingFailed")]
            SendingFailed = 5,

            /// <summary>
            /// Enum Received for value: Received
            /// </summary>
            [EnumMember(Value = "Received")]
            Received = 6

        }

        /// <summary>
        /// Message status. Different message types may have different allowed status values. For outbound faxes the aggregated message status is returned: If status for at least one recipient is &#39;Queued&#39;, then &#39;Queued&#39; value is returned If status for at least one recipient is &#39;SendingFailed&#39;, then &#39;SendingFailed&#39; value is returned In other cases Sent status is returned
        /// </summary>
        /// <value>Message status. Different message types may have different allowed status values. For outbound faxes the aggregated message status is returned: If status for at least one recipient is &#39;Queued&#39;, then &#39;Queued&#39; value is returned If status for at least one recipient is &#39;SendingFailed&#39;, then &#39;SendingFailed&#39; value is returned In other cases Sent status is returned</value>
        [DataMember(Name="messageStatus", EmitDefaultValue=false)]
        public MessageStatusEnum? MessageStatus { get; set; }
        /// <summary>
        /// Message priority
        /// </summary>
        /// <value>Message priority</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PriorityEnum
        {
            /// <summary>
            /// Enum Normal for value: Normal
            /// </summary>
            [EnumMember(Value = "Normal")]
            Normal = 1,

            /// <summary>
            /// Enum High for value: High
            /// </summary>
            [EnumMember(Value = "High")]
            High = 2

        }

        /// <summary>
        /// Message priority
        /// </summary>
        /// <value>Message priority</value>
        [DataMember(Name="priority", EmitDefaultValue=false)]
        public PriorityEnum? Priority { get; set; }
        /// <summary>
        /// Message read status
        /// </summary>
        /// <value>Message read status</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ReadStatusEnum
        {
            /// <summary>
            /// Enum Read for value: Read
            /// </summary>
            [EnumMember(Value = "Read")]
            Read = 1,

            /// <summary>
            /// Enum Unread for value: Unread
            /// </summary>
            [EnumMember(Value = "Unread")]
            Unread = 2

        }

        /// <summary>
        /// Message read status
        /// </summary>
        /// <value>Message read status</value>
        [DataMember(Name="readStatus", EmitDefaultValue=false)]
        public ReadStatusEnum? ReadStatus { get; set; }
        /// <summary>
        /// Message type
        /// </summary>
        /// <value>Message type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Fax for value: Fax
            /// </summary>
            [EnumMember(Value = "Fax")]
            Fax = 1,

            /// <summary>
            /// Enum SMS for value: SMS
            /// </summary>
            [EnumMember(Value = "SMS")]
            SMS = 2,

            /// <summary>
            /// Enum VoiceMail for value: VoiceMail
            /// </summary>
            [EnumMember(Value = "VoiceMail")]
            VoiceMail = 3,

            /// <summary>
            /// Enum Pager for value: Pager
            /// </summary>
            [EnumMember(Value = "Pager")]
            Pager = 4,

            /// <summary>
            /// Enum Text for value: Text
            /// </summary>
            [EnumMember(Value = "Text")]
            Text = 5

        }

        /// <summary>
        /// Message type
        /// </summary>
        /// <value>Message type</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetInternalTextMessageInfoResponse" /> class.
        /// </summary>
        /// <param name="id">Internal identifier of a message.</param>
        /// <param name="uri">Canonical URI of a message.</param>
        /// <param name="attachments">The list of message attachments.</param>
        /// <param name="availability">Message availability status. Message in &#39;Deleted&#39; state is still preserved with all its attachments and can be restored. &#39;Purged&#39; means that all attachments are already deleted and the message itself is about to be physically deleted shortly.</param>
        /// <param name="conversationId">SMS and Pager only. Identifier of a conversation that the message belongs to.</param>
        /// <param name="conversation">conversation.</param>
        /// <param name="creationTime">Message creation datetime in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z.</param>
        /// <param name="direction">Message direction. Note that for some message types not all directions are allowed. For example voicemail messages can be only inbound.</param>
        /// <param name="from">from.</param>
        /// <param name="lastModifiedTime">The datetime when the message was modified on server in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z.</param>
        /// <param name="messageStatus">Message status. Different message types may have different allowed status values. For outbound faxes the aggregated message status is returned: If status for at least one recipient is &#39;Queued&#39;, then &#39;Queued&#39; value is returned If status for at least one recipient is &#39;SendingFailed&#39;, then &#39;SendingFailed&#39; value is returned In other cases Sent status is returned.</param>
        /// <param name="pgToDepartment">&#39;Pager&#39; only. &#39;True&#39; if at least one of the message recipients is &#39;Department&#39; extension.</param>
        /// <param name="priority">Message priority.</param>
        /// <param name="readStatus">Message read status.</param>
        /// <param name="subject">Message subject. For SMS and Pager messages it replicates message text which is also returned as an attachment.</param>
        /// <param name="to">Recipient information.</param>
        /// <param name="type">Message type.</param>
        public GetInternalTextMessageInfoResponse(long id = default(long), string uri = default(string), List<MessageAttachmentInfo> attachments = default(List<MessageAttachmentInfo>), AvailabilityEnum? availability = default(AvailabilityEnum?), long conversationId = default(long), ConversationInfo conversation = default(ConversationInfo), DateTime creationTime = default(DateTime), DirectionEnum? direction = default(DirectionEnum?), MessageStoreCallerInfoResponseFrom from = default(MessageStoreCallerInfoResponseFrom), DateTime lastModifiedTime = default(DateTime), MessageStatusEnum? messageStatus = default(MessageStatusEnum?), bool pgToDepartment = default(bool), PriorityEnum? priority = default(PriorityEnum?), ReadStatusEnum? readStatus = default(ReadStatusEnum?), string subject = default(string), List<MessageStoreCallerInfoResponseTo> to = default(List<MessageStoreCallerInfoResponseTo>), TypeEnum? type = default(TypeEnum?))
        {
            this.Id = id;
            this.Uri = uri;
            this.Attachments = attachments;
            this.Availability = availability;
            this.ConversationId = conversationId;
            this.Conversation = conversation;
            this.CreationTime = creationTime;
            this.Direction = direction;
            this.From = from;
            this.LastModifiedTime = lastModifiedTime;
            this.MessageStatus = messageStatus;
            this.PgToDepartment = pgToDepartment;
            this.Priority = priority;
            this.ReadStatus = readStatus;
            this.Subject = subject;
            this.To = to;
            this.Type = type;
        }

        /// <summary>
        /// Internal identifier of a message
        /// </summary>
        /// <value>Internal identifier of a message</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long Id { get; set; }

        /// <summary>
        /// Canonical URI of a message
        /// </summary>
        /// <value>Canonical URI of a message</value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }

        /// <summary>
        /// The list of message attachments
        /// </summary>
        /// <value>The list of message attachments</value>
        [DataMember(Name="attachments", EmitDefaultValue=false)]
        public List<MessageAttachmentInfo> Attachments { get; set; }


        /// <summary>
        /// SMS and Pager only. Identifier of a conversation that the message belongs to
        /// </summary>
        /// <value>SMS and Pager only. Identifier of a conversation that the message belongs to</value>
        [DataMember(Name="conversationId", EmitDefaultValue=false)]
        public long ConversationId { get; set; }

        /// <summary>
        /// Gets or Sets Conversation
        /// </summary>
        [DataMember(Name="conversation", EmitDefaultValue=false)]
        public ConversationInfo Conversation { get; set; }

        /// <summary>
        /// Message creation datetime in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
        /// </summary>
        /// <value>Message creation datetime in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z</value>
        [DataMember(Name="creationTime", EmitDefaultValue=false)]
        public DateTime CreationTime { get; set; }


        /// <summary>
        /// Gets or Sets From
        /// </summary>
        [DataMember(Name="from", EmitDefaultValue=false)]
        public MessageStoreCallerInfoResponseFrom From { get; set; }

        /// <summary>
        /// The datetime when the message was modified on server in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
        /// </summary>
        /// <value>The datetime when the message was modified on server in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z</value>
        [DataMember(Name="lastModifiedTime", EmitDefaultValue=false)]
        public DateTime LastModifiedTime { get; set; }


        /// <summary>
        /// &#39;Pager&#39; only. &#39;True&#39; if at least one of the message recipients is &#39;Department&#39; extension
        /// </summary>
        /// <value>&#39;Pager&#39; only. &#39;True&#39; if at least one of the message recipients is &#39;Department&#39; extension</value>
        [DataMember(Name="pgToDepartment", EmitDefaultValue=false)]
        public bool PgToDepartment { get; set; }



        /// <summary>
        /// Message subject. For SMS and Pager messages it replicates message text which is also returned as an attachment
        /// </summary>
        /// <value>Message subject. For SMS and Pager messages it replicates message text which is also returned as an attachment</value>
        [DataMember(Name="subject", EmitDefaultValue=false)]
        public string Subject { get; set; }

        /// <summary>
        /// Recipient information
        /// </summary>
        /// <value>Recipient information</value>
        [DataMember(Name="to", EmitDefaultValue=false)]
        public List<MessageStoreCallerInfoResponseTo> To { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetInternalTextMessageInfoResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
            sb.Append("  Availability: ").Append(Availability).Append("\n");
            sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
            sb.Append("  Conversation: ").Append(Conversation).Append("\n");
            sb.Append("  CreationTime: ").Append(CreationTime).Append("\n");
            sb.Append("  Direction: ").Append(Direction).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  LastModifiedTime: ").Append(LastModifiedTime).Append("\n");
            sb.Append("  MessageStatus: ").Append(MessageStatus).Append("\n");
            sb.Append("  PgToDepartment: ").Append(PgToDepartment).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  ReadStatus: ").Append(ReadStatus).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as GetInternalTextMessageInfoResponse);
        }

        /// <summary>
        /// Returns true if GetInternalTextMessageInfoResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetInternalTextMessageInfoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetInternalTextMessageInfoResponse input)
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
                    this.Attachments == input.Attachments ||
                    this.Attachments != null &&
                    input.Attachments != null &&
                    this.Attachments.SequenceEqual(input.Attachments)
                ) && 
                (
                    this.Availability == input.Availability ||
                    (this.Availability != null &&
                    this.Availability.Equals(input.Availability))
                ) && 
                (
                    this.ConversationId == input.ConversationId ||
                    (this.ConversationId != null &&
                    this.ConversationId.Equals(input.ConversationId))
                ) && 
                (
                    this.Conversation == input.Conversation ||
                    (this.Conversation != null &&
                    this.Conversation.Equals(input.Conversation))
                ) && 
                (
                    this.CreationTime == input.CreationTime ||
                    (this.CreationTime != null &&
                    this.CreationTime.Equals(input.CreationTime))
                ) && 
                (
                    this.Direction == input.Direction ||
                    (this.Direction != null &&
                    this.Direction.Equals(input.Direction))
                ) && 
                (
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
                ) && 
                (
                    this.LastModifiedTime == input.LastModifiedTime ||
                    (this.LastModifiedTime != null &&
                    this.LastModifiedTime.Equals(input.LastModifiedTime))
                ) && 
                (
                    this.MessageStatus == input.MessageStatus ||
                    (this.MessageStatus != null &&
                    this.MessageStatus.Equals(input.MessageStatus))
                ) && 
                (
                    this.PgToDepartment == input.PgToDepartment ||
                    (this.PgToDepartment != null &&
                    this.PgToDepartment.Equals(input.PgToDepartment))
                ) && 
                (
                    this.Priority == input.Priority ||
                    (this.Priority != null &&
                    this.Priority.Equals(input.Priority))
                ) && 
                (
                    this.ReadStatus == input.ReadStatus ||
                    (this.ReadStatus != null &&
                    this.ReadStatus.Equals(input.ReadStatus))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.To == input.To ||
                    this.To != null &&
                    input.To != null &&
                    this.To.SequenceEqual(input.To)
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Attachments != null)
                    hashCode = hashCode * 59 + this.Attachments.GetHashCode();
                if (this.Availability != null)
                    hashCode = hashCode * 59 + this.Availability.GetHashCode();
                if (this.ConversationId != null)
                    hashCode = hashCode * 59 + this.ConversationId.GetHashCode();
                if (this.Conversation != null)
                    hashCode = hashCode * 59 + this.Conversation.GetHashCode();
                if (this.CreationTime != null)
                    hashCode = hashCode * 59 + this.CreationTime.GetHashCode();
                if (this.Direction != null)
                    hashCode = hashCode * 59 + this.Direction.GetHashCode();
                if (this.From != null)
                    hashCode = hashCode * 59 + this.From.GetHashCode();
                if (this.LastModifiedTime != null)
                    hashCode = hashCode * 59 + this.LastModifiedTime.GetHashCode();
                if (this.MessageStatus != null)
                    hashCode = hashCode * 59 + this.MessageStatus.GetHashCode();
                if (this.PgToDepartment != null)
                    hashCode = hashCode * 59 + this.PgToDepartment.GetHashCode();
                if (this.Priority != null)
                    hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.ReadStatus != null)
                    hashCode = hashCode * 59 + this.ReadStatus.GetHashCode();
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.To != null)
                    hashCode = hashCode * 59 + this.To.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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
