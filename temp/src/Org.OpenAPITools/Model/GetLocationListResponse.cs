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
    /// GetLocationListResponse
    /// </summary>
    [DataContract]
    public partial class GetLocationListResponse :  IEquatable<GetLocationListResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetLocationListResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetLocationListResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetLocationListResponse" /> class.
        /// </summary>
        /// <param name="uri">Link to the location list resource.</param>
        /// <param name="records">List of locations.</param>
        /// <param name="navigation">navigation (required).</param>
        /// <param name="paging">paging (required).</param>
        public GetLocationListResponse(string uri = default(string), List<LocationInfo> records = default(List<LocationInfo>), ProvisioningNavigationInfo navigation = default(ProvisioningNavigationInfo), ProvisioningPagingInfo paging = default(ProvisioningPagingInfo))
        {
            // to ensure "navigation" is required (not null)
            if (navigation == null)
            {
                throw new InvalidDataException("navigation is a required property for GetLocationListResponse and cannot be null");
            }
            else
            {
                this.Navigation = navigation;
            }

            // to ensure "paging" is required (not null)
            if (paging == null)
            {
                throw new InvalidDataException("paging is a required property for GetLocationListResponse and cannot be null");
            }
            else
            {
                this.Paging = paging;
            }

            this.Uri = uri;
            this.Records = records;
        }

        /// <summary>
        /// Link to the location list resource
        /// </summary>
        /// <value>Link to the location list resource</value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }

        /// <summary>
        /// List of locations
        /// </summary>
        /// <value>List of locations</value>
        [DataMember(Name="records", EmitDefaultValue=false)]
        public List<LocationInfo> Records { get; set; }

        /// <summary>
        /// Gets or Sets Navigation
        /// </summary>
        [DataMember(Name="navigation", EmitDefaultValue=true)]
        public ProvisioningNavigationInfo Navigation { get; set; }

        /// <summary>
        /// Gets or Sets Paging
        /// </summary>
        [DataMember(Name="paging", EmitDefaultValue=true)]
        public ProvisioningPagingInfo Paging { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetLocationListResponse {\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  Records: ").Append(Records).Append("\n");
            sb.Append("  Navigation: ").Append(Navigation).Append("\n");
            sb.Append("  Paging: ").Append(Paging).Append("\n");
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
            return this.Equals(input as GetLocationListResponse);
        }

        /// <summary>
        /// Returns true if GetLocationListResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetLocationListResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetLocationListResponse input)
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
                    this.Records == input.Records ||
                    this.Records != null &&
                    input.Records != null &&
                    this.Records.SequenceEqual(input.Records)
                ) && 
                (
                    this.Navigation == input.Navigation ||
                    (this.Navigation != null &&
                    this.Navigation.Equals(input.Navigation))
                ) && 
                (
                    this.Paging == input.Paging ||
                    (this.Paging != null &&
                    this.Paging.Equals(input.Paging))
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
                if (this.Records != null)
                    hashCode = hashCode * 59 + this.Records.GetHashCode();
                if (this.Navigation != null)
                    hashCode = hashCode * 59 + this.Navigation.GetHashCode();
                if (this.Paging != null)
                    hashCode = hashCode * 59 + this.Paging.GetHashCode();
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