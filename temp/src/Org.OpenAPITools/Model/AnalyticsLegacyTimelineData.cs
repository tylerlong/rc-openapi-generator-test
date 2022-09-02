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
    /// AnalyticsLegacyTimelineData
    /// </summary>
    [DataContract]
    public partial class AnalyticsLegacyTimelineData :  IEquatable<AnalyticsLegacyTimelineData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsLegacyTimelineData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AnalyticsLegacyTimelineData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsLegacyTimelineData" /> class.
        /// </summary>
        /// <param name="key">key (required).</param>
        /// <param name="keyInfo">keyInfo.</param>
        /// <param name="points">points.</param>
        public AnalyticsLegacyTimelineData(string key = default(string), AnalyticsLegacyKeyInfo keyInfo = default(AnalyticsLegacyKeyInfo), List<AnalyticsLegacyTimelineDataPoint> points = default(List<AnalyticsLegacyTimelineDataPoint>))
        {
            // to ensure "key" is required (not null)
            if (key == null)
            {
                throw new InvalidDataException("key is a required property for AnalyticsLegacyTimelineData and cannot be null");
            }
            else
            {
                this.Key = key;
            }

            this.KeyInfo = keyInfo;
            this.Points = points;
        }

        /// <summary>
        /// Gets or Sets Key
        /// </summary>
        [DataMember(Name="key", EmitDefaultValue=true)]
        public string Key { get; set; }

        /// <summary>
        /// Gets or Sets KeyInfo
        /// </summary>
        [DataMember(Name="keyInfo", EmitDefaultValue=false)]
        public AnalyticsLegacyKeyInfo KeyInfo { get; set; }

        /// <summary>
        /// Gets or Sets Points
        /// </summary>
        [DataMember(Name="points", EmitDefaultValue=false)]
        public List<AnalyticsLegacyTimelineDataPoint> Points { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnalyticsLegacyTimelineData {\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  KeyInfo: ").Append(KeyInfo).Append("\n");
            sb.Append("  Points: ").Append(Points).Append("\n");
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
            return this.Equals(input as AnalyticsLegacyTimelineData);
        }

        /// <summary>
        /// Returns true if AnalyticsLegacyTimelineData instances are equal
        /// </summary>
        /// <param name="input">Instance of AnalyticsLegacyTimelineData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AnalyticsLegacyTimelineData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.KeyInfo == input.KeyInfo ||
                    (this.KeyInfo != null &&
                    this.KeyInfo.Equals(input.KeyInfo))
                ) && 
                (
                    this.Points == input.Points ||
                    this.Points != null &&
                    input.Points != null &&
                    this.Points.SequenceEqual(input.Points)
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
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.KeyInfo != null)
                    hashCode = hashCode * 59 + this.KeyInfo.GetHashCode();
                if (this.Points != null)
                    hashCode = hashCode * 59 + this.Points.GetHashCode();
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