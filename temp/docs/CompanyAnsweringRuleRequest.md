
# Org.OpenAPITools.Model.CompanyAnsweringRuleRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of an answering rule specified by user. Max number of symbols is 30. The default value is &#39;My Rule N&#39; where &#39;N&#39; is the first free number | [optional] 
**Enabled** | **bool** | Specifies if the rule is active or inactive. The default value is &#39;True&#39; | [optional] [default to true]
**Type** | **string** | Type of an answering rule, the default value is &#39;Custom&#39; &#x3D; [&#39;BusinessHours&#39;, &#39;AfterHours&#39;, &#39;Custom&#39;] | [optional] 
**Callers** | [**List&lt;CompanyAnsweringRuleCallersInfoRequest&gt;**](CompanyAnsweringRuleCallersInfoRequest.md) | Answering rule will be applied when calls are received from the specified caller(s) | [optional] 
**CalledNumbers** | [**List&lt;CompanyAnsweringRuleCalledNumberInfo&gt;**](CompanyAnsweringRuleCalledNumberInfo.md) | Answering rule will be applied when calling the specified number(s) | [optional] 
**Schedule** | [**CompanyAnsweringRuleScheduleInfoRequest**](CompanyAnsweringRuleScheduleInfoRequest.md) |  | [optional] 
**CallHandlingAction** | **string** | Specifies how incoming calls are forwarded. The default value is &#39;Operator&#39; &#39;Operator&#39; - play company greeting and forward to operator extension &#39;Disconnect&#39; - play company greeting and disconnect &#39;Bypass&#39; - bypass greeting to go to selected extension &#x3D; [&#39;Operator&#39;, &#39;Disconnect&#39;, &#39;Bypass&#39;] | [optional] 
**Extension** | **string** | Extension to which the call is forwarded in &#39;Bypass&#39; mode | [optional] 
**Greetings** | [**List&lt;GreetingInfo&gt;**](GreetingInfo.md) | Greetings applied for an answering rule; only predefined greetings can be applied, see Dictionary Greeting List | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

