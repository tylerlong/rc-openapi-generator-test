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
    /// MessageStoreCallerInfoResponseTo
    /// </summary>
    [DataContract]
    public partial class MessageStoreCallerInfoResponseTo :  IEquatable<MessageStoreCallerInfoResponseTo>, IValidatableObject
    {
        /// <summary>
        /// Status of a message. Returned for outbound fax messages only
        /// </summary>
        /// <value>Status of a message. Returned for outbound fax messages only</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MessageStatusEnum
        {
            /// <summary>
            /// Enum Queued for value: Queued
            /// </summary>
            [EnumMember(Value = "Queued")]
            Queued = 1,

            /// <summary>
            /// Enum Sent for value: Sent
            /// </summary>
            [EnumMember(Value = "Sent")]
            Sent = 2,

            /// <summary>
            /// Enum Delivered for value: Delivered
            /// </summary>
            [EnumMember(Value = "Delivered")]
            Delivered = 3,

            /// <summary>
            /// Enum DeliveryFailed for value: DeliveryFailed
            /// </summary>
            [EnumMember(Value = "DeliveryFailed")]
            DeliveryFailed = 4,

            /// <summary>
            /// Enum SendingFailed for value: SendingFailed
            /// </summary>
            [EnumMember(Value = "SendingFailed")]
            SendingFailed = 5,

            /// <summary>
            /// Enum Received for value: Received
            /// </summary>
            [EnumMember(Value = "Received")]
            Received = 6

        }

        /// <summary>
        /// Status of a message. Returned for outbound fax messages only
        /// </summary>
        /// <value>Status of a message. Returned for outbound fax messages only</value>
        [DataMember(Name="messageStatus", EmitDefaultValue=false)]
        public MessageStatusEnum? MessageStatus { get; set; }
        /// <summary>
        /// Error code returned in case of fax sending failure. Returned if messageStatus value is &#39;SendingFailed&#39;. Supported for fax messages only
        /// </summary>
        /// <value>Error code returned in case of fax sending failure. Returned if messageStatus value is &#39;SendingFailed&#39;. Supported for fax messages only</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FaxErrorCodeEnum
        {
            /// <summary>
            /// Enum AllLinesInUse for value: AllLinesInUse
            /// </summary>
            [EnumMember(Value = "AllLinesInUse")]
            AllLinesInUse = 1,

            /// <summary>
            /// Enum Undefined for value: Undefined
            /// </summary>
            [EnumMember(Value = "Undefined")]
            Undefined = 2,

            /// <summary>
            /// Enum NoFaxSendPermission for value: NoFaxSendPermission
            /// </summary>
            [EnumMember(Value = "NoFaxSendPermission")]
            NoFaxSendPermission = 3,

            /// <summary>
            /// Enum NoInternationalPermission for value: NoInternationalPermission
            /// </summary>
            [EnumMember(Value = "NoInternationalPermission")]
            NoInternationalPermission = 4,

            /// <summary>
            /// Enum NoFaxMachine for value: NoFaxMachine
            /// </summary>
            [EnumMember(Value = "NoFaxMachine")]
            NoFaxMachine = 5,

            /// <summary>
            /// Enum NoAnswer for value: NoAnswer
            /// </summary>
            [EnumMember(Value = "NoAnswer")]
            NoAnswer = 6,

            /// <summary>
            /// Enum LineBusy for value: LineBusy
            /// </summary>
            [EnumMember(Value = "LineBusy")]
            LineBusy = 7,

            /// <summary>
            /// Enum CallerHungUp for value: CallerHungUp
            /// </summary>
            [EnumMember(Value = "CallerHungUp")]
            CallerHungUp = 8,

            /// <summary>
            /// Enum NotEnoughCredits for value: NotEnoughCredits
            /// </summary>
            [EnumMember(Value = "NotEnoughCredits")]
            NotEnoughCredits = 9,

            /// <summary>
            /// Enum SentPartially for value: SentPartially
            /// </summary>
            [EnumMember(Value = "SentPartially")]
            SentPartially = 10,

            /// <summary>
            /// Enum InternationalCallingDisabled for value: InternationalCallingDisabled
            /// </summary>
            [EnumMember(Value = "InternationalCallingDisabled")]
            InternationalCallingDisabled = 11,

            /// <summary>
            /// Enum DestinationCountryDisabled for value: DestinationCountryDisabled
            /// </summary>
            [EnumMember(Value = "DestinationCountryDisabled")]
            DestinationCountryDisabled = 12,

            /// <summary>
            /// Enum UnknownCountryCode for value: UnknownCountryCode
            /// </summary>
            [EnumMember(Value = "UnknownCountryCode")]
            UnknownCountryCode = 13,

            /// <summary>
            /// Enum NotAccepted for value: NotAccepted
            /// </summary>
            [EnumMember(Value = "NotAccepted")]
            NotAccepted = 14,

            /// <summary>
            /// Enum InvalidNumber for value: InvalidNumber
            /// </summary>
            [EnumMember(Value = "InvalidNumber")]
            InvalidNumber = 15,

            /// <summary>
            /// Enum CallDeclined for value: CallDeclined
            /// </summary>
            [EnumMember(Value = "CallDeclined")]
            CallDeclined = 16,

            /// <summary>
            /// Enum TooManyCallsPerLine for value: TooManyCallsPerLine
            /// </summary>
            [EnumMember(Value = "TooManyCallsPerLine")]
            TooManyCallsPerLine = 17,

            /// <summary>
            /// Enum CallFailed for value: CallFailed
            /// </summary>
            [EnumMember(Value = "CallFailed")]
            CallFailed = 18,

            /// <summary>
            /// Enum RenderingFailed for value: RenderingFailed
            /// </summary>
            [EnumMember(Value = "RenderingFailed")]
            RenderingFailed = 19,

            /// <summary>
            /// Enum TooManyPages for value: TooManyPages
            /// </summary>
            [EnumMember(Value = "TooManyPages")]
            TooManyPages = 20,

            /// <summary>
            /// Enum ReturnToDBQueue for value: ReturnToDBQueue
            /// </summary>
            [EnumMember(Value = "ReturnToDBQueue")]
            ReturnToDBQueue = 21,

            /// <summary>
            /// Enum NoCallTime for value: NoCallTime
            /// </summary>
            [EnumMember(Value = "NoCallTime")]
            NoCallTime = 22,

            /// <summary>
            /// Enum WrongNumber for value: WrongNumber
            /// </summary>
            [EnumMember(Value = "WrongNumber")]
            WrongNumber = 23,

            /// <summary>
            /// Enum ProhibitedNumber for value: ProhibitedNumber
            /// </summary>
            [EnumMember(Value = "ProhibitedNumber")]
            ProhibitedNumber = 24,

            /// <summary>
            /// Enum InternalError for value: InternalError
            /// </summary>
            [EnumMember(Value = "InternalError")]
            InternalError = 25,

            /// <summary>
            /// Enum FaxSendingProhibited for value: FaxSendingProhibited
            /// </summary>
            [EnumMember(Value = "FaxSendingProhibited")]
            FaxSendingProhibited = 26,

            /// <summary>
            /// Enum ThePhoneIsBlacklisted for value: ThePhoneIsBlacklisted
            /// </summary>
            [EnumMember(Value = "ThePhoneIsBlacklisted")]
            ThePhoneIsBlacklisted = 27,

            /// <summary>
            /// Enum UserNotFound for value: UserNotFound
            /// </summary>
            [EnumMember(Value = "UserNotFound")]
            UserNotFound = 28,

            /// <summary>
            /// Enum ConvertError for value: ConvertError
            /// </summary>
            [EnumMember(Value = "ConvertError")]
            ConvertError = 29,

            /// <summary>
            /// Enum DBGeneralError for value: DBGeneralError
            /// </summary>
            [EnumMember(Value = "DBGeneralError")]
            DBGeneralError = 30,

            /// <summary>
            /// Enum SkypeBillingFailed for value: SkypeBillingFailed
            /// </summary>
            [EnumMember(Value = "SkypeBillingFailed")]
            SkypeBillingFailed = 31,

            /// <summary>
            /// Enum AccountSuspended for value: AccountSuspended
            /// </summary>
            [EnumMember(Value = "AccountSuspended")]
            AccountSuspended = 32,

            /// <summary>
            /// Enum ProhibitedDestination for value: ProhibitedDestination
            /// </summary>
            [EnumMember(Value = "ProhibitedDestination")]
            ProhibitedDestination = 33,

            /// <summary>
            /// Enum InternationalDisabled for value: InternationalDisabled
            /// </summary>
            [EnumMember(Value = "InternationalDisabled")]
            InternationalDisabled = 34

        }

        /// <summary>
        /// Error code returned in case of fax sending failure. Returned if messageStatus value is &#39;SendingFailed&#39;. Supported for fax messages only
        /// </summary>
        /// <value>Error code returned in case of fax sending failure. Returned if messageStatus value is &#39;SendingFailed&#39;. Supported for fax messages only</value>
        [DataMember(Name="faxErrorCode", EmitDefaultValue=false)]
        public FaxErrorCodeEnum? FaxErrorCode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageStoreCallerInfoResponseTo" /> class.
        /// </summary>
        /// <param name="extensionNumber">Extension short number (usually 3 or 4 digits). This property is filled when parties communicate by means of short internal numbers, for example when calling to other extension or sending/receiving Company Pager message.</param>
        /// <param name="extensionId">extensionId.</param>
        /// <param name="location">Contains party location (city, state) if one can be determined from phoneNumber. This property is filled only when phoneNumber is not empty and server can calculate location information from it (for example, this information is unavailable for US toll-free numbers).</param>
        /// <param name="target">&#39;True&#39; specifies that message is sent exactly to this recipient. Returned in to field for group MMS. Useful if one extension has several phone numbers.</param>
        /// <param name="messageStatus">Status of a message. Returned for outbound fax messages only.</param>
        /// <param name="faxErrorCode">Error code returned in case of fax sending failure. Returned if messageStatus value is &#39;SendingFailed&#39;. Supported for fax messages only.</param>
        /// <param name="name">Symbolic name associated with a party. If the phone does not belong to the known extension, only the location is returned, the name is not determined then.</param>
        /// <param name="phoneNumber">Phone number of a party. Usually it is a plain number including country and area code like 18661234567. But sometimes it could be returned from database with some formatting applied, for example (866)123-4567. This property is filled in all cases where parties communicate by means of global phone numbers, for example when calling to direct numbers or sending/receiving SMS.</param>
        public MessageStoreCallerInfoResponseTo(string extensionNumber = default(string), string extensionId = default(string), string location = default(string), bool target = default(bool), MessageStatusEnum? messageStatus = default(MessageStatusEnum?), FaxErrorCodeEnum? faxErrorCode = default(FaxErrorCodeEnum?), string name = default(string), string phoneNumber = default(string))
        {
            this.ExtensionNumber = extensionNumber;
            this.ExtensionId = extensionId;
            this.Location = location;
            this.Target = target;
            this.MessageStatus = messageStatus;
            this.FaxErrorCode = faxErrorCode;
            this.Name = name;
            this.PhoneNumber = phoneNumber;
        }

        /// <summary>
        /// Extension short number (usually 3 or 4 digits). This property is filled when parties communicate by means of short internal numbers, for example when calling to other extension or sending/receiving Company Pager message
        /// </summary>
        /// <value>Extension short number (usually 3 or 4 digits). This property is filled when parties communicate by means of short internal numbers, for example when calling to other extension or sending/receiving Company Pager message</value>
        [DataMember(Name="extensionNumber", EmitDefaultValue=false)]
        public string ExtensionNumber { get; set; }

        /// <summary>
        /// Gets or Sets ExtensionId
        /// </summary>
        [DataMember(Name="extensionId", EmitDefaultValue=false)]
        public string ExtensionId { get; set; }

        /// <summary>
        /// Contains party location (city, state) if one can be determined from phoneNumber. This property is filled only when phoneNumber is not empty and server can calculate location information from it (for example, this information is unavailable for US toll-free numbers)
        /// </summary>
        /// <value>Contains party location (city, state) if one can be determined from phoneNumber. This property is filled only when phoneNumber is not empty and server can calculate location information from it (for example, this information is unavailable for US toll-free numbers)</value>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public string Location { get; set; }

        /// <summary>
        /// &#39;True&#39; specifies that message is sent exactly to this recipient. Returned in to field for group MMS. Useful if one extension has several phone numbers
        /// </summary>
        /// <value>&#39;True&#39; specifies that message is sent exactly to this recipient. Returned in to field for group MMS. Useful if one extension has several phone numbers</value>
        [DataMember(Name="target", EmitDefaultValue=false)]
        public bool Target { get; set; }



        /// <summary>
        /// Symbolic name associated with a party. If the phone does not belong to the known extension, only the location is returned, the name is not determined then
        /// </summary>
        /// <value>Symbolic name associated with a party. If the phone does not belong to the known extension, only the location is returned, the name is not determined then</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Phone number of a party. Usually it is a plain number including country and area code like 18661234567. But sometimes it could be returned from database with some formatting applied, for example (866)123-4567. This property is filled in all cases where parties communicate by means of global phone numbers, for example when calling to direct numbers or sending/receiving SMS
        /// </summary>
        /// <value>Phone number of a party. Usually it is a plain number including country and area code like 18661234567. But sometimes it could be returned from database with some formatting applied, for example (866)123-4567. This property is filled in all cases where parties communicate by means of global phone numbers, for example when calling to direct numbers or sending/receiving SMS</value>
        [DataMember(Name="phoneNumber", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessageStoreCallerInfoResponseTo {\n");
            sb.Append("  ExtensionNumber: ").Append(ExtensionNumber).Append("\n");
            sb.Append("  ExtensionId: ").Append(ExtensionId).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  Target: ").Append(Target).Append("\n");
            sb.Append("  MessageStatus: ").Append(MessageStatus).Append("\n");
            sb.Append("  FaxErrorCode: ").Append(FaxErrorCode).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
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
            return this.Equals(input as MessageStoreCallerInfoResponseTo);
        }

        /// <summary>
        /// Returns true if MessageStoreCallerInfoResponseTo instances are equal
        /// </summary>
        /// <param name="input">Instance of MessageStoreCallerInfoResponseTo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessageStoreCallerInfoResponseTo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExtensionNumber == input.ExtensionNumber ||
                    (this.ExtensionNumber != null &&
                    this.ExtensionNumber.Equals(input.ExtensionNumber))
                ) && 
                (
                    this.ExtensionId == input.ExtensionId ||
                    (this.ExtensionId != null &&
                    this.ExtensionId.Equals(input.ExtensionId))
                ) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this.Target == input.Target ||
                    (this.Target != null &&
                    this.Target.Equals(input.Target))
                ) && 
                (
                    this.MessageStatus == input.MessageStatus ||
                    (this.MessageStatus != null &&
                    this.MessageStatus.Equals(input.MessageStatus))
                ) && 
                (
                    this.FaxErrorCode == input.FaxErrorCode ||
                    (this.FaxErrorCode != null &&
                    this.FaxErrorCode.Equals(input.FaxErrorCode))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.PhoneNumber == input.PhoneNumber ||
                    (this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(input.PhoneNumber))
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
                if (this.ExtensionNumber != null)
                    hashCode = hashCode * 59 + this.ExtensionNumber.GetHashCode();
                if (this.ExtensionId != null)
                    hashCode = hashCode * 59 + this.ExtensionId.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.Target != null)
                    hashCode = hashCode * 59 + this.Target.GetHashCode();
                if (this.MessageStatus != null)
                    hashCode = hashCode * 59 + this.MessageStatus.GetHashCode();
                if (this.FaxErrorCode != null)
                    hashCode = hashCode * 59 + this.FaxErrorCode.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.PhoneNumber != null)
                    hashCode = hashCode * 59 + this.PhoneNumber.GetHashCode();
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