
# Org.OpenAPITools.Model.GlipTaskInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Internal identifier of a task | [optional] 
**CreationTime** | **string** | Datetime of the task creation in UTC time zone. | [optional] 
**LastModifiedTime** | **string** | Datetime of the last modification of the task in UTC time zone. | [optional] 
**Type** | **string** | Type of a task | [optional] 
**Creator** | [**GlipCreatorInfo**](GlipCreatorInfo.md) |  | [optional] 
**ChatIds** | **List&lt;string&gt;** | Chat IDs where the task is posted or shared. | [optional] 
**Status** | **string** | Status of task execution | [optional] 
**Subject** | **string** | Name/subject of a task | [optional] 
**Assignees** | [**List&lt;TaskAssigneeInfo&gt;**](TaskAssigneeInfo.md) |  | [optional] 
**CompletenessCondition** | **string** | Specifies how to determine task completeness | [optional] 
**CompletenessPercentage** | **int** | Current completeness percentage of the task with the specified percentage completeness condition | [optional] 
**StartDate** | **DateTime** | Task start date | [optional] 
**DueDate** | **DateTime** | Task due date/time | [optional] 
**Color** | **string** | Font color of a post with the current task | [optional] 
**Section** | **string** | Task section to group/search by | [optional] 
**Description** | **string** | Task details | [optional] 
**Recurrence** | [**GlipTaskRecurrenceInfo**](GlipTaskRecurrenceInfo.md) |  | [optional] 
**Attachments** | [**List&lt;TaskAttachment&gt;**](TaskAttachment.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

