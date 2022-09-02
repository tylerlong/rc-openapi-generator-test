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
    /// Notification payload body
    /// </summary>
    [DataContract]
    public partial class InstantMessageEventBody :  IEquatable<InstantMessageEventBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InstantMessageEventBody" /> class.
        /// </summary>
        /// <param name="id">Internal identifier of a message.</param>
        /// <param name="to">Message receiver(s) information.</param>
        /// <param name="from">from.</param>
        /// <param name="type">Type of a message. The default value is &#39;SMS&#39;.</param>
        /// <param name="creationTime">Message creation datetime in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z.</param>
        /// <param name="lastModifiedTime">Datetime when the message was modified in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z.</param>
        /// <param name="readStatus">Status of a message (default to &quot;Unread&quot;).</param>
        /// <param name="priority">priority (default to &quot;Normal&quot;).</param>
        /// <param name="attachments">Message attachment data.</param>
        /// <param name="direction">Message direction (default to &quot;Inbound&quot;).</param>
        /// <param name="availability">Message availability status (default to &quot;Alive&quot;).</param>
        /// <param name="subject">Message subject. It replicates message text which is also returned as an attachment.</param>
        /// <param name="messageStatus">Status of a message (default to &quot;Received&quot;).</param>
        /// <param name="conversationId">Deprecated. Identifier of a conversation the message belongs to.</param>
        /// <param name="conversation">conversation.</param>
        /// <param name="ownerId">Internal identifier of a subscription owner extension.</param>
        public InstantMessageEventBody(string id = default(string), List<NotificationRecipientInfo> to = default(List<NotificationRecipientInfo>), SenderInfo from = default(SenderInfo), string type = default(string), DateTime creationTime = default(DateTime), DateTime lastModifiedTime = default(DateTime), string readStatus = "Unread", string priority = "Normal", List<MessageAttachmentInfo> attachments = default(List<MessageAttachmentInfo>), string direction = "Inbound", string availability = "Alive", string subject = default(string), string messageStatus = "Received", string conversationId = default(string), ConversationInfo conversation = default(ConversationInfo), string ownerId = default(string))
        {
            this.Id = id;
            this.To = to;
            this.From = from;
            this.Type = type;
            this.CreationTime = creationTime;
            this.LastModifiedTime = lastModifiedTime;
            // use default value if no "readStatus" provided
            if (readStatus == null)
            {
                this.ReadStatus = "Unread";
            }
            else
            {
                this.ReadStatus = readStatus;
            }
            // use default value if no "priority" provided
            if (priority == null)
            {
                this.Priority = "Normal";
            }
            else
            {
                this.Priority = priority;
            }
            this.Attachments = attachments;
            // use default value if no "direction" provided
            if (direction == null)
            {
                this.Direction = "Inbound";
            }
            else
            {
                this.Direction = direction;
            }
            // use default value if no "availability" provided
            if (availability == null)
            {
                this.Availability = "Alive";
            }
            else
            {
                this.Availability = availability;
            }
            this.Subject = subject;
            // use default value if no "messageStatus" provided
            if (messageStatus == null)
            {
                this.MessageStatus = "Received";
            }
            else
            {
                this.MessageStatus = messageStatus;
            }
            this.ConversationId = conversationId;
            this.Conversation = conversation;
            this.OwnerId = ownerId;
        }

        /// <summary>
        /// Internal identifier of a message
        /// </summary>
        /// <value>Internal identifier of a message</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Message receiver(s) information
        /// </summary>
        /// <value>Message receiver(s) information</value>
        [DataMember(Name="to", EmitDefaultValue=false)]
        public List<NotificationRecipientInfo> To { get; set; }

        /// <summary>
        /// Gets or Sets From
        /// </summary>
        [DataMember(Name="from", EmitDefaultValue=false)]
        public SenderInfo From { get; set; }

        /// <summary>
        /// Type of a message. The default value is &#39;SMS&#39;
        /// </summary>
        /// <value>Type of a message. The default value is &#39;SMS&#39;</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Message creation datetime in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
        /// </summary>
        /// <value>Message creation datetime in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z</value>
        [DataMember(Name="creationTime", EmitDefaultValue=false)]
        public DateTime CreationTime { get; set; }

        /// <summary>
        /// Datetime when the message was modified in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
        /// </summary>
        /// <value>Datetime when the message was modified in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z</value>
        [DataMember(Name="lastModifiedTime", EmitDefaultValue=false)]
        public DateTime LastModifiedTime { get; set; }

        /// <summary>
        /// Status of a message
        /// </summary>
        /// <value>Status of a message</value>
        [DataMember(Name="readStatus", EmitDefaultValue=false)]
        public string ReadStatus { get; set; }

        /// <summary>
        /// Gets or Sets Priority
        /// </summary>
        [DataMember(Name="priority", EmitDefaultValue=false)]
        public string Priority { get; set; }

        /// <summary>
        /// Message attachment data
        /// </summary>
        /// <value>Message attachment data</value>
        [DataMember(Name="attachments", EmitDefaultValue=false)]
        public List<MessageAttachmentInfo> Attachments { get; set; }

        /// <summary>
        /// Message direction
        /// </summary>
        /// <value>Message direction</value>
        [DataMember(Name="direction", EmitDefaultValue=false)]
        public string Direction { get; set; }

        /// <summary>
        /// Message availability status
        /// </summary>
        /// <value>Message availability status</value>
        [DataMember(Name="availability", EmitDefaultValue=false)]
        public string Availability { get; set; }

        /// <summary>
        /// Message subject. It replicates message text which is also returned as an attachment
        /// </summary>
        /// <value>Message subject. It replicates message text which is also returned as an attachment</value>
        [DataMember(Name="subject", EmitDefaultValue=false)]
        public string Subject { get; set; }

        /// <summary>
        /// Status of a message
        /// </summary>
        /// <value>Status of a message</value>
        [DataMember(Name="messageStatus", EmitDefaultValue=false)]
        public string MessageStatus { get; set; }

        /// <summary>
        /// Deprecated. Identifier of a conversation the message belongs to
        /// </summary>
        /// <value>Deprecated. Identifier of a conversation the message belongs to</value>
        [DataMember(Name="conversationId", EmitDefaultValue=false)]
        public string ConversationId { get; set; }

        /// <summary>
        /// Gets or Sets Conversation
        /// </summary>
        [DataMember(Name="conversation", EmitDefaultValue=false)]
        public ConversationInfo Conversation { get; set; }

        /// <summary>
        /// Internal identifier of a subscription owner extension
        /// </summary>
        /// <value>Internal identifier of a subscription owner extension</value>
        [DataMember(Name="ownerId", EmitDefaultValue=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InstantMessageEventBody {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  CreationTime: ").Append(CreationTime).Append("\n");
            sb.Append("  LastModifiedTime: ").Append(LastModifiedTime).Append("\n");
            sb.Append("  ReadStatus: ").Append(ReadStatus).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
            sb.Append("  Direction: ").Append(Direction).Append("\n");
            sb.Append("  Availability: ").Append(Availability).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  MessageStatus: ").Append(MessageStatus).Append("\n");
            sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
            sb.Append("  Conversation: ").Append(Conversation).Append("\n");
            sb.Append("  OwnerId: ").Append(OwnerId).Append("\n");
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
            return this.Equals(input as InstantMessageEventBody);
        }

        /// <summary>
        /// Returns true if InstantMessageEventBody instances are equal
        /// </summary>
        /// <param name="input">Instance of InstantMessageEventBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InstantMessageEventBody input)
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
                    this.To == input.To ||
                    this.To != null &&
                    input.To != null &&
                    this.To.SequenceEqual(input.To)
                ) && 
                (
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                    this.ReadStatus == input.ReadStatus ||
                    (this.ReadStatus != null &&
                    this.ReadStatus.Equals(input.ReadStatus))
                ) && 
                (
                    this.Priority == input.Priority ||
                    (this.Priority != null &&
                    this.Priority.Equals(input.Priority))
                ) && 
                (
                    this.Attachments == input.Attachments ||
                    this.Attachments != null &&
                    input.Attachments != null &&
                    this.Attachments.SequenceEqual(input.Attachments)
                ) && 
                (
                    this.Direction == input.Direction ||
                    (this.Direction != null &&
                    this.Direction.Equals(input.Direction))
                ) && 
                (
                    this.Availability == input.Availability ||
                    (this.Availability != null &&
                    this.Availability.Equals(input.Availability))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.MessageStatus == input.MessageStatus ||
                    (this.MessageStatus != null &&
                    this.MessageStatus.Equals(input.MessageStatus))
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
                    this.OwnerId == input.OwnerId ||
                    (this.OwnerId != null &&
                    this.OwnerId.Equals(input.OwnerId))
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
                if (this.To != null)
                    hashCode = hashCode * 59 + this.To.GetHashCode();
                if (this.From != null)
                    hashCode = hashCode * 59 + this.From.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.CreationTime != null)
                    hashCode = hashCode * 59 + this.CreationTime.GetHashCode();
                if (this.LastModifiedTime != null)
                    hashCode = hashCode * 59 + this.LastModifiedTime.GetHashCode();
                if (this.ReadStatus != null)
                    hashCode = hashCode * 59 + this.ReadStatus.GetHashCode();
                if (this.Priority != null)
                    hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.Attachments != null)
                    hashCode = hashCode * 59 + this.Attachments.GetHashCode();
                if (this.Direction != null)
                    hashCode = hashCode * 59 + this.Direction.GetHashCode();
                if (this.Availability != null)
                    hashCode = hashCode * 59 + this.Availability.GetHashCode();
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.MessageStatus != null)
                    hashCode = hashCode * 59 + this.MessageStatus.GetHashCode();
                if (this.ConversationId != null)
                    hashCode = hashCode * 59 + this.ConversationId.GetHashCode();
                if (this.Conversation != null)
                    hashCode = hashCode * 59 + this.Conversation.GetHashCode();
                if (this.OwnerId != null)
                    hashCode = hashCode * 59 + this.OwnerId.GetHashCode();
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