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
    ///  Class for testing DevicesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class DevicesApiTests
    {
        private DevicesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DevicesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DevicesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' DevicesApi
            //Assert.IsInstanceOf(typeof(DevicesApi), instance);
        }

        
        /// <summary>
        /// Test ListExtensionDevices
        /// </summary>
        [Test]
        public void ListExtensionDevicesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string extensionId = null;
            //string linePooling = null;
            //string feature = null;
            //string page = null;
            //string perPage = null;
            //string line = null;
            //string lineType = null;
            //var response = instance.ListExtensionDevices(accountId, extensionId, linePooling, feature, page, perPage, line, lineType);
            //Assert.IsInstanceOf(typeof(GetExtensionDevicesResponse), response, "response is GetExtensionDevicesResponse");
        }
        
        /// <summary>
        /// Test ReadDevice
        /// </summary>
        [Test]
        public void ReadDeviceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //long deviceId = null;
            //bool? syncEmergencyAddress = null;
            //var response = instance.ReadDevice(accountId, deviceId, syncEmergencyAddress);
            //Assert.IsInstanceOf(typeof(GetDeviceInfoResponse), response, "response is GetDeviceInfoResponse");
        }
        
        /// <summary>
        /// Test ReadDeviceSIPInfo
        /// </summary>
        [Test]
        public void ReadDeviceSIPInfoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string deviceId = null;
            //string accountId = null;
            //var response = instance.ReadDeviceSIPInfo(deviceId, accountId);
            //Assert.IsInstanceOf(typeof(SipInfoResource), response, "response is SipInfoResource");
        }
        
        /// <summary>
        /// Test UpdateDevice
        /// </summary>
        [Test]
        public void UpdateDeviceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string deviceId = null;
            //string accountId = null;
            //bool? prestatement = null;
            //AccountDeviceUpdate accountDeviceUpdate = null;
            //var response = instance.UpdateDevice(deviceId, accountId, prestatement, accountDeviceUpdate);
            //Assert.IsInstanceOf(typeof(GetDeviceInfoResponse), response, "response is GetDeviceInfoResponse");
        }
        
    }

}
