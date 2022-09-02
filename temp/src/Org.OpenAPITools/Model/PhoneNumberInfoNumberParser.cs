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
    /// PhoneNumberInfoNumberParser
    /// </summary>
    [DataContract]
    public partial class PhoneNumberInfoNumberParser :  IEquatable<PhoneNumberInfoNumberParser>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumberInfoNumberParser" /> class.
        /// </summary>
        /// <param name="areaCode">Area code of location. The portion of the [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) number that identifies a specific geographic region/numbering area of the national numbering plan (NANP); that can be summarized as &#x60;NPA-NXX-xxxx&#x60; and covers Canada, the United States, parts of the Caribbean Sea, and some Atlantic and Pacific islands. See [North American Numbering Plan] (https://en.wikipedia.org/wiki/North_American_Numbering_Plan) for details.</param>
        /// <param name="country">country.</param>
        /// <param name="dialable">Dialing format of a phone number.</param>
        /// <param name="e164">Phone number [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) format.</param>
        /// <param name="formattedInternational">International format of a phone number.</param>
        /// <param name="formattedNational">Domestic format of a phone number.</param>
        /// <param name="originalString">One of the numbers to be parsed, passed as a string in response.</param>
        /// <param name="special">&#39;True&#39; if the number is in a special format (for example N11 code).</param>
        /// <param name="normalized">Phone number [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) format without plus sign (&#39;+&#39;).</param>
        /// <param name="tollFree">Specifies if a phone number is toll free or not.</param>
        /// <param name="subAddress">Sub-Address. The portion of the number that identifies a subscriber into the subscriber internal (non-public) network..</param>
        /// <param name="subscriberNumber"> Subscriber number. The portion of the [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) number that identifies a subscriber in a network or numbering area..</param>
        /// <param name="dtmfPostfix">DTMF (Dual Tone Multi-Frequency) postfix.</param>
        public PhoneNumberInfoNumberParser(string areaCode = default(string), GetCountryInfoNumberParser country = default(GetCountryInfoNumberParser), string dialable = default(string), string e164 = default(string), string formattedInternational = default(string), string formattedNational = default(string), string originalString = default(string), bool special = default(bool), string normalized = default(string), bool tollFree = default(bool), string subAddress = default(string), string subscriberNumber = default(string), string dtmfPostfix = default(string))
        {
            this.AreaCode = areaCode;
            this.Country = country;
            this.Dialable = dialable;
            this.E164 = e164;
            this.FormattedInternational = formattedInternational;
            this.FormattedNational = formattedNational;
            this.OriginalString = originalString;
            this.Special = special;
            this.Normalized = normalized;
            this.TollFree = tollFree;
            this.SubAddress = subAddress;
            this.SubscriberNumber = subscriberNumber;
            this.DtmfPostfix = dtmfPostfix;
        }

        /// <summary>
        /// Area code of location. The portion of the [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) number that identifies a specific geographic region/numbering area of the national numbering plan (NANP); that can be summarized as &#x60;NPA-NXX-xxxx&#x60; and covers Canada, the United States, parts of the Caribbean Sea, and some Atlantic and Pacific islands. See [North American Numbering Plan] (https://en.wikipedia.org/wiki/North_American_Numbering_Plan) for details
        /// </summary>
        /// <value>Area code of location. The portion of the [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) number that identifies a specific geographic region/numbering area of the national numbering plan (NANP); that can be summarized as &#x60;NPA-NXX-xxxx&#x60; and covers Canada, the United States, parts of the Caribbean Sea, and some Atlantic and Pacific islands. See [North American Numbering Plan] (https://en.wikipedia.org/wiki/North_American_Numbering_Plan) for details</value>
        [DataMember(Name="areaCode", EmitDefaultValue=false)]
        public string AreaCode { get; set; }

        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public GetCountryInfoNumberParser Country { get; set; }

        /// <summary>
        /// Dialing format of a phone number
        /// </summary>
        /// <value>Dialing format of a phone number</value>
        [DataMember(Name="dialable", EmitDefaultValue=false)]
        public string Dialable { get; set; }

        /// <summary>
        /// Phone number [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) format
        /// </summary>
        /// <value>Phone number [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) format</value>
        [DataMember(Name="e164", EmitDefaultValue=false)]
        public string E164 { get; set; }

        /// <summary>
        /// International format of a phone number
        /// </summary>
        /// <value>International format of a phone number</value>
        [DataMember(Name="formattedInternational", EmitDefaultValue=false)]
        public string FormattedInternational { get; set; }

        /// <summary>
        /// Domestic format of a phone number
        /// </summary>
        /// <value>Domestic format of a phone number</value>
        [DataMember(Name="formattedNational", EmitDefaultValue=false)]
        public string FormattedNational { get; set; }

        /// <summary>
        /// One of the numbers to be parsed, passed as a string in response
        /// </summary>
        /// <value>One of the numbers to be parsed, passed as a string in response</value>
        [DataMember(Name="originalString", EmitDefaultValue=false)]
        public string OriginalString { get; set; }

        /// <summary>
        /// &#39;True&#39; if the number is in a special format (for example N11 code)
        /// </summary>
        /// <value>&#39;True&#39; if the number is in a special format (for example N11 code)</value>
        [DataMember(Name="special", EmitDefaultValue=false)]
        public bool Special { get; set; }

        /// <summary>
        /// Phone number [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) format without plus sign (&#39;+&#39;)
        /// </summary>
        /// <value>Phone number [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) format without plus sign (&#39;+&#39;)</value>
        [DataMember(Name="normalized", EmitDefaultValue=false)]
        public string Normalized { get; set; }

        /// <summary>
        /// Specifies if a phone number is toll free or not
        /// </summary>
        /// <value>Specifies if a phone number is toll free or not</value>
        [DataMember(Name="tollFree", EmitDefaultValue=false)]
        public bool TollFree { get; set; }

        /// <summary>
        /// Sub-Address. The portion of the number that identifies a subscriber into the subscriber internal (non-public) network.
        /// </summary>
        /// <value>Sub-Address. The portion of the number that identifies a subscriber into the subscriber internal (non-public) network.</value>
        [DataMember(Name="subAddress", EmitDefaultValue=false)]
        public string SubAddress { get; set; }

        /// <summary>
        ///  Subscriber number. The portion of the [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) number that identifies a subscriber in a network or numbering area.
        /// </summary>
        /// <value> Subscriber number. The portion of the [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) number that identifies a subscriber in a network or numbering area.</value>
        [DataMember(Name="subscriberNumber", EmitDefaultValue=false)]
        public string SubscriberNumber { get; set; }

        /// <summary>
        /// DTMF (Dual Tone Multi-Frequency) postfix
        /// </summary>
        /// <value>DTMF (Dual Tone Multi-Frequency) postfix</value>
        [DataMember(Name="dtmfPostfix", EmitDefaultValue=false)]
        public string DtmfPostfix { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PhoneNumberInfoNumberParser {\n");
            sb.Append("  AreaCode: ").Append(AreaCode).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Dialable: ").Append(Dialable).Append("\n");
            sb.Append("  E164: ").Append(E164).Append("\n");
            sb.Append("  FormattedInternational: ").Append(FormattedInternational).Append("\n");
            sb.Append("  FormattedNational: ").Append(FormattedNational).Append("\n");
            sb.Append("  OriginalString: ").Append(OriginalString).Append("\n");
            sb.Append("  Special: ").Append(Special).Append("\n");
            sb.Append("  Normalized: ").Append(Normalized).Append("\n");
            sb.Append("  TollFree: ").Append(TollFree).Append("\n");
            sb.Append("  SubAddress: ").Append(SubAddress).Append("\n");
            sb.Append("  SubscriberNumber: ").Append(SubscriberNumber).Append("\n");
            sb.Append("  DtmfPostfix: ").Append(DtmfPostfix).Append("\n");
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
            return this.Equals(input as PhoneNumberInfoNumberParser);
        }

        /// <summary>
        /// Returns true if PhoneNumberInfoNumberParser instances are equal
        /// </summary>
        /// <param name="input">Instance of PhoneNumberInfoNumberParser to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PhoneNumberInfoNumberParser input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AreaCode == input.AreaCode ||
                    (this.AreaCode != null &&
                    this.AreaCode.Equals(input.AreaCode))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.Dialable == input.Dialable ||
                    (this.Dialable != null &&
                    this.Dialable.Equals(input.Dialable))
                ) && 
                (
                    this.E164 == input.E164 ||
                    (this.E164 != null &&
                    this.E164.Equals(input.E164))
                ) && 
                (
                    this.FormattedInternational == input.FormattedInternational ||
                    (this.FormattedInternational != null &&
                    this.FormattedInternational.Equals(input.FormattedInternational))
                ) && 
                (
                    this.FormattedNational == input.FormattedNational ||
                    (this.FormattedNational != null &&
                    this.FormattedNational.Equals(input.FormattedNational))
                ) && 
                (
                    this.OriginalString == input.OriginalString ||
                    (this.OriginalString != null &&
                    this.OriginalString.Equals(input.OriginalString))
                ) && 
                (
                    this.Special == input.Special ||
                    (this.Special != null &&
                    this.Special.Equals(input.Special))
                ) && 
                (
                    this.Normalized == input.Normalized ||
                    (this.Normalized != null &&
                    this.Normalized.Equals(input.Normalized))
                ) && 
                (
                    this.TollFree == input.TollFree ||
                    (this.TollFree != null &&
                    this.TollFree.Equals(input.TollFree))
                ) && 
                (
                    this.SubAddress == input.SubAddress ||
                    (this.SubAddress != null &&
                    this.SubAddress.Equals(input.SubAddress))
                ) && 
                (
                    this.SubscriberNumber == input.SubscriberNumber ||
                    (this.SubscriberNumber != null &&
                    this.SubscriberNumber.Equals(input.SubscriberNumber))
                ) && 
                (
                    this.DtmfPostfix == input.DtmfPostfix ||
                    (this.DtmfPostfix != null &&
                    this.DtmfPostfix.Equals(input.DtmfPostfix))
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
                if (this.AreaCode != null)
                    hashCode = hashCode * 59 + this.AreaCode.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.Dialable != null)
                    hashCode = hashCode * 59 + this.Dialable.GetHashCode();
                if (this.E164 != null)
                    hashCode = hashCode * 59 + this.E164.GetHashCode();
                if (this.FormattedInternational != null)
                    hashCode = hashCode * 59 + this.FormattedInternational.GetHashCode();
                if (this.FormattedNational != null)
                    hashCode = hashCode * 59 + this.FormattedNational.GetHashCode();
                if (this.OriginalString != null)
                    hashCode = hashCode * 59 + this.OriginalString.GetHashCode();
                if (this.Special != null)
                    hashCode = hashCode * 59 + this.Special.GetHashCode();
                if (this.Normalized != null)
                    hashCode = hashCode * 59 + this.Normalized.GetHashCode();
                if (this.TollFree != null)
                    hashCode = hashCode * 59 + this.TollFree.GetHashCode();
                if (this.SubAddress != null)
                    hashCode = hashCode * 59 + this.SubAddress.GetHashCode();
                if (this.SubscriberNumber != null)
                    hashCode = hashCode * 59 + this.SubscriberNumber.GetHashCode();
                if (this.DtmfPostfix != null)
                    hashCode = hashCode * 59 + this.DtmfPostfix.GetHashCode();
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