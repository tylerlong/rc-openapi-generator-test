
# Org.OpenAPITools.Model.QueueInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TransferMode** | **string** | Specifies how calls are transferred to group members | [optional] 
**Transfer** | [**List&lt;TransferInfo&gt;**](TransferInfo.md) | Call transfer information | [optional] 
**NoAnswerAction** | **string** | Specifies the type of action to be taken if: members are available but no one answers, or all members are busy/unavailable. This option is available for Business hours only. For simultaneous transfer mode only &#39;WaitPrimaryMembers&#39; and &#39;WaitPrimaryAndOverflowMembers&#39; are supported | [optional] 
**FixedOrderAgents** | [**List&lt;FixedOrderAgents&gt;**](FixedOrderAgents.md) | Information on a call forwarding rule | [optional] 
**HoldAudioInterruptionMode** | **string** | Connecting audio interruption mode | [optional] 
**HoldAudioInterruptionPeriod** | **int** | Connecting audio interruption message period in seconds | [optional] 
**HoldTimeExpirationAction** | **string** | Specifies the type of action to be taken after the hold time (waiting for an available call queue member) expires. If &#39;TransferToExtension&#39; option is selected, the extension specified in &#x60;transfer&#x60; field is used. The default value is &#x60;Voicemail&#x60; | [optional] [default to HoldTimeExpirationActionEnum.Voicemail]
**AgentTimeout** | **int** | Maximum time in seconds to wait for a call queue member before trying the next member | [optional] 
**WrapUpTime** | **int** | Minimum post-call wrap up time in seconds before agent status is automatically set; the value range is from 180 to 300 | [optional] 
**HoldTime** | **int** | Maximum hold time in seconds to wait for an available call queue member | [optional] 
**MaxCallers** | **int** | Maximum count of callers on hold; the limitation is 25 callers | [optional] 
**MaxCallersAction** | **string** | Specifies the type of action to be taken if count of callers on hold exceeds the supported maximum | [optional] 
**UnconditionalForwarding** | [**List&lt;UnconditionalForwardingInfo&gt;**](UnconditionalForwardingInfo.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

