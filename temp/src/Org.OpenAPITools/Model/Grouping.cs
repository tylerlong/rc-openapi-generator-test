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
    /// This field specifies the dimensions by which the response should be grouped and specific keys to narrow the response. See also [Call Aggregate reports](https://developers.ringcentral.com/guide/analytics/aggregate) or [Call Timeline reports](https://developers.ringcentral.com/guide/analytics/timeline) pages in the developer guide for more information
    /// </summary>
    [DataContract]
    public partial class Grouping :  IEquatable<Grouping>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets GroupBy
        /// </summary>
        [DataMember(Name="groupBy", EmitDefaultValue=true)]
        public GroupingOptions GroupBy { get; set; }
        /// <summary>
        /// Gets or Sets GroupByMembers
        /// </summary>
        [DataMember(Name="groupByMembers", EmitDefaultValue=true)]
        public MembersGroupingOptions GroupByMembers { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Grouping" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Grouping() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Grouping" /> class.
        /// </summary>
        /// <param name="groupBy">groupBy (required).</param>
        /// <param name="keys">This field can be used to further limit the users selection by specifying unique identifiers of corresponding entities. For example, providing unique queue ids along with &#x60;Queue&#x60; in &#x60;groupByMembers&#x60; field will limit the response to users that are queue agents in at least one of these queues.</param>
        /// <param name="groupByMembers">groupByMembers (required).</param>
        public Grouping(GroupingOptions groupBy = default(GroupingOptions), List<string> keys = default(List<string>), MembersGroupingOptions groupByMembers = default(MembersGroupingOptions))
        {
            // to ensure "groupBy" is required (not null)
            if (groupBy == null)
            {
                throw new InvalidDataException("groupBy is a required property for Grouping and cannot be null");
            }
            else
            {
                this.GroupBy = groupBy;
            }

            // to ensure "groupByMembers" is required (not null)
            if (groupByMembers == null)
            {
                throw new InvalidDataException("groupByMembers is a required property for Grouping and cannot be null");
            }
            else
            {
                this.GroupByMembers = groupByMembers;
            }

            this.Keys = keys;
        }


        /// <summary>
        /// This field can be used to further limit the users selection by specifying unique identifiers of corresponding entities. For example, providing unique queue ids along with &#x60;Queue&#x60; in &#x60;groupByMembers&#x60; field will limit the response to users that are queue agents in at least one of these queues
        /// </summary>
        /// <value>This field can be used to further limit the users selection by specifying unique identifiers of corresponding entities. For example, providing unique queue ids along with &#x60;Queue&#x60; in &#x60;groupByMembers&#x60; field will limit the response to users that are queue agents in at least one of these queues</value>
        [DataMember(Name="keys", EmitDefaultValue=false)]
        public List<string> Keys { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Grouping {\n");
            sb.Append("  GroupBy: ").Append(GroupBy).Append("\n");
            sb.Append("  Keys: ").Append(Keys).Append("\n");
            sb.Append("  GroupByMembers: ").Append(GroupByMembers).Append("\n");
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
            return this.Equals(input as Grouping);
        }

        /// <summary>
        /// Returns true if Grouping instances are equal
        /// </summary>
        /// <param name="input">Instance of Grouping to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Grouping input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GroupBy == input.GroupBy ||
                    (this.GroupBy != null &&
                    this.GroupBy.Equals(input.GroupBy))
                ) && 
                (
                    this.Keys == input.Keys ||
                    this.Keys != null &&
                    input.Keys != null &&
                    this.Keys.SequenceEqual(input.Keys)
                ) && 
                (
                    this.GroupByMembers == input.GroupByMembers ||
                    (this.GroupByMembers != null &&
                    this.GroupByMembers.Equals(input.GroupByMembers))
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
                if (this.GroupBy != null)
                    hashCode = hashCode * 59 + this.GroupBy.GetHashCode();
                if (this.Keys != null)
                    hashCode = hashCode * 59 + this.Keys.GetHashCode();
                if (this.GroupByMembers != null)
                    hashCode = hashCode * 59 + this.GroupByMembers.GetHashCode();
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
