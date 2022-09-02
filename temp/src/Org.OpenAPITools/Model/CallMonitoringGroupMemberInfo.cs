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
    /// CallMonitoringGroupMemberInfo
    /// </summary>
    [DataContract]
    public partial class CallMonitoringGroupMemberInfo :  IEquatable<CallMonitoringGroupMemberInfo>, IValidatableObject
    {
        /// <summary>
        /// Call monitoring permission; multiple values are allowed: * &#x60;Monitoring&#x60; - User can monitor a group * &#x60;Monitored&#x60; - User can be monitored
        /// </summary>
        /// <value>Call monitoring permission; multiple values are allowed: * &#x60;Monitoring&#x60; - User can monitor a group * &#x60;Monitored&#x60; - User can be monitored</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PermissionsEnum
        {
            /// <summary>
            /// Enum Monitoring for value: Monitoring
            /// </summary>
            [EnumMember(Value = "Monitoring")]
            Monitoring = 1,

            /// <summary>
            /// Enum Monitored for value: Monitored
            /// </summary>
            [EnumMember(Value = "Monitored")]
            Monitored = 2

        }


        /// <summary>
        /// Gets or Sets Permissions
        /// </summary>
        [DataMember(Name="permissions", EmitDefaultValue=false)]
        public List<PermissionsEnum> Permissions { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CallMonitoringGroupMemberInfo" /> class.
        /// </summary>
        /// <param name="uri">Link to a call monitoring group member.</param>
        /// <param name="id">Internal identifier of a call monitoring group member.</param>
        /// <param name="extensionNumber">Extension number of a call monitoring group member.</param>
        /// <param name="permissions">permissions.</param>
        public CallMonitoringGroupMemberInfo(string uri = default(string), string id = default(string), string extensionNumber = default(string), List<PermissionsEnum> permissions = default(List<PermissionsEnum>))
        {
            this.Uri = uri;
            this.Id = id;
            this.ExtensionNumber = extensionNumber;
            this.Permissions = permissions;
        }

        /// <summary>
        /// Link to a call monitoring group member
        /// </summary>
        /// <value>Link to a call monitoring group member</value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }

        /// <summary>
        /// Internal identifier of a call monitoring group member
        /// </summary>
        /// <value>Internal identifier of a call monitoring group member</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Extension number of a call monitoring group member
        /// </summary>
        /// <value>Extension number of a call monitoring group member</value>
        [DataMember(Name="extensionNumber", EmitDefaultValue=false)]
        public string ExtensionNumber { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CallMonitoringGroupMemberInfo {\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ExtensionNumber: ").Append(ExtensionNumber).Append("\n");
            sb.Append("  Permissions: ").Append(Permissions).Append("\n");
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
            return this.Equals(input as CallMonitoringGroupMemberInfo);
        }

        /// <summary>
        /// Returns true if CallMonitoringGroupMemberInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of CallMonitoringGroupMemberInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CallMonitoringGroupMemberInfo input)
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
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.ExtensionNumber == input.ExtensionNumber ||
                    (this.ExtensionNumber != null &&
                    this.ExtensionNumber.Equals(input.ExtensionNumber))
                ) && 
                (
                    this.Permissions == input.Permissions ||
                    this.Permissions != null &&
                    input.Permissions != null &&
                    this.Permissions.SequenceEqual(input.Permissions)
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ExtensionNumber != null)
                    hashCode = hashCode * 59 + this.ExtensionNumber.GetHashCode();
                if (this.Permissions != null)
                    hashCode = hashCode * 59 + this.Permissions.GetHashCode();
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