
# Org.OpenAPITools.Model.ShippingInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | Shipping status of the order item. It is set to &#39;Initial&#39; when the order is submitted. Then it is changed to &#39;Accepted&#39; when a distributor starts processing the order. Finally the status is changed to &#39;Shipped&#39; which means that distributor shipped the device. | [optional] 
**Carrier** | **string** | Shipping carrier name. Appears only if the device status is &#39;Shipped&#39; | [optional] 
**TrackingNumber** | **string** | Carrier-specific tracking number. Appears only if the device status is &#39;Shipped&#39; | [optional] 
**Method** | [**MethodInfo**](MethodInfo.md) |  | [optional] 
**Address** | [**ShippingAddressInfo**](ShippingAddressInfo.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

