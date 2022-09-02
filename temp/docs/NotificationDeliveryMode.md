
# Org.OpenAPITools.Model.NotificationDeliveryMode

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TransportType** | **string** | Notifications transport name, e.g. \&quot;WebHook\&quot; | 
**Address** | **string** | For a \&quot;WebHook\&quot; transport - URL of a consumer service (cannot be changed during subscription update) | [optional] 
**Encryption** | **bool** | Optional parameter. Specifies if the message will be encrypted or not. If request contains any presence event filter the value by default is &#39;true&#39; (even if specified as &#39;false&#39;). If request contains only message event filters the value by default is &#39;false&#39;  | [optional] 
**CertificateName** | **string** | Certificate name (for \&quot;RC/APNS\&quot; and \&quot;RC/GCM\&quot; transport types only) | [optional] 
**RegistrationId** | **string** | Registration identifier (for \&quot;RC/APNS\&quot; and \&quot;RC/GCM\&quot; transport types only) | [optional] 
**VerificationToken** | **string** | Subscription verification token ensuring data security (For \&quot;Webhook\&quot; transport type only) | [optional] 
**SubscriberKey** | **string** | PubNub subscriber credentials required to subscribe to the channel (for \&quot;PubNub\&quot; transport type only) | [optional] [readonly] 
**SecretKey** | **string** | PubNub subscriber credentials required to subscribe to the channel (for \&quot;PubNub\&quot; transport type only) | [optional] [readonly] 
**EncryptionAlgorithm** | **string** | Encryption algorithm \&quot;AES\&quot; (for \&quot;PubNub\&quot; transport type only) | [optional] [readonly] 
**EncryptionKey** | **string** | Key for notification message decryption (for \&quot;PubNub\&quot; transport type only) | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

