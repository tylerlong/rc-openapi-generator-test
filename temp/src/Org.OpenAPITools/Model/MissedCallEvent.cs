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
    /// MissedCallEvent
    /// </summary>
    [DataContract]
    public partial class MissedCallEvent :  IEquatable<MissedCallEvent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MissedCallEvent" /> class.
        /// </summary>
        /// <param name="uuid">Universally unique identifier of a notification.</param>
        /// <param name="pnApns">pnApns.</param>
        /// <param name="_event">Event filter name.</param>
        /// <param name="subscriptionId">Internal identifier of a subscription.</param>
        /// <param name="timestamp">The timestamp of a call action in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format including timezone, for example 2016-03-10T18:07:52.534Z.</param>
        /// <param name="extensionId">Internal identifier of an extension (default to &quot;~&quot;).</param>
        /// <param name="action">Calling action, for example &#39;StartRing&#39;.</param>
        /// <param name="sessionId">Identifier of a call session.</param>
        /// <param name="serverId">Identifier of a server.</param>
        /// <param name="from">Phone number of a caller. For GCM transport type &#39;_from&#39; property should be used.</param>
        /// <param name="fromName">Caller name.</param>
        /// <param name="to">Phone number of a callee.</param>
        /// <param name="toName">Callee name.</param>
        /// <param name="sid">Unique identifier of a session.</param>
        /// <param name="toUrl">SIP proxy registration name.</param>
        /// <param name="srvLvl">User data.</param>
        /// <param name="srvLvlExt">User data.</param>
        /// <param name="recUrl">File containing recorded caller name.</param>
        /// <param name="pnTtl">Notification lifetime value in seconds, the default value is 30 seconds.</param>
        /// <param name="ownerId">Internal identifier of a subscription owner extension.</param>
        public MissedCallEvent(string uuid = default(string), APNSInfo pnApns = default(APNSInfo), string _event = default(string), string subscriptionId = default(string), DateTime timestamp = default(DateTime), string extensionId = "~", string action = default(string), string sessionId = default(string), string serverId = default(string), string from = default(string), string fromName = default(string), string to = default(string), string toName = default(string), string sid = default(string), string toUrl = default(string), string srvLvl = default(string), string srvLvlExt = default(string), string recUrl = default(string), int pnTtl = default(int), string ownerId = default(string))
        {
            this.Uuid = uuid;
            this.PnApns = pnApns;
            this.Event = _event;
            this.SubscriptionId = subscriptionId;
            this.Timestamp = timestamp;
            // use default value if no "extensionId" provided
            if (extensionId == null)
            {
                this.ExtensionId = "~";
            }
            else
            {
                this.ExtensionId = extensionId;
            }
            this.Action = action;
            this.SessionId = sessionId;
            this.ServerId = serverId;
            this.From = from;
            this.FromName = fromName;
            this.To = to;
            this.ToName = toName;
            this.Sid = sid;
            this.ToUrl = toUrl;
            this.SrvLvl = srvLvl;
            this.SrvLvlExt = srvLvlExt;
            this.RecUrl = recUrl;
            this.PnTtl = pnTtl;
            this.OwnerId = ownerId;
        }

        /// <summary>
        /// Universally unique identifier of a notification
        /// </summary>
        /// <value>Universally unique identifier of a notification</value>
        [DataMember(Name="uuid", EmitDefaultValue=false)]
        public string Uuid { get; set; }

        /// <summary>
        /// Gets or Sets PnApns
        /// </summary>
        [DataMember(Name="pn_apns", EmitDefaultValue=false)]
        public APNSInfo PnApns { get; set; }

        /// <summary>
        /// Event filter name
        /// </summary>
        /// <value>Event filter name</value>
        [DataMember(Name="event", EmitDefaultValue=false)]
        public string Event { get; set; }

        /// <summary>
        /// Internal identifier of a subscription
        /// </summary>
        /// <value>Internal identifier of a subscription</value>
        [DataMember(Name="subscriptionId", EmitDefaultValue=false)]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// The timestamp of a call action in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format including timezone, for example 2016-03-10T18:07:52.534Z
        /// </summary>
        /// <value>The timestamp of a call action in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format including timezone, for example 2016-03-10T18:07:52.534Z</value>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public DateTime Timestamp { get; set; }

        /// <summary>
        /// Internal identifier of an extension
        /// </summary>
        /// <value>Internal identifier of an extension</value>
        [DataMember(Name="extensionId", EmitDefaultValue=false)]
        public string ExtensionId { get; set; }

        /// <summary>
        /// Calling action, for example &#39;StartRing&#39;
        /// </summary>
        /// <value>Calling action, for example &#39;StartRing&#39;</value>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public string Action { get; set; }

        /// <summary>
        /// Identifier of a call session
        /// </summary>
        /// <value>Identifier of a call session</value>
        [DataMember(Name="sessionId", EmitDefaultValue=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// Identifier of a server
        /// </summary>
        /// <value>Identifier of a server</value>
        [DataMember(Name="serverId", EmitDefaultValue=false)]
        public string ServerId { get; set; }

        /// <summary>
        /// Phone number of a caller. For GCM transport type &#39;_from&#39; property should be used
        /// </summary>
        /// <value>Phone number of a caller. For GCM transport type &#39;_from&#39; property should be used</value>
        [DataMember(Name="from", EmitDefaultValue=false)]
        public string From { get; set; }

        /// <summary>
        /// Caller name
        /// </summary>
        /// <value>Caller name</value>
        [DataMember(Name="fromName", EmitDefaultValue=false)]
        public string FromName { get; set; }

        /// <summary>
        /// Phone number of a callee
        /// </summary>
        /// <value>Phone number of a callee</value>
        [DataMember(Name="to", EmitDefaultValue=false)]
        public string To { get; set; }

        /// <summary>
        /// Callee name
        /// </summary>
        /// <value>Callee name</value>
        [DataMember(Name="toName", EmitDefaultValue=false)]
        public string ToName { get; set; }

        /// <summary>
        /// Unique identifier of a session
        /// </summary>
        /// <value>Unique identifier of a session</value>
        [DataMember(Name="sid", EmitDefaultValue=false)]
        public string Sid { get; set; }

        /// <summary>
        /// SIP proxy registration name
        /// </summary>
        /// <value>SIP proxy registration name</value>
        [DataMember(Name="toUrl", EmitDefaultValue=false)]
        public string ToUrl { get; set; }

        /// <summary>
        /// User data
        /// </summary>
        /// <value>User data</value>
        [DataMember(Name="srvLvl", EmitDefaultValue=false)]
        public string SrvLvl { get; set; }

        /// <summary>
        /// User data
        /// </summary>
        /// <value>User data</value>
        [DataMember(Name="srvLvlExt", EmitDefaultValue=false)]
        public string SrvLvlExt { get; set; }

        /// <summary>
        /// File containing recorded caller name
        /// </summary>
        /// <value>File containing recorded caller name</value>
        [DataMember(Name="recUrl", EmitDefaultValue=false)]
        public string RecUrl { get; set; }

        /// <summary>
        /// Notification lifetime value in seconds, the default value is 30 seconds
        /// </summary>
        /// <value>Notification lifetime value in seconds, the default value is 30 seconds</value>
        [DataMember(Name="pn_ttl", EmitDefaultValue=false)]
        public int PnTtl { get; set; }

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
            sb.Append("class MissedCallEvent {\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  PnApns: ").Append(PnApns).Append("\n");
            sb.Append("  Event: ").Append(Event).Append("\n");
            sb.Append("  SubscriptionId: ").Append(SubscriptionId).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  ExtensionId: ").Append(ExtensionId).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  SessionId: ").Append(SessionId).Append("\n");
            sb.Append("  ServerId: ").Append(ServerId).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  FromName: ").Append(FromName).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  ToName: ").Append(ToName).Append("\n");
            sb.Append("  Sid: ").Append(Sid).Append("\n");
            sb.Append("  ToUrl: ").Append(ToUrl).Append("\n");
            sb.Append("  SrvLvl: ").Append(SrvLvl).Append("\n");
            sb.Append("  SrvLvlExt: ").Append(SrvLvlExt).Append("\n");
            sb.Append("  RecUrl: ").Append(RecUrl).Append("\n");
            sb.Append("  PnTtl: ").Append(PnTtl).Append("\n");
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
            return this.Equals(input as MissedCallEvent);
        }

        /// <summary>
        /// Returns true if MissedCallEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of MissedCallEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MissedCallEvent input)
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
                    this.PnApns == input.PnApns ||
                    (this.PnApns != null &&
                    this.PnApns.Equals(input.PnApns))
                ) && 
                (
                    this.Event == input.Event ||
                    (this.Event != null &&
                    this.Event.Equals(input.Event))
                ) && 
                (
                    this.SubscriptionId == input.SubscriptionId ||
                    (this.SubscriptionId != null &&
                    this.SubscriptionId.Equals(input.SubscriptionId))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
                ) && 
                (
                    this.ExtensionId == input.ExtensionId ||
                    (this.ExtensionId != null &&
                    this.ExtensionId.Equals(input.ExtensionId))
                ) && 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                ) && 
                (
                    this.SessionId == input.SessionId ||
                    (this.SessionId != null &&
                    this.SessionId.Equals(input.SessionId))
                ) && 
                (
                    this.ServerId == input.ServerId ||
                    (this.ServerId != null &&
                    this.ServerId.Equals(input.ServerId))
                ) && 
                (
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
                ) && 
                (
                    this.FromName == input.FromName ||
                    (this.FromName != null &&
                    this.FromName.Equals(input.FromName))
                ) && 
                (
                    this.To == input.To ||
                    (this.To != null &&
                    this.To.Equals(input.To))
                ) && 
                (
                    this.ToName == input.ToName ||
                    (this.ToName != null &&
                    this.ToName.Equals(input.ToName))
                ) && 
                (
                    this.Sid == input.Sid ||
                    (this.Sid != null &&
                    this.Sid.Equals(input.Sid))
                ) && 
                (
                    this.ToUrl == input.ToUrl ||
                    (this.ToUrl != null &&
                    this.ToUrl.Equals(input.ToUrl))
                ) && 
                (
                    this.SrvLvl == input.SrvLvl ||
                    (this.SrvLvl != null &&
                    this.SrvLvl.Equals(input.SrvLvl))
                ) && 
                (
                    this.SrvLvlExt == input.SrvLvlExt ||
                    (this.SrvLvlExt != null &&
                    this.SrvLvlExt.Equals(input.SrvLvlExt))
                ) && 
                (
                    this.RecUrl == input.RecUrl ||
                    (this.RecUrl != null &&
                    this.RecUrl.Equals(input.RecUrl))
                ) && 
                (
                    this.PnTtl == input.PnTtl ||
                    (this.PnTtl != null &&
                    this.PnTtl.Equals(input.PnTtl))
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
                if (this.Uuid != null)
                    hashCode = hashCode * 59 + this.Uuid.GetHashCode();
                if (this.PnApns != null)
                    hashCode = hashCode * 59 + this.PnApns.GetHashCode();
                if (this.Event != null)
                    hashCode = hashCode * 59 + this.Event.GetHashCode();
                if (this.SubscriptionId != null)
                    hashCode = hashCode * 59 + this.SubscriptionId.GetHashCode();
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                if (this.ExtensionId != null)
                    hashCode = hashCode * 59 + this.ExtensionId.GetHashCode();
                if (this.Action != null)
                    hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.SessionId != null)
                    hashCode = hashCode * 59 + this.SessionId.GetHashCode();
                if (this.ServerId != null)
                    hashCode = hashCode * 59 + this.ServerId.GetHashCode();
                if (this.From != null)
                    hashCode = hashCode * 59 + this.From.GetHashCode();
                if (this.FromName != null)
                    hashCode = hashCode * 59 + this.FromName.GetHashCode();
                if (this.To != null)
                    hashCode = hashCode * 59 + this.To.GetHashCode();
                if (this.ToName != null)
                    hashCode = hashCode * 59 + this.ToName.GetHashCode();
                if (this.Sid != null)
                    hashCode = hashCode * 59 + this.Sid.GetHashCode();
                if (this.ToUrl != null)
                    hashCode = hashCode * 59 + this.ToUrl.GetHashCode();
                if (this.SrvLvl != null)
                    hashCode = hashCode * 59 + this.SrvLvl.GetHashCode();
                if (this.SrvLvlExt != null)
                    hashCode = hashCode * 59 + this.SrvLvlExt.GetHashCode();
                if (this.RecUrl != null)
                    hashCode = hashCode * 59 + this.RecUrl.GetHashCode();
                if (this.PnTtl != null)
                    hashCode = hashCode * 59 + this.PnTtl.GetHashCode();
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
