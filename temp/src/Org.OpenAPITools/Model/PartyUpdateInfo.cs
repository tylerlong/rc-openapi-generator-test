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
    /// Party update data
    /// </summary>
    [DataContract]
    public partial class PartyUpdateInfo :  IEquatable<PartyUpdateInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PartyUpdateInfo" /> class.
        /// </summary>
        /// <param name="muted">Specifies if a call participant is muted or not. **Note:** If a call is also controlled via Hard phone or RingCentral App (not only through the API by calling call control methods) then it cannot be fully muted/unmuted via API only, in this case the action should be duplicated via Hard phone/RC App interfaces.</param>
        /// <param name="standAlone">If &#39;True&#39; then the party is not connected to a session voice conference, &#39;False&#39; means the party is connected to other parties in a session.</param>
        public PartyUpdateInfo(bool muted = default(bool), bool standAlone = default(bool))
        {
            this.Muted = muted;
            this.StandAlone = standAlone;
        }

        /// <summary>
        /// Specifies if a call participant is muted or not. **Note:** If a call is also controlled via Hard phone or RingCentral App (not only through the API by calling call control methods) then it cannot be fully muted/unmuted via API only, in this case the action should be duplicated via Hard phone/RC App interfaces
        /// </summary>
        /// <value>Specifies if a call participant is muted or not. **Note:** If a call is also controlled via Hard phone or RingCentral App (not only through the API by calling call control methods) then it cannot be fully muted/unmuted via API only, in this case the action should be duplicated via Hard phone/RC App interfaces</value>
        [DataMember(Name="muted", EmitDefaultValue=false)]
        public bool Muted { get; set; }

        /// <summary>
        /// If &#39;True&#39; then the party is not connected to a session voice conference, &#39;False&#39; means the party is connected to other parties in a session
        /// </summary>
        /// <value>If &#39;True&#39; then the party is not connected to a session voice conference, &#39;False&#39; means the party is connected to other parties in a session</value>
        [DataMember(Name="standAlone", EmitDefaultValue=false)]
        public bool StandAlone { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PartyUpdateInfo {\n");
            sb.Append("  Muted: ").Append(Muted).Append("\n");
            sb.Append("  StandAlone: ").Append(StandAlone).Append("\n");
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
            return this.Equals(input as PartyUpdateInfo);
        }

        /// <summary>
        /// Returns true if PartyUpdateInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of PartyUpdateInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PartyUpdateInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Muted == input.Muted ||
                    (this.Muted != null &&
                    this.Muted.Equals(input.Muted))
                ) && 
                (
                    this.StandAlone == input.StandAlone ||
                    (this.StandAlone != null &&
                    this.StandAlone.Equals(input.StandAlone))
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
                if (this.Muted != null)
                    hashCode = hashCode * 59 + this.Muted.GetHashCode();
                if (this.StandAlone != null)
                    hashCode = hashCode * 59 + this.StandAlone.GetHashCode();
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
