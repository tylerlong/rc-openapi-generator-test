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
    /// PrivateIpRangeInfoRequest
    /// </summary>
    [DataContract]
    public partial class PrivateIpRangeInfoRequest :  IEquatable<PrivateIpRangeInfoRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateIpRangeInfoRequest" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="startIp">startIp.</param>
        /// <param name="endIp">endIp.</param>
        /// <param name="name">Network name.</param>
        /// <param name="emergencyAddress">emergencyAddress.</param>
        /// <param name="emergencyLocationId">Emergency response location (address) internal identifier. Only one of a pair &#x60;emergencyAddress&#x60; or &#x60;emergencyLocationId&#x60; should be specified, otherwise the error is returned.</param>
        public PrivateIpRangeInfoRequest(string id = default(string), string startIp = default(string), string endIp = default(string), string name = default(string), LocationUpdatesEmergencyAddressInfoRequest emergencyAddress = default(LocationUpdatesEmergencyAddressInfoRequest), string emergencyLocationId = default(string))
        {
            this.Id = id;
            this.StartIp = startIp;
            this.EndIp = endIp;
            this.Name = name;
            this.EmergencyAddress = emergencyAddress;
            this.EmergencyLocationId = emergencyLocationId;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets StartIp
        /// </summary>
        [DataMember(Name="startIp", EmitDefaultValue=false)]
        public string StartIp { get; set; }

        /// <summary>
        /// Gets or Sets EndIp
        /// </summary>
        [DataMember(Name="endIp", EmitDefaultValue=false)]
        public string EndIp { get; set; }

        /// <summary>
        /// Network name
        /// </summary>
        /// <value>Network name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets EmergencyAddress
        /// </summary>
        [DataMember(Name="emergencyAddress", EmitDefaultValue=false)]
        public LocationUpdatesEmergencyAddressInfoRequest EmergencyAddress { get; set; }

        /// <summary>
        /// Emergency response location (address) internal identifier. Only one of a pair &#x60;emergencyAddress&#x60; or &#x60;emergencyLocationId&#x60; should be specified, otherwise the error is returned
        /// </summary>
        /// <value>Emergency response location (address) internal identifier. Only one of a pair &#x60;emergencyAddress&#x60; or &#x60;emergencyLocationId&#x60; should be specified, otherwise the error is returned</value>
        [DataMember(Name="emergencyLocationId", EmitDefaultValue=false)]
        public string EmergencyLocationId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PrivateIpRangeInfoRequest {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  StartIp: ").Append(StartIp).Append("\n");
            sb.Append("  EndIp: ").Append(EndIp).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  EmergencyAddress: ").Append(EmergencyAddress).Append("\n");
            sb.Append("  EmergencyLocationId: ").Append(EmergencyLocationId).Append("\n");
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
            return this.Equals(input as PrivateIpRangeInfoRequest);
        }

        /// <summary>
        /// Returns true if PrivateIpRangeInfoRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PrivateIpRangeInfoRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PrivateIpRangeInfoRequest input)
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
                    this.StartIp == input.StartIp ||
                    (this.StartIp != null &&
                    this.StartIp.Equals(input.StartIp))
                ) && 
                (
                    this.EndIp == input.EndIp ||
                    (this.EndIp != null &&
                    this.EndIp.Equals(input.EndIp))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.EmergencyAddress == input.EmergencyAddress ||
                    (this.EmergencyAddress != null &&
                    this.EmergencyAddress.Equals(input.EmergencyAddress))
                ) && 
                (
                    this.EmergencyLocationId == input.EmergencyLocationId ||
                    (this.EmergencyLocationId != null &&
                    this.EmergencyLocationId.Equals(input.EmergencyLocationId))
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
                if (this.StartIp != null)
                    hashCode = hashCode * 59 + this.StartIp.GetHashCode();
                if (this.EndIp != null)
                    hashCode = hashCode * 59 + this.EndIp.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.EmergencyAddress != null)
                    hashCode = hashCode * 59 + this.EmergencyAddress.GetHashCode();
                if (this.EmergencyLocationId != null)
                    hashCode = hashCode * 59 + this.EmergencyLocationId.GetHashCode();
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
