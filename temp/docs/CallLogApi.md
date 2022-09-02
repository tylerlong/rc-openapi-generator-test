# Org.OpenAPITools.Api.CallLogApi

All URIs are relative to *https://platform.ringcentral.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteUserCallLog**](CallLogApi.md#deleteusercalllog) | **DELETE** /restapi/v1.0/account/{accountId}/extension/{extensionId}/call-log | Delete User Call Log
[**ListCompanyActiveCalls**](CallLogApi.md#listcompanyactivecalls) | **GET** /restapi/v1.0/account/{accountId}/active-calls | Get Company Active Calls
[**ListExtensionActiveCalls**](CallLogApi.md#listextensionactivecalls) | **GET** /restapi/v1.0/account/{accountId}/extension/{extensionId}/active-calls | Get User Active Calls
[**ReadCompanyCallLog**](CallLogApi.md#readcompanycalllog) | **GET** /restapi/v1.0/account/{accountId}/call-log | Get Company Call Log Records
[**ReadCompanyCallRecord**](CallLogApi.md#readcompanycallrecord) | **GET** /restapi/v1.0/account/{accountId}/call-log/{callRecordId} | Get Company Call Log Record(s)
[**ReadUserCallLog**](CallLogApi.md#readusercalllog) | **GET** /restapi/v1.0/account/{accountId}/extension/{extensionId}/call-log | Get User Call Log Records
[**ReadUserCallRecord**](CallLogApi.md#readusercallrecord) | **GET** /restapi/v1.0/account/{accountId}/extension/{extensionId}/call-log/{callRecordId} | Get User Call Record
[**SyncAccountCallLog**](CallLogApi.md#syncaccountcalllog) | **GET** /restapi/v1.0/account/{accountId}/call-log-sync | Sync Company Call Log
[**SyncUserCallLog**](CallLogApi.md#syncusercalllog) | **GET** /restapi/v1.0/account/{accountId}/extension/{extensionId}/call-log-sync | Sync User Call Log



## DeleteUserCallLog

> void DeleteUserCallLog (string accountId, string extensionId, DateTime? dateTo = null)

Delete User Call Log

Deletes filtered call log records.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeleteUserCallLogExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CallLogApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")
            var dateTo = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | The end datetime for records deletion in (ISO 8601)[https://en.wikipedia.org/wiki/ISO_8601]  format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is current time (optional) 

            try
            {
                // Delete User Call Log
                apiInstance.DeleteUserCallLog(accountId, extensionId, dateTo);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CallLogApi.DeleteUserCallLog: " + e.Message );
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
 **dateTo** | **DateTime?**| The end datetime for records deletion in (ISO 8601)[https://en.wikipedia.org/wiki/ISO_8601]  format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is current time | [optional] 

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
| **0** | Success |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListCompanyActiveCalls

> CompanyActiveCallsResponse ListCompanyActiveCalls (string accountId, List<string> direction = null, string view = null, List<string> type = null, List<string> transport = null, int? page = null, int? perPage = null)

Get Company Active Calls

Returns records of all calls that are in progress, ordered by start time in descending order.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListCompanyActiveCallsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CallLogApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var direction = new List<string>(); // List<string> | The direction for the result records. If not specified, both inbound and outbound records are returned. Multiple values are accepted (optional) 
            var view = "Simple";  // string | View of call records. The same view parameter specified for FSync will be applied for ISync, the view cannot be changed for ISync (optional)  (default to Simple)
            var type = new List<string>(); // List<string> | Call type of a record. If not specified, all call types are returned. Multiple values are accepted (optional) 
            var transport = new List<string>(); // List<string> | Call transport type. 'PSTN' specifies that a call leg is initiated from the PSTN network provider; 'VoIP' - from an RC phone. By default this filter is disabled (optional) 
            var page = 1;  // int? | Indicates the page number to retrieve. Only positive number values are accepted (optional)  (default to 1)
            var perPage = 100;  // int? | Indicates the page size (number of items) (optional)  (default to 100)

            try
            {
                // Get Company Active Calls
                CompanyActiveCallsResponse result = apiInstance.ListCompanyActiveCalls(accountId, direction, view, type, transport, page, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CallLogApi.ListCompanyActiveCalls: " + e.Message );
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
 **direction** | [**List&lt;string&gt;**](string.md)| The direction for the result records. If not specified, both inbound and outbound records are returned. Multiple values are accepted | [optional] 
 **view** | **string**| View of call records. The same view parameter specified for FSync will be applied for ISync, the view cannot be changed for ISync | [optional] [default to Simple]
 **type** | [**List&lt;string&gt;**](string.md)| Call type of a record. If not specified, all call types are returned. Multiple values are accepted | [optional] 
 **transport** | [**List&lt;string&gt;**](string.md)| Call transport type. &#39;PSTN&#39; specifies that a call leg is initiated from the PSTN network provider; &#39;VoIP&#39; - from an RC phone. By default this filter is disabled | [optional] 
 **page** | **int?**| Indicates the page number to retrieve. Only positive number values are accepted | [optional] [default to 1]
 **perPage** | **int?**| Indicates the page size (number of items) | [optional] [default to 100]

### Return type

[**CompanyActiveCallsResponse**](CompanyActiveCallsResponse.md)

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


## ListExtensionActiveCalls

> UserActiveCallsResponse ListExtensionActiveCalls (string accountId, string extensionId, List<string> direction = null, string view = null, List<string> type = null, int? page = null, int? perPage = null)

Get User Active Calls

Returns records of all extension calls that are in progress, ordered by start time in descending order.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListExtensionActiveCallsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CallLogApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")
            var direction = new List<string>(); // List<string> | The direction for the result records. If not specified, both inbound and outbound records are returned. Multiple values are accepted (optional) 
            var view = "Simple";  // string | View of call records. The same view parameter specified for FSync will be applied for ISync, the view cannot be changed for ISync (optional)  (default to Simple)
            var type = new List<string>(); // List<string> | Call type of a record. If not specified, all call types are returned. Multiple values are accepted (optional) 
            var page = 1;  // int? | Indicates the page number to retrieve. Only positive number values are allowed (optional)  (default to 1)
            var perPage = 100;  // int? | Indicates the page size (number of items) (optional)  (default to 100)

            try
            {
                // Get User Active Calls
                UserActiveCallsResponse result = apiInstance.ListExtensionActiveCalls(accountId, extensionId, direction, view, type, page, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CallLogApi.ListExtensionActiveCalls: " + e.Message );
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
 **direction** | [**List&lt;string&gt;**](string.md)| The direction for the result records. If not specified, both inbound and outbound records are returned. Multiple values are accepted | [optional] 
 **view** | **string**| View of call records. The same view parameter specified for FSync will be applied for ISync, the view cannot be changed for ISync | [optional] [default to Simple]
 **type** | [**List&lt;string&gt;**](string.md)| Call type of a record. If not specified, all call types are returned. Multiple values are accepted | [optional] 
 **page** | **int?**| Indicates the page number to retrieve. Only positive number values are allowed | [optional] [default to 1]
 **perPage** | **int?**| Indicates the page size (number of items) | [optional] [default to 100]

### Return type

[**UserActiveCallsResponse**](UserActiveCallsResponse.md)

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


## ReadCompanyCallLog

> AccountCallLogResponse ReadCompanyCallLog (string accountId, string extensionNumber = null, string phoneNumber = null, List<string> direction = null, List<string> type = null, string view = null, bool? withRecording = null, string recordingType = null, DateTime? dateFrom = null, DateTime? dateTo = null, int? page = null, int? perPage = null, string sessionId = null)

Get Company Call Log Records

Returns call log records filtered by parameters specified.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadCompanyCallLogExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CallLogApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var extensionNumber = "extensionNumber_example";  // string | Extension number of a user. If specified, returns call log for a particular extension only (optional) 
            var phoneNumber = 12053320033;  // string | Phone number of a caller/callee in e.164 format without a plus sign '+'. If specified, all incoming and outgoing calls with this phone number are returned. Cannot be specified together with the `extensionNumber` filter (optional) 
            var direction = new List<string>(); // List<string> | The direction for the result records. If not specified, both inbound and outbound records are returned. Multiple values are accepted (optional) 
            var type = new List<string>(); // List<string> | Call type of a record. If not specified, all call types are returned. Multiple values are accepted (optional) 
            var view = "Simple";  // string | View of call records. The same view parameter specified for FSync will be applied for ISync, the view cannot be changed for ISync (optional)  (default to Simple)
            var withRecording = true;  // bool? | **Deprecated**. Supported for compatibility reasons only. `true` if only recorded calls are returned. The default value is `false`. If both `withRecording` and `recordingType` are specified, `withRecording` is ignored (optional) 
            var recordingType = "Automatic";  // string | Type of a call recording. If not specified, then calls without recordings are also returned (optional) 
            var dateFrom = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | The start datetime for resulting records in (ISO 8601)[https://en.wikipedia.org/wiki/ISO_8601]  format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is dateTo minus 24 hours (optional) 
            var dateTo = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | The end datetime for resulting records in (ISO 8601)[https://en.wikipedia.org/wiki/ISO_8601]  format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is current time (optional) 
            var page = 1;  // int? | Indicates the page number to retrieve. Only positive number values are accepted (optional)  (default to 1)
            var perPage = 100;  // int? | Indicates the page size (number of items) (optional)  (default to 100)
            var sessionId = "sessionId_example";  // string | Internal identifier of a call session (optional) 

            try
            {
                // Get Company Call Log Records
                AccountCallLogResponse result = apiInstance.ReadCompanyCallLog(accountId, extensionNumber, phoneNumber, direction, type, view, withRecording, recordingType, dateFrom, dateTo, page, perPage, sessionId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CallLogApi.ReadCompanyCallLog: " + e.Message );
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
 **extensionNumber** | **string**| Extension number of a user. If specified, returns call log for a particular extension only | [optional] 
 **phoneNumber** | **string**| Phone number of a caller/callee in e.164 format without a plus sign &#39;+&#39;. If specified, all incoming and outgoing calls with this phone number are returned. Cannot be specified together with the &#x60;extensionNumber&#x60; filter | [optional] 
 **direction** | [**List&lt;string&gt;**](string.md)| The direction for the result records. If not specified, both inbound and outbound records are returned. Multiple values are accepted | [optional] 
 **type** | [**List&lt;string&gt;**](string.md)| Call type of a record. If not specified, all call types are returned. Multiple values are accepted | [optional] 
 **view** | **string**| View of call records. The same view parameter specified for FSync will be applied for ISync, the view cannot be changed for ISync | [optional] [default to Simple]
 **withRecording** | **bool?**| **Deprecated**. Supported for compatibility reasons only. &#x60;true&#x60; if only recorded calls are returned. The default value is &#x60;false&#x60;. If both &#x60;withRecording&#x60; and &#x60;recordingType&#x60; are specified, &#x60;withRecording&#x60; is ignored | [optional] 
 **recordingType** | **string**| Type of a call recording. If not specified, then calls without recordings are also returned | [optional] 
 **dateFrom** | **DateTime?**| The start datetime for resulting records in (ISO 8601)[https://en.wikipedia.org/wiki/ISO_8601]  format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is dateTo minus 24 hours | [optional] 
 **dateTo** | **DateTime?**| The end datetime for resulting records in (ISO 8601)[https://en.wikipedia.org/wiki/ISO_8601]  format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is current time | [optional] 
 **page** | **int?**| Indicates the page number to retrieve. Only positive number values are accepted | [optional] [default to 1]
 **perPage** | **int?**| Indicates the page size (number of items) | [optional] [default to 100]
 **sessionId** | **string**| Internal identifier of a call session | [optional] 

### Return type

[**AccountCallLogResponse**](AccountCallLogResponse.md)

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


## ReadCompanyCallRecord

> CompanyCallLogRecord ReadCompanyCallRecord (string accountId, string callRecordId, string view = null)

Get Company Call Log Record(s)

Returns individual call log record(s) by ID(s). Batch request is supported.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadCompanyCallRecordExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CallLogApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var callRecordId = "callRecordId_example";  // string | Internal identifier of a call log record
            var view = "Simple";  // string | View of call records. The view value specified for 'FSync' will also be applied for 'ISync' by default, since it cannot be changed for ISync (optional)  (default to Simple)

            try
            {
                // Get Company Call Log Record(s)
                CompanyCallLogRecord result = apiInstance.ReadCompanyCallRecord(accountId, callRecordId, view);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CallLogApi.ReadCompanyCallRecord: " + e.Message );
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
 **callRecordId** | **string**| Internal identifier of a call log record | 
 **view** | **string**| View of call records. The view value specified for &#39;FSync&#39; will also be applied for &#39;ISync&#39; by default, since it cannot be changed for ISync | [optional] [default to Simple]

### Return type

[**CompanyCallLogRecord**](CompanyCallLogRecord.md)

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


## ReadUserCallLog

> UserCallLogResponse ReadUserCallLog (string accountId, string extensionId, string extensionNumber = null, bool? showBlocked = null, string phoneNumber = null, List<string> direction = null, string sessionId = null, List<string> type = null, List<string> transport = null, string view = null, bool? withRecording = null, string recordingType = null, DateTime? dateTo = null, DateTime? dateFrom = null, int? page = null, int? perPage = null, bool? showDeleted = null)

Get User Call Log Records

Returns call log records filtered by parameters specified.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadUserCallLogExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CallLogApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")
            var extensionNumber = "extensionNumber_example";  // string | Extension number of a user. If specified, returns call log for a particular extension only (optional) 
            var showBlocked = true;  // bool? | If 'True' then calls from/to blocked numbers are returned (optional)  (default to true)
            var phoneNumber = 12053320032;  // string | Phone number of a caller/callee in e.164 format without a plus sign '+'. If specified, all incoming and outgoing calls with this phone number are returned (optional) 
            var direction = new List<string>(); // List<string> | The direction for the resulting records. If not specified, both inbound and outbound records are returned. Multiple values are accepted (optional) 
            var sessionId = "sessionId_example";  // string | Internal identifier of a session (optional) 
            var type = new List<string>(); // List<string> | Call type of a record. It is allowed to specify more than one type. If not specified, all call types are returned. Multiple values are accepted (optional) 
            var transport = new List<string>(); // List<string> | Call transport type. 'PSTN' specifies that a call leg is initiated from the PSTN network provider; 'VoIP' - from an RC phone. By default this filter is disabled (optional) 
            var view = "Simple";  // string | View of call records. The same view parameter specified for FSync will be applied for ISync, the view cannot be changed for ISync (optional)  (default to Simple)
            var withRecording = false;  // bool? | **Deprecated**. Supported for compatibility reasons. `True` if only recorded calls are returned. If both `withRecording` and `recordingType` are specified, then `withRecording` is ignored (optional)  (default to false)
            var recordingType = "Automatic";  // string | Type of a call recording. If not specified, then calls without recordings are also returned (optional) 
            var dateTo = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | The end datetime for resulting records in (ISO 8601)[https://en.wikipedia.org/wiki/ISO_8601] format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is current time (optional) 
            var dateFrom = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | The start datetime for resulting records in (ISO 8601)[https://en.wikipedia.org/wiki/ISO_8601] format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is dateTo minus 24 hours (optional) 
            var page = 1;  // int? | Indicates the page number to retrieve. Only positive number values are allowed (optional)  (default to 1)
            var perPage = 100;  // int? | Indicates the page size (number of items). The default value is 100. The maximum value is 1000, for detailed call log - 250 (optional)  (default to 100)
            var showDeleted = false;  // bool? | If 'True' then deleted calls are returned (optional)  (default to false)

            try
            {
                // Get User Call Log Records
                UserCallLogResponse result = apiInstance.ReadUserCallLog(accountId, extensionId, extensionNumber, showBlocked, phoneNumber, direction, sessionId, type, transport, view, withRecording, recordingType, dateTo, dateFrom, page, perPage, showDeleted);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CallLogApi.ReadUserCallLog: " + e.Message );
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
 **extensionNumber** | **string**| Extension number of a user. If specified, returns call log for a particular extension only | [optional] 
 **showBlocked** | **bool?**| If &#39;True&#39; then calls from/to blocked numbers are returned | [optional] [default to true]
 **phoneNumber** | **string**| Phone number of a caller/callee in e.164 format without a plus sign &#39;+&#39;. If specified, all incoming and outgoing calls with this phone number are returned | [optional] 
 **direction** | [**List&lt;string&gt;**](string.md)| The direction for the resulting records. If not specified, both inbound and outbound records are returned. Multiple values are accepted | [optional] 
 **sessionId** | **string**| Internal identifier of a session | [optional] 
 **type** | [**List&lt;string&gt;**](string.md)| Call type of a record. It is allowed to specify more than one type. If not specified, all call types are returned. Multiple values are accepted | [optional] 
 **transport** | [**List&lt;string&gt;**](string.md)| Call transport type. &#39;PSTN&#39; specifies that a call leg is initiated from the PSTN network provider; &#39;VoIP&#39; - from an RC phone. By default this filter is disabled | [optional] 
 **view** | **string**| View of call records. The same view parameter specified for FSync will be applied for ISync, the view cannot be changed for ISync | [optional] [default to Simple]
 **withRecording** | **bool?**| **Deprecated**. Supported for compatibility reasons. &#x60;True&#x60; if only recorded calls are returned. If both &#x60;withRecording&#x60; and &#x60;recordingType&#x60; are specified, then &#x60;withRecording&#x60; is ignored | [optional] [default to false]
 **recordingType** | **string**| Type of a call recording. If not specified, then calls without recordings are also returned | [optional] 
 **dateTo** | **DateTime?**| The end datetime for resulting records in (ISO 8601)[https://en.wikipedia.org/wiki/ISO_8601] format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is current time | [optional] 
 **dateFrom** | **DateTime?**| The start datetime for resulting records in (ISO 8601)[https://en.wikipedia.org/wiki/ISO_8601] format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is dateTo minus 24 hours | [optional] 
 **page** | **int?**| Indicates the page number to retrieve. Only positive number values are allowed | [optional] [default to 1]
 **perPage** | **int?**| Indicates the page size (number of items). The default value is 100. The maximum value is 1000, for detailed call log - 250 | [optional] [default to 100]
 **showDeleted** | **bool?**| If &#39;True&#39; then deleted calls are returned | [optional] [default to false]

### Return type

[**UserCallLogResponse**](UserCallLogResponse.md)

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


## ReadUserCallRecord

> UserCallLogRecord ReadUserCallRecord (List<string> callRecordId, string extensionId, string accountId, string view = null)

Get User Call Record

Returns call log records by ID.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadUserCallRecordExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CallLogApi(Configuration.Default);
            var callRecordId = new List<string>(); // List<string> | 
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var view = "Simple";  // string | View of call records. The view value specified for 'FSync' will also be applied for 'ISync' by default, since it cannot be changed for ISync (optional)  (default to Simple)

            try
            {
                // Get User Call Record
                UserCallLogRecord result = apiInstance.ReadUserCallRecord(callRecordId, extensionId, accountId, view);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CallLogApi.ReadUserCallRecord: " + e.Message );
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
 **callRecordId** | [**List&lt;string&gt;**](string.md)|  | 
 **extensionId** | **string**| Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session | [default to &quot;~&quot;]
 **accountId** | **string**| Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session | [default to &quot;~&quot;]
 **view** | **string**| View of call records. The view value specified for &#39;FSync&#39; will also be applied for &#39;ISync&#39; by default, since it cannot be changed for ISync | [optional] [default to Simple]

### Return type

[**UserCallLogRecord**](UserCallLogRecord.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Call Log Record |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## SyncAccountCallLog

> AccountCallLogSyncResponse SyncAccountCallLog (string accountId, string syncType = null, string syncToken = null, DateTime? dateFrom = null, int? recordCount = null, List<string> statusGroup = null, string view = null, bool? showDeleted = null)

Sync Company Call Log

Synchronizes company call log records.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SyncAccountCallLogExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CallLogApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var syncType = "FSync";  // string | Type of synchronization. (optional)  (default to FSync)
            var syncToken = "syncToken_example";  // string | Value of syncToken property of last sync request response (optional) 
            var dateFrom = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | The start datetime for resulting records in (ISO 8601)[https://en.wikipedia.org/wiki/ISO_8601]  format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is the current moment (optional) 
            var recordCount = 56;  // int? | For 'FSync' the parameter is mandatory, it limits the number of records to be returned in response. For 'ISync' it specifies with how many records to extend sync frame to the past, the maximum number of records is 250 (optional) 
            var statusGroup = new List<string>(); // List<string> | Type of calls to be returned. (optional) 
            var view = "Simple";  // string | View of call records. The same view parameter specified for FSync will be applied for ISync, the view cannot be changed for ISync (optional)  (default to Simple)
            var showDeleted = false;  // bool? | Supported for ISync. If 'True' then deleted call records are returned (optional)  (default to false)

            try
            {
                // Sync Company Call Log
                AccountCallLogSyncResponse result = apiInstance.SyncAccountCallLog(accountId, syncType, syncToken, dateFrom, recordCount, statusGroup, view, showDeleted);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CallLogApi.SyncAccountCallLog: " + e.Message );
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
 **syncType** | **string**| Type of synchronization. | [optional] [default to FSync]
 **syncToken** | **string**| Value of syncToken property of last sync request response | [optional] 
 **dateFrom** | **DateTime?**| The start datetime for resulting records in (ISO 8601)[https://en.wikipedia.org/wiki/ISO_8601]  format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is the current moment | [optional] 
 **recordCount** | **int?**| For &#39;FSync&#39; the parameter is mandatory, it limits the number of records to be returned in response. For &#39;ISync&#39; it specifies with how many records to extend sync frame to the past, the maximum number of records is 250 | [optional] 
 **statusGroup** | [**List&lt;string&gt;**](string.md)| Type of calls to be returned. | [optional] 
 **view** | **string**| View of call records. The same view parameter specified for FSync will be applied for ISync, the view cannot be changed for ISync | [optional] [default to Simple]
 **showDeleted** | **bool?**| Supported for ISync. If &#39;True&#39; then deleted call records are returned | [optional] [default to false]

### Return type

[**AccountCallLogSyncResponse**](AccountCallLogSyncResponse.md)

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


## SyncUserCallLog

> CallLogSync SyncUserCallLog (string accountId, string extensionId, string syncType = null, string syncToken = null, DateTime? dateFrom = null, int? recordCount = null, List<string> statusGroup = null, string view = null, bool? showDeleted = null)

Sync User Call Log

Synchronizes call log records.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SyncUserCallLogExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CallLogApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")
            var syncType = "FSync";  // string | Type of synchronization (optional)  (default to FSync)
            var syncToken = "syncToken_example";  // string | Value of syncToken property of last sync request response (optional) 
            var dateFrom = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | The start datetime for resulting records in (ISO 8601)[https://en.wikipedia.org/wiki/ISO_8601] format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is the current moment (optional) 
            var recordCount = 56;  // int? | For 'FSync' the parameter is mandatory, it limits the number of records to be returned in response. For 'ISync' it specifies with how many records to extend sync Frame to the past, the maximum number of records is 250 (optional) 
            var statusGroup = new List<string>(); // List<string> | Type of calls to be returned. The default value is 'All' (optional) 
            var view = "Simple";  // string | View of call records. The same view parameter specified for FSync will be applied for ISync, the view cannot be changed for ISync (optional)  (default to Simple)
            var showDeleted = false;  // bool? | Supported for ISync. If 'True' then deleted call records are returned (optional)  (default to false)

            try
            {
                // Sync User Call Log
                CallLogSync result = apiInstance.SyncUserCallLog(accountId, extensionId, syncType, syncToken, dateFrom, recordCount, statusGroup, view, showDeleted);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CallLogApi.SyncUserCallLog: " + e.Message );
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
 **syncType** | **string**| Type of synchronization | [optional] [default to FSync]
 **syncToken** | **string**| Value of syncToken property of last sync request response | [optional] 
 **dateFrom** | **DateTime?**| The start datetime for resulting records in (ISO 8601)[https://en.wikipedia.org/wiki/ISO_8601] format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is the current moment | [optional] 
 **recordCount** | **int?**| For &#39;FSync&#39; the parameter is mandatory, it limits the number of records to be returned in response. For &#39;ISync&#39; it specifies with how many records to extend sync Frame to the past, the maximum number of records is 250 | [optional] 
 **statusGroup** | [**List&lt;string&gt;**](string.md)| Type of calls to be returned. The default value is &#39;All&#39; | [optional] 
 **view** | **string**| View of call records. The same view parameter specified for FSync will be applied for ISync, the view cannot be changed for ISync | [optional] [default to Simple]
 **showDeleted** | **bool?**| Supported for ISync. If &#39;True&#39; then deleted call records are returned | [optional] [default to false]

### Return type

[**CallLogSync**](CallLogSync.md)

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

