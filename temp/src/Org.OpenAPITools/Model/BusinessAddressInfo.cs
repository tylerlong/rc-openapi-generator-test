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
    /// Company business address
    /// </summary>
    [DataContract]
    public partial class BusinessAddressInfo :  IEquatable<BusinessAddressInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessAddressInfo" /> class.
        /// </summary>
        /// <param name="country">Name of a country.</param>
        /// <param name="state">Name of a state/province.</param>
        /// <param name="city">Name of a city.</param>
        /// <param name="street">Street address.</param>
        /// <param name="zip">Zip code.</param>
        public BusinessAddressInfo(string country = default(string), string state = default(string), string city = default(string), string street = default(string), string zip = default(string))
        {
            this.Country = country;
            this.State = state;
            this.City = city;
            this.Street = street;
            this.Zip = zip;
        }

        /// <summary>
        /// Name of a country
        /// </summary>
        /// <value>Name of a country</value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// Name of a state/province
        /// </summary>
        /// <value>Name of a state/province</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }

        /// <summary>
        /// Name of a city
        /// </summary>
        /// <value>Name of a city</value>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }

        /// <summary>
        /// Street address
        /// </summary>
        /// <value>Street address</value>
        [DataMember(Name="street", EmitDefaultValue=false)]
        public string Street { get; set; }

        /// <summary>
        /// Zip code
        /// </summary>
        /// <value>Zip code</value>
        [DataMember(Name="zip", EmitDefaultValue=false)]
        public string Zip { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BusinessAddressInfo {\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Street: ").Append(Street).Append("\n");
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
            return this.Equals(input as BusinessAddressInfo);
        }

        /// <summary>
        /// Returns true if BusinessAddressInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of BusinessAddressInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BusinessAddressInfo input)
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
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
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
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.Street != null)
                    hashCode = hashCode * 59 + this.Street.GetHashCode();
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
