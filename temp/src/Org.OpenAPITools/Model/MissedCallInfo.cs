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
    /// Specifies behavior for the missed call scenario. Returned only if &#x60;enabled&#x60; parameter of a voicemail is set to &#39;false&#39;
    /// </summary>
    [DataContract]
    public partial class MissedCallInfo :  IEquatable<MissedCallInfo>, IValidatableObject
    {
        /// <summary>
        /// Specifies the action that should be executed on a missed call. It can either be playing greeting message and disconnection, or sending call to a calling group. If &#39;ConnectToExtension&#39; is set, then calling group extension should be specified
        /// </summary>
        /// <value>Specifies the action that should be executed on a missed call. It can either be playing greeting message and disconnection, or sending call to a calling group. If &#39;ConnectToExtension&#39; is set, then calling group extension should be specified</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActionTypeEnum
        {
            /// <summary>
            /// Enum PlayGreetingAndDisconnect for value: PlayGreetingAndDisconnect
            /// </summary>
            [EnumMember(Value = "PlayGreetingAndDisconnect")]
            PlayGreetingAndDisconnect = 1,

            /// <summary>
            /// Enum ConnectToExtension for value: ConnectToExtension
            /// </summary>
            [EnumMember(Value = "ConnectToExtension")]
            ConnectToExtension = 2,

            /// <summary>
            /// Enum ConnectToExternalNumber for value: ConnectToExternalNumber
            /// </summary>
            [EnumMember(Value = "ConnectToExternalNumber")]
            ConnectToExternalNumber = 3

        }

        /// <summary>
        /// Specifies the action that should be executed on a missed call. It can either be playing greeting message and disconnection, or sending call to a calling group. If &#39;ConnectToExtension&#39; is set, then calling group extension should be specified
        /// </summary>
        /// <value>Specifies the action that should be executed on a missed call. It can either be playing greeting message and disconnection, or sending call to a calling group. If &#39;ConnectToExtension&#39; is set, then calling group extension should be specified</value>
        [DataMember(Name="actionType", EmitDefaultValue=false)]
        public ActionTypeEnum? ActionType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MissedCallInfo" /> class.
        /// </summary>
        /// <param name="actionType">Specifies the action that should be executed on a missed call. It can either be playing greeting message and disconnection, or sending call to a calling group. If &#39;ConnectToExtension&#39; is set, then calling group extension should be specified.</param>
        /// <param name="extension">extension.</param>
        public MissedCallInfo(ActionTypeEnum? actionType = default(ActionTypeEnum?), MissedCallExtensionInfo extension = default(MissedCallExtensionInfo))
        {
            this.ActionType = actionType;
            this.Extension = extension;
        }


        /// <summary>
        /// Gets or Sets Extension
        /// </summary>
        [DataMember(Name="extension", EmitDefaultValue=false)]
        public MissedCallExtensionInfo Extension { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MissedCallInfo {\n");
            sb.Append("  ActionType: ").Append(ActionType).Append("\n");
            sb.Append("  Extension: ").Append(Extension).Append("\n");
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
            return this.Equals(input as MissedCallInfo);
        }

        /// <summary>
        /// Returns true if MissedCallInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of MissedCallInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MissedCallInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ActionType == input.ActionType ||
                    (this.ActionType != null &&
                    this.ActionType.Equals(input.ActionType))
                ) && 
                (
                    this.Extension == input.Extension ||
                    (this.Extension != null &&
                    this.Extension.Equals(input.Extension))
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
                if (this.ActionType != null)
                    hashCode = hashCode * 59 + this.ActionType.GetHashCode();
                if (this.Extension != null)
                    hashCode = hashCode * 59 + this.Extension.GetHashCode();
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