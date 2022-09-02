
# Org.OpenAPITools.Model.TokenInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccessToken** | **string** | OAuth access token to pass to subsequent API requests | 
**ExpiresIn** | **int** | Issued access token TTL (time-to-live) in seconds | 
**RefreshToken** | **string** | OAuth refresh token (in case the one was issued)  | [optional] 
**RefreshTokenExpiresIn** | **int** | Issued refresh token TTL (time-to-live) in seconds | [optional] 
**Scope** | **string** | List of permissions (space separated) granted to the application with this access token  | 
**TokenType** | **string** | Type of token. The only supported value is &#x60;bearer&#x60;. This value should be used when specifying access token in &#x60;Authorization&#x60; header of subsequent API requests | 
**OwnerId** | **string** | Token owner (extension/user) identifier | [optional] 
**EndpointId** | **string** | Application instance identifier | [optional] 
**IdToken** | **string** | OIDC ID token (if OpenId Connect flow was activated during authorization) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

