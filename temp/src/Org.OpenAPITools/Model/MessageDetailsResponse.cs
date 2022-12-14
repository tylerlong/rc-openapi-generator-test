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
    /// Complete details of the message
    /// </summary>
    [DataContract]
    public partial class MessageDetailsResponse :  IEquatable<MessageDetailsResponse>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets MessageStatus
        /// </summary>
        [DataMember(Name="messageStatus", EmitDefaultValue=false)]
        public SmsStatusEnum? MessageStatus { get; set; }
        /// <summary>
        /// Gets or Sets Direction
        /// </summary>
        [DataMember(Name="direction", EmitDefaultValue=false)]
        public SmsDirectionEnum? Direction { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageDetailsResponse" /> class.
        /// </summary>
        /// <param name="id">Internal identifier of a message.</param>
        /// <param name="from">Phone number in [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) format from which the message was sent.</param>
        /// <param name="to">List of phone numbers in [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) format to which the message was sent.</param>
        /// <param name="text">Text of a message, maximum number of characters is 1000.</param>
        /// <param name="creationTime">The time when this is message was created..</param>
        /// <param name="lastModifiedTime">The time when this message was last updated..</param>
        /// <param name="messageStatus">messageStatus.</param>
        /// <param name="segmentCount">Number of segments of a message.</param>
        /// <param name="cost">Cost of a message.</param>
        /// <param name="batchId">The batch in which the message was submitted.</param>
        /// <param name="direction">direction.</param>
        /// <param name="errorCode">The RC error code of the message sending failure reason.</param>
        public MessageDetailsResponse(string id = default(string), string from = default(string), List<string> to = default(List<string>), string text = default(string), DateTime creationTime = default(DateTime), DateTime lastModifiedTime = default(DateTime), SmsStatusEnum? messageStatus = default(SmsStatusEnum?), int segmentCount = default(int), double cost = default(double), string batchId = default(string), SmsDirectionEnum? direction = default(SmsDirectionEnum?), string errorCode = default(string))
        {
            this.Id = id;
            this.From = from;
            this.To = to;
            this.Text = text;
            this.CreationTime = creationTime;
            this.LastModifiedTime = lastModifiedTime;
            this.MessageStatus = messageStatus;
            this.SegmentCount = segmentCount;
            this.Cost = cost;
            this.BatchId = batchId;
            this.Direction = direction;
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Internal identifier of a message
        /// </summary>
        /// <value>Internal identifier of a message</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Phone number in [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) format from which the message was sent
        /// </summary>
        /// <value>Phone number in [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) format from which the message was sent</value>
        [DataMember(Name="from", EmitDefaultValue=false)]
        public string From { get; set; }

        /// <summary>
        /// List of phone numbers in [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) format to which the message was sent
        /// </summary>
        /// <value>List of phone numbers in [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) format to which the message was sent</value>
        [DataMember(Name="to", EmitDefaultValue=false)]
        public List<string> To { get; set; }

        /// <summary>
        /// Text of a message, maximum number of characters is 1000
        /// </summary>
        /// <value>Text of a message, maximum number of characters is 1000</value>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }

        /// <summary>
        /// The time when this is message was created.
        /// </summary>
        /// <value>The time when this is message was created.</value>
        [DataMember(Name="creationTime", EmitDefaultValue=false)]
        public DateTime CreationTime { get; set; }

        /// <summary>
        /// The time when this message was last updated.
        /// </summary>
        /// <value>The time when this message was last updated.</value>
        [DataMember(Name="lastModifiedTime", EmitDefaultValue=false)]
        public DateTime LastModifiedTime { get; set; }


        /// <summary>
        /// Number of segments of a message
        /// </summary>
        /// <value>Number of segments of a message</value>
        [DataMember(Name="segmentCount", EmitDefaultValue=false)]
        public int SegmentCount { get; set; }

        /// <summary>
        /// Cost of a message
        /// </summary>
        /// <value>Cost of a message</value>
        [DataMember(Name="cost", EmitDefaultValue=false)]
        public double Cost { get; set; }

        /// <summary>
        /// The batch in which the message was submitted
        /// </summary>
        /// <value>The batch in which the message was submitted</value>
        [DataMember(Name="batchId", EmitDefaultValue=false)]
        public string BatchId { get; set; }


        /// <summary>
        /// The RC error code of the message sending failure reason
        /// </summary>
        /// <value>The RC error code of the message sending failure reason</value>
        [DataMember(Name="errorCode", EmitDefaultValue=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessageDetailsResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  CreationTime: ").Append(CreationTime).Append("\n");
            sb.Append("  LastModifiedTime: ").Append(LastModifiedTime).Append("\n");
            sb.Append("  MessageStatus: ").Append(MessageStatus).Append("\n");
            sb.Append("  SegmentCount: ").Append(SegmentCount).Append("\n");
            sb.Append("  Cost: ").Append(Cost).Append("\n");
            sb.Append("  BatchId: ").Append(BatchId).Append("\n");
            sb.Append("  Direction: ").Append(Direction).Append("\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
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
            return this.Equals(input as MessageDetailsResponse);
        }

        /// <summary>
        /// Returns true if MessageDetailsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of MessageDetailsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessageDetailsResponse input)
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
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
                ) && 
                (
                    this.To == input.To ||
                    this.To != null &&
                    input.To != null &&
                    this.To.SequenceEqual(input.To)
                ) && 
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
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
                    this.MessageStatus == input.MessageStatus ||
                    (this.MessageStatus != null &&
                    this.MessageStatus.Equals(input.MessageStatus))
                ) && 
                (
                    this.SegmentCount == input.SegmentCount ||
                    (this.SegmentCount != null &&
                    this.SegmentCount.Equals(input.SegmentCount))
                ) && 
                (
                    this.Cost == input.Cost ||
                    (this.Cost != null &&
                    this.Cost.Equals(input.Cost))
                ) && 
                (
                    this.BatchId == input.BatchId ||
                    (this.BatchId != null &&
                    this.BatchId.Equals(input.BatchId))
                ) && 
                (
                    this.Direction == input.Direction ||
                    (this.Direction != null &&
                    this.Direction.Equals(input.Direction))
                ) && 
                (
                    this.ErrorCode == input.ErrorCode ||
                    (this.ErrorCode != null &&
                    this.ErrorCode.Equals(input.ErrorCode))
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
                if (this.From != null)
                    hashCode = hashCode * 59 + this.From.GetHashCode();
                if (this.To != null)
                    hashCode = hashCode * 59 + this.To.GetHashCode();
                if (this.Text != null)
                    hashCode = hashCode * 59 + this.Text.GetHashCode();
                if (this.CreationTime != null)
                    hashCode = hashCode * 59 + this.CreationTime.GetHashCode();
                if (this.LastModifiedTime != null)
                    hashCode = hashCode * 59 + this.LastModifiedTime.GetHashCode();
                if (this.MessageStatus != null)
                    hashCode = hashCode * 59 + this.MessageStatus.GetHashCode();
                if (this.SegmentCount != null)
                    hashCode = hashCode * 59 + this.SegmentCount.GetHashCode();
                if (this.Cost != null)
                    hashCode = hashCode * 59 + this.Cost.GetHashCode();
                if (this.BatchId != null)
                    hashCode = hashCode * 59 + this.BatchId.GetHashCode();
                if (this.Direction != null)
                    hashCode = hashCode * 59 + this.Direction.GetHashCode();
                if (this.ErrorCode != null)
                    hashCode = hashCode * 59 + this.ErrorCode.GetHashCode();
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
