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
    /// RNPPagingInfo
    /// </summary>
    [DataContract]
    public partial class RNPPagingInfo :  IEquatable<RNPPagingInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RNPPagingInfo" /> class.
        /// </summary>
        /// <param name="page">page.</param>
        /// <param name="totalPages">totalPages.</param>
        /// <param name="perPage">perPage.</param>
        /// <param name="totalElements">totalElements.</param>
        /// <param name="pageStart">pageStart.</param>
        /// <param name="pageEnd">pageEnd.</param>
        public RNPPagingInfo(int page = default(int), int totalPages = default(int), int perPage = default(int), int totalElements = default(int), int pageStart = default(int), int pageEnd = default(int))
        {
            this.Page = page;
            this.TotalPages = totalPages;
            this.PerPage = perPage;
            this.TotalElements = totalElements;
            this.PageStart = pageStart;
            this.PageEnd = pageEnd;
        }

        /// <summary>
        /// Gets or Sets Page
        /// </summary>
        [DataMember(Name="page", EmitDefaultValue=false)]
        public int Page { get; set; }

        /// <summary>
        /// Gets or Sets TotalPages
        /// </summary>
        [DataMember(Name="totalPages", EmitDefaultValue=false)]
        public int TotalPages { get; set; }

        /// <summary>
        /// Gets or Sets PerPage
        /// </summary>
        [DataMember(Name="perPage", EmitDefaultValue=false)]
        public int PerPage { get; set; }

        /// <summary>
        /// Gets or Sets TotalElements
        /// </summary>
        [DataMember(Name="totalElements", EmitDefaultValue=false)]
        public int TotalElements { get; set; }

        /// <summary>
        /// Gets or Sets PageStart
        /// </summary>
        [DataMember(Name="pageStart", EmitDefaultValue=false)]
        public int PageStart { get; set; }

        /// <summary>
        /// Gets or Sets PageEnd
        /// </summary>
        [DataMember(Name="pageEnd", EmitDefaultValue=false)]
        public int PageEnd { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RNPPagingInfo {\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
            sb.Append("  TotalPages: ").Append(TotalPages).Append("\n");
            sb.Append("  PerPage: ").Append(PerPage).Append("\n");
            sb.Append("  TotalElements: ").Append(TotalElements).Append("\n");
            sb.Append("  PageStart: ").Append(PageStart).Append("\n");
            sb.Append("  PageEnd: ").Append(PageEnd).Append("\n");
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
            return this.Equals(input as RNPPagingInfo);
        }

        /// <summary>
        /// Returns true if RNPPagingInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of RNPPagingInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RNPPagingInfo input)
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
                    this.TotalPages == input.TotalPages ||
                    (this.TotalPages != null &&
                    this.TotalPages.Equals(input.TotalPages))
                ) && 
                (
                    this.PerPage == input.PerPage ||
                    (this.PerPage != null &&
                    this.PerPage.Equals(input.PerPage))
                ) && 
                (
                    this.TotalElements == input.TotalElements ||
                    (this.TotalElements != null &&
                    this.TotalElements.Equals(input.TotalElements))
                ) && 
                (
                    this.PageStart == input.PageStart ||
                    (this.PageStart != null &&
                    this.PageStart.Equals(input.PageStart))
                ) && 
                (
                    this.PageEnd == input.PageEnd ||
                    (this.PageEnd != null &&
                    this.PageEnd.Equals(input.PageEnd))
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
                if (this.TotalPages != null)
                    hashCode = hashCode * 59 + this.TotalPages.GetHashCode();
                if (this.PerPage != null)
                    hashCode = hashCode * 59 + this.PerPage.GetHashCode();
                if (this.TotalElements != null)
                    hashCode = hashCode * 59 + this.TotalElements.GetHashCode();
                if (this.PageStart != null)
                    hashCode = hashCode * 59 + this.PageStart.GetHashCode();
                if (this.PageEnd != null)
                    hashCode = hashCode * 59 + this.PageEnd.GetHashCode();
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
