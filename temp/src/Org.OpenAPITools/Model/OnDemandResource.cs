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
    /// OnDemandResource
    /// </summary>
    [DataContract]
    public partial class OnDemandResource :  IEquatable<OnDemandResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OnDemandResource" /> class.
        /// </summary>
        /// <param name="enabled">Flag for controlling OnDemand Call Recording settings.</param>
        /// <param name="retentionPeriod">Retention period of a call recording, the default value is 90 days.</param>
        public OnDemandResource(bool enabled = default(bool), int retentionPeriod = default(int))
        {
            this.Enabled = enabled;
            this.RetentionPeriod = retentionPeriod;
        }

        /// <summary>
        /// Flag for controlling OnDemand Call Recording settings
        /// </summary>
        /// <value>Flag for controlling OnDemand Call Recording settings</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Retention period of a call recording, the default value is 90 days
        /// </summary>
        /// <value>Retention period of a call recording, the default value is 90 days</value>
        [DataMember(Name="retentionPeriod", EmitDefaultValue=false)]
        public int RetentionPeriod { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OnDemandResource {\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  RetentionPeriod: ").Append(RetentionPeriod).Append("\n");
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
            return this.Equals(input as OnDemandResource);
        }

        /// <summary>
        /// Returns true if OnDemandResource instances are equal
        /// </summary>
        /// <param name="input">Instance of OnDemandResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OnDemandResource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
                ) && 
                (
                    this.RetentionPeriod == input.RetentionPeriod ||
                    (this.RetentionPeriod != null &&
                    this.RetentionPeriod.Equals(input.RetentionPeriod))
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
                if (this.Enabled != null)
                    hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.RetentionPeriod != null)
                    hashCode = hashCode * 59 + this.RetentionPeriod.GetHashCode();
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
