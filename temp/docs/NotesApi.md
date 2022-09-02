# Org.OpenAPITools.Api.NotesApi

All URIs are relative to *https://platform.ringcentral.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateChatNote**](NotesApi.md#createchatnote) | **POST** /restapi/v1.0/glip/chats/{chatId}/notes | Create Note
[**DeleteNote**](NotesApi.md#deletenote) | **DELETE** /restapi/v1.0/glip/notes/{noteId} | Delete Note
[**ListChatNotes**](NotesApi.md#listchatnotes) | **GET** /restapi/v1.0/glip/chats/{chatId}/notes | Get Chat Notes
[**LockNote**](NotesApi.md#locknote) | **POST** /restapi/v1.0/glip/notes/{noteId}/lock | Lock Note
[**PatchNote**](NotesApi.md#patchnote) | **PATCH** /restapi/v1.0/glip/notes/{noteId} | Update Note
[**PublishNote**](NotesApi.md#publishnote) | **POST** /restapi/v1.0/glip/notes/{noteId}/publish | Publish Note
[**ReadUserNote**](NotesApi.md#readusernote) | **GET** /restapi/v1.0/glip/notes/{noteId} | Get Note
[**UnlockNote**](NotesApi.md#unlocknote) | **POST** /restapi/v1.0/glip/notes/{noteId}/unlock | Unlock Note



## CreateChatNote

> GlipNoteInfo CreateChatNote (string chatId, GlipNoteCreate glipNoteCreate)

Create Note

Creates a new note in the specified chat.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateChatNoteExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotesApi(Configuration.Default);
            var chatId = "chatId_example";  // string | Internal identifier of a chat to create a note in
            var glipNoteCreate = new GlipNoteCreate(); // GlipNoteCreate | 

            try
            {
                // Create Note
                GlipNoteInfo result = apiInstance.CreateChatNote(chatId, glipNoteCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling NotesApi.CreateChatNote: " + e.Message );
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
 **chatId** | **string**| Internal identifier of a chat to create a note in | 
 **glipNoteCreate** | [**GlipNoteCreate**](GlipNoteCreate.md)|  | 

### Return type

[**GlipNoteInfo**](GlipNoteInfo.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Some of parameters are missing or have invalid format. |  -  |
| **403** | You do not have permissions to create note in the specified group. |  -  |
| **404** | Group not found. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteNote

> void DeleteNote (string noteId)

Delete Note

Deletes the specified note.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeleteNoteExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotesApi(Configuration.Default);
            var noteId = "noteId_example";  // string | Internal identifier of a note to be deleted

            try
            {
                // Delete Note
                apiInstance.DeleteNote(noteId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling NotesApi.DeleteNote: " + e.Message );
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
 **noteId** | **string**| Internal identifier of a note to be deleted | 

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
| **400** | Note is locked by another user |  -  |
| **403** | You have no permissions to delete note |  -  |
| **404** | Note is not found |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListChatNotes

> GlipNotesInfo ListChatNotes (string chatId, string creationTimeTo = null, string creationTimeFrom = null, string creatorId = null, string status = null, string pageToken = null, int? recordCount = null)

Get Chat Notes

Returns the list of notes created in the specified chat.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListChatNotesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotesApi(Configuration.Default);
            var chatId = "chatId_example";  // string | Internal identifier of a chat to fetch notes from.
            var creationTimeTo = "creationTimeTo_example";  // string | The end datetime for resulting records in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format including timezone, e.g. 2019-03-10T18:23:45. The default value is Now. (optional) 
            var creationTimeFrom = "creationTimeFrom_example";  // string | The start datetime for resulting records in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format including timezone (optional) 
            var creatorId = "creatorId_example";  // string | Internal identifier of the user that created the note. Multiple values are supported (optional) 
            var status = "Active";  // string | Status of notes to be fetched; if not specified all notes are fetched by default. (optional) 
            var pageToken = "pageToken_example";  // string | Pagination token (optional) 
            var recordCount = 30;  // int? | Max number of notes to be fetched by one request; the value range is 1-250. (optional)  (default to 30)

            try
            {
                // Get Chat Notes
                GlipNotesInfo result = apiInstance.ListChatNotes(chatId, creationTimeTo, creationTimeFrom, creatorId, status, pageToken, recordCount);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling NotesApi.ListChatNotes: " + e.Message );
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
 **chatId** | **string**| Internal identifier of a chat to fetch notes from. | 
 **creationTimeTo** | **string**| The end datetime for resulting records in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format including timezone, e.g. 2019-03-10T18:23:45. The default value is Now. | [optional] 
 **creationTimeFrom** | **string**| The start datetime for resulting records in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format including timezone | [optional] 
 **creatorId** | **string**| Internal identifier of the user that created the note. Multiple values are supported | [optional] 
 **status** | **string**| Status of notes to be fetched; if not specified all notes are fetched by default. | [optional] 
 **pageToken** | **string**| Pagination token | [optional] 
 **recordCount** | **int?**| Max number of notes to be fetched by one request; the value range is 1-250. | [optional] [default to 30]

### Return type

[**GlipNotesInfo**](GlipNotesInfo.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Some of parameters are missing or have invalid format. |  -  |
| **403** | You do not have permissions to get such kind of information. |  -  |
| **404** | Group Not Found. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## LockNote

> void LockNote (string noteId)

Lock Note

Locks a note providing the user with the unique write access for 5 hours.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class LockNoteExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotesApi(Configuration.Default);
            var noteId = "noteId_example";  // string | Internal identifier of a note to be locked

            try
            {
                // Lock Note
                apiInstance.LockNote(noteId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling NotesApi.LockNote: " + e.Message );
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
 **noteId** | **string**| Internal identifier of a note to be locked | 

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
| **204** | No Сontent |  -  |
| **400** | Note is locked by another user |  -  |
| **403** | You have no permissions to lock the note |  -  |
| **404** | Note is not found |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PatchNote

> GlipNoteInfo PatchNote (string noteId, GlipNoteCreate glipNoteCreate)

Update Note

Edits a note. Notes can be edited by any user if posted to a chat. the user belongs to.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PatchNoteExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotesApi(Configuration.Default);
            var noteId = "noteId_example";  // string | Internal identifier of a note to be updated
            var glipNoteCreate = new GlipNoteCreate(); // GlipNoteCreate | 

            try
            {
                // Update Note
                GlipNoteInfo result = apiInstance.PatchNote(noteId, glipNoteCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling NotesApi.PatchNote: " + e.Message );
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
 **noteId** | **string**| Internal identifier of a note to be updated | 
 **glipNoteCreate** | [**GlipNoteCreate**](GlipNoteCreate.md)|  | 

### Return type

[**GlipNoteInfo**](GlipNoteInfo.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Note is locked by another user |  -  |
| **403** | You have no permissions to update the note |  -  |
| **404** | Note is not found |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PublishNote

> void PublishNote (string noteId)

Publish Note

Publishes a note making it visible to other users.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PublishNoteExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotesApi(Configuration.Default);
            var noteId = "noteId_example";  // string | Internal identifier of a note to be published

            try
            {
                // Publish Note
                apiInstance.PublishNote(noteId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling NotesApi.PublishNote: " + e.Message );
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
 **noteId** | **string**| Internal identifier of a note to be published | 

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
| **400** | User is not a creator of note |  -  |
| **404** | Note is not found |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ReadUserNote

> GetGlipNoteInfo ReadUserNote (string noteId)

Get Note

Returns the specified note(s). It is possible to fetch up to 50 notes per request.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadUserNoteExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotesApi(Configuration.Default);
            var noteId = "noteId_example";  // string | Internal identifier of a note to be fetched

            try
            {
                // Get Note
                GetGlipNoteInfo result = apiInstance.ReadUserNote(noteId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling NotesApi.ReadUserNote: " + e.Message );
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
 **noteId** | **string**| Internal identifier of a note to be fetched | 

### Return type

[**GetGlipNoteInfo**](GetGlipNoteInfo.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | When note is not found. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UnlockNote

> void UnlockNote (string noteId)

Unlock Note

Unlocks a note letting other users edit this note. Once the note is locked (by another user) it cannot be unlocked during 5 hours since the lock datetime.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UnlockNoteExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotesApi(Configuration.Default);
            var noteId = "noteId_example";  // string | Internal identifier of a note to be unlocked

            try
            {
                // Unlock Note
                apiInstance.UnlockNote(noteId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling NotesApi.UnlockNote: " + e.Message );
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
 **noteId** | **string**| Internal identifier of a note to be unlocked | 

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
| **400** | Note is locked by another user |  -  |
| **403** | You have no permissions to unlock the note |  -  |
| **404** | Note is not found |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

