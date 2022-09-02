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
    ///  Class for testing AdaptiveCardsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AdaptiveCardsApiTests
    {
        private AdaptiveCardsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AdaptiveCardsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AdaptiveCardsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' AdaptiveCardsApi
            //Assert.IsInstanceOf(typeof(AdaptiveCardsApi), instance);
        }

        
        /// <summary>
        /// Test CreateGlipAdaptiveCard
        /// </summary>
        [Test]
        public void CreateGlipAdaptiveCardTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string chatId = null;
            //GlipAdaptiveCardRequest glipAdaptiveCardRequest = null;
            //var response = instance.CreateGlipAdaptiveCard(chatId, glipAdaptiveCardRequest);
            //Assert.IsInstanceOf(typeof(GlipAdaptiveCardShortInfo), response, "response is GlipAdaptiveCardShortInfo");
        }
        
        /// <summary>
        /// Test DeleteGlipAdaptiveCard
        /// </summary>
        [Test]
        public void DeleteGlipAdaptiveCardTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string cardId = null;
            //instance.DeleteGlipAdaptiveCard(cardId);
            
        }
        
        /// <summary>
        /// Test GetGlipAdaptiveCard
        /// </summary>
        [Test]
        public void GetGlipAdaptiveCardTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<string> cardId = null;
            //var response = instance.GetGlipAdaptiveCard(cardId);
            //Assert.IsInstanceOf(typeof(GlipAdaptiveCardInfo), response, "response is GlipAdaptiveCardInfo");
        }
        
        /// <summary>
        /// Test UpdateGlipAdaptiveCard
        /// </summary>
        [Test]
        public void UpdateGlipAdaptiveCardTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string cardId = null;
            //GlipAdaptiveCardRequest glipAdaptiveCardRequest = null;
            //var response = instance.UpdateGlipAdaptiveCard(cardId, glipAdaptiveCardRequest);
            //Assert.IsInstanceOf(typeof(GlipAdaptiveCardShortInfo), response, "response is GlipAdaptiveCardShortInfo");
        }
        
    }

}