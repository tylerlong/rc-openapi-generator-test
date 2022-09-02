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
    ///  Class for testing ExternalContactsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ExternalContactsApiTests
    {
        private ExternalContactsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ExternalContactsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ExternalContactsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' ExternalContactsApi
            //Assert.IsInstanceOf(typeof(ExternalContactsApi), instance);
        }

        
        /// <summary>
        /// Test AddressBookBulkUpload
        /// </summary>
        [Test]
        public void AddressBookBulkUploadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //AddressBookBulkUploadRequest addressBookBulkUploadRequest = null;
            //var response = instance.AddressBookBulkUpload(accountId, addressBookBulkUploadRequest);
            //Assert.IsInstanceOf(typeof(AddressBookBulkUploadResponse), response, "response is AddressBookBulkUploadResponse");
        }
        
        /// <summary>
        /// Test CreateContact
        /// </summary>
        [Test]
        public void CreateContactTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string extensionId = null;
            //string dialingPlan = null;
            //PersonalContactRequest personalContactRequest = null;
            //var response = instance.CreateContact(accountId, extensionId, dialingPlan, personalContactRequest);
            //Assert.IsInstanceOf(typeof(PersonalContactResource), response, "response is PersonalContactResource");
        }
        
        /// <summary>
        /// Test DeleteContact
        /// </summary>
        [Test]
        public void DeleteContactTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string extensionId = null;
            //long contactId = null;
            //instance.DeleteContact(accountId, extensionId, contactId);
            
        }
        
        /// <summary>
        /// Test GetAddressBookBulkUploadTask
        /// </summary>
        [Test]
        public void GetAddressBookBulkUploadTaskTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string taskId = null;
            //var response = instance.GetAddressBookBulkUploadTask(accountId, taskId);
            //Assert.IsInstanceOf(typeof(AddressBookBulkUploadResponse), response, "response is AddressBookBulkUploadResponse");
        }
        
        /// <summary>
        /// Test ListContacts
        /// </summary>
        [Test]
        public void ListContactsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string extensionId = null;
            //string startsWith = null;
            //List<string> sortBy = null;
            //int? page = null;
            //int? perPage = null;
            //List<string> phoneNumber = null;
            //var response = instance.ListContacts(accountId, extensionId, startsWith, sortBy, page, perPage, phoneNumber);
            //Assert.IsInstanceOf(typeof(ContactList), response, "response is ContactList");
        }
        
        /// <summary>
        /// Test ListFavoriteContacts
        /// </summary>
        [Test]
        public void ListFavoriteContactsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string extensionId = null;
            //var response = instance.ListFavoriteContacts(accountId, extensionId);
            //Assert.IsInstanceOf(typeof(FavoriteContactList), response, "response is FavoriteContactList");
        }
        
        /// <summary>
        /// Test ReadContact
        /// </summary>
        [Test]
        public void ReadContactTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string extensionId = null;
            //long contactId = null;
            //var response = instance.ReadContact(accountId, extensionId, contactId);
            //Assert.IsInstanceOf(typeof(PersonalContactResource), response, "response is PersonalContactResource");
        }
        
        /// <summary>
        /// Test SyncAddressBook
        /// </summary>
        [Test]
        public void SyncAddressBookTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string extensionId = null;
            //string syncType = null;
            //string syncToken = null;
            //int? perPage = null;
            //long? pageId = null;
            //var response = instance.SyncAddressBook(accountId, extensionId, syncType, syncToken, perPage, pageId);
            //Assert.IsInstanceOf(typeof(AddressBookSync), response, "response is AddressBookSync");
        }
        
        /// <summary>
        /// Test UpdateContact
        /// </summary>
        [Test]
        public void UpdateContactTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string extensionId = null;
            //long contactId = null;
            //string dialingPlan = null;
            //PersonalContactRequest personalContactRequest = null;
            //var response = instance.UpdateContact(accountId, extensionId, contactId, dialingPlan, personalContactRequest);
            //Assert.IsInstanceOf(typeof(PersonalContactResource), response, "response is PersonalContactResource");
        }
        
        /// <summary>
        /// Test UpdateFavoriteContactList
        /// </summary>
        [Test]
        public void UpdateFavoriteContactListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string extensionId = null;
            //FavoriteCollection favoriteCollection = null;
            //var response = instance.UpdateFavoriteContactList(accountId, extensionId, favoriteCollection);
            //Assert.IsInstanceOf(typeof(FavoriteContactList), response, "response is FavoriteContactList");
        }
        
    }

}