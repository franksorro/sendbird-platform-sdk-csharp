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
    /// UpdateExtraDataInMessageData
    /// </summary>
    [DataContract]
    public partial class UpdateExtraDataInMessageData :  IEquatable<UpdateExtraDataInMessageData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateExtraDataInMessageData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateExtraDataInMessageData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateExtraDataInMessageData" /> class.
        /// </summary>
        /// <param name="channelType">Specifies the type of the channel. Either open_channels or group_channels. (required).</param>
        /// <param name="channelUrl">Specifies the URL of the target channel. (required).</param>
        /// <param name="messageId">Specifies the unique ID of the message to update key-values items. (required).</param>
        /// <param name="sortedMetaarray">Specifies a &#x60;JSON&#x60; object of one or more key-values items which store additional message information. Each item consists of a key and the values in an array. Items are saved and will be returned in the exact order they&#39;ve been specified. (required).</param>
        /// <param name="mode">Determines whether to add the specified values in the items or remove the specified values from the existing items. Acceptable values are limited to add and remove. If set to add, the specified values are added only when they are different from the existing values. If set to remove, the specified values are removed only when they have the corresponding ones in the existing values. (required).</param>
        /// <param name="upsert">Determines whether to add new items in addition to updating existing items. If true, new key-values items are added when there are no items with the keys. The existing items are updated with new values when there are already items with the keys. If false, only the items of which keys match the ones you specify are updated with new values. (Default: false) (required).</param>
        public UpdateExtraDataInMessageData(string channelType = default, string channelUrl = default, int messageId = default(int), string sortedMetaarray = default, string mode = default, bool upsert = default(bool))
        {
            // to ensure "channelType" is required (not null)
            if (channelType == null)
            {
                throw new InvalidDataException("channelType is a required property for UpdateExtraDataInMessageData and cannot be null");
            }
            else
            {
                this.ChannelType = channelType;
            }

            // to ensure "channelUrl" is required (not null)
            if (channelUrl == null)
            {
                throw new InvalidDataException("channelUrl is a required property for UpdateExtraDataInMessageData and cannot be null");
            }
            else
            {
                this.ChannelUrl = channelUrl;
            }

            // to ensure "messageId" is required (not null)
            if (messageId == null)
            {
                throw new InvalidDataException("messageId is a required property for UpdateExtraDataInMessageData and cannot be null");
            }
            else
            {
                this.MessageId = messageId;
            }

            // to ensure "sortedMetaarray" is required (not null)
            if (sortedMetaarray == null)
            {
                throw new InvalidDataException("sortedMetaarray is a required property for UpdateExtraDataInMessageData and cannot be null");
            }
            else
            {
                this.SortedMetaarray = sortedMetaarray;
            }

            // to ensure "mode" is required (not null)
            if (mode == null)
            {
                throw new InvalidDataException("mode is a required property for UpdateExtraDataInMessageData and cannot be null");
            }
            else
            {
                this.Mode = mode;
            }

            // to ensure "upsert" is required (not null)
            if (upsert == null)
            {
                throw new InvalidDataException("upsert is a required property for UpdateExtraDataInMessageData and cannot be null");
            }
            else
            {
                this.Upsert = upsert;
            }

        }

        /// <summary>
        /// Specifies the type of the channel. Either open_channels or group_channels.
        /// </summary>
        /// <value>Specifies the type of the channel. Either open_channels or group_channels.</value>
        [DataMember(Name="channel_type", EmitDefaultValue=true)]
        public string ChannelType { get; set; }

        /// <summary>
        /// Specifies the URL of the target channel.
        /// </summary>
        /// <value>Specifies the URL of the target channel.</value>
        [DataMember(Name="channel_url", EmitDefaultValue=true)]
        public string ChannelUrl { get; set; }

        /// <summary>
        /// Specifies the unique ID of the message to update key-values items.
        /// </summary>
        /// <value>Specifies the unique ID of the message to update key-values items.</value>
        [DataMember(Name="message_id", EmitDefaultValue=true)]
        public int MessageId { get; set; }

        /// <summary>
        /// Specifies a &#x60;JSON&#x60; object of one or more key-values items which store additional message information. Each item consists of a key and the values in an array. Items are saved and will be returned in the exact order they&#39;ve been specified.
        /// </summary>
        /// <value>Specifies a &#x60;JSON&#x60; object of one or more key-values items which store additional message information. Each item consists of a key and the values in an array. Items are saved and will be returned in the exact order they&#39;ve been specified.</value>
        [DataMember(Name="sorted_metaarray", EmitDefaultValue=true)]
        public string SortedMetaarray { get; set; }

        /// <summary>
        /// Determines whether to add the specified values in the items or remove the specified values from the existing items. Acceptable values are limited to add and remove. If set to add, the specified values are added only when they are different from the existing values. If set to remove, the specified values are removed only when they have the corresponding ones in the existing values.
        /// </summary>
        /// <value>Determines whether to add the specified values in the items or remove the specified values from the existing items. Acceptable values are limited to add and remove. If set to add, the specified values are added only when they are different from the existing values. If set to remove, the specified values are removed only when they have the corresponding ones in the existing values.</value>
        [DataMember(Name="mode", EmitDefaultValue=true)]
        public string Mode { get; set; }

        /// <summary>
        /// Determines whether to add new items in addition to updating existing items. If true, new key-values items are added when there are no items with the keys. The existing items are updated with new values when there are already items with the keys. If false, only the items of which keys match the ones you specify are updated with new values. (Default: false)
        /// </summary>
        /// <value>Determines whether to add new items in addition to updating existing items. If true, new key-values items are added when there are no items with the keys. The existing items are updated with new values when there are already items with the keys. If false, only the items of which keys match the ones you specify are updated with new values. (Default: false)</value>
        [DataMember(Name="upsert", EmitDefaultValue=true)]
        public bool Upsert { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateExtraDataInMessageData {\n");
            sb.Append("  ChannelType: ").Append(ChannelType).Append("\n");
            sb.Append("  ChannelUrl: ").Append(ChannelUrl).Append("\n");
            sb.Append("  MessageId: ").Append(MessageId).Append("\n");
            sb.Append("  SortedMetaarray: ").Append(SortedMetaarray).Append("\n");
            sb.Append("  Mode: ").Append(Mode).Append("\n");
            sb.Append("  Upsert: ").Append(Upsert).Append("\n");
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
            return this.Equals(input as UpdateExtraDataInMessageData);
        }

        /// <summary>
        /// Returns true if UpdateExtraDataInMessageData instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateExtraDataInMessageData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateExtraDataInMessageData input)
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
                    this.SortedMetaarray == input.SortedMetaarray ||
                    (this.SortedMetaarray != null &&
                    this.SortedMetaarray.Equals(input.SortedMetaarray))
                ) && 
                (
                    this.Mode == input.Mode ||
                    (this.Mode != null &&
                    this.Mode.Equals(input.Mode))
                ) && 
                (
                    this.Upsert == input.Upsert ||
                    (this.Upsert != null &&
                    this.Upsert.Equals(input.Upsert))
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
                if (this.SortedMetaarray != null)
                    hashCode = hashCode * 59 + this.SortedMetaarray.GetHashCode();
                if (this.Mode != null)
                    hashCode = hashCode * 59 + this.Mode.GetHashCode();
                if (this.Upsert != null)
                    hashCode = hashCode * 59 + this.Upsert.GetHashCode();
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
