/*
 * RingCentral Connect Platform API
 *
 * RingCentral Connect Platform API
 *
 * The version of the OpenAPI document: 1.0.48
 * Contact: platform@ringcentral.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using RestSharp;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IVideoConfigurationApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get User Video Configuration
        /// </summary>
        /// <remarks>
        /// Returns information about video configuration of the current user.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the current session account</param>
        /// <returns>UserVideoConfiguration</returns>
        UserVideoConfiguration ReadUserVideoConfiguration (string accountId, string extensionId);

        /// <summary>
        /// Get User Video Configuration
        /// </summary>
        /// <remarks>
        /// Returns information about video configuration of the current user.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the current session account</param>
        /// <returns>ApiResponse of UserVideoConfiguration</returns>
        ApiResponse<UserVideoConfiguration> ReadUserVideoConfigurationWithHttpInfo (string accountId, string extensionId);
        /// <summary>
        /// Update User Video Configuration
        /// </summary>
        /// <remarks>
        /// Allows to update user video settings, for example video provider.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the current session account</param>
        /// <param name="userVideoConfiguration"></param>
        /// <returns>UserVideoConfiguration</returns>
        UserVideoConfiguration UpdateUserVideoConfiguration (string accountId, string extensionId, UserVideoConfiguration userVideoConfiguration);

        /// <summary>
        /// Update User Video Configuration
        /// </summary>
        /// <remarks>
        /// Allows to update user video settings, for example video provider.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the current session account</param>
        /// <param name="userVideoConfiguration"></param>
        /// <returns>ApiResponse of UserVideoConfiguration</returns>
        ApiResponse<UserVideoConfiguration> UpdateUserVideoConfigurationWithHttpInfo (string accountId, string extensionId, UserVideoConfiguration userVideoConfiguration);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get User Video Configuration
        /// </summary>
        /// <remarks>
        /// Returns information about video configuration of the current user.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the current session account</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of UserVideoConfiguration</returns>
        System.Threading.Tasks.Task<UserVideoConfiguration> ReadUserVideoConfigurationAsync (string accountId, string extensionId, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get User Video Configuration
        /// </summary>
        /// <remarks>
        /// Returns information about video configuration of the current user.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the current session account</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (UserVideoConfiguration)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserVideoConfiguration>> ReadUserVideoConfigurationWithHttpInfoAsync (string accountId, string extensionId, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Update User Video Configuration
        /// </summary>
        /// <remarks>
        /// Allows to update user video settings, for example video provider.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the current session account</param>
        /// <param name="userVideoConfiguration"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of UserVideoConfiguration</returns>
        System.Threading.Tasks.Task<UserVideoConfiguration> UpdateUserVideoConfigurationAsync (string accountId, string extensionId, UserVideoConfiguration userVideoConfiguration, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Update User Video Configuration
        /// </summary>
        /// <remarks>
        /// Allows to update user video settings, for example video provider.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the current session account</param>
        /// <param name="userVideoConfiguration"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (UserVideoConfiguration)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserVideoConfiguration>> UpdateUserVideoConfigurationWithHttpInfoAsync (string accountId, string extensionId, UserVideoConfiguration userVideoConfiguration, CancellationToken cancellationToken = default(CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class VideoConfigurationApi : IVideoConfigurationApi
    {
        private Org.OpenAPITools.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoConfigurationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public VideoConfigurationApi(String basePath)
        {
            this.Configuration = new Org.OpenAPITools.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoConfigurationApi"/> class
        /// </summary>
        /// <returns></returns>
        public VideoConfigurationApi()
        {
            this.Configuration = Org.OpenAPITools.Client.Configuration.Default;

            ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoConfigurationApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public VideoConfigurationApi(Org.OpenAPITools.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Org.OpenAPITools.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Org.OpenAPITools.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Org.OpenAPITools.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Get User Video Configuration Returns information about video configuration of the current user.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the current session account</param>
        /// <returns>UserVideoConfiguration</returns>
        public UserVideoConfiguration ReadUserVideoConfiguration (string accountId, string extensionId)
        {
             ApiResponse<UserVideoConfiguration> localVarResponse = ReadUserVideoConfigurationWithHttpInfo(accountId, extensionId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get User Video Configuration Returns information about video configuration of the current user.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the current session account</param>
        /// <returns>ApiResponse of UserVideoConfiguration</returns>
        public ApiResponse<UserVideoConfiguration> ReadUserVideoConfigurationWithHttpInfo (string accountId, string extensionId)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null)
                throw new ApiException(400, "Missing required parameter 'accountId' when calling VideoConfigurationApi->ReadUserVideoConfiguration");
            // verify the required parameter 'extensionId' is set
            if (extensionId == null)
                throw new ApiException(400, "Missing required parameter 'extensionId' when calling VideoConfigurationApi->ReadUserVideoConfiguration");

            var localVarPath = "/restapi/v1.0/account/{accountId}/extension/{extensionId}/video-configuration";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (accountId != null) localVarPathParams.Add("accountId", this.Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (extensionId != null) localVarPathParams.Add("extensionId", this.Configuration.ApiClient.ParameterToString(extensionId)); // path parameter

            // authentication (OAuth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ReadUserVideoConfiguration", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<UserVideoConfiguration>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (UserVideoConfiguration) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserVideoConfiguration)));
        }

        /// <summary>
        /// Get User Video Configuration Returns information about video configuration of the current user.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the current session account</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of UserVideoConfiguration</returns>
        public async System.Threading.Tasks.Task<UserVideoConfiguration> ReadUserVideoConfigurationAsync (string accountId, string extensionId, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<UserVideoConfiguration> localVarResponse = await ReadUserVideoConfigurationWithHttpInfoAsync(accountId, extensionId, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get User Video Configuration Returns information about video configuration of the current user.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the current session account</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (UserVideoConfiguration)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserVideoConfiguration>> ReadUserVideoConfigurationWithHttpInfoAsync (string accountId, string extensionId, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null)
                throw new ApiException(400, "Missing required parameter 'accountId' when calling VideoConfigurationApi->ReadUserVideoConfiguration");
            // verify the required parameter 'extensionId' is set
            if (extensionId == null)
                throw new ApiException(400, "Missing required parameter 'extensionId' when calling VideoConfigurationApi->ReadUserVideoConfiguration");

            var localVarPath = "/restapi/v1.0/account/{accountId}/extension/{extensionId}/video-configuration";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (accountId != null) localVarPathParams.Add("accountId", this.Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (extensionId != null) localVarPathParams.Add("extensionId", this.Configuration.ApiClient.ParameterToString(extensionId)); // path parameter

            // authentication (OAuth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ReadUserVideoConfiguration", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<UserVideoConfiguration>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (UserVideoConfiguration) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserVideoConfiguration)));
        }

        /// <summary>
        /// Update User Video Configuration Allows to update user video settings, for example video provider.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the current session account</param>
        /// <param name="userVideoConfiguration"></param>
        /// <returns>UserVideoConfiguration</returns>
        public UserVideoConfiguration UpdateUserVideoConfiguration (string accountId, string extensionId, UserVideoConfiguration userVideoConfiguration)
        {
             ApiResponse<UserVideoConfiguration> localVarResponse = UpdateUserVideoConfigurationWithHttpInfo(accountId, extensionId, userVideoConfiguration);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update User Video Configuration Allows to update user video settings, for example video provider.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the current session account</param>
        /// <param name="userVideoConfiguration"></param>
        /// <returns>ApiResponse of UserVideoConfiguration</returns>
        public ApiResponse<UserVideoConfiguration> UpdateUserVideoConfigurationWithHttpInfo (string accountId, string extensionId, UserVideoConfiguration userVideoConfiguration)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null)
                throw new ApiException(400, "Missing required parameter 'accountId' when calling VideoConfigurationApi->UpdateUserVideoConfiguration");
            // verify the required parameter 'extensionId' is set
            if (extensionId == null)
                throw new ApiException(400, "Missing required parameter 'extensionId' when calling VideoConfigurationApi->UpdateUserVideoConfiguration");
            // verify the required parameter 'userVideoConfiguration' is set
            if (userVideoConfiguration == null)
                throw new ApiException(400, "Missing required parameter 'userVideoConfiguration' when calling VideoConfigurationApi->UpdateUserVideoConfiguration");

            var localVarPath = "/restapi/v1.0/account/{accountId}/extension/{extensionId}/video-configuration";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (accountId != null) localVarPathParams.Add("accountId", this.Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (extensionId != null) localVarPathParams.Add("extensionId", this.Configuration.ApiClient.ParameterToString(extensionId)); // path parameter
            if (userVideoConfiguration != null && userVideoConfiguration.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(userVideoConfiguration); // http body (model) parameter
            }
            else
            {
                localVarPostBody = userVideoConfiguration; // byte array
            }

            // authentication (OAuth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdateUserVideoConfiguration", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<UserVideoConfiguration>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (UserVideoConfiguration) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserVideoConfiguration)));
        }

        /// <summary>
        /// Update User Video Configuration Allows to update user video settings, for example video provider.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the current session account</param>
        /// <param name="userVideoConfiguration"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of UserVideoConfiguration</returns>
        public async System.Threading.Tasks.Task<UserVideoConfiguration> UpdateUserVideoConfigurationAsync (string accountId, string extensionId, UserVideoConfiguration userVideoConfiguration, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<UserVideoConfiguration> localVarResponse = await UpdateUserVideoConfigurationWithHttpInfoAsync(accountId, extensionId, userVideoConfiguration, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update User Video Configuration Allows to update user video settings, for example video provider.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the current session account</param>
        /// <param name="userVideoConfiguration"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (UserVideoConfiguration)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserVideoConfiguration>> UpdateUserVideoConfigurationWithHttpInfoAsync (string accountId, string extensionId, UserVideoConfiguration userVideoConfiguration, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null)
                throw new ApiException(400, "Missing required parameter 'accountId' when calling VideoConfigurationApi->UpdateUserVideoConfiguration");
            // verify the required parameter 'extensionId' is set
            if (extensionId == null)
                throw new ApiException(400, "Missing required parameter 'extensionId' when calling VideoConfigurationApi->UpdateUserVideoConfiguration");
            // verify the required parameter 'userVideoConfiguration' is set
            if (userVideoConfiguration == null)
                throw new ApiException(400, "Missing required parameter 'userVideoConfiguration' when calling VideoConfigurationApi->UpdateUserVideoConfiguration");

            var localVarPath = "/restapi/v1.0/account/{accountId}/extension/{extensionId}/video-configuration";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (accountId != null) localVarPathParams.Add("accountId", this.Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (extensionId != null) localVarPathParams.Add("extensionId", this.Configuration.ApiClient.ParameterToString(extensionId)); // path parameter
            if (userVideoConfiguration != null && userVideoConfiguration.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(userVideoConfiguration); // http body (model) parameter
            }
            else
            {
                localVarPostBody = userVideoConfiguration; // byte array
            }

            // authentication (OAuth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdateUserVideoConfiguration", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<UserVideoConfiguration>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (UserVideoConfiguration) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserVideoConfiguration)));
        }

    }
}
