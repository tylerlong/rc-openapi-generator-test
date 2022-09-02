# Org.OpenAPITools.Api.DevicesApi

All URIs are relative to *https://platform.ringcentral.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListExtensionDevices**](DevicesApi.md#listextensiondevices) | **GET** /restapi/v1.0/account/{accountId}/extension/{extensionId}/device | Get Extension Device List
[**ReadDevice**](DevicesApi.md#readdevice) | **GET** /restapi/v1.0/account/{accountId}/device/{deviceId} | Get Device
[**ReadDeviceSIPInfo**](DevicesApi.md#readdevicesipinfo) | **GET** /restapi/v1.0/account/{accountId}/device/{deviceId}/sip-info | Get Device SIP Info
[**UpdateDevice**](DevicesApi.md#updatedevice) | **PUT** /restapi/v1.0/account/{accountId}/device/{deviceId} | Update Device



## ListExtensionDevices

> GetExtensionDevicesResponse ListExtensionDevices (string accountId, string extensionId, string linePooling = null, string feature = null, string page = null, string perPage = null, string line = null, string lineType = null)

Get Extension Device List

Returns devices of the extension(s) by their ID(s). Batch request is supported

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListExtensionDevicesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DevicesApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")
            var linePooling = "Host";  // string | Pooling type of a device (optional) 
            var feature = "Intercom";  // string | Device feature or multiple features supported (optional) 
            var page = "\"1\"";  // string | Number of a page to be returned (optional)  (default to "1")
            var perPage = "\"100\"";  // string | Number of records per page to be returned (optional)  (default to "100")
            var line = "Room";  // string | Device type (optional)  (default to HardPhone)
            var lineType = "Standalone";  // string | Type of phone line (optional) 

            try
            {
                // Get Extension Device List
                GetExtensionDevicesResponse result = apiInstance.ListExtensionDevices(accountId, extensionId, linePooling, feature, page, perPage, line, lineType);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DevicesApi.ListExtensionDevices: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session | [default to &quot;~&quot;]
 **extensionId** | **string**| Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session | [default to &quot;~&quot;]
 **linePooling** | **string**| Pooling type of a device | [optional] 
 **feature** | **string**| Device feature or multiple features supported | [optional] 
 **page** | **string**| Number of a page to be returned | [optional] [default to &quot;1&quot;]
 **perPage** | **string**| Number of records per page to be returned | [optional] [default to &quot;100&quot;]
 **line** | **string**| Device type | [optional] [default to HardPhone]
 **lineType** | **string**| Type of phone line | [optional] 

### Return type

[**GetExtensionDevicesResponse**](GetExtensionDevicesResponse.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | Success |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ReadDevice

> GetDeviceInfoResponse ReadDevice (string accountId, long deviceId, bool? syncEmergencyAddress = null)

Get Device

Returns account device(s) by their ID(s).

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadDeviceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DevicesApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var deviceId = 789L;  // long | Internal identifier of a device
            var syncEmergencyAddress = false;  // bool? | Specifies if emergency address should be synchronized or not (optional)  (default to false)

            try
            {
                // Get Device
                GetDeviceInfoResponse result = apiInstance.ReadDevice(accountId, deviceId, syncEmergencyAddress);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DevicesApi.ReadDevice: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session | [default to &quot;~&quot;]
 **deviceId** | **long**| Internal identifier of a device | 
 **syncEmergencyAddress** | **bool?**| Specifies if emergency address should be synchronized or not | [optional] [default to false]

### Return type

[**GetDeviceInfoResponse**](GetDeviceInfoResponse.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | Account Device(s) Info |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ReadDeviceSIPInfo

> SipInfoResource ReadDeviceSIPInfo (string deviceId, string accountId)

Get Device SIP Info

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadDeviceSIPInfoExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DevicesApi(Configuration.Default);
            var deviceId = "deviceId_example";  // string | Internal identifier of a device
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")

            try
            {
                // Get Device SIP Info
                SipInfoResource result = apiInstance.ReadDeviceSIPInfo(deviceId, accountId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DevicesApi.ReadDeviceSIPInfo: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **deviceId** | **string**| Internal identifier of a device | 
 **accountId** | **string**| Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session | [default to &quot;~&quot;]

### Return type

[**SipInfoResource**](SipInfoResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Device SIP Information |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateDevice

> GetDeviceInfoResponse UpdateDevice (string deviceId, string accountId, bool? prestatement = null, AccountDeviceUpdate accountDeviceUpdate = null)

Update Device

Updates account device(s) by their ID(s).

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateDeviceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DevicesApi(Configuration.Default);
            var deviceId = "deviceId_example";  // string | 
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var prestatement = true;  // bool? |  (optional) 
            var accountDeviceUpdate = new AccountDeviceUpdate(); // AccountDeviceUpdate |  (optional) 

            try
            {
                // Update Device
                GetDeviceInfoResponse result = apiInstance.UpdateDevice(deviceId, accountId, prestatement, accountDeviceUpdate);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DevicesApi.UpdateDevice: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **deviceId** | **string**|  | 
 **accountId** | **string**| Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session | [default to &quot;~&quot;]
 **prestatement** | **bool?**|  | [optional] 
 **accountDeviceUpdate** | [**AccountDeviceUpdate**](AccountDeviceUpdate.md)|  | [optional] 

### Return type

[**GetDeviceInfoResponse**](GetDeviceInfoResponse.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | successful operation |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

