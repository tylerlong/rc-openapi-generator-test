
# Org.OpenAPITools.Model.GlipAdaptiveCardInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Internal identifier of an adaptive card | [optional] 
**CreationTime** | **DateTime** | Adaptive Card creation datetime in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format | [optional] 
**LastModifiedTime** | **DateTime** | Post last modification datetime in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format | [optional] 
**Schema** | **string** | Schema of an adaptive card | [optional] 
**Type** | **string** |  | [optional] 
**_Version** | **string** | Version of an adaptive card | [optional] 
**Creator** | [**AdaptiveCardCreator**](.md) |  | [optional] 
**ChatIds** | **List&lt;string&gt;** | Chat IDs where an adaptive card is posted or shared. | [optional] 
**Body** | [**List&lt;AdaptiveCardInfoRequest&gt;**](AdaptiveCardInfoRequest.md) | List of card elements to show in the primary card region | [optional] 
**Actions** | [**List&lt;AdaptiveCardAction&gt;**](AdaptiveCardAction.md) |  | [optional] 
**SelectAction** | [**AdaptiveCardSelectAction**](.md) |  | [optional] 
**FallbackText** | **string** | Text shown when the client doesn&#39;t support the version specified (may contain markdown) | [optional] 
**BackgroundImage** | [**GlipAdaptiveCardInfoBackgroundImage**](GlipAdaptiveCardInfoBackgroundImage.md) |  | [optional] 
**MinHeight** | **string** | Specifies the minimum height of the card in pxls | [optional] 
**Speak** | **string** | Specifies what should be spoken for this entire card. This is simple text or SSML fragment | [optional] 
**Lang** | **string** | The 2-letter ISO-639-1 language used in the card. Used to localize any date/time functions | [optional] 
**VerticalContentAlignment** | [**VerticalContentAlignment**](.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

