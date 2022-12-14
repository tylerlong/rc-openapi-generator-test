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
    /// UserAnsweringRuleListPaging
    /// </summary>
    [DataContract]
    public partial class UserAnsweringRuleListPaging :  IEquatable<UserAnsweringRuleListPaging>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserAnsweringRuleListPaging" /> class.
        /// </summary>
        /// <param name="page">The current page number. 1-indexed, so the first page is 1 by default. May be omitted if result is empty (because non-existent page was specified or perPage&#x3D;0 was requested).</param>
        /// <param name="totalPages">The total number of pages in a dataset..</param>
        /// <param name="perPage">Current page size, describes how many items are in each page. Default value is 100. Maximum value is 1000. If perPage value in the request is greater than 1000, the maximum value (1000) is applied.</param>
        /// <param name="totalElements">The total number of elements in a dataset..</param>
        /// <param name="pageStart">The zero-based number of the first element on the current page. Omitted if the page is omitted or result is empty.</param>
        /// <param name="pageEnd">The zero-based index of the last element on the current page. Omitted if the page is omitted or result is empty.</param>
        public UserAnsweringRuleListPaging(int page = default(int), int totalPages = default(int), int perPage = default(int), int totalElements = default(int), int pageStart = default(int), int pageEnd = default(int))
        {
            this.Page = page;
            this.TotalPages = totalPages;
            this.PerPage = perPage;
            this.TotalElements = totalElements;
            this.PageStart = pageStart;
            this.PageEnd = pageEnd;
        }

        /// <summary>
        /// The current page number. 1-indexed, so the first page is 1 by default. May be omitted if result is empty (because non-existent page was specified or perPage&#x3D;0 was requested)
        /// </summary>
        /// <value>The current page number. 1-indexed, so the first page is 1 by default. May be omitted if result is empty (because non-existent page was specified or perPage&#x3D;0 was requested)</value>
        [DataMember(Name="page", EmitDefaultValue=false)]
        public int Page { get; set; }

        /// <summary>
        /// The total number of pages in a dataset.
        /// </summary>
        /// <value>The total number of pages in a dataset.</value>
        [DataMember(Name="totalPages", EmitDefaultValue=false)]
        public int TotalPages { get; set; }

        /// <summary>
        /// Current page size, describes how many items are in each page. Default value is 100. Maximum value is 1000. If perPage value in the request is greater than 1000, the maximum value (1000) is applied
        /// </summary>
        /// <value>Current page size, describes how many items are in each page. Default value is 100. Maximum value is 1000. If perPage value in the request is greater than 1000, the maximum value (1000) is applied</value>
        [DataMember(Name="perPage", EmitDefaultValue=false)]
        public int PerPage { get; set; }

        /// <summary>
        /// The total number of elements in a dataset.
        /// </summary>
        /// <value>The total number of elements in a dataset.</value>
        [DataMember(Name="totalElements", EmitDefaultValue=false)]
        public int TotalElements { get; set; }

        /// <summary>
        /// The zero-based number of the first element on the current page. Omitted if the page is omitted or result is empty
        /// </summary>
        /// <value>The zero-based number of the first element on the current page. Omitted if the page is omitted or result is empty</value>
        [DataMember(Name="pageStart", EmitDefaultValue=false)]
        public int PageStart { get; set; }

        /// <summary>
        /// The zero-based index of the last element on the current page. Omitted if the page is omitted or result is empty
        /// </summary>
        /// <value>The zero-based index of the last element on the current page. Omitted if the page is omitted or result is empty</value>
        [DataMember(Name="pageEnd", EmitDefaultValue=false)]
        public int PageEnd { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserAnsweringRuleListPaging {\n");
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
            return this.Equals(input as UserAnsweringRuleListPaging);
        }

        /// <summary>
        /// Returns true if UserAnsweringRuleListPaging instances are equal
        /// </summary>
        /// <param name="input">Instance of UserAnsweringRuleListPaging to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserAnsweringRuleListPaging input)
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
