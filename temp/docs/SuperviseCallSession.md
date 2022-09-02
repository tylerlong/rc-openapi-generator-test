
# Org.OpenAPITools.Model.SuperviseCallSession

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**From** | [**SupervisePartyFrom**](SupervisePartyFrom.md) |  | [optional] 
**To** | [**SupervisePartyTo**](SupervisePartyTo.md) |  | [optional] 
**Direction** | **string** | Direction of a call | [optional] 
**Id** | **string** | Internal identifier of a party that monitors a call | [optional] 
**AccountId** | **string** | Internal identifier of an account that monitors a call | [optional] 
**ExtensionId** | **string** | Internal identifier of an extension that monitors a call | [optional] 
**Muted** | **bool** | Specifies if a call participant is muted or not. **Note:** If a call is also controlled via Hard phone or RingCentral App (not only through the API by calling call control methods) then it cannot be fully muted/unmuted via API only, in this case the action should be duplicated via Hard phone/RC App interfaces | [optional] 
**Owner** | [**OwnerInfo**](OwnerInfo.md) |  | [optional] 
**StandAlone** | **bool** | If &#39;True&#39; then the party is not connected to a session voice conference, &#39;False&#39; means the party is connected to other parties in a session | [optional] 
**Status** | [**CallStatusInfo**](CallStatusInfo.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

