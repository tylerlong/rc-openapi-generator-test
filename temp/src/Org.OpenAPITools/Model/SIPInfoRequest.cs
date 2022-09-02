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
    /// SIPInfoRequest
    /// </summary>
    [DataContract]
    public partial class SIPInfoRequest :  IEquatable<SIPInfoRequest>, IValidatableObject
    {
        /// <summary>
        /// Supported transport. SIP info will be returned for this transport if supported
        /// </summary>
        /// <value>Supported transport. SIP info will be returned for this transport if supported</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TransportEnum
        {
            /// <summary>
            /// Enum UDP for value: UDP
            /// </summary>
            [EnumMember(Value = "UDP")]
            UDP = 1,

            /// <summary>
            /// Enum TCP for value: TCP
            /// </summary>
            [EnumMember(Value = "TCP")]
            TCP = 2,

            /// <summary>
            /// Enum TLS for value: TLS
            /// </summary>
            [EnumMember(Value = "TLS")]
            TLS = 3,

            /// <summary>
            /// Enum WS for value: WS
            /// </summary>
            [EnumMember(Value = "WS")]
            WS = 4,

            /// <summary>
            /// Enum WSS for value: WSS
            /// </summary>
            [EnumMember(Value = "WSS")]
            WSS = 5

        }

        /// <summary>
        /// Supported transport. SIP info will be returned for this transport if supported
        /// </summary>
        /// <value>Supported transport. SIP info will be returned for this transport if supported</value>
        [DataMember(Name="transport", EmitDefaultValue=false)]
        public TransportEnum? Transport { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SIPInfoRequest" /> class.
        /// </summary>
        /// <param name="transport">Supported transport. SIP info will be returned for this transport if supported.</param>
        public SIPInfoRequest(TransportEnum? transport = default(TransportEnum?))
        {
            this.Transport = transport;
        }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SIPInfoRequest {\n");
            sb.Append("  Transport: ").Append(Transport).Append("\n");
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
            return this.Equals(input as SIPInfoRequest);
        }

        /// <summary>
        /// Returns true if SIPInfoRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SIPInfoRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SIPInfoRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Transport == input.Transport ||
                    (this.Transport != null &&
                    this.Transport.Equals(input.Transport))
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
                if (this.Transport != null)
                    hashCode = hashCode * 59 + this.Transport.GetHashCode();
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
