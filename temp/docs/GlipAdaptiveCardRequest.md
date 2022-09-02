
# Org.OpenAPITools.Model.GlipAdaptiveCardRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Type of atttachment. This field is mandatory and filled on server side - will be ignored if set in request body | 
**_Version** | **string** | Version. This field is mandatory and filled on server side - will be ignored if set in request body | 
**Body** | [**List&lt;AdaptiveCardInfoRequest&gt;**](AdaptiveCardInfoRequest.md) | List of adaptive cards with the detailed information | [optional] 
**Actions** | [**List&lt;AdaptiveCardAction&gt;**](AdaptiveCardAction.md) |  | [optional] 
**SelectAction** | [**AdaptiveCardSelectAction**](.md) |  | [optional] 
**FallbackText** | **string** |  | [optional] 
**BackgroundImage** | [**GlipAdaptiveCardRequestBackgroundImage**](GlipAdaptiveCardRequestBackgroundImage.md) |  | [optional] 
**MinHeight** | **string** | Specifies the minimum height of the card in pxls | [optional] 
**Speak** | **string** | Specifies what should be spoken for this entire card. This is simple text or SSML fragment | [optional] 
**Lang** | **string** | The 2-letter ISO-639-1 language used in the card. Used to localize any date/time functions | [optional] 
**VerticalContentAlignment** | [**VerticalContentAlignment**](.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

