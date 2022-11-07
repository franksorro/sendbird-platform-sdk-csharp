/*
 * Sendbird Platform SDK
 *
 * Sendbird Platform API SDK  https://sendbird.com/docs/chat/v3/platform-api/getting-started/prepare-to-use-api
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: support@sendbird.com
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
    ///  Class for testing UserApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class UserApiTests
    {
        private UserApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new UserApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of UserApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' UserApi
            //Assert.IsInstanceOf(typeof(UserApi), instance);
        }

        
        /// <summary>
        /// Test AddRegistrationOrDeviceToken
        /// </summary>
        [Test]
        public void AddRegistrationOrDeviceTokenTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiToken = null;
            //string userId = null;
            //string tokenType = null;
            //AddRegistrationOrDeviceTokenData addRegistrationOrDeviceTokenData = null;
            //var response = instance.AddRegistrationOrDeviceToken(apiToken, userId, tokenType, addRegistrationOrDeviceTokenData);
            //Assert.IsInstanceOf(typeof(AddRegistrationOrDeviceTokenResponse), response, "response is AddRegistrationOrDeviceTokenResponse");
        }
        
        /// <summary>
        /// Test ChoosePushNotificationContentTemplate
        /// </summary>
        [Test]
        public void ChoosePushNotificationContentTemplateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiToken = null;
            //string userId = null;
            //Object body = null;
            //var response = instance.ChoosePushNotificationContentTemplate(apiToken, userId, body);
            //Assert.IsInstanceOf(typeof(ChoosePushNotificationContentTemplateResponse), response, "response is ChoosePushNotificationContentTemplateResponse");
        }
        
        /// <summary>
        /// Test CreateUser
        /// </summary>
        [Test]
        public void CreateUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiToken = null;
            //CreateUserData createUserData = null;
            //var response = instance.CreateUser(apiToken, createUserData);
            //Assert.IsInstanceOf(typeof(SendBirdUser), response, "response is SendBirdUser");
        }
        
        /// <summary>
        /// Test CreateUserToken
        /// </summary>
        [Test]
        public void CreateUserTokenTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiToken = null;
            //string userId = null;
            //CreateUserTokenData createUserTokenData = null;
            //var response = instance.CreateUserToken(apiToken, userId, createUserTokenData);
            //Assert.IsInstanceOf(typeof(CreateUserTokenResponse), response, "response is CreateUserTokenResponse");
        }
        
        /// <summary>
        /// Test DeleteUserById
        /// </summary>
        [Test]
        public void DeleteUserByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiToken = null;
            //string userId = null;
            //var response = instance.DeleteUserById(apiToken, userId);
            //Assert.IsInstanceOf(typeof(Object), response, "response is Object");
        }
        
        /// <summary>
        /// Test LeaveMyGroupChannels
        /// </summary>
        [Test]
        public void LeaveMyGroupChannelsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiToken = null;
            //string userId = null;
            //LeaveMyGroupChannelsData leaveMyGroupChannelsData = null;
            //var response = instance.LeaveMyGroupChannels(apiToken, userId, leaveMyGroupChannelsData);
            //Assert.IsInstanceOf(typeof(Object), response, "response is Object");
        }
        
        /// <summary>
        /// Test ListMyGroupChannels
        /// </summary>
        [Test]
        public void ListMyGroupChannelsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiToken = null;
            //string userId = null;
            //string token = null;
            //int? limit = null;
            //string distinctMode = null;
            //string publicMode = null;
            //string superMode = null;
            //string hiddenMode = null;
            //string memberStateFilter = null;
            //string unreadFilter = null;
            //int? createdAfter = null;
            //int? createdBefore = null;
            //bool? showEmpty = null;
            //bool? showFrozen = null;
            //bool? showMember = null;
            //bool? showDeliveryReceipt = null;
            //bool? showReadReceipt = null;
            //string order = null;
            //string metadataOrderKey = null;
            //string customTypes = null;
            //string customTypeStartswith = null;
            //string channelUrls = null;
            //string name = null;
            //string nameContains = null;
            //string nameStartswith = null;
            //string membersExactlyIn = null;
            //string membersIncludeIn = null;
            //string queryType = null;
            //string membersNickname = null;
            //string membersNicknameContains = null;
            //string searchQuery = null;
            //string searchFields = null;
            //string metadataKey = null;
            //string metadataValues = null;
            //string metadataValueStartswith = null;
            //string metacounterKey = null;
            //string metacounterValues = null;
            //string metacounterValueGt = null;
            //string metacounterValueGte = null;
            //string metacounterValueLt = null;
            //string metacounterValueLte = null;
            //string customType = null;
            //var response = instance.ListMyGroupChannels(apiToken, userId, token, limit, distinctMode, publicMode, superMode, hiddenMode, memberStateFilter, unreadFilter, createdAfter, createdBefore, showEmpty, showFrozen, showMember, showDeliveryReceipt, showReadReceipt, order, metadataOrderKey, customTypes, customTypeStartswith, channelUrls, name, nameContains, nameStartswith, membersExactlyIn, membersIncludeIn, queryType, membersNickname, membersNicknameContains, searchQuery, searchFields, metadataKey, metadataValues, metadataValueStartswith, metacounterKey, metacounterValues, metacounterValueGt, metacounterValueGte, metacounterValueLt, metacounterValueLte, customType);
            //Assert.IsInstanceOf(typeof(ListMyGroupChannelsResponse), response, "response is ListMyGroupChannelsResponse");
        }
        
        /// <summary>
        /// Test ListRegistrationOrDeviceTokens
        /// </summary>
        [Test]
        public void ListRegistrationOrDeviceTokensTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiToken = null;
            //string userId = null;
            //string tokenType = null;
            //var response = instance.ListRegistrationOrDeviceTokens(apiToken, userId, tokenType);
            //Assert.IsInstanceOf(typeof(ListRegistrationOrDeviceTokensResponse), response, "response is ListRegistrationOrDeviceTokensResponse");
        }
        
        /// <summary>
        /// Test ListUsers
        /// </summary>
        [Test]
        public void ListUsersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiToken = null;
            //string token = null;
            //int? limit = null;
            //string activeMode = null;
            //bool? showBot = null;
            //string userIds = null;
            //string nickname = null;
            //string nicknameStartswith = null;
            //string metadatakey = null;
            //string metadatavaluesIn = null;
            //var response = instance.ListUsers(apiToken, token, limit, activeMode, showBot, userIds, nickname, nicknameStartswith, metadatakey, metadatavaluesIn);
            //Assert.IsInstanceOf(typeof(ListUsersResponse), response, "response is ListUsersResponse");
        }
        
        /// <summary>
        /// Test MarkAllMessagesAsRead
        /// </summary>
        [Test]
        public void MarkAllMessagesAsReadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiToken = null;
            //string userId = null;
            //MarkAllMessagesAsReadData markAllMessagesAsReadData = null;
            //var response = instance.MarkAllMessagesAsRead(apiToken, userId, markAllMessagesAsReadData);
            //Assert.IsInstanceOf(typeof(Object), response, "response is Object");
        }
        
        /// <summary>
        /// Test RegisterAsOperatorToChannelsWithCustomChannelTypes
        /// </summary>
        [Test]
        public void RegisterAsOperatorToChannelsWithCustomChannelTypesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiToken = null;
            //string userId = null;
            //RegisterAsOperatorToChannelsWithCustomChannelTypesData registerAsOperatorToChannelsWithCustomChannelTypesData = null;
            //var response = instance.RegisterAsOperatorToChannelsWithCustomChannelTypes(apiToken, userId, registerAsOperatorToChannelsWithCustomChannelTypesData);
            //Assert.IsInstanceOf(typeof(Object), response, "response is Object");
        }
        
        /// <summary>
        /// Test RemoveRegistrationOrDeviceToken
        /// </summary>
        [Test]
        public void RemoveRegistrationOrDeviceTokenTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiToken = null;
            //string userId = null;
            //var response = instance.RemoveRegistrationOrDeviceToken(apiToken, userId);
            //Assert.IsInstanceOf(typeof(RemoveRegistrationOrDeviceTokenResponse), response, "response is RemoveRegistrationOrDeviceTokenResponse");
        }
        
        /// <summary>
        /// Test RemoveRegistrationOrDeviceTokenByToken
        /// </summary>
        [Test]
        public void RemoveRegistrationOrDeviceTokenByTokenTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiToken = null;
            //string userId = null;
            //string tokenType = null;
            //string token = null;
            //var response = instance.RemoveRegistrationOrDeviceTokenByToken(apiToken, userId, tokenType, token);
            //Assert.IsInstanceOf(typeof(RemoveRegistrationOrDeviceTokenByTokenResponse), response, "response is RemoveRegistrationOrDeviceTokenByTokenResponse");
        }
        
        /// <summary>
        /// Test RemoveRegistrationOrDeviceTokenFromOwnerByToken
        /// </summary>
        [Test]
        public void RemoveRegistrationOrDeviceTokenFromOwnerByTokenTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiToken = null;
            //string tokenType = null;
            //string token = null;
            //var response = instance.RemoveRegistrationOrDeviceTokenFromOwnerByToken(apiToken, tokenType, token);
            //Assert.IsInstanceOf(typeof(RemoveRegistrationOrDeviceTokenFromOwnerByTokenResponse), response, "response is RemoveRegistrationOrDeviceTokenFromOwnerByTokenResponse");
        }
        
        /// <summary>
        /// Test ResetPushPreferences
        /// </summary>
        [Test]
        public void ResetPushPreferencesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiToken = null;
            //string userId = null;
            //var response = instance.ResetPushPreferences(apiToken, userId);
            //Assert.IsInstanceOf(typeof(ResetPushPreferencesResponse), response, "response is ResetPushPreferencesResponse");
        }
        
        /// <summary>
        /// Test UpdateChannelInvitationPreference
        /// </summary>
        [Test]
        public void UpdateChannelInvitationPreferenceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiToken = null;
            //string userId = null;
            //UpdateChannelInvitationPreferenceData updateChannelInvitationPreferenceData = null;
            //var response = instance.UpdateChannelInvitationPreference(apiToken, userId, updateChannelInvitationPreferenceData);
            //Assert.IsInstanceOf(typeof(UpdateChannelInvitationPreferenceResponse), response, "response is UpdateChannelInvitationPreferenceResponse");
        }
        
        /// <summary>
        /// Test UpdateCountPreferenceOfChannelByUrl
        /// </summary>
        [Test]
        public void UpdateCountPreferenceOfChannelByUrlTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiToken = null;
            //string userId = null;
            //string channelUrl = null;
            //UpdateCountPreferenceOfChannelByUrlData updateCountPreferenceOfChannelByUrlData = null;
            //var response = instance.UpdateCountPreferenceOfChannelByUrl(apiToken, userId, channelUrl, updateCountPreferenceOfChannelByUrlData);
            //Assert.IsInstanceOf(typeof(UpdateCountPreferenceOfChannelByUrlResponse), response, "response is UpdateCountPreferenceOfChannelByUrlResponse");
        }
        
        /// <summary>
        /// Test UpdatePushPreferences
        /// </summary>
        [Test]
        public void UpdatePushPreferencesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiToken = null;
            //string userId = null;
            //UpdatePushPreferencesData updatePushPreferencesData = null;
            //var response = instance.UpdatePushPreferences(apiToken, userId, updatePushPreferencesData);
            //Assert.IsInstanceOf(typeof(UpdatePushPreferencesResponse), response, "response is UpdatePushPreferencesResponse");
        }
        
        /// <summary>
        /// Test UpdatePushPreferencesForChannelByUrl
        /// </summary>
        [Test]
        public void UpdatePushPreferencesForChannelByUrlTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiToken = null;
            //string userId = null;
            //string channelUrl = null;
            //UpdatePushPreferencesForChannelByUrlData updatePushPreferencesForChannelByUrlData = null;
            //var response = instance.UpdatePushPreferencesForChannelByUrl(apiToken, userId, channelUrl, updatePushPreferencesForChannelByUrlData);
            //Assert.IsInstanceOf(typeof(UpdatePushPreferencesForChannelByUrlResponse), response, "response is UpdatePushPreferencesForChannelByUrlResponse");
        }
        
        /// <summary>
        /// Test UpdateUserById
        /// </summary>
        [Test]
        public void UpdateUserByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiToken = null;
            //string userId = null;
            //UpdateUserByIdData updateUserByIdData = null;
            //var response = instance.UpdateUserById(apiToken, userId, updateUserByIdData);
            //Assert.IsInstanceOf(typeof(SendBirdUser), response, "response is SendBirdUser");
        }
        
        /// <summary>
        /// Test ViewChannelInvitationPreference
        /// </summary>
        [Test]
        public void ViewChannelInvitationPreferenceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiToken = null;
            //string userId = null;
            //var response = instance.ViewChannelInvitationPreference(apiToken, userId);
            //Assert.IsInstanceOf(typeof(ViewChannelInvitationPreferenceResponse), response, "response is ViewChannelInvitationPreferenceResponse");
        }
        
        /// <summary>
        /// Test ViewCountPreferenceOfChannelByUrl
        /// </summary>
        [Test]
        public void ViewCountPreferenceOfChannelByUrlTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiToken = null;
            //string userId = null;
            //string channelUrl = null;
            //var response = instance.ViewCountPreferenceOfChannelByUrl(apiToken, userId, channelUrl);
            //Assert.IsInstanceOf(typeof(ViewCountPreferenceOfChannelByUrlResponse), response, "response is ViewCountPreferenceOfChannelByUrlResponse");
        }
        
        /// <summary>
        /// Test ViewNumberOfChannelsByJoinStatus
        /// </summary>
        [Test]
        public void ViewNumberOfChannelsByJoinStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiToken = null;
            //string userId = null;
            //string state = null;
            //var response = instance.ViewNumberOfChannelsByJoinStatus(apiToken, userId, state);
            //Assert.IsInstanceOf(typeof(ViewNumberOfChannelsByJoinStatusResponse), response, "response is ViewNumberOfChannelsByJoinStatusResponse");
        }
        
        /// <summary>
        /// Test ViewNumberOfChannelsWithUnreadMessages
        /// </summary>
        [Test]
        public void ViewNumberOfChannelsWithUnreadMessagesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiToken = null;
            //string userId = null;
            //List<string> customTypes = null;
            //string superMode = null;
            //var response = instance.ViewNumberOfChannelsWithUnreadMessages(apiToken, userId, customTypes, superMode);
            //Assert.IsInstanceOf(typeof(ViewNumberOfChannelsWithUnreadMessagesResponse), response, "response is ViewNumberOfChannelsWithUnreadMessagesResponse");
        }
        
        /// <summary>
        /// Test ViewNumberOfUnreadItems
        /// </summary>
        [Test]
        public void ViewNumberOfUnreadItemsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiToken = null;
            //string userId = null;
            //string customType = null;
            //string itemKeys = null;
            //var response = instance.ViewNumberOfUnreadItems(apiToken, userId, customType, itemKeys);
            //Assert.IsInstanceOf(typeof(ViewNumberOfUnreadItemsResponse), response, "response is ViewNumberOfUnreadItemsResponse");
        }
        
        /// <summary>
        /// Test ViewNumberOfUnreadMessages
        /// </summary>
        [Test]
        public void ViewNumberOfUnreadMessagesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiToken = null;
            //string userId = null;
            //string customTypes = null;
            //string superMode = null;
            //var response = instance.ViewNumberOfUnreadMessages(apiToken, userId, customTypes, superMode);
            //Assert.IsInstanceOf(typeof(ViewNumberOfUnreadMessagesResponse), response, "response is ViewNumberOfUnreadMessagesResponse");
        }
        
        /// <summary>
        /// Test ViewPushPreferences
        /// </summary>
        [Test]
        public void ViewPushPreferencesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiToken = null;
            //string userId = null;
            //var response = instance.ViewPushPreferences(apiToken, userId);
            //Assert.IsInstanceOf(typeof(ViewPushPreferencesResponse), response, "response is ViewPushPreferencesResponse");
        }
        
        /// <summary>
        /// Test ViewPushPreferencesForChannelByUrl
        /// </summary>
        [Test]
        public void ViewPushPreferencesForChannelByUrlTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiToken = null;
            //string userId = null;
            //string channelUrl = null;
            //var response = instance.ViewPushPreferencesForChannelByUrl(apiToken, userId, channelUrl);
            //Assert.IsInstanceOf(typeof(ViewPushPreferencesForChannelByUrlResponse), response, "response is ViewPushPreferencesForChannelByUrlResponse");
        }
        
        /// <summary>
        /// Test ViewUserById
        /// </summary>
        [Test]
        public void ViewUserByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiToken = null;
            //string userId = null;
            //bool? includeUnreadCount = null;
            //string customTypes = null;
            //string superMode = null;
            //var response = instance.ViewUserById(apiToken, userId, includeUnreadCount, customTypes, superMode);
            //Assert.IsInstanceOf(typeof(SendBirdUser), response, "response is SendBirdUser");
        }
        
        /// <summary>
        /// Test ViewWhoOwnsRegistrationOrDeviceTokenByToken
        /// </summary>
        [Test]
        public void ViewWhoOwnsRegistrationOrDeviceTokenByTokenTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiToken = null;
            //string tokenType = null;
            //string token = null;
            //var response = instance.ViewWhoOwnsRegistrationOrDeviceTokenByToken(apiToken, tokenType, token);
            //Assert.IsInstanceOf(typeof(List<ViewWhoOwnsRegistrationOrDeviceTokenByTokenResponseInner>), response, "response is List<ViewWhoOwnsRegistrationOrDeviceTokenByTokenResponseInner>");
        }
        
    }

}
