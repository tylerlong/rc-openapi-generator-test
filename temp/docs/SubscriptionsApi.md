# Org.OpenAPITools.Api.SubscriptionsApi

All URIs are relative to *https://platform.ringcentral.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateSubscription**](SubscriptionsApi.md#createsubscription) | **POST** /restapi/v1.0/subscription | Create Subscription
[**DeleteSubscription**](SubscriptionsApi.md#deletesubscription) | **DELETE** /restapi/v1.0/subscription/{subscriptionId} | Cancel Subscription
[**ListSubscriptions**](SubscriptionsApi.md#listsubscriptions) | **GET** /restapi/v1.0/subscription | Get Subscription List
[**ReadSubscription**](SubscriptionsApi.md#readsubscription) | **GET** /restapi/v1.0/subscription/{subscriptionId} | Get Subscription
[**RenewSubscription**](SubscriptionsApi.md#renewsubscription) | **POST** /restapi/v1.0/subscription/{subscriptionId}/renew | Renew Subscription
[**UpdateSubscription**](SubscriptionsApi.md#updatesubscription) | **PUT** /restapi/v1.0/subscription/{subscriptionId} | Update Subscription



## CreateSubscription

> SubscriptionInfo CreateSubscription (CreateSubscriptionRequest createSubscriptionRequest)

Create Subscription

Creates a new subscription for the current authorized user / client application.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateSubscriptionExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SubscriptionsApi(Configuration.Default);
            var createSubscriptionRequest = new CreateSubscriptionRequest(); // CreateSubscriptionRequest | JSON body

            try
            {
                // Create Subscription
                SubscriptionInfo result = apiInstance.CreateSubscription(createSubscriptionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.CreateSubscription: " + e.Message );
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
 **createSubscriptionRequest** | [**CreateSubscriptionRequest**](CreateSubscriptionRequest.md)| JSON body | 

### Return type

[**SubscriptionInfo**](SubscriptionInfo.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteSubscription

> void DeleteSubscription (string subscriptionId)

Cancel Subscription

Cancels the existing subscription.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeleteSubscriptionExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SubscriptionsApi(Configuration.Default);
            var subscriptionId = 12345678;  // string | Internal identifier of a subscription

            try
            {
                // Cancel Subscription
                apiInstance.DeleteSubscription(subscriptionId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.DeleteSubscription: " + e.Message );
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
 **subscriptionId** | **string**| Internal identifier of a subscription | 

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


## ListSubscriptions

> SubscriptionListResource ListSubscriptions ()

Get Subscription List

Returns a list of subscriptions created by the user for the current authorized client application. 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListSubscriptionsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SubscriptionsApi(Configuration.Default);

            try
            {
                // Get Subscription List
                SubscriptionListResource result = apiInstance.ListSubscriptions();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.ListSubscriptions: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**SubscriptionListResource**](SubscriptionListResource.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of Subscriptions |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ReadSubscription

> SubscriptionInfo ReadSubscription (string subscriptionId)

Get Subscription

Returns the existing subscription by ID.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadSubscriptionExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SubscriptionsApi(Configuration.Default);
            var subscriptionId = 12345678;  // string | Internal identifier of a subscription

            try
            {
                // Get Subscription
                SubscriptionInfo result = apiInstance.ReadSubscription(subscriptionId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.ReadSubscription: " + e.Message );
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
 **subscriptionId** | **string**| Internal identifier of a subscription | 

### Return type

[**SubscriptionInfo**](SubscriptionInfo.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## RenewSubscription

> SubscriptionInfo RenewSubscription (string subscriptionId)

Renew Subscription

Renews the existing subscription (this request comes with empty body).

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RenewSubscriptionExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SubscriptionsApi(Configuration.Default);
            var subscriptionId = 12345678;  // string | Internal identifier of a subscription

            try
            {
                // Renew Subscription
                SubscriptionInfo result = apiInstance.RenewSubscription(subscriptionId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.RenewSubscription: " + e.Message );
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
 **subscriptionId** | **string**| Internal identifier of a subscription | 

### Return type

[**SubscriptionInfo**](SubscriptionInfo.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Subscription renewed successfully |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateSubscription

> SubscriptionInfo UpdateSubscription (string subscriptionId, UpdateSubscriptionRequest updateSubscriptionRequest)

Update Subscription

Updates the existing subscription. The client application can extend/narrow the list of events for which it receives notifications within this subscription. If event filters are specified, calling this method modifies them for the existing subscription. The method also allows to set the subscription expiration time. If other than `events` and `expiresIn` parameters are passed in the request they will be ignored. If the request body is empty then the specified subscription will be just renewed without any event filter modifications and with default expiration time. 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateSubscriptionExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SubscriptionsApi(Configuration.Default);
            var subscriptionId = 12345678;  // string | Internal identifier of a subscription
            var updateSubscriptionRequest = new UpdateSubscriptionRequest(); // UpdateSubscriptionRequest | JSON body

            try
            {
                // Update Subscription
                SubscriptionInfo result = apiInstance.UpdateSubscription(subscriptionId, updateSubscriptionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.UpdateSubscription: " + e.Message );
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
 **subscriptionId** | **string**| Internal identifier of a subscription | 
 **updateSubscriptionRequest** | [**UpdateSubscriptionRequest**](UpdateSubscriptionRequest.md)| JSON body | 

### Return type

[**SubscriptionInfo**](SubscriptionInfo.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

