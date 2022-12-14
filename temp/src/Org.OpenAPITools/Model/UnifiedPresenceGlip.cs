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
    /// Returned if *Glip* feature is switched on
    /// </summary>
    [DataContract]
    public partial class UnifiedPresenceGlip :  IEquatable<UnifiedPresenceGlip>, IValidatableObject
    {
        /// <summary>
        /// Glip connection status calculated from all user&#39;s apps. Returned always for the requester&#39;s extension; returned for another users if their glip visibility is set to &#39;Visible&#39;
        /// </summary>
        /// <value>Glip connection status calculated from all user&#39;s apps. Returned always for the requester&#39;s extension; returned for another users if their glip visibility is set to &#39;Visible&#39;</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Offline for value: Offline
            /// </summary>
            [EnumMember(Value = "Offline")]
            Offline = 1,

            /// <summary>
            /// Enum Online for value: Online
            /// </summary>
            [EnumMember(Value = "Online")]
            Online = 2

        }

        /// <summary>
        /// Glip connection status calculated from all user&#39;s apps. Returned always for the requester&#39;s extension; returned for another users if their glip visibility is set to &#39;Visible&#39;
        /// </summary>
        /// <value>Glip connection status calculated from all user&#39;s apps. Returned always for the requester&#39;s extension; returned for another users if their glip visibility is set to &#39;Visible&#39;</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Visibility setting allowing other users to see the user&#39;s Glip presence status; returned only for requester&#39;s extension
        /// </summary>
        /// <value>Visibility setting allowing other users to see the user&#39;s Glip presence status; returned only for requester&#39;s extension</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum VisibilityEnum
        {
            /// <summary>
            /// Enum Visible for value: Visible
            /// </summary>
            [EnumMember(Value = "Visible")]
            Visible = 1,

            /// <summary>
            /// Enum Invisible for value: Invisible
            /// </summary>
            [EnumMember(Value = "Invisible")]
            Invisible = 2

        }

        /// <summary>
        /// Visibility setting allowing other users to see the user&#39;s Glip presence status; returned only for requester&#39;s extension
        /// </summary>
        /// <value>Visibility setting allowing other users to see the user&#39;s Glip presence status; returned only for requester&#39;s extension</value>
        [DataMember(Name="visibility", EmitDefaultValue=false)]
        public VisibilityEnum? Visibility { get; set; }
        /// <summary>
        /// Shows whether user wants to receive Glip notifications or not.
        /// </summary>
        /// <value>Shows whether user wants to receive Glip notifications or not.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AvailabilityEnum
        {
            /// <summary>
            /// Enum Available for value: Available
            /// </summary>
            [EnumMember(Value = "Available")]
            Available = 1,

            /// <summary>
            /// Enum DND for value: DND
            /// </summary>
            [EnumMember(Value = "DND")]
            DND = 2

        }

        /// <summary>
        /// Shows whether user wants to receive Glip notifications or not.
        /// </summary>
        /// <value>Shows whether user wants to receive Glip notifications or not.</value>
        [DataMember(Name="availability", EmitDefaultValue=false)]
        public AvailabilityEnum? Availability { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UnifiedPresenceGlip" /> class.
        /// </summary>
        /// <param name="status">Glip connection status calculated from all user&#39;s apps. Returned always for the requester&#39;s extension; returned for another users if their glip visibility is set to &#39;Visible&#39;.</param>
        /// <param name="visibility">Visibility setting allowing other users to see the user&#39;s Glip presence status; returned only for requester&#39;s extension.</param>
        /// <param name="availability">Shows whether user wants to receive Glip notifications or not..</param>
        public UnifiedPresenceGlip(StatusEnum? status = default(StatusEnum?), VisibilityEnum? visibility = default(VisibilityEnum?), AvailabilityEnum? availability = default(AvailabilityEnum?))
        {
            this.Status = status;
            this.Visibility = visibility;
            this.Availability = availability;
        }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UnifiedPresenceGlip {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Visibility: ").Append(Visibility).Append("\n");
            sb.Append("  Availability: ").Append(Availability).Append("\n");
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
            return this.Equals(input as UnifiedPresenceGlip);
        }

        /// <summary>
        /// Returns true if UnifiedPresenceGlip instances are equal
        /// </summary>
        /// <param name="input">Instance of UnifiedPresenceGlip to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UnifiedPresenceGlip input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Visibility == input.Visibility ||
                    (this.Visibility != null &&
                    this.Visibility.Equals(input.Visibility))
                ) && 
                (
                    this.Availability == input.Availability ||
                    (this.Availability != null &&
                    this.Availability.Equals(input.Availability))
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
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Visibility != null)
                    hashCode = hashCode * 59 + this.Visibility.GetHashCode();
                if (this.Availability != null)
                    hashCode = hashCode * 59 + this.Availability.GetHashCode();
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
