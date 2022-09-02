
# Org.OpenAPITools.Model.ExtensionCallerIdInfoRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Uri** | **string** | Canonical URL of a caller ID resource | [optional] 
**ByDevice** | [**List&lt;CallerIdByDeviceRequest&gt;**](CallerIdByDeviceRequest.md) |  | [optional] 
**ByFeature** | [**List&lt;CallerIdByFeatureRequest&gt;**](CallerIdByFeatureRequest.md) |  | [optional] 
**ExtensionNameForOutboundCalls** | **bool** | If &#39;True&#39;, then user first name and last name will be used as caller ID when making outbound calls from extension | [optional] 
**ExtensionNumberForInternalCalls** | **bool** | If &#39;True&#39;, then extension number will be used as caller ID when making internal calls | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

