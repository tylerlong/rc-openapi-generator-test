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
    /// GlipNavigationInfo
    /// </summary>
    [DataContract]
    public partial class GlipNavigationInfo :  IEquatable<GlipNavigationInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlipNavigationInfo" /> class.
        /// </summary>
        /// <param name="prevPageToken">Previous page token. To get previous page, user should pass one of returned token in next request and, in turn, required page will be returned with new tokens.</param>
        /// <param name="nextPageToken">Next page token. To get next page, user should pass one of returned token in next request and, in turn, required page will be returned with new tokens.</param>
        public GlipNavigationInfo(string prevPageToken = default(string), string nextPageToken = default(string))
        {
            this.PrevPageToken = prevPageToken;
            this.NextPageToken = nextPageToken;
        }

        /// <summary>
        /// Previous page token. To get previous page, user should pass one of returned token in next request and, in turn, required page will be returned with new tokens
        /// </summary>
        /// <value>Previous page token. To get previous page, user should pass one of returned token in next request and, in turn, required page will be returned with new tokens</value>
        [DataMember(Name="prevPageToken", EmitDefaultValue=false)]
        public string PrevPageToken { get; set; }

        /// <summary>
        /// Next page token. To get next page, user should pass one of returned token in next request and, in turn, required page will be returned with new tokens
        /// </summary>
        /// <value>Next page token. To get next page, user should pass one of returned token in next request and, in turn, required page will be returned with new tokens</value>
        [DataMember(Name="nextPageToken", EmitDefaultValue=false)]
        public string NextPageToken { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GlipNavigationInfo {\n");
            sb.Append("  PrevPageToken: ").Append(PrevPageToken).Append("\n");
            sb.Append("  NextPageToken: ").Append(NextPageToken).Append("\n");
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
            return this.Equals(input as GlipNavigationInfo);
        }

        /// <summary>
        /// Returns true if GlipNavigationInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of GlipNavigationInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GlipNavigationInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PrevPageToken == input.PrevPageToken ||
                    (this.PrevPageToken != null &&
                    this.PrevPageToken.Equals(input.PrevPageToken))
                ) && 
                (
                    this.NextPageToken == input.NextPageToken ||
                    (this.NextPageToken != null &&
                    this.NextPageToken.Equals(input.NextPageToken))
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
                if (this.PrevPageToken != null)
                    hashCode = hashCode * 59 + this.PrevPageToken.GetHashCode();
                if (this.NextPageToken != null)
                    hashCode = hashCode * 59 + this.NextPageToken.GetHashCode();
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
