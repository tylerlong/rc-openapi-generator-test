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
    /// Information on navigation
    /// </summary>
    [DataContract]
    public partial class MessagingNavigationInfo :  IEquatable<MessagingNavigationInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MessagingNavigationInfo" /> class.
        /// </summary>
        /// <param name="firstPage">firstPage.</param>
        /// <param name="nextPage">nextPage.</param>
        /// <param name="previousPage">previousPage.</param>
        /// <param name="lastPage">lastPage.</param>
        public MessagingNavigationInfo(MessagingNavigationInfoURI firstPage = default(MessagingNavigationInfoURI), MessagingNavigationInfoURI nextPage = default(MessagingNavigationInfoURI), MessagingNavigationInfoURI previousPage = default(MessagingNavigationInfoURI), MessagingNavigationInfoURI lastPage = default(MessagingNavigationInfoURI))
        {
            this.FirstPage = firstPage;
            this.NextPage = nextPage;
            this.PreviousPage = previousPage;
            this.LastPage = lastPage;
        }

        /// <summary>
        /// Gets or Sets FirstPage
        /// </summary>
        [DataMember(Name="firstPage", EmitDefaultValue=false)]
        public MessagingNavigationInfoURI FirstPage { get; set; }

        /// <summary>
        /// Gets or Sets NextPage
        /// </summary>
        [DataMember(Name="nextPage", EmitDefaultValue=false)]
        public MessagingNavigationInfoURI NextPage { get; set; }

        /// <summary>
        /// Gets or Sets PreviousPage
        /// </summary>
        [DataMember(Name="previousPage", EmitDefaultValue=false)]
        public MessagingNavigationInfoURI PreviousPage { get; set; }

        /// <summary>
        /// Gets or Sets LastPage
        /// </summary>
        [DataMember(Name="lastPage", EmitDefaultValue=false)]
        public MessagingNavigationInfoURI LastPage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessagingNavigationInfo {\n");
            sb.Append("  FirstPage: ").Append(FirstPage).Append("\n");
            sb.Append("  NextPage: ").Append(NextPage).Append("\n");
            sb.Append("  PreviousPage: ").Append(PreviousPage).Append("\n");
            sb.Append("  LastPage: ").Append(LastPage).Append("\n");
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
            return this.Equals(input as MessagingNavigationInfo);
        }

        /// <summary>
        /// Returns true if MessagingNavigationInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of MessagingNavigationInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessagingNavigationInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FirstPage == input.FirstPage ||
                    (this.FirstPage != null &&
                    this.FirstPage.Equals(input.FirstPage))
                ) && 
                (
                    this.NextPage == input.NextPage ||
                    (this.NextPage != null &&
                    this.NextPage.Equals(input.NextPage))
                ) && 
                (
                    this.PreviousPage == input.PreviousPage ||
                    (this.PreviousPage != null &&
                    this.PreviousPage.Equals(input.PreviousPage))
                ) && 
                (
                    this.LastPage == input.LastPage ||
                    (this.LastPage != null &&
                    this.LastPage.Equals(input.LastPage))
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
                if (this.FirstPage != null)
                    hashCode = hashCode * 59 + this.FirstPage.GetHashCode();
                if (this.NextPage != null)
                    hashCode = hashCode * 59 + this.NextPage.GetHashCode();
                if (this.PreviousPage != null)
                    hashCode = hashCode * 59 + this.PreviousPage.GetHashCode();
                if (this.LastPage != null)
                    hashCode = hashCode * 59 + this.LastPage.GetHashCode();
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
