
# Org.OpenAPITools.Model.PartySuperviseRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Mode** | **string** | Supervising mode | 
**SupervisorDeviceId** | **string** | Internal identifier of a supervisor&#39;s device | 
**AgentExtensionId** | **string** | Mailbox ID of a user that will be monitored | 
**AutoAnswer** | **bool** | Specifies if auto-answer SIP header should be sent. If auto-answer is set to &#39;True&#39;, the call is automatically answered by the supervising party, if set to &#39;False&#39; - then the supervising party has to accept or decline the monitored call | [optional] [default to true]
**MediaSDP** | **string** | Specifies session description protocol (SDP) setting. The possible values are &#39;sendOnly&#39; (only sending) meaning one-way audio streaming; and &#39;sendRecv&#39; (sending/receiving) meaning two-way audio streaming | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

