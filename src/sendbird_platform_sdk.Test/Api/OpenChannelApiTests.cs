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
    ///  Class for testing OpenChannelApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class OpenChannelApiTests
    {
        private OpenChannelApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new OpenChannelApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of OpenChannelApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' OpenChannelApi
            //Assert.IsInstanceOf(typeof(OpenChannelApi), instance);
        }

        
        /// <summary>
        /// Test OcBanUser
        /// </summary>
        [Test]
        public void OcBanUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string channelUrl = null;
            //string apiToken = null;
            //OcBanUserData ocBanUserData = null;
            //var response = instance.OcBanUser(channelUrl, apiToken, ocBanUserData);
            //Assert.IsInstanceOf(typeof(InlineResponse20033BannedList), response, "response is InlineResponse20033BannedList");
        }
        
        /// <summary>
        /// Test OcCancelTheRegistrationOfOperators
        /// </summary>
        [Test]
        public void OcCancelTheRegistrationOfOperatorsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string channelUrl = null;
            //List<string> operatorIds = null;
            //string apiToken = null;
            //bool? deleteAll = null;
            //instance.OcCancelTheRegistrationOfOperators(channelUrl, operatorIds, apiToken, deleteAll);
            
        }
        
        /// <summary>
        /// Test OcCreateChannel
        /// </summary>
        [Test]
        public void OcCreateChannelTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiToken = null;
            //OcCreateChannelData ocCreateChannelData = null;
            //var response = instance.OcCreateChannel(apiToken, ocCreateChannelData);
            //Assert.IsInstanceOf(typeof(SendBirdOpenChannel), response, "response is SendBirdOpenChannel");
        }
        
        /// <summary>
        /// Test OcDeleteChannelByUrl
        /// </summary>
        [Test]
        public void OcDeleteChannelByUrlTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string channelUrl = null;
            //string apiToken = null;
            //instance.OcDeleteChannelByUrl(channelUrl, apiToken);
            
        }
        
        /// <summary>
        /// Test OcFreezeChannel
        /// </summary>
        [Test]
        public void OcFreezeChannelTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string channelUrl = null;
            //string apiToken = null;
            //OcFreezeChannelData ocFreezeChannelData = null;
            //var response = instance.OcFreezeChannel(channelUrl, apiToken, ocFreezeChannelData);
            //Assert.IsInstanceOf(typeof(SendBirdOpenChannel), response, "response is SendBirdOpenChannel");
        }
        
        /// <summary>
        /// Test OcListBannedUsers
        /// </summary>
        [Test]
        public void OcListBannedUsersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string channelUrl = null;
            //string apiToken = null;
            //string token = null;
            //int? limit = null;
            //var response = instance.OcListBannedUsers(channelUrl, apiToken, token, limit);
            //Assert.IsInstanceOf(typeof(InlineResponse20033), response, "response is InlineResponse20033");
        }
        
        /// <summary>
        /// Test OcListChannels
        /// </summary>
        [Test]
        public void OcListChannelsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiToken = null;
            //string token = null;
            //int? limit = null;
            //string customTypes = null;
            //string nameContains = null;
            //string urlContains = null;
            //bool? showFrozen = null;
            //bool? showMetadata = null;
            //string customType = null;
            //var response = instance.OcListChannels(apiToken, token, limit, customTypes, nameContains, urlContains, showFrozen, showMetadata, customType);
            //Assert.IsInstanceOf(typeof(InlineResponse20030), response, "response is InlineResponse20030");
        }
        
        /// <summary>
        /// Test OcListMutedUsers
        /// </summary>
        [Test]
        public void OcListMutedUsersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string channelUrl = null;
            //string apiToken = null;
            //string token = null;
            //int? limit = null;
            //var response = instance.OcListMutedUsers(channelUrl, apiToken, token, limit);
            //Assert.IsInstanceOf(typeof(InlineResponse20031), response, "response is InlineResponse20031");
        }
        
        /// <summary>
        /// Test OcListOperators
        /// </summary>
        [Test]
        public void OcListOperatorsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string channelUrl = null;
            //string apiToken = null;
            //string token = null;
            //int? limit = null;
            //var response = instance.OcListOperators(channelUrl, apiToken, token, limit);
            //Assert.IsInstanceOf(typeof(InlineResponse20034), response, "response is InlineResponse20034");
        }
        
        /// <summary>
        /// Test OcListParticipants
        /// </summary>
        [Test]
        public void OcListParticipantsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string channelUrl = null;
            //string apiToken = null;
            //string token = null;
            //int? limit = null;
            //var response = instance.OcListParticipants(channelUrl, apiToken, token, limit);
            //Assert.IsInstanceOf(typeof(InlineResponse20032), response, "response is InlineResponse20032");
        }
        
        /// <summary>
        /// Test OcMuteUser
        /// </summary>
        [Test]
        public void OcMuteUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string channelUrl = null;
            //string apiToken = null;
            //OcMuteUserData ocMuteUserData = null;
            //var response = instance.OcMuteUser(channelUrl, apiToken, ocMuteUserData);
            //Assert.IsInstanceOf(typeof(SendBirdOpenChannel), response, "response is SendBirdOpenChannel");
        }
        
        /// <summary>
        /// Test OcRegisterOperators
        /// </summary>
        [Test]
        public void OcRegisterOperatorsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string channelUrl = null;
            //string apiToken = null;
            //OcRegisterOperatorsData ocRegisterOperatorsData = null;
            //instance.OcRegisterOperators(channelUrl, apiToken, ocRegisterOperatorsData);
            
        }
        
        /// <summary>
        /// Test OcUnbanUserById
        /// </summary>
        [Test]
        public void OcUnbanUserByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string channelUrl = null;
            //string bannedUserId = null;
            //string apiToken = null;
            //instance.OcUnbanUserById(channelUrl, bannedUserId, apiToken);
            
        }
        
        /// <summary>
        /// Test OcUnmuteUserById
        /// </summary>
        [Test]
        public void OcUnmuteUserByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string channelUrl = null;
            //string mutedUserId = null;
            //string apiToken = null;
            //instance.OcUnmuteUserById(channelUrl, mutedUserId, apiToken);
            
        }
        
        /// <summary>
        /// Test OcUpdateBanById
        /// </summary>
        [Test]
        public void OcUpdateBanByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string channelUrl = null;
            //string bannedUserId = null;
            //string apiToken = null;
            //OcUpdateBanByIdData ocUpdateBanByIdData = null;
            //var response = instance.OcUpdateBanById(channelUrl, bannedUserId, apiToken, ocUpdateBanByIdData);
            //Assert.IsInstanceOf(typeof(SendBirdUser), response, "response is SendBirdUser");
        }
        
        /// <summary>
        /// Test OcUpdateChannelByUrl
        /// </summary>
        [Test]
        public void OcUpdateChannelByUrlTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string channelUrl = null;
            //string apiToken = null;
            //OcUpdateChannelByUrlData ocUpdateChannelByUrlData = null;
            //var response = instance.OcUpdateChannelByUrl(channelUrl, apiToken, ocUpdateChannelByUrlData);
            //Assert.IsInstanceOf(typeof(SendBirdOpenChannel), response, "response is SendBirdOpenChannel");
        }
        
        /// <summary>
        /// Test OcViewBanById
        /// </summary>
        [Test]
        public void OcViewBanByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string channelUrl = null;
            //string bannedUserId = null;
            //string apiToken = null;
            //var response = instance.OcViewBanById(channelUrl, bannedUserId, apiToken);
            //Assert.IsInstanceOf(typeof(SendBirdUser), response, "response is SendBirdUser");
        }
        
        /// <summary>
        /// Test OcViewChannelByUrl
        /// </summary>
        [Test]
        public void OcViewChannelByUrlTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string channelUrl = null;
            //string apiToken = null;
            //var response = instance.OcViewChannelByUrl(channelUrl, apiToken);
            //Assert.IsInstanceOf(typeof(SendBirdOpenChannel), response, "response is SendBirdOpenChannel");
        }
        
        /// <summary>
        /// Test OcViewMuteById
        /// </summary>
        [Test]
        public void OcViewMuteByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string channelUrl = null;
            //string mutedUserId = null;
            //string apiToken = null;
            //var response = instance.OcViewMuteById(channelUrl, mutedUserId, apiToken);
            //Assert.IsInstanceOf(typeof(InlineResponse20035), response, "response is InlineResponse20035");
        }
        
    }

}