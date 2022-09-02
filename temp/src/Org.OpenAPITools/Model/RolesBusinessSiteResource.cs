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
    /// RolesBusinessSiteResource
    /// </summary>
    [DataContract]
    public partial class RolesBusinessSiteResource :  IEquatable<RolesBusinessSiteResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RolesBusinessSiteResource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RolesBusinessSiteResource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RolesBusinessSiteResource" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="email">email.</param>
        /// <param name="code">code.</param>
        /// <param name="name">name.</param>
        /// <param name="extensionNumber">extensionNumber.</param>
        /// <param name="callerIdName">callerIdName.</param>
        /// <param name="_operator">_operator.</param>
        /// <param name="regionalSettings">regionalSettings.</param>
        /// <param name="businessAddress">businessAddress.</param>
        public RolesBusinessSiteResource(string id = default(string), string email = default(string), string code = default(string), string name = default(string), string extensionNumber = default(string), string callerIdName = default(string), BasicExtensionInfoResource _operator = default(BasicExtensionInfoResource), RolesRegionalSettingsResource regionalSettings = default(RolesRegionalSettingsResource), ContactAddressInfoResource businessAddress = default(ContactAddressInfoResource))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for RolesBusinessSiteResource and cannot be null");
            }
            else
            {
                this.Id = id;
            }

            this.Email = email;
            this.Code = code;
            this.Name = name;
            this.ExtensionNumber = extensionNumber;
            this.CallerIdName = callerIdName;
            this.Operator = _operator;
            this.RegionalSettings = regionalSettings;
            this.BusinessAddress = businessAddress;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets ExtensionNumber
        /// </summary>
        [DataMember(Name="extensionNumber", EmitDefaultValue=false)]
        public string ExtensionNumber { get; set; }

        /// <summary>
        /// Gets or Sets CallerIdName
        /// </summary>
        [DataMember(Name="callerIdName", EmitDefaultValue=false)]
        public string CallerIdName { get; set; }

        /// <summary>
        /// Gets or Sets Operator
        /// </summary>
        [DataMember(Name="operator", EmitDefaultValue=false)]
        public BasicExtensionInfoResource Operator { get; set; }

        /// <summary>
        /// Gets or Sets RegionalSettings
        /// </summary>
        [DataMember(Name="regionalSettings", EmitDefaultValue=false)]
        public RolesRegionalSettingsResource RegionalSettings { get; set; }

        /// <summary>
        /// Gets or Sets BusinessAddress
        /// </summary>
        [DataMember(Name="businessAddress", EmitDefaultValue=false)]
        public ContactAddressInfoResource BusinessAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RolesBusinessSiteResource {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ExtensionNumber: ").Append(ExtensionNumber).Append("\n");
            sb.Append("  CallerIdName: ").Append(CallerIdName).Append("\n");
            sb.Append("  Operator: ").Append(Operator).Append("\n");
            sb.Append("  RegionalSettings: ").Append(RegionalSettings).Append("\n");
            sb.Append("  BusinessAddress: ").Append(BusinessAddress).Append("\n");
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
            return this.Equals(input as RolesBusinessSiteResource);
        }

        /// <summary>
        /// Returns true if RolesBusinessSiteResource instances are equal
        /// </summary>
        /// <param name="input">Instance of RolesBusinessSiteResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RolesBusinessSiteResource input)
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
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ExtensionNumber == input.ExtensionNumber ||
                    (this.ExtensionNumber != null &&
                    this.ExtensionNumber.Equals(input.ExtensionNumber))
                ) && 
                (
                    this.CallerIdName == input.CallerIdName ||
                    (this.CallerIdName != null &&
                    this.CallerIdName.Equals(input.CallerIdName))
                ) && 
                (
                    this.Operator == input.Operator ||
                    (this.Operator != null &&
                    this.Operator.Equals(input.Operator))
                ) && 
                (
                    this.RegionalSettings == input.RegionalSettings ||
                    (this.RegionalSettings != null &&
                    this.RegionalSettings.Equals(input.RegionalSettings))
                ) && 
                (
                    this.BusinessAddress == input.BusinessAddress ||
                    (this.BusinessAddress != null &&
                    this.BusinessAddress.Equals(input.BusinessAddress))
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
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ExtensionNumber != null)
                    hashCode = hashCode * 59 + this.ExtensionNumber.GetHashCode();
                if (this.CallerIdName != null)
                    hashCode = hashCode * 59 + this.CallerIdName.GetHashCode();
                if (this.Operator != null)
                    hashCode = hashCode * 59 + this.Operator.GetHashCode();
                if (this.RegionalSettings != null)
                    hashCode = hashCode * 59 + this.RegionalSettings.GetHashCode();
                if (this.BusinessAddress != null)
                    hashCode = hashCode * 59 + this.BusinessAddress.GetHashCode();
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
