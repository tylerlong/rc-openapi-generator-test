
# Org.OpenAPITools.Model.SubscriptionInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Uri** | **string** | Canonical URI of a subscription resource | [readonly] 
**Id** | **string** | Internal identifier of a subscription | [readonly] 
**EventFilters** | **List&lt;string&gt;** | The list of event filter names corresponding to events the user is subscribed to | 
**DisabledFilters** | [**List&lt;DisabledFilterInfo&gt;**](DisabledFilterInfo.md) | The list of event filter names corresponding to events the user is not subscribed to due to certain limitations | [optional] [readonly] 
**ExpirationTime** | **DateTime** | Subscription expiration datetime in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format including timezone, for example *2016-03-10T18:07:52.534Z* | [readonly] 
**ExpiresIn** | **int** | Subscription lifetime in seconds | [optional] 
**Status** | **string** | Subscription status | [readonly] 
**CreationTime** | **DateTime** | Subscription creation datetime in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format including timezone, for example *2016-03-10T18:07:52.534* | [readonly] 
**DeliveryMode** | [**NotificationDeliveryMode**](NotificationDeliveryMode.md) |  | 
**BlacklistedData** | [**SubscriptionInfoBlacklistedData**](SubscriptionInfoBlacklistedData.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

