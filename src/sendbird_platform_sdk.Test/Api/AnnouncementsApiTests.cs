/*
 * Sendbird Platform SDK
 *
 * Sendbird Platform API Javascript SDK  https://sendbird.com/docs/chat/v3/platform-api/getting-started/prepare-to-use-api
 *
 * The version of the OpenAPI document: 1.0.0
 * 
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

using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Model;

namespace sendbird_platform_sdk.Test
{
    /// <summary>
    ///  Class for testing AnnouncementsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AnnouncementsApiTests
    {
        private AnnouncementsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AnnouncementsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AnnouncementsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' AnnouncementsApi
            //Assert.IsInstanceOf(typeof(AnnouncementsApi), instance);
        }

        
        /// <summary>
        /// Test GetDetailedOpenRateOfAnnouncementById
        /// </summary>
        [Test]
        public void GetDetailedOpenRateOfAnnouncementByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string uniqueId = null;
            //string apiToken = null;
            //var response = instance.GetDetailedOpenRateOfAnnouncementById(uniqueId, apiToken);
            //Assert.IsInstanceOf(typeof(InlineResponse20042), response, "response is InlineResponse20042");
        }
        
        /// <summary>
        /// Test GetDetailedOpenRateOfAnnouncementGroup
        /// </summary>
        [Test]
        public void GetDetailedOpenRateOfAnnouncementGroupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string announcementGroup = null;
            //string apiToken = null;
            //var response = instance.GetDetailedOpenRateOfAnnouncementGroup(announcementGroup, apiToken);
            //Assert.IsInstanceOf(typeof(InlineResponse20046), response, "response is InlineResponse20046");
        }
        
        /// <summary>
        /// Test GetDetailedOpenStatusOfAnnouncementById
        /// </summary>
        [Test]
        public void GetDetailedOpenStatusOfAnnouncementByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string uniqueId = null;
            //string apiToken = null;
            //int? limit = null;
            //string next = null;
            //List<string> uniqueIds = null;
            //List<string> channelUrls = null;
            //bool? hasOpened = null;
            //var response = instance.GetDetailedOpenStatusOfAnnouncementById(uniqueId, apiToken, limit, next, uniqueIds, channelUrls, hasOpened);
            //Assert.IsInstanceOf(typeof(InlineResponse20043), response, "response is InlineResponse20043");
        }
        
        /// <summary>
        /// Test GetStatistics
        /// </summary>
        [Test]
        public void GetStatisticsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiToken = null;
            //var response = instance.GetStatistics(apiToken);
            //Assert.IsInstanceOf(typeof(InlineResponse20044), response, "response is InlineResponse20044");
        }
        
        /// <summary>
        /// Test GetStatisticsDaily
        /// </summary>
        [Test]
        public void GetStatisticsDailyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string startDate = null;
            //string endDate = null;
            //string startWeek = null;
            //string endWeek = null;
            //string startMonth = null;
            //string endMonth = null;
            //string apiToken = null;
            //string announcementGroup = null;
            //var response = instance.GetStatisticsDaily(startDate, endDate, startWeek, endWeek, startMonth, endMonth, apiToken, announcementGroup);
            //Assert.IsInstanceOf(typeof(InlineResponse20044), response, "response is InlineResponse20044");
        }
        
        /// <summary>
        /// Test GetStatisticsMonthly
        /// </summary>
        [Test]
        public void GetStatisticsMonthlyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiToken = null;
            //var response = instance.GetStatisticsMonthly(apiToken);
            //Assert.IsInstanceOf(typeof(InlineResponse20044), response, "response is InlineResponse20044");
        }
        
        /// <summary>
        /// Test ListAnnouncementGroups
        /// </summary>
        [Test]
        public void ListAnnouncementGroupsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiToken = null;
            //string token = null;
            //int? limit = null;
            //var response = instance.ListAnnouncementGroups(apiToken, token, limit);
            //Assert.IsInstanceOf(typeof(InlineResponse20045), response, "response is InlineResponse20045");
        }
        
        /// <summary>
        /// Test ListAnnouncements
        /// </summary>
        [Test]
        public void ListAnnouncementsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiToken = null;
            //string token = null;
            //int? limit = null;
            //string order = null;
            //string status = null;
            //string announcementGroup = null;
            //var response = instance.ListAnnouncements(apiToken, token, limit, order, status, announcementGroup);
            //Assert.IsInstanceOf(typeof(InlineResponse20039), response, "response is InlineResponse20039");
        }
        
        /// <summary>
        /// Test ScheduleAnnouncement
        /// </summary>
        [Test]
        public void ScheduleAnnouncementTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiToken = null;
            //ScheduleAnnouncementData scheduleAnnouncementData = null;
            //var response = instance.ScheduleAnnouncement(apiToken, scheduleAnnouncementData);
            //Assert.IsInstanceOf(typeof(InlineResponse20040), response, "response is InlineResponse20040");
        }
        
        /// <summary>
        /// Test UpdateAnnouncementById
        /// </summary>
        [Test]
        public void UpdateAnnouncementByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string uniqueId = null;
            //string apiToken = null;
            //UpdateAnnouncementByIdData updateAnnouncementByIdData = null;
            //var response = instance.UpdateAnnouncementById(uniqueId, apiToken, updateAnnouncementByIdData);
            //Assert.IsInstanceOf(typeof(InlineResponse20041), response, "response is InlineResponse20041");
        }
        
        /// <summary>
        /// Test ViewAnnouncementById
        /// </summary>
        [Test]
        public void ViewAnnouncementByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string uniqueId = null;
            //string apiToken = null;
            //var response = instance.ViewAnnouncementById(uniqueId, apiToken);
            //Assert.IsInstanceOf(typeof(InlineResponse20039Announcements), response, "response is InlineResponse20039Announcements");
        }
        
    }

}