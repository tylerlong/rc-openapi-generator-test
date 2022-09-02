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
    ///  Class for testing CallForwardingApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class CallForwardingApiTests
    {
        private CallForwardingApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CallForwardingApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CallForwardingApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' CallForwardingApi
            //Assert.IsInstanceOf(typeof(CallForwardingApi), instance);
        }

        
        /// <summary>
        /// Test CreateForwardingNumber
        /// </summary>
        [Test]
        public void CreateForwardingNumberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string extensionId = null;
            //CreateForwardingNumberRequest createForwardingNumberRequest = null;
            //var response = instance.CreateForwardingNumber(accountId, extensionId, createForwardingNumberRequest);
            //Assert.IsInstanceOf(typeof(ForwardingNumberInfo), response, "response is ForwardingNumberInfo");
        }
        
        /// <summary>
        /// Test DeleteForwardingNumber
        /// </summary>
        [Test]
        public void DeleteForwardingNumberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string extensionId = null;
            //string forwardingNumberId = null;
            //instance.DeleteForwardingNumber(accountId, extensionId, forwardingNumberId);
            
        }
        
        /// <summary>
        /// Test DeleteForwardingNumbers
        /// </summary>
        [Test]
        public void DeleteForwardingNumbersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string extensionId = null;
            //DeleteForwardingNumbersRequest deleteForwardingNumbersRequest = null;
            //instance.DeleteForwardingNumbers(accountId, extensionId, deleteForwardingNumbersRequest);
            
        }
        
        /// <summary>
        /// Test ListForwardingNumbers
        /// </summary>
        [Test]
        public void ListForwardingNumbersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string extensionId = null;
            //int? page = null;
            //int? perPage = null;
            //var response = instance.ListForwardingNumbers(accountId, extensionId, page, perPage);
            //Assert.IsInstanceOf(typeof(GetExtensionForwardingNumberListResponse), response, "response is GetExtensionForwardingNumberListResponse");
        }
        
        /// <summary>
        /// Test ReadForwardingNumber
        /// </summary>
        [Test]
        public void ReadForwardingNumberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string forwardingNumberId = null;
            //string extensionId = null;
            //string accountId = null;
            //var response = instance.ReadForwardingNumber(forwardingNumberId, extensionId, accountId);
            //Assert.IsInstanceOf(typeof(ForwardingNumberInfo), response, "response is ForwardingNumberInfo");
        }
        
        /// <summary>
        /// Test UpdateForwardingNumber
        /// </summary>
        [Test]
        public void UpdateForwardingNumberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string extensionId = null;
            //string forwardingNumberId = null;
            //UpdateForwardingNumberRequest updateForwardingNumberRequest = null;
            //var response = instance.UpdateForwardingNumber(accountId, extensionId, forwardingNumberId, updateForwardingNumberRequest);
            //Assert.IsInstanceOf(typeof(ForwardingNumberInfo), response, "response is ForwardingNumberInfo");
        }
        
    }

}
