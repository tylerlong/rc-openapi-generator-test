
# Org.OpenAPITools.Model.ListCompanyAnsweringRuleInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Internal identifier of an answering rule | [optional] 
**Uri** | **string** | Canonical URI of an answering rule | [optional] 
**Enabled** | **bool** | Specifies if the rule is active or inactive. The default value is &#39;True&#39; | [optional] [default to true]
**Type** | **string** | Type of an answering rule, the default value is &#39;Custom&#39; &#x3D; [&#39;BusinessHours&#39;, &#39;AfterHours&#39;, &#39;Custom&#39;] | [optional] 
**Name** | **string** | Name of an answering rule specified by user. Max number of symbols is 30. The default value is &#39;My Rule N&#39; where &#39;N&#39; is the first free number | [optional] 
**CalledNumbers** | [**List&lt;CalledNumberInfo&gt;**](CalledNumberInfo.md) | Answering rules are applied when calling to selected number(s) | [optional] 
**Extension** | [**CompanyAnsweringRuleExtensionInfo**](CompanyAnsweringRuleExtensionInfo.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

