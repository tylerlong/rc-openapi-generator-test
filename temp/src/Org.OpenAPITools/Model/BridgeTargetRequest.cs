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
    /// BridgeTargetRequest
    /// </summary>
    [DataContract]
    public partial class BridgeTargetRequest :  IEquatable<BridgeTargetRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BridgeTargetRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BridgeTargetRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BridgeTargetRequest" /> class.
        /// </summary>
        /// <param name="telephonySessionId">Internal identifier of a call session to be connected to (bridged) (required).</param>
        /// <param name="partyId">Internal identifier of a call party to be connected to (bridged) (required).</param>
        public BridgeTargetRequest(string telephonySessionId = default(string), string partyId = default(string))
        {
            // to ensure "telephonySessionId" is required (not null)
            if (telephonySessionId == null)
            {
                throw new InvalidDataException("telephonySessionId is a required property for BridgeTargetRequest and cannot be null");
            }
            else
            {
                this.TelephonySessionId = telephonySessionId;
            }

            // to ensure "partyId" is required (not null)
            if (partyId == null)
            {
                throw new InvalidDataException("partyId is a required property for BridgeTargetRequest and cannot be null");
            }
            else
            {
                this.PartyId = partyId;
            }

        }

        /// <summary>
        /// Internal identifier of a call session to be connected to (bridged)
        /// </summary>
        /// <value>Internal identifier of a call session to be connected to (bridged)</value>
        [DataMember(Name="telephonySessionId", EmitDefaultValue=true)]
        public string TelephonySessionId { get; set; }

        /// <summary>
        /// Internal identifier of a call party to be connected to (bridged)
        /// </summary>
        /// <value>Internal identifier of a call party to be connected to (bridged)</value>
        [DataMember(Name="partyId", EmitDefaultValue=true)]
        public string PartyId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BridgeTargetRequest {\n");
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
            return this.Equals(input as BridgeTargetRequest);
        }

        /// <summary>
        /// Returns true if BridgeTargetRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of BridgeTargetRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BridgeTargetRequest input)
        {
            if (input == null)
                return false;

            return 
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
