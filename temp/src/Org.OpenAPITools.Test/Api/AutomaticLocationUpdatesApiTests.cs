/*
 * RingCentral Connect Platform API
 *
 * RingCentral Connect Platform API
 *
 * The version of the OpenAPI document: 1.0.48
 * Contact: platform@ringcentral.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Org.OpenAPITools.Client;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Test
{
    /// <summary>
    ///  Class for testing AutomaticLocationUpdatesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AutomaticLocationUpdatesApiTests
    {
        private AutomaticLocationUpdatesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AutomaticLocationUpdatesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AutomaticLocationUpdatesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' AutomaticLocationUpdatesApi
            //Assert.IsInstanceOf(typeof(AutomaticLocationUpdatesApi), instance);
        }

        
        /// <summary>
        /// Test AssignMultipleAutomaticLocationUpdatesUsers
        /// </summary>
        [Test]
        public void AssignMultipleAutomaticLocationUpdatesUsersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //BulkAssignAutomaticLocationUpdatesUsers bulkAssignAutomaticLocationUpdatesUsers = null;
            //instance.AssignMultipleAutomaticLocationUpdatesUsers(accountId, bulkAssignAutomaticLocationUpdatesUsers);
            
        }
        
        /// <summary>
        /// Test AssignMultipleDevicesAutomaticLocationUpdates
        /// </summary>
        [Test]
        public void AssignMultipleDevicesAutomaticLocationUpdatesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //AssignMultipleDevicesAutomaticLocationUpdates assignMultipleDevicesAutomaticLocationUpdates = null;
            //instance.AssignMultipleDevicesAutomaticLocationUpdates(accountId, assignMultipleDevicesAutomaticLocationUpdates);
            
        }
        
        /// <summary>
        /// Test CreateEmergencyLocation
        /// </summary>
        [Test]
        public void CreateEmergencyLocationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //EmergencyLocationInfoRequest emergencyLocationInfoRequest = null;
            //instance.CreateEmergencyLocation(accountId, emergencyLocationInfoRequest);
            
        }
        
        /// <summary>
        /// Test CreateExtensionEmergencyLocation
        /// </summary>
        [Test]
        public void CreateExtensionEmergencyLocationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string extensionId = null;
            //CreateUserEmergencyLocationRequest createUserEmergencyLocationRequest = null;
            //var response = instance.CreateExtensionEmergencyLocation(accountId, extensionId, createUserEmergencyLocationRequest);
            //Assert.IsInstanceOf(typeof(EmergencyLocationInfo), response, "response is EmergencyLocationInfo");
        }
        
        /// <summary>
        /// Test CreateMultipleSwitches
        /// </summary>
        [Test]
        public void CreateMultipleSwitchesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //CreateMultipleSwitchesRequest createMultipleSwitchesRequest = null;
            //var response = instance.CreateMultipleSwitches(accountId, createMultipleSwitchesRequest);
            //Assert.IsInstanceOf(typeof(CreateMultipleSwitchesResponse), response, "response is CreateMultipleSwitchesResponse");
        }
        
        /// <summary>
        /// Test CreateMultipleWirelessPoints
        /// </summary>
        [Test]
        public void CreateMultipleWirelessPointsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //CreateMultipleWirelessPointsRequest createMultipleWirelessPointsRequest = null;
            //var response = instance.CreateMultipleWirelessPoints(accountId, createMultipleWirelessPointsRequest);
            //Assert.IsInstanceOf(typeof(CreateMultipleWirelessPointsResponse), response, "response is CreateMultipleWirelessPointsResponse");
        }
        
        /// <summary>
        /// Test CreateNetwork
        /// </summary>
        [Test]
        public void CreateNetworkTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //CreateNetworkRequest createNetworkRequest = null;
            //var response = instance.CreateNetwork(accountId, createNetworkRequest);
            //Assert.IsInstanceOf(typeof(NetworkInfo), response, "response is NetworkInfo");
        }
        
        /// <summary>
        /// Test CreateSwitch
        /// </summary>
        [Test]
        public void CreateSwitchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //CreateSwitchInfo createSwitchInfo = null;
            //var response = instance.CreateSwitch(accountId, createSwitchInfo);
            //Assert.IsInstanceOf(typeof(SwitchInfo), response, "response is SwitchInfo");
        }
        
        /// <summary>
        /// Test CreateWirelessPoint
        /// </summary>
        [Test]
        public void CreateWirelessPointTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //CreateWirelessPoint createWirelessPoint = null;
            //var response = instance.CreateWirelessPoint(accountId, createWirelessPoint);
            //Assert.IsInstanceOf(typeof(WirelessPointInfo), response, "response is WirelessPointInfo");
        }
        
        /// <summary>
        /// Test DeleteEmergencyLocation
        /// </summary>
        [Test]
        public void DeleteEmergencyLocationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string locationId = null;
            //string newLocationId = null;
            //bool? validateOnly = null;
            //instance.DeleteEmergencyLocation(accountId, locationId, newLocationId, validateOnly);
            
        }
        
        /// <summary>
        /// Test DeleteExtensionEmergencyLocation
        /// </summary>
        [Test]
        public void DeleteExtensionEmergencyLocationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string extensionId = null;
            //string locationId = null;
            //bool? validateOnly = null;
            //instance.DeleteExtensionEmergencyLocation(accountId, extensionId, locationId, validateOnly);
            
        }
        
        /// <summary>
        /// Test DeleteNetwork
        /// </summary>
        [Test]
        public void DeleteNetworkTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //List<string> networkId = null;
            //instance.DeleteNetwork(accountId, networkId);
            
        }
        
        /// <summary>
        /// Test DeleteSwitch
        /// </summary>
        [Test]
        public void DeleteSwitchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //List<string> switchId = null;
            //instance.DeleteSwitch(accountId, switchId);
            
        }
        
        /// <summary>
        /// Test DeleteWirelessPoint
        /// </summary>
        [Test]
        public void DeleteWirelessPointTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //List<string> pointId = null;
            //instance.DeleteWirelessPoint(accountId, pointId);
            
        }
        
        /// <summary>
        /// Test GetExtensionEmergencyLocation
        /// </summary>
        [Test]
        public void GetExtensionEmergencyLocationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string extensionId = null;
            //string locationId = null;
            //var response = instance.GetExtensionEmergencyLocation(accountId, extensionId, locationId);
            //Assert.IsInstanceOf(typeof(EmergencyLocationInfo), response, "response is EmergencyLocationInfo");
        }
        
        /// <summary>
        /// Test GetExtensionEmergencyLocations
        /// </summary>
        [Test]
        public void GetExtensionEmergencyLocationsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string extensionId = null;
            //List<string> siteId = null;
            //string searchString = null;
            //string domesticCountryId = null;
            //string orderBy = null;
            //int? perPage = null;
            //int? page = null;
            //string visibility = null;
            //string ifNoneMatch = null;
            //var response = instance.GetExtensionEmergencyLocations(accountId, extensionId, siteId, searchString, domesticCountryId, orderBy, perPage, page, visibility, ifNoneMatch);
            //Assert.IsInstanceOf(typeof(EmergencyLocationsResource), response, "response is EmergencyLocationsResource");
        }
        
        /// <summary>
        /// Test ListAccountSwitches
        /// </summary>
        [Test]
        public void ListAccountSwitchesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string siteId = null;
            //string searchString = null;
            //string orderBy = null;
            //int? perPage = null;
            //int? page = null;
            //var response = instance.ListAccountSwitches(accountId, siteId, searchString, orderBy, perPage, page);
            //Assert.IsInstanceOf(typeof(SwitchesList), response, "response is SwitchesList");
        }
        
        /// <summary>
        /// Test ListAutomaticLocationUpdatesUsers
        /// </summary>
        [Test]
        public void ListAutomaticLocationUpdatesUsersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string type = null;
            //string searchString = null;
            //string department = null;
            //string siteId = null;
            //bool? featureEnabled = null;
            //string orderBy = null;
            //int? perPage = null;
            //int? page = null;
            //var response = instance.ListAutomaticLocationUpdatesUsers(accountId, type, searchString, department, siteId, featureEnabled, orderBy, perPage, page);
            //Assert.IsInstanceOf(typeof(AutomaticLocationUpdatesUserList), response, "response is AutomaticLocationUpdatesUserList");
        }
        
        /// <summary>
        /// Test ListDevicesAutomaticLocationUpdates
        /// </summary>
        [Test]
        public void ListDevicesAutomaticLocationUpdatesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string siteId = null;
            //bool? featureEnabled = null;
            //string model = null;
            //bool? compatibleOnly = null;
            //string searchString = null;
            //string orderBy = null;
            //int? perPage = null;
            //int? page = null;
            //var response = instance.ListDevicesAutomaticLocationUpdates(accountId, siteId, featureEnabled, model, compatibleOnly, searchString, orderBy, perPage, page);
            //Assert.IsInstanceOf(typeof(ListDevicesAutomaticLocationUpdates), response, "response is ListDevicesAutomaticLocationUpdates");
        }
        
        /// <summary>
        /// Test ListEmergencyLocations
        /// </summary>
        [Test]
        public void ListEmergencyLocationsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string searchString = null;
            //string siteId = null;
            //string addressStatus = null;
            //string usageStatus = null;
            //string domesticCountryId = null;
            //string orderBy = null;
            //int? perPage = null;
            //int? page = null;
            //var response = instance.ListEmergencyLocations(accountId, searchString, siteId, addressStatus, usageStatus, domesticCountryId, orderBy, perPage, page);
            //Assert.IsInstanceOf(typeof(EmergencyLocationList), response, "response is EmergencyLocationList");
        }
        
        /// <summary>
        /// Test ListNetworks
        /// </summary>
        [Test]
        public void ListNetworksTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //var response = instance.ListNetworks(accountId);
            //Assert.IsInstanceOf(typeof(NetworksList), response, "response is NetworksList");
        }
        
        /// <summary>
        /// Test ListWirelessPoints
        /// </summary>
        [Test]
        public void ListWirelessPointsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string siteId = null;
            //string searchString = null;
            //string orderBy = null;
            //int? perPage = null;
            //int? page = null;
            //var response = instance.ListWirelessPoints(accountId, siteId, searchString, orderBy, perPage, page);
            //Assert.IsInstanceOf(typeof(WirelessPointsList), response, "response is WirelessPointsList");
        }
        
        /// <summary>
        /// Test ReadAutomaticLocationUpdatesTask
        /// </summary>
        [Test]
        public void ReadAutomaticLocationUpdatesTaskTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string taskId = null;
            //var response = instance.ReadAutomaticLocationUpdatesTask(accountId, taskId);
            //Assert.IsInstanceOf(typeof(AutomaticLocationUpdatesTaskInfo), response, "response is AutomaticLocationUpdatesTaskInfo");
        }
        
        /// <summary>
        /// Test ReadEmergencyLocation
        /// </summary>
        [Test]
        public void ReadEmergencyLocationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string locationId = null;
            //var response = instance.ReadEmergencyLocation(accountId, locationId);
            //Assert.IsInstanceOf(typeof(EmergencyLocationInfo), response, "response is EmergencyLocationInfo");
        }
        
        /// <summary>
        /// Test ReadNetwork
        /// </summary>
        [Test]
        public void ReadNetworkTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string networkId = null;
            //var response = instance.ReadNetwork(accountId, networkId);
            //Assert.IsInstanceOf(typeof(NetworkInfo), response, "response is NetworkInfo");
        }
        
        /// <summary>
        /// Test ReadSwitch
        /// </summary>
        [Test]
        public void ReadSwitchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string switchId = null;
            //var response = instance.ReadSwitch(accountId, switchId);
            //Assert.IsInstanceOf(typeof(SwitchInfo), response, "response is SwitchInfo");
        }
        
        /// <summary>
        /// Test ReadWirelessPoint
        /// </summary>
        [Test]
        public void ReadWirelessPointTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string pointId = null;
            //var response = instance.ReadWirelessPoint(accountId, pointId);
            //Assert.IsInstanceOf(typeof(WirelessPointInfo), response, "response is WirelessPointInfo");
        }
        
        /// <summary>
        /// Test UpdateEmergencyLocation
        /// </summary>
        [Test]
        public void UpdateEmergencyLocationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string locationId = null;
            //EmergencyLocationInfoRequest emergencyLocationInfoRequest = null;
            //var response = instance.UpdateEmergencyLocation(accountId, locationId, emergencyLocationInfoRequest);
            //Assert.IsInstanceOf(typeof(EmergencyLocationInfo), response, "response is EmergencyLocationInfo");
        }
        
        /// <summary>
        /// Test UpdateExtensionEmergencyLocation
        /// </summary>
        [Test]
        public void UpdateExtensionEmergencyLocationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string extensionId = null;
            //string locationId = null;
            //EmergencyLocationInfo emergencyLocationInfo = null;
            //var response = instance.UpdateExtensionEmergencyLocation(accountId, extensionId, locationId, emergencyLocationInfo);
            //Assert.IsInstanceOf(typeof(EmergencyLocationInfo), response, "response is EmergencyLocationInfo");
        }
        
        /// <summary>
        /// Test UpdateMultipleSwitches
        /// </summary>
        [Test]
        public void UpdateMultipleSwitchesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //UpdateMultipleSwitchesRequest updateMultipleSwitchesRequest = null;
            //var response = instance.UpdateMultipleSwitches(accountId, updateMultipleSwitchesRequest);
            //Assert.IsInstanceOf(typeof(UpdateMultipleSwitchesResponse), response, "response is UpdateMultipleSwitchesResponse");
        }
        
        /// <summary>
        /// Test UpdateMultipleWirelessPoints
        /// </summary>
        [Test]
        public void UpdateMultipleWirelessPointsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //UpdateMultipleWirelessPointsRequest updateMultipleWirelessPointsRequest = null;
            //var response = instance.UpdateMultipleWirelessPoints(accountId, updateMultipleWirelessPointsRequest);
            //Assert.IsInstanceOf(typeof(UpdateMultipleWirelessPointsResponse), response, "response is UpdateMultipleWirelessPointsResponse");
        }
        
        /// <summary>
        /// Test UpdateNetwork
        /// </summary>
        [Test]
        public void UpdateNetworkTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string networkId = null;
            //UpdateNetworkRequest updateNetworkRequest = null;
            //instance.UpdateNetwork(accountId, networkId, updateNetworkRequest);
            
        }
        
        /// <summary>
        /// Test UpdateSwitch
        /// </summary>
        [Test]
        public void UpdateSwitchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string switchId = null;
            //UpdateSwitchInfo updateSwitchInfo = null;
            //var response = instance.UpdateSwitch(accountId, switchId, updateSwitchInfo);
            //Assert.IsInstanceOf(typeof(SwitchInfo), response, "response is SwitchInfo");
        }
        
        /// <summary>
        /// Test UpdateWirelessPoint
        /// </summary>
        [Test]
        public void UpdateWirelessPointTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string pointId = null;
            //UpdateWirelessPoint updateWirelessPoint = null;
            //var response = instance.UpdateWirelessPoint(accountId, pointId, updateWirelessPoint);
            //Assert.IsInstanceOf(typeof(WirelessPointInfo), response, "response is WirelessPointInfo");
        }
        
        /// <summary>
        /// Test ValidateMultipleSwitches
        /// </summary>
        [Test]
        public void ValidateMultipleSwitchesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //ValidateMultipleSwitchesRequest validateMultipleSwitchesRequest = null;
            //var response = instance.ValidateMultipleSwitches(accountId, validateMultipleSwitchesRequest);
            //Assert.IsInstanceOf(typeof(ValidateMultipleSwitchesResponse), response, "response is ValidateMultipleSwitchesResponse");
        }
        
        /// <summary>
        /// Test ValidateMultipleWirelessPoints
        /// </summary>
        [Test]
        public void ValidateMultipleWirelessPointsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //ValidateMultipleWirelessPointsRequest validateMultipleWirelessPointsRequest = null;
            //var response = instance.ValidateMultipleWirelessPoints(accountId, validateMultipleWirelessPointsRequest);
            //Assert.IsInstanceOf(typeof(ValidateMultipleWirelessPointsResponse), response, "response is ValidateMultipleWirelessPointsResponse");
        }
        
    }

}