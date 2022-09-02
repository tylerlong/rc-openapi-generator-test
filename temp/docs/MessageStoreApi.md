# Org.OpenAPITools.Api.MessageStoreApi

All URIs are relative to *https://platform.ringcentral.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteMessage**](MessageStoreApi.md#deletemessage) | **DELETE** /restapi/v1.0/account/{accountId}/extension/{extensionId}/message-store/{messageId} | Delete Message
[**DeleteMessageByFilter**](MessageStoreApi.md#deletemessagebyfilter) | **DELETE** /restapi/v1.0/account/{accountId}/extension/{extensionId}/message-store | Delete Conversation
[**ListMessages**](MessageStoreApi.md#listmessages) | **GET** /restapi/v1.0/account/{accountId}/extension/{extensionId}/message-store | Get Message List
[**ReadMessage**](MessageStoreApi.md#readmessage) | **GET** /restapi/v1.0/account/{accountId}/extension/{extensionId}/message-store/{messageId} | Get Message
[**ReadMessageContent**](MessageStoreApi.md#readmessagecontent) | **GET** /restapi/v1.0/account/{accountId}/extension/{extensionId}/message-store/{messageId}/content/{attachmentId} | Get Message Content
[**ReadMessageStoreConfiguration**](MessageStoreApi.md#readmessagestoreconfiguration) | **GET** /restapi/v1.0/account/{accountId}/message-store-configuration | Get Message Store Configuration
[**SyncMessages**](MessageStoreApi.md#syncmessages) | **GET** /restapi/v1.0/account/{accountId}/extension/{extensionId}/message-sync | Sync Messages
[**UpdateMessage**](MessageStoreApi.md#updatemessage) | **PUT** /restapi/v1.0/account/{accountId}/extension/{extensionId}/message-store/{messageId} | Update Message List
[**UpdateMessageStoreConfiguration**](MessageStoreApi.md#updatemessagestoreconfiguration) | **PUT** /restapi/v1.0/account/{accountId}/message-store-configuration | Update Message Store Configuration



## DeleteMessage

> void DeleteMessage (string accountId, string extensionId, List<long> messageId, bool? purge = null, long? conversationId = null)

Delete Message

Deletes message(s) by the given message ID(s). The first call of this method transfers the message to the 'Delete' status. The second call transfers the deleted message to the 'Purged' status. If it is required to make the message 'Purged' immediately (from the first call), then set the query parameter purge to 'True'.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeleteMessageExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MessageStoreApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")
            var messageId = new List<long>(); // List<long> | Internal identifier of a message
            var purge = false;  // bool? | If the value is 'True', then the message is purged immediately with all the attachments (optional)  (default to false)
            var conversationId = 789L;  // long? | Internal identifier of a message thread (optional) 

            try
            {
                // Delete Message
                apiInstance.DeleteMessage(accountId, extensionId, messageId, purge, conversationId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MessageStoreApi.DeleteMessage: " + e.Message );
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
 **messageId** | [**List&lt;long&gt;**](long.md)| Internal identifier of a message | 
 **purge** | **bool?**| If the value is &#39;True&#39;, then the message is purged immediately with all the attachments | [optional] [default to false]
 **conversationId** | **long?**| Internal identifier of a message thread | [optional] 

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


## DeleteMessageByFilter

> void DeleteMessageByFilter (string extensionId, string accountId, List<string> conversationId = null, DateTime? dateTo = null, string type = null)

Delete Conversation

Deletes conversation(s) by conversation ID(s). Batch request is supported, max number of IDs passed as query/path parameters is 50. Alternative syntax is supported - user conversations can be deleted by passing multiple IDs in request body as an array of string, max number of conversation IDs passed in request body is 100. In this case asterisk is used in the path instead of IDs

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeleteMessageByFilterExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MessageStoreApi(Configuration.Default);
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var conversationId = new List<string>(); // List<string> |  (optional) 
            var dateTo = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Messages received earlier then the date specified will be deleted. The default value is current datetime (optional) 
            var type = "Fax";  // string | Type of messages to be deleted (optional)  (default to All)

            try
            {
                // Delete Conversation
                apiInstance.DeleteMessageByFilter(extensionId, accountId, conversationId, dateTo, type);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MessageStoreApi.DeleteMessageByFilter: " + e.Message );
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
 **conversationId** | [**List&lt;string&gt;**](string.md)|  | [optional] 
 **dateTo** | **DateTime?**| Messages received earlier then the date specified will be deleted. The default value is current datetime | [optional] 
 **type** | **string**| Type of messages to be deleted | [optional] [default to All]

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


## ListMessages

> GetMessageList ListMessages (string accountId, string extensionId, List<string> availability = null, int? conversationId = null, DateTime? dateFrom = null, DateTime? dateTo = null, List<string> direction = null, bool? distinctConversations = null, List<string> messageType = null, List<string> readStatus = null, int? page = null, int? perPage = null, string phoneNumber = null)

Get Message List

Returns the list of messages from an extension mailbox.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListMessagesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MessageStoreApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")
            var availability = new List<string>(); // List<string> | Specifies the availability status for the resulting messages. Multiple values are accepted (optional) 
            var conversationId = 56;  // int? | Specifies the conversation identifier for the resulting messages (optional) 
            var dateFrom = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | The start datetime for resulting messages in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is dateTo minus 24 hours (optional) 
            var dateTo = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | The end datetime for resulting messages in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is current time (optional) 
            var direction = new List<string>(); // List<string> | The direction for the resulting messages. If not specified, both inbound and outbound messages are returned. Multiple values are accepted (optional) 
            var distinctConversations = true;  // bool? | If 'True', then the latest messages per every conversation ID are returned (optional) 
            var messageType = new List<string>(); // List<string> | The type of the resulting messages. If not specified, all messages without message type filtering are returned. Multiple values are accepted (optional) 
            var readStatus = new List<string>(); // List<string> | The read status for the resulting messages. Multiple values are accepted (optional) 
            var page = 1;  // int? | Indicates the page number to retrieve. Only positive number values are accepted (optional)  (default to 1)
            var perPage = 100;  // int? | Indicates the page size (number of items) (optional)  (default to 100)
            var phoneNumber = "phoneNumber_example";  // string | The phone number. If specified, messages are returned for this particular phone number only (optional) 

            try
            {
                // Get Message List
                GetMessageList result = apiInstance.ListMessages(accountId, extensionId, availability, conversationId, dateFrom, dateTo, direction, distinctConversations, messageType, readStatus, page, perPage, phoneNumber);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MessageStoreApi.ListMessages: " + e.Message );
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
 **availability** | [**List&lt;string&gt;**](string.md)| Specifies the availability status for the resulting messages. Multiple values are accepted | [optional] 
 **conversationId** | **int?**| Specifies the conversation identifier for the resulting messages | [optional] 
 **dateFrom** | **DateTime?**| The start datetime for resulting messages in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is dateTo minus 24 hours | [optional] 
 **dateTo** | **DateTime?**| The end datetime for resulting messages in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is current time | [optional] 
 **direction** | [**List&lt;string&gt;**](string.md)| The direction for the resulting messages. If not specified, both inbound and outbound messages are returned. Multiple values are accepted | [optional] 
 **distinctConversations** | **bool?**| If &#39;True&#39;, then the latest messages per every conversation ID are returned | [optional] 
 **messageType** | [**List&lt;string&gt;**](string.md)| The type of the resulting messages. If not specified, all messages without message type filtering are returned. Multiple values are accepted | [optional] 
 **readStatus** | [**List&lt;string&gt;**](string.md)| The read status for the resulting messages. Multiple values are accepted | [optional] 
 **page** | **int?**| Indicates the page number to retrieve. Only positive number values are accepted | [optional] [default to 1]
 **perPage** | **int?**| Indicates the page size (number of items) | [optional] [default to 100]
 **phoneNumber** | **string**| The phone number. If specified, messages are returned for this particular phone number only | [optional] 

### Return type

[**GetMessageList**](GetMessageList.md)

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


## ReadMessage

> GetMessageInfoResponse ReadMessage (string accountId, string extensionId, long messageId)

Get Message

Returns individual message record(s) by the given message ID(s). The length of inbound messages is unlimited. Batch request is supported.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadMessageExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MessageStoreApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")
            var messageId = 789L;  // long | Internal identifier of a message

            try
            {
                // Get Message
                GetMessageInfoResponse result = apiInstance.ReadMessage(accountId, extensionId, messageId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MessageStoreApi.ReadMessage: " + e.Message );
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
 **messageId** | **long**| Internal identifier of a message | 

### Return type

[**GetMessageInfoResponse**](GetMessageInfoResponse.md)

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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ReadMessageContent

> System.IO.Stream ReadMessageContent (string accountId, string extensionId, long attachmentId, long messageId, string range = null, string contentDisposition = null)

Get Message Content

Returns a specific message attachment data as media stream.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadMessageContentExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MessageStoreApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")
            var attachmentId = 789L;  // long | Internal identifier of a message attachment
            var messageId = 789L;  // long | Internal identifier of a message
            var range = "range_example";  // string |  (optional) 
            var contentDisposition = "Inline";  // string | Content disposition of a response (optional)  (default to Inline)

            try
            {
                // Get Message Content
                System.IO.Stream result = apiInstance.ReadMessageContent(accountId, extensionId, attachmentId, messageId, range, contentDisposition);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MessageStoreApi.ReadMessageContent: " + e.Message );
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
 **attachmentId** | **long**| Internal identifier of a message attachment | 
 **messageId** | **long**| Internal identifier of a message | 
 **range** | **string**|  | [optional] 
 **contentDisposition** | **string**| Content disposition of a response | [optional] [default to Inline]

### Return type

**System.IO.Stream**

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, image/tiff


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Attachment Data |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ReadMessageStoreConfiguration

> MessageStoreConfiguration ReadMessageStoreConfiguration (string accountId)

Get Message Store Configuration

Returns message store settings.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadMessageStoreConfigurationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MessageStoreApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")

            try
            {
                // Get Message Store Configuration
                MessageStoreConfiguration result = apiInstance.ReadMessageStoreConfiguration(accountId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MessageStoreApi.ReadMessageStoreConfiguration: " + e.Message );
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

[**MessageStoreConfiguration**](MessageStoreConfiguration.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## SyncMessages

> GetMessageSyncResponse SyncMessages (string accountId, string extensionId, long? conversationId = null, DateTime? dateFrom = null, DateTime? dateTo = null, List<string> direction = null, bool? distinctConversations = null, List<string> messageType = null, int? recordCount = null, string syncToken = null, string syncType = null)

Sync Messages

Synchronizes messages.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SyncMessagesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MessageStoreApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")
            var conversationId = 789L;  // long? | Conversation identifier for the resulting messages. Meaningful for SMS and Pager messages only. (optional) 
            var dateFrom = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | The start datetime for resulting messages in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is dateTo minus 24 hours (optional) 
            var dateTo = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | The end datetime for resulting messages in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is current time (optional) 
            var direction = new List<string>(); // List<string> | Direction for the resulting messages. If not specified, both inbound and outbound messages are returned. Multiple values are accepted (optional) 
            var distinctConversations = true;  // bool? | If 'True', then the latest messages per every conversation ID are returned (optional) 
            var messageType = new List<string>(); // List<string> | Type for the resulting messages. If not specified, all types of messages are returned. Multiple values are accepted (optional) 
            var recordCount = 56;  // int? | Limits the number of records to be returned (works in combination with dateFrom and dateTo if specified) (optional) 
            var syncToken = "syncToken_example";  // string | Value of syncToken property of last sync request response (optional) 
            var syncType = "FSync";  // string | Type of message synchronization (optional) 

            try
            {
                // Sync Messages
                GetMessageSyncResponse result = apiInstance.SyncMessages(accountId, extensionId, conversationId, dateFrom, dateTo, direction, distinctConversations, messageType, recordCount, syncToken, syncType);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MessageStoreApi.SyncMessages: " + e.Message );
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
 **conversationId** | **long?**| Conversation identifier for the resulting messages. Meaningful for SMS and Pager messages only. | [optional] 
 **dateFrom** | **DateTime?**| The start datetime for resulting messages in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is dateTo minus 24 hours | [optional] 
 **dateTo** | **DateTime?**| The end datetime for resulting messages in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is current time | [optional] 
 **direction** | [**List&lt;string&gt;**](string.md)| Direction for the resulting messages. If not specified, both inbound and outbound messages are returned. Multiple values are accepted | [optional] 
 **distinctConversations** | **bool?**| If &#39;True&#39;, then the latest messages per every conversation ID are returned | [optional] 
 **messageType** | [**List&lt;string&gt;**](string.md)| Type for the resulting messages. If not specified, all types of messages are returned. Multiple values are accepted | [optional] 
 **recordCount** | **int?**| Limits the number of records to be returned (works in combination with dateFrom and dateTo if specified) | [optional] 
 **syncToken** | **string**| Value of syncToken property of last sync request response | [optional] 
 **syncType** | **string**| Type of message synchronization | [optional] 

### Return type

[**GetMessageSyncResponse**](GetMessageSyncResponse.md)

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


## UpdateMessage

> GetMessageInfoResponse UpdateMessage (string accountId, string extensionId, List<long> messageId, string dateFrom = null, string type = null, string readStatus = null)

Update Message List

Updates message(s) by ID(s). Currently only message read status can be updated. Batch request is supported, max number of IDs passed as query/path parameters is 50. Alternative syntax is supported - user messages can be updated by passing multiple IDs in request body as an array of string, max number of IDs passed in request body is 1000. In this case asterisk is used in the path instead of IDs.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateMessageExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MessageStoreApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")
            var messageId = new List<long>(); // List<long> | Internal identifier of a message
            var dateFrom = "dateFrom_example";  // string |  (optional) 
            var type = "Fax";  // string |  (optional) 
            var readStatus = "Read";  // string | Read status of a message to be changed. Multiple values are accepted (optional) 

            try
            {
                // Update Message List
                GetMessageInfoResponse result = apiInstance.UpdateMessage(accountId, extensionId, messageId, dateFrom, type, readStatus);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MessageStoreApi.UpdateMessage: " + e.Message );
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
 **messageId** | [**List&lt;long&gt;**](long.md)| Internal identifier of a message | 
 **dateFrom** | **string**|  | [optional] 
 **type** | **string**|  | [optional] 
 **readStatus** | **string**| Read status of a message to be changed. Multiple values are accepted | [optional] 

### Return type

[**GetMessageInfoResponse**](GetMessageInfoResponse.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: multipart/mixed, application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **207** | Multi-Status |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateMessageStoreConfiguration

> MessageStoreConfiguration UpdateMessageStoreConfiguration (string accountId, MessageStoreConfiguration messageStoreConfiguration)

Update Message Store Configuration

Updates message store settings.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateMessageStoreConfigurationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MessageStoreApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var messageStoreConfiguration = new MessageStoreConfiguration(); // MessageStoreConfiguration | JSON body

            try
            {
                // Update Message Store Configuration
                MessageStoreConfiguration result = apiInstance.UpdateMessageStoreConfiguration(accountId, messageStoreConfiguration);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MessageStoreApi.UpdateMessageStoreConfiguration: " + e.Message );
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
 **messageStoreConfiguration** | [**MessageStoreConfiguration**](MessageStoreConfiguration.md)| JSON body | 

### Return type

[**MessageStoreConfiguration**](MessageStoreConfiguration.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

