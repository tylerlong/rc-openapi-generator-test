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
    /// GlipAdaptiveCardInfo
    /// </summary>
    [DataContract]
    public partial class GlipAdaptiveCardInfo :  IEquatable<GlipAdaptiveCardInfo>, IValidatableObject
    {
        /// <summary>
        /// Defines Type
        /// </summary>
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
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
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
        /// Initializes a new instance of the <see cref="GlipAdaptiveCardInfo" /> class.
        /// </summary>
        /// <param name="id">Internal identifier of an adaptive card.</param>
        /// <param name="creationTime">Adaptive Card creation datetime in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format.</param>
        /// <param name="lastModifiedTime">Post last modification datetime in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format.</param>
        /// <param name="schema">Schema of an adaptive card.</param>
        /// <param name="type">type.</param>
        /// <param name="version">Version of an adaptive card.</param>
        /// <param name="creator">creator.</param>
        /// <param name="chatIds">Chat IDs where an adaptive card is posted or shared..</param>
        /// <param name="body">List of card elements to show in the primary card region.</param>
        /// <param name="actions">actions.</param>
        /// <param name="selectAction">selectAction.</param>
        /// <param name="fallbackText">Text shown when the client doesn&#39;t support the version specified (may contain markdown).</param>
        /// <param name="backgroundImage">backgroundImage.</param>
        /// <param name="minHeight">Specifies the minimum height of the card in pxls.</param>
        /// <param name="speak">Specifies what should be spoken for this entire card. This is simple text or SSML fragment.</param>
        /// <param name="lang">The 2-letter ISO-639-1 language used in the card. Used to localize any date/time functions.</param>
        /// <param name="verticalContentAlignment">verticalContentAlignment.</param>
        public GlipAdaptiveCardInfo(string id = default(string), DateTime creationTime = default(DateTime), DateTime lastModifiedTime = default(DateTime), string schema = default(string), TypeEnum? type = default(TypeEnum?), string version = default(string), AdaptiveCardCreator creator = default(AdaptiveCardCreator), List<string> chatIds = default(List<string>), List<AdaptiveCardInfoRequest> body = default(List<AdaptiveCardInfoRequest>), List<AdaptiveCardAction> actions = default(List<AdaptiveCardAction>), AdaptiveCardSelectAction selectAction = default(AdaptiveCardSelectAction), string fallbackText = default(string), GlipAdaptiveCardInfoBackgroundImage backgroundImage = default(GlipAdaptiveCardInfoBackgroundImage), string minHeight = default(string), string speak = default(string), LangEnum? lang = default(LangEnum?), VerticalContentAlignment verticalContentAlignment = default(VerticalContentAlignment))
        {
            this.Id = id;
            this.CreationTime = creationTime;
            this.LastModifiedTime = lastModifiedTime;
            this.Schema = schema;
            this.Type = type;
            this._Version = version;
            this.Creator = creator;
            this.ChatIds = chatIds;
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
        /// Internal identifier of an adaptive card
        /// </summary>
        /// <value>Internal identifier of an adaptive card</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Adaptive Card creation datetime in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format
        /// </summary>
        /// <value>Adaptive Card creation datetime in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format</value>
        [DataMember(Name="creationTime", EmitDefaultValue=false)]
        public DateTime CreationTime { get; set; }

        /// <summary>
        /// Post last modification datetime in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format
        /// </summary>
        /// <value>Post last modification datetime in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format</value>
        [DataMember(Name="lastModifiedTime", EmitDefaultValue=false)]
        public DateTime LastModifiedTime { get; set; }

        /// <summary>
        /// Schema of an adaptive card
        /// </summary>
        /// <value>Schema of an adaptive card</value>
        [DataMember(Name="$schema", EmitDefaultValue=false)]
        public string Schema { get; set; }


        /// <summary>
        /// Version of an adaptive card
        /// </summary>
        /// <value>Version of an adaptive card</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string _Version { get; set; }

        /// <summary>
        /// Gets or Sets Creator
        /// </summary>
        [DataMember(Name="creator", EmitDefaultValue=false)]
        public AdaptiveCardCreator Creator { get; set; }

        /// <summary>
        /// Chat IDs where an adaptive card is posted or shared.
        /// </summary>
        /// <value>Chat IDs where an adaptive card is posted or shared.</value>
        [DataMember(Name="chatIds", EmitDefaultValue=false)]
        public List<string> ChatIds { get; set; }

        /// <summary>
        /// List of card elements to show in the primary card region
        /// </summary>
        /// <value>List of card elements to show in the primary card region</value>
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
        /// Text shown when the client doesn&#39;t support the version specified (may contain markdown)
        /// </summary>
        /// <value>Text shown when the client doesn&#39;t support the version specified (may contain markdown)</value>
        [DataMember(Name="fallbackText", EmitDefaultValue=false)]
        public string FallbackText { get; set; }

        /// <summary>
        /// Gets or Sets BackgroundImage
        /// </summary>
        [DataMember(Name="backgroundImage", EmitDefaultValue=false)]
        public GlipAdaptiveCardInfoBackgroundImage BackgroundImage { get; set; }

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
            sb.Append("class GlipAdaptiveCardInfo {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreationTime: ").Append(CreationTime).Append("\n");
            sb.Append("  LastModifiedTime: ").Append(LastModifiedTime).Append("\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
            sb.Append("  Creator: ").Append(Creator).Append("\n");
            sb.Append("  ChatIds: ").Append(ChatIds).Append("\n");
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
            return this.Equals(input as GlipAdaptiveCardInfo);
        }

        /// <summary>
        /// Returns true if GlipAdaptiveCardInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of GlipAdaptiveCardInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GlipAdaptiveCardInfo input)
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
                    this.CreationTime == input.CreationTime ||
                    (this.CreationTime != null &&
                    this.CreationTime.Equals(input.CreationTime))
                ) && 
                (
                    this.LastModifiedTime == input.LastModifiedTime ||
                    (this.LastModifiedTime != null &&
                    this.LastModifiedTime.Equals(input.LastModifiedTime))
                ) && 
                (
                    this.Schema == input.Schema ||
                    (this.Schema != null &&
                    this.Schema.Equals(input.Schema))
                ) && 
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
                    this.Creator == input.Creator ||
                    (this.Creator != null &&
                    this.Creator.Equals(input.Creator))
                ) && 
                (
                    this.ChatIds == input.ChatIds ||
                    this.ChatIds != null &&
                    input.ChatIds != null &&
                    this.ChatIds.SequenceEqual(input.ChatIds)
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.CreationTime != null)
                    hashCode = hashCode * 59 + this.CreationTime.GetHashCode();
                if (this.LastModifiedTime != null)
                    hashCode = hashCode * 59 + this.LastModifiedTime.GetHashCode();
                if (this.Schema != null)
                    hashCode = hashCode * 59 + this.Schema.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this._Version != null)
                    hashCode = hashCode * 59 + this._Version.GetHashCode();
                if (this.Creator != null)
                    hashCode = hashCode * 59 + this.Creator.GetHashCode();
                if (this.ChatIds != null)
                    hashCode = hashCode * 59 + this.ChatIds.GetHashCode();
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
