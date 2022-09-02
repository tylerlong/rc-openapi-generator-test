
# Org.OpenAPITools.Model.ExtensionDeviceResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Internal identifier of a device | [optional] 
**Uri** | **string** | Canonical URI of a device | [optional] 
**Sku** | **string** | Device identification number (stock keeping unit) in the format TP-ID [-AT-AC], where TP is device type (HP for RC HardPhone, DV for all other devices including softphone); ID - device model ID; AT -addon type ID; AC - addon count (if any). For example &#39;HP-56-2-2&#39; | [optional] 
**Type** | **string** | Device type | [optional] [default to TypeEnum.HardPhone]
**Name** | **string** | Device name. Mandatory if ordering  SoftPhone  or  OtherPhone. Optional for  HardPhone. If not specified for HardPhone, then device model name is used as device name | [optional] 
**Status** | **string** | Device status | [optional] 
**Serial** | **string** | Serial number for HardPhone (is returned only when the phone is shipped and provisioned); endpoint_id for softphone and mobile applications | [optional] 
**ComputerName** | **string** | PC name for softphone | [optional] 
**Model** | [**ModelInfo**](ModelInfo.md) |  | [optional] 
**Extension** | [**ExtensionInfoIntId**](ExtensionInfoIntId.md) |  | [optional] 
**EmergencyServiceAddress** | [**EmergencyServiceAddressResource**](EmergencyServiceAddressResource.md) |  | [optional] 
**Emergency** | [**DeviceEmergencyInfo**](DeviceEmergencyInfo.md) |  | [optional] 
**PhoneLines** | [**List&lt;PhoneLinesInfo&gt;**](PhoneLinesInfo.md) | Phone lines information | [optional] 
**Shipping** | [**ShippingInfo**](ShippingInfo.md) |  | [optional] 
**BoxBillingId** | **long** | Box billing identifier of a device. Applicable only for HardPhones. It is an alternative way to identify the device to be ordered. Either model  structure, or  boxBillingId  must be specified for HardPhone | [optional] 
**UseAsCommonPhone** | **bool** | Supported only for devices assigned to Limited extensions. If true, enables users to log in to this phone as a common phone. | [optional] 
**LinePooling** | **string** | Pooling type of a deviceHost - device with standalone paid phone line which can be linked to Glip/Softphone instanceGuest - device with a linked phone lineNone - device without a phone line or with specific line (free, BLA, etc.) &#x3D; [&#39;Host&#39;, &#39;Guest&#39;, &#39;None&#39;] | [optional] 
**InCompanyNet** | **bool** | Network location status. &#39;True&#39; if the device is located in the configured corporate network (On-Net); &#39;False&#39; for Off-Net location. Parameter is not returned if &#x60;EmergencyAddressAutoUpdate&#x60; feature is not enabled for the account/user, or if device network location is not determined | [optional] 
**Site** | [**DeviceSiteInfo**](DeviceSiteInfo.md) |  | [optional] 
**LastLocationReportTime** | **string** | Datetime of receiving last location report in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format including timezone, for example *2016-03-10T18:07:52.534Z | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

