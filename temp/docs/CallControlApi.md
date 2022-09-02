# Org.OpenAPITools.Api.CallControlApi

All URIs are relative to *https://platform.ringcentral.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AnswerCallParty**](CallControlApi.md#answercallparty) | **POST** /restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/answer | Answer Call Party
[**BridgeCallParty**](CallControlApi.md#bridgecallparty) | **POST** /restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/bridge | Bridge Call Party
[**CallFlipParty**](CallControlApi.md#callflipparty) | **POST** /restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/flip | Call Flip on Party
[**CallParkParty**](CallControlApi.md#callparkparty) | **POST** /restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/park | Call Park
[**CreateCallOutCallSession**](CallControlApi.md#createcalloutcallsession) | **POST** /restapi/v1.0/account/{accountId}/telephony/call-out | Make CallOut
[**CreateCallPartyWithBringIn**](CallControlApi.md#createcallpartywithbringin) | **POST** /restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/bring-in | Bring-In Call Party
[**CreateConferenceCallSession**](CallControlApi.md#createconferencecallsession) | **POST** /restapi/v1.0/account/{accountId}/telephony/conference | Start Conference Call Session
[**DeleteCallParty**](CallControlApi.md#deletecallparty) | **DELETE** /restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId} | Delete Call Party
[**DeleteCallSession**](CallControlApi.md#deletecallsession) | **DELETE** /restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId} | Drop Call Session
[**ForwardCallParty**](CallControlApi.md#forwardcallparty) | **POST** /restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/forward | Forward Call Party
[**HoldCallParty**](CallControlApi.md#holdcallparty) | **POST** /restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/hold | Hold Call Party
[**IgnoreCallInQueue**](CallControlApi.md#ignorecallinqueue) | **POST** /restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/ignore | Ignore Call in Queue
[**PauseResumeCallRecording**](CallControlApi.md#pauseresumecallrecording) | **PATCH** /restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/recordings/{recordingId} | Pause/Resume Recording
[**PickupCallParty**](CallControlApi.md#pickupcallparty) | **POST** /restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/pickup | Pickup Call
[**ReadCallPartyStatus**](CallControlApi.md#readcallpartystatus) | **GET** /restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId} | Get Call Party Status
[**ReadCallSessionStatus**](CallControlApi.md#readcallsessionstatus) | **GET** /restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId} | Get Call Session Status
[**RejectParty**](CallControlApi.md#rejectparty) | **POST** /restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/reject | Reject Call Party
[**ReplyParty**](CallControlApi.md#replyparty) | **POST** /restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/reply | Reply with Text
[**StartCallRecording**](CallControlApi.md#startcallrecording) | **POST** /restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/recordings | Create Recording
[**SuperviseCallParty**](CallControlApi.md#supervisecallparty) | **POST** /restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/supervise | Supervise Call Party
[**SuperviseCallSession**](CallControlApi.md#supervisecallsession) | **POST** /restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/supervise | Supervise Call Session
[**TransferCallParty**](CallControlApi.md#transfercallparty) | **POST** /restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/transfer | Transfer Call Party
[**UnholdCallParty**](CallControlApi.md#unholdcallparty) | **POST** /restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/unhold | Unhold Call Party
[**UpdateCallParty**](CallControlApi.md#updatecallparty) | **PATCH** /restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId} | Update Call Party



## AnswerCallParty

> CallParty AnswerCallParty (string accountId, string telephonySessionId, string partyId, AnswerTarget answerTarget)

Answer Call Party

Answers a call on a certain device by passing the corresponding device ID in request body. Supported for call forwarding, call transfer, call flip and call queues.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AnswerCallPartyExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CallControlApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var telephonySessionId = "telephonySessionId_example";  // string | Internal identifier of a call session
            var partyId = "partyId_example";  // string | Internal identifier of a call party
            var answerTarget = new AnswerTarget(); // AnswerTarget | Distributes a non-answered call to the defined target. Only a single target is allowed

            try
            {
                // Answer Call Party
                CallParty result = apiInstance.AnswerCallParty(accountId, telephonySessionId, partyId, answerTarget);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CallControlApi.AnswerCallParty: " + e.Message );
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
 **telephonySessionId** | **string**| Internal identifier of a call session | 
 **partyId** | **string**| Internal identifier of a call party | 
 **answerTarget** | [**AnswerTarget**](AnswerTarget.md)| Distributes a non-answered call to the defined target. Only a single target is allowed | 

### Return type

[**CallParty**](CallParty.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Call Session Information |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **409** | Conflict |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Temporary Unavailable |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## BridgeCallParty

> CallParty BridgeCallParty (string accountId, string telephonySessionId, string partyId, BridgeTargetRequest bridgeTargetRequest)

Bridge Call Party

Allows the user to connect multiple call session participants over a conference call bridge. The current active call session ID and party ID of the user within this session should be specified in path; the bridged call session ID and party ID of the user within that session should be specified in request body. Thus the user connects participants of two sessions into one conference call using his/her own party IDs from both sessions.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BridgeCallPartyExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CallControlApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var telephonySessionId = "telephonySessionId_example";  // string | Internal identifier of a call session
            var partyId = "partyId_example";  // string | Internal identifier of a call party
            var bridgeTargetRequest = new BridgeTargetRequest(); // BridgeTargetRequest | Defines target call session and call party to be bridged

            try
            {
                // Bridge Call Party
                CallParty result = apiInstance.BridgeCallParty(accountId, telephonySessionId, partyId, bridgeTargetRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CallControlApi.BridgeCallParty: " + e.Message );
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
 **telephonySessionId** | **string**| Internal identifier of a call session | 
 **partyId** | **string**| Internal identifier of a call party | 
 **bridgeTargetRequest** | [**BridgeTargetRequest**](BridgeTargetRequest.md)| Defines target call session and call party to be bridged | 

### Return type

[**CallParty**](CallParty.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Bridged Call Info |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **409** | Conflict |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Temporary Unavailable |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CallFlipParty

> void CallFlipParty (string accountId, string telephonySessionId, string partyId, CallPartyFlip callPartyFlip)

Call Flip on Party

Performs call flip procedure by holding opposite party and calling to the specified target

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CallFlipPartyExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CallControlApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var telephonySessionId = "telephonySessionId_example";  // string | Internal identifier of a call session
            var partyId = "partyId_example";  // string | Internal identifier of a call party
            var callPartyFlip = new CallPartyFlip(); // CallPartyFlip | JSON body

            try
            {
                // Call Flip on Party
                apiInstance.CallFlipParty(accountId, telephonySessionId, partyId, callPartyFlip);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CallControlApi.CallFlipParty: " + e.Message );
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
 **telephonySessionId** | **string**| Internal identifier of a call session | 
 **partyId** | **string**| Internal identifier of a call party | 
 **callPartyFlip** | [**CallPartyFlip**](CallPartyFlip.md)| JSON body | 

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
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **409** | Conflict |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Temporary Unavailable |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CallParkParty

> CallParty CallParkParty (string accountId, string telephonySessionId, string partyId)

Call Park

Parks a call to a virtual location from where it can further be retrieved by any user from any phone of the system. The call session and call party identifiers should be specified in path. Currently the users can park only their own incoming calls. Up to 50 calls can be parked simultaneously. Park location starts with asterisk (*) and ranges 801-899.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CallParkPartyExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CallControlApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var telephonySessionId = "telephonySessionId_example";  // string | Internal identifier of a call session
            var partyId = "partyId_example";  // string | Internal identifier of a call party

            try
            {
                // Call Park
                CallParty result = apiInstance.CallParkParty(accountId, telephonySessionId, partyId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CallControlApi.CallParkParty: " + e.Message );
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
 **telephonySessionId** | **string**| Internal identifier of a call session | 
 **partyId** | **string**| Internal identifier of a call party | 

### Return type

[**CallParty**](CallParty.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **409** | Conflict |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Temporary Unavailable |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CreateCallOutCallSession

> CallSession CreateCallOutCallSession (string accountId, MakeCallOutRequest makeCallOutRequest)

Make CallOut

Creates a new outbound call out session. Currently this method is supported for Softphone/Hardphone only, since device IDs for WebRTC/Mobile apps cannot be obtained.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateCallOutCallSessionExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CallControlApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var makeCallOutRequest = new MakeCallOutRequest(); // MakeCallOutRequest | JSON body

            try
            {
                // Make CallOut
                CallSession result = apiInstance.CreateCallOutCallSession(accountId, makeCallOutRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CallControlApi.CreateCallOutCallSession: " + e.Message );
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
 **makeCallOutRequest** | [**MakeCallOutRequest**](MakeCallOutRequest.md)| JSON body | 

### Return type

[**CallSession**](CallSession.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **503** | Service Temporary Unavailable |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CreateCallPartyWithBringIn

> CallParty CreateCallPartyWithBringIn (string accountId, string telephonySessionId, AddPartyRequest addPartyRequest)

Bring-In Call Party

Adds a new party to the call session by bringing-in an established SIP call connection. The maximum number of parties to bring-in is 10; only 1 call party can be added per request. Currently the method is supported for sessions of 'Conference' origin only.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateCallPartyWithBringInExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CallControlApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var telephonySessionId = "telephonySessionId_example";  // string | Internal identifier of a call session
            var addPartyRequest = new AddPartyRequest(); // AddPartyRequest | JSON body

            try
            {
                // Bring-In Call Party
                CallParty result = apiInstance.CreateCallPartyWithBringIn(accountId, telephonySessionId, addPartyRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CallControlApi.CreateCallPartyWithBringIn: " + e.Message );
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
 **telephonySessionId** | **string**| Internal identifier of a call session | 
 **addPartyRequest** | [**AddPartyRequest**](AddPartyRequest.md)| JSON body | 

### Return type

[**CallParty**](CallParty.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **409** | Conflict |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Temporary Unavailable |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CreateConferenceCallSession

> CallSessionObject CreateConferenceCallSession (string accountId)

Start Conference Call Session

Initiates a conference call session.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateConferenceCallSessionExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CallControlApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")

            try
            {
                // Start Conference Call Session
                CallSessionObject result = apiInstance.CreateConferenceCallSession(accountId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CallControlApi.CreateConferenceCallSession: " + e.Message );
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

[**CallSessionObject**](CallSessionObject.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **409** | Conflict |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Temporary Unavailable |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteCallParty

> void DeleteCallParty (string accountId, string telephonySessionId, string partyId)

Delete Call Party

Removes a party from a call session by ID. A party can be deleted only if supervised or parked. It is possible to delete only one conference participant per request.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeleteCallPartyExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CallControlApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var telephonySessionId = "telephonySessionId_example";  // string | Internal identifier of a call session
            var partyId = "partyId_example";  // string | Internal identifier of a call party

            try
            {
                // Delete Call Party
                apiInstance.DeleteCallParty(accountId, telephonySessionId, partyId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CallControlApi.DeleteCallParty: " + e.Message );
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
 **telephonySessionId** | **string**| Internal identifier of a call session | 
 **partyId** | **string**| Internal identifier of a call party | 

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
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Temporary Unavailable |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteCallSession

> void DeleteCallSession (string accountId, string telephonySessionId)

Drop Call Session

Drops a call session.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeleteCallSessionExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CallControlApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var telephonySessionId = "telephonySessionId_example";  // string | Internal identifier of a call session

            try
            {
                // Drop Call Session
                apiInstance.DeleteCallSession(accountId, telephonySessionId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CallControlApi.DeleteCallSession: " + e.Message );
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
 **telephonySessionId** | **string**| Internal identifier of a call session | 

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
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Temporary Unavailable |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ForwardCallParty

> CallParty ForwardCallParty (string accountId, string telephonySessionId, string partyId, ForwardTarget forwardTarget)

Forward Call Party

Forwards a non-answered incoming call to the specified call party. Applicable for a call session in \"Setup\" or \"Proceeding\" state.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ForwardCallPartyExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CallControlApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var telephonySessionId = "telephonySessionId_example";  // string | Internal identifier of a call session
            var partyId = "partyId_example";  // string | Internal identifier of a call party
            var forwardTarget = new ForwardTarget(); // ForwardTarget | Specifies a call party to which the call will be forwarded. Only a single call party is allowed.

            try
            {
                // Forward Call Party
                CallParty result = apiInstance.ForwardCallParty(accountId, telephonySessionId, partyId, forwardTarget);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CallControlApi.ForwardCallParty: " + e.Message );
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
 **telephonySessionId** | **string**| Internal identifier of a call session | 
 **partyId** | **string**| Internal identifier of a call party | 
 **forwardTarget** | [**ForwardTarget**](ForwardTarget.md)| Specifies a call party to which the call will be forwarded. Only a single call party is allowed. | 

### Return type

[**CallParty**](CallParty.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **409** | Conflict |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Temporary Unavailable |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## HoldCallParty

> CallParty HoldCallParty (string accountId, string telephonySessionId, string partyId)

Hold Call Party

Puts the party to stand-alone mode and starts to play Hold Music according to configuration & state to peers. There is a known limitation for Hold API - hold via REST API doesn't work with hold placed via RingCentral apps or HardPhone. It means that if you muted participant via Call Control API and RingCentral Desktop app, then you need to unhold both endpoints to remove Hold Music and bring media back.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class HoldCallPartyExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CallControlApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var telephonySessionId = "telephonySessionId_example";  // string | Internal identifier of a call session
            var partyId = "partyId_example";  // string | Internal identifier of a call party

            try
            {
                // Hold Call Party
                CallParty result = apiInstance.HoldCallParty(accountId, telephonySessionId, partyId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CallControlApi.HoldCallParty: " + e.Message );
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
 **telephonySessionId** | **string**| Internal identifier of a call session | 
 **partyId** | **string**| Internal identifier of a call party | 

### Return type

[**CallParty**](CallParty.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **409** | Conflict |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Temporary Unavailable |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## IgnoreCallInQueue

> void IgnoreCallInQueue (string accountId, string telephonySessionId, string partyId, IgnoreRequestBody ignoreRequestBody)

Ignore Call in Queue

Ignores a call to a call queue agent in `Setup` or `Proceeding` state.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IgnoreCallInQueueExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CallControlApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var telephonySessionId = "telephonySessionId_example";  // string | Internal identifier of a call session
            var partyId = "partyId_example";  // string | Internal identifier of a call party
            var ignoreRequestBody = new IgnoreRequestBody(); // IgnoreRequestBody | JSON body

            try
            {
                // Ignore Call in Queue
                apiInstance.IgnoreCallInQueue(accountId, telephonySessionId, partyId, ignoreRequestBody);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CallControlApi.IgnoreCallInQueue: " + e.Message );
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
 **telephonySessionId** | **string**| Internal identifier of a call session | 
 **partyId** | **string**| Internal identifier of a call party | 
 **ignoreRequestBody** | [**IgnoreRequestBody**](IgnoreRequestBody.md)| JSON body | 

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
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **409** | Conflict |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PauseResumeCallRecording

> CallRecording PauseResumeCallRecording (string brandId, string accountId, string telephonySessionId, string partyId, string recordingId, CallRecordingUpdate callRecordingUpdate)

Pause/Resume Recording

Pause/resume recording

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PauseResumeCallRecordingExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CallControlApi(Configuration.Default);
            var brandId = "\"~\"";  // string | Identifies a brand of a logged in user or a brand of a sign-up session (default to "~")
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var telephonySessionId = "telephonySessionId_example";  // string | Internal identifier of a call session
            var partyId = "partyId_example";  // string | Internal identifier of a call party
            var recordingId = "recordingId_example";  // string | Internal identifier of a recording
            var callRecordingUpdate = new CallRecordingUpdate(); // CallRecordingUpdate | JSON body

            try
            {
                // Pause/Resume Recording
                CallRecording result = apiInstance.PauseResumeCallRecording(brandId, accountId, telephonySessionId, partyId, recordingId, callRecordingUpdate);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CallControlApi.PauseResumeCallRecording: " + e.Message );
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
 **brandId** | **string**| Identifies a brand of a logged in user or a brand of a sign-up session | [default to &quot;~&quot;]
 **accountId** | **string**| Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session | [default to &quot;~&quot;]
 **telephonySessionId** | **string**| Internal identifier of a call session | 
 **partyId** | **string**| Internal identifier of a call party | 
 **recordingId** | **string**| Internal identifier of a recording | 
 **callRecordingUpdate** | [**CallRecordingUpdate**](CallRecordingUpdate.md)| JSON body | 

### Return type

[**CallRecording**](CallRecording.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **409** | Conflict |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Temporary Unavailable |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PickupCallParty

> CallParty PickupCallParty (string accountId, string telephonySessionId, string partyId, PickupTarget pickupTarget)

Pickup Call

Picks up a call parked to the specified park location.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PickupCallPartyExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CallControlApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var telephonySessionId = "telephonySessionId_example";  // string | Internal identifier of a call session
            var partyId = "partyId_example";  // string | Internal identifier of a call party
            var pickupTarget = new PickupTarget(); // PickupTarget | Distributes a non-answered call to the defined target. Only a single target is allowed

            try
            {
                // Pickup Call
                CallParty result = apiInstance.PickupCallParty(accountId, telephonySessionId, partyId, pickupTarget);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CallControlApi.PickupCallParty: " + e.Message );
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
 **telephonySessionId** | **string**| Internal identifier of a call session | 
 **partyId** | **string**| Internal identifier of a call party | 
 **pickupTarget** | [**PickupTarget**](PickupTarget.md)| Distributes a non-answered call to the defined target. Only a single target is allowed | 

### Return type

[**CallParty**](CallParty.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **409** | Conflict |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ReadCallPartyStatus

> CallParty ReadCallPartyStatus (string accountId, string telephonySessionId, string partyId)

Get Call Party Status

Returns a call party status by ID.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadCallPartyStatusExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CallControlApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var telephonySessionId = "telephonySessionId_example";  // string | Internal identifier of a call session
            var partyId = "partyId_example";  // string | Internal identifier of a call party

            try
            {
                // Get Call Party Status
                CallParty result = apiInstance.ReadCallPartyStatus(accountId, telephonySessionId, partyId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CallControlApi.ReadCallPartyStatus: " + e.Message );
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
 **telephonySessionId** | **string**| Internal identifier of a call session | 
 **partyId** | **string**| Internal identifier of a call party | 

### Return type

[**CallParty**](CallParty.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Temporary Unavailable |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ReadCallSessionStatus

> CallSessionObject ReadCallSessionStatus (string accountId, string telephonySessionId, string timestamp = null, string timeout = null)

Get Call Session Status

Returns the status of a call session by ID.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadCallSessionStatusExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CallControlApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var telephonySessionId = "telephonySessionId_example";  // string | Internal identifier of a call session
            var timestamp = "timestamp_example";  // string | The date and time of a call session latest change (optional) 
            var timeout = "timeout_example";  // string | The time frame of awaiting for a status change before sending the resulting one in response (optional) 

            try
            {
                // Get Call Session Status
                CallSessionObject result = apiInstance.ReadCallSessionStatus(accountId, telephonySessionId, timestamp, timeout);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CallControlApi.ReadCallSessionStatus: " + e.Message );
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
 **telephonySessionId** | **string**| Internal identifier of a call session | 
 **timestamp** | **string**| The date and time of a call session latest change | [optional] 
 **timeout** | **string**| The time frame of awaiting for a status change before sending the resulting one in response | [optional] 

### Return type

[**CallSessionObject**](CallSessionObject.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **503** | Service Temporary Unavailable |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## RejectParty

> void RejectParty (string accountId, string telephonySessionId, string partyId)

Reject Call Party

Rejects an inbound call in a \"Setup\" or \"Proceeding\" state

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RejectPartyExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CallControlApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var telephonySessionId = "telephonySessionId_example";  // string | Internal identifier of a call session
            var partyId = "partyId_example";  // string | Internal identifier of a call party

            try
            {
                // Reject Call Party
                apiInstance.RejectParty(accountId, telephonySessionId, partyId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CallControlApi.RejectParty: " + e.Message );
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
 **telephonySessionId** | **string**| Internal identifier of a call session | 
 **partyId** | **string**| Internal identifier of a call party | 

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
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **409** | Conflict |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Temporary Unavailable |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ReplyParty

> ReplyParty ReplyParty (string accountId, string telephonySessionId, string partyId, CallPartyReply callPartyReply)

Reply with Text

Replies with text/pattern without picking up a call.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReplyPartyExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CallControlApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var telephonySessionId = "telephonySessionId_example";  // string | Internal identifier of a call session
            var partyId = "partyId_example";  // string | Internal identifier of a call party
            var callPartyReply = new CallPartyReply(); // CallPartyReply | JSON body

            try
            {
                // Reply with Text
                ReplyParty result = apiInstance.ReplyParty(accountId, telephonySessionId, partyId, callPartyReply);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CallControlApi.ReplyParty: " + e.Message );
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
 **telephonySessionId** | **string**| Internal identifier of a call session | 
 **partyId** | **string**| Internal identifier of a call party | 
 **callPartyReply** | [**CallPartyReply**](CallPartyReply.md)| JSON body | 

### Return type

[**ReplyParty**](ReplyParty.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **409** | Conflict |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Server is unable to process request just now |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## StartCallRecording

> void StartCallRecording (string accountId, string telephonySessionId, string partyId)

Create Recording

Starts a new call recording for the party

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class StartCallRecordingExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CallControlApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var telephonySessionId = "telephonySessionId_example";  // string | Internal identifier of a call session
            var partyId = "partyId_example";  // string | Internal identifier of a call party

            try
            {
                // Create Recording
                apiInstance.StartCallRecording(accountId, telephonySessionId, partyId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CallControlApi.StartCallRecording: " + e.Message );
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
 **telephonySessionId** | **string**| Internal identifier of a call session | 
 **partyId** | **string**| Internal identifier of a call party | 

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
| **201** | Created |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **409** | Conflict |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Temporary Unavailable |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## SuperviseCallParty

> PartySuperviseResponse SuperviseCallParty (string accountId, string telephonySessionId, string partyId, PartySuperviseRequest partySuperviseRequest)

Supervise Call Party

Allows to monitor a call party in 'Listen' mode. Input parameters are extension number of a monitored user and internal identifier of a supervisor's device. Call session and party identifiers should be specified in path. Please note that for this method dual channel audio flow is supported, which means that you need to make one more request for monitoring the second participant of a call. And as a result of each monitoring request the client receives SIP invite with the following header `p-rc-api-monitoring-ids` containing IDs of the monitored party and session. The flow is supported for calls with no more than 2 participants. Currently this method is supported for Softphone/Hardphone only, since device IDs for WebRTC/Mobile apps cannot be obtained.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SuperviseCallPartyExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CallControlApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var telephonySessionId = "telephonySessionId_example";  // string | Internal identifier of a call session
            var partyId = "partyId_example";  // string | Internal identifier of a call party
            var partySuperviseRequest = new PartySuperviseRequest(); // PartySuperviseRequest | JSON body

            try
            {
                // Supervise Call Party
                PartySuperviseResponse result = apiInstance.SuperviseCallParty(accountId, telephonySessionId, partyId, partySuperviseRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CallControlApi.SuperviseCallParty: " + e.Message );
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
 **telephonySessionId** | **string**| Internal identifier of a call session | 
 **partyId** | **string**| Internal identifier of a call party | 
 **partySuperviseRequest** | [**PartySuperviseRequest**](PartySuperviseRequest.md)| JSON body | 

### Return type

[**PartySuperviseResponse**](PartySuperviseResponse.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **409** | Conflict |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Temporary Unavailable |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## SuperviseCallSession

> SuperviseCallSession SuperviseCallSession (string accountId, string telephonySessionId, SuperviseCallSessionRequest superviseCallSessionRequest)

Supervise Call Session

Allows to monitor a call session in 'Listen' mode. Input parameters should contain internal identifiers of a monitored user and a supervisor's device. Call session should be specified in path. Please note that this method supports single channel audio flow, which means that audio of both call participants is mixed and delivered to the supervisor in single audio channel. Currently this method is supported for Softphone/Hardphone only, since device IDs for WebRTC/Mobile apps cannot be obtained.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SuperviseCallSessionExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CallControlApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var telephonySessionId = "telephonySessionId_example";  // string | Internal identifier of a call session
            var superviseCallSessionRequest = new SuperviseCallSessionRequest(); // SuperviseCallSessionRequest | JSON body

            try
            {
                // Supervise Call Session
                SuperviseCallSession result = apiInstance.SuperviseCallSession(accountId, telephonySessionId, superviseCallSessionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CallControlApi.SuperviseCallSession: " + e.Message );
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
 **telephonySessionId** | **string**| Internal identifier of a call session | 
 **superviseCallSessionRequest** | [**SuperviseCallSessionRequest**](SuperviseCallSessionRequest.md)| JSON body | 

### Return type

[**SuperviseCallSession**](SuperviseCallSession.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Temporary Unavailable |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## TransferCallParty

> CallParty TransferCallParty (string accountId, string telephonySessionId, string partyId, TransferTarget transferTarget)

Transfer Call Party

Transfers an answered call to the specified call party. Applicable for a call session in \"Answered\" or \"Hold\" state.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TransferCallPartyExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CallControlApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var telephonySessionId = "telephonySessionId_example";  // string | Internal identifier of a call session
            var partyId = "partyId_example";  // string | Internal identifier of a call party
            var transferTarget = new TransferTarget(); // TransferTarget | Specifies a call party to which the call will be transfered. Only a single call party is allowed.

            try
            {
                // Transfer Call Party
                CallParty result = apiInstance.TransferCallParty(accountId, telephonySessionId, partyId, transferTarget);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CallControlApi.TransferCallParty: " + e.Message );
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
 **telephonySessionId** | **string**| Internal identifier of a call session | 
 **partyId** | **string**| Internal identifier of a call party | 
 **transferTarget** | [**TransferTarget**](TransferTarget.md)| Specifies a call party to which the call will be transfered. Only a single call party is allowed. | 

### Return type

[**CallParty**](CallParty.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **409** | Conflict |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Temporary Unavailable |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UnholdCallParty

> CallParty UnholdCallParty (string accountId, string telephonySessionId, string partyId)

Unhold Call Party

Brings a party back into a call and stops to play Hold Music. There is a known limitation for Hold API - hold via REST API doesn't work with hold placed via RingCentral apps or HardPhone. It means that if you muted participant via Call Control API and RingCentral Desktop app, then you need to unhold both endpoints to remove Hold Music and bring media back.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UnholdCallPartyExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CallControlApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var telephonySessionId = "telephonySessionId_example";  // string | Internal identifier of a call session
            var partyId = "partyId_example";  // string | Internal identifier of a call party

            try
            {
                // Unhold Call Party
                CallParty result = apiInstance.UnholdCallParty(accountId, telephonySessionId, partyId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CallControlApi.UnholdCallParty: " + e.Message );
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
 **telephonySessionId** | **string**| Internal identifier of a call session | 
 **partyId** | **string**| Internal identifier of a call party | 

### Return type

[**CallParty**](CallParty.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **409** | Conflict |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Temporary Unavailable |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateCallParty

> CallParty UpdateCallParty (string accountId, string telephonySessionId, string partyId, PartyUpdateRequest partyUpdateRequest)

Update Call Party

Modifies a call party by ID. There is a known limitation for Mute scenario - mute via REST API doesn't work with mute placed via RingCentral apps or HardPhone. It means that if you muted participant via Call Control API and Ringcentral Desktop app you need to unmute both endpoints to bring the media back.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateCallPartyExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CallControlApi(Configuration.Default);
            var accountId = "\"~\"";  // string | Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session (default to "~")
            var telephonySessionId = "telephonySessionId_example";  // string | Internal identifier of a call session
            var partyId = "partyId_example";  // string | Internal identifier of a call party
            var partyUpdateRequest = new PartyUpdateRequest(); // PartyUpdateRequest | JSON body

            try
            {
                // Update Call Party
                CallParty result = apiInstance.UpdateCallParty(accountId, telephonySessionId, partyId, partyUpdateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CallControlApi.UpdateCallParty: " + e.Message );
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
 **telephonySessionId** | **string**| Internal identifier of a call session | 
 **partyId** | **string**| Internal identifier of a call party | 
 **partyUpdateRequest** | [**PartyUpdateRequest**](PartyUpdateRequest.md)| JSON body | 

### Return type

[**CallParty**](CallParty.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **409** | Conflict |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Temporary Unavailable |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

