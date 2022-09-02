# Org.OpenAPITools.Api.OAuthOIDCApi

All URIs are relative to *https://platform.ringcentral.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Authorize**](OAuthOIDCApi.md#authorize) | **GET** /restapi/oauth/authorize | OAuth 2.0 Authorization
[**Authorize2**](OAuthOIDCApi.md#authorize2) | **POST** /restapi/oauth/authorize | OAuth 2.0 Authorization (POST)
[**GetToken**](OAuthOIDCApi.md#gettoken) | **POST** /restapi/oauth/token | Get OAuth Token
[**RevokeToken**](OAuthOIDCApi.md#revoketoken) | **POST** /restapi/oauth/revoke | Revoke Token



## Authorize

> void Authorize ()

OAuth 2.0 Authorization

Performs OAuth 2.0 authorization (GET version)

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AuthorizeExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OAuthOIDCApi(Configuration.Default);

            try
            {
                // OAuth 2.0 Authorization
                apiInstance.Authorize();
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OAuthOIDCApi.Authorize: " + e.Message );
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

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **302** | Found |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Authorize2

> void Authorize2 (string responseType, string redirectUri, string clientId, string state = null, string brandId = null, string display = null, string prompt = null, string localeId = null, string uiLocales = null, string uiOptions = null, string scope = null, string acceptLanguage = null, string request = null, string requestUri = null, string nonce = null, string codeChallenge = null, string codeChallengeMethod = null)

OAuth 2.0 Authorization (POST)

Performs OAuth 2.0 authorization (POST version)

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class Authorize2Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OAuthOIDCApi(Configuration.Default);
            var responseType = "code";  // string | Determines authorization flow: **code** - Authorization Code, **token** - Implicit Grant
            var redirectUri = "redirectUri_example";  // string | This is a callback URI which determines where the response is sent. The value of this parameter must exactly match one of the URIs you have provided for your app upon registration
            var clientId = "clientId_example";  // string | Identifier (key) of a client application
            var state = "state_example";  // string | Client state. Returned back to the client at the end of the flow (optional) 
            var brandId = "brandId_example";  // string | Brand identifier. If it is not provided in request, server will try to determine brand from client app profile. The default value is '1210' - RingCentral US (optional) 
            var display = "page";  // string | Style of login form. The default value is 'page'. The 'popup' and 'touch' values are featured for mobile applications (optional) 
            var prompt = "login";  // string | Specifies which login form will be displayed. Space-separated set of the following values: 'login' - official RingCentral login form, 'sso' - Single Sign-On login form, 'consent' - form to show the requested scope and prompt user for consent. Either 'login' or 'sso' (or both) must be specified. The default value is 'login&sso' (optional) 
            var localeId = "localeId_example";  // string | Localization code of a language. Overwrites 'Accept-Language' header value (optional) 
            var uiLocales = "uiLocales_example";  // string | Localization code of a language. Overwrites 'localeId' parameter value (optional) 
            var uiOptions = "hide_logo";  // string | User interface options data (optional) 
            var scope = "scope_example";  // string |  (optional) 
            var acceptLanguage = "acceptLanguage_example";  // string |  (optional) 
            var request = "request_example";  // string |  (optional) 
            var requestUri = "requestUri_example";  // string |  (optional) 
            var nonce = "nonce_example";  // string |  (optional) 
            var codeChallenge = "codeChallenge_example";  // string |  (optional) 
            var codeChallengeMethod = "plain";  // string |  (optional) 

            try
            {
                // OAuth 2.0 Authorization (POST)
                apiInstance.Authorize2(responseType, redirectUri, clientId, state, brandId, display, prompt, localeId, uiLocales, uiOptions, scope, acceptLanguage, request, requestUri, nonce, codeChallenge, codeChallengeMethod);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OAuthOIDCApi.Authorize2: " + e.Message );
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
 **responseType** | **string**| Determines authorization flow: **code** - Authorization Code, **token** - Implicit Grant | 
 **redirectUri** | **string**| This is a callback URI which determines where the response is sent. The value of this parameter must exactly match one of the URIs you have provided for your app upon registration | 
 **clientId** | **string**| Identifier (key) of a client application | 
 **state** | **string**| Client state. Returned back to the client at the end of the flow | [optional] 
 **brandId** | **string**| Brand identifier. If it is not provided in request, server will try to determine brand from client app profile. The default value is &#39;1210&#39; - RingCentral US | [optional] 
 **display** | **string**| Style of login form. The default value is &#39;page&#39;. The &#39;popup&#39; and &#39;touch&#39; values are featured for mobile applications | [optional] 
 **prompt** | **string**| Specifies which login form will be displayed. Space-separated set of the following values: &#39;login&#39; - official RingCentral login form, &#39;sso&#39; - Single Sign-On login form, &#39;consent&#39; - form to show the requested scope and prompt user for consent. Either &#39;login&#39; or &#39;sso&#39; (or both) must be specified. The default value is &#39;login&amp;sso&#39; | [optional] 
 **localeId** | **string**| Localization code of a language. Overwrites &#39;Accept-Language&#39; header value | [optional] 
 **uiLocales** | **string**| Localization code of a language. Overwrites &#39;localeId&#39; parameter value | [optional] 
 **uiOptions** | **string**| User interface options data | [optional] 
 **scope** | **string**|  | [optional] 
 **acceptLanguage** | **string**|  | [optional] 
 **request** | **string**|  | [optional] 
 **requestUri** | **string**|  | [optional] 
 **nonce** | **string**|  | [optional] 
 **codeChallenge** | **string**|  | [optional] 
 **codeChallengeMethod** | **string**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/x-www-form-urlencoded
- **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **302** | Found |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetToken

> TokenInfo GetToken (string username = null, string password = null, string extension = null, string grantType = null, string code = null, string redirectUri = null, int? accessTokenTtl = null, int? refreshTokenTtl = null, string scope = null, string refreshToken = null, string endpointId = null, string pin = null, string clientId = null, string accountId = null, string partnerAccountId = null, string clientAssertionType = null, string clientAssertion = null, string assertion = null, string brandId = null, string codeVerifier = null, string deviceCode = null)

Get OAuth Token

Returns access (and potentially refresh) tokens for making API requests.  Depending on client application type requests to this endpoint may require authentication with HTTP Basic scheme using registered client ID and client secret as login and password, correspondingly. 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetTokenExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OAuthOIDCApi(Configuration.Default);
            var username = "username_example";  // string | Phone number linked to an account or extension in E.164 format with or without leading '+' sign (optional) 
            var password = "password_example";  // string | User's password (optional) 
            var extension = "extension_example";  // string | Optional. Extension short number. If company number is specified as a username, and extension is not specified, the server will attempt to authenticate client as main company administrator (optional) 
            var grantType = "authorization_code";  // string | Grant type (optional)  (default to password)
            var code = "code_example";  // string | Authorization code (optional) 
            var redirectUri = "redirectUri_example";  // string | This is a callback URI which determines where the response is sent. The value of this parameter must exactly match one of the URIs you have provided for your app upon registration (optional) 
            var accessTokenTtl = 3600;  // int? | Access token lifetime in seconds (optional)  (default to 3600)
            var refreshTokenTtl = 604800;  // int? | Refresh token lifetime in seconds (optional)  (default to 604800)
            var scope = "scope_example";  // string | List of API permissions to be used with access token. Can be omitted when requesting all permissions defined during the application registration phase (optional) 
            var refreshToken = "refreshToken_example";  // string | Previously issued refresh token. This is the only formData field used for the Refresh Token Flow. (optional) 
            var endpointId = "endpointId_example";  // string | The unique identifier of a client application. If not specified, the previously specified or auto generated value is used by default (optional) 
            var pin = "pin_example";  // string |  (optional) 
            var clientId = "clientId_example";  // string |  (optional) 
            var accountId = "accountId_example";  // string |  (optional) 
            var partnerAccountId = "partnerAccountId_example";  // string |  (optional) 
            var clientAssertionType = "clientAssertionType_example";  // string |  (optional) 
            var clientAssertion = "clientAssertion_example";  // string |  (optional) 
            var assertion = "assertion_example";  // string |  (optional) 
            var brandId = "brandId_example";  // string |  (optional) 
            var codeVerifier = "codeVerifier_example";  // string |  (optional) 
            var deviceCode = "deviceCode_example";  // string |  (optional) 

            try
            {
                // Get OAuth Token
                TokenInfo result = apiInstance.GetToken(username, password, extension, grantType, code, redirectUri, accessTokenTtl, refreshTokenTtl, scope, refreshToken, endpointId, pin, clientId, accountId, partnerAccountId, clientAssertionType, clientAssertion, assertion, brandId, codeVerifier, deviceCode);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OAuthOIDCApi.GetToken: " + e.Message );
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
 **username** | **string**| Phone number linked to an account or extension in E.164 format with or without leading &#39;+&#39; sign | [optional] 
 **password** | **string**| User&#39;s password | [optional] 
 **extension** | **string**| Optional. Extension short number. If company number is specified as a username, and extension is not specified, the server will attempt to authenticate client as main company administrator | [optional] 
 **grantType** | **string**| Grant type | [optional] [default to password]
 **code** | **string**| Authorization code | [optional] 
 **redirectUri** | **string**| This is a callback URI which determines where the response is sent. The value of this parameter must exactly match one of the URIs you have provided for your app upon registration | [optional] 
 **accessTokenTtl** | **int?**| Access token lifetime in seconds | [optional] [default to 3600]
 **refreshTokenTtl** | **int?**| Refresh token lifetime in seconds | [optional] [default to 604800]
 **scope** | **string**| List of API permissions to be used with access token. Can be omitted when requesting all permissions defined during the application registration phase | [optional] 
 **refreshToken** | **string**| Previously issued refresh token. This is the only formData field used for the Refresh Token Flow. | [optional] 
 **endpointId** | **string**| The unique identifier of a client application. If not specified, the previously specified or auto generated value is used by default | [optional] 
 **pin** | **string**|  | [optional] 
 **clientId** | **string**|  | [optional] 
 **accountId** | **string**|  | [optional] 
 **partnerAccountId** | **string**|  | [optional] 
 **clientAssertionType** | **string**|  | [optional] 
 **clientAssertion** | **string**|  | [optional] 
 **assertion** | **string**|  | [optional] 
 **brandId** | **string**|  | [optional] 
 **codeVerifier** | **string**|  | [optional] 
 **deviceCode** | **string**|  | [optional] 

### Return type

[**TokenInfo**](TokenInfo.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/x-www-form-urlencoded
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Access/Refresh Tokens |  -  |
| **400** | Possible responses: 1. invalid_request: Unsupported grant type 2. invalid_client: Bad Application Release Status: Blocked  |  -  |
| **415** | Unsupported Media Type |  -  |
| **429** | Request rate exceeded |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## RevokeToken

> void RevokeToken (string token, string clientAssertionType = null, string clientAssertion = null)

Revoke Token

Revokes previously issued access and refresh token.  Depending on client application type requests to this endpoint may require authentication with HTTP Basic scheme using registered client ID and client secret as login and password, correspondingly. 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RevokeTokenExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OAuthOIDCApi(Configuration.Default);
            var token = "token_example";  // string | Active access or refresh token to be revoked
            var clientAssertionType = "clientAssertionType_example";  // string |  (optional) 
            var clientAssertion = "clientAssertion_example";  // string |  (optional) 

            try
            {
                // Revoke Token
                apiInstance.RevokeToken(token, clientAssertionType, clientAssertion);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OAuthOIDCApi.RevokeToken: " + e.Message );
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
 **token** | **string**| Active access or refresh token to be revoked | 
 **clientAssertionType** | **string**|  | [optional] 
 **clientAssertion** | **string**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

- **Content-Type**: application/x-www-form-urlencoded
- **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

