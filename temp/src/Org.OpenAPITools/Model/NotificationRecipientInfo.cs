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
    /// NotificationRecipientInfo
    /// </summary>
    [DataContract]
    public partial class NotificationRecipientInfo :  IEquatable<NotificationRecipientInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationRecipientInfo" /> class.
        /// </summary>
        /// <param name="phoneNumber">Phone number in E.164 (with &#39;+&#39; sign) format.</param>
        /// <param name="extensionNumber">Extension number.</param>
        /// <param name="target">&#39;True&#39; specifies that message is sent exactly to this recipient. Returned in to field for group MMS. Useful if one extension has several phone numbers.</param>
        /// <param name="location">Contains party location (city, state) if one can be determined from phoneNumber. This property is filled only when phoneNumber is not empty and server can calculate location information from it (for example, this information is unavailable for US toll-free numbers).</param>
        /// <param name="name">Symbolic name associated with a caller/callee. If the phone does not belong to the known extension, only the location is returned, the name is not determined then.</param>
        public NotificationRecipientInfo(string phoneNumber = default(string), string extensionNumber = default(string), bool target = default(bool), string location = default(string), string name = default(string))
        {
            this.PhoneNumber = phoneNumber;
            this.ExtensionNumber = extensionNumber;
            this.Target = target;
            this.Location = location;
            this.Name = name;
        }

        /// <summary>
        /// Phone number in E.164 (with &#39;+&#39; sign) format
        /// </summary>
        /// <value>Phone number in E.164 (with &#39;+&#39; sign) format</value>
        [DataMember(Name="phoneNumber", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Extension number
        /// </summary>
        /// <value>Extension number</value>
        [DataMember(Name="extensionNumber", EmitDefaultValue=false)]
        public string ExtensionNumber { get; set; }

        /// <summary>
        /// &#39;True&#39; specifies that message is sent exactly to this recipient. Returned in to field for group MMS. Useful if one extension has several phone numbers
        /// </summary>
        /// <value>&#39;True&#39; specifies that message is sent exactly to this recipient. Returned in to field for group MMS. Useful if one extension has several phone numbers</value>
        [DataMember(Name="target", EmitDefaultValue=false)]
        public bool Target { get; set; }

        /// <summary>
        /// Contains party location (city, state) if one can be determined from phoneNumber. This property is filled only when phoneNumber is not empty and server can calculate location information from it (for example, this information is unavailable for US toll-free numbers)
        /// </summary>
        /// <value>Contains party location (city, state) if one can be determined from phoneNumber. This property is filled only when phoneNumber is not empty and server can calculate location information from it (for example, this information is unavailable for US toll-free numbers)</value>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public string Location { get; set; }

        /// <summary>
        /// Symbolic name associated with a caller/callee. If the phone does not belong to the known extension, only the location is returned, the name is not determined then
        /// </summary>
        /// <value>Symbolic name associated with a caller/callee. If the phone does not belong to the known extension, only the location is returned, the name is not determined then</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NotificationRecipientInfo {\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  ExtensionNumber: ").Append(ExtensionNumber).Append("\n");
            sb.Append("  Target: ").Append(Target).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as NotificationRecipientInfo);
        }

        /// <summary>
        /// Returns true if NotificationRecipientInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of NotificationRecipientInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NotificationRecipientInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PhoneNumber == input.PhoneNumber ||
                    (this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(input.PhoneNumber))
                ) && 
                (
                    this.ExtensionNumber == input.ExtensionNumber ||
                    (this.ExtensionNumber != null &&
                    this.ExtensionNumber.Equals(input.ExtensionNumber))
                ) && 
                (
                    this.Target == input.Target ||
                    (this.Target != null &&
                    this.Target.Equals(input.Target))
                ) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.PhoneNumber != null)
                    hashCode = hashCode * 59 + this.PhoneNumber.GetHashCode();
                if (this.ExtensionNumber != null)
                    hashCode = hashCode * 59 + this.ExtensionNumber.GetHashCode();
                if (this.Target != null)
                    hashCode = hashCode * 59 + this.Target.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
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
