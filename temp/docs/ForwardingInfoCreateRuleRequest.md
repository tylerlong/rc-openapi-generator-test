
# Org.OpenAPITools.Model.ForwardingInfoCreateRuleRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NotifyMySoftPhones** | **bool** | Specifies if the first ring on desktop/mobile apps is enabled. The default value is &#39;True&#39; | [optional] 
**NotifyAdminSoftPhones** | **bool** | Deprecated parameter. Specifies if the administrator&#39;s softphone (desktop application) is notified before forwarding the incoming call to desk phones and forwarding numbers. The default value is &#39;True&#39;. | [optional] 
**SoftPhonesRingCount** | **int** | Specifies delay between ring on apps and starting of a call forwarding. To activate this parameter use the value &gt; 0, and turn off the &#x60;softPhonesAlwaysRing&#x60; setting. If the value is 1 or 0, the &#x60;softPhonesAlwaysRing&#x60; setting cannot be turned off | [optional] 
**SoftPhonesAlwaysRing** | **bool** | Specifies that desktop and mobile applications of the user will ring till the end of their forwarding list. If set to &#39;True&#39; then &#x60;softPhonesRingCount&#x60; is ignored | [optional] [default to true]
**RingingMode** | **string** | Specifies the order in which forwarding numbers ring. &#39;Sequentially&#39; means that forwarding numbers are ringing one at a time, in order of priority. &#39;Simultaneously&#39; means that forwarding numbers are ringing all at the same time. The default value is &#39;Sequentially&#39; | [optional] 
**Rules** | [**List&lt;RuleInfoCreateRuleRequest&gt;**](RuleInfoCreateRuleRequest.md) | Information on a call forwarding rule | [optional] 
**MobileTimeout** | **bool** | Deprecated parameter. Specifies if mobile timeout is activated for the rule | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

