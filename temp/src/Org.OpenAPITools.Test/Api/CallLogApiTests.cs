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
    ///  Class for testing CallLogApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class CallLogApiTests
    {
        private CallLogApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CallLogApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CallLogApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' CallLogApi
            //Assert.IsInstanceOf(typeof(CallLogApi), instance);
        }

        
        /// <summary>
        /// Test DeleteUserCallLog
        /// </summary>
        [Test]
        public void DeleteUserCallLogTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string extensionId = null;
            //DateTime? dateTo = null;
            //instance.DeleteUserCallLog(accountId, extensionId, dateTo);
            
        }
        
        /// <summary>
        /// Test ListCompanyActiveCalls
        /// </summary>
        [Test]
        public void ListCompanyActiveCallsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //List<string> direction = null;
            //string view = null;
            //List<string> type = null;
            //List<string> transport = null;
            //int? page = null;
            //int? perPage = null;
            //var response = instance.ListCompanyActiveCalls(accountId, direction, view, type, transport, page, perPage);
            //Assert.IsInstanceOf(typeof(CompanyActiveCallsResponse), response, "response is CompanyActiveCallsResponse");
        }
        
        /// <summary>
        /// Test ListExtensionActiveCalls
        /// </summary>
        [Test]
        public void ListExtensionActiveCallsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string extensionId = null;
            //List<string> direction = null;
            //string view = null;
            //List<string> type = null;
            //int? page = null;
            //int? perPage = null;
            //var response = instance.ListExtensionActiveCalls(accountId, extensionId, direction, view, type, page, perPage);
            //Assert.IsInstanceOf(typeof(UserActiveCallsResponse), response, "response is UserActiveCallsResponse");
        }
        
        /// <summary>
        /// Test ReadCompanyCallLog
        /// </summary>
        [Test]
        public void ReadCompanyCallLogTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string extensionNumber = null;
            //string phoneNumber = null;
            //List<string> direction = null;
            //List<string> type = null;
            //string view = null;
            //bool? withRecording = null;
            //string recordingType = null;
            //DateTime? dateFrom = null;
            //DateTime? dateTo = null;
            //int? page = null;
            //int? perPage = null;
            //string sessionId = null;
            //var response = instance.ReadCompanyCallLog(accountId, extensionNumber, phoneNumber, direction, type, view, withRecording, recordingType, dateFrom, dateTo, page, perPage, sessionId);
            //Assert.IsInstanceOf(typeof(AccountCallLogResponse), response, "response is AccountCallLogResponse");
        }
        
        /// <summary>
        /// Test ReadCompanyCallRecord
        /// </summary>
        [Test]
        public void ReadCompanyCallRecordTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string callRecordId = null;
            //string view = null;
            //var response = instance.ReadCompanyCallRecord(accountId, callRecordId, view);
            //Assert.IsInstanceOf(typeof(CompanyCallLogRecord), response, "response is CompanyCallLogRecord");
        }
        
        /// <summary>
        /// Test ReadUserCallLog
        /// </summary>
        [Test]
        public void ReadUserCallLogTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string extensionId = null;
            //string extensionNumber = null;
            //bool? showBlocked = null;
            //string phoneNumber = null;
            //List<string> direction = null;
            //string sessionId = null;
            //List<string> type = null;
            //List<string> transport = null;
            //string view = null;
            //bool? withRecording = null;
            //string recordingType = null;
            //DateTime? dateTo = null;
            //DateTime? dateFrom = null;
            //int? page = null;
            //int? perPage = null;
            //bool? showDeleted = null;
            //var response = instance.ReadUserCallLog(accountId, extensionId, extensionNumber, showBlocked, phoneNumber, direction, sessionId, type, transport, view, withRecording, recordingType, dateTo, dateFrom, page, perPage, showDeleted);
            //Assert.IsInstanceOf(typeof(UserCallLogResponse), response, "response is UserCallLogResponse");
        }
        
        /// <summary>
        /// Test ReadUserCallRecord
        /// </summary>
        [Test]
        public void ReadUserCallRecordTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<string> callRecordId = null;
            //string extensionId = null;
            //string accountId = null;
            //string view = null;
            //var response = instance.ReadUserCallRecord(callRecordId, extensionId, accountId, view);
            //Assert.IsInstanceOf(typeof(UserCallLogRecord), response, "response is UserCallLogRecord");
        }
        
        /// <summary>
        /// Test SyncAccountCallLog
        /// </summary>
        [Test]
        public void SyncAccountCallLogTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string syncType = null;
            //string syncToken = null;
            //DateTime? dateFrom = null;
            //int? recordCount = null;
            //List<string> statusGroup = null;
            //string view = null;
            //bool? showDeleted = null;
            //var response = instance.SyncAccountCallLog(accountId, syncType, syncToken, dateFrom, recordCount, statusGroup, view, showDeleted);
            //Assert.IsInstanceOf(typeof(AccountCallLogSyncResponse), response, "response is AccountCallLogSyncResponse");
        }
        
        /// <summary>
        /// Test SyncUserCallLog
        /// </summary>
        [Test]
        public void SyncUserCallLogTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string extensionId = null;
            //string syncType = null;
            //string syncToken = null;
            //DateTime? dateFrom = null;
            //int? recordCount = null;
            //List<string> statusGroup = null;
            //string view = null;
            //bool? showDeleted = null;
            //var response = instance.SyncUserCallLog(accountId, extensionId, syncType, syncToken, dateFrom, recordCount, statusGroup, view, showDeleted);
            //Assert.IsInstanceOf(typeof(CallLogSync), response, "response is CallLogSync");
        }
        
    }

}
