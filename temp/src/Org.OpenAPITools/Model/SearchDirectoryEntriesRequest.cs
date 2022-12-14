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
    /// SearchDirectoryEntriesRequest
    /// </summary>
    [DataContract]
    public partial class SearchDirectoryEntriesRequest :  IEquatable<SearchDirectoryEntriesRequest>, IValidatableObject
    {
        /// <summary>
        /// Defines SearchFields
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SearchFieldsEnum
        {
            /// <summary>
            /// Enum FirstName for value: firstName
            /// </summary>
            [EnumMember(Value = "firstName")]
            FirstName = 1,

            /// <summary>
            /// Enum LastName for value: lastName
            /// </summary>
            [EnumMember(Value = "lastName")]
            LastName = 2,

            /// <summary>
            /// Enum ExtensionNumber for value: extensionNumber
            /// </summary>
            [EnumMember(Value = "extensionNumber")]
            ExtensionNumber = 3,

            /// <summary>
            /// Enum PhoneNumber for value: phoneNumber
            /// </summary>
            [EnumMember(Value = "phoneNumber")]
            PhoneNumber = 4,

            /// <summary>
            /// Enum Email for value: email
            /// </summary>
            [EnumMember(Value = "email")]
            Email = 5,

            /// <summary>
            /// Enum JobTitle for value: jobTitle
            /// </summary>
            [EnumMember(Value = "jobTitle")]
            JobTitle = 6,

            /// <summary>
            /// Enum Department for value: department
            /// </summary>
            [EnumMember(Value = "department")]
            Department = 7

        }


        /// <summary>
        /// Gets or Sets SearchFields
        /// </summary>
        [DataMember(Name="searchFields", EmitDefaultValue=false)]
        public List<SearchFieldsEnum> SearchFields { get; set; }
        /// <summary>
        /// Type of extension to filter the contacts. Please note that legacy &#39;Department&#39; extension type corresponds to &#39;Call Queue&#39; extensions in modern RingCentral product terminology
        /// </summary>
        /// <value>Type of extension to filter the contacts. Please note that legacy &#39;Department&#39; extension type corresponds to &#39;Call Queue&#39; extensions in modern RingCentral product terminology</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ExtensionTypeEnum
        {
            /// <summary>
            /// Enum User for value: User
            /// </summary>
            [EnumMember(Value = "User")]
            User = 1,

            /// <summary>
            /// Enum Department for value: Department
            /// </summary>
            [EnumMember(Value = "Department")]
            Department = 2,

            /// <summary>
            /// Enum Announcement for value: Announcement
            /// </summary>
            [EnumMember(Value = "Announcement")]
            Announcement = 3,

            /// <summary>
            /// Enum Voicemail for value: Voicemail
            /// </summary>
            [EnumMember(Value = "Voicemail")]
            Voicemail = 4,

            /// <summary>
            /// Enum SharedLinesGroup for value: SharedLinesGroup
            /// </summary>
            [EnumMember(Value = "SharedLinesGroup")]
            SharedLinesGroup = 5,

            /// <summary>
            /// Enum PagingOnly for value: PagingOnly
            /// </summary>
            [EnumMember(Value = "PagingOnly")]
            PagingOnly = 6,

            /// <summary>
            /// Enum ParkLocation for value: ParkLocation
            /// </summary>
            [EnumMember(Value = "ParkLocation")]
            ParkLocation = 7,

            /// <summary>
            /// Enum IvrMenu for value: IvrMenu
            /// </summary>
            [EnumMember(Value = "IvrMenu")]
            IvrMenu = 8,

            /// <summary>
            /// Enum Limited for value: Limited
            /// </summary>
            [EnumMember(Value = "Limited")]
            Limited = 9,

            /// <summary>
            /// Enum ApplicationExtension for value: ApplicationExtension
            /// </summary>
            [EnumMember(Value = "ApplicationExtension")]
            ApplicationExtension = 10,

            /// <summary>
            /// Enum Site for value: Site
            /// </summary>
            [EnumMember(Value = "Site")]
            Site = 11,

            /// <summary>
            /// Enum Bot for value: Bot
            /// </summary>
            [EnumMember(Value = "Bot")]
            Bot = 12,

            /// <summary>
            /// Enum ProxyAdmin for value: ProxyAdmin
            /// </summary>
            [EnumMember(Value = "ProxyAdmin")]
            ProxyAdmin = 13,

            /// <summary>
            /// Enum DelegatedLinesGroup for value: DelegatedLinesGroup
            /// </summary>
            [EnumMember(Value = "DelegatedLinesGroup")]
            DelegatedLinesGroup = 14,

            /// <summary>
            /// Enum GroupCallPickup for value: GroupCallPickup
            /// </summary>
            [EnumMember(Value = "GroupCallPickup")]
            GroupCallPickup = 15,

            /// <summary>
            /// Enum Room for value: Room
            /// </summary>
            [EnumMember(Value = "Room")]
            Room = 16

        }

        /// <summary>
        /// Type of extension to filter the contacts. Please note that legacy &#39;Department&#39; extension type corresponds to &#39;Call Queue&#39; extensions in modern RingCentral product terminology
        /// </summary>
        /// <value>Type of extension to filter the contacts. Please note that legacy &#39;Department&#39; extension type corresponds to &#39;Call Queue&#39; extensions in modern RingCentral product terminology</value>
        [DataMember(Name="extensionType", EmitDefaultValue=false)]
        public ExtensionTypeEnum? ExtensionType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchDirectoryEntriesRequest" /> class.
        /// </summary>
        /// <param name="searchString">String value to filter the contacts. The value specified is searched through the following fields: &#x60;firstName&#x60;, &#x60;lastName&#x60;, &#x60;extensionNumber&#x60;, &#x60;phoneNumber&#x60;, &#x60;email&#x60;, &#x60;jobTitle&#x60;, &#x60;department&#x60;.</param>
        /// <param name="searchFields">searchFields.</param>
        /// <param name="showFederated">If &#39;True&#39; then contacts of all accounts in federation are returned. If &#39;False&#39; then only contacts of the current account are returned, and account section is eliminated in this case (default to true).</param>
        /// <param name="extensionType">Type of extension to filter the contacts. Please note that legacy &#39;Department&#39; extension type corresponds to &#39;Call Queue&#39; extensions in modern RingCentral product terminology.</param>
        /// <param name="orderBy">Sorting settings.</param>
        /// <param name="page">page.</param>
        /// <param name="perPage">perPage.</param>
        public SearchDirectoryEntriesRequest(string searchString = default(string), List<SearchFieldsEnum> searchFields = default(List<SearchFieldsEnum>), bool showFederated = true, ExtensionTypeEnum? extensionType = default(ExtensionTypeEnum?), List<OrderBy> orderBy = default(List<OrderBy>), int page = default(int), int perPage = default(int))
        {
            this.SearchString = searchString;
            this.SearchFields = searchFields;
            // use default value if no "showFederated" provided
            if (showFederated == null)
            {
                this.ShowFederated = true;
            }
            else
            {
                this.ShowFederated = showFederated;
            }
            this.ExtensionType = extensionType;
            this.OrderBy = orderBy;
            this.Page = page;
            this.PerPage = perPage;
        }

        /// <summary>
        /// String value to filter the contacts. The value specified is searched through the following fields: &#x60;firstName&#x60;, &#x60;lastName&#x60;, &#x60;extensionNumber&#x60;, &#x60;phoneNumber&#x60;, &#x60;email&#x60;, &#x60;jobTitle&#x60;, &#x60;department&#x60;
        /// </summary>
        /// <value>String value to filter the contacts. The value specified is searched through the following fields: &#x60;firstName&#x60;, &#x60;lastName&#x60;, &#x60;extensionNumber&#x60;, &#x60;phoneNumber&#x60;, &#x60;email&#x60;, &#x60;jobTitle&#x60;, &#x60;department&#x60;</value>
        [DataMember(Name="searchString", EmitDefaultValue=false)]
        public string SearchString { get; set; }


        /// <summary>
        /// If &#39;True&#39; then contacts of all accounts in federation are returned. If &#39;False&#39; then only contacts of the current account are returned, and account section is eliminated in this case
        /// </summary>
        /// <value>If &#39;True&#39; then contacts of all accounts in federation are returned. If &#39;False&#39; then only contacts of the current account are returned, and account section is eliminated in this case</value>
        [DataMember(Name="showFederated", EmitDefaultValue=false)]
        public bool ShowFederated { get; set; }


        /// <summary>
        /// Sorting settings
        /// </summary>
        /// <value>Sorting settings</value>
        [DataMember(Name="orderBy", EmitDefaultValue=false)]
        public List<OrderBy> OrderBy { get; set; }

        /// <summary>
        /// Gets or Sets Page
        /// </summary>
        [DataMember(Name="page", EmitDefaultValue=false)]
        public int Page { get; set; }

        /// <summary>
        /// Gets or Sets PerPage
        /// </summary>
        [DataMember(Name="perPage", EmitDefaultValue=false)]
        public int PerPage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchDirectoryEntriesRequest {\n");
            sb.Append("  SearchString: ").Append(SearchString).Append("\n");
            sb.Append("  SearchFields: ").Append(SearchFields).Append("\n");
            sb.Append("  ShowFederated: ").Append(ShowFederated).Append("\n");
            sb.Append("  ExtensionType: ").Append(ExtensionType).Append("\n");
            sb.Append("  OrderBy: ").Append(OrderBy).Append("\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
            sb.Append("  PerPage: ").Append(PerPage).Append("\n");
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
            return this.Equals(input as SearchDirectoryEntriesRequest);
        }

        /// <summary>
        /// Returns true if SearchDirectoryEntriesRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SearchDirectoryEntriesRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchDirectoryEntriesRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SearchString == input.SearchString ||
                    (this.SearchString != null &&
                    this.SearchString.Equals(input.SearchString))
                ) && 
                (
                    this.SearchFields == input.SearchFields ||
                    this.SearchFields != null &&
                    input.SearchFields != null &&
                    this.SearchFields.SequenceEqual(input.SearchFields)
                ) && 
                (
                    this.ShowFederated == input.ShowFederated ||
                    (this.ShowFederated != null &&
                    this.ShowFederated.Equals(input.ShowFederated))
                ) && 
                (
                    this.ExtensionType == input.ExtensionType ||
                    (this.ExtensionType != null &&
                    this.ExtensionType.Equals(input.ExtensionType))
                ) && 
                (
                    this.OrderBy == input.OrderBy ||
                    this.OrderBy != null &&
                    input.OrderBy != null &&
                    this.OrderBy.SequenceEqual(input.OrderBy)
                ) && 
                (
                    this.Page == input.Page ||
                    (this.Page != null &&
                    this.Page.Equals(input.Page))
                ) && 
                (
                    this.PerPage == input.PerPage ||
                    (this.PerPage != null &&
                    this.PerPage.Equals(input.PerPage))
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
                if (this.SearchString != null)
                    hashCode = hashCode * 59 + this.SearchString.GetHashCode();
                if (this.SearchFields != null)
                    hashCode = hashCode * 59 + this.SearchFields.GetHashCode();
                if (this.ShowFederated != null)
                    hashCode = hashCode * 59 + this.ShowFederated.GetHashCode();
                if (this.ExtensionType != null)
                    hashCode = hashCode * 59 + this.ExtensionType.GetHashCode();
                if (this.OrderBy != null)
                    hashCode = hashCode * 59 + this.OrderBy.GetHashCode();
                if (this.Page != null)
                    hashCode = hashCode * 59 + this.Page.GetHashCode();
                if (this.PerPage != null)
                    hashCode = hashCode * 59 + this.PerPage.GetHashCode();
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
