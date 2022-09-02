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
    /// AnalyticsLegacyPerformanceCallsTimelineResponse
    /// </summary>
    [DataContract]
    public partial class AnalyticsLegacyPerformanceCallsTimelineResponse :  IEquatable<AnalyticsLegacyPerformanceCallsTimelineResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsLegacyPerformanceCallsTimelineResponse" /> class.
        /// </summary>
        /// <param name="data">A list of time-value points of call aggregations as per the grouping and filtering options specified in the request.</param>
        public AnalyticsLegacyPerformanceCallsTimelineResponse(List<AnalyticsLegacyTimelineData> data = default(List<AnalyticsLegacyTimelineData>))
        {
            this.Data = data;
        }

        /// <summary>
        /// A list of time-value points of call aggregations as per the grouping and filtering options specified in the request
        /// </summary>
        /// <value>A list of time-value points of call aggregations as per the grouping and filtering options specified in the request</value>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public List<AnalyticsLegacyTimelineData> Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnalyticsLegacyPerformanceCallsTimelineResponse {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
            return this.Equals(input as AnalyticsLegacyPerformanceCallsTimelineResponse);
        }

        /// <summary>
        /// Returns true if AnalyticsLegacyPerformanceCallsTimelineResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of AnalyticsLegacyPerformanceCallsTimelineResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AnalyticsLegacyPerformanceCallsTimelineResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Data == input.Data ||
                    this.Data != null &&
                    input.Data != null &&
                    this.Data.SequenceEqual(input.Data)
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
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
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