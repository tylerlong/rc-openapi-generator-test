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
    /// ParsePhoneNumberRequest
    /// </summary>
    [DataContract]
    public partial class ParsePhoneNumberRequest :  IEquatable<ParsePhoneNumberRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ParsePhoneNumberRequest" /> class.
        /// </summary>
        /// <param name="originalStrings">Phone numbers passed in a string. The maximum value of phone numbers is limited to 64. The maximum number of symbols in each phone number in a string is 64.</param>
        public ParsePhoneNumberRequest(List<string> originalStrings = default(List<string>))
        {
            this.OriginalStrings = originalStrings;
        }

        /// <summary>
        /// Phone numbers passed in a string. The maximum value of phone numbers is limited to 64. The maximum number of symbols in each phone number in a string is 64
        /// </summary>
        /// <value>Phone numbers passed in a string. The maximum value of phone numbers is limited to 64. The maximum number of symbols in each phone number in a string is 64</value>
        [DataMember(Name="originalStrings", EmitDefaultValue=false)]
        public List<string> OriginalStrings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ParsePhoneNumberRequest {\n");
            sb.Append("  OriginalStrings: ").Append(OriginalStrings).Append("\n");
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
            return this.Equals(input as ParsePhoneNumberRequest);
        }

        /// <summary>
        /// Returns true if ParsePhoneNumberRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ParsePhoneNumberRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ParsePhoneNumberRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OriginalStrings == input.OriginalStrings ||
                    this.OriginalStrings != null &&
                    input.OriginalStrings != null &&
                    this.OriginalStrings.SequenceEqual(input.OriginalStrings)
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
                if (this.OriginalStrings != null)
                    hashCode = hashCode * 59 + this.OriginalStrings.GetHashCode();
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
