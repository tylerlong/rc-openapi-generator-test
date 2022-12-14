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
    /// InboundMessageEvent
    /// </summary>
    [DataContract]
    public partial class InboundMessageEvent :  IEquatable<InboundMessageEvent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InboundMessageEvent" /> class.
        /// </summary>
        /// <param name="aps">aps.</param>
        /// <param name="messageId">Internal identifier of a message.</param>
        /// <param name="conversationId">Internal identifier of a conversation.</param>
        /// <param name="from">Sender phone number. For GCM transport type &#39;_from&#39; property should be used.</param>
        /// <param name="to">Receiver phone number.</param>
        /// <param name="ownerId">Internal identifier of a subscription owner extension.</param>
        public InboundMessageEvent(NotificationInfo aps = default(NotificationInfo), string messageId = default(string), string conversationId = default(string), string from = default(string), string to = default(string), string ownerId = default(string))
        {
            this.Aps = aps;
            this.MessageId = messageId;
            this.ConversationId = conversationId;
            this.From = from;
            this.To = to;
            this.OwnerId = ownerId;
        }

        /// <summary>
        /// Gets or Sets Aps
        /// </summary>
        [DataMember(Name="aps", EmitDefaultValue=false)]
        public NotificationInfo Aps { get; set; }

        /// <summary>
        /// Internal identifier of a message
        /// </summary>
        /// <value>Internal identifier of a message</value>
        [DataMember(Name="messageId", EmitDefaultValue=false)]
        public string MessageId { get; set; }

        /// <summary>
        /// Internal identifier of a conversation
        /// </summary>
        /// <value>Internal identifier of a conversation</value>
        [DataMember(Name="conversationId", EmitDefaultValue=false)]
        public string ConversationId { get; set; }

        /// <summary>
        /// Sender phone number. For GCM transport type &#39;_from&#39; property should be used
        /// </summary>
        /// <value>Sender phone number. For GCM transport type &#39;_from&#39; property should be used</value>
        [DataMember(Name="from", EmitDefaultValue=false)]
        public string From { get; set; }

        /// <summary>
        /// Receiver phone number
        /// </summary>
        /// <value>Receiver phone number</value>
        [DataMember(Name="to", EmitDefaultValue=false)]
        public string To { get; set; }

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
            sb.Append("class InboundMessageEvent {\n");
            sb.Append("  Aps: ").Append(Aps).Append("\n");
            sb.Append("  MessageId: ").Append(MessageId).Append("\n");
            sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
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
            return this.Equals(input as InboundMessageEvent);
        }

        /// <summary>
        /// Returns true if InboundMessageEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of InboundMessageEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InboundMessageEvent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Aps == input.Aps ||
                    (this.Aps != null &&
                    this.Aps.Equals(input.Aps))
                ) && 
                (
                    this.MessageId == input.MessageId ||
                    (this.MessageId != null &&
                    this.MessageId.Equals(input.MessageId))
                ) && 
                (
                    this.ConversationId == input.ConversationId ||
                    (this.ConversationId != null &&
                    this.ConversationId.Equals(input.ConversationId))
                ) && 
                (
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
                ) && 
                (
                    this.To == input.To ||
                    (this.To != null &&
                    this.To.Equals(input.To))
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
                if (this.Aps != null)
                    hashCode = hashCode * 59 + this.Aps.GetHashCode();
                if (this.MessageId != null)
                    hashCode = hashCode * 59 + this.MessageId.GetHashCode();
                if (this.ConversationId != null)
                    hashCode = hashCode * 59 + this.ConversationId.GetHashCode();
                if (this.From != null)
                    hashCode = hashCode * 59 + this.From.GetHashCode();
                if (this.To != null)
                    hashCode = hashCode * 59 + this.To.GetHashCode();
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
