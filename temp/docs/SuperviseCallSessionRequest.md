
# Org.OpenAPITools.Model.SuperviseCallSessionRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Mode** | **string** | Supervising mode | 
**SupervisorDeviceId** | **string** | Internal identifier of a supervisor&#39;s device which will be used for call session monitoring | 
**AgentExtensionId** | **string** | Extension identifier of the user that will be monitored | [optional] 
**AutoAnswer** | **bool** | Specifies if auto-answer SIP header should be sent. If auto-answer is set to &#39;True&#39;, the call is automatically answered by the supervising party, if set to &#39;False&#39; - then the supervising party has to accept or decline the monitored call | [optional] [default to true]
**MediaSDP** | **string** | Specifies session description protocol setting | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

