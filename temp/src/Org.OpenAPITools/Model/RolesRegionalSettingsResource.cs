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
    /// RolesRegionalSettingsResource
    /// </summary>
    [DataContract]
    public partial class RolesRegionalSettingsResource :  IEquatable<RolesRegionalSettingsResource>, IValidatableObject
    {
        /// <summary>
        /// Defines TimeFormat
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TimeFormatEnum
        {
            /// <summary>
            /// Enum _12h for value: 12h
            /// </summary>
            [EnumMember(Value = "12h")]
            _12h = 1,

            /// <summary>
            /// Enum _24h for value: 24h
            /// </summary>
            [EnumMember(Value = "24h")]
            _24h = 2

        }

        /// <summary>
        /// Gets or Sets TimeFormat
        /// </summary>
        [DataMember(Name="timeFormat", EmitDefaultValue=false)]
        public TimeFormatEnum? TimeFormat { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RolesRegionalSettingsResource" /> class.
        /// </summary>
        /// <param name="timezone">timezone.</param>
        /// <param name="homeCountry">homeCountry.</param>
        /// <param name="language">language.</param>
        /// <param name="greetingLanguage">greetingLanguage.</param>
        /// <param name="formattingLocale">formattingLocale.</param>
        /// <param name="timeFormat">timeFormat.</param>
        /// <param name="currency">currency.</param>
        public RolesRegionalSettingsResource(RolesTimezoneResource timezone = default(RolesTimezoneResource), RolesCountryResource homeCountry = default(RolesCountryResource), RolesLanguageResource language = default(RolesLanguageResource), RolesLanguageResource greetingLanguage = default(RolesLanguageResource), RolesLanguageResource formattingLocale = default(RolesLanguageResource), TimeFormatEnum? timeFormat = default(TimeFormatEnum?), CurrencyResource currency = default(CurrencyResource))
        {
            this.Timezone = timezone;
            this.HomeCountry = homeCountry;
            this.Language = language;
            this.GreetingLanguage = greetingLanguage;
            this.FormattingLocale = formattingLocale;
            this.TimeFormat = timeFormat;
            this.Currency = currency;
        }

        /// <summary>
        /// Gets or Sets Timezone
        /// </summary>
        [DataMember(Name="timezone", EmitDefaultValue=false)]
        public RolesTimezoneResource Timezone { get; set; }

        /// <summary>
        /// Gets or Sets HomeCountry
        /// </summary>
        [DataMember(Name="homeCountry", EmitDefaultValue=false)]
        public RolesCountryResource HomeCountry { get; set; }

        /// <summary>
        /// Gets or Sets Language
        /// </summary>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public RolesLanguageResource Language { get; set; }

        /// <summary>
        /// Gets or Sets GreetingLanguage
        /// </summary>
        [DataMember(Name="greetingLanguage", EmitDefaultValue=false)]
        public RolesLanguageResource GreetingLanguage { get; set; }

        /// <summary>
        /// Gets or Sets FormattingLocale
        /// </summary>
        [DataMember(Name="formattingLocale", EmitDefaultValue=false)]
        public RolesLanguageResource FormattingLocale { get; set; }


        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public CurrencyResource Currency { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RolesRegionalSettingsResource {\n");
            sb.Append("  Timezone: ").Append(Timezone).Append("\n");
            sb.Append("  HomeCountry: ").Append(HomeCountry).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  GreetingLanguage: ").Append(GreetingLanguage).Append("\n");
            sb.Append("  FormattingLocale: ").Append(FormattingLocale).Append("\n");
            sb.Append("  TimeFormat: ").Append(TimeFormat).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
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
            return this.Equals(input as RolesRegionalSettingsResource);
        }

        /// <summary>
        /// Returns true if RolesRegionalSettingsResource instances are equal
        /// </summary>
        /// <param name="input">Instance of RolesRegionalSettingsResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RolesRegionalSettingsResource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Timezone == input.Timezone ||
                    (this.Timezone != null &&
                    this.Timezone.Equals(input.Timezone))
                ) && 
                (
                    this.HomeCountry == input.HomeCountry ||
                    (this.HomeCountry != null &&
                    this.HomeCountry.Equals(input.HomeCountry))
                ) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && 
                (
                    this.GreetingLanguage == input.GreetingLanguage ||
                    (this.GreetingLanguage != null &&
                    this.GreetingLanguage.Equals(input.GreetingLanguage))
                ) && 
                (
                    this.FormattingLocale == input.FormattingLocale ||
                    (this.FormattingLocale != null &&
                    this.FormattingLocale.Equals(input.FormattingLocale))
                ) && 
                (
                    this.TimeFormat == input.TimeFormat ||
                    (this.TimeFormat != null &&
                    this.TimeFormat.Equals(input.TimeFormat))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
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
                if (this.Timezone != null)
                    hashCode = hashCode * 59 + this.Timezone.GetHashCode();
                if (this.HomeCountry != null)
                    hashCode = hashCode * 59 + this.HomeCountry.GetHashCode();
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.GreetingLanguage != null)
                    hashCode = hashCode * 59 + this.GreetingLanguage.GetHashCode();
                if (this.FormattingLocale != null)
                    hashCode = hashCode * 59 + this.FormattingLocale.GetHashCode();
                if (this.TimeFormat != null)
                    hashCode = hashCode * 59 + this.TimeFormat.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
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