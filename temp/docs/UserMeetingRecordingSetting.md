
# Org.OpenAPITools.Model.UserMeetingRecordingSetting

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LocalRecording** | **bool** | Allows hosts and participants to record a meeting to a local file | [optional] 
**CloudRecording** | **bool** | Allows hosts to record and save a meeting/webinar in the cloud | [optional] 
**RecordSpeakerView** | **bool** | Allows to record active speaker with the shared screen | [optional] [default to false]
**RecordGalleryView** | **bool** | Allows to record gallery view with the shared screen | [optional] [default to false]
**RecordAudioFile** | **bool** | Allows to record an audio-only file | [optional] [default to false]
**SaveChatText** | **bool** | Allows to save chat text from a meeting | [optional] [default to false]
**ShowTimestamp** | **bool** | Allows to show timestamp on video | [optional] [default to false]
**AutoRecording** | **string** | Automatical recording (local/cloud/none) of meetings as they start | [optional] [default to AutoRecordingEnum.Local]
**AutoDeleteCmr** | **string** | Automatical deletion of cloud recordings | [optional] [default to "false"]
**AutoDeleteCmrDays** | **int** | A specified number of days for automatical deletion of cloud recordings, the value range is 1-60 | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

