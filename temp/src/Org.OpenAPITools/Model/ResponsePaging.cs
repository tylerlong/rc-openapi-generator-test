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
    /// Paging information
    /// </summary>
    [DataContract]
    public partial class ResponsePaging :  IEquatable<ResponsePaging>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsePaging" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ResponsePaging() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsePaging" /> class.
        /// </summary>
        /// <param name="page">The current page number (required).</param>
        /// <param name="perPage">How many items are displayed on the page (required).</param>
        /// <param name="totalPages">The total number of pages (required).</param>
        /// <param name="totalElements">The total number of items in the dataset (required).</param>
        public ResponsePaging(long page = default(long), long perPage = default(long), long totalPages = default(long), long totalElements = default(long))
        {
            // to ensure "page" is required (not null)
            if (page == null)
            {
                throw new InvalidDataException("page is a required property for ResponsePaging and cannot be null");
            }
            else
            {
                this.Page = page;
            }

            // to ensure "perPage" is required (not null)
            if (perPage == null)
            {
                throw new InvalidDataException("perPage is a required property for ResponsePaging and cannot be null");
            }
            else
            {
                this.PerPage = perPage;
            }

            // to ensure "totalPages" is required (not null)
            if (totalPages == null)
            {
                throw new InvalidDataException("totalPages is a required property for ResponsePaging and cannot be null");
            }
            else
            {
                this.TotalPages = totalPages;
            }

            // to ensure "totalElements" is required (not null)
            if (totalElements == null)
            {
                throw new InvalidDataException("totalElements is a required property for ResponsePaging and cannot be null");
            }
            else
            {
                this.TotalElements = totalElements;
            }

        }

        /// <summary>
        /// The current page number
        /// </summary>
        /// <value>The current page number</value>
        [DataMember(Name="page", EmitDefaultValue=true)]
        public long Page { get; set; }

        /// <summary>
        /// How many items are displayed on the page
        /// </summary>
        /// <value>How many items are displayed on the page</value>
        [DataMember(Name="perPage", EmitDefaultValue=true)]
        public long PerPage { get; set; }

        /// <summary>
        /// The total number of pages
        /// </summary>
        /// <value>The total number of pages</value>
        [DataMember(Name="totalPages", EmitDefaultValue=true)]
        public long TotalPages { get; set; }

        /// <summary>
        /// The total number of items in the dataset
        /// </summary>
        /// <value>The total number of items in the dataset</value>
        [DataMember(Name="totalElements", EmitDefaultValue=true)]
        public long TotalElements { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResponsePaging {\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
            sb.Append("  PerPage: ").Append(PerPage).Append("\n");
            sb.Append("  TotalPages: ").Append(TotalPages).Append("\n");
            sb.Append("  TotalElements: ").Append(TotalElements).Append("\n");
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
            return this.Equals(input as ResponsePaging);
        }

        /// <summary>
        /// Returns true if ResponsePaging instances are equal
        /// </summary>
        /// <param name="input">Instance of ResponsePaging to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResponsePaging input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Page == input.Page ||
                    (this.Page != null &&
                    this.Page.Equals(input.Page))
                ) && 
                (
                    this.PerPage == input.PerPage ||
                    (this.PerPage != null &&
                    this.PerPage.Equals(input.PerPage))
                ) && 
                (
                    this.TotalPages == input.TotalPages ||
                    (this.TotalPages != null &&
                    this.TotalPages.Equals(input.TotalPages))
                ) && 
                (
                    this.TotalElements == input.TotalElements ||
                    (this.TotalElements != null &&
                    this.TotalElements.Equals(input.TotalElements))
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
                if (this.Page != null)
                    hashCode = hashCode * 59 + this.Page.GetHashCode();
                if (this.PerPage != null)
                    hashCode = hashCode * 59 + this.PerPage.GetHashCode();
                if (this.TotalPages != null)
                    hashCode = hashCode * 59 + this.TotalPages.GetHashCode();
                if (this.TotalElements != null)
                    hashCode = hashCode * 59 + this.TotalElements.GetHashCode();
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
