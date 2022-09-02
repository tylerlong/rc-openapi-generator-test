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
    /// FilterSupported
    /// </summary>
    [DataContract]
    public partial class FilterSupported :  IEquatable<FilterSupported>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FilterSupported" /> class.
        /// </summary>
        /// <param name="maxResults">maxResults.</param>
        /// <param name="supported">supported (default to false).</param>
        public FilterSupported(int maxResults = default(int), bool supported = false)
        {
            this.MaxResults = maxResults;
            // use default value if no "supported" provided
            if (supported == null)
            {
                this.Supported = false;
            }
            else
            {
                this.Supported = supported;
            }
        }

        /// <summary>
        /// Gets or Sets MaxResults
        /// </summary>
        [DataMember(Name="maxResults", EmitDefaultValue=false)]
        public int MaxResults { get; set; }

        /// <summary>
        /// Gets or Sets Supported
        /// </summary>
        [DataMember(Name="supported", EmitDefaultValue=false)]
        public bool Supported { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FilterSupported {\n");
            sb.Append("  MaxResults: ").Append(MaxResults).Append("\n");
            sb.Append("  Supported: ").Append(Supported).Append("\n");
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
            return this.Equals(input as FilterSupported);
        }

        /// <summary>
        /// Returns true if FilterSupported instances are equal
        /// </summary>
        /// <param name="input">Instance of FilterSupported to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FilterSupported input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MaxResults == input.MaxResults ||
                    (this.MaxResults != null &&
                    this.MaxResults.Equals(input.MaxResults))
                ) && 
                (
                    this.Supported == input.Supported ||
                    (this.Supported != null &&
                    this.Supported.Equals(input.Supported))
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
                if (this.MaxResults != null)
                    hashCode = hashCode * 59 + this.MaxResults.GetHashCode();
                if (this.Supported != null)
                    hashCode = hashCode * 59 + this.Supported.GetHashCode();
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
