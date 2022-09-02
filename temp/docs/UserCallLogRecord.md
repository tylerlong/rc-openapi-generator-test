
# Org.OpenAPITools.Model.UserCallLogRecord

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Internal identifier of a cal log record | [optional] 
**Uri** | **string** | Canonical URI of a call log record | [optional] 
**SessionId** | **string** | Internal identifier of a call session | [optional] 
**TelephonySessionId** | **string** | Telephony identifier of a call session | [optional] 
**From** | [**CallLogCallerInfo**](CallLogCallerInfo.md) |  | [optional] 
**To** | [**CallLogCallerInfo**](CallLogCallerInfo.md) |  | [optional] 
**Extension** | [**ExtensionInfoCallLog**](ExtensionInfoCallLog.md) |  | [optional] 
**Type** | **string** | Call type | [optional] 
**Transport** | **string** | For &#39;Detailed&#39; view only. Call transport | [optional] 
**Legs** | [**List&lt;CallLogRecordLegInfo&gt;**](CallLogRecordLegInfo.md) | For &#39;Detailed&#39; view only. Leg description | [optional] 
**Billing** | [**BillingInfo**](BillingInfo.md) |  | [optional] 
**Direction** | **string** | Call direction | [optional] 
**Message** | [**CallLogRecordMessage**](CallLogRecordMessage.md) |  | [optional] 
**StartTime** | **string** | The call start datetime in (ISO 8601)[https://en.wikipedia.org/wiki/ISO_8601] format including timezone, for example 2016-03-10T18:07:52.534Z | [optional] 
**Delegate** | [**CallLogDelegateInfo**](CallLogDelegateInfo.md) |  | [optional] 
**Deleted** | **bool** | Indicates whether the record is deleted. Returned for deleted records, for ISync requests | [optional] 
**Duration** | **int** | Call duration in seconds | [optional] 
**LastModifiedTime** | **DateTime** | For &#39;Detailed&#39; view only. The datetime when the call log record was modified in (ISO 8601)[https://en.wikipedia.org/wiki/ISO_8601] format including timezone, for example 2016-03-10T18:07:52.534Z | [optional] 
**Recording** | [**CallLogRecordingInfo**](CallLogRecordingInfo.md) |  | [optional] 
**ShortRecording** | **bool** | Indicates that the recording is too short and therefore wouldn&#39;t be returned. The flag is not returned if the value is false | [optional] 
**Action** | **string** | Action description of the call operation | [optional] 
**Result** | **string** | Status description of the call operation | [optional] 
**Reason** | **string** | Reason of a call result:  * &#x60;Accepted&#x60; - The call was connected to and accepted by this number  * &#x60;Connected&#x60; - The call was answered, but there was no response on how to handle the call (for example, a voice mail system answered the call and did not push \&quot;1\&quot; to accept)  * &#x60;Line Busy&#x60; - The phone number you dialed was busy  * &#x60;Not Answered&#x60; - The phone number you dialed was not answered  * &#x60;No Answer&#x60; - You did not answer the call  * &#x60;Hang Up&#x60; - The caller hung up before the call was answered  * &#x60;Stopped&#x60; - This attempt was stopped because the call was answered by another phone  * &#x60;Internal Error&#x60; - An internal error occurred when making the call. Please try again  * &#x60;No Credit&#x60; - There was not enough Calling Credit on your account to make this call  * &#x60;Restricted Number&#x60; - The number you dialed is restricted by RingCentral  * &#x60;Wrong Number&#x60; - The number you dialed has either been disconnected or is not a valid phone number. Please check the number and try again  * &#x60;International Disabled&#x60; - International calling is not enabled on your account. Contact customer service to activate International Calling  * &#x60;International Restricted&#x60; - The country and/or area you attempted to call has been prohibited by your administrator  * &#x60;Bad Number&#x60; - An error occurred when making the call. Please check the number before trying again  * &#x60;Info 411 Restricted&#x60; - Calling to 411 Information Services is restricted  * &#x60;Customer 611 Restricted&#x60; - 611 customer service is not supported. Please contact customer service at &lt;(888) 555-1212&gt;  * &#x60;No Digital Line&#x60; - This DigitalLine was either not plugged in or did not have an internet connection  * &#x60;Failed Try Again&#x60; - Call failed. Please try again  * &#x60;Max Call Limit&#x60; - The number of simultaneous calls to your account has reached its limit  * &#x60;Too Many Calls&#x60; - The number of simultaneous calls for per DigitalLine associated with Other Phone has reached its limit. Please contact customer service  * &#x60;Calls Not Accepted&#x60; - Your account was not accepting calls at this time  * &#x60;Number Not Allowed&#x60; - The number that was dialed to access your account is not allowed  * &#x60;Number Blocked&#x60; - This number is in your Blocked Numbers list  * &#x60;Number Disabled&#x60; - The phone number and/or area you attempted to call has been prohibited by your administrator  * &#x60;Resource Error&#x60; - An error occurred when making the call. Please try again  * &#x60;Call Loop&#x60; - A call loop occurred due to an incorrect call forwarding configuration. Please check that you are not forwarding calls back to your own account  * &#x60;Fax Not Received&#x60; - An incoming fax could not be received because a proper connection with the sender&#39;s fax machine could not be established  * &#x60;Fax Partially Sent&#x60; - The fax was only partially sent. Possible explanations include phone line quality to poor to maintain the connection or the call was dropped  * &#x60;Fax Not Sent&#x60; - An attempt to send the fax was made, but could not connect with the receiving fax machine  * &#x60;Fax Poor Line&#x60; - An attempt to send the fax was made, but the phone line quality was too poor to send the fax  * &#x60;Fax Prepare Error&#x60; - An internal error occurred when preparing the fax. Please try again  * &#x60;Fax Save Error&#x60; - An internal error occurred when saving the fax. Please try again  * &#x60;Fax Send Error&#x60; - An error occurred when sending the fax. Please try again  * &#x60;DescNoE911Address&#x60; - The call was rejected due to no E911 address  | [optional] 
**ReasonDescription** | **string** |  | [optional] 
**InternalType** | **string** | Internal type of a call | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

