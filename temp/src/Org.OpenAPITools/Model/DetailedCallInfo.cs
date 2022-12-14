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
    /// DetailedCallInfo
    /// </summary>
    [DataContract]
    public partial class DetailedCallInfo :  IEquatable<DetailedCallInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DetailedCallInfo" /> class.
        /// </summary>
        /// <param name="callId">callId.</param>
        /// <param name="toTag">toTag.</param>
        /// <param name="fromTag">fromTag.</param>
        /// <param name="remoteUri">remoteUri.</param>
        /// <param name="localUri">localUri.</param>
        /// <param name="rcSessionId">rcSessionId.</param>
        public DetailedCallInfo(string callId = default(string), string toTag = default(string), string fromTag = default(string), string remoteUri = default(string), string localUri = default(string), string rcSessionId = default(string))
        {
            this.CallId = callId;
            this.ToTag = toTag;
            this.FromTag = fromTag;
            this.RemoteUri = remoteUri;
            this.LocalUri = localUri;
            this.RcSessionId = rcSessionId;
        }

        /// <summary>
        /// Gets or Sets CallId
        /// </summary>
        [DataMember(Name="callId", EmitDefaultValue=false)]
        public string CallId { get; set; }

        /// <summary>
        /// Gets or Sets ToTag
        /// </summary>
        [DataMember(Name="toTag", EmitDefaultValue=false)]
        public string ToTag { get; set; }

        /// <summary>
        /// Gets or Sets FromTag
        /// </summary>
        [DataMember(Name="fromTag", EmitDefaultValue=false)]
        public string FromTag { get; set; }

        /// <summary>
        /// Gets or Sets RemoteUri
        /// </summary>
        [DataMember(Name="remoteUri", EmitDefaultValue=false)]
        public string RemoteUri { get; set; }

        /// <summary>
        /// Gets or Sets LocalUri
        /// </summary>
        [DataMember(Name="localUri", EmitDefaultValue=false)]
        public string LocalUri { get; set; }

        /// <summary>
        /// Gets or Sets RcSessionId
        /// </summary>
        [DataMember(Name="rcSessionId", EmitDefaultValue=false)]
        public string RcSessionId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DetailedCallInfo {\n");
            sb.Append("  CallId: ").Append(CallId).Append("\n");
            sb.Append("  ToTag: ").Append(ToTag).Append("\n");
            sb.Append("  FromTag: ").Append(FromTag).Append("\n");
            sb.Append("  RemoteUri: ").Append(RemoteUri).Append("\n");
            sb.Append("  LocalUri: ").Append(LocalUri).Append("\n");
            sb.Append("  RcSessionId: ").Append(RcSessionId).Append("\n");
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
            return this.Equals(input as DetailedCallInfo);
        }

        /// <summary>
        /// Returns true if DetailedCallInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of DetailedCallInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DetailedCallInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CallId == input.CallId ||
                    (this.CallId != null &&
                    this.CallId.Equals(input.CallId))
                ) && 
                (
                    this.ToTag == input.ToTag ||
                    (this.ToTag != null &&
                    this.ToTag.Equals(input.ToTag))
                ) && 
                (
                    this.FromTag == input.FromTag ||
                    (this.FromTag != null &&
                    this.FromTag.Equals(input.FromTag))
                ) && 
                (
                    this.RemoteUri == input.RemoteUri ||
                    (this.RemoteUri != null &&
                    this.RemoteUri.Equals(input.RemoteUri))
                ) && 
                (
                    this.LocalUri == input.LocalUri ||
                    (this.LocalUri != null &&
                    this.LocalUri.Equals(input.LocalUri))
                ) && 
                (
                    this.RcSessionId == input.RcSessionId ||
                    (this.RcSessionId != null &&
                    this.RcSessionId.Equals(input.RcSessionId))
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
                if (this.CallId != null)
                    hashCode = hashCode * 59 + this.CallId.GetHashCode();
                if (this.ToTag != null)
                    hashCode = hashCode * 59 + this.ToTag.GetHashCode();
                if (this.FromTag != null)
                    hashCode = hashCode * 59 + this.FromTag.GetHashCode();
                if (this.RemoteUri != null)
                    hashCode = hashCode * 59 + this.RemoteUri.GetHashCode();
                if (this.LocalUri != null)
                    hashCode = hashCode * 59 + this.LocalUri.GetHashCode();
                if (this.RcSessionId != null)
                    hashCode = hashCode * 59 + this.RcSessionId.GetHashCode();
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
