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
    /// Contact Information
    /// </summary>
    [DataContract]
    public partial class ContactInfoCreationRequest :  IEquatable<ContactInfoCreationRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactInfoCreationRequest" /> class.
        /// </summary>
        /// <param name="firstName">For User extension type only. Extension user first name.</param>
        /// <param name="lastName">For User extension type only. Extension user last name.</param>
        /// <param name="company">Extension user company name.</param>
        /// <param name="jobTitle">jobTitle.</param>
        /// <param name="email">Email of extension user.</param>
        /// <param name="businessPhone">Extension user contact phone number in [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) format.</param>
        /// <param name="mobilePhone">Extension user mobile (**non** Toll Free) phone number in [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) (with &#39;+&#39; sign) format.</param>
        /// <param name="businessAddress">businessAddress.</param>
        /// <param name="emailAsLoginName"> If &#39;True&#39; then contact email is enabled as login name for this user. Please note that email should be unique in this case. The default value is &#39;False&#39;.</param>
        /// <param name="pronouncedName">pronouncedName.</param>
        /// <param name="department">Extension user department, if any.</param>
        public ContactInfoCreationRequest(string firstName = default(string), string lastName = default(string), string company = default(string), string jobTitle = default(string), string email = default(string), string businessPhone = default(string), string mobilePhone = default(string), ContactBusinessAddressInfo businessAddress = default(ContactBusinessAddressInfo), bool emailAsLoginName = default(bool), PronouncedNameInfo pronouncedName = default(PronouncedNameInfo), string department = default(string))
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Company = company;
            this.JobTitle = jobTitle;
            this.Email = email;
            this.BusinessPhone = businessPhone;
            this.MobilePhone = mobilePhone;
            this.BusinessAddress = businessAddress;
            this.EmailAsLoginName = emailAsLoginName;
            this.PronouncedName = pronouncedName;
            this.Department = department;
        }

        /// <summary>
        /// For User extension type only. Extension user first name
        /// </summary>
        /// <value>For User extension type only. Extension user first name</value>
        [DataMember(Name="firstName", EmitDefaultValue=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// For User extension type only. Extension user last name
        /// </summary>
        /// <value>For User extension type only. Extension user last name</value>
        [DataMember(Name="lastName", EmitDefaultValue=false)]
        public string LastName { get; set; }

        /// <summary>
        /// Extension user company name
        /// </summary>
        /// <value>Extension user company name</value>
        [DataMember(Name="company", EmitDefaultValue=false)]
        public string Company { get; set; }

        /// <summary>
        /// Gets or Sets JobTitle
        /// </summary>
        [DataMember(Name="jobTitle", EmitDefaultValue=false)]
        public string JobTitle { get; set; }

        /// <summary>
        /// Email of extension user
        /// </summary>
        /// <value>Email of extension user</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Extension user contact phone number in [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) format
        /// </summary>
        /// <value>Extension user contact phone number in [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) format</value>
        [DataMember(Name="businessPhone", EmitDefaultValue=false)]
        public string BusinessPhone { get; set; }

        /// <summary>
        /// Extension user mobile (**non** Toll Free) phone number in [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) (with &#39;+&#39; sign) format
        /// </summary>
        /// <value>Extension user mobile (**non** Toll Free) phone number in [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) (with &#39;+&#39; sign) format</value>
        [DataMember(Name="mobilePhone", EmitDefaultValue=false)]
        public string MobilePhone { get; set; }

        /// <summary>
        /// Gets or Sets BusinessAddress
        /// </summary>
        [DataMember(Name="businessAddress", EmitDefaultValue=false)]
        public ContactBusinessAddressInfo BusinessAddress { get; set; }

        /// <summary>
        ///  If &#39;True&#39; then contact email is enabled as login name for this user. Please note that email should be unique in this case. The default value is &#39;False&#39;
        /// </summary>
        /// <value> If &#39;True&#39; then contact email is enabled as login name for this user. Please note that email should be unique in this case. The default value is &#39;False&#39;</value>
        [DataMember(Name="emailAsLoginName", EmitDefaultValue=false)]
        public bool EmailAsLoginName { get; set; }

        /// <summary>
        /// Gets or Sets PronouncedName
        /// </summary>
        [DataMember(Name="pronouncedName", EmitDefaultValue=false)]
        public PronouncedNameInfo PronouncedName { get; set; }

        /// <summary>
        /// Extension user department, if any
        /// </summary>
        /// <value>Extension user department, if any</value>
        [DataMember(Name="department", EmitDefaultValue=false)]
        public string Department { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContactInfoCreationRequest {\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  JobTitle: ").Append(JobTitle).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  BusinessPhone: ").Append(BusinessPhone).Append("\n");
            sb.Append("  MobilePhone: ").Append(MobilePhone).Append("\n");
            sb.Append("  BusinessAddress: ").Append(BusinessAddress).Append("\n");
            sb.Append("  EmailAsLoginName: ").Append(EmailAsLoginName).Append("\n");
            sb.Append("  PronouncedName: ").Append(PronouncedName).Append("\n");
            sb.Append("  Department: ").Append(Department).Append("\n");
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
            return this.Equals(input as ContactInfoCreationRequest);
        }

        /// <summary>
        /// Returns true if ContactInfoCreationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ContactInfoCreationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactInfoCreationRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.Company == input.Company ||
                    (this.Company != null &&
                    this.Company.Equals(input.Company))
                ) && 
                (
                    this.JobTitle == input.JobTitle ||
                    (this.JobTitle != null &&
                    this.JobTitle.Equals(input.JobTitle))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.BusinessPhone == input.BusinessPhone ||
                    (this.BusinessPhone != null &&
                    this.BusinessPhone.Equals(input.BusinessPhone))
                ) && 
                (
                    this.MobilePhone == input.MobilePhone ||
                    (this.MobilePhone != null &&
                    this.MobilePhone.Equals(input.MobilePhone))
                ) && 
                (
                    this.BusinessAddress == input.BusinessAddress ||
                    (this.BusinessAddress != null &&
                    this.BusinessAddress.Equals(input.BusinessAddress))
                ) && 
                (
                    this.EmailAsLoginName == input.EmailAsLoginName ||
                    (this.EmailAsLoginName != null &&
                    this.EmailAsLoginName.Equals(input.EmailAsLoginName))
                ) && 
                (
                    this.PronouncedName == input.PronouncedName ||
                    (this.PronouncedName != null &&
                    this.PronouncedName.Equals(input.PronouncedName))
                ) && 
                (
                    this.Department == input.Department ||
                    (this.Department != null &&
                    this.Department.Equals(input.Department))
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
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.Company != null)
                    hashCode = hashCode * 59 + this.Company.GetHashCode();
                if (this.JobTitle != null)
                    hashCode = hashCode * 59 + this.JobTitle.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.BusinessPhone != null)
                    hashCode = hashCode * 59 + this.BusinessPhone.GetHashCode();
                if (this.MobilePhone != null)
                    hashCode = hashCode * 59 + this.MobilePhone.GetHashCode();
                if (this.BusinessAddress != null)
                    hashCode = hashCode * 59 + this.BusinessAddress.GetHashCode();
                if (this.EmailAsLoginName != null)
                    hashCode = hashCode * 59 + this.EmailAsLoginName.GetHashCode();
                if (this.PronouncedName != null)
                    hashCode = hashCode * 59 + this.PronouncedName.GetHashCode();
                if (this.Department != null)
                    hashCode = hashCode * 59 + this.Department.GetHashCode();
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