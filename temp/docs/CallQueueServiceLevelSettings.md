
# Org.OpenAPITools.Model.CallQueueServiceLevelSettings

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SlaGoal** | **int** | Target percentage of calls that must be answered by agents within the service level time threshold | [optional] 
**SlaThresholdSeconds** | **int** | The period of time in seconds that is considered to be an acceptable service level | [optional] 
**IncludeAbandonedCalls** | **bool** | Includes abandoned calls (when callers hang up prior to being served by an agent) into service-level calculation | [optional] 
**AbandonedThresholdSeconds** | **int** | Abandoned calls that are shorter than the defined period of time in seconds will not be included into the calculation of Service Level | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

