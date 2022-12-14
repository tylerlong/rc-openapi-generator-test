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
    /// CallQueues
    /// </summary>
    [DataContract]
    public partial class CallQueues :  IEquatable<CallQueues>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CallQueues" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CallQueues() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CallQueues" /> class.
        /// </summary>
        /// <param name="uri">Link to a call queues resource (required).</param>
        /// <param name="records">List of call queues (required).</param>
        /// <param name="navigation">navigation (required).</param>
        /// <param name="paging">paging (required).</param>
        public CallQueues(string uri = default(string), List<CallQueueInfo> records = default(List<CallQueueInfo>), ProvisioningNavigationInfo navigation = default(ProvisioningNavigationInfo), ProvisioningPagingInfo paging = default(ProvisioningPagingInfo))
        {
            // to ensure "uri" is required (not null)
            if (uri == null)
            {
                throw new InvalidDataException("uri is a required property for CallQueues and cannot be null");
            }
            else
            {
                this.Uri = uri;
            }

            // to ensure "records" is required (not null)
            if (records == null)
            {
                throw new InvalidDataException("records is a required property for CallQueues and cannot be null");
            }
            else
            {
                this.Records = records;
            }

            // to ensure "navigation" is required (not null)
            if (navigation == null)
            {
                throw new InvalidDataException("navigation is a required property for CallQueues and cannot be null");
            }
            else
            {
                this.Navigation = navigation;
            }

            // to ensure "paging" is required (not null)
            if (paging == null)
            {
                throw new InvalidDataException("paging is a required property for CallQueues and cannot be null");
            }
            else
            {
                this.Paging = paging;
            }

        }

        /// <summary>
        /// Link to a call queues resource
        /// </summary>
        /// <value>Link to a call queues resource</value>
        [DataMember(Name="uri", EmitDefaultValue=true)]
        public string Uri { get; set; }

        /// <summary>
        /// List of call queues
        /// </summary>
        /// <value>List of call queues</value>
        [DataMember(Name="records", EmitDefaultValue=true)]
        public List<CallQueueInfo> Records { get; set; }

        /// <summary>
        /// Gets or Sets Navigation
        /// </summary>
        [DataMember(Name="navigation", EmitDefaultValue=true)]
        public ProvisioningNavigationInfo Navigation { get; set; }

        /// <summary>
        /// Gets or Sets Paging
        /// </summary>
        [DataMember(Name="paging", EmitDefaultValue=true)]
        public ProvisioningPagingInfo Paging { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CallQueues {\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  Records: ").Append(Records).Append("\n");
            sb.Append("  Navigation: ").Append(Navigation).Append("\n");
            sb.Append("  Paging: ").Append(Paging).Append("\n");
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
            return this.Equals(input as CallQueues);
        }

        /// <summary>
        /// Returns true if CallQueues instances are equal
        /// </summary>
        /// <param name="input">Instance of CallQueues to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CallQueues input)
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
                    this.Navigation == input.Navigation ||
                    (this.Navigation != null &&
                    this.Navigation.Equals(input.Navigation))
                ) && 
                (
                    this.Paging == input.Paging ||
                    (this.Paging != null &&
                    this.Paging.Equals(input.Paging))
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
                if (this.Navigation != null)
                    hashCode = hashCode * 59 + this.Navigation.GetHashCode();
                if (this.Paging != null)
                    hashCode = hashCode * 59 + this.Paging.GetHashCode();
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
