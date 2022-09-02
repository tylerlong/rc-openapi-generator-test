# Org.OpenAPITools.Api.AutomaticLocationUpdatesApi

All URIs are relative to *https://platform.ringcentral.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AssignMultipleAutomaticLocationUpdatesUsers**](AutomaticLocationUpdatesApi.md#assignmultipleautomaticlocationupdatesusers) | **POST** /restapi/v1.0/account/{accountId}/emergency-address-auto-update/users/bulk-assign | Enable Automatic Location Updates for Users
[**AssignMultipleDevicesAutomaticLocationUpdates**](AutomaticLocationUpdatesApi.md#assignmultipledevicesautomaticlocationupdates) | **POST** /restapi/v1.0/account/{accountId}/emergency-address-auto-update/devices/bulk-assign | Enable Automatic Location Updates for Devices
[**CreateEmergencyLocation**](AutomaticLocationUpdatesApi.md#createemergencylocation) | **POST** /restapi/v1.0/account/{accountId}/emergency-locations | Add Emergency Location
[**CreateExtensionEmergencyLocation**](AutomaticLocationUpdatesApi.md#createextensionemergencylocation) | **POST** /restapi/v1.0/account/{accountId}/extension/{extensionId}/emergency-locations | Create User Emergency Location
[**CreateMultipleSwitches**](AutomaticLocationUpdatesApi.md#createmultipleswitches) | **POST** /restapi/v1.0/account/{accountId}/emergency-address-auto-update/switches-bulk-create | Create Multiple Switches
[**CreateMultipleWirelessPoints**](AutomaticLocationUpdatesApi.md#createmultiplewirelesspoints) | **POST** /restapi/v1.0/account/{accountId}/emergency-address-auto-update/wireless-points-bulk-create | Create Multiple Wireless Points
[**CreateNetwork**](AutomaticLocationUpdatesApi.md#createnetwork) | **POST** /restapi/v1.0/account/{accountId}/emergency-address-auto-update/networks | Create Network
[**CreateSwitch**](AutomaticLocationUpdatesApi.md#createswitch) | **POST** /restapi/v1.0/account/{accountId}/emergency-address-auto-update/switches | Create Switch
[**CreateWirelessPoint**](AutomaticLocationUpdatesApi.md#createwirelesspoint) | **POST** /restapi/v1.0/account/{accountId}/emergency-address-auto-update/wireless-points | Create Wireless Point
[**DeleteEmergencyLocation**](AutomaticLocationUpdatesApi.md#deleteemergencylocation) | **DELETE** /restapi/v1.0/account/{accountId}/emergency-locations/{locationId} | Delete Emergency Location
[**DeleteExtensionEmergencyLocation**](AutomaticLocationUpdatesApi.md#deleteextensionemergencylocation) | **DELETE** /restapi/v1.0/account/{accountId}/extension/{extensionId}/emergency-locations/{locationId} | Delete User Emergency Location
[**DeleteNetwork**](AutomaticLocationUpdatesApi.md#deletenetwork) | **DELETE** /restapi/v1.0/account/{accountId}/emergency-address-auto-update/networks/{networkId} | Delete Network
[**DeleteSwitch**](AutomaticLocationUpdatesApi.md#deleteswitch) | **DELETE** /restapi/v1.0/account/{accountId}/emergency-address-auto-update/switches/{switchId} | Delete Switch
[**DeleteWirelessPoint**](AutomaticLocationUpdatesApi.md#deletewirelesspoint) | **DELETE** /restapi/v1.0/account/{accountId}/emergency-address-auto-update/wireless-points/{pointId} | Delete Wireless Point
[**GetExtensionEmergencyLocation**](AutomaticLocationUpdatesApi.md#getextensionemergencylocation) | **GET** /restapi/v1.0/account/{accountId}/extension/{extensionId}/emergency-locations/{locationId} | Get User Emergency Location
[**GetExtensionEmergencyLocations**](AutomaticLocationUpdatesApi.md#getextensionemergencylocations) | **GET** /restapi/v1.0/account/{accountId}/extension/{extensionId}/emergency-locations | Get User Emergency Location List
[**ListAccountSwitches**](AutomaticLocationUpdatesApi.md#listaccountswitches) | **GET** /restapi/v1.0/account/{accountId}/emergency-address-auto-update/switches | Get Account Switch List
[**ListAutomaticLocationUpdatesUsers**](AutomaticLocationUpdatesApi.md#listautomaticlocationupdatesusers) | **GET** /restapi/v1.0/account/{accountId}/emergency-address-auto-update/users | Get User List
[**ListDevicesAutomaticLocationUpdates**](AutomaticLocationUpdatesApi.md#listdevicesautomaticlocationupdates) | **GET** /restapi/v1.0/account/{accountId}/emergency-address-auto-update/devices | Get Device List
[**ListEmergencyLocations**](AutomaticLocationUpdatesApi.md#listemergencylocations) | **GET** /restapi/v1.0/account/{accountId}/emergency-locations | Get Emergency Location List
[**ListNetworks**](AutomaticLocationUpdatesApi.md#listnetworks) | **GET** /restapi/v1.0/account/{accountId}/emergency-address-auto-update/networks | Get Network Map
[**ListWirelessPoints**](AutomaticLocationUpdatesApi.md#listwirelesspoints) | **GET** /restapi/v1.0/account/{accountId}/emergency-address-auto-update/wireless-points | Get Wireless Point List
[**ReadAutomaticLocationUpdatesTask**](AutomaticLocationUpdatesApi.md#readautomaticlocationupdatestask) | **GET** /restapi/v1.0/account/{accountId}/emergency-address-auto-update/tasks/{taskId} | Get Emergency Map Configuration Task
[**ReadEmergencyLocation**](AutomaticLocationUpdatesApi.md#reademergencylocation) | **GET** /restapi/v1.0/account/{accountId}/emergency-locations/{locationId} | Get Emergency Location
[**ReadNetwork**](AutomaticLocationUpdatesApi.md#readnetwork) | **GET** /restapi/v1.0/account/{accountId}/emergency-address-auto-update/networks/{networkId} | Get Network
[**ReadSwitch**](AutomaticLocationUpdatesApi.md#readswitch) | **GET** /restapi/v1.0/account/{accountId}/emergency-address-auto-update/switches/{switchId} | Get Switch
[**ReadWirelessPoint**](AutomaticLocationUpdatesApi.md#readwirelesspoint) | **GET** /restapi/v1.0/account/{accountId}/emergency-address-auto-update/wireless-points/{pointId} | Get Wireless Point
[**UpdateEmergencyLocation**](AutomaticLocationUpdatesApi.md#updateemergencylocation) | **PUT** /restapi/v1.0/account/{accountId}/emergency-locations/{locationId} | Update Emergency Location
[**UpdateExtensionEmergencyLocation**](AutomaticLocationUpdatesApi.md#updateextensionemergencylocation) | **PUT** /restapi/v1.0/account/{accountId}/extension/{extensionId}/emergency-locations/{locationId} | Update User Emergency Location
[**UpdateMultipleSwitches**](AutomaticLocationUpdatesApi.md#updatemultipleswitches) | **POST** /restapi/v1.0/account/{accountId}/emergency-address-auto-update/switches-bulk-update | Update Multiple Switches
[**UpdateMultipleWirelessPoints**](AutomaticLocationUpdatesApi.md#updatemultiplewirelesspoints) | **POST** /restapi/v1.0/account/{accountId}/emergency-address-auto-update/wireless-points-bulk-update | Update Multiple Wireless Points
[**UpdateNetwork**](AutomaticLocationUpdatesApi.md#updatenetwork) | **PUT** /restapi/v1.0/account/{accountId}/emergency-address-auto-update/networks/{networkId} | Update Network
[**UpdateSwitch**](AutomaticLocationUpdatesApi.md#updateswitch) | **PUT** /restapi/v1.0/account/{accountId}/emergency-address-auto-update/switches/{switchId} | Update Switch
[**UpdateWirelessPoint**](AutomaticLocationUpdatesApi.md#updatewirelesspoint) | **PUT** /restapi/v1.0/account/{accountId}/emergency-address-auto-update/wireless-points/{pointId} | Update Wireless Point
[**ValidateMultipleSwitches**](AutomaticLocationUpdatesApi.md#validatemultipleswitches) | **POST** /restapi/v1.0/account/{accountId}/emergency-address-auto-update/switches-bulk-validate | Validate Multiple Switches
[**ValidateMultipleWirelessPoints**](AutomaticLocationUpdatesApi.md#validatemultiplewirelesspoints) | **POST** /restapi/v1.0/account/{accountId}/emergency-address-auto-update/wireless-points-bulk-validate | Validate Multiple Wireless Points



## AssignMultipleAutomaticLocationUpdatesUsers

> void AssignMultipleAutomaticLocationUpdatesUsers (string accountId, BulkAssignAutomaticLocationUpdatesUsers bulkAssignAutomaticLocationUpdatesUsers = null)

Enable Automatic Location Updates for Users

Enables or disables Automatic Location Updates feature for multiple account users.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AssignMultipleAutomaticLocationUpdatesUsersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AutomaticLocationUpdatesApi(Configuration.Default);
            var accountId = "\"~\"";  // string |  (default to "~")
            var bulkAssignAutomaticLocationUpdatesUsers = new BulkAssignAutomaticLocationUpdatesUsers(); // BulkAssignAutomaticLocationUpdatesUsers |  (optional) 

            try
            {
                // Enable Automatic Location Updates for Users
                apiInstance.AssignMultipleAutomaticLocationUpdatesUsers(accountId, bulkAssignAutomaticLocationUpdatesUsers);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AutomaticLocationUpdatesApi.AssignMultipleAutomaticLocationUpdatesUsers: " + e.Message );
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
 **accountId** | **string**|  | [default to &quot;~&quot;]
 **bulkAssignAutomaticLocationUpdatesUsers** | [**BulkAssignAutomaticLocationUpdatesUsers**](BulkAssignAutomaticLocationUpdatesUsers.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## AssignMultipleDevicesAutomaticLocationUpdates

> void AssignMultipleDevicesAutomaticLocationUpdates (string accountId, AssignMultipleDevicesAutomaticLocationUpdates assignMultipleDevicesAutomaticLocationUpdates = null)

Enable Automatic Location Updates for Devices

Enables or disables Automatic Location Updates feature for the specified common phones.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AssignMultipleDevicesAutomaticLocationUpdatesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AutomaticLocationUpdatesApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var assignMultipleDevicesAutomaticLocationUpdates = new AssignMultipleDevicesAutomaticLocationUpdates(); // AssignMultipleDevicesAutomaticLocationUpdates |  (optional) 

            try
            {
                // Enable Automatic Location Updates for Devices
                apiInstance.AssignMultipleDevicesAutomaticLocationUpdates(accountId, assignMultipleDevicesAutomaticLocationUpdates);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AutomaticLocationUpdatesApi.AssignMultipleDevicesAutomaticLocationUpdates: " + e.Message );
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
 **assignMultipleDevicesAutomaticLocationUpdates** | [**AssignMultipleDevicesAutomaticLocationUpdates**](AssignMultipleDevicesAutomaticLocationUpdates.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CreateEmergencyLocation

> void CreateEmergencyLocation (string accountId, EmergencyLocationInfoRequest emergencyLocationInfoRequest)

Add Emergency Location

Creates a new emergency response location for the company.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateEmergencyLocationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AutomaticLocationUpdatesApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var emergencyLocationInfoRequest = new EmergencyLocationInfoRequest(); // EmergencyLocationInfoRequest | JSON body

            try
            {
                // Add Emergency Location
                apiInstance.CreateEmergencyLocation(accountId, emergencyLocationInfoRequest);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AutomaticLocationUpdatesApi.CreateEmergencyLocation: " + e.Message );
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
 **emergencyLocationInfoRequest** | [**EmergencyLocationInfoRequest**](EmergencyLocationInfoRequest.md)| JSON body | 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CreateExtensionEmergencyLocation

> EmergencyLocationInfo CreateExtensionEmergencyLocation (string accountId, string extensionId, CreateUserEmergencyLocationRequest createUserEmergencyLocationRequest)

Create User Emergency Location

Creates a personal emergency response location for the current user.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateExtensionEmergencyLocationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AutomaticLocationUpdatesApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")
            var createUserEmergencyLocationRequest = new CreateUserEmergencyLocationRequest(); // CreateUserEmergencyLocationRequest | 

            try
            {
                // Create User Emergency Location
                EmergencyLocationInfo result = apiInstance.CreateExtensionEmergencyLocation(accountId, extensionId, createUserEmergencyLocationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AutomaticLocationUpdatesApi.CreateExtensionEmergencyLocation: " + e.Message );
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
 **createUserEmergencyLocationRequest** | [**CreateUserEmergencyLocationRequest**](CreateUserEmergencyLocationRequest.md)|  | 

### Return type

[**EmergencyLocationInfo**](EmergencyLocationInfo.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Emergency Location Information |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CreateMultipleSwitches

> CreateMultipleSwitchesResponse CreateMultipleSwitches (string accountId, CreateMultipleSwitchesRequest createMultipleSwitchesRequest)

Create Multiple Switches

Creates multiple switches in corporate map. The maximum number of switches per request is 10 000; limitation for account is 10 000.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateMultipleSwitchesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AutomaticLocationUpdatesApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var createMultipleSwitchesRequest = new CreateMultipleSwitchesRequest(); // CreateMultipleSwitchesRequest | 

            try
            {
                // Create Multiple Switches
                CreateMultipleSwitchesResponse result = apiInstance.CreateMultipleSwitches(accountId, createMultipleSwitchesRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AutomaticLocationUpdatesApi.CreateMultipleSwitches: " + e.Message );
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
 **createMultipleSwitchesRequest** | [**CreateMultipleSwitchesRequest**](CreateMultipleSwitchesRequest.md)|  | 

### Return type

[**CreateMultipleSwitchesResponse**](CreateMultipleSwitchesResponse.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Multiple Switches Creation Task |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CreateMultipleWirelessPoints

> CreateMultipleWirelessPointsResponse CreateMultipleWirelessPoints (string accountId, CreateMultipleWirelessPointsRequest createMultipleWirelessPointsRequest)

Create Multiple Wireless Points

Creates multiple wireless points in corporate map. The maximum number of wireless points per request is 10 000; limitation for account is 70 000.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateMultipleWirelessPointsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AutomaticLocationUpdatesApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var createMultipleWirelessPointsRequest = new CreateMultipleWirelessPointsRequest(); // CreateMultipleWirelessPointsRequest | 

            try
            {
                // Create Multiple Wireless Points
                CreateMultipleWirelessPointsResponse result = apiInstance.CreateMultipleWirelessPoints(accountId, createMultipleWirelessPointsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AutomaticLocationUpdatesApi.CreateMultipleWirelessPoints: " + e.Message );
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
 **createMultipleWirelessPointsRequest** | [**CreateMultipleWirelessPointsRequest**](CreateMultipleWirelessPointsRequest.md)|  | 

### Return type

[**CreateMultipleWirelessPointsResponse**](CreateMultipleWirelessPointsResponse.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Multiple Wireless Points Creation Task |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CreateNetwork

> NetworkInfo CreateNetwork (string accountId, CreateNetworkRequest createNetworkRequest)

Create Network

Creates a new network in corporate ethernet map for assignment of emergency addresses to network access points.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateNetworkExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AutomaticLocationUpdatesApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var createNetworkRequest = new CreateNetworkRequest(); // CreateNetworkRequest | 

            try
            {
                // Create Network
                NetworkInfo result = apiInstance.CreateNetwork(accountId, createNetworkRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AutomaticLocationUpdatesApi.CreateNetwork: " + e.Message );
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
 **createNetworkRequest** | [**CreateNetworkRequest**](CreateNetworkRequest.md)|  | 

### Return type

[**NetworkInfo**](NetworkInfo.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Created Network |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CreateSwitch

> SwitchInfo CreateSwitch (string accountId, CreateSwitchInfo createSwitchInfo)

Create Switch

Creates a new switch in corporate map based on chassis ID and used for Automatic Locations Update feature.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateSwitchExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AutomaticLocationUpdatesApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var createSwitchInfo = new CreateSwitchInfo(); // CreateSwitchInfo | 

            try
            {
                // Create Switch
                SwitchInfo result = apiInstance.CreateSwitch(accountId, createSwitchInfo);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AutomaticLocationUpdatesApi.CreateSwitch: " + e.Message );
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
 **createSwitchInfo** | [**CreateSwitchInfo**](CreateSwitchInfo.md)|  | 

### Return type

[**SwitchInfo**](SwitchInfo.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Switch information |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CreateWirelessPoint

> WirelessPointInfo CreateWirelessPoint (string accountId, CreateWirelessPoint createWirelessPoint)

Create Wireless Point

Creates a new wireless point in network configuration with the emergency address assigned.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateWirelessPointExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AutomaticLocationUpdatesApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var createWirelessPoint = new CreateWirelessPoint(); // CreateWirelessPoint | 

            try
            {
                // Create Wireless Point
                WirelessPointInfo result = apiInstance.CreateWirelessPoint(accountId, createWirelessPoint);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AutomaticLocationUpdatesApi.CreateWirelessPoint: " + e.Message );
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
 **createWirelessPoint** | [**CreateWirelessPoint**](CreateWirelessPoint.md)|  | 

### Return type

[**WirelessPointInfo**](WirelessPointInfo.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Wireless Point |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteEmergencyLocation

> void DeleteEmergencyLocation (string accountId, string locationId, string newLocationId = null, bool? validateOnly = null)

Delete Emergency Location

Deletes the specified emergency response location.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeleteEmergencyLocationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AutomaticLocationUpdatesApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var locationId = "locationId_example";  // string | Internal identifier of emergency location
            var newLocationId = "newLocationId_example";  // string | Internal identifier of a location that should be used instead of a deleted one (optional) 
            var validateOnly = true;  // bool? | Flag indicating that validation of emergency location(s) is required before deletion (optional) 

            try
            {
                // Delete Emergency Location
                apiInstance.DeleteEmergencyLocation(accountId, locationId, newLocationId, validateOnly);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AutomaticLocationUpdatesApi.DeleteEmergencyLocation: " + e.Message );
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
 **locationId** | **string**| Internal identifier of emergency location | 
 **newLocationId** | **string**| Internal identifier of a location that should be used instead of a deleted one | [optional] 
 **validateOnly** | **bool?**| Flag indicating that validation of emergency location(s) is required before deletion | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful validation |  -  |
| **204** | No Content |  -  |
| **207** | Multi-Status |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteExtensionEmergencyLocation

> void DeleteExtensionEmergencyLocation (string accountId, string extensionId, string locationId, bool? validateOnly = null)

Delete User Emergency Location

Deletes a personal emergency response location by ID by the current user or admin. Multiple personal emergency response locations can be deleted by one API call

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeleteExtensionEmergencyLocationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AutomaticLocationUpdatesApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")
            var locationId = "locationId_example";  // string | Internal identifier of an emergency response location to be deleted
            var validateOnly = true;  // bool? | Flag indicating that only validation of Emergency Response Locations to be deleted is required. (optional) 

            try
            {
                // Delete User Emergency Location
                apiInstance.DeleteExtensionEmergencyLocation(accountId, extensionId, locationId, validateOnly);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AutomaticLocationUpdatesApi.DeleteExtensionEmergencyLocation: " + e.Message );
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
 **locationId** | **string**| Internal identifier of an emergency response location to be deleted | 
 **validateOnly** | **bool?**| Flag indicating that only validation of Emergency Response Locations to be deleted is required. | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteNetwork

> void DeleteNetwork (string accountId, List<string> networkId)

Delete Network

Deletes network(s) in corporate ethernet map for Automatic Location Updates feature.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeleteNetworkExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AutomaticLocationUpdatesApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var networkId = new List<string>(); // List<string> | 

            try
            {
                // Delete Network
                apiInstance.DeleteNetwork(accountId, networkId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AutomaticLocationUpdatesApi.DeleteNetwork: " + e.Message );
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
 **networkId** | [**List&lt;string&gt;**](string.md)|  | 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteSwitch

> void DeleteSwitch (string accountId, List<string> switchId)

Delete Switch

Deletes wireless switch(es) in network configuration for Automatic Location Updates feature.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeleteSwitchExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AutomaticLocationUpdatesApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var switchId = new List<string>(); // List<string> | 

            try
            {
                // Delete Switch
                apiInstance.DeleteSwitch(accountId, switchId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AutomaticLocationUpdatesApi.DeleteSwitch: " + e.Message );
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
 **switchId** | [**List&lt;string&gt;**](string.md)|  | 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteWirelessPoint

> void DeleteWirelessPoint (string accountId, List<string> pointId)

Delete Wireless Point

Deletes wireless point(s) of a corporate map by ID(s).

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeleteWirelessPointExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AutomaticLocationUpdatesApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var pointId = new List<string>(); // List<string> | 

            try
            {
                // Delete Wireless Point
                apiInstance.DeleteWirelessPoint(accountId, pointId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AutomaticLocationUpdatesApi.DeleteWirelessPoint: " + e.Message );
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
 **pointId** | [**List&lt;string&gt;**](string.md)|  | 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetExtensionEmergencyLocation

> EmergencyLocationInfo GetExtensionEmergencyLocation (string accountId, string extensionId, string locationId)

Get User Emergency Location

Returns personal emergency response location for the current user.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetExtensionEmergencyLocationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AutomaticLocationUpdatesApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")
            var locationId = "locationId_example";  // string | Internal identifier of emergency location

            try
            {
                // Get User Emergency Location
                EmergencyLocationInfo result = apiInstance.GetExtensionEmergencyLocation(accountId, extensionId, locationId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AutomaticLocationUpdatesApi.GetExtensionEmergencyLocation: " + e.Message );
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
 **locationId** | **string**| Internal identifier of emergency location | 

### Return type

[**EmergencyLocationInfo**](EmergencyLocationInfo.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetExtensionEmergencyLocations

> EmergencyLocationsResource GetExtensionEmergencyLocations (string accountId, string extensionId, List<string> siteId = null, string searchString = null, string domesticCountryId = null, string orderBy = null, int? perPage = null, int? page = null, string visibility = null, string ifNoneMatch = null)

Get User Emergency Location List

Returns a list of emergency response locations available for the current user extension.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetExtensionEmergencyLocationsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AutomaticLocationUpdatesApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")
            var siteId = new List<string>(); // List<string> | Internal identifier of a site. To filter Main Site (Company) main-site must be specified. Supported only If multi-site feature is enabled for the account (optional) 
            var searchString = "searchString_example";  // string | Filters entries by the specified substring (search by chassis ID, switch name or address) The characters range is 0-64 (if empty the filter is ignored) (optional) 
            var domesticCountryId = "domesticCountryId_example";  // string |  (optional) 
            var orderBy = "+name";  // string | Comma-separated list of fields to order results prefixed by plus sign '+' (ascending order) or minus sign '-' (descending order). The default value is `+visibility`, which means public ERLs will be returned first in the list, then - private ones (optional)  (default to +visibility)
            var perPage = 56;  // int? | Indicates the page size (number of items). The values supported: `Max` or numeric value. If not specified, 100 records are returned per one page (optional) 
            var page = 1;  // int? | Indicates the page number to retrieve. Only positive number values are supported (optional)  (default to 1)
            var visibility = "Private";  // string | Specifies whether to return only private or only public (company) ERLs (Emergency Response Locations) (optional) 
            var ifNoneMatch = "ifNoneMatch_example";  // string | Flag that provides matching the client 'etag' value with the server one (optional) 

            try
            {
                // Get User Emergency Location List
                EmergencyLocationsResource result = apiInstance.GetExtensionEmergencyLocations(accountId, extensionId, siteId, searchString, domesticCountryId, orderBy, perPage, page, visibility, ifNoneMatch);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AutomaticLocationUpdatesApi.GetExtensionEmergencyLocations: " + e.Message );
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
 **siteId** | [**List&lt;string&gt;**](string.md)| Internal identifier of a site. To filter Main Site (Company) main-site must be specified. Supported only If multi-site feature is enabled for the account | [optional] 
 **searchString** | **string**| Filters entries by the specified substring (search by chassis ID, switch name or address) The characters range is 0-64 (if empty the filter is ignored) | [optional] 
 **domesticCountryId** | **string**|  | [optional] 
 **orderBy** | **string**| Comma-separated list of fields to order results prefixed by plus sign &#39;+&#39; (ascending order) or minus sign &#39;-&#39; (descending order). The default value is &#x60;+visibility&#x60;, which means public ERLs will be returned first in the list, then - private ones | [optional] [default to +visibility]
 **perPage** | **int?**| Indicates the page size (number of items). The values supported: &#x60;Max&#x60; or numeric value. If not specified, 100 records are returned per one page | [optional] 
 **page** | **int?**| Indicates the page number to retrieve. Only positive number values are supported | [optional] [default to 1]
 **visibility** | **string**| Specifies whether to return only private or only public (company) ERLs (Emergency Response Locations) | [optional] 
 **ifNoneMatch** | **string**| Flag that provides matching the client &#39;etag&#39; value with the server one | [optional] 

### Return type

[**EmergencyLocationsResource**](EmergencyLocationsResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | User Emergency Location List |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListAccountSwitches

> SwitchesList ListAccountSwitches (string accountId, string siteId = null, string searchString = null, string orderBy = null, int? perPage = null, int? page = null)

Get Account Switch List

Returns corporate map of configured network switches with the assigned emergency addresses for the logged-in account.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListAccountSwitchesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AutomaticLocationUpdatesApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var siteId = "siteId_example";  // string | Internal identifier of a site. To filter Main Site (Company) main-site must be specified. Supported only If multi-site feature is enabled for the account (optional) 
            var searchString = "searchString_example";  // string | Filters entries by the specified substring (search by chassis ID, switch name or address) The characters range is 0-64 (if empty the filter is ignored) (optional) 
            var orderBy = "orderBy_example";  // string | Comma-separated list of fields to order results prefixed by '+' sign (ascending order) or '-' sign (descending order). The default sorting is by `name` (optional) 
            var perPage = 56;  // int? | Indicates the page size (number of items). The values supported: `Max` or numeric value. If not specified, 100 records are returned per one page (optional) 
            var page = 1;  // int? | Indicates the page number to retrieve. Only positive number values are supported (optional)  (default to 1)

            try
            {
                // Get Account Switch List
                SwitchesList result = apiInstance.ListAccountSwitches(accountId, siteId, searchString, orderBy, perPage, page);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AutomaticLocationUpdatesApi.ListAccountSwitches: " + e.Message );
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
 **siteId** | **string**| Internal identifier of a site. To filter Main Site (Company) main-site must be specified. Supported only If multi-site feature is enabled for the account | [optional] 
 **searchString** | **string**| Filters entries by the specified substring (search by chassis ID, switch name or address) The characters range is 0-64 (if empty the filter is ignored) | [optional] 
 **orderBy** | **string**| Comma-separated list of fields to order results prefixed by &#39;+&#39; sign (ascending order) or &#39;-&#39; sign (descending order). The default sorting is by &#x60;name&#x60; | [optional] 
 **perPage** | **int?**| Indicates the page size (number of items). The values supported: &#x60;Max&#x60; or numeric value. If not specified, 100 records are returned per one page | [optional] 
 **page** | **int?**| Indicates the page number to retrieve. Only positive number values are supported | [optional] [default to 1]

### Return type

[**SwitchesList**](SwitchesList.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Switches Map |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListAutomaticLocationUpdatesUsers

> AutomaticLocationUpdatesUserList ListAutomaticLocationUpdatesUsers (string accountId, string type = null, string searchString = null, string department = null, string siteId = null, bool? featureEnabled = null, string orderBy = null, int? perPage = null, int? page = null)

Get User List

Returns the list of users with their status of Automatic Location Updates feature.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListAutomaticLocationUpdatesUsersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AutomaticLocationUpdatesApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var type = "User";  // string | Extension type. Multiple values are supported (optional) 
            var searchString = "searchString_example";  // string | Filters entries containing the specified substring in user name, extension or department. The characters range is 0-64; not case-sensitive. If empty then the filter is ignored (optional) 
            var department = "department_example";  // string | Department name to filter the users. The value range is 0-64; not case-sensitive. If not specified then the parameter is ignored. Multiple values are supported (optional) 
            var siteId = "siteId_example";  // string | Internal identifier of a site. To filter users of Main Site (Company) `main-site` must be specified. Supported only If Multi-Site feature is enabled for the account. Multiple values are supported (optional) 
            var featureEnabled = true;  // bool? | Filters entries by their status of Automatic Location Updates feature (optional) 
            var orderBy = "\"name\"";  // string | Comma-separated list of fields to order results prefixed by plus sign '+' (ascending order) or minus sign '-' (descending order). Supported values: 'name', 'modelName', 'siteName', 'featureEnabled' (optional)  (default to "name")
            var perPage = 56;  // int? | Indicates the page size (number of items). The values supported: `Max` or numeric value. If not specified, 100 records are returned per one page (optional) 
            var page = 1;  // int? | Indicates the page number to retrieve. Only positive number values are supported (optional)  (default to 1)

            try
            {
                // Get User List
                AutomaticLocationUpdatesUserList result = apiInstance.ListAutomaticLocationUpdatesUsers(accountId, type, searchString, department, siteId, featureEnabled, orderBy, perPage, page);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AutomaticLocationUpdatesApi.ListAutomaticLocationUpdatesUsers: " + e.Message );
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
 **type** | **string**| Extension type. Multiple values are supported | [optional] 
 **searchString** | **string**| Filters entries containing the specified substring in user name, extension or department. The characters range is 0-64; not case-sensitive. If empty then the filter is ignored | [optional] 
 **department** | **string**| Department name to filter the users. The value range is 0-64; not case-sensitive. If not specified then the parameter is ignored. Multiple values are supported | [optional] 
 **siteId** | **string**| Internal identifier of a site. To filter users of Main Site (Company) &#x60;main-site&#x60; must be specified. Supported only If Multi-Site feature is enabled for the account. Multiple values are supported | [optional] 
 **featureEnabled** | **bool?**| Filters entries by their status of Automatic Location Updates feature | [optional] 
 **orderBy** | **string**| Comma-separated list of fields to order results prefixed by plus sign &#39;+&#39; (ascending order) or minus sign &#39;-&#39; (descending order). Supported values: &#39;name&#39;, &#39;modelName&#39;, &#39;siteName&#39;, &#39;featureEnabled&#39; | [optional] [default to &quot;name&quot;]
 **perPage** | **int?**| Indicates the page size (number of items). The values supported: &#x60;Max&#x60; or numeric value. If not specified, 100 records are returned per one page | [optional] 
 **page** | **int?**| Indicates the page number to retrieve. Only positive number values are supported | [optional] [default to 1]

### Return type

[**AutomaticLocationUpdatesUserList**](AutomaticLocationUpdatesUserList.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | User List |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListDevicesAutomaticLocationUpdates

> ListDevicesAutomaticLocationUpdates ListDevicesAutomaticLocationUpdates (string accountId, string siteId = null, bool? featureEnabled = null, string model = null, bool? compatibleOnly = null, string searchString = null, string orderBy = null, int? perPage = null, int? page = null)

Get Device List

Returns the list of common devices with their status of Automatic Location Updates feature.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListDevicesAutomaticLocationUpdatesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AutomaticLocationUpdatesApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var siteId = "siteId_example";  // string | Internal identifier of a site. To filter devices of Main Site (Company) `main-site` must be specified. Supported only If Multi-Site feature is enabled for the account (optional) 
            var featureEnabled = true;  // bool? | Filters entries by their status of Automatic Location Updates feature (optional) 
            var model = "model_example";  // string | Internal identifier of a device model for filtering. Multiple values are supported (optional) 
            var compatibleOnly = true;  // bool? | Filters devices which support HELD protocol (optional) 
            var searchString = "searchString_example";  // string | Filters entries which have device name or model name containing the mentioned substring. The value should be split by spaces; the range is 0 - 64 characters, not case-sensitive. If empty the filter is ignored (optional) 
            var orderBy = "\"name\"";  // string | Comma-separated list of fields to order results prefixed by plus sign '+' (ascending order) or minus sign '-' (descending order). Supported values: 'name', 'modelName', 'siteName', 'featureEnabled' (optional)  (default to "name")
            var perPage = 56;  // int? | Indicates the page size (number of items). The values supported: `Max` or numeric value. If not specified, 100 records are returned per one page (optional) 
            var page = 1;  // int? | Indicates the page number to retrieve. Only positive number values are supported (optional)  (default to 1)

            try
            {
                // Get Device List
                ListDevicesAutomaticLocationUpdates result = apiInstance.ListDevicesAutomaticLocationUpdates(accountId, siteId, featureEnabled, model, compatibleOnly, searchString, orderBy, perPage, page);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AutomaticLocationUpdatesApi.ListDevicesAutomaticLocationUpdates: " + e.Message );
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
 **siteId** | **string**| Internal identifier of a site. To filter devices of Main Site (Company) &#x60;main-site&#x60; must be specified. Supported only If Multi-Site feature is enabled for the account | [optional] 
 **featureEnabled** | **bool?**| Filters entries by their status of Automatic Location Updates feature | [optional] 
 **model** | **string**| Internal identifier of a device model for filtering. Multiple values are supported | [optional] 
 **compatibleOnly** | **bool?**| Filters devices which support HELD protocol | [optional] 
 **searchString** | **string**| Filters entries which have device name or model name containing the mentioned substring. The value should be split by spaces; the range is 0 - 64 characters, not case-sensitive. If empty the filter is ignored | [optional] 
 **orderBy** | **string**| Comma-separated list of fields to order results prefixed by plus sign &#39;+&#39; (ascending order) or minus sign &#39;-&#39; (descending order). Supported values: &#39;name&#39;, &#39;modelName&#39;, &#39;siteName&#39;, &#39;featureEnabled&#39; | [optional] [default to &quot;name&quot;]
 **perPage** | **int?**| Indicates the page size (number of items). The values supported: &#x60;Max&#x60; or numeric value. If not specified, 100 records are returned per one page | [optional] 
 **page** | **int?**| Indicates the page number to retrieve. Only positive number values are supported | [optional] [default to 1]

### Return type

[**ListDevicesAutomaticLocationUpdates**](ListDevicesAutomaticLocationUpdates.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Device List with their status of Automatic Location Updates feature |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListEmergencyLocations

> EmergencyLocationList ListEmergencyLocations (string accountId, string searchString = null, string siteId = null, string addressStatus = null, string usageStatus = null, string domesticCountryId = null, string orderBy = null, int? perPage = null, int? page = null)

Get Emergency Location List

Returns emergency response locations of the current account.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListEmergencyLocationsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AutomaticLocationUpdatesApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var searchString = "searchString_example";  // string | Filters entries containing the specified substring in address and name fields. The characters range is 0-64; not case-sensitive. If empty then the filter is ignored (optional) 
            var siteId = "siteId_example";  // string | Internal identifier of a site for filtering. To filter by Main Site (Company) `main-site` value should be specified (optional) 
            var addressStatus = "Valid";  // string |  (optional) 
            var usageStatus = "Active";  // string |  (optional) 
            var domesticCountryId = "domesticCountryId_example";  // string |  (optional) 
            var orderBy = "\"+address\"";  // string | Comma-separated list of fields to order results prefixed by plus sign '+' (ascending order) or minus sign '-' (descending order). Possible field entries are: - `name`; - `siteName`; - `address`; - `addressStatus`; - `usageStatus`.  (optional)  (default to "+address")
            var perPage = 56;  // int? | Indicates the page size (number of items). The values supported: `Max` or numeric value. If not specified, 100 records are returned per one page (optional) 
            var page = 1;  // int? | Indicates the page number to retrieve. Only positive number values are supported (optional)  (default to 1)

            try
            {
                // Get Emergency Location List
                EmergencyLocationList result = apiInstance.ListEmergencyLocations(accountId, searchString, siteId, addressStatus, usageStatus, domesticCountryId, orderBy, perPage, page);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AutomaticLocationUpdatesApi.ListEmergencyLocations: " + e.Message );
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
 **searchString** | **string**| Filters entries containing the specified substring in address and name fields. The characters range is 0-64; not case-sensitive. If empty then the filter is ignored | [optional] 
 **siteId** | **string**| Internal identifier of a site for filtering. To filter by Main Site (Company) &#x60;main-site&#x60; value should be specified | [optional] 
 **addressStatus** | **string**|  | [optional] 
 **usageStatus** | **string**|  | [optional] 
 **domesticCountryId** | **string**|  | [optional] 
 **orderBy** | **string**| Comma-separated list of fields to order results prefixed by plus sign &#39;+&#39; (ascending order) or minus sign &#39;-&#39; (descending order). Possible field entries are: - &#x60;name&#x60;; - &#x60;siteName&#x60;; - &#x60;address&#x60;; - &#x60;addressStatus&#x60;; - &#x60;usageStatus&#x60;.  | [optional] [default to &quot;+address&quot;]
 **perPage** | **int?**| Indicates the page size (number of items). The values supported: &#x60;Max&#x60; or numeric value. If not specified, 100 records are returned per one page | [optional] 
 **page** | **int?**| Indicates the page number to retrieve. Only positive number values are supported | [optional] [default to 1]

### Return type

[**EmergencyLocationList**](EmergencyLocationList.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Emergency Location List |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListNetworks

> NetworksList ListNetworks (string accountId)

Get Network Map

Returns corporate networks map with emergency addresses assigned to the current account.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListNetworksExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AutomaticLocationUpdatesApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")

            try
            {
                // Get Network Map
                NetworksList result = apiInstance.ListNetworks(accountId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AutomaticLocationUpdatesApi.ListNetworks: " + e.Message );
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

### Return type

[**NetworksList**](NetworksList.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | Networks List |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListWirelessPoints

> WirelessPointsList ListWirelessPoints (string accountId, string siteId = null, string searchString = null, string orderBy = null, int? perPage = null, int? page = null)

Get Wireless Point List

Returns account wireless points configured and used for Automatic Location Updates feature.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListWirelessPointsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AutomaticLocationUpdatesApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var siteId = "siteId_example";  // string | Internal identifier of a site. To filter Main Site (Company) 'main-site' must be specified. Supported only If multi-site feature is enabled for the account (optional) 
            var searchString = "searchString_example";  // string | Filters entries by the specified substring (search by chassis ID, switch name or address) The characters range is 0-64 (if empty the filter is ignored) (optional) 
            var orderBy = "orderBy_example";  // string | Comma-separated list of fields to order results prefixed by '+' sign (ascending order) or '-' sign (descending order). The default sorting is by `name` (optional) 
            var perPage = 56;  // int? | Indicates the page size (number of items). The values supported: `Max` or numeric value. If not specified, 100 records are returned per one page (optional) 
            var page = 1;  // int? | Indicates the page number to retrieve. Only positive number values are supported (optional)  (default to 1)

            try
            {
                // Get Wireless Point List
                WirelessPointsList result = apiInstance.ListWirelessPoints(accountId, siteId, searchString, orderBy, perPage, page);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AutomaticLocationUpdatesApi.ListWirelessPoints: " + e.Message );
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
 **siteId** | **string**| Internal identifier of a site. To filter Main Site (Company) &#39;main-site&#39; must be specified. Supported only If multi-site feature is enabled for the account | [optional] 
 **searchString** | **string**| Filters entries by the specified substring (search by chassis ID, switch name or address) The characters range is 0-64 (if empty the filter is ignored) | [optional] 
 **orderBy** | **string**| Comma-separated list of fields to order results prefixed by &#39;+&#39; sign (ascending order) or &#39;-&#39; sign (descending order). The default sorting is by &#x60;name&#x60; | [optional] 
 **perPage** | **int?**| Indicates the page size (number of items). The values supported: &#x60;Max&#x60; or numeric value. If not specified, 100 records are returned per one page | [optional] 
 **page** | **int?**| Indicates the page number to retrieve. Only positive number values are supported | [optional] [default to 1]

### Return type

[**WirelessPointsList**](WirelessPointsList.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Wireless Points |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ReadAutomaticLocationUpdatesTask

> AutomaticLocationUpdatesTaskInfo ReadAutomaticLocationUpdatesTask (string accountId, string taskId)

Get Emergency Map Configuration Task

Returns results of the task created within the frame of Automatic Location Updates feature. Currently four task types are supported: 'Wireless Points Bulk Create', 'Wireless Points Bulk Update', 'Switches Bulk Create', 'Switches Bulk Update'.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadAutomaticLocationUpdatesTaskExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AutomaticLocationUpdatesApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var taskId = "taskId_example";  // string | 

            try
            {
                // Get Emergency Map Configuration Task
                AutomaticLocationUpdatesTaskInfo result = apiInstance.ReadAutomaticLocationUpdatesTask(accountId, taskId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AutomaticLocationUpdatesApi.ReadAutomaticLocationUpdatesTask: " + e.Message );
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
 **taskId** | **string**|  | 

### Return type

[**AutomaticLocationUpdatesTaskInfo**](AutomaticLocationUpdatesTaskInfo.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Task Information |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ReadEmergencyLocation

> EmergencyLocationInfo ReadEmergencyLocation (string accountId, string locationId)

Get Emergency Location

Returns emergency response location by ID.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadEmergencyLocationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AutomaticLocationUpdatesApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var locationId = "locationId_example";  // string | Internal identifier of the emergency location

            try
            {
                // Get Emergency Location
                EmergencyLocationInfo result = apiInstance.ReadEmergencyLocation(accountId, locationId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AutomaticLocationUpdatesApi.ReadEmergencyLocation: " + e.Message );
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
 **locationId** | **string**| Internal identifier of the emergency location | 

### Return type

[**EmergencyLocationInfo**](EmergencyLocationInfo.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Emergency Location Information |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ReadNetwork

> NetworkInfo ReadNetwork (string accountId, string networkId)

Get Network

Returns the specified network with emergency addresses assigned to the current account.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadNetworkExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AutomaticLocationUpdatesApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var networkId = "networkId_example";  // string | 

            try
            {
                // Get Network
                NetworkInfo result = apiInstance.ReadNetwork(accountId, networkId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AutomaticLocationUpdatesApi.ReadNetwork: " + e.Message );
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
 **networkId** | **string**|  | 

### Return type

[**NetworkInfo**](NetworkInfo.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Network information |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ReadSwitch

> SwitchInfo ReadSwitch (string accountId, string switchId)

Get Switch

Returns the specified switch with the assigned emergency address.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadSwitchExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AutomaticLocationUpdatesApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var switchId = "switchId_example";  // string | 

            try
            {
                // Get Switch
                SwitchInfo result = apiInstance.ReadSwitch(accountId, switchId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AutomaticLocationUpdatesApi.ReadSwitch: " + e.Message );
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
 **switchId** | **string**|  | 

### Return type

[**SwitchInfo**](SwitchInfo.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Switch information |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ReadWirelessPoint

> WirelessPointInfo ReadWirelessPoint (string accountId, string pointId)

Get Wireless Point

Returns the specified wireless access point of a corporate map with the emergency address assigned.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadWirelessPointExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AutomaticLocationUpdatesApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var pointId = "pointId_example";  // string | 

            try
            {
                // Get Wireless Point
                WirelessPointInfo result = apiInstance.ReadWirelessPoint(accountId, pointId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AutomaticLocationUpdatesApi.ReadWirelessPoint: " + e.Message );
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
 **pointId** | **string**|  | 

### Return type

[**WirelessPointInfo**](WirelessPointInfo.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Wireless Point |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateEmergencyLocation

> EmergencyLocationInfo UpdateEmergencyLocation (string accountId, string locationId, EmergencyLocationInfoRequest emergencyLocationInfoRequest)

Update Emergency Location

Updates the specified emergency response location.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateEmergencyLocationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AutomaticLocationUpdatesApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var locationId = "locationId_example";  // string | Internal identifier of the emergency location
            var emergencyLocationInfoRequest = new EmergencyLocationInfoRequest(); // EmergencyLocationInfoRequest | JSON body

            try
            {
                // Update Emergency Location
                EmergencyLocationInfo result = apiInstance.UpdateEmergencyLocation(accountId, locationId, emergencyLocationInfoRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AutomaticLocationUpdatesApi.UpdateEmergencyLocation: " + e.Message );
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
 **locationId** | **string**| Internal identifier of the emergency location | 
 **emergencyLocationInfoRequest** | [**EmergencyLocationInfoRequest**](EmergencyLocationInfoRequest.md)| JSON body | 

### Return type

[**EmergencyLocationInfo**](EmergencyLocationInfo.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Emergency Location Information |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateExtensionEmergencyLocation

> EmergencyLocationInfo UpdateExtensionEmergencyLocation (string accountId, string extensionId, string locationId, EmergencyLocationInfo emergencyLocationInfo)

Update User Emergency Location

Updates a personal emergency response location by the current user or admin.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateExtensionEmergencyLocationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AutomaticLocationUpdatesApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")
            var locationId = "locationId_example";  // string | Internal identifier of an emergency response location to be deleted
            var emergencyLocationInfo = new EmergencyLocationInfo(); // EmergencyLocationInfo | 

            try
            {
                // Update User Emergency Location
                EmergencyLocationInfo result = apiInstance.UpdateExtensionEmergencyLocation(accountId, extensionId, locationId, emergencyLocationInfo);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AutomaticLocationUpdatesApi.UpdateExtensionEmergencyLocation: " + e.Message );
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
 **locationId** | **string**| Internal identifier of an emergency response location to be deleted | 
 **emergencyLocationInfo** | [**EmergencyLocationInfo**](EmergencyLocationInfo.md)|  | 

### Return type

[**EmergencyLocationInfo**](EmergencyLocationInfo.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateMultipleSwitches

> UpdateMultipleSwitchesResponse UpdateMultipleSwitches (string accountId, UpdateMultipleSwitchesRequest updateMultipleSwitchesRequest)

Update Multiple Switches

Updates multiple switches in corporate map. The maximum number of switches per request is 10 000; limitation for account is 10 000.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateMultipleSwitchesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AutomaticLocationUpdatesApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var updateMultipleSwitchesRequest = new UpdateMultipleSwitchesRequest(); // UpdateMultipleSwitchesRequest | 

            try
            {
                // Update Multiple Switches
                UpdateMultipleSwitchesResponse result = apiInstance.UpdateMultipleSwitches(accountId, updateMultipleSwitchesRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AutomaticLocationUpdatesApi.UpdateMultipleSwitches: " + e.Message );
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
 **updateMultipleSwitchesRequest** | [**UpdateMultipleSwitchesRequest**](UpdateMultipleSwitchesRequest.md)|  | 

### Return type

[**UpdateMultipleSwitchesResponse**](UpdateMultipleSwitchesResponse.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Multiple Switches Update Task |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateMultipleWirelessPoints

> UpdateMultipleWirelessPointsResponse UpdateMultipleWirelessPoints (string accountId, UpdateMultipleWirelessPointsRequest updateMultipleWirelessPointsRequest)

Update Multiple Wireless Points

Updates wireless points in corporate map. The maximum number of wireless points per request is 10 000; limitation for account is 70 000.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateMultipleWirelessPointsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AutomaticLocationUpdatesApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var updateMultipleWirelessPointsRequest = new UpdateMultipleWirelessPointsRequest(); // UpdateMultipleWirelessPointsRequest | 

            try
            {
                // Update Multiple Wireless Points
                UpdateMultipleWirelessPointsResponse result = apiInstance.UpdateMultipleWirelessPoints(accountId, updateMultipleWirelessPointsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AutomaticLocationUpdatesApi.UpdateMultipleWirelessPoints: " + e.Message );
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
 **updateMultipleWirelessPointsRequest** | [**UpdateMultipleWirelessPointsRequest**](UpdateMultipleWirelessPointsRequest.md)|  | 

### Return type

[**UpdateMultipleWirelessPointsResponse**](UpdateMultipleWirelessPointsResponse.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Multiple Wireless Points Update Task |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateNetwork

> void UpdateNetwork (string accountId, string networkId, UpdateNetworkRequest updateNetworkRequest)

Update Network

Updates network in corporate ethernet map for assignment of emergency addresses to network access points.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateNetworkExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AutomaticLocationUpdatesApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var networkId = "networkId_example";  // string | 
            var updateNetworkRequest = new UpdateNetworkRequest(); // UpdateNetworkRequest | 

            try
            {
                // Update Network
                apiInstance.UpdateNetwork(accountId, networkId, updateNetworkRequest);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AutomaticLocationUpdatesApi.UpdateNetwork: " + e.Message );
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
 **networkId** | **string**|  | 
 **updateNetworkRequest** | [**UpdateNetworkRequest**](UpdateNetworkRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateSwitch

> SwitchInfo UpdateSwitch (string accountId, string switchId, UpdateSwitchInfo updateSwitchInfo)

Update Switch

Updates switch. Partial update is not supported, all switch parameters should be specified. If null value is received or parameter is missing, its value is removed.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateSwitchExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AutomaticLocationUpdatesApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var switchId = "switchId_example";  // string | 
            var updateSwitchInfo = new UpdateSwitchInfo(); // UpdateSwitchInfo | 

            try
            {
                // Update Switch
                SwitchInfo result = apiInstance.UpdateSwitch(accountId, switchId, updateSwitchInfo);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AutomaticLocationUpdatesApi.UpdateSwitch: " + e.Message );
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
 **switchId** | **string**|  | 
 **updateSwitchInfo** | [**UpdateSwitchInfo**](UpdateSwitchInfo.md)|  | 

### Return type

[**SwitchInfo**](SwitchInfo.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Switch information |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateWirelessPoint

> WirelessPointInfo UpdateWirelessPoint (string accountId, string pointId, UpdateWirelessPoint updateWirelessPoint)

Update Wireless Point

Updates the specified wireless access point of a corporate map by ID.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateWirelessPointExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AutomaticLocationUpdatesApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var pointId = "pointId_example";  // string | 
            var updateWirelessPoint = new UpdateWirelessPoint(); // UpdateWirelessPoint | 

            try
            {
                // Update Wireless Point
                WirelessPointInfo result = apiInstance.UpdateWirelessPoint(accountId, pointId, updateWirelessPoint);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AutomaticLocationUpdatesApi.UpdateWirelessPoint: " + e.Message );
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
 **pointId** | **string**|  | 
 **updateWirelessPoint** | [**UpdateWirelessPoint**](UpdateWirelessPoint.md)|  | 

### Return type

[**WirelessPointInfo**](WirelessPointInfo.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Wireless Point |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ValidateMultipleSwitches

> ValidateMultipleSwitchesResponse ValidateMultipleSwitches (string accountId, ValidateMultipleSwitchesRequest validateMultipleSwitchesRequest)

Validate Multiple Switches

Validates switches before creation or update. The maximum number of switches per request is 10 000.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ValidateMultipleSwitchesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AutomaticLocationUpdatesApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var validateMultipleSwitchesRequest = new ValidateMultipleSwitchesRequest(); // ValidateMultipleSwitchesRequest | 

            try
            {
                // Validate Multiple Switches
                ValidateMultipleSwitchesResponse result = apiInstance.ValidateMultipleSwitches(accountId, validateMultipleSwitchesRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AutomaticLocationUpdatesApi.ValidateMultipleSwitches: " + e.Message );
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
 **validateMultipleSwitchesRequest** | [**ValidateMultipleSwitchesRequest**](ValidateMultipleSwitchesRequest.md)|  | 

### Return type

[**ValidateMultipleSwitchesResponse**](ValidateMultipleSwitchesResponse.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ValidateMultipleWirelessPoints

> ValidateMultipleWirelessPointsResponse ValidateMultipleWirelessPoints (string accountId, ValidateMultipleWirelessPointsRequest validateMultipleWirelessPointsRequest)

Validate Multiple Wireless Points

Validates wireless points before creation or update. The maximum number of wireless points per request is 10 000.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ValidateMultipleWirelessPointsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AutomaticLocationUpdatesApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var validateMultipleWirelessPointsRequest = new ValidateMultipleWirelessPointsRequest(); // ValidateMultipleWirelessPointsRequest | 

            try
            {
                // Validate Multiple Wireless Points
                ValidateMultipleWirelessPointsResponse result = apiInstance.ValidateMultipleWirelessPoints(accountId, validateMultipleWirelessPointsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AutomaticLocationUpdatesApi.ValidateMultipleWirelessPoints: " + e.Message );
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
 **validateMultipleWirelessPointsRequest** | [**ValidateMultipleWirelessPointsRequest**](ValidateMultipleWirelessPointsRequest.md)|  | 

### Return type

[**ValidateMultipleWirelessPointsResponse**](ValidateMultipleWirelessPointsResponse.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

