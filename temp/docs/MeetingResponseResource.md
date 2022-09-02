
# Org.OpenAPITools.Model.MeetingResponseResource

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Uri** | **string** | Link to a meeting resource | [optional] 
**Uuid** | **string** | Universally unique identifier of a meeting\&quot; | [optional] 
**Id** | **string** | Internal identifier of a meeting | [optional] 
**Topic** | **string** | Custom topic of a meeting | [optional] 
**MeetingType** | **string** |  | [optional] 
**Password** | **string** | Meeting password | [optional] 
**H323Password** | **string** |  | [optional] 
**Status** | **string** | Status of a meeting | [optional] 
**Links** | [**MeetingLinks**](MeetingLinks.md) |  | [optional] 
**Schedule** | [**MeetingScheduleResource**](MeetingScheduleResource.md) |  | [optional] 
**Host** | [**HostInfoRequest**](HostInfoRequest.md) |  | [optional] 
**AllowJoinBeforeHost** | **bool** | If true, then participants can join the meeting before host arrives | [optional] [default to false]
**StartHostVideo** | **bool** | Starting meetings with host video on/off (true/false) | [optional] [default to false]
**StartParticipantsVideo** | **bool** | Starting meetings with participant video on/off (true/false) | [optional] [default to false]
**AudioOptions** | **List&lt;string&gt;** |  | [optional] 
**Reccurence** | [**RecurrenceInfo**](RecurrenceInfo.md) |  | [optional] 
**AutoRecordType** | **string** | Automatic record type | [optional] [default to AutoRecordTypeEnum.None]
**EnforceLogin** | **bool** | If true, then only signed-in users can join this meeting | [optional] 
**MuteParticipantsOnEntry** | **bool** | If true, then participants are muted on entry | [optional] 
**EnableWaitingRoom** | **bool** | If true, then the waiting room for participants is enabled | [optional] 
**GlobalDialInCountries** | **List&lt;string&gt;** | List of global dial-in countries (eg. US, UK, AU, etc.) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

