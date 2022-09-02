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
    /// Conditional aggregation of calls based on the overall call length
    /// </summary>
    [DataContract]
    public partial class AnalyticsLegacyPerformanceCallsFilterByLength :  IEquatable<AnalyticsLegacyPerformanceCallsFilterByLength>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsLegacyPerformanceCallsFilterByLength" /> class.
        /// </summary>
        /// <param name="minValueSeconds">minValueSeconds.</param>
        /// <param name="maxValueSeconds">maxValueSeconds.</param>
        public AnalyticsLegacyPerformanceCallsFilterByLength(long minValueSeconds = default(long), long maxValueSeconds = default(long))
        {
            this.MinValueSeconds = minValueSeconds;
            this.MaxValueSeconds = maxValueSeconds;
        }

        /// <summary>
        /// Gets or Sets MinValueSeconds
        /// </summary>
        [DataMember(Name="minValueSeconds", EmitDefaultValue=false)]
        public long MinValueSeconds { get; set; }

        /// <summary>
        /// Gets or Sets MaxValueSeconds
        /// </summary>
        [DataMember(Name="maxValueSeconds", EmitDefaultValue=false)]
        public long MaxValueSeconds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnalyticsLegacyPerformanceCallsFilterByLength {\n");
            sb.Append("  MinValueSeconds: ").Append(MinValueSeconds).Append("\n");
            sb.Append("  MaxValueSeconds: ").Append(MaxValueSeconds).Append("\n");
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
            return this.Equals(input as AnalyticsLegacyPerformanceCallsFilterByLength);
        }

        /// <summary>
        /// Returns true if AnalyticsLegacyPerformanceCallsFilterByLength instances are equal
        /// </summary>
        /// <param name="input">Instance of AnalyticsLegacyPerformanceCallsFilterByLength to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AnalyticsLegacyPerformanceCallsFilterByLength input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MinValueSeconds == input.MinValueSeconds ||
                    (this.MinValueSeconds != null &&
                    this.MinValueSeconds.Equals(input.MinValueSeconds))
                ) && 
                (
                    this.MaxValueSeconds == input.MaxValueSeconds ||
                    (this.MaxValueSeconds != null &&
                    this.MaxValueSeconds.Equals(input.MaxValueSeconds))
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
                if (this.MinValueSeconds != null)
                    hashCode = hashCode * 59 + this.MinValueSeconds.GetHashCode();
                if (this.MaxValueSeconds != null)
                    hashCode = hashCode * 59 + this.MaxValueSeconds.GetHashCode();
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