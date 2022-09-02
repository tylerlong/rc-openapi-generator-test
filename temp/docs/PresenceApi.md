# Org.OpenAPITools.Api.PresenceApi

All URIs are relative to *https://platform.ringcentral.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ReadAccountPresence**](PresenceApi.md#readaccountpresence) | **GET** /restapi/v1.0/account/{accountId}/presence | Get User Presence Status List
[**ReadCallQueuePresence**](PresenceApi.md#readcallqueuepresence) | **GET** /restapi/v1.0/account/{accountId}/call-queues/{groupId}/presence | Get Call Queue Presence
[**ReadExtensionCallQueuePresence**](PresenceApi.md#readextensioncallqueuepresence) | **GET** /restapi/v1.0/account/{accountId}/extension/{extensionId}/call-queue-presence | Get Agent’s Call Queue Presence
[**ReadUnifiedPresence**](PresenceApi.md#readunifiedpresence) | **GET** /restapi/v1.0/account/{accountId}/extension/{extensionId}/unified-presence | Get Unified Presence
[**ReadUserPresenceStatus**](PresenceApi.md#readuserpresencestatus) | **GET** /restapi/v1.0/account/{accountId}/extension/{extensionId}/presence | Get User Presence Status
[**UpdateCallQueuePresence**](PresenceApi.md#updatecallqueuepresence) | **PUT** /restapi/v1.0/account/{accountId}/call-queues/{groupId}/presence | Update Call Queue Presence
[**UpdateExtensionCallQueuePresence**](PresenceApi.md#updateextensioncallqueuepresence) | **PUT** /restapi/v1.0/account/{accountId}/extension/{extensionId}/call-queue-presence | Update Call Queue Presence
[**UpdateUnifiedPresence**](PresenceApi.md#updateunifiedpresence) | **PATCH** /restapi/v1.0/account/{accountId}/extension/{extensionId}/unified-presence | Update Unified Presence
[**UpdateUserPresenceStatus**](PresenceApi.md#updateuserpresencestatus) | **PUT** /restapi/v1.0/account/{accountId}/extension/{extensionId}/presence | Update User Presence Status



## ReadAccountPresence

> AccountPresenceInfo ReadAccountPresence (string accountId, bool? detailedTelephonyState = null, bool? sipData = null, int? page = null, int? perPage = null)

Get User Presence Status List

Returns presence status of all extensions of an account. Please note: The presenceStatus is returned as Offline (the parameters telephonyStatus, message, userStatus and dndStatus are not returned at all) for the following extension types: Department, Announcement Only, Voicemail (Take Messages Only), Fax User, Paging Only Group, Shared Lines Group, IVR Menu, Application Extension.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadAccountPresenceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PresenceApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var detailedTelephonyState = true;  // bool? | Whether to return detailed telephony state (optional) 
            var sipData = true;  // bool? | Whether to return SIP data (optional) 
            var page = 56;  // int? | Page number for account presence information (optional) 
            var perPage = 56;  // int? | Number for account presence information items per page (optional) 

            try
            {
                // Get User Presence Status List
                AccountPresenceInfo result = apiInstance.ReadAccountPresence(accountId, detailedTelephonyState, sipData, page, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PresenceApi.ReadAccountPresence: " + e.Message );
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
 **detailedTelephonyState** | **bool?**| Whether to return detailed telephony state | [optional] 
 **sipData** | **bool?**| Whether to return SIP data | [optional] 
 **page** | **int?**| Page number for account presence information | [optional] 
 **perPage** | **int?**| Number for account presence information items per page | [optional] 

### Return type

[**AccountPresenceInfo**](AccountPresenceInfo.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ReadCallQueuePresence

> CallQueuePresence ReadCallQueuePresence (string accountId, string groupId)

Get Call Queue Presence

Returns presence status of the call queue members.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadCallQueuePresenceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PresenceApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var groupId = "groupId_example";  // string | Internal identifier of an call queue extension

            try
            {
                // Get Call Queue Presence
                CallQueuePresence result = apiInstance.ReadCallQueuePresence(accountId, groupId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PresenceApi.ReadCallQueuePresence: " + e.Message );
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
 **groupId** | **string**| Internal identifier of an call queue extension | 

### Return type

[**CallQueuePresence**](CallQueuePresence.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ReadExtensionCallQueuePresence

> ExtensionCallQueuePresenceList ReadExtensionCallQueuePresence (string accountId, string extensionId, bool? editableMemberStatus = null)

Get Agent’s Call Queue Presence

Returns a list of agent's call queues with the agent presence status (per queue).

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadExtensionCallQueuePresenceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PresenceApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var extensionId = "\"~\"";  // string | Internal identifier of an extension (default to "~")
            var editableMemberStatus = true;  // bool? | Filtering by the flag 'Allow members to change their Queue Status'. If 'true' only queues where user can change his availability status are returned (optional) 

            try
            {
                // Get Agent’s Call Queue Presence
                ExtensionCallQueuePresenceList result = apiInstance.ReadExtensionCallQueuePresence(accountId, extensionId, editableMemberStatus);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PresenceApi.ReadExtensionCallQueuePresence: " + e.Message );
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
 **extensionId** | **string**| Internal identifier of an extension | [default to &quot;~&quot;]
 **editableMemberStatus** | **bool?**| Filtering by the flag &#39;Allow members to change their Queue Status&#39;. If &#39;true&#39; only queues where user can change his availability status are returned | [optional] 

### Return type

[**ExtensionCallQueuePresenceList**](ExtensionCallQueuePresenceList.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ReadUnifiedPresence

> UnifiedPresence ReadUnifiedPresence (string accountId, string extensionId)

Get Unified Presence

Returns the unified presence status of the requested user(s). The set of parameters returned by this method differs whether you return the requester's presence or any other user presence.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadUnifiedPresenceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PresenceApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")

            try
            {
                // Get Unified Presence
                UnifiedPresence result = apiInstance.ReadUnifiedPresence(accountId, extensionId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PresenceApi.ReadUnifiedPresence: " + e.Message );
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

### Return type

[**UnifiedPresence**](UnifiedPresence.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **207** | Multi-Status |  -  |
| **400** | Some of parameters are missing or have invalid format. |  -  |
| **404** | Resource not found |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ReadUserPresenceStatus

> GetPresenceInfo ReadUserPresenceStatus (string accountId, string extensionId, bool? detailedTelephonyState = null, bool? sipData = null)

Get User Presence Status

Returns presence status of an extension or several extensions by their ID(s). Batch request is supported. The 'presenceStatus' is returned as Offline (the parameters 'telephonyStatus', 'message', 'userStatus' and 'dndStatus' are not returned at all) for the following extension types: Department/Announcement Only/Take Messages Only (Voicemail)/Fax User/Paging Only Group/Shared Lines Group/IVR Menu/Application Extension/Park Location.If the user requests his/her own presence status, the response contains actual presence status even if the status publication is turned off. Batch request is supported. For batch requests the number of extensions in one request is limited to 30. If more extensions are included in the request, the error code 400 Bad Request is returned with the logical error code InvalidMultipartRequest and the corresponding message 'Extension Presence Info multipart request is limited to 30 extensions'.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadUserPresenceStatusExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PresenceApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")
            var detailedTelephonyState = true;  // bool? | Whether to return detailed telephony state (optional) 
            var sipData = true;  // bool? | Whether to return SIP data (optional) 

            try
            {
                // Get User Presence Status
                GetPresenceInfo result = apiInstance.ReadUserPresenceStatus(accountId, extensionId, detailedTelephonyState, sipData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PresenceApi.ReadUserPresenceStatus: " + e.Message );
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
 **detailedTelephonyState** | **bool?**| Whether to return detailed telephony state | [optional] 
 **sipData** | **bool?**| Whether to return SIP data | [optional] 

### Return type

[**GetPresenceInfo**](GetPresenceInfo.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateCallQueuePresence

> CallQueuePresence UpdateCallQueuePresence (string accountId, string groupId, CallQueueUpdatePresence callQueueUpdatePresence)

Update Call Queue Presence

Updates presence status of the call queue members in the specified queue.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateCallQueuePresenceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PresenceApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var groupId = "groupId_example";  // string | Internal identifier of a call queue extension
            var callQueueUpdatePresence = new CallQueueUpdatePresence(); // CallQueueUpdatePresence | 

            try
            {
                // Update Call Queue Presence
                CallQueuePresence result = apiInstance.UpdateCallQueuePresence(accountId, groupId, callQueueUpdatePresence);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PresenceApi.UpdateCallQueuePresence: " + e.Message );
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
 **groupId** | **string**| Internal identifier of a call queue extension | 
 **callQueueUpdatePresence** | [**CallQueueUpdatePresence**](CallQueueUpdatePresence.md)|  | 

### Return type

[**CallQueuePresence**](CallQueuePresence.md)

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


## UpdateExtensionCallQueuePresence

> ExtensionCallQueuePresenceList UpdateExtensionCallQueuePresence (string accountId, string extensionId, ExtensionCallQueueUpdatePresenceList extensionCallQueueUpdatePresenceList)

Update Call Queue Presence

Updates availability of the agent for the call queues.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateExtensionCallQueuePresenceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PresenceApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var extensionId = "\"~\"";  // string | Internal identifier of an extension (default to "~")
            var extensionCallQueueUpdatePresenceList = new ExtensionCallQueueUpdatePresenceList(); // ExtensionCallQueueUpdatePresenceList | 

            try
            {
                // Update Call Queue Presence
                ExtensionCallQueuePresenceList result = apiInstance.UpdateExtensionCallQueuePresence(accountId, extensionId, extensionCallQueueUpdatePresenceList);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PresenceApi.UpdateExtensionCallQueuePresence: " + e.Message );
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
 **extensionId** | **string**| Internal identifier of an extension | [default to &quot;~&quot;]
 **extensionCallQueueUpdatePresenceList** | [**ExtensionCallQueueUpdatePresenceList**](ExtensionCallQueueUpdatePresenceList.md)|  | 

### Return type

[**ExtensionCallQueuePresenceList**](ExtensionCallQueuePresenceList.md)

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


## UpdateUnifiedPresence

> UnifiedPresence UpdateUnifiedPresence (string accountId, string extensionId, UpdateUnifiedPresence updateUnifiedPresence)

Update Unified Presence

Updates the unified presence for the current user specified in path.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateUnifiedPresenceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PresenceApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")
            var updateUnifiedPresence = new UpdateUnifiedPresence(); // UpdateUnifiedPresence | JSON body

            try
            {
                // Update Unified Presence
                UnifiedPresence result = apiInstance.UpdateUnifiedPresence(accountId, extensionId, updateUnifiedPresence);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PresenceApi.UpdateUnifiedPresence: " + e.Message );
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
 **updateUnifiedPresence** | [**UpdateUnifiedPresence**](UpdateUnifiedPresence.md)| JSON body | 

### Return type

[**UnifiedPresence**](UnifiedPresence.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Some of parameters are missing or have invalid format |  -  |
| **403** | User is not allowed to do this action |  -  |
| **404** | Resource not found |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateUserPresenceStatus

> PresenceInfoResponse UpdateUserPresenceStatus (string extensionId, string accountId, PresenceInfoRequest presenceInfoRequest = null)

Update User Presence Status

Updates user-defined extension presence status, status message and DnD status by extension ID. Supported for regular User extensions only. The extension types listed do not support presence status: Department, Announcement Only, Take Messages Only (Voicemail), Fax User, Paging Only Group, Shared Lines Group, IVR Menu, Application Extension.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateUserPresenceStatusExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PresenceApi(Configuration.Default);
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var presenceInfoRequest = new PresenceInfoRequest(); // PresenceInfoRequest |  (optional) 

            try
            {
                // Update User Presence Status
                PresenceInfoResponse result = apiInstance.UpdateUserPresenceStatus(extensionId, accountId, presenceInfoRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PresenceApi.UpdateUserPresenceStatus: " + e.Message );
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
 **extensionId** | **string**| Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session | [default to &quot;~&quot;]
 **accountId** | **string**| Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session | [default to &quot;~&quot;]
 **presenceInfoRequest** | [**PresenceInfoRequest**](PresenceInfoRequest.md)|  | [optional] 

### Return type

[**PresenceInfoResponse**](PresenceInfoResponse.md)

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

