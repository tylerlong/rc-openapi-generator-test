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
    /// Caller ID settings by device
    /// </summary>
    [DataContract]
    public partial class CallerIdByDevice :  IEquatable<CallerIdByDevice>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CallerIdByDevice" /> class.
        /// </summary>
        /// <param name="device">device.</param>
        /// <param name="callerId">callerId.</param>
        public CallerIdByDevice(CallerIdDeviceInfo device = default(CallerIdDeviceInfo), CallerIdByDeviceInfo callerId = default(CallerIdByDeviceInfo))
        {
            this.Device = device;
            this.CallerId = callerId;
        }

        /// <summary>
        /// Gets or Sets Device
        /// </summary>
        [DataMember(Name="device", EmitDefaultValue=false)]
        public CallerIdDeviceInfo Device { get; set; }

        /// <summary>
        /// Gets or Sets CallerId
        /// </summary>
        [DataMember(Name="callerId", EmitDefaultValue=false)]
        public CallerIdByDeviceInfo CallerId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CallerIdByDevice {\n");
            sb.Append("  Device: ").Append(Device).Append("\n");
            sb.Append("  CallerId: ").Append(CallerId).Append("\n");
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
            return this.Equals(input as CallerIdByDevice);
        }

        /// <summary>
        /// Returns true if CallerIdByDevice instances are equal
        /// </summary>
        /// <param name="input">Instance of CallerIdByDevice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CallerIdByDevice input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Device == input.Device ||
                    (this.Device != null &&
                    this.Device.Equals(input.Device))
                ) && 
                (
                    this.CallerId == input.CallerId ||
                    (this.CallerId != null &&
                    this.CallerId.Equals(input.CallerId))
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
                if (this.Device != null)
                    hashCode = hashCode * 59 + this.Device.GetHashCode();
                if (this.CallerId != null)
                    hashCode = hashCode * 59 + this.CallerId.GetHashCode();
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
