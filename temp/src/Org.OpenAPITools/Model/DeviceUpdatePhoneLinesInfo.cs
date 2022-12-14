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
    /// Information on phone lines added to a device
    /// </summary>
    [DataContract]
    public partial class DeviceUpdatePhoneLinesInfo :  IEquatable<DeviceUpdatePhoneLinesInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceUpdatePhoneLinesInfo" /> class.
        /// </summary>
        /// <param name="phoneLines">Information on phone lines added to a device.</param>
        public DeviceUpdatePhoneLinesInfo(List<UpdateDevicePhoneInfo> phoneLines = default(List<UpdateDevicePhoneInfo>))
        {
            this.PhoneLines = phoneLines;
        }

        /// <summary>
        /// Information on phone lines added to a device
        /// </summary>
        /// <value>Information on phone lines added to a device</value>
        [DataMember(Name="phoneLines", EmitDefaultValue=false)]
        public List<UpdateDevicePhoneInfo> PhoneLines { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeviceUpdatePhoneLinesInfo {\n");
            sb.Append("  PhoneLines: ").Append(PhoneLines).Append("\n");
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
            return this.Equals(input as DeviceUpdatePhoneLinesInfo);
        }

        /// <summary>
        /// Returns true if DeviceUpdatePhoneLinesInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of DeviceUpdatePhoneLinesInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeviceUpdatePhoneLinesInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PhoneLines == input.PhoneLines ||
                    this.PhoneLines != null &&
                    input.PhoneLines != null &&
                    this.PhoneLines.SequenceEqual(input.PhoneLines)
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
                if (this.PhoneLines != null)
                    hashCode = hashCode * 59 + this.PhoneLines.GetHashCode();
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
