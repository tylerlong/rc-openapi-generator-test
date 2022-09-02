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
    /// TimelineResponse
    /// </summary>
    [DataContract]
    public partial class TimelineResponse :  IEquatable<TimelineResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TimelineResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TimelineResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TimelineResponse" /> class.
        /// </summary>
        /// <param name="paging">paging (required).</param>
        /// <param name="data">data (required).</param>
        public TimelineResponse(ResponsePaging paging = default(ResponsePaging), TimelineResponseData data = default(TimelineResponseData))
        {
            // to ensure "paging" is required (not null)
            if (paging == null)
            {
                throw new InvalidDataException("paging is a required property for TimelineResponse and cannot be null");
            }
            else
            {
                this.Paging = paging;
            }

            // to ensure "data" is required (not null)
            if (data == null)
            {
                throw new InvalidDataException("data is a required property for TimelineResponse and cannot be null");
            }
            else
            {
                this.Data = data;
            }

        }

        /// <summary>
        /// Gets or Sets Paging
        /// </summary>
        [DataMember(Name="paging", EmitDefaultValue=true)]
        public ResponsePaging Paging { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="data", EmitDefaultValue=true)]
        public TimelineResponseData Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TimelineResponse {\n");
            sb.Append("  Paging: ").Append(Paging).Append("\n");
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
            return this.Equals(input as TimelineResponse);
        }

        /// <summary>
        /// Returns true if TimelineResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of TimelineResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TimelineResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Paging == input.Paging ||
                    (this.Paging != null &&
                    this.Paging.Equals(input.Paging))
                ) && 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
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
                if (this.Paging != null)
                    hashCode = hashCode * 59 + this.Paging.GetHashCode();
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
