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
    /// Emergency address assigned to the switch. Only one of a pair &#x60;emergencyAddress&#x60; or &#x60;emergencyLocationId&#x60; should be specified, otherwise the error is returned
    /// </summary>
    [DataContract]
    public partial class LocationUpdatesEmergencyAddressInfoRequest :  IEquatable<LocationUpdatesEmergencyAddressInfoRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LocationUpdatesEmergencyAddressInfoRequest" /> class.
        /// </summary>
        /// <param name="country">Country name.</param>
        /// <param name="countryId">Internal identifier of a country.</param>
        /// <param name="countryIsoCode">ISO code of a country.</param>
        /// <param name="countryName">Full name of a country.</param>
        /// <param name="customerName">Customer name.</param>
        /// <param name="state">State/Province name. Mandatory for the USA, the UK and Canada.</param>
        /// <param name="stateId">Internal identifier of a state.</param>
        /// <param name="stateIsoCode">ISO code of a state.</param>
        /// <param name="stateName">Full name of a state.</param>
        /// <param name="city">City name.</param>
        /// <param name="street">First line address.</param>
        /// <param name="street2">Second line address (apartment, suite, unit, building, floor, etc.).</param>
        /// <param name="zip">Postal (Zip) code.</param>
        public LocationUpdatesEmergencyAddressInfoRequest(string country = default(string), string countryId = default(string), string countryIsoCode = default(string), string countryName = default(string), string customerName = default(string), string state = default(string), string stateId = default(string), string stateIsoCode = default(string), string stateName = default(string), string city = default(string), string street = default(string), string street2 = default(string), string zip = default(string))
        {
            this.Country = country;
            this.CountryId = countryId;
            this.CountryIsoCode = countryIsoCode;
            this.CountryName = countryName;
            this.CustomerName = customerName;
            this.State = state;
            this.StateId = stateId;
            this.StateIsoCode = stateIsoCode;
            this.StateName = stateName;
            this.City = city;
            this.Street = street;
            this.Street2 = street2;
            this.Zip = zip;
        }

        /// <summary>
        /// Country name
        /// </summary>
        /// <value>Country name</value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// Internal identifier of a country
        /// </summary>
        /// <value>Internal identifier of a country</value>
        [DataMember(Name="countryId", EmitDefaultValue=false)]
        public string CountryId { get; set; }

        /// <summary>
        /// ISO code of a country
        /// </summary>
        /// <value>ISO code of a country</value>
        [DataMember(Name="countryIsoCode", EmitDefaultValue=false)]
        public string CountryIsoCode { get; set; }

        /// <summary>
        /// Full name of a country
        /// </summary>
        /// <value>Full name of a country</value>
        [DataMember(Name="countryName", EmitDefaultValue=false)]
        public string CountryName { get; set; }

        /// <summary>
        /// Customer name
        /// </summary>
        /// <value>Customer name</value>
        [DataMember(Name="customerName", EmitDefaultValue=false)]
        public string CustomerName { get; set; }

        /// <summary>
        /// State/Province name. Mandatory for the USA, the UK and Canada
        /// </summary>
        /// <value>State/Province name. Mandatory for the USA, the UK and Canada</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }

        /// <summary>
        /// Internal identifier of a state
        /// </summary>
        /// <value>Internal identifier of a state</value>
        [DataMember(Name="stateId", EmitDefaultValue=false)]
        public string StateId { get; set; }

        /// <summary>
        /// ISO code of a state
        /// </summary>
        /// <value>ISO code of a state</value>
        [DataMember(Name="stateIsoCode", EmitDefaultValue=false)]
        public string StateIsoCode { get; set; }

        /// <summary>
        /// Full name of a state
        /// </summary>
        /// <value>Full name of a state</value>
        [DataMember(Name="stateName", EmitDefaultValue=false)]
        public string StateName { get; set; }

        /// <summary>
        /// City name
        /// </summary>
        /// <value>City name</value>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }

        /// <summary>
        /// First line address
        /// </summary>
        /// <value>First line address</value>
        [DataMember(Name="street", EmitDefaultValue=false)]
        public string Street { get; set; }

        /// <summary>
        /// Second line address (apartment, suite, unit, building, floor, etc.)
        /// </summary>
        /// <value>Second line address (apartment, suite, unit, building, floor, etc.)</value>
        [DataMember(Name="street2", EmitDefaultValue=false)]
        public string Street2 { get; set; }

        /// <summary>
        /// Postal (Zip) code
        /// </summary>
        /// <value>Postal (Zip) code</value>
        [DataMember(Name="zip", EmitDefaultValue=false)]
        public string Zip { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LocationUpdatesEmergencyAddressInfoRequest {\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  CountryId: ").Append(CountryId).Append("\n");
            sb.Append("  CountryIsoCode: ").Append(CountryIsoCode).Append("\n");
            sb.Append("  CountryName: ").Append(CountryName).Append("\n");
            sb.Append("  CustomerName: ").Append(CustomerName).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  StateId: ").Append(StateId).Append("\n");
            sb.Append("  StateIsoCode: ").Append(StateIsoCode).Append("\n");
            sb.Append("  StateName: ").Append(StateName).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Street: ").Append(Street).Append("\n");
            sb.Append("  Street2: ").Append(Street2).Append("\n");
            sb.Append("  Zip: ").Append(Zip).Append("\n");
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
            return this.Equals(input as LocationUpdatesEmergencyAddressInfoRequest);
        }

        /// <summary>
        /// Returns true if LocationUpdatesEmergencyAddressInfoRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of LocationUpdatesEmergencyAddressInfoRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LocationUpdatesEmergencyAddressInfoRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.CountryId == input.CountryId ||
                    (this.CountryId != null &&
                    this.CountryId.Equals(input.CountryId))
                ) && 
                (
                    this.CountryIsoCode == input.CountryIsoCode ||
                    (this.CountryIsoCode != null &&
                    this.CountryIsoCode.Equals(input.CountryIsoCode))
                ) && 
                (
                    this.CountryName == input.CountryName ||
                    (this.CountryName != null &&
                    this.CountryName.Equals(input.CountryName))
                ) && 
                (
                    this.CustomerName == input.CustomerName ||
                    (this.CustomerName != null &&
                    this.CustomerName.Equals(input.CustomerName))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.StateId == input.StateId ||
                    (this.StateId != null &&
                    this.StateId.Equals(input.StateId))
                ) && 
                (
                    this.StateIsoCode == input.StateIsoCode ||
                    (this.StateIsoCode != null &&
                    this.StateIsoCode.Equals(input.StateIsoCode))
                ) && 
                (
                    this.StateName == input.StateName ||
                    (this.StateName != null &&
                    this.StateName.Equals(input.StateName))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.Street == input.Street ||
                    (this.Street != null &&
                    this.Street.Equals(input.Street))
                ) && 
                (
                    this.Street2 == input.Street2 ||
                    (this.Street2 != null &&
                    this.Street2.Equals(input.Street2))
                ) && 
                (
                    this.Zip == input.Zip ||
                    (this.Zip != null &&
                    this.Zip.Equals(input.Zip))
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
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.CountryId != null)
                    hashCode = hashCode * 59 + this.CountryId.GetHashCode();
                if (this.CountryIsoCode != null)
                    hashCode = hashCode * 59 + this.CountryIsoCode.GetHashCode();
                if (this.CountryName != null)
                    hashCode = hashCode * 59 + this.CountryName.GetHashCode();
                if (this.CustomerName != null)
                    hashCode = hashCode * 59 + this.CustomerName.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.StateId != null)
                    hashCode = hashCode * 59 + this.StateId.GetHashCode();
                if (this.StateIsoCode != null)
                    hashCode = hashCode * 59 + this.StateIsoCode.GetHashCode();
                if (this.StateName != null)
                    hashCode = hashCode * 59 + this.StateName.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.Street != null)
                    hashCode = hashCode * 59 + this.Street.GetHashCode();
                if (this.Street2 != null)
                    hashCode = hashCode * 59 + this.Street2.GetHashCode();
                if (this.Zip != null)
                    hashCode = hashCode * 59 + this.Zip.GetHashCode();
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
