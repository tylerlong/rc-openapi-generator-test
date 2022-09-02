
# Org.OpenAPITools.Model.UpdateAnsweringRuleRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Identifier of an answering rule | [optional] 
**Forwarding** | [**ForwardingInfoCreateRuleRequest**](ForwardingInfoCreateRuleRequest.md) |  | [optional] 
**Enabled** | **bool** | Specifies if the rule is active or inactive. The default value is &#39;True&#39; | [optional] 
**Name** | **string** | Name of an answering rule specified by user | [optional] 
**Callers** | [**List&lt;CallersInfoRequest&gt;**](CallersInfoRequest.md) | Answering rule will be applied when calls are received from the specified caller(s) | [optional] 
**CalledNumbers** | [**List&lt;CalledNumberInfo&gt;**](CalledNumberInfo.md) | Answering rules are applied when calling to selected number(s) | [optional] 
**Schedule** | [**ScheduleInfo**](ScheduleInfo.md) |  | [optional] 
**CallHandlingAction** | **string** | Specifies how incoming calls are forwarded | [optional] 
**Type** | **string** | Type of an answering rule | [optional] 
**UnconditionalForwarding** | [**UnconditionalForwardingInfo**](UnconditionalForwardingInfo.md) |  | [optional] 
**Queue** | [**QueueInfo**](QueueInfo.md) |  | [optional] 
**Voicemail** | [**VoicemailInfo**](VoicemailInfo.md) |  | [optional] 
**MissedCall** | [**MissedCallInfo**](MissedCallInfo.md) |  | [optional] 
**Greetings** | [**List&lt;GreetingInfo&gt;**](GreetingInfo.md) | Greetings applied for an answering rule; only predefined greetings can be applied, see Dictionary Greeting List | [optional] 
**Screening** | **string** | Call screening status. &#39;Off&#39; - no call screening; &#39;NoCallerId&#39; - if caller ID is missing, then callers are asked to say their name before connecting; &#39;UnknownCallerId&#39; - if caller ID is not in contact list, then callers are asked to say their name before connecting; &#39;Always&#39; - the callers are always asked to say their name before connecting. The default value is &#39;Off&#39; | [optional] 
**ShowInactiveNumbers** | **bool** | Indicates whether inactive numbers should be returned or not | [optional] 
**Transfer** | [**TransferredExtensionInfo**](TransferredExtensionInfo.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

