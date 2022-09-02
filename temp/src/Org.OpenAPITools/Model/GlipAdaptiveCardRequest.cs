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
    /// GlipAdaptiveCardRequest
    /// </summary>
    [DataContract]
    public partial class GlipAdaptiveCardRequest :  IEquatable<GlipAdaptiveCardRequest>, IValidatableObject
    {
        /// <summary>
        /// Type of atttachment. This field is mandatory and filled on server side - will be ignored if set in request body
        /// </summary>
        /// <value>Type of atttachment. This field is mandatory and filled on server side - will be ignored if set in request body</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum AdaptiveCard for value: AdaptiveCard
            /// </summary>
            [EnumMember(Value = "AdaptiveCard")]
            AdaptiveCard = 1

        }

        /// <summary>
        /// Type of atttachment. This field is mandatory and filled on server side - will be ignored if set in request body
        /// </summary>
        /// <value>Type of atttachment. This field is mandatory and filled on server side - will be ignored if set in request body</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// The 2-letter ISO-639-1 language used in the card. Used to localize any date/time functions
        /// </summary>
        /// <value>The 2-letter ISO-639-1 language used in the card. Used to localize any date/time functions</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LangEnum
        {
            /// <summary>
            /// Enum En for value: en
            /// </summary>
            [EnumMember(Value = "en")]
            En = 1,

            /// <summary>
            /// Enum Fr for value: fr
            /// </summary>
            [EnumMember(Value = "fr")]
            Fr = 2,

            /// <summary>
            /// Enum Es for value: es
            /// </summary>
            [EnumMember(Value = "es")]
            Es = 3

        }

        /// <summary>
        /// The 2-letter ISO-639-1 language used in the card. Used to localize any date/time functions
        /// </summary>
        /// <value>The 2-letter ISO-639-1 language used in the card. Used to localize any date/time functions</value>
        [DataMember(Name="lang", EmitDefaultValue=false)]
        public LangEnum? Lang { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GlipAdaptiveCardRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GlipAdaptiveCardRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GlipAdaptiveCardRequest" /> class.
        /// </summary>
        /// <param name="type">Type of atttachment. This field is mandatory and filled on server side - will be ignored if set in request body (required).</param>
        /// <param name="version">Version. This field is mandatory and filled on server side - will be ignored if set in request body (required).</param>
        /// <param name="body">List of adaptive cards with the detailed information.</param>
        /// <param name="actions">actions.</param>
        /// <param name="selectAction">selectAction.</param>
        /// <param name="fallbackText">fallbackText.</param>
        /// <param name="backgroundImage">backgroundImage.</param>
        /// <param name="minHeight">Specifies the minimum height of the card in pxls.</param>
        /// <param name="speak">Specifies what should be spoken for this entire card. This is simple text or SSML fragment.</param>
        /// <param name="lang">The 2-letter ISO-639-1 language used in the card. Used to localize any date/time functions.</param>
        /// <param name="verticalContentAlignment">verticalContentAlignment.</param>
        public GlipAdaptiveCardRequest(TypeEnum type = default(TypeEnum), string version = default(string), List<AdaptiveCardInfoRequest> body = default(List<AdaptiveCardInfoRequest>), List<AdaptiveCardAction> actions = default(List<AdaptiveCardAction>), AdaptiveCardSelectAction selectAction = default(AdaptiveCardSelectAction), string fallbackText = default(string), GlipAdaptiveCardRequestBackgroundImage backgroundImage = default(GlipAdaptiveCardRequestBackgroundImage), string minHeight = default(string), string speak = default(string), LangEnum? lang = default(LangEnum?), VerticalContentAlignment verticalContentAlignment = default(VerticalContentAlignment))
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for GlipAdaptiveCardRequest and cannot be null");
            }
            else
            {
                this.Type = type;
            }

            // to ensure "version" is required (not null)
            if (version == null)
            {
                throw new InvalidDataException("version is a required property for GlipAdaptiveCardRequest and cannot be null");
            }
            else
            {
                this._Version = version;
            }

            this.Body = body;
            this.Actions = actions;
            this.SelectAction = selectAction;
            this.FallbackText = fallbackText;
            this.BackgroundImage = backgroundImage;
            this.MinHeight = minHeight;
            this.Speak = speak;
            this.Lang = lang;
            this.VerticalContentAlignment = verticalContentAlignment;
        }


        /// <summary>
        /// Version. This field is mandatory and filled on server side - will be ignored if set in request body
        /// </summary>
        /// <value>Version. This field is mandatory and filled on server side - will be ignored if set in request body</value>
        [DataMember(Name="version", EmitDefaultValue=true)]
        public string _Version { get; set; }

        /// <summary>
        /// List of adaptive cards with the detailed information
        /// </summary>
        /// <value>List of adaptive cards with the detailed information</value>
        [DataMember(Name="body", EmitDefaultValue=false)]
        public List<AdaptiveCardInfoRequest> Body { get; set; }

        /// <summary>
        /// Gets or Sets Actions
        /// </summary>
        [DataMember(Name="actions", EmitDefaultValue=false)]
        public List<AdaptiveCardAction> Actions { get; set; }

        /// <summary>
        /// Gets or Sets SelectAction
        /// </summary>
        [DataMember(Name="selectAction", EmitDefaultValue=false)]
        public AdaptiveCardSelectAction SelectAction { get; set; }

        /// <summary>
        /// Gets or Sets FallbackText
        /// </summary>
        [DataMember(Name="fallbackText", EmitDefaultValue=false)]
        public string FallbackText { get; set; }

        /// <summary>
        /// Gets or Sets BackgroundImage
        /// </summary>
        [DataMember(Name="backgroundImage", EmitDefaultValue=false)]
        public GlipAdaptiveCardRequestBackgroundImage BackgroundImage { get; set; }

        /// <summary>
        /// Specifies the minimum height of the card in pxls
        /// </summary>
        /// <value>Specifies the minimum height of the card in pxls</value>
        [DataMember(Name="minHeight", EmitDefaultValue=false)]
        public string MinHeight { get; set; }

        /// <summary>
        /// Specifies what should be spoken for this entire card. This is simple text or SSML fragment
        /// </summary>
        /// <value>Specifies what should be spoken for this entire card. This is simple text or SSML fragment</value>
        [DataMember(Name="speak", EmitDefaultValue=false)]
        public string Speak { get; set; }


        /// <summary>
        /// Gets or Sets VerticalContentAlignment
        /// </summary>
        [DataMember(Name="verticalContentAlignment", EmitDefaultValue=false)]
        public VerticalContentAlignment VerticalContentAlignment { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GlipAdaptiveCardRequest {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  Actions: ").Append(Actions).Append("\n");
            sb.Append("  SelectAction: ").Append(SelectAction).Append("\n");
            sb.Append("  FallbackText: ").Append(FallbackText).Append("\n");
            sb.Append("  BackgroundImage: ").Append(BackgroundImage).Append("\n");
            sb.Append("  MinHeight: ").Append(MinHeight).Append("\n");
            sb.Append("  Speak: ").Append(Speak).Append("\n");
            sb.Append("  Lang: ").Append(Lang).Append("\n");
            sb.Append("  VerticalContentAlignment: ").Append(VerticalContentAlignment).Append("\n");
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
            return this.Equals(input as GlipAdaptiveCardRequest);
        }

        /// <summary>
        /// Returns true if GlipAdaptiveCardRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GlipAdaptiveCardRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GlipAdaptiveCardRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this._Version == input._Version ||
                    (this._Version != null &&
                    this._Version.Equals(input._Version))
                ) && 
                (
                    this.Body == input.Body ||
                    this.Body != null &&
                    input.Body != null &&
                    this.Body.SequenceEqual(input.Body)
                ) && 
                (
                    this.Actions == input.Actions ||
                    this.Actions != null &&
                    input.Actions != null &&
                    this.Actions.SequenceEqual(input.Actions)
                ) && 
                (
                    this.SelectAction == input.SelectAction ||
                    (this.SelectAction != null &&
                    this.SelectAction.Equals(input.SelectAction))
                ) && 
                (
                    this.FallbackText == input.FallbackText ||
                    (this.FallbackText != null &&
                    this.FallbackText.Equals(input.FallbackText))
                ) && 
                (
                    this.BackgroundImage == input.BackgroundImage ||
                    (this.BackgroundImage != null &&
                    this.BackgroundImage.Equals(input.BackgroundImage))
                ) && 
                (
                    this.MinHeight == input.MinHeight ||
                    (this.MinHeight != null &&
                    this.MinHeight.Equals(input.MinHeight))
                ) && 
                (
                    this.Speak == input.Speak ||
                    (this.Speak != null &&
                    this.Speak.Equals(input.Speak))
                ) && 
                (
                    this.Lang == input.Lang ||
                    (this.Lang != null &&
                    this.Lang.Equals(input.Lang))
                ) && 
                (
                    this.VerticalContentAlignment == input.VerticalContentAlignment ||
                    (this.VerticalContentAlignment != null &&
                    this.VerticalContentAlignment.Equals(input.VerticalContentAlignment))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this._Version != null)
                    hashCode = hashCode * 59 + this._Version.GetHashCode();
                if (this.Body != null)
                    hashCode = hashCode * 59 + this.Body.GetHashCode();
                if (this.Actions != null)
                    hashCode = hashCode * 59 + this.Actions.GetHashCode();
                if (this.SelectAction != null)
                    hashCode = hashCode * 59 + this.SelectAction.GetHashCode();
                if (this.FallbackText != null)
                    hashCode = hashCode * 59 + this.FallbackText.GetHashCode();
                if (this.BackgroundImage != null)
                    hashCode = hashCode * 59 + this.BackgroundImage.GetHashCode();
                if (this.MinHeight != null)
                    hashCode = hashCode * 59 + this.MinHeight.GetHashCode();
                if (this.Speak != null)
                    hashCode = hashCode * 59 + this.Speak.GetHashCode();
                if (this.Lang != null)
                    hashCode = hashCode * 59 + this.Lang.GetHashCode();
                if (this.VerticalContentAlignment != null)
                    hashCode = hashCode * 59 + this.VerticalContentAlignment.GetHashCode();
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