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
    ///  Class for testing SiteAdministrationApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class SiteAdministrationApiTests
    {
        private SiteAdministrationApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new SiteAdministrationApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SiteAdministrationApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' SiteAdministrationApi
            //Assert.IsInstanceOf(typeof(SiteAdministrationApi), instance);
        }

        
        /// <summary>
        /// Test ListAdministeredSites
        /// </summary>
        [Test]
        public void ListAdministeredSitesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string extensionId = null;
            //instance.ListAdministeredSites(accountId, extensionId);
            
        }
        
        /// <summary>
        /// Test UpdateUserAdministeredSites
        /// </summary>
        [Test]
        public void UpdateUserAdministeredSitesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string extensionId = null;
            //BusinessSiteCollectionRequest businessSiteCollectionRequest = null;
            //var response = instance.UpdateUserAdministeredSites(accountId, extensionId, businessSiteCollectionRequest);
            //Assert.IsInstanceOf(typeof(BusinessSiteCollectionResource), response, "response is BusinessSiteCollectionResource");
        }
        
    }

}