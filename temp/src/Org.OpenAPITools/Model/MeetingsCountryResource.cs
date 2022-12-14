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
    /// MeetingsCountryResource
    /// </summary>
    [DataContract]
    public partial class MeetingsCountryResource :  IEquatable<MeetingsCountryResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MeetingsCountryResource" /> class.
        /// </summary>
        /// <param name="uri">uri.</param>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="isoCode">isoCode.</param>
        /// <param name="callingCode">callingCode.</param>
        /// <param name="emergencyCalling">emergencyCalling (default to false).</param>
        /// <param name="numberSelling">numberSelling (default to false).</param>
        /// <param name="loginAllowed">loginAllowed (default to false).</param>
        public MeetingsCountryResource(string uri = default(string), string id = default(string), string name = default(string), string isoCode = default(string), string callingCode = default(string), bool emergencyCalling = false, bool numberSelling = false, bool loginAllowed = false)
        {
            this.Uri = uri;
            this.Id = id;
            this.Name = name;
            this.IsoCode = isoCode;
            this.CallingCode = callingCode;
            // use default value if no "emergencyCalling" provided
            if (emergencyCalling == null)
            {
                this.EmergencyCalling = false;
            }
            else
            {
                this.EmergencyCalling = emergencyCalling;
            }
            // use default value if no "numberSelling" provided
            if (numberSelling == null)
            {
                this.NumberSelling = false;
            }
            else
            {
                this.NumberSelling = numberSelling;
            }
            // use default value if no "loginAllowed" provided
            if (loginAllowed == null)
            {
                this.LoginAllowed = false;
            }
            else
            {
                this.LoginAllowed = loginAllowed;
            }
        }

        /// <summary>
        /// Gets or Sets Uri
        /// </summary>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets IsoCode
        /// </summary>
        [DataMember(Name="isoCode", EmitDefaultValue=false)]
        public string IsoCode { get; set; }

        /// <summary>
        /// Gets or Sets CallingCode
        /// </summary>
        [DataMember(Name="callingCode", EmitDefaultValue=false)]
        public string CallingCode { get; set; }

        /// <summary>
        /// Gets or Sets EmergencyCalling
        /// </summary>
        [DataMember(Name="emergencyCalling", EmitDefaultValue=false)]
        public bool EmergencyCalling { get; set; }

        /// <summary>
        /// Gets or Sets NumberSelling
        /// </summary>
        [DataMember(Name="numberSelling", EmitDefaultValue=false)]
        public bool NumberSelling { get; set; }

        /// <summary>
        /// Gets or Sets LoginAllowed
        /// </summary>
        [DataMember(Name="loginAllowed", EmitDefaultValue=false)]
        public bool LoginAllowed { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MeetingsCountryResource {\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  IsoCode: ").Append(IsoCode).Append("\n");
            sb.Append("  CallingCode: ").Append(CallingCode).Append("\n");
            sb.Append("  EmergencyCalling: ").Append(EmergencyCalling).Append("\n");
            sb.Append("  NumberSelling: ").Append(NumberSelling).Append("\n");
            sb.Append("  LoginAllowed: ").Append(LoginAllowed).Append("\n");
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
            return this.Equals(input as MeetingsCountryResource);
        }

        /// <summary>
        /// Returns true if MeetingsCountryResource instances are equal
        /// </summary>
        /// <param name="input">Instance of MeetingsCountryResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MeetingsCountryResource input)
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
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.IsoCode == input.IsoCode ||
                    (this.IsoCode != null &&
                    this.IsoCode.Equals(input.IsoCode))
                ) && 
                (
                    this.CallingCode == input.CallingCode ||
                    (this.CallingCode != null &&
                    this.CallingCode.Equals(input.CallingCode))
                ) && 
                (
                    this.EmergencyCalling == input.EmergencyCalling ||
                    (this.EmergencyCalling != null &&
                    this.EmergencyCalling.Equals(input.EmergencyCalling))
                ) && 
                (
                    this.NumberSelling == input.NumberSelling ||
                    (this.NumberSelling != null &&
                    this.NumberSelling.Equals(input.NumberSelling))
                ) && 
                (
                    this.LoginAllowed == input.LoginAllowed ||
                    (this.LoginAllowed != null &&
                    this.LoginAllowed.Equals(input.LoginAllowed))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.IsoCode != null)
                    hashCode = hashCode * 59 + this.IsoCode.GetHashCode();
                if (this.CallingCode != null)
                    hashCode = hashCode * 59 + this.CallingCode.GetHashCode();
                if (this.EmergencyCalling != null)
                    hashCode = hashCode * 59 + this.EmergencyCalling.GetHashCode();
                if (this.NumberSelling != null)
                    hashCode = hashCode * 59 + this.NumberSelling.GetHashCode();
                if (this.LoginAllowed != null)
                    hashCode = hashCode * 59 + this.LoginAllowed.GetHashCode();
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
