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
    /// JoinChannelsData
    /// </summary>
    [DataContract]
    public partial class JoinChannelsData :  IEquatable<JoinChannelsData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JoinChannelsData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected JoinChannelsData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="JoinChannelsData" /> class.
        /// </summary>
        /// <param name="botUserid">Specifies the ID of the bot to join the channels. (required).</param>
        /// <param name="channelUrls">Specifies an array of one or more URLs of the channels to join. (required).</param>
        public JoinChannelsData(string botUserid = default, List<string> channelUrls = default)
        {
            // to ensure "botUserid" is required (not null)
            if (botUserid == null)
            {
                throw new InvalidDataException("botUserid is a required property for JoinChannelsData and cannot be null");
            }
            else
            {
                this.BotUserid = botUserid;
            }

            // to ensure "channelUrls" is required (not null)
            if (channelUrls == null)
            {
                throw new InvalidDataException("channelUrls is a required property for JoinChannelsData and cannot be null");
            }
            else
            {
                this.ChannelUrls = channelUrls;
            }

        }

        /// <summary>
        /// Specifies the ID of the bot to join the channels.
        /// </summary>
        /// <value>Specifies the ID of the bot to join the channels.</value>
        [DataMember(Name="bot_userid", EmitDefaultValue=true)]
        public string BotUserid { get; set; }

        /// <summary>
        /// Specifies an array of one or more URLs of the channels to join.
        /// </summary>
        /// <value>Specifies an array of one or more URLs of the channels to join.</value>
        [DataMember(Name="channel_urls", EmitDefaultValue=true)]
        public List<string> ChannelUrls { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JoinChannelsData {\n");
            sb.Append("  BotUserid: ").Append(BotUserid).Append("\n");
            sb.Append("  ChannelUrls: ").Append(ChannelUrls).Append("\n");
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
            return this.Equals(input as JoinChannelsData);
        }

        /// <summary>
        /// Returns true if JoinChannelsData instances are equal
        /// </summary>
        /// <param name="input">Instance of JoinChannelsData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JoinChannelsData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BotUserid == input.BotUserid ||
                    (this.BotUserid != null &&
                    this.BotUserid.Equals(input.BotUserid))
                ) && 
                (
                    this.ChannelUrls == input.ChannelUrls ||
                    this.ChannelUrls != null &&
                    input.ChannelUrls != null &&
                    this.ChannelUrls.SequenceEqual(input.ChannelUrls)
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
                if (this.BotUserid != null)
                    hashCode = hashCode * 59 + this.BotUserid.GetHashCode();
                if (this.ChannelUrls != null)
                    hashCode = hashCode * 59 + this.ChannelUrls.GetHashCode();
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
