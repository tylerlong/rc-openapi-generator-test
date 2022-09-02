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
    /// RingOut status information
    /// </summary>
    [DataContract]
    public partial class RingOutStatusInfo :  IEquatable<RingOutStatusInfo>, IValidatableObject
    {
        /// <summary>
        /// Status of a call
        /// </summary>
        /// <value>Status of a call</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CallStatusEnum
        {
            /// <summary>
            /// Enum Invalid for value: Invalid
            /// </summary>
            [EnumMember(Value = "Invalid")]
            Invalid = 1,

            /// <summary>
            /// Enum Success for value: Success
            /// </summary>
            [EnumMember(Value = "Success")]
            Success = 2,

            /// <summary>
            /// Enum InProgress for value: InProgress
            /// </summary>
            [EnumMember(Value = "InProgress")]
            InProgress = 3,

            /// <summary>
            /// Enum Busy for value: Busy
            /// </summary>
            [EnumMember(Value = "Busy")]
            Busy = 4,

            /// <summary>
            /// Enum NoAnswer for value: NoAnswer
            /// </summary>
            [EnumMember(Value = "NoAnswer")]
            NoAnswer = 5,

            /// <summary>
            /// Enum Rejected for value: Rejected
            /// </summary>
            [EnumMember(Value = "Rejected")]
            Rejected = 6,

            /// <summary>
            /// Enum GenericError for value: GenericError
            /// </summary>
            [EnumMember(Value = "GenericError")]
            GenericError = 7,

            /// <summary>
            /// Enum Finished for value: Finished
            /// </summary>
            [EnumMember(Value = "Finished")]
            Finished = 8,

            /// <summary>
            /// Enum InternationalDisabled for value: InternationalDisabled
            /// </summary>
            [EnumMember(Value = "InternationalDisabled")]
            InternationalDisabled = 9,

            /// <summary>
            /// Enum DestinationBlocked for value: DestinationBlocked
            /// </summary>
            [EnumMember(Value = "DestinationBlocked")]
            DestinationBlocked = 10,

            /// <summary>
            /// Enum NotEnoughFunds for value: NotEnoughFunds
            /// </summary>
            [EnumMember(Value = "NotEnoughFunds")]
            NotEnoughFunds = 11,

            /// <summary>
            /// Enum NoSuchUser for value: NoSuchUser
            /// </summary>
            [EnumMember(Value = "NoSuchUser")]
            NoSuchUser = 12

        }

        /// <summary>
        /// Status of a call
        /// </summary>
        /// <value>Status of a call</value>
        [DataMember(Name="callStatus", EmitDefaultValue=false)]
        public CallStatusEnum? CallStatus { get; set; }
        /// <summary>
        /// Status of a calling party
        /// </summary>
        /// <value>Status of a calling party</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CallerStatusEnum
        {
            /// <summary>
            /// Enum Invalid for value: Invalid
            /// </summary>
            [EnumMember(Value = "Invalid")]
            Invalid = 1,

            /// <summary>
            /// Enum Success for value: Success
            /// </summary>
            [EnumMember(Value = "Success")]
            Success = 2,

            /// <summary>
            /// Enum InProgress for value: InProgress
            /// </summary>
            [EnumMember(Value = "InProgress")]
            InProgress = 3,

            /// <summary>
            /// Enum Busy for value: Busy
            /// </summary>
            [EnumMember(Value = "Busy")]
            Busy = 4,

            /// <summary>
            /// Enum NoAnswer for value: NoAnswer
            /// </summary>
            [EnumMember(Value = "NoAnswer")]
            NoAnswer = 5,

            /// <summary>
            /// Enum Rejected for value: Rejected
            /// </summary>
            [EnumMember(Value = "Rejected")]
            Rejected = 6,

            /// <summary>
            /// Enum GenericError for value: GenericError
            /// </summary>
            [EnumMember(Value = "GenericError")]
            GenericError = 7,

            /// <summary>
            /// Enum Finished for value: Finished
            /// </summary>
            [EnumMember(Value = "Finished")]
            Finished = 8,

            /// <summary>
            /// Enum InternationalDisabled for value: InternationalDisabled
            /// </summary>
            [EnumMember(Value = "InternationalDisabled")]
            InternationalDisabled = 9,

            /// <summary>
            /// Enum DestinationBlocked for value: DestinationBlocked
            /// </summary>
            [EnumMember(Value = "DestinationBlocked")]
            DestinationBlocked = 10,

            /// <summary>
            /// Enum NotEnoughFunds for value: NotEnoughFunds
            /// </summary>
            [EnumMember(Value = "NotEnoughFunds")]
            NotEnoughFunds = 11,

            /// <summary>
            /// Enum NoSuchUser for value: NoSuchUser
            /// </summary>
            [EnumMember(Value = "NoSuchUser")]
            NoSuchUser = 12

        }

        /// <summary>
        /// Status of a calling party
        /// </summary>
        /// <value>Status of a calling party</value>
        [DataMember(Name="callerStatus", EmitDefaultValue=false)]
        public CallerStatusEnum? CallerStatus { get; set; }
        /// <summary>
        /// Status of a called party
        /// </summary>
        /// <value>Status of a called party</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CalleeStatusEnum
        {
            /// <summary>
            /// Enum Invalid for value: Invalid
            /// </summary>
            [EnumMember(Value = "Invalid")]
            Invalid = 1,

            /// <summary>
            /// Enum Success for value: Success
            /// </summary>
            [EnumMember(Value = "Success")]
            Success = 2,

            /// <summary>
            /// Enum InProgress for value: InProgress
            /// </summary>
            [EnumMember(Value = "InProgress")]
            InProgress = 3,

            /// <summary>
            /// Enum Busy for value: Busy
            /// </summary>
            [EnumMember(Value = "Busy")]
            Busy = 4,

            /// <summary>
            /// Enum NoAnswer for value: NoAnswer
            /// </summary>
            [EnumMember(Value = "NoAnswer")]
            NoAnswer = 5,

            /// <summary>
            /// Enum Rejected for value: Rejected
            /// </summary>
            [EnumMember(Value = "Rejected")]
            Rejected = 6,

            /// <summary>
            /// Enum GenericError for value: GenericError
            /// </summary>
            [EnumMember(Value = "GenericError")]
            GenericError = 7,

            /// <summary>
            /// Enum Finished for value: Finished
            /// </summary>
            [EnumMember(Value = "Finished")]
            Finished = 8,

            /// <summary>
            /// Enum InternationalDisabled for value: InternationalDisabled
            /// </summary>
            [EnumMember(Value = "InternationalDisabled")]
            InternationalDisabled = 9,

            /// <summary>
            /// Enum DestinationBlocked for value: DestinationBlocked
            /// </summary>
            [EnumMember(Value = "DestinationBlocked")]
            DestinationBlocked = 10,

            /// <summary>
            /// Enum NotEnoughFunds for value: NotEnoughFunds
            /// </summary>
            [EnumMember(Value = "NotEnoughFunds")]
            NotEnoughFunds = 11,

            /// <summary>
            /// Enum NoSuchUser for value: NoSuchUser
            /// </summary>
            [EnumMember(Value = "NoSuchUser")]
            NoSuchUser = 12

        }

        /// <summary>
        /// Status of a called party
        /// </summary>
        /// <value>Status of a called party</value>
        [DataMember(Name="calleeStatus", EmitDefaultValue=false)]
        public CalleeStatusEnum? CalleeStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RingOutStatusInfo" /> class.
        /// </summary>
        /// <param name="callStatus">Status of a call.</param>
        /// <param name="callerStatus">Status of a calling party.</param>
        /// <param name="calleeStatus">Status of a called party.</param>
        public RingOutStatusInfo(CallStatusEnum? callStatus = default(CallStatusEnum?), CallerStatusEnum? callerStatus = default(CallerStatusEnum?), CalleeStatusEnum? calleeStatus = default(CalleeStatusEnum?))
        {
            this.CallStatus = callStatus;
            this.CallerStatus = callerStatus;
            this.CalleeStatus = calleeStatus;
        }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RingOutStatusInfo {\n");
            sb.Append("  CallStatus: ").Append(CallStatus).Append("\n");
            sb.Append("  CallerStatus: ").Append(CallerStatus).Append("\n");
            sb.Append("  CalleeStatus: ").Append(CalleeStatus).Append("\n");
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
            return this.Equals(input as RingOutStatusInfo);
        }

        /// <summary>
        /// Returns true if RingOutStatusInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of RingOutStatusInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RingOutStatusInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CallStatus == input.CallStatus ||
                    (this.CallStatus != null &&
                    this.CallStatus.Equals(input.CallStatus))
                ) && 
                (
                    this.CallerStatus == input.CallerStatus ||
                    (this.CallerStatus != null &&
                    this.CallerStatus.Equals(input.CallerStatus))
                ) && 
                (
                    this.CalleeStatus == input.CalleeStatus ||
                    (this.CalleeStatus != null &&
                    this.CalleeStatus.Equals(input.CalleeStatus))
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
                if (this.CallStatus != null)
                    hashCode = hashCode * 59 + this.CallStatus.GetHashCode();
                if (this.CallerStatus != null)
                    hashCode = hashCode * 59 + this.CallerStatus.GetHashCode();
                if (this.CalleeStatus != null)
                    hashCode = hashCode * 59 + this.CalleeStatus.GetHashCode();
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