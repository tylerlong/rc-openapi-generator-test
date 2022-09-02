
# Org.OpenAPITools.Model.MessageStoreCallerInfoResponseTo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ExtensionNumber** | **string** | Extension short number (usually 3 or 4 digits). This property is filled when parties communicate by means of short internal numbers, for example when calling to other extension or sending/receiving Company Pager message | [optional] 
**ExtensionId** | **string** |  | [optional] 
**Location** | **string** | Contains party location (city, state) if one can be determined from phoneNumber. This property is filled only when phoneNumber is not empty and server can calculate location information from it (for example, this information is unavailable for US toll-free numbers) | [optional] 
**Target** | **bool** | &#39;True&#39; specifies that message is sent exactly to this recipient. Returned in to field for group MMS. Useful if one extension has several phone numbers | [optional] 
**MessageStatus** | **string** | Status of a message. Returned for outbound fax messages only | [optional] 
**FaxErrorCode** | **string** | Error code returned in case of fax sending failure. Returned if messageStatus value is &#39;SendingFailed&#39;. Supported for fax messages only | [optional] 
**Name** | **string** | Symbolic name associated with a party. If the phone does not belong to the known extension, only the location is returned, the name is not determined then | [optional] 
**PhoneNumber** | **string** | Phone number of a party. Usually it is a plain number including country and area code like 18661234567. But sometimes it could be returned from database with some formatting applied, for example (866)123-4567. This property is filled in all cases where parties communicate by means of global phone numbers, for example when calling to direct numbers or sending/receiving SMS | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

