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
    /// SendBirdUserMessageParams
    /// </summary>
    [DataContract]
    public partial class SendBirdUserMessageParams :  IEquatable<SendBirdUserMessageParams>, IValidatableObject
    {
        /// <summary>
        /// Defines MentionType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MentionTypeEnum
        {
            /// <summary>
            /// Enum Channel for value: channel
            /// </summary>
            [EnumMember(Value = "channel")]
            Channel = 1,

            /// <summary>
            /// Enum Users for value: users
            /// </summary>
            [EnumMember(Value = "users")]
            Users = 2

        }

        /// <summary>
        /// Gets or Sets MentionType
        /// </summary>
        [DataMember(Name="mention_type", EmitDefaultValue=false)]
        public MentionTypeEnum? MentionType { get; set; }
        /// <summary>
        /// Defines PushNotificationDeliveryOption
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PushNotificationDeliveryOptionEnum
        {
            /// <summary>
            /// Enum Default for value: default
            /// </summary>
            [EnumMember(Value = "default")]
            Default = 1,

            /// <summary>
            /// Enum Suppress for value: suppress
            /// </summary>
            [EnumMember(Value = "suppress")]
            Suppress = 2

        }

        /// <summary>
        /// Gets or Sets PushNotificationDeliveryOption
        /// </summary>
        [DataMember(Name="push_notification_delivery_option", EmitDefaultValue=false)]
        public PushNotificationDeliveryOptionEnum? PushNotificationDeliveryOption { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SendBirdUserMessageParams" /> class.
        /// </summary>
        /// <param name="appleCriticalAlertOptions">appleCriticalAlertOptions.</param>
        /// <param name="customType">customType.</param>
        /// <param name="data">data.</param>
        /// <param name="isReplyToChannel">isReplyToChannel.</param>
        /// <param name="mentionType">mentionType.</param>
        /// <param name="mentionedUserIds">mentionedUserIds.</param>
        /// <param name="mentionedUsers">mentionedUsers.</param>
        /// <param name="message">message.</param>
        /// <param name="metaArrayKeys">metaArrayKeys.</param>
        /// <param name="metaArrays">metaArrays.</param>
        /// <param name="parentMessageId">parentMessageId.</param>
        /// <param name="pollId">pollId.</param>
        /// <param name="pushNotificationDeliveryOption">pushNotificationDeliveryOption.</param>
        /// <param name="targetLanguages">targetLanguages.</param>
        /// <param name="translationTargetLanguages">translationTargetLanguages.</param>
        public SendBirdUserMessageParams(SendBirdAppleCriticalAlertOptions appleCriticalAlertOptions = default(SendBirdAppleCriticalAlertOptions), string customType = default, string data = default, bool isReplyToChannel = default(bool), MentionTypeEnum? mentionType = default(MentionTypeEnum?), List<string> mentionedUserIds = default, List<SendBirdUser> mentionedUsers = default(List<SendBirdUser>), string message = default, List<string> metaArrayKeys = default, List<SendBirdMessageMetaArray> metaArrays = default(List<SendBirdMessageMetaArray>), decimal parentMessageId = default(decimal), decimal pollId = default(decimal), PushNotificationDeliveryOptionEnum? pushNotificationDeliveryOption = default(PushNotificationDeliveryOptionEnum?), List<string> targetLanguages = default, List<string> translationTargetLanguages = default)
        {
            this.AppleCriticalAlertOptions = appleCriticalAlertOptions;
            this.CustomType = customType;
            this.Data = data;
            this.IsReplyToChannel = isReplyToChannel;
            this.MentionType = mentionType;
            this.MentionedUserIds = mentionedUserIds;
            this.MentionedUsers = mentionedUsers;
            this.Message = message;
            this.MetaArrayKeys = metaArrayKeys;
            this.MetaArrays = metaArrays;
            this.ParentMessageId = parentMessageId;
            this.PollId = pollId;
            this.PushNotificationDeliveryOption = pushNotificationDeliveryOption;
            this.TargetLanguages = targetLanguages;
            this.TranslationTargetLanguages = translationTargetLanguages;
        }

        /// <summary>
        /// Gets or Sets AppleCriticalAlertOptions
        /// </summary>
        [DataMember(Name="apple_critical_alert_options", EmitDefaultValue=false)]
        public SendBirdAppleCriticalAlertOptions AppleCriticalAlertOptions { get; set; }

        /// <summary>
        /// Gets or Sets CustomType
        /// </summary>
        [DataMember(Name="custom_type", EmitDefaultValue=false)]
        public string CustomType { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public string Data { get; set; }

        /// <summary>
        /// Gets or Sets IsReplyToChannel
        /// </summary>
        [DataMember(Name="is_reply_to_channel", EmitDefaultValue=false)]
        public bool IsReplyToChannel { get; set; }


        /// <summary>
        /// Gets or Sets MentionedUserIds
        /// </summary>
        [DataMember(Name="mentioned_user_ids", EmitDefaultValue=false)]
        public List<string> MentionedUserIds { get; set; }

        /// <summary>
        /// Gets or Sets MentionedUsers
        /// </summary>
        [DataMember(Name="mentioned_users", EmitDefaultValue=false)]
        public List<SendBirdUser> MentionedUsers { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets MetaArrayKeys
        /// </summary>
        [DataMember(Name="meta_array_keys", EmitDefaultValue=false)]
        public List<string> MetaArrayKeys { get; set; }

        /// <summary>
        /// Gets or Sets MetaArrays
        /// </summary>
        [DataMember(Name="meta_arrays", EmitDefaultValue=false)]
        public List<SendBirdMessageMetaArray> MetaArrays { get; set; }

        /// <summary>
        /// Gets or Sets ParentMessageId
        /// </summary>
        [DataMember(Name="parent_message_id", EmitDefaultValue=false)]
        public decimal ParentMessageId { get; set; }

        /// <summary>
        /// Gets or Sets PollId
        /// </summary>
        [DataMember(Name="poll_id", EmitDefaultValue=false)]
        public decimal PollId { get; set; }


        /// <summary>
        /// Gets or Sets TargetLanguages
        /// </summary>
        [DataMember(Name="target_languages", EmitDefaultValue=false)]
        public List<string> TargetLanguages { get; set; }

        /// <summary>
        /// Gets or Sets TranslationTargetLanguages
        /// </summary>
        [DataMember(Name="translation_target_languages", EmitDefaultValue=false)]
        public List<string> TranslationTargetLanguages { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SendBirdUserMessageParams {\n");
            sb.Append("  AppleCriticalAlertOptions: ").Append(AppleCriticalAlertOptions).Append("\n");
            sb.Append("  CustomType: ").Append(CustomType).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  IsReplyToChannel: ").Append(IsReplyToChannel).Append("\n");
            sb.Append("  MentionType: ").Append(MentionType).Append("\n");
            sb.Append("  MentionedUserIds: ").Append(MentionedUserIds).Append("\n");
            sb.Append("  MentionedUsers: ").Append(MentionedUsers).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  MetaArrayKeys: ").Append(MetaArrayKeys).Append("\n");
            sb.Append("  MetaArrays: ").Append(MetaArrays).Append("\n");
            sb.Append("  ParentMessageId: ").Append(ParentMessageId).Append("\n");
            sb.Append("  PollId: ").Append(PollId).Append("\n");
            sb.Append("  PushNotificationDeliveryOption: ").Append(PushNotificationDeliveryOption).Append("\n");
            sb.Append("  TargetLanguages: ").Append(TargetLanguages).Append("\n");
            sb.Append("  TranslationTargetLanguages: ").Append(TranslationTargetLanguages).Append("\n");
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
            return this.Equals(input as SendBirdUserMessageParams);
        }

        /// <summary>
        /// Returns true if SendBirdUserMessageParams instances are equal
        /// </summary>
        /// <param name="input">Instance of SendBirdUserMessageParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SendBirdUserMessageParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AppleCriticalAlertOptions == input.AppleCriticalAlertOptions ||
                    (this.AppleCriticalAlertOptions != null &&
                    this.AppleCriticalAlertOptions.Equals(input.AppleCriticalAlertOptions))
                ) && 
                (
                    this.CustomType == input.CustomType ||
                    (this.CustomType != null &&
                    this.CustomType.Equals(input.CustomType))
                ) && 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
                ) && 
                (
                    this.IsReplyToChannel == input.IsReplyToChannel ||
                    (this.IsReplyToChannel != null &&
                    this.IsReplyToChannel.Equals(input.IsReplyToChannel))
                ) && 
                (
                    this.MentionType == input.MentionType ||
                    (this.MentionType != null &&
                    this.MentionType.Equals(input.MentionType))
                ) && 
                (
                    this.MentionedUserIds == input.MentionedUserIds ||
                    this.MentionedUserIds != null &&
                    input.MentionedUserIds != null &&
                    this.MentionedUserIds.SequenceEqual(input.MentionedUserIds)
                ) && 
                (
                    this.MentionedUsers == input.MentionedUsers ||
                    this.MentionedUsers != null &&
                    input.MentionedUsers != null &&
                    this.MentionedUsers.SequenceEqual(input.MentionedUsers)
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.MetaArrayKeys == input.MetaArrayKeys ||
                    this.MetaArrayKeys != null &&
                    input.MetaArrayKeys != null &&
                    this.MetaArrayKeys.SequenceEqual(input.MetaArrayKeys)
                ) && 
                (
                    this.MetaArrays == input.MetaArrays ||
                    this.MetaArrays != null &&
                    input.MetaArrays != null &&
                    this.MetaArrays.SequenceEqual(input.MetaArrays)
                ) && 
                (
                    this.ParentMessageId == input.ParentMessageId ||
                    (this.ParentMessageId != null &&
                    this.ParentMessageId.Equals(input.ParentMessageId))
                ) && 
                (
                    this.PollId == input.PollId ||
                    (this.PollId != null &&
                    this.PollId.Equals(input.PollId))
                ) && 
                (
                    this.PushNotificationDeliveryOption == input.PushNotificationDeliveryOption ||
                    (this.PushNotificationDeliveryOption != null &&
                    this.PushNotificationDeliveryOption.Equals(input.PushNotificationDeliveryOption))
                ) && 
                (
                    this.TargetLanguages == input.TargetLanguages ||
                    this.TargetLanguages != null &&
                    input.TargetLanguages != null &&
                    this.TargetLanguages.SequenceEqual(input.TargetLanguages)
                ) && 
                (
                    this.TranslationTargetLanguages == input.TranslationTargetLanguages ||
                    this.TranslationTargetLanguages != null &&
                    input.TranslationTargetLanguages != null &&
                    this.TranslationTargetLanguages.SequenceEqual(input.TranslationTargetLanguages)
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
                if (this.AppleCriticalAlertOptions != null)
                    hashCode = hashCode * 59 + this.AppleCriticalAlertOptions.GetHashCode();
                if (this.CustomType != null)
                    hashCode = hashCode * 59 + this.CustomType.GetHashCode();
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
                if (this.IsReplyToChannel != null)
                    hashCode = hashCode * 59 + this.IsReplyToChannel.GetHashCode();
                if (this.MentionType != null)
                    hashCode = hashCode * 59 + this.MentionType.GetHashCode();
                if (this.MentionedUserIds != null)
                    hashCode = hashCode * 59 + this.MentionedUserIds.GetHashCode();
                if (this.MentionedUsers != null)
                    hashCode = hashCode * 59 + this.MentionedUsers.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.MetaArrayKeys != null)
                    hashCode = hashCode * 59 + this.MetaArrayKeys.GetHashCode();
                if (this.MetaArrays != null)
                    hashCode = hashCode * 59 + this.MetaArrays.GetHashCode();
                if (this.ParentMessageId != null)
                    hashCode = hashCode * 59 + this.ParentMessageId.GetHashCode();
                if (this.PollId != null)
                    hashCode = hashCode * 59 + this.PollId.GetHashCode();
                if (this.PushNotificationDeliveryOption != null)
                    hashCode = hashCode * 59 + this.PushNotificationDeliveryOption.GetHashCode();
                if (this.TargetLanguages != null)
                    hashCode = hashCode * 59 + this.TargetLanguages.GetHashCode();
                if (this.TranslationTargetLanguages != null)
                    hashCode = hashCode * 59 + this.TranslationTargetLanguages.GetHashCode();
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
