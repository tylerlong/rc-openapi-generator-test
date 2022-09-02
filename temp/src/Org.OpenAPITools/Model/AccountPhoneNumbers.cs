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
    /// AccountPhoneNumbers
    /// </summary>
    [DataContract]
    public partial class AccountPhoneNumbers :  IEquatable<AccountPhoneNumbers>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountPhoneNumbers" /> class.
        /// </summary>
        /// <param name="uri">Link to the list of account phone numbers.</param>
        /// <param name="records">List of account phone numbers.</param>
        /// <param name="navigation">navigation.</param>
        /// <param name="paging">paging.</param>
        public AccountPhoneNumbers(string uri = default(string), List<CompanyPhoneNumberInfo> records = default(List<CompanyPhoneNumberInfo>), ProvisioningNavigationInfo navigation = default(ProvisioningNavigationInfo), ProvisioningPagingInfo paging = default(ProvisioningPagingInfo))
        {
            this.Uri = uri;
            this.Records = records;
            this.Navigation = navigation;
            this.Paging = paging;
        }

        /// <summary>
        /// Link to the list of account phone numbers
        /// </summary>
        /// <value>Link to the list of account phone numbers</value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }

        /// <summary>
        /// List of account phone numbers
        /// </summary>
        /// <value>List of account phone numbers</value>
        [DataMember(Name="records", EmitDefaultValue=false)]
        public List<CompanyPhoneNumberInfo> Records { get; set; }

        /// <summary>
        /// Gets or Sets Navigation
        /// </summary>
        [DataMember(Name="navigation", EmitDefaultValue=false)]
        public ProvisioningNavigationInfo Navigation { get; set; }

        /// <summary>
        /// Gets or Sets Paging
        /// </summary>
        [DataMember(Name="paging", EmitDefaultValue=false)]
        public ProvisioningPagingInfo Paging { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountPhoneNumbers {\n");
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
            return this.Equals(input as AccountPhoneNumbers);
        }

        /// <summary>
        /// Returns true if AccountPhoneNumbers instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountPhoneNumbers to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountPhoneNumbers input)
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
