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
    /// CallPartyFlip
    /// </summary>
    [DataContract]
    public partial class CallPartyFlip :  IEquatable<CallPartyFlip>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CallPartyFlip" /> class.
        /// </summary>
        /// <param name="callFlipId">Call flip id.</param>
        public CallPartyFlip(string callFlipId = default(string))
        {
            this.CallFlipId = callFlipId;
        }

        /// <summary>
        /// Call flip id
        /// </summary>
        /// <value>Call flip id</value>
        [DataMember(Name="callFlipId", EmitDefaultValue=false)]
        public string CallFlipId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CallPartyFlip {\n");
            sb.Append("  CallFlipId: ").Append(CallFlipId).Append("\n");
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
            return this.Equals(input as CallPartyFlip);
        }

        /// <summary>
        /// Returns true if CallPartyFlip instances are equal
        /// </summary>
        /// <param name="input">Instance of CallPartyFlip to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CallPartyFlip input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CallFlipId == input.CallFlipId ||
                    (this.CallFlipId != null &&
                    this.CallFlipId.Equals(input.CallFlipId))
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
                if (this.CallFlipId != null)
                    hashCode = hashCode * 59 + this.CallFlipId.GetHashCode();
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
