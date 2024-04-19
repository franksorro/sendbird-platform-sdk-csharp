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
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = sendbird_platform_sdk.Client.OpenAPIDateConverter;

namespace sendbird_platform_sdk.Model
{
    /// <summary>
    /// GcHideOrArchiveChannelData
    /// </summary>
    [DataContract]
    public partial class GcHideOrArchiveChannelData :  IEquatable<GcHideOrArchiveChannelData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GcHideOrArchiveChannelData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GcHideOrArchiveChannelData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GcHideOrArchiveChannelData" /> class.
        /// </summary>
        /// <param name="channelUrl">Specifies the URL of the channel to hide or archive. (required).</param>
        /// <param name="userId">Specifies the unique ID of the user whose channel will be hidden or archived from the list. This property is required when should_hide_all is set to false, which is the default value. However, when should_hide_all is set to true, this property isn&#39;t effective. (required).</param>
        /// <param name="allowAutoUnhide">Determines the state and operating behavior of the channel in a channel list. If set to true, the channel is hidden from a user&#39;s channel list but it will reappear when there is a new message. If set to false, the channel is hidden from a user&#39;s channel list and it will remain hidden unless the value of the property changes to true through [unarchiving](#2-unhide-or-unarchive-a-channel). (Default: true)&lt;br /&gt;&lt;br /&gt; When a user who has hidden the channel sends a message in that channel through the [Platform API](/docs/chat/v3/platform-api/guides/messages#2-send-a-message), the &#x60;allow_auto_unhide&#x60; property is changed to true, making the channel reappear in the channel list. (required).</param>
        /// <param name="shouldHideAll">Determines whether to make the specified channel disappear from the channel list of all channel members. When this is set to true, the user_id property isn&#39;t effective and doesn&#39;t need to be specified in the request. (Default: false) (required).</param>
        /// <param name="hidePreviousMessages">When the channel gets appeared back in either the list of the user in the user_id property or the lists of all channel members (should_hide_all &#x3D; true), determines whether to conceal the messages sent and received before hiding or archiving the channel. (Default: false)&lt;br /&gt;&lt;br /&gt; This property is effective only when the value of the [global application settings resource](/docs/chat/v3/platform-api/guides/global-application-settings#-3-resource-representation)&#39;s display_past_message property is false. (required).</param>
        public GcHideOrArchiveChannelData(string channelUrl = default, string userId = default, bool allowAutoUnhide = default(bool), bool shouldHideAll = default(bool), bool hidePreviousMessages = default(bool))
        {
            // to ensure "channelUrl" is required (not null)
            if (channelUrl == null)
            {
                throw new InvalidDataException("channelUrl is a required property for GcHideOrArchiveChannelData and cannot be null");
            }
            else
            {
                this.ChannelUrl = channelUrl;
            }

            // to ensure "userId" is required (not null)
            if (userId == null)
            {
                throw new InvalidDataException("userId is a required property for GcHideOrArchiveChannelData and cannot be null");
            }
            else
            {
                this.UserId = userId;
            }

            // to ensure "allowAutoUnhide" is required (not null)
            if (allowAutoUnhide == null)
            {
                throw new InvalidDataException("allowAutoUnhide is a required property for GcHideOrArchiveChannelData and cannot be null");
            }
            else
            {
                this.AllowAutoUnhide = allowAutoUnhide;
            }

            // to ensure "shouldHideAll" is required (not null)
            if (shouldHideAll == null)
            {
                throw new InvalidDataException("shouldHideAll is a required property for GcHideOrArchiveChannelData and cannot be null");
            }
            else
            {
                this.ShouldHideAll = shouldHideAll;
            }

            // to ensure "hidePreviousMessages" is required (not null)
            if (hidePreviousMessages == null)
            {
                throw new InvalidDataException("hidePreviousMessages is a required property for GcHideOrArchiveChannelData and cannot be null");
            }
            else
            {
                this.HidePreviousMessages = hidePreviousMessages;
            }

        }

        /// <summary>
        /// Specifies the URL of the channel to hide or archive.
        /// </summary>
        /// <value>Specifies the URL of the channel to hide or archive.</value>
        [DataMember(Name="channel_url", EmitDefaultValue=true)]
        public string ChannelUrl { get; set; }

        /// <summary>
        /// Specifies the unique ID of the user whose channel will be hidden or archived from the list. This property is required when should_hide_all is set to false, which is the default value. However, when should_hide_all is set to true, this property isn&#39;t effective.
        /// </summary>
        /// <value>Specifies the unique ID of the user whose channel will be hidden or archived from the list. This property is required when should_hide_all is set to false, which is the default value. However, when should_hide_all is set to true, this property isn&#39;t effective.</value>
        [DataMember(Name="user_id", EmitDefaultValue=true)]
        public string UserId { get; set; }

        /// <summary>
        /// Determines the state and operating behavior of the channel in a channel list. If set to true, the channel is hidden from a user&#39;s channel list but it will reappear when there is a new message. If set to false, the channel is hidden from a user&#39;s channel list and it will remain hidden unless the value of the property changes to true through [unarchiving](#2-unhide-or-unarchive-a-channel). (Default: true)&lt;br /&gt;&lt;br /&gt; When a user who has hidden the channel sends a message in that channel through the [Platform API](/docs/chat/v3/platform-api/guides/messages#2-send-a-message), the &#x60;allow_auto_unhide&#x60; property is changed to true, making the channel reappear in the channel list.
        /// </summary>
        /// <value>Determines the state and operating behavior of the channel in a channel list. If set to true, the channel is hidden from a user&#39;s channel list but it will reappear when there is a new message. If set to false, the channel is hidden from a user&#39;s channel list and it will remain hidden unless the value of the property changes to true through [unarchiving](#2-unhide-or-unarchive-a-channel). (Default: true)&lt;br /&gt;&lt;br /&gt; When a user who has hidden the channel sends a message in that channel through the [Platform API](/docs/chat/v3/platform-api/guides/messages#2-send-a-message), the &#x60;allow_auto_unhide&#x60; property is changed to true, making the channel reappear in the channel list.</value>
        [DataMember(Name="allow_auto_unhide", EmitDefaultValue=true)]
        public bool AllowAutoUnhide { get; set; }

        /// <summary>
        /// Determines whether to make the specified channel disappear from the channel list of all channel members. When this is set to true, the user_id property isn&#39;t effective and doesn&#39;t need to be specified in the request. (Default: false)
        /// </summary>
        /// <value>Determines whether to make the specified channel disappear from the channel list of all channel members. When this is set to true, the user_id property isn&#39;t effective and doesn&#39;t need to be specified in the request. (Default: false)</value>
        [DataMember(Name="should_hide_all", EmitDefaultValue=true)]
        public bool ShouldHideAll { get; set; }

        /// <summary>
        /// When the channel gets appeared back in either the list of the user in the user_id property or the lists of all channel members (should_hide_all &#x3D; true), determines whether to conceal the messages sent and received before hiding or archiving the channel. (Default: false)&lt;br /&gt;&lt;br /&gt; This property is effective only when the value of the [global application settings resource](/docs/chat/v3/platform-api/guides/global-application-settings#-3-resource-representation)&#39;s display_past_message property is false.
        /// </summary>
        /// <value>When the channel gets appeared back in either the list of the user in the user_id property or the lists of all channel members (should_hide_all &#x3D; true), determines whether to conceal the messages sent and received before hiding or archiving the channel. (Default: false)&lt;br /&gt;&lt;br /&gt; This property is effective only when the value of the [global application settings resource](/docs/chat/v3/platform-api/guides/global-application-settings#-3-resource-representation)&#39;s display_past_message property is false.</value>
        [DataMember(Name="hide_previous_messages", EmitDefaultValue=true)]
        public bool HidePreviousMessages { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GcHideOrArchiveChannelData {\n");
            sb.Append("  ChannelUrl: ").Append(ChannelUrl).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  AllowAutoUnhide: ").Append(AllowAutoUnhide).Append("\n");
            sb.Append("  ShouldHideAll: ").Append(ShouldHideAll).Append("\n");
            sb.Append("  HidePreviousMessages: ").Append(HidePreviousMessages).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as GcHideOrArchiveChannelData);
        }

        /// <summary>
        /// Returns true if GcHideOrArchiveChannelData instances are equal
        /// </summary>
        /// <param name="input">Instance of GcHideOrArchiveChannelData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GcHideOrArchiveChannelData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ChannelUrl == input.ChannelUrl ||
                    (this.ChannelUrl != null &&
                    this.ChannelUrl.Equals(input.ChannelUrl))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.AllowAutoUnhide == input.AllowAutoUnhide ||
                    (this.AllowAutoUnhide != null &&
                    this.AllowAutoUnhide.Equals(input.AllowAutoUnhide))
                ) && 
                (
                    this.ShouldHideAll == input.ShouldHideAll ||
                    (this.ShouldHideAll != null &&
                    this.ShouldHideAll.Equals(input.ShouldHideAll))
                ) && 
                (
                    this.HidePreviousMessages == input.HidePreviousMessages ||
                    (this.HidePreviousMessages != null &&
                    this.HidePreviousMessages.Equals(input.HidePreviousMessages))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ChannelUrl != null)
                    hashCode = hashCode * 59 + this.ChannelUrl.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.AllowAutoUnhide != null)
                    hashCode = hashCode * 59 + this.AllowAutoUnhide.GetHashCode();
                if (this.ShouldHideAll != null)
                    hashCode = hashCode * 59 + this.ShouldHideAll.GetHashCode();
                if (this.HidePreviousMessages != null)
                    hashCode = hashCode * 59 + this.HidePreviousMessages.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
