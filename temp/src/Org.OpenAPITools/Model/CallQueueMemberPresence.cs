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
    /// CallQueueMemberPresence
    /// </summary>
    [DataContract]
    public partial class CallQueueMemberPresence :  IEquatable<CallQueueMemberPresence>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CallQueueMemberPresence" /> class.
        /// </summary>
        /// <param name="member">member.</param>
        /// <param name="acceptQueueCalls">Private member telephony availability status applied to calls of all queues.</param>
        /// <param name="acceptCurrentQueueCalls">Call queue member availability in this particular queue.</param>
        public CallQueueMemberPresence(CallQueueMember member = default(CallQueueMember), bool acceptQueueCalls = default(bool), bool acceptCurrentQueueCalls = default(bool))
        {
            this.Member = member;
            this.AcceptQueueCalls = acceptQueueCalls;
            this.AcceptCurrentQueueCalls = acceptCurrentQueueCalls;
        }

        /// <summary>
        /// Gets or Sets Member
        /// </summary>
        [DataMember(Name="member", EmitDefaultValue=false)]
        public CallQueueMember Member { get; set; }

        /// <summary>
        /// Private member telephony availability status applied to calls of all queues
        /// </summary>
        /// <value>Private member telephony availability status applied to calls of all queues</value>
        [DataMember(Name="acceptQueueCalls", EmitDefaultValue=false)]
        public bool AcceptQueueCalls { get; set; }

        /// <summary>
        /// Call queue member availability in this particular queue
        /// </summary>
        /// <value>Call queue member availability in this particular queue</value>
        [DataMember(Name="acceptCurrentQueueCalls", EmitDefaultValue=false)]
        public bool AcceptCurrentQueueCalls { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CallQueueMemberPresence {\n");
            sb.Append("  Member: ").Append(Member).Append("\n");
            sb.Append("  AcceptQueueCalls: ").Append(AcceptQueueCalls).Append("\n");
            sb.Append("  AcceptCurrentQueueCalls: ").Append(AcceptCurrentQueueCalls).Append("\n");
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
            return this.Equals(input as CallQueueMemberPresence);
        }

        /// <summary>
        /// Returns true if CallQueueMemberPresence instances are equal
        /// </summary>
        /// <param name="input">Instance of CallQueueMemberPresence to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CallQueueMemberPresence input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Member == input.Member ||
                    (this.Member != null &&
                    this.Member.Equals(input.Member))
                ) && 
                (
                    this.AcceptQueueCalls == input.AcceptQueueCalls ||
                    (this.AcceptQueueCalls != null &&
                    this.AcceptQueueCalls.Equals(input.AcceptQueueCalls))
                ) && 
                (
                    this.AcceptCurrentQueueCalls == input.AcceptCurrentQueueCalls ||
                    (this.AcceptCurrentQueueCalls != null &&
                    this.AcceptCurrentQueueCalls.Equals(input.AcceptCurrentQueueCalls))
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
                if (this.Member != null)
                    hashCode = hashCode * 59 + this.Member.GetHashCode();
                if (this.AcceptQueueCalls != null)
                    hashCode = hashCode * 59 + this.AcceptQueueCalls.GetHashCode();
                if (this.AcceptCurrentQueueCalls != null)
                    hashCode = hashCode * 59 + this.AcceptCurrentQueueCalls.GetHashCode();
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
