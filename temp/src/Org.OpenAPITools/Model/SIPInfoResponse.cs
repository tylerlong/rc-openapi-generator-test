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
    /// SIPInfoResponse
    /// </summary>
    [DataContract]
    public partial class SIPInfoResponse :  IEquatable<SIPInfoResponse>, IValidatableObject
    {
        /// <summary>
        /// Preferred transport. SIP info will be returned for this transport if supported
        /// </summary>
        /// <value>Preferred transport. SIP info will be returned for this transport if supported</value>
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
        /// Preferred transport. SIP info will be returned for this transport if supported
        /// </summary>
        /// <value>Preferred transport. SIP info will be returned for this transport if supported</value>
        [DataMember(Name="transport", EmitDefaultValue=false)]
        public TransportEnum? Transport { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SIPInfoResponse" /> class.
        /// </summary>
        /// <param name="username">User credentials.</param>
        /// <param name="password">User password.</param>
        /// <param name="authorizationId">Identifier for SIP authorization.</param>
        /// <param name="domain">SIP domain.</param>
        /// <param name="outboundProxy">SIP outbound proxy.</param>
        /// <param name="outboundProxyIPv6">SIP outbound IPv6 proxy.</param>
        /// <param name="outboundProxyBackup">SIP outbound proxy backup.</param>
        /// <param name="outboundProxyIPv6Backup">SIP outbound IPv6 proxy backup.</param>
        /// <param name="transport">Preferred transport. SIP info will be returned for this transport if supported.</param>
        /// <param name="certificate">For TLS transport only Base64 encoded certificate.</param>
        /// <param name="switchBackInterval">The interval in seconds after which the app must try to switch back to primary proxy if it was previously switched to backup. If this parameter is not returned, the app must stay on backup proxy and try to switch to primary proxy after the next SIP-provision call..</param>
        public SIPInfoResponse(string username = default(string), string password = default(string), string authorizationId = default(string), string domain = default(string), string outboundProxy = default(string), string outboundProxyIPv6 = default(string), string outboundProxyBackup = default(string), string outboundProxyIPv6Backup = default(string), TransportEnum? transport = default(TransportEnum?), string certificate = default(string), int switchBackInterval = default(int))
        {
            this.Username = username;
            this.Password = password;
            this.AuthorizationId = authorizationId;
            this.Domain = domain;
            this.OutboundProxy = outboundProxy;
            this.OutboundProxyIPv6 = outboundProxyIPv6;
            this.OutboundProxyBackup = outboundProxyBackup;
            this.OutboundProxyIPv6Backup = outboundProxyIPv6Backup;
            this.Transport = transport;
            this.Certificate = certificate;
            this.SwitchBackInterval = switchBackInterval;
        }

        /// <summary>
        /// User credentials
        /// </summary>
        /// <value>User credentials</value>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// User password
        /// </summary>
        /// <value>User password</value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// Identifier for SIP authorization
        /// </summary>
        /// <value>Identifier for SIP authorization</value>
        [DataMember(Name="authorizationId", EmitDefaultValue=false)]
        public string AuthorizationId { get; set; }

        /// <summary>
        /// SIP domain
        /// </summary>
        /// <value>SIP domain</value>
        [DataMember(Name="domain", EmitDefaultValue=false)]
        public string Domain { get; set; }

        /// <summary>
        /// SIP outbound proxy
        /// </summary>
        /// <value>SIP outbound proxy</value>
        [DataMember(Name="outboundProxy", EmitDefaultValue=false)]
        public string OutboundProxy { get; set; }

        /// <summary>
        /// SIP outbound IPv6 proxy
        /// </summary>
        /// <value>SIP outbound IPv6 proxy</value>
        [DataMember(Name="outboundProxyIPv6", EmitDefaultValue=false)]
        public string OutboundProxyIPv6 { get; set; }

        /// <summary>
        /// SIP outbound proxy backup
        /// </summary>
        /// <value>SIP outbound proxy backup</value>
        [DataMember(Name="outboundProxyBackup", EmitDefaultValue=false)]
        public string OutboundProxyBackup { get; set; }

        /// <summary>
        /// SIP outbound IPv6 proxy backup
        /// </summary>
        /// <value>SIP outbound IPv6 proxy backup</value>
        [DataMember(Name="outboundProxyIPv6Backup", EmitDefaultValue=false)]
        public string OutboundProxyIPv6Backup { get; set; }


        /// <summary>
        /// For TLS transport only Base64 encoded certificate
        /// </summary>
        /// <value>For TLS transport only Base64 encoded certificate</value>
        [DataMember(Name="certificate", EmitDefaultValue=false)]
        public string Certificate { get; set; }

        /// <summary>
        /// The interval in seconds after which the app must try to switch back to primary proxy if it was previously switched to backup. If this parameter is not returned, the app must stay on backup proxy and try to switch to primary proxy after the next SIP-provision call.
        /// </summary>
        /// <value>The interval in seconds after which the app must try to switch back to primary proxy if it was previously switched to backup. If this parameter is not returned, the app must stay on backup proxy and try to switch to primary proxy after the next SIP-provision call.</value>
        [DataMember(Name="switchBackInterval", EmitDefaultValue=false)]
        public int SwitchBackInterval { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SIPInfoResponse {\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  AuthorizationId: ").Append(AuthorizationId).Append("\n");
            sb.Append("  Domain: ").Append(Domain).Append("\n");
            sb.Append("  OutboundProxy: ").Append(OutboundProxy).Append("\n");
            sb.Append("  OutboundProxyIPv6: ").Append(OutboundProxyIPv6).Append("\n");
            sb.Append("  OutboundProxyBackup: ").Append(OutboundProxyBackup).Append("\n");
            sb.Append("  OutboundProxyIPv6Backup: ").Append(OutboundProxyIPv6Backup).Append("\n");
            sb.Append("  Transport: ").Append(Transport).Append("\n");
            sb.Append("  Certificate: ").Append(Certificate).Append("\n");
            sb.Append("  SwitchBackInterval: ").Append(SwitchBackInterval).Append("\n");
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
            return this.Equals(input as SIPInfoResponse);
        }

        /// <summary>
        /// Returns true if SIPInfoResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SIPInfoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SIPInfoResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.AuthorizationId == input.AuthorizationId ||
                    (this.AuthorizationId != null &&
                    this.AuthorizationId.Equals(input.AuthorizationId))
                ) && 
                (
                    this.Domain == input.Domain ||
                    (this.Domain != null &&
                    this.Domain.Equals(input.Domain))
                ) && 
                (
                    this.OutboundProxy == input.OutboundProxy ||
                    (this.OutboundProxy != null &&
                    this.OutboundProxy.Equals(input.OutboundProxy))
                ) && 
                (
                    this.OutboundProxyIPv6 == input.OutboundProxyIPv6 ||
                    (this.OutboundProxyIPv6 != null &&
                    this.OutboundProxyIPv6.Equals(input.OutboundProxyIPv6))
                ) && 
                (
                    this.OutboundProxyBackup == input.OutboundProxyBackup ||
                    (this.OutboundProxyBackup != null &&
                    this.OutboundProxyBackup.Equals(input.OutboundProxyBackup))
                ) && 
                (
                    this.OutboundProxyIPv6Backup == input.OutboundProxyIPv6Backup ||
                    (this.OutboundProxyIPv6Backup != null &&
                    this.OutboundProxyIPv6Backup.Equals(input.OutboundProxyIPv6Backup))
                ) && 
                (
                    this.Transport == input.Transport ||
                    (this.Transport != null &&
                    this.Transport.Equals(input.Transport))
                ) && 
                (
                    this.Certificate == input.Certificate ||
                    (this.Certificate != null &&
                    this.Certificate.Equals(input.Certificate))
                ) && 
                (
                    this.SwitchBackInterval == input.SwitchBackInterval ||
                    (this.SwitchBackInterval != null &&
                    this.SwitchBackInterval.Equals(input.SwitchBackInterval))
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
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.AuthorizationId != null)
                    hashCode = hashCode * 59 + this.AuthorizationId.GetHashCode();
                if (this.Domain != null)
                    hashCode = hashCode * 59 + this.Domain.GetHashCode();
                if (this.OutboundProxy != null)
                    hashCode = hashCode * 59 + this.OutboundProxy.GetHashCode();
                if (this.OutboundProxyIPv6 != null)
                    hashCode = hashCode * 59 + this.OutboundProxyIPv6.GetHashCode();
                if (this.OutboundProxyBackup != null)
                    hashCode = hashCode * 59 + this.OutboundProxyBackup.GetHashCode();
                if (this.OutboundProxyIPv6Backup != null)
                    hashCode = hashCode * 59 + this.OutboundProxyIPv6Backup.GetHashCode();
                if (this.Transport != null)
                    hashCode = hashCode * 59 + this.Transport.GetHashCode();
                if (this.Certificate != null)
                    hashCode = hashCode * 59 + this.Certificate.GetHashCode();
                if (this.SwitchBackInterval != null)
                    hashCode = hashCode * 59 + this.SwitchBackInterval.GetHashCode();
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