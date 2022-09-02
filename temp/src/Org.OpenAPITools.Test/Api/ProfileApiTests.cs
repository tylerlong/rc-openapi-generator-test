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
    ///  Class for testing ProfileApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ProfileApiTests
    {
        private ProfileApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ProfileApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ProfileApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' ProfileApi
            //Assert.IsInstanceOf(typeof(ProfileApi), instance);
        }

        
        /// <summary>
        /// Test ReadGlipCompany
        /// </summary>
        [Test]
        public void ReadGlipCompanyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string companyId = null;
            //var response = instance.ReadGlipCompany(companyId);
            //Assert.IsInstanceOf(typeof(GlipCompany), response, "response is GlipCompany");
        }
        
        /// <summary>
        /// Test ReadGlipPerson
        /// </summary>
        [Test]
        public void ReadGlipPersonTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string personId = null;
            //var response = instance.ReadGlipPerson(personId);
            //Assert.IsInstanceOf(typeof(GlipPersonInfo), response, "response is GlipPersonInfo");
        }
        
        /// <summary>
        /// Test ReadGlipPreferences
        /// </summary>
        [Test]
        public void ReadGlipPreferencesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ReadGlipPreferences();
            //Assert.IsInstanceOf(typeof(GlipPreferencesInfo), response, "response is GlipPreferencesInfo");
        }
        
    }

}