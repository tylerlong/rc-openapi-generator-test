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
    /// CallLogSync
    /// </summary>
    [DataContract]
    public partial class CallLogSync :  IEquatable<CallLogSync>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CallLogSync" /> class.
        /// </summary>
        /// <param name="uri">Link to the list of call log records with sync information.</param>
        /// <param name="records">List of call log records with synchronization information. For ISync the total number of returned records is limited to 250; this includes both new records and the old ones, specified by the recordCount parameter.</param>
        /// <param name="syncInfo">syncInfo.</param>
        public CallLogSync(string uri = default(string), List<UserCallLogRecord> records = default(List<UserCallLogRecord>), SyncInfoCallLog syncInfo = default(SyncInfoCallLog))
        {
            this.Uri = uri;
            this.Records = records;
            this.SyncInfo = syncInfo;
        }

        /// <summary>
        /// Link to the list of call log records with sync information
        /// </summary>
        /// <value>Link to the list of call log records with sync information</value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }

        /// <summary>
        /// List of call log records with synchronization information. For ISync the total number of returned records is limited to 250; this includes both new records and the old ones, specified by the recordCount parameter
        /// </summary>
        /// <value>List of call log records with synchronization information. For ISync the total number of returned records is limited to 250; this includes both new records and the old ones, specified by the recordCount parameter</value>
        [DataMember(Name="records", EmitDefaultValue=false)]
        public List<UserCallLogRecord> Records { get; set; }

        /// <summary>
        /// Gets or Sets SyncInfo
        /// </summary>
        [DataMember(Name="syncInfo", EmitDefaultValue=false)]
        public SyncInfoCallLog SyncInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CallLogSync {\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  Records: ").Append(Records).Append("\n");
            sb.Append("  SyncInfo: ").Append(SyncInfo).Append("\n");
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
            return this.Equals(input as CallLogSync);
        }

        /// <summary>
        /// Returns true if CallLogSync instances are equal
        /// </summary>
        /// <param name="input">Instance of CallLogSync to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CallLogSync input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Uri == input.Uri ||
                    (this.Uri != null &&
                    this.Uri.Equals(input.Uri))
                ) && 
                (
                    this.Records == input.Records ||
                    this.Records != null &&
                    input.Records != null &&
                    this.Records.SequenceEqual(input.Records)
                ) && 
                (
                    this.SyncInfo == input.SyncInfo ||
                    (this.SyncInfo != null &&
                    this.SyncInfo.Equals(input.SyncInfo))
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
                if (this.Uri != null)
                    hashCode = hashCode * 59 + this.Uri.GetHashCode();
                if (this.Records != null)
                    hashCode = hashCode * 59 + this.Records.GetHashCode();
                if (this.SyncInfo != null)
                    hashCode = hashCode * 59 + this.SyncInfo.GetHashCode();
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
