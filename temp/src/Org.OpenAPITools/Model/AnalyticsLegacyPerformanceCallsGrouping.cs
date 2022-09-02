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
    /// This field specifies the dimensions by which the response should be grouped and specific IDs to narrow the response. If this field is undefined or null, the response will contain one record with data aggregated by the whole company
    /// </summary>
    [DataContract]
    public partial class AnalyticsLegacyPerformanceCallsGrouping :  IEquatable<AnalyticsLegacyPerformanceCallsGrouping>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets GroupBy
        /// </summary>
        [DataMember(Name="groupBy", EmitDefaultValue=true)]
        public AnalyticsLegacyGroupingOptions GroupBy { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsLegacyPerformanceCallsGrouping" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AnalyticsLegacyPerformanceCallsGrouping() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsLegacyPerformanceCallsGrouping" /> class.
        /// </summary>
        /// <param name="groupBy">groupBy (required).</param>
        /// <param name="ids">This field can be used to specify unique identifiers of groups in GroupBy types.</param>
        public AnalyticsLegacyPerformanceCallsGrouping(AnalyticsLegacyGroupingOptions groupBy = default(AnalyticsLegacyGroupingOptions), List<string> ids = default(List<string>))
        {
            // to ensure "groupBy" is required (not null)
            if (groupBy == null)
            {
                throw new InvalidDataException("groupBy is a required property for AnalyticsLegacyPerformanceCallsGrouping and cannot be null");
            }
            else
            {
                this.GroupBy = groupBy;
            }

            this.Ids = ids;
        }


        /// <summary>
        /// This field can be used to specify unique identifiers of groups in GroupBy types
        /// </summary>
        /// <value>This field can be used to specify unique identifiers of groups in GroupBy types</value>
        [DataMember(Name="ids", EmitDefaultValue=false)]
        public List<string> Ids { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnalyticsLegacyPerformanceCallsGrouping {\n");
            sb.Append("  GroupBy: ").Append(GroupBy).Append("\n");
            sb.Append("  Ids: ").Append(Ids).Append("\n");
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
            return this.Equals(input as AnalyticsLegacyPerformanceCallsGrouping);
        }

        /// <summary>
        /// Returns true if AnalyticsLegacyPerformanceCallsGrouping instances are equal
        /// </summary>
        /// <param name="input">Instance of AnalyticsLegacyPerformanceCallsGrouping to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AnalyticsLegacyPerformanceCallsGrouping input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GroupBy == input.GroupBy ||
                    (this.GroupBy != null &&
                    this.GroupBy.Equals(input.GroupBy))
                ) && 
                (
                    this.Ids == input.Ids ||
                    this.Ids != null &&
                    input.Ids != null &&
                    this.Ids.SequenceEqual(input.Ids)
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
                if (this.GroupBy != null)
                    hashCode = hashCode * 59 + this.GroupBy.GetHashCode();
                if (this.Ids != null)
                    hashCode = hashCode * 59 + this.Ids.GetHashCode();
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