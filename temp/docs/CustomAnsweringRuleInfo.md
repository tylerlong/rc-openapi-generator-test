
# Org.OpenAPITools.Model.CustomAnsweringRuleInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Uri** | **string** | Canonical URI to an answering rule resource | [optional] 
**Id** | **string** | Internal identifier of an answering rule | [optional] 
**Type** | **string** | Type of an answering rule | [optional] 
**Name** | **string** | Name of an answering rule specified by user | [optional] 
**Enabled** | **bool** | Specifies if an answering rule is active or inactive | [optional] 
**Schedule** | [**ScheduleInfo**](ScheduleInfo.md) |  | [optional] 
**CalledNumbers** | [**List&lt;CalledNumberInfo&gt;**](CalledNumberInfo.md) | Answering rules are applied when calling to selected number(s) | [optional] 
**Callers** | [**List&lt;CallersInfo&gt;**](CallersInfo.md) | Answering rules are applied when calls are received from specified caller(s) | [optional] 
**CallHandlingAction** | **string** | Specifies how incoming calls are forwarded | [optional] 
**Forwarding** | [**ForwardingInfo**](ForwardingInfo.md) |  | [optional] 
**UnconditionalForwarding** | [**UnconditionalForwardingInfo**](UnconditionalForwardingInfo.md) |  | [optional] 
**Queue** | [**QueueInfo**](QueueInfo.md) |  | [optional] 
**Transfer** | [**TransferredExtensionInfo**](TransferredExtensionInfo.md) |  | [optional] 
**Voicemail** | [**VoicemailInfo**](VoicemailInfo.md) |  | [optional] 
**Greetings** | [**List&lt;GreetingInfo&gt;**](GreetingInfo.md) | Greetings applied for an answering rule; only predefined greetings can be applied, see Dictionary Greeting List | [optional] 
**Screening** | **string** | Call screening status. &#39;Off&#39; - no call screening; &#39;NoCallerId&#39; - if caller ID is missing, then callers are asked to say their name before connecting; &#39;UnknownCallerId&#39; - if caller ID is not in contact list, then callers are asked to say their name before connecting; &#39;Always&#39; - the callers are always asked to say their name before connecting. The default value is &#39;Off&#39; | [optional] 
**SharedLines** | [**SharedLinesInfo**](SharedLinesInfo.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

