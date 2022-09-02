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
    /// The statuses of the messages filtered by batch/account/phone numbers.
    /// </summary>
    [DataContract]
    public partial class MessageStatusesResponse :  IEquatable<MessageStatusesResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageStatusesResponse" /> class.
        /// </summary>
        /// <param name="messageStatuses">messageStatuses.</param>
        public MessageStatusesResponse(MessageStatuses messageStatuses = default(MessageStatuses))
        {
            this.MessageStatuses = messageStatuses;
        }

        /// <summary>
        /// Gets or Sets MessageStatuses
        /// </summary>
        [DataMember(Name="messageStatuses", EmitDefaultValue=false)]
        public MessageStatuses MessageStatuses { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessageStatusesResponse {\n");
            sb.Append("  MessageStatuses: ").Append(MessageStatuses).Append("\n");
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
            return this.Equals(input as MessageStatusesResponse);
        }

        /// <summary>
        /// Returns true if MessageStatusesResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of MessageStatusesResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessageStatusesResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MessageStatuses == input.MessageStatuses ||
                    (this.MessageStatuses != null &&
                    this.MessageStatuses.Equals(input.MessageStatuses))
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
                if (this.MessageStatuses != null)
                    hashCode = hashCode * 59 + this.MessageStatuses.GetHashCode();
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
