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
    /// Information specified in request
    /// </summary>
    [DataContract]
    public partial class SpecificInfo :  IEquatable<SpecificInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SpecificInfo" /> class.
        /// </summary>
        /// <param name="timeFrom">Starting time for data collection.</param>
        /// <param name="timeTo">Ending time for data collection.</param>
        /// <param name="contacts">contacts.</param>
        /// <param name="chatIds">List of chats from which the data (posts, files, tasks, events, notes, etc.) will be collected.</param>
        public SpecificInfo(string timeFrom = default(string), string timeTo = default(string), List<DataExportTaskContactInfo> contacts = default(List<DataExportTaskContactInfo>), List<string> chatIds = default(List<string>))
        {
            this.TimeFrom = timeFrom;
            this.TimeTo = timeTo;
            this.Contacts = contacts;
            this.ChatIds = chatIds;
        }

        /// <summary>
        /// Starting time for data collection
        /// </summary>
        /// <value>Starting time for data collection</value>
        [DataMember(Name="timeFrom", EmitDefaultValue=false)]
        public string TimeFrom { get; set; }

        /// <summary>
        /// Ending time for data collection
        /// </summary>
        /// <value>Ending time for data collection</value>
        [DataMember(Name="timeTo", EmitDefaultValue=false)]
        public string TimeTo { get; set; }

        /// <summary>
        /// Gets or Sets Contacts
        /// </summary>
        [DataMember(Name="contacts", EmitDefaultValue=false)]
        public List<DataExportTaskContactInfo> Contacts { get; set; }

        /// <summary>
        /// List of chats from which the data (posts, files, tasks, events, notes, etc.) will be collected
        /// </summary>
        /// <value>List of chats from which the data (posts, files, tasks, events, notes, etc.) will be collected</value>
        [DataMember(Name="chatIds", EmitDefaultValue=false)]
        public List<string> ChatIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SpecificInfo {\n");
            sb.Append("  TimeFrom: ").Append(TimeFrom).Append("\n");
            sb.Append("  TimeTo: ").Append(TimeTo).Append("\n");
            sb.Append("  Contacts: ").Append(Contacts).Append("\n");
            sb.Append("  ChatIds: ").Append(ChatIds).Append("\n");
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
            return this.Equals(input as SpecificInfo);
        }

        /// <summary>
        /// Returns true if SpecificInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of SpecificInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SpecificInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TimeFrom == input.TimeFrom ||
                    (this.TimeFrom != null &&
                    this.TimeFrom.Equals(input.TimeFrom))
                ) && 
                (
                    this.TimeTo == input.TimeTo ||
                    (this.TimeTo != null &&
                    this.TimeTo.Equals(input.TimeTo))
                ) && 
                (
                    this.Contacts == input.Contacts ||
                    this.Contacts != null &&
                    input.Contacts != null &&
                    this.Contacts.SequenceEqual(input.Contacts)
                ) && 
                (
                    this.ChatIds == input.ChatIds ||
                    this.ChatIds != null &&
                    input.ChatIds != null &&
                    this.ChatIds.SequenceEqual(input.ChatIds)
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
                if (this.TimeFrom != null)
                    hashCode = hashCode * 59 + this.TimeFrom.GetHashCode();
                if (this.TimeTo != null)
                    hashCode = hashCode * 59 + this.TimeTo.GetHashCode();
                if (this.Contacts != null)
                    hashCode = hashCode * 59 + this.Contacts.GetHashCode();
                if (this.ChatIds != null)
                    hashCode = hashCode * 59 + this.ChatIds.GetHashCode();
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
