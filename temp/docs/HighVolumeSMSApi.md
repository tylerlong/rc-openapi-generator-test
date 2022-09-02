# Org.OpenAPITools.Api.HighVolumeSMSApi

All URIs are relative to *https://platform.ringcentral.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddA2PSMSOptOuts**](HighVolumeSMSApi.md#adda2psmsoptouts) | **POST** /restapi/v1.0/account/{accountId}/a2p-sms/opt-outs/bulk-assign | Assign Multiple Opted Out/In Numbers
[**AggregateA2PSMSStatuses**](HighVolumeSMSApi.md#aggregatea2psmsstatuses) | **GET** /restapi/v1.0/account/{accountId}/a2p-sms/statuses | List A2P SMS Statuses
[**CreateA2PSMS**](HighVolumeSMSApi.md#createa2psms) | **POST** /restapi/v1.0/account/{accountId}/a2p-sms/batches | Send A2P SMS
[**ListA2PBatches**](HighVolumeSMSApi.md#lista2pbatches) | **GET** /restapi/v1.0/account/{accountId}/a2p-sms/batches | Get A2P SMS Batches
[**ListA2PSMS**](HighVolumeSMSApi.md#lista2psms) | **GET** /restapi/v1.0/account/{accountId}/a2p-sms/messages | Get A2P SMS List
[**ReadA2PBatch**](HighVolumeSMSApi.md#reada2pbatch) | **GET** /restapi/v1.0/account/{accountId}/a2p-sms/batches/{batchId} | Get A2P SMS Batch
[**ReadA2PSMS**](HighVolumeSMSApi.md#reada2psms) | **GET** /restapi/v1.0/account/{accountId}/a2p-sms/messages/{messageId} | Get A2P SMS
[**ReadA2PSMSOptOuts**](HighVolumeSMSApi.md#reada2psmsoptouts) | **GET** /restapi/v1.0/account/{accountId}/a2p-sms/opt-outs | Get Opted Out Numbers



## AddA2PSMSOptOuts

> OptOutBulkAssignResponse AddA2PSMSOptOuts (string accountId, OptOutBulkAssignRequest optOutBulkAssignRequest = null)

Assign Multiple Opted Out/In Numbers

Adds multiple opt-outs and/or opt-ins for the specified sender number and a set of recipient numbers.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AddA2PSMSOptOutsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new HighVolumeSMSApi(Configuration.Default);
            var accountId = "accountId_example";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session
            var optOutBulkAssignRequest = new OptOutBulkAssignRequest(); // OptOutBulkAssignRequest | Consists of `from` field and `optOuts` and `optIns` lists. Both `optOuts` and `optIns` can be empty but not simultaneously - at least one of the lists must be entered. (optional) 

            try
            {
                // Assign Multiple Opted Out/In Numbers
                OptOutBulkAssignResponse result = apiInstance.AddA2PSMSOptOuts(accountId, optOutBulkAssignRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling HighVolumeSMSApi.AddA2PSMSOptOuts: " + e.Message );
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
 **accountId** | **string**| Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session | 
 **optOutBulkAssignRequest** | [**OptOutBulkAssignRequest**](OptOutBulkAssignRequest.md)| Consists of &#x60;from&#x60; field and &#x60;optOuts&#x60; and &#x60;optIns&#x60; lists. Both &#x60;optOuts&#x60; and &#x60;optIns&#x60; can be empty but not simultaneously - at least one of the lists must be entered. | [optional] 

### Return type

[**OptOutBulkAssignResponse**](OptOutBulkAssignResponse.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The results of adding opt-outs and opt-ins. |  -  |
| **400** | Invalid Request |  -  |
| **500** | Service Unavailable |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## AggregateA2PSMSStatuses

> MessageStatusesResponse AggregateA2PSMSStatuses (string accountId, string batchId = null, SmsDirectionEnum? direction = null, DateTime? dateFrom = null, DateTime? dateTo = null, List<string> phoneNumber = null)

List A2P SMS Statuses

Retrieves a set of message counts by message status and error codes filtered by dates, batchId and message direction.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AggregateA2PSMSStatusesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new HighVolumeSMSApi(Configuration.Default);
            var accountId = "accountId_example";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session
            var batchId = 55577;  // string | Internal identifier of a message batch to filter the response (optional) 
            var direction = Inbound;  // SmsDirectionEnum? | Direction of a message to filter the message list result. By default there is no filter applied - both Inbound and Outbound messages are returned (optional) 
            var dateFrom = 2020-11-09T16:07:52.597Z;  // DateTime? | The end of the time range to filter the results in ISO 8601 format including timezone. Default is the 'dateTo' minus 24 hours (optional) 
            var dateTo = 2020-11-25T16:07:52.597Z;  // DateTime? | The end of the time range to filter the results in ISO 8601 format including timezone. Default is the current time (optional) 
            var phoneNumber = new List<string>(); // List<string> | List of phone numbers (specified in 'to' or 'from' fields of a message) to filter the results. Maximum number of phone numbers allowed to be specified as filters is 15 (optional) 

            try
            {
                // List A2P SMS Statuses
                MessageStatusesResponse result = apiInstance.AggregateA2PSMSStatuses(accountId, batchId, direction, dateFrom, dateTo, phoneNumber);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling HighVolumeSMSApi.AggregateA2PSMSStatuses: " + e.Message );
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
 **accountId** | **string**| Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session | 
 **batchId** | **string**| Internal identifier of a message batch to filter the response | [optional] 
 **direction** | **SmsDirectionEnum?**| Direction of a message to filter the message list result. By default there is no filter applied - both Inbound and Outbound messages are returned | [optional] 
 **dateFrom** | **DateTime?**| The end of the time range to filter the results in ISO 8601 format including timezone. Default is the &#39;dateTo&#39; minus 24 hours | [optional] 
 **dateTo** | **DateTime?**| The end of the time range to filter the results in ISO 8601 format including timezone. Default is the current time | [optional] 
 **phoneNumber** | [**List&lt;string&gt;**](string.md)| List of phone numbers (specified in &#39;to&#39; or &#39;from&#39; fields of a message) to filter the results. Maximum number of phone numbers allowed to be specified as filters is 15 | [optional] 

### Return type

[**MessageStatusesResponse**](MessageStatusesResponse.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The statuses of the messages sent by the account filtered by criteria specified in the query |  -  |
| **400** | Invalid request |  -  |
| **401** | Unauthorized |  -  |
| **404** | No resource found for the account |  -  |
| **500** | Service Unavailable |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CreateA2PSMS

> MessageBatchResponse CreateA2PSMS (string accountId, MessageBatchCreateRequest messageBatchCreateRequest = null)

Send A2P SMS

Allows to send high volume of A2P (Application-to-Person) SMS messages (in message batches). Only phone number with the `A2PSmsSender` feature can be used as a sender. 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateA2PSMSExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new HighVolumeSMSApi(Configuration.Default);
            var accountId = "accountId_example";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session
            var messageBatchCreateRequest = new MessageBatchCreateRequest(); // MessageBatchCreateRequest | SMS batch payload (optional) 

            try
            {
                // Send A2P SMS
                MessageBatchResponse result = apiInstance.CreateA2PSMS(accountId, messageBatchCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling HighVolumeSMSApi.CreateA2PSMS: " + e.Message );
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
 **accountId** | **string**| Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session | 
 **messageBatchCreateRequest** | [**MessageBatchCreateRequest**](MessageBatchCreateRequest.md)| SMS batch payload | [optional] 

### Return type

[**MessageBatchResponse**](MessageBatchResponse.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Message batch created |  -  |
| **400** | Validation Failed, Invalid Request |  -  |
| **401** | Unauthorized error |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListA2PBatches

> BatchListResponse ListA2PBatches (string accountId, DateTime? dateFrom = null, DateTime? dateTo = null, string from = null, List<string> status = null, string pageToken = null, long? perPage = null)

Get A2P SMS Batches

Returns the list of A2P batches sent from the current account. The list can be filtered by message batch ID and/or from phone number.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListA2PBatchesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new HighVolumeSMSApi(Configuration.Default);
            var accountId = "accountId_example";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session
            var dateFrom = 2020-11-09T16:07:52.597Z;  // DateTime? | The end of the time range to filter the results in ISO 8601 format including timezone. Default is the 'dateTo' minus 24 hours (optional) 
            var dateTo = 2020-11-25T16:07:52.597Z;  // DateTime? | The end of the time range to filter the results in ISO 8601 format including timezone. Default is the current time (optional) 
            var from = 15551234455;  // string | Phone number in E.164 format from which the messages are going to be sent (optional) 
            var status = new List<string>(); // List<string> | A list of batch statuses to filter the results (optional) 
            var pageToken = pgt1;  // string | The page token of the page to be retrieved (optional) 
            var perPage = 1;  // long? | The number of records to be returned per page (optional) 

            try
            {
                // Get A2P SMS Batches
                BatchListResponse result = apiInstance.ListA2PBatches(accountId, dateFrom, dateTo, from, status, pageToken, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling HighVolumeSMSApi.ListA2PBatches: " + e.Message );
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
 **accountId** | **string**| Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session | 
 **dateFrom** | **DateTime?**| The end of the time range to filter the results in ISO 8601 format including timezone. Default is the &#39;dateTo&#39; minus 24 hours | [optional] 
 **dateTo** | **DateTime?**| The end of the time range to filter the results in ISO 8601 format including timezone. Default is the current time | [optional] 
 **from** | **string**| Phone number in E.164 format from which the messages are going to be sent | [optional] 
 **status** | [**List&lt;string&gt;**](string.md)| A list of batch statuses to filter the results | [optional] 
 **pageToken** | **string**| The page token of the page to be retrieved | [optional] 
 **perPage** | **long?**| The number of records to be returned per page | [optional] 

### Return type

[**BatchListResponse**](BatchListResponse.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The list of batches sent by the account and filtered by the criteria specified in the query parameters  |  -  |
| **400** | Invalid Request |  -  |
| **401** | Unauthorized |  -  |
| **404** | No resource found for the account. |  -  |
| **500** | Service Unavailable |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListA2PSMS

> MessageListResponse ListA2PSMS (string accountId, string batchId = null, SmsDirectionEnum? direction = null, DateTime? dateFrom = null, DateTime? dateTo = null, string view = null, List<string> phoneNumber = null, string pageToken = null, int? perPage = null)

Get A2P SMS List

Returns the list of outbound/inbound A2P messages sent from/to A2P phone numbers of the current account. The list can be filtered by message batch ID and/or phone number.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListA2PSMSExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new HighVolumeSMSApi(Configuration.Default);
            var accountId = "accountId_example";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session
            var batchId = 55577;  // string | Internal identifier of a message batch to filter the response (optional) 
            var direction = Inbound;  // SmsDirectionEnum? | Direction of a message to filter the message list result. By default there is no filter applied - both Inbound and Outbound messages are returned (optional) 
            var dateFrom = 2020-11-09T16:07:52.597Z;  // DateTime? | The end of the time range to filter the results in ISO 8601 format including timezone. Default is the 'dateTo' minus 24 hours (optional) 
            var dateTo = 2020-11-25T16:07:52.597Z;  // DateTime? | The end of the time range to filter the results in ISO 8601 format including timezone. Default is the current time (optional) 
            var view = "Simple";  // string | Indicates if the response has to be detailed, includes text in the response if detailed (optional)  (default to Simple)
            var phoneNumber = new List<string>(); // List<string> | List of phone numbers (specified in 'to' or 'from' fields of a message) to filter the results. Maximum number of phone numbers allowed to be specified as filters is 15 (optional) 
            var pageToken = pgt1;  // string | The page token of the page to be retrieved. (optional) 
            var perPage = 1;  // int? | The number of messages to be returned per request (optional)  (default to 1000)

            try
            {
                // Get A2P SMS List
                MessageListResponse result = apiInstance.ListA2PSMS(accountId, batchId, direction, dateFrom, dateTo, view, phoneNumber, pageToken, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling HighVolumeSMSApi.ListA2PSMS: " + e.Message );
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
 **accountId** | **string**| Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session | 
 **batchId** | **string**| Internal identifier of a message batch to filter the response | [optional] 
 **direction** | **SmsDirectionEnum?**| Direction of a message to filter the message list result. By default there is no filter applied - both Inbound and Outbound messages are returned | [optional] 
 **dateFrom** | **DateTime?**| The end of the time range to filter the results in ISO 8601 format including timezone. Default is the &#39;dateTo&#39; minus 24 hours | [optional] 
 **dateTo** | **DateTime?**| The end of the time range to filter the results in ISO 8601 format including timezone. Default is the current time | [optional] 
 **view** | **string**| Indicates if the response has to be detailed, includes text in the response if detailed | [optional] [default to Simple]
 **phoneNumber** | [**List&lt;string&gt;**](string.md)| List of phone numbers (specified in &#39;to&#39; or &#39;from&#39; fields of a message) to filter the results. Maximum number of phone numbers allowed to be specified as filters is 15 | [optional] 
 **pageToken** | **string**| The page token of the page to be retrieved. | [optional] 
 **perPage** | **int?**| The number of messages to be returned per request | [optional] [default to 1000]

### Return type

[**MessageListResponse**](MessageListResponse.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The list of messages sent by the account and filtered by the criteria specified in the query parameters  |  -  |
| **400** | Invalid Request |  -  |
| **401** | Unauthorized |  -  |
| **404** | No resource found for the account. |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ReadA2PBatch

> MessageBatchResponse ReadA2PBatch (string accountId, string batchId)

Get A2P SMS Batch

Returns information on a message batch.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadA2PBatchExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new HighVolumeSMSApi(Configuration.Default);
            var accountId = "accountId_example";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session
            var batchId = 55577;  // string | Internal identifier of a message batch to be retrieved

            try
            {
                // Get A2P SMS Batch
                MessageBatchResponse result = apiInstance.ReadA2PBatch(accountId, batchId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling HighVolumeSMSApi.ReadA2PBatch: " + e.Message );
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
 **accountId** | **string**| Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session | 
 **batchId** | **string**| Internal identifier of a message batch to be retrieved | 

### Return type

[**MessageBatchResponse**](MessageBatchResponse.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Message batch information |  -  |
| **400** | Invalid request |  -  |
| **401** | Unauthorized error |  -  |
| **404** | The batch is not found |  -  |
| **500** | Service is unavailable |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ReadA2PSMS

> MessageDetailsResponse ReadA2PSMS (string accountId, string messageId)

Get A2P SMS

Returns the details of an A2P SMS message by ID.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadA2PSMSExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new HighVolumeSMSApi(Configuration.Default);
            var accountId = "accountId_example";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session
            var messageId = 1234;  // string | Internal identifier of a message to be retrieved

            try
            {
                // Get A2P SMS
                MessageDetailsResponse result = apiInstance.ReadA2PSMS(accountId, messageId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling HighVolumeSMSApi.ReadA2PSMS: " + e.Message );
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
 **accountId** | **string**| Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session | 
 **messageId** | **string**| Internal identifier of a message to be retrieved | 

### Return type

[**MessageDetailsResponse**](MessageDetailsResponse.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The message is found and returned |  -  |
| **400** | Invalid request |  -  |
| **401** | Unauthorized error |  -  |
| **404** | The message is not found |  -  |
| **500** | Service is not available |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ReadA2PSMSOptOuts

> OptOutListResponse ReadA2PSMSOptOuts (string accountId, string from = null, string to = null, string status = null, string pageToken = null, int? perPage = null)

Get Opted Out Numbers

Returns the list of numbers opted out from the account. The list can be filtered by `to`/`from` phone number query parameters. Specifying `text/csv` in the Accept header downloads the data in CSV format.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadA2PSMSOptOutsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new HighVolumeSMSApi(Configuration.Default);
            var accountId = "accountId_example";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session
            var from = 15551234455;  // string | The sender's phone number in [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) format for filtering messages. The asterisk value \"*\" means any number in `from` field (optional) 
            var to = 15551237755;  // string | The receiver's phone number (`to` field) in [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) format for filtering messages (optional) 
            var status = optout;  // string | The status (opted out, opted in, or both) to be used as the filter (optional)  (default to optout)
            var pageToken = pgt1;  // string | The page token of the page to be retrieved (optional) 
            var perPage = 5;  // int? | The number of records to be returned for the page (optional)  (default to 1000)

            try
            {
                // Get Opted Out Numbers
                OptOutListResponse result = apiInstance.ReadA2PSMSOptOuts(accountId, from, to, status, pageToken, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling HighVolumeSMSApi.ReadA2PSMSOptOuts: " + e.Message );
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
 **accountId** | **string**| Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session | 
 **from** | **string**| The sender&#39;s phone number in [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) format for filtering messages. The asterisk value \&quot;*\&quot; means any number in &#x60;from&#x60; field | [optional] 
 **to** | **string**| The receiver&#39;s phone number (&#x60;to&#x60; field) in [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) format for filtering messages | [optional] 
 **status** | **string**| The status (opted out, opted in, or both) to be used as the filter | [optional] [default to optout]
 **pageToken** | **string**| The page token of the page to be retrieved | [optional] 
 **perPage** | **int?**| The number of records to be returned for the page | [optional] [default to 1000]

### Return type

[**OptOutListResponse**](OptOutListResponse.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The list of opt records for the account filtered by the search criteria provided as query param |  -  |
| **400** | Invalid Request |  -  |
| **401** | Unauthorized |  -  |
| **404** | No resource found for the account |  -  |
| **500** | Service Unavailable |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

