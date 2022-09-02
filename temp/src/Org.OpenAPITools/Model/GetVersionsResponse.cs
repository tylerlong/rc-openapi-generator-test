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
    /// GetVersionsResponse
    /// </summary>
    [DataContract]
    public partial class GetVersionsResponse :  IEquatable<GetVersionsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetVersionsResponse" /> class.
        /// </summary>
        /// <param name="uri">Canonical URI of the API version.</param>
        /// <param name="apiVersions">Full API version information: uri, number, release date.</param>
        /// <param name="serverVersion">Server version.</param>
        /// <param name="serverRevision">Server revision.</param>
        public GetVersionsResponse(string uri = default(string), List<VersionInfo> apiVersions = default(List<VersionInfo>), string serverVersion = default(string), string serverRevision = default(string))
        {
            this.Uri = uri;
            this.ApiVersions = apiVersions;
            this.ServerVersion = serverVersion;
            this.ServerRevision = serverRevision;
        }

        /// <summary>
        /// Canonical URI of the API version
        /// </summary>
        /// <value>Canonical URI of the API version</value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }

        /// <summary>
        /// Full API version information: uri, number, release date
        /// </summary>
        /// <value>Full API version information: uri, number, release date</value>
        [DataMember(Name="apiVersions", EmitDefaultValue=false)]
        public List<VersionInfo> ApiVersions { get; set; }

        /// <summary>
        /// Server version
        /// </summary>
        /// <value>Server version</value>
        [DataMember(Name="serverVersion", EmitDefaultValue=false)]
        public string ServerVersion { get; set; }

        /// <summary>
        /// Server revision
        /// </summary>
        /// <value>Server revision</value>
        [DataMember(Name="serverRevision", EmitDefaultValue=false)]
        public string ServerRevision { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetVersionsResponse {\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  ApiVersions: ").Append(ApiVersions).Append("\n");
            sb.Append("  ServerVersion: ").Append(ServerVersion).Append("\n");
            sb.Append("  ServerRevision: ").Append(ServerRevision).Append("\n");
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
            return this.Equals(input as GetVersionsResponse);
        }

        /// <summary>
        /// Returns true if GetVersionsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetVersionsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetVersionsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Uri == input.Uri ||
                    (this.Uri != null &&
                    this.Uri.Equals(input.Uri))
                ) && 
                (
                    this.ApiVersions == input.ApiVersions ||
                    this.ApiVersions != null &&
                    input.ApiVersions != null &&
                    this.ApiVersions.SequenceEqual(input.ApiVersions)
                ) && 
                (
                    this.ServerVersion == input.ServerVersion ||
                    (this.ServerVersion != null &&
                    this.ServerVersion.Equals(input.ServerVersion))
                ) && 
                (
                    this.ServerRevision == input.ServerRevision ||
                    (this.ServerRevision != null &&
                    this.ServerRevision.Equals(input.ServerRevision))
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
                if (this.Uri != null)
                    hashCode = hashCode * 59 + this.Uri.GetHashCode();
                if (this.ApiVersions != null)
                    hashCode = hashCode * 59 + this.ApiVersions.GetHashCode();
                if (this.ServerVersion != null)
                    hashCode = hashCode * 59 + this.ServerVersion.GetHashCode();
                if (this.ServerRevision != null)
                    hashCode = hashCode * 59 + this.ServerRevision.GetHashCode();
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