
# Org.OpenAPITools.Model.ForwardingInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NotifyMySoftPhones** | **bool** | Specifies if the user&#39;s softphone(s) are notified before forwarding the incoming call to desk phones and forwarding numbers | [optional] 
**NotifyAdminSoftPhones** | **bool** | Deprecated parameter. Specifies if the administrator&#39;s softphone is notified before forwarding the incoming call to desk phones and forwarding numbers. The default value is &#39;False&#39; | [optional] 
**SoftPhonesRingCount** | **int** | Number of rings before forwarding starts | [optional] 
**SoftPhonesAlwaysRing** | **bool** | Specifies that desktop and mobile applications of the user will ring till the end of their forwarding list. If set to &#39;True&#39; then &#x60;softPhonesRingCount&#x60; is ignored | [optional] [default to true]
**RingingMode** | **string** | Specifies the order in which the forwarding numbers ring. &#39;Sequentially&#39; means that forwarding numbers are ringing one at a time, in order of priority. &#39;Simultaneously&#39; means that forwarding numbers are ring all at the same time | [optional] 
**Rules** | [**List&lt;RuleInfo&gt;**](RuleInfo.md) | Information on a call forwarding rule | [optional] 
**SoftPhonesPositionTop** | **bool** | Specifies if desktop and mobile applications of the user are notified before (true) or after (false) forwarding the incoming call to desk phones and forwarding numbers. Applicable only if &#x60;notifyMySoftPhones&#x60; parameter is set to &#x60;true&#x60; | [optional] 
**MobileTimeout** | **bool** | Deprecated parameter. Specifies if mobile timeout is activated for the rule | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

