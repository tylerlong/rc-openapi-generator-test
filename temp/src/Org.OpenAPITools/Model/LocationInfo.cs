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
    /// LocationInfo
    /// </summary>
    [DataContract]
    public partial class LocationInfo :  IEquatable<LocationInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LocationInfo" /> class.
        /// </summary>
        /// <param name="uri">Canonical URI of a location.</param>
        /// <param name="areaCode">Area code of the location.</param>
        /// <param name="city">Official name of the city, belonging to the certain state.</param>
        /// <param name="npa">Area code of the location (3-digit usually), according to the NANP number format, that can be summarized as NPA-NXX-xxxx and covers Canada, the United States, parts of the Caribbean Sea, and some Atlantic and Pacific islands. See for details North American Numbering Plan.</param>
        /// <param name="nxx">Central office code of the location, according to the NANP number format, that can be summarized as NPA-NXX-xxxx and covers Canada, the United States, parts of the Caribbean Sea, and some Atlantic and Pacific islands. See for details North American Numbering Plan.</param>
        /// <param name="state">state.</param>
        public LocationInfo(string uri = default(string), string areaCode = default(string), string city = default(string), string npa = default(string), string nxx = default(string), LocationStateInfo state = default(LocationStateInfo))
        {
            this.Uri = uri;
            this.AreaCode = areaCode;
            this.City = city;
            this.Npa = npa;
            this.Nxx = nxx;
            this.State = state;
        }

        /// <summary>
        /// Canonical URI of a location
        /// </summary>
        /// <value>Canonical URI of a location</value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }

        /// <summary>
        /// Area code of the location
        /// </summary>
        /// <value>Area code of the location</value>
        [DataMember(Name="areaCode", EmitDefaultValue=false)]
        public string AreaCode { get; set; }

        /// <summary>
        /// Official name of the city, belonging to the certain state
        /// </summary>
        /// <value>Official name of the city, belonging to the certain state</value>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }

        /// <summary>
        /// Area code of the location (3-digit usually), according to the NANP number format, that can be summarized as NPA-NXX-xxxx and covers Canada, the United States, parts of the Caribbean Sea, and some Atlantic and Pacific islands. See for details North American Numbering Plan
        /// </summary>
        /// <value>Area code of the location (3-digit usually), according to the NANP number format, that can be summarized as NPA-NXX-xxxx and covers Canada, the United States, parts of the Caribbean Sea, and some Atlantic and Pacific islands. See for details North American Numbering Plan</value>
        [DataMember(Name="npa", EmitDefaultValue=false)]
        public string Npa { get; set; }

        /// <summary>
        /// Central office code of the location, according to the NANP number format, that can be summarized as NPA-NXX-xxxx and covers Canada, the United States, parts of the Caribbean Sea, and some Atlantic and Pacific islands. See for details North American Numbering Plan
        /// </summary>
        /// <value>Central office code of the location, according to the NANP number format, that can be summarized as NPA-NXX-xxxx and covers Canada, the United States, parts of the Caribbean Sea, and some Atlantic and Pacific islands. See for details North American Numbering Plan</value>
        [DataMember(Name="nxx", EmitDefaultValue=false)]
        public string Nxx { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public LocationStateInfo State { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LocationInfo {\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  AreaCode: ").Append(AreaCode).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Npa: ").Append(Npa).Append("\n");
            sb.Append("  Nxx: ").Append(Nxx).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
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
            return this.Equals(input as LocationInfo);
        }

        /// <summary>
        /// Returns true if LocationInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of LocationInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LocationInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Uri == input.Uri ||
                    (this.Uri != null &&
                    this.Uri.Equals(input.Uri))
                ) && 
                (
                    this.AreaCode == input.AreaCode ||
                    (this.AreaCode != null &&
                    this.AreaCode.Equals(input.AreaCode))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.Npa == input.Npa ||
                    (this.Npa != null &&
                    this.Npa.Equals(input.Npa))
                ) && 
                (
                    this.Nxx == input.Nxx ||
                    (this.Nxx != null &&
                    this.Nxx.Equals(input.Nxx))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
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
                if (this.Uri != null)
                    hashCode = hashCode * 59 + this.Uri.GetHashCode();
                if (this.AreaCode != null)
                    hashCode = hashCode * 59 + this.AreaCode.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.Npa != null)
                    hashCode = hashCode * 59 + this.Npa.GetHashCode();
                if (this.Nxx != null)
                    hashCode = hashCode * 59 + this.Nxx.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
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
