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
    ///  Class for testing PhoneNumbersApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class PhoneNumbersApiTests
    {
        private PhoneNumbersApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PhoneNumbersApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PhoneNumbersApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' PhoneNumbersApi
            //Assert.IsInstanceOf(typeof(PhoneNumbersApi), instance);
        }

        
        /// <summary>
        /// Test ListAccountPhoneNumbers
        /// </summary>
        [Test]
        public void ListAccountPhoneNumbersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //int? page = null;
            //int? perPage = null;
            //List<string> usageType = null;
            //string status = null;
            //var response = instance.ListAccountPhoneNumbers(accountId, page, perPage, usageType, status);
            //Assert.IsInstanceOf(typeof(AccountPhoneNumbers), response, "response is AccountPhoneNumbers");
        }
        
        /// <summary>
        /// Test ListExtensionPhoneNumbers
        /// </summary>
        [Test]
        public void ListExtensionPhoneNumbersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string extensionId = null;
            //string status = null;
            //List<string> usageType = null;
            //int? page = null;
            //int? perPage = null;
            //var response = instance.ListExtensionPhoneNumbers(accountId, extensionId, status, usageType, page, perPage);
            //Assert.IsInstanceOf(typeof(GetExtensionPhoneNumbersResponse), response, "response is GetExtensionPhoneNumbersResponse");
        }
        
        /// <summary>
        /// Test ParsePhoneNumber
        /// </summary>
        [Test]
        public void ParsePhoneNumberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ParsePhoneNumberRequest parsePhoneNumberRequest = null;
            //string homeCountry = null;
            //bool? nationalAsPriority = null;
            //var response = instance.ParsePhoneNumber(parsePhoneNumberRequest, homeCountry, nationalAsPriority);
            //Assert.IsInstanceOf(typeof(ParsePhoneNumberResponse), response, "response is ParsePhoneNumberResponse");
        }
        
        /// <summary>
        /// Test ReadAccountPhoneNumber
        /// </summary>
        [Test]
        public void ReadAccountPhoneNumberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //long phoneNumberId = null;
            //var response = instance.ReadAccountPhoneNumber(accountId, phoneNumberId);
            //Assert.IsInstanceOf(typeof(CompanyPhoneNumberInfo), response, "response is CompanyPhoneNumberInfo");
        }
        
    }

}
