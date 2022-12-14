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
    /// Information about a call party that is monitored
    /// </summary>
    [DataContract]
    public partial class SupervisePartyTo :  IEquatable<SupervisePartyTo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SupervisePartyTo" /> class.
        /// </summary>
        /// <param name="phoneNumber">Phone number of a party.</param>
        /// <param name="name">Displayed name of a party.</param>
        /// <param name="deviceId">Internal identifier of a device.</param>
        /// <param name="extensionId">Internal identifier of an extension.</param>
        public SupervisePartyTo(string phoneNumber = default(string), string name = default(string), string deviceId = default(string), string extensionId = default(string))
        {
            this.PhoneNumber = phoneNumber;
            this.Name = name;
            this.DeviceId = deviceId;
            this.ExtensionId = extensionId;
        }

        /// <summary>
        /// Phone number of a party
        /// </summary>
        /// <value>Phone number of a party</value>
        [DataMember(Name="phoneNumber", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Displayed name of a party
        /// </summary>
        /// <value>Displayed name of a party</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Internal identifier of a device
        /// </summary>
        /// <value>Internal identifier of a device</value>
        [DataMember(Name="deviceId", EmitDefaultValue=false)]
        public string DeviceId { get; set; }

        /// <summary>
        /// Internal identifier of an extension
        /// </summary>
        /// <value>Internal identifier of an extension</value>
        [DataMember(Name="extensionId", EmitDefaultValue=false)]
        public string ExtensionId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SupervisePartyTo {\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DeviceId: ").Append(DeviceId).Append("\n");
            sb.Append("  ExtensionId: ").Append(ExtensionId).Append("\n");
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
            return this.Equals(input as SupervisePartyTo);
        }

        /// <summary>
        /// Returns true if SupervisePartyTo instances are equal
        /// </summary>
        /// <param name="input">Instance of SupervisePartyTo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SupervisePartyTo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PhoneNumber == input.PhoneNumber ||
                    (this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(input.PhoneNumber))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.DeviceId == input.DeviceId ||
                    (this.DeviceId != null &&
                    this.DeviceId.Equals(input.DeviceId))
                ) && 
                (
                    this.ExtensionId == input.ExtensionId ||
                    (this.ExtensionId != null &&
                    this.ExtensionId.Equals(input.ExtensionId))
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
                if (this.PhoneNumber != null)
                    hashCode = hashCode * 59 + this.PhoneNumber.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.DeviceId != null)
                    hashCode = hashCode * 59 + this.DeviceId.GetHashCode();
                if (this.ExtensionId != null)
                    hashCode = hashCode * 59 + this.ExtensionId.GetHashCode();
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
