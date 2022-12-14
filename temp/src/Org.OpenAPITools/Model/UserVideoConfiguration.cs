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
    /// UserVideoConfiguration
    /// </summary>
    [DataContract]
    public partial class UserVideoConfiguration :  IEquatable<UserVideoConfiguration>, IValidatableObject
    {
        /// <summary>
        /// Video provider of the user
        /// </summary>
        /// <value>Video provider of the user</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ProviderEnum
        {
            /// <summary>
            /// Enum RCMeetings for value: RCMeetings
            /// </summary>
            [EnumMember(Value = "RCMeetings")]
            RCMeetings = 1,

            /// <summary>
            /// Enum RCVideo for value: RCVideo
            /// </summary>
            [EnumMember(Value = "RCVideo")]
            RCVideo = 2,

            /// <summary>
            /// Enum None for value: None
            /// </summary>
            [EnumMember(Value = "None")]
            None = 3

        }

        /// <summary>
        /// Video provider of the user
        /// </summary>
        /// <value>Video provider of the user</value>
        [DataMember(Name="provider", EmitDefaultValue=false)]
        public ProviderEnum? Provider { get; set; }
        /// <summary>
        /// Specifies if the user is &#39;paid&#39; (has meeting license) or &#39;free&#39; (w/o meeting license)
        /// </summary>
        /// <value>Specifies if the user is &#39;paid&#39; (has meeting license) or &#39;free&#39; (w/o meeting license)</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum UserLicenseTypeEnum
        {
            /// <summary>
            /// Enum Paid for value: Paid
            /// </summary>
            [EnumMember(Value = "Paid")]
            Paid = 1,

            /// <summary>
            /// Enum Free for value: Free
            /// </summary>
            [EnumMember(Value = "Free")]
            Free = 2

        }

        /// <summary>
        /// Specifies if the user is &#39;paid&#39; (has meeting license) or &#39;free&#39; (w/o meeting license)
        /// </summary>
        /// <value>Specifies if the user is &#39;paid&#39; (has meeting license) or &#39;free&#39; (w/o meeting license)</value>
        [DataMember(Name="userLicenseType", EmitDefaultValue=false)]
        public UserLicenseTypeEnum? UserLicenseType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserVideoConfiguration" /> class.
        /// </summary>
        /// <param name="provider">Video provider of the user.</param>
        /// <param name="userLicenseType">Specifies if the user is &#39;paid&#39; (has meeting license) or &#39;free&#39; (w/o meeting license).</param>
        public UserVideoConfiguration(ProviderEnum? provider = default(ProviderEnum?), UserLicenseTypeEnum? userLicenseType = default(UserLicenseTypeEnum?))
        {
            this.Provider = provider;
            this.UserLicenseType = userLicenseType;
        }



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserVideoConfiguration {\n");
            sb.Append("  Provider: ").Append(Provider).Append("\n");
            sb.Append("  UserLicenseType: ").Append(UserLicenseType).Append("\n");
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
            return this.Equals(input as UserVideoConfiguration);
        }

        /// <summary>
        /// Returns true if UserVideoConfiguration instances are equal
        /// </summary>
        /// <param name="input">Instance of UserVideoConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserVideoConfiguration input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Provider == input.Provider ||
                    (this.Provider != null &&
                    this.Provider.Equals(input.Provider))
                ) && 
                (
                    this.UserLicenseType == input.UserLicenseType ||
                    (this.UserLicenseType != null &&
                    this.UserLicenseType.Equals(input.UserLicenseType))
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
                if (this.Provider != null)
                    hashCode = hashCode * 59 + this.Provider.GetHashCode();
                if (this.UserLicenseType != null)
                    hashCode = hashCode * 59 + this.UserLicenseType.GetHashCode();
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
