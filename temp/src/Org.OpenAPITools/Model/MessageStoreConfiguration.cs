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
    /// MessageStoreConfiguration
    /// </summary>
    [DataContract]
    public partial class MessageStoreConfiguration :  IEquatable<MessageStoreConfiguration>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageStoreConfiguration" /> class.
        /// </summary>
        /// <param name="retentionPeriod">Retention policy setting, specifying how long to keep messages; the supported value range is 7-90 days.</param>
        public MessageStoreConfiguration(int retentionPeriod = default(int))
        {
            this.RetentionPeriod = retentionPeriod;
        }

        /// <summary>
        /// Retention policy setting, specifying how long to keep messages; the supported value range is 7-90 days
        /// </summary>
        /// <value>Retention policy setting, specifying how long to keep messages; the supported value range is 7-90 days</value>
        [DataMember(Name="retentionPeriod", EmitDefaultValue=false)]
        public int RetentionPeriod { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessageStoreConfiguration {\n");
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
            return this.Equals(input as MessageStoreConfiguration);
        }

        /// <summary>
        /// Returns true if MessageStoreConfiguration instances are equal
        /// </summary>
        /// <param name="input">Instance of MessageStoreConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessageStoreConfiguration input)
        {
            if (input == null)
                return false;

            return 
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


            // RetentionPeriod (int) maximum
            if(this.RetentionPeriod > (int)90)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RetentionPeriod, must be a value less than or equal to 90.", new [] { "RetentionPeriod" });
            }

            // RetentionPeriod (int) minimum
            if(this.RetentionPeriod < (int)7)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RetentionPeriod, must be a value greater than or equal to 7.", new [] { "RetentionPeriod" });
            }

            yield break;
        }
    }

}
