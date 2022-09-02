
# Org.OpenAPITools.Model.CreateSubscriptionRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EventFilters** | **List&lt;string&gt;** | The list of event filter names corresponding to events the user is subscribed to | 
**DeliveryMode** | [**NotificationDeliveryMode**](NotificationDeliveryMode.md) |  | 
**ExpiresIn** | **int** | Subscription lifetime in seconds. For \&quot;WebHook\&quot; transport type max value might be set up to 315360000 seconds (10 years). For \&quot;RC/APNS\&quot; and \&quot;RC/GSM\&quot; transport types max subscription lifetime is 7776000 seconds (90 days). For \&quot;PubNub\&quot; transport type the max value is 900 seconds (15 minutes)  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

