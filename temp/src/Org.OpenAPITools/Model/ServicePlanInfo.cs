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
    /// Information on account service plan
    /// </summary>
    [DataContract]
    public partial class ServicePlanInfo :  IEquatable<ServicePlanInfo>, IValidatableObject
    {
        /// <summary>
        /// Defines FreemiumProductType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FreemiumProductTypeEnum
        {
            /// <summary>
            /// Enum Freyja for value: Freyja
            /// </summary>
            [EnumMember(Value = "Freyja")]
            Freyja = 1,

            /// <summary>
            /// Enum Phoenix for value: Phoenix
            /// </summary>
            [EnumMember(Value = "Phoenix")]
            Phoenix = 2

        }

        /// <summary>
        /// Gets or Sets FreemiumProductType
        /// </summary>
        [DataMember(Name="freemiumProductType", EmitDefaultValue=false)]
        public FreemiumProductTypeEnum? FreemiumProductType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ServicePlanInfo" /> class.
        /// </summary>
        /// <param name="id">Internal identifier of a service plan.</param>
        /// <param name="name">Name of a service plan.</param>
        /// <param name="edition">Edition of a service plan.</param>
        /// <param name="freemiumProductType">freemiumProductType.</param>
        public ServicePlanInfo(string id = default(string), string name = default(string), string edition = default(string), FreemiumProductTypeEnum? freemiumProductType = default(FreemiumProductTypeEnum?))
        {
            this.Id = id;
            this.Name = name;
            this.Edition = edition;
            this.FreemiumProductType = freemiumProductType;
        }

        /// <summary>
        /// Internal identifier of a service plan
        /// </summary>
        /// <value>Internal identifier of a service plan</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Name of a service plan
        /// </summary>
        /// <value>Name of a service plan</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Edition of a service plan
        /// </summary>
        /// <value>Edition of a service plan</value>
        [DataMember(Name="edition", EmitDefaultValue=false)]
        public string Edition { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServicePlanInfo {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Edition: ").Append(Edition).Append("\n");
            sb.Append("  FreemiumProductType: ").Append(FreemiumProductType).Append("\n");
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
            return this.Equals(input as ServicePlanInfo);
        }

        /// <summary>
        /// Returns true if ServicePlanInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ServicePlanInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ServicePlanInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Edition == input.Edition ||
                    (this.Edition != null &&
                    this.Edition.Equals(input.Edition))
                ) && 
                (
                    this.FreemiumProductType == input.FreemiumProductType ||
                    (this.FreemiumProductType != null &&
                    this.FreemiumProductType.Equals(input.FreemiumProductType))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Edition != null)
                    hashCode = hashCode * 59 + this.Edition.GetHashCode();
                if (this.FreemiumProductType != null)
                    hashCode = hashCode * 59 + this.FreemiumProductType.GetHashCode();
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
