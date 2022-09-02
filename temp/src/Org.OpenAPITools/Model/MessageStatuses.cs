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
    /// The messages status object with details of each status
    /// </summary>
    [DataContract]
    public partial class MessageStatuses :  IEquatable<MessageStatuses>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageStatuses" /> class.
        /// </summary>
        /// <param name="queued">queued.</param>
        /// <param name="delivered">delivered.</param>
        /// <param name="deliveryFailed">deliveryFailed.</param>
        /// <param name="sent">sent.</param>
        /// <param name="sendingFailed">sendingFailed.</param>
        public MessageStatuses(MessageStatusCounts queued = default(MessageStatusCounts), MessageStatusCounts delivered = default(MessageStatusCounts), MessageStatusCounts deliveryFailed = default(MessageStatusCounts), MessageStatusCounts sent = default(MessageStatusCounts), MessageStatusCounts sendingFailed = default(MessageStatusCounts))
        {
            this.Queued = queued;
            this.Delivered = delivered;
            this.DeliveryFailed = deliveryFailed;
            this.Sent = sent;
            this.SendingFailed = sendingFailed;
        }

        /// <summary>
        /// Gets or Sets Queued
        /// </summary>
        [DataMember(Name="Queued", EmitDefaultValue=false)]
        public MessageStatusCounts Queued { get; set; }

        /// <summary>
        /// Gets or Sets Delivered
        /// </summary>
        [DataMember(Name="Delivered", EmitDefaultValue=false)]
        public MessageStatusCounts Delivered { get; set; }

        /// <summary>
        /// Gets or Sets DeliveryFailed
        /// </summary>
        [DataMember(Name="DeliveryFailed", EmitDefaultValue=false)]
        public MessageStatusCounts DeliveryFailed { get; set; }

        /// <summary>
        /// Gets or Sets Sent
        /// </summary>
        [DataMember(Name="Sent", EmitDefaultValue=false)]
        public MessageStatusCounts Sent { get; set; }

        /// <summary>
        /// Gets or Sets SendingFailed
        /// </summary>
        [DataMember(Name="SendingFailed", EmitDefaultValue=false)]
        public MessageStatusCounts SendingFailed { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessageStatuses {\n");
            sb.Append("  Queued: ").Append(Queued).Append("\n");
            sb.Append("  Delivered: ").Append(Delivered).Append("\n");
            sb.Append("  DeliveryFailed: ").Append(DeliveryFailed).Append("\n");
            sb.Append("  Sent: ").Append(Sent).Append("\n");
            sb.Append("  SendingFailed: ").Append(SendingFailed).Append("\n");
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
            return this.Equals(input as MessageStatuses);
        }

        /// <summary>
        /// Returns true if MessageStatuses instances are equal
        /// </summary>
        /// <param name="input">Instance of MessageStatuses to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessageStatuses input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Queued == input.Queued ||
                    (this.Queued != null &&
                    this.Queued.Equals(input.Queued))
                ) && 
                (
                    this.Delivered == input.Delivered ||
                    (this.Delivered != null &&
                    this.Delivered.Equals(input.Delivered))
                ) && 
                (
                    this.DeliveryFailed == input.DeliveryFailed ||
                    (this.DeliveryFailed != null &&
                    this.DeliveryFailed.Equals(input.DeliveryFailed))
                ) && 
                (
                    this.Sent == input.Sent ||
                    (this.Sent != null &&
                    this.Sent.Equals(input.Sent))
                ) && 
                (
                    this.SendingFailed == input.SendingFailed ||
                    (this.SendingFailed != null &&
                    this.SendingFailed.Equals(input.SendingFailed))
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
                if (this.Queued != null)
                    hashCode = hashCode * 59 + this.Queued.GetHashCode();
                if (this.Delivered != null)
                    hashCode = hashCode * 59 + this.Delivered.GetHashCode();
                if (this.DeliveryFailed != null)
                    hashCode = hashCode * 59 + this.DeliveryFailed.GetHashCode();
                if (this.Sent != null)
                    hashCode = hashCode * 59 + this.Sent.GetHashCode();
                if (this.SendingFailed != null)
                    hashCode = hashCode * 59 + this.SendingFailed.GetHashCode();
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