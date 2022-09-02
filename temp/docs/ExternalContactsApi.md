# Org.OpenAPITools.Api.ExternalContactsApi

All URIs are relative to *https://platform.ringcentral.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddressBookBulkUpload**](ExternalContactsApi.md#addressbookbulkupload) | **POST** /restapi/v1.0/account/{accountId}/address-book-bulk-upload | Update Multiple Contacts
[**CreateContact**](ExternalContactsApi.md#createcontact) | **POST** /restapi/v1.0/account/{accountId}/extension/{extensionId}/address-book/contact | Create Contact
[**DeleteContact**](ExternalContactsApi.md#deletecontact) | **DELETE** /restapi/v1.0/account/{accountId}/extension/{extensionId}/address-book/contact/{contactId} | Delete Contact
[**GetAddressBookBulkUploadTask**](ExternalContactsApi.md#getaddressbookbulkuploadtask) | **GET** /restapi/v1.0/account/{accountId}/address-book-bulk-upload/tasks/{taskId} | Get Contacts Update Task
[**ListContacts**](ExternalContactsApi.md#listcontacts) | **GET** /restapi/v1.0/account/{accountId}/extension/{extensionId}/address-book/contact | Get Contact List
[**ListFavoriteContacts**](ExternalContactsApi.md#listfavoritecontacts) | **GET** /restapi/v1.0/account/{accountId}/extension/{extensionId}/favorite | Get Favorite Contact List
[**ReadContact**](ExternalContactsApi.md#readcontact) | **GET** /restapi/v1.0/account/{accountId}/extension/{extensionId}/address-book/contact/{contactId} | Get Contact
[**SyncAddressBook**](ExternalContactsApi.md#syncaddressbook) | **GET** /restapi/v1.0/account/{accountId}/extension/{extensionId}/address-book-sync | Address Book Synchronization
[**UpdateContact**](ExternalContactsApi.md#updatecontact) | **PUT** /restapi/v1.0/account/{accountId}/extension/{extensionId}/address-book/contact/{contactId} | Update Contact
[**UpdateFavoriteContactList**](ExternalContactsApi.md#updatefavoritecontactlist) | **PUT** /restapi/v1.0/account/{accountId}/extension/{extensionId}/favorite | Update Favorite Contact List



## AddressBookBulkUpload

> AddressBookBulkUploadResponse AddressBookBulkUpload (string accountId, AddressBookBulkUploadRequest addressBookBulkUploadRequest)

Update Multiple Contacts

Uploads multiple contacts for multiple extensions at once. Maximum 500 extensions can be uploaded per request. Max amount of contacts that can be uploaded per an extension is 10,000. Each contact uploaded to an extension is not visible to other extensions.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AddressBookBulkUploadExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ExternalContactsApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var addressBookBulkUploadRequest = new AddressBookBulkUploadRequest(); // AddressBookBulkUploadRequest | JSON body

            try
            {
                // Update Multiple Contacts
                AddressBookBulkUploadResponse result = apiInstance.AddressBookBulkUpload(accountId, addressBookBulkUploadRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.AddressBookBulkUpload: " + e.Message );
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
 **addressBookBulkUploadRequest** | [**AddressBookBulkUploadRequest**](AddressBookBulkUploadRequest.md)| JSON body | 

### Return type

[**AddressBookBulkUploadResponse**](AddressBookBulkUploadResponse.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Accepted |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CreateContact

> PersonalContactResource CreateContact (string accountId, string extensionId, string dialingPlan = null, PersonalContactRequest personalContactRequest = null)

Create Contact

Creates personal user contact.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateContactExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ExternalContactsApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")
            var dialingPlan = "dialingPlan_example";  // string | A country code value complying with the [ISO 3166-1 alpha-2](https://ru.wikipedia.org/wiki/ISO_3166-1_alpha-2) format. The default value is home country of the current extension (optional) 
            var personalContactRequest = new PersonalContactRequest(); // PersonalContactRequest |  (optional) 

            try
            {
                // Create Contact
                PersonalContactResource result = apiInstance.CreateContact(accountId, extensionId, dialingPlan, personalContactRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.CreateContact: " + e.Message );
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
 **dialingPlan** | **string**| A country code value complying with the [ISO 3166-1 alpha-2](https://ru.wikipedia.org/wiki/ISO_3166-1_alpha-2) format. The default value is home country of the current extension | [optional] 
 **personalContactRequest** | [**PersonalContactRequest**](PersonalContactRequest.md)|  | [optional] 

### Return type

[**PersonalContactResource**](PersonalContactResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | New Contact |  -  |
| **400** | Contact cannot be created: max contacts count reached ($limit) |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteContact

> void DeleteContact (string accountId, string extensionId, long contactId)

Delete Contact

Deletes contact(s) by ID(s). Batch request is supported.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeleteContactExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ExternalContactsApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")
            var contactId = 789L;  // long | Internal identifier of a contact record in the RingCentral database

            try
            {
                // Delete Contact
                apiInstance.DeleteContact(accountId, extensionId, contactId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.DeleteContact: " + e.Message );
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
 **contactId** | **long**| Internal identifier of a contact record in the RingCentral database | 

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


## GetAddressBookBulkUploadTask

> AddressBookBulkUploadResponse GetAddressBookBulkUploadTask (string accountId, string taskId)

Get Contacts Update Task

Returns the status of a task on adding multiple contacts to multiple extensions.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetAddressBookBulkUploadTaskExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ExternalContactsApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var taskId = "taskId_example";  // string | Internal identifier of a task

            try
            {
                // Get Contacts Update Task
                AddressBookBulkUploadResponse result = apiInstance.GetAddressBookBulkUploadTask(accountId, taskId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.GetAddressBookBulkUploadTask: " + e.Message );
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
 **taskId** | **string**| Internal identifier of a task | 

### Return type

[**AddressBookBulkUploadResponse**](AddressBookBulkUploadResponse.md)

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


## ListContacts

> ContactList ListContacts (string accountId, string extensionId, string startsWith = null, List<string> sortBy = null, int? page = null, int? perPage = null, List<string> phoneNumber = null)

Get Contact List

Returns user personal contacts.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListContactsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ExternalContactsApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")
            var startsWith = "startsWith_example";  // string | If specified, only contacts whose First name or Last name start with the mentioned substring are returned. Case-insensitive (optional) 
            var sortBy = new List<string>(); // List<string> | Sorts results by the specified property (optional) 
            var page = 1;  // int? | Indicates the page number to retrieve. Only positive number values are accepted (optional)  (default to 1)
            var perPage = 100;  // int? | Indicates the page size (number of items) (optional)  (default to 100)
            var phoneNumber = new List<string>(); // List<string> |  (optional) 

            try
            {
                // Get Contact List
                ContactList result = apiInstance.ListContacts(accountId, extensionId, startsWith, sortBy, page, perPage, phoneNumber);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.ListContacts: " + e.Message );
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
 **startsWith** | **string**| If specified, only contacts whose First name or Last name start with the mentioned substring are returned. Case-insensitive | [optional] 
 **sortBy** | [**List&lt;string&gt;**](string.md)| Sorts results by the specified property | [optional] 
 **page** | **int?**| Indicates the page number to retrieve. Only positive number values are accepted | [optional] [default to 1]
 **perPage** | **int?**| Indicates the page size (number of items) | [optional] [default to 100]
 **phoneNumber** | [**List&lt;string&gt;**](string.md)|  | [optional] 

### Return type

[**ContactList**](ContactList.md)

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


## ListFavoriteContacts

> FavoriteContactList ListFavoriteContacts (string accountId, string extensionId)

Get Favorite Contact List

Returns the list of favorite contacts of the current extension. Favorite contacts include both company contacts (extensions) and personal contacts (address book records).

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListFavoriteContactsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ExternalContactsApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")

            try
            {
                // Get Favorite Contact List
                FavoriteContactList result = apiInstance.ListFavoriteContacts(accountId, extensionId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.ListFavoriteContacts: " + e.Message );
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

[**FavoriteContactList**](FavoriteContactList.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Favorite Contact List |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ReadContact

> PersonalContactResource ReadContact (string accountId, string extensionId, long contactId)

Get Contact

Returns contact(s) by ID(s). Batch request is supported.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadContactExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ExternalContactsApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")
            var contactId = 789L;  // long | Internal identifier of a contact record in the RingCentral database

            try
            {
                // Get Contact
                PersonalContactResource result = apiInstance.ReadContact(accountId, extensionId, contactId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.ReadContact: " + e.Message );
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
 **contactId** | **long**| Internal identifier of a contact record in the RingCentral database | 

### Return type

[**PersonalContactResource**](PersonalContactResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | Contact |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## SyncAddressBook

> AddressBookSync SyncAddressBook (string accountId, string extensionId, string syncType = null, string syncToken = null, int? perPage = null, long? pageId = null)

Address Book Synchronization

Synchronizes user contacts.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SyncAddressBookExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ExternalContactsApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")
            var syncType = "FSync";  // string | Type of synchronization (optional) 
            var syncToken = "syncToken_example";  // string | Value of syncToken property of the last sync request response (optional) 
            var perPage = 56;  // int? | Number of records per page to be returned. The max number of records is 250, which is also the default. For 'FSync' if the number of records exceeds the parameter value (either specified or default), all of the pages can be retrieved in several requests. For 'ISync' if the number of records exceeds the page size, the number of incoming changes to this number is limited (optional) 
            var pageId = 789L;  // long? | Internal identifier of a page. It can be obtained from the 'nextPageId' parameter passed in response body (optional) 

            try
            {
                // Address Book Synchronization
                AddressBookSync result = apiInstance.SyncAddressBook(accountId, extensionId, syncType, syncToken, perPage, pageId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.SyncAddressBook: " + e.Message );
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
 **syncType** | **string**| Type of synchronization | [optional] 
 **syncToken** | **string**| Value of syncToken property of the last sync request response | [optional] 
 **perPage** | **int?**| Number of records per page to be returned. The max number of records is 250, which is also the default. For &#39;FSync&#39; if the number of records exceeds the parameter value (either specified or default), all of the pages can be retrieved in several requests. For &#39;ISync&#39; if the number of records exceeds the page size, the number of incoming changes to this number is limited | [optional] 
 **pageId** | **long?**| Internal identifier of a page. It can be obtained from the &#39;nextPageId&#39; parameter passed in response body | [optional] 

### Return type

[**AddressBookSync**](AddressBookSync.md)

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


## UpdateContact

> PersonalContactResource UpdateContact (string accountId, string extensionId, long contactId, string dialingPlan = null, PersonalContactRequest personalContactRequest = null)

Update Contact

Updates personal contact information by contact ID(s). Batch request is supported

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateContactExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ExternalContactsApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")
            var contactId = 789L;  // long | Internal identifier of a contact record in the RingCentral database
            var dialingPlan = "dialingPlan_example";  // string | A country code value complying with the [ISO 3166-1 alpha-2](https://ru.wikipedia.org/wiki/ISO_3166-1_alpha-2) format. The default value is home country of the current extension (optional) 
            var personalContactRequest = new PersonalContactRequest(); // PersonalContactRequest |  (optional) 

            try
            {
                // Update Contact
                PersonalContactResource result = apiInstance.UpdateContact(accountId, extensionId, contactId, dialingPlan, personalContactRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.UpdateContact: " + e.Message );
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
 **contactId** | **long**| Internal identifier of a contact record in the RingCentral database | 
 **dialingPlan** | **string**| A country code value complying with the [ISO 3166-1 alpha-2](https://ru.wikipedia.org/wiki/ISO_3166-1_alpha-2) format. The default value is home country of the current extension | [optional] 
 **personalContactRequest** | [**PersonalContactRequest**](PersonalContactRequest.md)|  | [optional] 

### Return type

[**PersonalContactResource**](PersonalContactResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | Success |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateFavoriteContactList

> FavoriteContactList UpdateFavoriteContactList (string accountId, string extensionId, FavoriteCollection favoriteCollection = null)

Update Favorite Contact List

Updates the list of favorite contacts of the current extension. Favorite contacts include both company contacts (extensions) and personal contacts (address book records).**Please note**: currently personal address book size is limited to 10 000 contacts.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateFavoriteContactListExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ExternalContactsApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var extensionId = "\"~\"";  // string | Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session (default to "~")
            var favoriteCollection = new FavoriteCollection(); // FavoriteCollection |  (optional) 

            try
            {
                // Update Favorite Contact List
                FavoriteContactList result = apiInstance.UpdateFavoriteContactList(accountId, extensionId, favoriteCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ExternalContactsApi.UpdateFavoriteContactList: " + e.Message );
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
 **favoriteCollection** | [**FavoriteCollection**](FavoriteCollection.md)|  | [optional] 

### Return type

[**FavoriteContactList**](FavoriteContactList.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Favorite Contact List |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

