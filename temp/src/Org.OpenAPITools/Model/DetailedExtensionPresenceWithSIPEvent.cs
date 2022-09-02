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
    /// DetailedExtensionPresenceWithSIPEvent
    /// </summary>
    [DataContract]
    public partial class DetailedExtensionPresenceWithSIPEvent :  IEquatable<DetailedExtensionPresenceWithSIPEvent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DetailedExtensionPresenceWithSIPEvent" /> class.
        /// </summary>
        /// <param name="uuid">Universally unique identifier of a notification.</param>
        /// <param name="_event">Event filter name.</param>
        /// <param name="timestamp">Timestamp when this notification was sent in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format including timezone, for example *2016-03-10T18:07:52.534Z*.</param>
        /// <param name="subscriptionId">Internal identifier of a subscription.</param>
        /// <param name="body">body.</param>
        public DetailedExtensionPresenceWithSIPEvent(string uuid = default(string), string _event = default(string), DateTime timestamp = default(DateTime), string subscriptionId = default(string), DetailedExtensionPresenceWithSIPEventBody body = default(DetailedExtensionPresenceWithSIPEventBody))
        {
            this.Uuid = uuid;
            this.Event = _event;
            this.Timestamp = timestamp;
            this.SubscriptionId = subscriptionId;
            this.Body = body;
        }

        /// <summary>
        /// Universally unique identifier of a notification
        /// </summary>
        /// <value>Universally unique identifier of a notification</value>
        [DataMember(Name="uuid", EmitDefaultValue=false)]
        public string Uuid { get; set; }

        /// <summary>
        /// Event filter name
        /// </summary>
        /// <value>Event filter name</value>
        [DataMember(Name="event", EmitDefaultValue=false)]
        public string Event { get; set; }

        /// <summary>
        /// Timestamp when this notification was sent in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format including timezone, for example *2016-03-10T18:07:52.534Z*
        /// </summary>
        /// <value>Timestamp when this notification was sent in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format including timezone, for example *2016-03-10T18:07:52.534Z*</value>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public DateTime Timestamp { get; set; }

        /// <summary>
        /// Internal identifier of a subscription
        /// </summary>
        /// <value>Internal identifier of a subscription</value>
        [DataMember(Name="subscriptionId", EmitDefaultValue=false)]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// Gets or Sets Body
        /// </summary>
        [DataMember(Name="body", EmitDefaultValue=false)]
        public DetailedExtensionPresenceWithSIPEventBody Body { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DetailedExtensionPresenceWithSIPEvent {\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  Event: ").Append(Event).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  SubscriptionId: ").Append(SubscriptionId).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
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
            return this.Equals(input as DetailedExtensionPresenceWithSIPEvent);
        }

        /// <summary>
        /// Returns true if DetailedExtensionPresenceWithSIPEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of DetailedExtensionPresenceWithSIPEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DetailedExtensionPresenceWithSIPEvent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Uuid == input.Uuid ||
                    (this.Uuid != null &&
                    this.Uuid.Equals(input.Uuid))
                ) && 
                (
                    this.Event == input.Event ||
                    (this.Event != null &&
                    this.Event.Equals(input.Event))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
                ) && 
                (
                    this.SubscriptionId == input.SubscriptionId ||
                    (this.SubscriptionId != null &&
                    this.SubscriptionId.Equals(input.SubscriptionId))
                ) && 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
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
                if (this.Uuid != null)
                    hashCode = hashCode * 59 + this.Uuid.GetHashCode();
                if (this.Event != null)
                    hashCode = hashCode * 59 + this.Event.GetHashCode();
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                if (this.SubscriptionId != null)
                    hashCode = hashCode * 59 + this.SubscriptionId.GetHashCode();
                if (this.Body != null)
                    hashCode = hashCode * 59 + this.Body.GetHashCode();
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
