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
    /// Peer session/party details. Valid in &#39;Gone&#39; state of a call
    /// </summary>
    [DataContract]
    public partial class PeerInfo :  IEquatable<PeerInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PeerInfo" /> class.
        /// </summary>
        /// <param name="sessionId">sessionId.</param>
        /// <param name="telephonySessionId">telephonySessionId.</param>
        /// <param name="partyId">partyId.</param>
        public PeerInfo(string sessionId = default(string), string telephonySessionId = default(string), string partyId = default(string))
        {
            this.SessionId = sessionId;
            this.TelephonySessionId = telephonySessionId;
            this.PartyId = partyId;
        }

        /// <summary>
        /// Gets or Sets SessionId
        /// </summary>
        [DataMember(Name="sessionId", EmitDefaultValue=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// Gets or Sets TelephonySessionId
        /// </summary>
        [DataMember(Name="telephonySessionId", EmitDefaultValue=false)]
        public string TelephonySessionId { get; set; }

        /// <summary>
        /// Gets or Sets PartyId
        /// </summary>
        [DataMember(Name="partyId", EmitDefaultValue=false)]
        public string PartyId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PeerInfo {\n");
            sb.Append("  SessionId: ").Append(SessionId).Append("\n");
            sb.Append("  TelephonySessionId: ").Append(TelephonySessionId).Append("\n");
            sb.Append("  PartyId: ").Append(PartyId).Append("\n");
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
            return this.Equals(input as PeerInfo);
        }

        /// <summary>
        /// Returns true if PeerInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of PeerInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PeerInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SessionId == input.SessionId ||
                    (this.SessionId != null &&
                    this.SessionId.Equals(input.SessionId))
                ) && 
                (
                    this.TelephonySessionId == input.TelephonySessionId ||
                    (this.TelephonySessionId != null &&
                    this.TelephonySessionId.Equals(input.TelephonySessionId))
                ) && 
                (
                    this.PartyId == input.PartyId ||
                    (this.PartyId != null &&
                    this.PartyId.Equals(input.PartyId))
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
                if (this.SessionId != null)
                    hashCode = hashCode * 59 + this.SessionId.GetHashCode();
                if (this.TelephonySessionId != null)
                    hashCode = hashCode * 59 + this.TelephonySessionId.GetHashCode();
                if (this.PartyId != null)
                    hashCode = hashCode * 59 + this.PartyId.GetHashCode();
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