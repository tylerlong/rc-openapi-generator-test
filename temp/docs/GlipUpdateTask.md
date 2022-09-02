
# Org.OpenAPITools.Model.GlipUpdateTask

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Subject** | **string** | Task name/subject. Max allowed length is 250 characters. | [optional] 
**Assignees** | [**List&lt;AssigneeInfo&gt;**](AssigneeInfo.md) |  | [optional] 
**CompletenessCondition** | **string** |  | [optional] 
**StartDate** | **DateTime** | Task start date in UTC time zone | [optional] 
**DueDate** | **DateTime** | Task due date/time in UTC time zone | [optional] 
**Color** | **string** |  | [optional] 
**Section** | **string** | Task section to group/search by. Max allowed length is 100 characters | [optional] 
**Description** | **string** | Task details. Max allowed length is 102400 characters (100kB) | [optional] 
**Recurrence** | [**GlipTaskRecurrenceInfo**](GlipTaskRecurrenceInfo.md) |  | [optional] 
**Attachments** | [**List&lt;GlipAttachmentInfoRequest&gt;**](GlipAttachmentInfoRequest.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

