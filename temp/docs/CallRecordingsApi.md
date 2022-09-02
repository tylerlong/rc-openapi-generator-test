# Org.OpenAPITools.Api.CallRecordingsApi

All URIs are relative to *https://platform.ringcentral.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListCallRecordingData**](CallRecordingsApi.md#listcallrecordingdata) | **GET** /restapi/v1.0/account/{accountId}/recording/{recordingId}/content | Get Call Recordings Data
[**ReadCallRecording**](CallRecordingsApi.md#readcallrecording) | **GET** /restapi/v1.0/account/{accountId}/recording/{recordingId} | Get Call Recording



## ListCallRecordingData

> void ListCallRecordingData (string accountId, string recordingId)

Get Call Recordings Data

Returns media content of a call recording.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListCallRecordingDataExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CallRecordingsApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var recordingId = "recordingId_example";  // string | Internal identifier of a recording (returned in Call Log)

            try
            {
                // Get Call Recordings Data
                apiInstance.ListCallRecordingData(accountId, recordingId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CallRecordingsApi.ListCallRecordingData: " + e.Message );
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
 **recordingId** | **string**| Internal identifier of a recording (returned in Call Log) | 

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
| **200** | Call Recording Media Data |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ReadCallRecording

> GetCallRecordingResponse ReadCallRecording (string accountId, string recordingId)

Get Call Recording

Returns call recordings by ID(s).

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadCallRecordingExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CallRecordingsApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var recordingId = "recordingId_example";  // string | Internal identifier of a recording (returned in Call Log)

            try
            {
                // Get Call Recording
                GetCallRecordingResponse result = apiInstance.ReadCallRecording(accountId, recordingId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CallRecordingsApi.ReadCallRecording: " + e.Message );
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
 **recordingId** | **string**| Internal identifier of a recording (returned in Call Log) | 

### Return type

[**GetCallRecordingResponse**](GetCallRecordingResponse.md)

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

