# Org.OpenAPITools.Api.RegionalSettingsApi

All URIs are relative to *https://platform.ringcentral.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListCountries**](RegionalSettingsApi.md#listcountries) | **GET** /restapi/v1.0/dictionary/country | Get Country List
[**ListLanguages**](RegionalSettingsApi.md#listlanguages) | **GET** /restapi/v1.0/dictionary/language | Get Language List
[**ListLocations**](RegionalSettingsApi.md#listlocations) | **GET** /restapi/v1.0/dictionary/location | Get Location List
[**ListStates**](RegionalSettingsApi.md#liststates) | **GET** /restapi/v1.0/dictionary/state | Get States List
[**ListTimezones**](RegionalSettingsApi.md#listtimezones) | **GET** /restapi/v1.0/dictionary/timezone | Get Timezone List
[**ReadCountry**](RegionalSettingsApi.md#readcountry) | **GET** /restapi/v1.0/dictionary/country/{countryId} | Get Country
[**ReadLanguage**](RegionalSettingsApi.md#readlanguage) | **GET** /restapi/v1.0/dictionary/language/{languageId} | Get Language
[**ReadState**](RegionalSettingsApi.md#readstate) | **GET** /restapi/v1.0/dictionary/state/{stateId} | Get State
[**ReadTimezone**](RegionalSettingsApi.md#readtimezone) | **GET** /restapi/v1.0/dictionary/timezone/{timezoneId} | Get Timezone



## ListCountries

> GetCountryListResponse ListCountries (bool? loginAllowed = null, bool? signupAllowed = null, bool? numberSelling = null, int? page = null, int? perPage = null, bool? freeSoftphoneLine = null)

Get Country List

Returns all the countries available for calling.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListCountriesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RegionalSettingsApi(Configuration.Default);
            var loginAllowed = true;  // bool? | Specifies whether login with the phone numbers of this country is enabled or not (optional) 
            var signupAllowed = true;  // bool? | Indicates whether signup/billing is allowed for a country. If not specified all countries are returned (according to other filters specified if any) (optional) 
            var numberSelling = true;  // bool? | Specifies if RingCentral sells phone numbers of this country (optional) 
            var page = 1;  // int? | Indicates the page number to retrieve. Only positive number values are accepted (optional)  (default to 1)
            var perPage = 100;  // int? | Indicates the page size (number of items) (optional)  (default to 100)
            var freeSoftphoneLine = true;  // bool? | Specifies if free phone line for softphone is available for a country or not (optional) 

            try
            {
                // Get Country List
                GetCountryListResponse result = apiInstance.ListCountries(loginAllowed, signupAllowed, numberSelling, page, perPage, freeSoftphoneLine);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RegionalSettingsApi.ListCountries: " + e.Message );
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
 **loginAllowed** | **bool?**| Specifies whether login with the phone numbers of this country is enabled or not | [optional] 
 **signupAllowed** | **bool?**| Indicates whether signup/billing is allowed for a country. If not specified all countries are returned (according to other filters specified if any) | [optional] 
 **numberSelling** | **bool?**| Specifies if RingCentral sells phone numbers of this country | [optional] 
 **page** | **int?**| Indicates the page number to retrieve. Only positive number values are accepted | [optional] [default to 1]
 **perPage** | **int?**| Indicates the page size (number of items) | [optional] [default to 100]
 **freeSoftphoneLine** | **bool?**| Specifies if free phone line for softphone is available for a country or not | [optional] 

### Return type

[**GetCountryListResponse**](GetCountryListResponse.md)

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


## ListLanguages

> LanguageList ListLanguages ()

Get Language List

Returns the information about supported languages.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListLanguagesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RegionalSettingsApi(Configuration.Default);

            try
            {
                // Get Language List
                LanguageList result = apiInstance.ListLanguages();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RegionalSettingsApi.ListLanguages: " + e.Message );
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

[**LanguageList**](LanguageList.md)

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


## ListLocations

> GetLocationListResponse ListLocations (string orderBy = null, int? page = null, int? perPage = null, string stateId = null, bool? withNxx = null)

Get Location List

Returns all available locations for a certain state.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListLocationsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RegionalSettingsApi(Configuration.Default);
            var orderBy = "Npa";  // string | Sorts results by the property specified (optional)  (default to City)
            var page = 1;  // int? | Indicates the page number to retrieve. Only positive number values are accepted (optional)  (default to 1)
            var perPage = 100;  // int? | Indicates the page size (number of items) (optional)  (default to 100)
            var stateId = "stateId_example";  // string | Internal identifier of a state (optional) 
            var withNxx = true;  // bool? | Specifies if nxx codes are returned (optional) 

            try
            {
                // Get Location List
                GetLocationListResponse result = apiInstance.ListLocations(orderBy, page, perPage, stateId, withNxx);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RegionalSettingsApi.ListLocations: " + e.Message );
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
 **orderBy** | **string**| Sorts results by the property specified | [optional] [default to City]
 **page** | **int?**| Indicates the page number to retrieve. Only positive number values are accepted | [optional] [default to 1]
 **perPage** | **int?**| Indicates the page size (number of items) | [optional] [default to 100]
 **stateId** | **string**| Internal identifier of a state | [optional] 
 **withNxx** | **bool?**| Specifies if nxx codes are returned | [optional] 

### Return type

[**GetLocationListResponse**](GetLocationListResponse.md)

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


## ListStates

> GetStateListResponse ListStates (bool? allCountries = null, long? countryId = null, int? page = null, int? perPage = null, bool? withPhoneNumbers = null)

Get States List

Returns all the states of a certain country

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListStatesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RegionalSettingsApi(Configuration.Default);
            var allCountries = true;  // bool? | If set to 'True' then states for all countries are returned and `countryId` is ignored, even if specified. If the value is empty then the parameter is ignored (optional) 
            var countryId = 789L;  // long? | Internal identifier of a country (optional) 
            var page = 1;  // int? | Indicates the page number to retrieve. Only positive number values are accepted (optional)  (default to 1)
            var perPage = 100;  // int? | Indicates the page size (number of items) (optional)  (default to 100)
            var withPhoneNumbers = false;  // bool? | If 'True', the list of states with phone numbers available for buying is returned (optional)  (default to false)

            try
            {
                // Get States List
                GetStateListResponse result = apiInstance.ListStates(allCountries, countryId, page, perPage, withPhoneNumbers);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RegionalSettingsApi.ListStates: " + e.Message );
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
 **allCountries** | **bool?**| If set to &#39;True&#39; then states for all countries are returned and &#x60;countryId&#x60; is ignored, even if specified. If the value is empty then the parameter is ignored | [optional] 
 **countryId** | **long?**| Internal identifier of a country | [optional] 
 **page** | **int?**| Indicates the page number to retrieve. Only positive number values are accepted | [optional] [default to 1]
 **perPage** | **int?**| Indicates the page size (number of items) | [optional] [default to 100]
 **withPhoneNumbers** | **bool?**| If &#39;True&#39;, the list of states with phone numbers available for buying is returned | [optional] [default to false]

### Return type

[**GetStateListResponse**](GetStateListResponse.md)

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


## ListTimezones

> GetTimezoneListResponse ListTimezones (string page = null, string perPage = null)

Get Timezone List

Returns all available timezones.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListTimezonesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RegionalSettingsApi(Configuration.Default);
            var page = "\"1\"";  // string | Indicates the page number to retrieve. Only positive number values are accepted (optional)  (default to "1")
            var perPage = "\"100\"";  // string | Indicates the page size (number of items) (optional)  (default to "100")

            try
            {
                // Get Timezone List
                GetTimezoneListResponse result = apiInstance.ListTimezones(page, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RegionalSettingsApi.ListTimezones: " + e.Message );
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
 **page** | **string**| Indicates the page number to retrieve. Only positive number values are accepted | [optional] [default to &quot;1&quot;]
 **perPage** | **string**| Indicates the page size (number of items) | [optional] [default to &quot;100&quot;]

### Return type

[**GetTimezoneListResponse**](GetTimezoneListResponse.md)

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


## ReadCountry

> GetCountryInfoDictionaryResponse ReadCountry (long countryId)

Get Country

Returns the information on a specific country.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadCountryExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RegionalSettingsApi(Configuration.Default);
            var countryId = 789L;  // long | Internal identifier of a country

            try
            {
                // Get Country
                GetCountryInfoDictionaryResponse result = apiInstance.ReadCountry(countryId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RegionalSettingsApi.ReadCountry: " + e.Message );
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
 **countryId** | **long**| Internal identifier of a country | 

### Return type

[**GetCountryInfoDictionaryResponse**](GetCountryInfoDictionaryResponse.md)

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


## ReadLanguage

> LanguageInfo ReadLanguage (long languageId)

Get Language

Returns language by ID.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadLanguageExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RegionalSettingsApi(Configuration.Default);
            var languageId = 789L;  // long | Internal identifier of a language

            try
            {
                // Get Language
                LanguageInfo result = apiInstance.ReadLanguage(languageId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RegionalSettingsApi.ReadLanguage: " + e.Message );
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
 **languageId** | **long**| Internal identifier of a language | 

### Return type

[**LanguageInfo**](LanguageInfo.md)

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


## ReadState

> GetStateInfoResponse ReadState (long stateId)

Get State

Returns the information on a specific state.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadStateExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RegionalSettingsApi(Configuration.Default);
            var stateId = 789L;  // long | Internal identifier of a state

            try
            {
                // Get State
                GetStateInfoResponse result = apiInstance.ReadState(stateId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RegionalSettingsApi.ReadState: " + e.Message );
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
 **stateId** | **long**| Internal identifier of a state | 

### Return type

[**GetStateInfoResponse**](GetStateInfoResponse.md)

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


## ReadTimezone

> GetTimezoneInfoResponse ReadTimezone (long timezoneId, string page = null, string perPage = null)

Get Timezone

Returns the information on a certain timezone.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ReadTimezoneExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://platform.ringcentral.com";
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RegionalSettingsApi(Configuration.Default);
            var timezoneId = 789L;  // long | Internal identifier of a timezone
            var page = "\"1\"";  // string | Indicates the page number to retrieve. Only positive number values are accepted (optional)  (default to "1")
            var perPage = "\"100\"";  // string | Indicates the page size (number of items) (optional)  (default to "100")

            try
            {
                // Get Timezone
                GetTimezoneInfoResponse result = apiInstance.ReadTimezone(timezoneId, page, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RegionalSettingsApi.ReadTimezone: " + e.Message );
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
 **timezoneId** | **long**| Internal identifier of a timezone | 
 **page** | **string**| Indicates the page number to retrieve. Only positive number values are accepted | [optional] [default to &quot;1&quot;]
 **perPage** | **string**| Indicates the page size (number of items) | [optional] [default to &quot;100&quot;]

### Return type

[**GetTimezoneInfoResponse**](GetTimezoneInfoResponse.md)

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

