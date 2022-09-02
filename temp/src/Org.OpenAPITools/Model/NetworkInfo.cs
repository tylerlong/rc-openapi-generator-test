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
    /// NetworkInfo
    /// </summary>
    [DataContract]
    public partial class NetworkInfo :  IEquatable<NetworkInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkInfo" /> class.
        /// </summary>
        /// <param name="id">Internal identifier of a network.</param>
        /// <param name="uri">Link to a network resource.</param>
        /// <param name="name">name.</param>
        /// <param name="site">site.</param>
        /// <param name="publicIpRanges">publicIpRanges.</param>
        /// <param name="privateIpRanges">privateIpRanges.</param>
        /// <param name="emergencyLocation">emergencyLocation.</param>
        public NetworkInfo(string id = default(string), string uri = default(string), string name = default(string), AutomaticLocationUpdatesSiteInfo site = default(AutomaticLocationUpdatesSiteInfo), List<PublicIpRangeInfo> publicIpRanges = default(List<PublicIpRangeInfo>), List<PrivateIpRangeInfo> privateIpRanges = default(List<PrivateIpRangeInfo>), ERLLocationInfo emergencyLocation = default(ERLLocationInfo))
        {
            this.Id = id;
            this.Uri = uri;
            this.Name = name;
            this.Site = site;
            this.PublicIpRanges = publicIpRanges;
            this.PrivateIpRanges = privateIpRanges;
            this.EmergencyLocation = emergencyLocation;
        }

        /// <summary>
        /// Internal identifier of a network
        /// </summary>
        /// <value>Internal identifier of a network</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Link to a network resource
        /// </summary>
        /// <value>Link to a network resource</value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Site
        /// </summary>
        [DataMember(Name="site", EmitDefaultValue=false)]
        public AutomaticLocationUpdatesSiteInfo Site { get; set; }

        /// <summary>
        /// Gets or Sets PublicIpRanges
        /// </summary>
        [DataMember(Name="publicIpRanges", EmitDefaultValue=false)]
        public List<PublicIpRangeInfo> PublicIpRanges { get; set; }

        /// <summary>
        /// Gets or Sets PrivateIpRanges
        /// </summary>
        [DataMember(Name="privateIpRanges", EmitDefaultValue=false)]
        public List<PrivateIpRangeInfo> PrivateIpRanges { get; set; }

        /// <summary>
        /// Gets or Sets EmergencyLocation
        /// </summary>
        [DataMember(Name="emergencyLocation", EmitDefaultValue=false)]
        public ERLLocationInfo EmergencyLocation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NetworkInfo {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Site: ").Append(Site).Append("\n");
            sb.Append("  PublicIpRanges: ").Append(PublicIpRanges).Append("\n");
            sb.Append("  PrivateIpRanges: ").Append(PrivateIpRanges).Append("\n");
            sb.Append("  EmergencyLocation: ").Append(EmergencyLocation).Append("\n");
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
            return this.Equals(input as NetworkInfo);
        }

        /// <summary>
        /// Returns true if NetworkInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of NetworkInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NetworkInfo input)
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
                    this.Uri == input.Uri ||
                    (this.Uri != null &&
                    this.Uri.Equals(input.Uri))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Site == input.Site ||
                    (this.Site != null &&
                    this.Site.Equals(input.Site))
                ) && 
                (
                    this.PublicIpRanges == input.PublicIpRanges ||
                    this.PublicIpRanges != null &&
                    input.PublicIpRanges != null &&
                    this.PublicIpRanges.SequenceEqual(input.PublicIpRanges)
                ) && 
                (
                    this.PrivateIpRanges == input.PrivateIpRanges ||
                    this.PrivateIpRanges != null &&
                    input.PrivateIpRanges != null &&
                    this.PrivateIpRanges.SequenceEqual(input.PrivateIpRanges)
                ) && 
                (
                    this.EmergencyLocation == input.EmergencyLocation ||
                    (this.EmergencyLocation != null &&
                    this.EmergencyLocation.Equals(input.EmergencyLocation))
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
                if (this.Uri != null)
                    hashCode = hashCode * 59 + this.Uri.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Site != null)
                    hashCode = hashCode * 59 + this.Site.GetHashCode();
                if (this.PublicIpRanges != null)
                    hashCode = hashCode * 59 + this.PublicIpRanges.GetHashCode();
                if (this.PrivateIpRanges != null)
                    hashCode = hashCode * 59 + this.PrivateIpRanges.GetHashCode();
                if (this.EmergencyLocation != null)
                    hashCode = hashCode * 59 + this.EmergencyLocation.GetHashCode();
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