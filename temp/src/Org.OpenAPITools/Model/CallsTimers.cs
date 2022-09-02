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
    /// Call length data for the specified grouping
    /// </summary>
    [DataContract]
    public partial class CallsTimers :  IEquatable<CallsTimers>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CallsTimers" /> class.
        /// </summary>
        /// <param name="allCalls">allCalls.</param>
        /// <param name="callsByDirection">callsByDirection.</param>
        /// <param name="callsByOrigin">callsByOrigin.</param>
        /// <param name="callsByResponse">callsByResponse.</param>
        /// <param name="callsSegments">callsSegments.</param>
        /// <param name="callsByResult">callsByResult.</param>
        /// <param name="callsByCompanyHours">callsByCompanyHours.</param>
        /// <param name="callsByQueueSla">callsByQueueSla.</param>
        /// <param name="callsByType">callsByType.</param>
        public CallsTimers(AllCalls allCalls = default(AllCalls), CallsByDirection callsByDirection = default(CallsByDirection), CallsByOrigin callsByOrigin = default(CallsByOrigin), CallsByResponse callsByResponse = default(CallsByResponse), CallsBySegments callsSegments = default(CallsBySegments), CallsByResult callsByResult = default(CallsByResult), CallsByCompanyHours callsByCompanyHours = default(CallsByCompanyHours), CallsByQueueSla callsByQueueSla = default(CallsByQueueSla), CallsByType callsByType = default(CallsByType))
        {
            this.AllCalls = allCalls;
            this.CallsByDirection = callsByDirection;
            this.CallsByOrigin = callsByOrigin;
            this.CallsByResponse = callsByResponse;
            this.CallsSegments = callsSegments;
            this.CallsByResult = callsByResult;
            this.CallsByCompanyHours = callsByCompanyHours;
            this.CallsByQueueSla = callsByQueueSla;
            this.CallsByType = callsByType;
        }

        /// <summary>
        /// Gets or Sets AllCalls
        /// </summary>
        [DataMember(Name="allCalls", EmitDefaultValue=false)]
        public AllCalls AllCalls { get; set; }

        /// <summary>
        /// Gets or Sets CallsByDirection
        /// </summary>
        [DataMember(Name="callsByDirection", EmitDefaultValue=false)]
        public CallsByDirection CallsByDirection { get; set; }

        /// <summary>
        /// Gets or Sets CallsByOrigin
        /// </summary>
        [DataMember(Name="callsByOrigin", EmitDefaultValue=false)]
        public CallsByOrigin CallsByOrigin { get; set; }

        /// <summary>
        /// Gets or Sets CallsByResponse
        /// </summary>
        [DataMember(Name="callsByResponse", EmitDefaultValue=false)]
        public CallsByResponse CallsByResponse { get; set; }

        /// <summary>
        /// Gets or Sets CallsSegments
        /// </summary>
        [DataMember(Name="callsSegments", EmitDefaultValue=false)]
        public CallsBySegments CallsSegments { get; set; }

        /// <summary>
        /// Gets or Sets CallsByResult
        /// </summary>
        [DataMember(Name="callsByResult", EmitDefaultValue=false)]
        public CallsByResult CallsByResult { get; set; }

        /// <summary>
        /// Gets or Sets CallsByCompanyHours
        /// </summary>
        [DataMember(Name="callsByCompanyHours", EmitDefaultValue=false)]
        public CallsByCompanyHours CallsByCompanyHours { get; set; }

        /// <summary>
        /// Gets or Sets CallsByQueueSla
        /// </summary>
        [DataMember(Name="callsByQueueSla", EmitDefaultValue=false)]
        public CallsByQueueSla CallsByQueueSla { get; set; }

        /// <summary>
        /// Gets or Sets CallsByType
        /// </summary>
        [DataMember(Name="callsByType", EmitDefaultValue=false)]
        public CallsByType CallsByType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CallsTimers {\n");
            sb.Append("  AllCalls: ").Append(AllCalls).Append("\n");
            sb.Append("  CallsByDirection: ").Append(CallsByDirection).Append("\n");
            sb.Append("  CallsByOrigin: ").Append(CallsByOrigin).Append("\n");
            sb.Append("  CallsByResponse: ").Append(CallsByResponse).Append("\n");
            sb.Append("  CallsSegments: ").Append(CallsSegments).Append("\n");
            sb.Append("  CallsByResult: ").Append(CallsByResult).Append("\n");
            sb.Append("  CallsByCompanyHours: ").Append(CallsByCompanyHours).Append("\n");
            sb.Append("  CallsByQueueSla: ").Append(CallsByQueueSla).Append("\n");
            sb.Append("  CallsByType: ").Append(CallsByType).Append("\n");
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
            return this.Equals(input as CallsTimers);
        }

        /// <summary>
        /// Returns true if CallsTimers instances are equal
        /// </summary>
        /// <param name="input">Instance of CallsTimers to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CallsTimers input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AllCalls == input.AllCalls ||
                    (this.AllCalls != null &&
                    this.AllCalls.Equals(input.AllCalls))
                ) && 
                (
                    this.CallsByDirection == input.CallsByDirection ||
                    (this.CallsByDirection != null &&
                    this.CallsByDirection.Equals(input.CallsByDirection))
                ) && 
                (
                    this.CallsByOrigin == input.CallsByOrigin ||
                    (this.CallsByOrigin != null &&
                    this.CallsByOrigin.Equals(input.CallsByOrigin))
                ) && 
                (
                    this.CallsByResponse == input.CallsByResponse ||
                    (this.CallsByResponse != null &&
                    this.CallsByResponse.Equals(input.CallsByResponse))
                ) && 
                (
                    this.CallsSegments == input.CallsSegments ||
                    (this.CallsSegments != null &&
                    this.CallsSegments.Equals(input.CallsSegments))
                ) && 
                (
                    this.CallsByResult == input.CallsByResult ||
                    (this.CallsByResult != null &&
                    this.CallsByResult.Equals(input.CallsByResult))
                ) && 
                (
                    this.CallsByCompanyHours == input.CallsByCompanyHours ||
                    (this.CallsByCompanyHours != null &&
                    this.CallsByCompanyHours.Equals(input.CallsByCompanyHours))
                ) && 
                (
                    this.CallsByQueueSla == input.CallsByQueueSla ||
                    (this.CallsByQueueSla != null &&
                    this.CallsByQueueSla.Equals(input.CallsByQueueSla))
                ) && 
                (
                    this.CallsByType == input.CallsByType ||
                    (this.CallsByType != null &&
                    this.CallsByType.Equals(input.CallsByType))
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
                if (this.AllCalls != null)
                    hashCode = hashCode * 59 + this.AllCalls.GetHashCode();
                if (this.CallsByDirection != null)
                    hashCode = hashCode * 59 + this.CallsByDirection.GetHashCode();
                if (this.CallsByOrigin != null)
                    hashCode = hashCode * 59 + this.CallsByOrigin.GetHashCode();
                if (this.CallsByResponse != null)
                    hashCode = hashCode * 59 + this.CallsByResponse.GetHashCode();
                if (this.CallsSegments != null)
                    hashCode = hashCode * 59 + this.CallsSegments.GetHashCode();
                if (this.CallsByResult != null)
                    hashCode = hashCode * 59 + this.CallsByResult.GetHashCode();
                if (this.CallsByCompanyHours != null)
                    hashCode = hashCode * 59 + this.CallsByCompanyHours.GetHashCode();
                if (this.CallsByQueueSla != null)
                    hashCode = hashCode * 59 + this.CallsByQueueSla.GetHashCode();
                if (this.CallsByType != null)
                    hashCode = hashCode * 59 + this.CallsByType.GetHashCode();
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
