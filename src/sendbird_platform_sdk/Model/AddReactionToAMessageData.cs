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
    /// AddReactionToAMessageData
    /// </summary>
    [DataContract]
    public partial class AddReactionToAMessageData :  IEquatable<AddReactionToAMessageData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddReactionToAMessageData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AddReactionToAMessageData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddReactionToAMessageData" /> class.
        /// </summary>
        /// <param name="channelType">Specifies the type of the channel. Currently, a value of group_channels is only available for the parameter. (required).</param>
        /// <param name="channelUrl">Specifies the URL of the target channel. (required).</param>
        /// <param name="messageId">Specifies the unique ID of the message to add a reaction to. (required).</param>
        /// <param name="userId">Specifies the ID of the user who reacts to the message. (required).</param>
        /// <param name="reaction">Specifies the unique key of the reaction to be added to the message. The length is limited to 192 charaters. (required).</param>
        public AddReactionToAMessageData(string channelType = default, string channelUrl = default, int messageId = default(int), string userId = default, string reaction = default)
        {
            // to ensure "channelType" is required (not null)
            if (channelType == null)
            {
                throw new InvalidDataException("channelType is a required property for AddReactionToAMessageData and cannot be null");
            }
            else
            {
                this.ChannelType = channelType;
            }

            // to ensure "channelUrl" is required (not null)
            if (channelUrl == null)
            {
                throw new InvalidDataException("channelUrl is a required property for AddReactionToAMessageData and cannot be null");
            }
            else
            {
                this.ChannelUrl = channelUrl;
            }

            // to ensure "messageId" is required (not null)
            if (messageId == null)
            {
                throw new InvalidDataException("messageId is a required property for AddReactionToAMessageData and cannot be null");
            }
            else
            {
                this.MessageId = messageId;
            }

            // to ensure "userId" is required (not null)
            if (userId == null)
            {
                throw new InvalidDataException("userId is a required property for AddReactionToAMessageData and cannot be null");
            }
            else
            {
                this.UserId = userId;
            }

            // to ensure "reaction" is required (not null)
            if (reaction == null)
            {
                throw new InvalidDataException("reaction is a required property for AddReactionToAMessageData and cannot be null");
            }
            else
            {
                this.Reaction = reaction;
            }

        }

        /// <summary>
        /// Specifies the type of the channel. Currently, a value of group_channels is only available for the parameter.
        /// </summary>
        /// <value>Specifies the type of the channel. Currently, a value of group_channels is only available for the parameter.</value>
        [DataMember(Name="channel_type", EmitDefaultValue=true)]
        public string ChannelType { get; set; }

        /// <summary>
        /// Specifies the URL of the target channel.
        /// </summary>
        /// <value>Specifies the URL of the target channel.</value>
        [DataMember(Name="channel_url", EmitDefaultValue=true)]
        public string ChannelUrl { get; set; }

        /// <summary>
        /// Specifies the unique ID of the message to add a reaction to.
        /// </summary>
        /// <value>Specifies the unique ID of the message to add a reaction to.</value>
        [DataMember(Name="message_id", EmitDefaultValue=true)]
        public int MessageId { get; set; }

        /// <summary>
        /// Specifies the ID of the user who reacts to the message.
        /// </summary>
        /// <value>Specifies the ID of the user who reacts to the message.</value>
        [DataMember(Name="user_id", EmitDefaultValue=true)]
        public string UserId { get; set; }

        /// <summary>
        /// Specifies the unique key of the reaction to be added to the message. The length is limited to 192 charaters.
        /// </summary>
        /// <value>Specifies the unique key of the reaction to be added to the message. The length is limited to 192 charaters.</value>
        [DataMember(Name="reaction", EmitDefaultValue=true)]
        public string Reaction { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddReactionToAMessageData {\n");
            sb.Append("  ChannelType: ").Append(ChannelType).Append("\n");
            sb.Append("  ChannelUrl: ").Append(ChannelUrl).Append("\n");
            sb.Append("  MessageId: ").Append(MessageId).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Reaction: ").Append(Reaction).Append("\n");
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
            return this.Equals(input as AddReactionToAMessageData);
        }

        /// <summary>
        /// Returns true if AddReactionToAMessageData instances are equal
        /// </summary>
        /// <param name="input">Instance of AddReactionToAMessageData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddReactionToAMessageData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ChannelType == input.ChannelType ||
                    (this.ChannelType != null &&
                    this.ChannelType.Equals(input.ChannelType))
                ) && 
                (
                    this.ChannelUrl == input.ChannelUrl ||
                    (this.ChannelUrl != null &&
                    this.ChannelUrl.Equals(input.ChannelUrl))
                ) && 
                (
                    this.MessageId == input.MessageId ||
                    (this.MessageId != null &&
                    this.MessageId.Equals(input.MessageId))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.Reaction == input.Reaction ||
                    (this.Reaction != null &&
                    this.Reaction.Equals(input.Reaction))
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
                if (this.ChannelType != null)
                    hashCode = hashCode * 59 + this.ChannelType.GetHashCode();
                if (this.ChannelUrl != null)
                    hashCode = hashCode * 59 + this.ChannelUrl.GetHashCode();
                if (this.MessageId != null)
                    hashCode = hashCode * 59 + this.MessageId.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.Reaction != null)
                    hashCode = hashCode * 59 + this.Reaction.GetHashCode();
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
