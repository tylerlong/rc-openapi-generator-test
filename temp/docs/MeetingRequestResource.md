
# Org.OpenAPITools.Model.MeetingRequestResource

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Topic** | **string** | Custom topic of a meeting | [optional] 
**MeetingType** | **string** |  | [optional] 
**Schedule** | [**MeetingScheduleResource**](MeetingScheduleResource.md) |  | [optional] 
**Password** | **string** | Meeting password | [optional] 
**Host** | [**HostInfoRequest**](HostInfoRequest.md) |  | [optional] 
**AllowJoinBeforeHost** | **bool** |  | [optional] [default to false]
**StartHostVideo** | **bool** |  | [optional] [default to false]
**StartParticipantsVideo** | **bool** | Starting meetings with participant video on/off (true/false) | [optional] [default to false]
**UsePersonalMeetingId** | **bool** | If true, then personal user&#39;s meeting ID is applied for creation of this meeting | [optional] 
**AudioOptions** | **List&lt;string&gt;** |  | [optional] 
**Recurrence** | [**RecurrenceInfo**](RecurrenceInfo.md) |  | [optional] 
**AutoRecordType** | **string** | Automatic record type | [optional] [default to AutoRecordTypeEnum.None]
**EnforceLogin** | **bool** | If true, then only signed-in users can join this meeting | [optional] 
**MuteParticipantsOnEntry** | **bool** | If true, then participants are muted on entry | [optional] 
**EnableWaitingRoom** | **bool** | If true, then the waiting room for participants is enabled | [optional] 
**GlobalDialInCountries** | **List&lt;string&gt;** | List of global dial-in countries (eg. US, UK, AU, etc.) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

