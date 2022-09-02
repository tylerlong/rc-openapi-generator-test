
# Org.OpenAPITools.Model.ScheduleUserMeetingInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EnforceLogin** | **bool** | If true, then only signed-in users can join this meeting | [optional] 
**StartHostVideo** | **bool** | Starting meetings with host video on/off (true/false) | [optional] 
**StartParticipantsVideo** | **bool** | Starting meetings with participant video on/off (true/false) | [optional] 
**AudioOptions** | **List&lt;string&gt;** | Determines how participants can join the audio channel of a meeting | [optional] 
**AllowJoinBeforeHost** | **bool** | Allows participants to join the meeting before the host arrives | [optional] 
**UsePmiForScheduledMeetings** | **bool** | Determines whether to use Personal Meeting ID (PMI) when scheduling a meeting | [optional] 
**UsePmiForInstantMeetings** | **bool** | Determines whether to use Personal Meeting ID (PMI) when starting an instant meeting | [optional] 
**RequirePasswordForSchedulingNewMeetings** | **bool** | A password will be generated when scheduling a meeting and participants will require password to join a meeting. The Personal Meeting ID (PMI) meetings are not included | [optional] 
**RequirePasswordForScheduledMeetings** | **bool** | Specifies whether to require a password for meetings which have already been scheduled | [optional] 
**DefaultPasswordForScheduledMeetings** | **string** | Password for already scheduled meetings. Users can set it individually | [optional] 
**RequirePasswordForInstantMeetings** | **bool** | A random password will be generated for an instant meeting, if set to &#39;True&#39;. If you use PMI for your instant meetings, this option will be disabled | [optional] 
**RequirePasswordForPmiMeetings** | **string** | Specifies whether to require a password for meetings using Personal Meeting ID (PMI). The supported values are: &#39;none&#39;, &#39;all&#39; and &#39;jbhOnly&#39; (joined before host only) | [optional] 
**PmiPassword** | **string** | The default password for Personal Meeting ID (PMI) meetings | [optional] 
**PstnPasswordProtected** | **bool** | Specifies whether to generate and require a password for participants joining by phone | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

