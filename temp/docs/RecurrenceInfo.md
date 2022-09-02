
# Org.OpenAPITools.Model.RecurrenceInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Frequency** | **string** | Recurrence time frame | [optional] 
**Interval** | **int** | Reccurence interval. The supported ranges are: 1-90 for &#x60;Daily&#x60;; 1-12 for &#x60;Weekly&#x60;; 1-3 for &#x60;Monthly&#x60; | [optional] 
**MonthlyByWeek** | **string** | Supported together with &#x60;weeklyByDay&#x60; | [optional] 
**WeeklyByDay** | **string** | This field is used only if you&#39;re scheduling a recurring meeting of type &#x60;3&#x60; to state which day in a month the meeting should recur. The value range is 1 - 31. For instance, if the meeting should recur each month on 23rd, provide &#x60;23&#x60; as the value of this field and &#x60;1&#x60; as the value of the recurrence &#x60;interval&#x60; field. And if the meeting should recur every three months, on 23rd of the month, change the value of the recurrence &#x60;interval&#x60; field to &#x60;3&#x60;. | [optional] 
**WeeklyByDays** | **string** | This field is used only if you&#39;re scheduling a recurring meeting of type &#x60;2&#x60; to state which day(s) of the week the meeting should recur. The values are: 1 - Sunday; 2 - Monday; 3- Tuesday; 4 - Wednesday; 5 - Thursday; 6 - Friday; 7 - Saturday. Multiple values are supported, should be specified separated by comma | [optional] 
**MonthlyByDay** | **int** | The supported range is 1-31 | [optional] 
**MonthlyByWeekDay** | **int** | This field is used only if you&#39;re scheduling a recurring meeting of type &#x60;3&#x60; to state a specific day in a week when the monthly meeting should recur; it works together with &#x60;MonthlyByWeek&#x60; field. The values are: 1 - Sunday; 2 - Monday; 3 - Tuesday; 4 - Wednesday; 5 - Thursday; 6 - Friday; 7- Saturday | [optional] 
**Count** | **int** | Number of meeting occurrences | [optional] 
**Until** | **string** | Meeting expiration datetime | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

