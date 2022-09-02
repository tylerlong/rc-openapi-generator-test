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
    ///  Class for testing UserPermissionsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class UserPermissionsApiTests
    {
        private UserPermissionsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new UserPermissionsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of UserPermissionsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' UserPermissionsApi
            //Assert.IsInstanceOf(typeof(UserPermissionsApi), instance);
        }

        
        /// <summary>
        /// Test CheckUserPermission
        /// </summary>
        [Test]
        public void CheckUserPermissionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string extensionId = null;
            //string accountId = null;
            //string permissionId = null;
            //string targetExtensionId = null;
            //var response = instance.CheckUserPermission(extensionId, accountId, permissionId, targetExtensionId);
            //Assert.IsInstanceOf(typeof(AuthProfileCheckResource), response, "response is AuthProfileCheckResource");
        }
        
        /// <summary>
        /// Test ReadAuthorizationProfile
        /// </summary>
        [Test]
        public void ReadAuthorizationProfileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string extensionId = null;
            //string accountId = null;
            //var response = instance.ReadAuthorizationProfile(extensionId, accountId);
            //Assert.IsInstanceOf(typeof(AuthProfileResource), response, "response is AuthProfileResource");
        }
        
    }

}
