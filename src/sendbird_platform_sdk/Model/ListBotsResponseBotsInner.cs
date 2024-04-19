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
    /// ListBotsResponseBotsInner
    /// </summary>
    [DataContract]
    public partial class ListBotsResponseBotsInner :  IEquatable<ListBotsResponseBotsInner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListBotsResponseBotsInner" /> class.
        /// </summary>
        /// <param name="bot">bot.</param>
        /// <param name="botCallbackUrl">botCallbackUrl.</param>
        /// <param name="enableMarkAsRead">enableMarkAsRead.</param>
        /// <param name="isPrivacyMode">isPrivacyMode.</param>
        /// <param name="showMember">showMember.</param>
        /// <param name="channelInvitationPreference">channelInvitationPreference.</param>
        public ListBotsResponseBotsInner(CreateBotResponseBot bot = default(CreateBotResponseBot), string botCallbackUrl = default, bool enableMarkAsRead = default(bool), bool isPrivacyMode = default(bool), bool showMember = default(bool), decimal channelInvitationPreference = default(decimal))
        {
            this.Bot = bot;
            this.BotCallbackUrl = botCallbackUrl;
            this.EnableMarkAsRead = enableMarkAsRead;
            this.IsPrivacyMode = isPrivacyMode;
            this.ShowMember = showMember;
            this.ChannelInvitationPreference = channelInvitationPreference;
        }

        /// <summary>
        /// Gets or Sets Bot
        /// </summary>
        [DataMember(Name="bot", EmitDefaultValue=false)]
        public CreateBotResponseBot Bot { get; set; }

        /// <summary>
        /// Gets or Sets BotCallbackUrl
        /// </summary>
        [DataMember(Name="bot_callback_url", EmitDefaultValue=false)]
        public string BotCallbackUrl { get; set; }

        /// <summary>
        /// Gets or Sets EnableMarkAsRead
        /// </summary>
        [DataMember(Name="enable_mark_as_read", EmitDefaultValue=false)]
        public bool EnableMarkAsRead { get; set; }

        /// <summary>
        /// Gets or Sets IsPrivacyMode
        /// </summary>
        [DataMember(Name="is_privacy_mode", EmitDefaultValue=false)]
        public bool IsPrivacyMode { get; set; }

        /// <summary>
        /// Gets or Sets ShowMember
        /// </summary>
        [DataMember(Name="show_member", EmitDefaultValue=false)]
        public bool ShowMember { get; set; }

        /// <summary>
        /// Gets or Sets ChannelInvitationPreference
        /// </summary>
        [DataMember(Name="channel_invitation_preference", EmitDefaultValue=false)]
        public decimal ChannelInvitationPreference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListBotsResponseBotsInner {\n");
            sb.Append("  Bot: ").Append(Bot).Append("\n");
            sb.Append("  BotCallbackUrl: ").Append(BotCallbackUrl).Append("\n");
            sb.Append("  EnableMarkAsRead: ").Append(EnableMarkAsRead).Append("\n");
            sb.Append("  IsPrivacyMode: ").Append(IsPrivacyMode).Append("\n");
            sb.Append("  ShowMember: ").Append(ShowMember).Append("\n");
            sb.Append("  ChannelInvitationPreference: ").Append(ChannelInvitationPreference).Append("\n");
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
            return this.Equals(input as ListBotsResponseBotsInner);
        }

        /// <summary>
        /// Returns true if ListBotsResponseBotsInner instances are equal
        /// </summary>
        /// <param name="input">Instance of ListBotsResponseBotsInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListBotsResponseBotsInner input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Bot == input.Bot ||
                    (this.Bot != null &&
                    this.Bot.Equals(input.Bot))
                ) && 
                (
                    this.BotCallbackUrl == input.BotCallbackUrl ||
                    (this.BotCallbackUrl != null &&
                    this.BotCallbackUrl.Equals(input.BotCallbackUrl))
                ) && 
                (
                    this.EnableMarkAsRead == input.EnableMarkAsRead ||
                    (this.EnableMarkAsRead != null &&
                    this.EnableMarkAsRead.Equals(input.EnableMarkAsRead))
                ) && 
                (
                    this.IsPrivacyMode == input.IsPrivacyMode ||
                    (this.IsPrivacyMode != null &&
                    this.IsPrivacyMode.Equals(input.IsPrivacyMode))
                ) && 
                (
                    this.ShowMember == input.ShowMember ||
                    (this.ShowMember != null &&
                    this.ShowMember.Equals(input.ShowMember))
                ) && 
                (
                    this.ChannelInvitationPreference == input.ChannelInvitationPreference ||
                    (this.ChannelInvitationPreference != null &&
                    this.ChannelInvitationPreference.Equals(input.ChannelInvitationPreference))
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
                if (this.Bot != null)
                    hashCode = hashCode * 59 + this.Bot.GetHashCode();
                if (this.BotCallbackUrl != null)
                    hashCode = hashCode * 59 + this.BotCallbackUrl.GetHashCode();
                if (this.EnableMarkAsRead != null)
                    hashCode = hashCode * 59 + this.EnableMarkAsRead.GetHashCode();
                if (this.IsPrivacyMode != null)
                    hashCode = hashCode * 59 + this.IsPrivacyMode.GetHashCode();
                if (this.ShowMember != null)
                    hashCode = hashCode * 59 + this.ShowMember.GetHashCode();
                if (this.ChannelInvitationPreference != null)
                    hashCode = hashCode * 59 + this.ChannelInvitationPreference.GetHashCode();
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
