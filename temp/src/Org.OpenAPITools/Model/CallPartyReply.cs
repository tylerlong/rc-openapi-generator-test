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
    /// CallPartyReply
    /// </summary>
    [DataContract]
    public partial class CallPartyReply :  IEquatable<CallPartyReply>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CallPartyReply" /> class.
        /// </summary>
        /// <param name="replyWithText">Text to reply.</param>
        /// <param name="replyWithPattern">replyWithPattern.</param>
        public CallPartyReply(string replyWithText = default(string), ReplyWithPattern replyWithPattern = default(ReplyWithPattern))
        {
            this.ReplyWithText = replyWithText;
            this.ReplyWithPattern = replyWithPattern;
        }

        /// <summary>
        /// Text to reply
        /// </summary>
        /// <value>Text to reply</value>
        [DataMember(Name="replyWithText", EmitDefaultValue=false)]
        public string ReplyWithText { get; set; }

        /// <summary>
        /// Gets or Sets ReplyWithPattern
        /// </summary>
        [DataMember(Name="replyWithPattern", EmitDefaultValue=false)]
        public ReplyWithPattern ReplyWithPattern { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CallPartyReply {\n");
            sb.Append("  ReplyWithText: ").Append(ReplyWithText).Append("\n");
            sb.Append("  ReplyWithPattern: ").Append(ReplyWithPattern).Append("\n");
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
            return this.Equals(input as CallPartyReply);
        }

        /// <summary>
        /// Returns true if CallPartyReply instances are equal
        /// </summary>
        /// <param name="input">Instance of CallPartyReply to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CallPartyReply input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ReplyWithText == input.ReplyWithText ||
                    (this.ReplyWithText != null &&
                    this.ReplyWithText.Equals(input.ReplyWithText))
                ) && 
                (
                    this.ReplyWithPattern == input.ReplyWithPattern ||
                    (this.ReplyWithPattern != null &&
                    this.ReplyWithPattern.Equals(input.ReplyWithPattern))
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
                if (this.ReplyWithText != null)
                    hashCode = hashCode * 59 + this.ReplyWithText.GetHashCode();
                if (this.ReplyWithPattern != null)
                    hashCode = hashCode * 59 + this.ReplyWithPattern.GetHashCode();
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