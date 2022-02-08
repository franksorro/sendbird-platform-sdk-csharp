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
    /// GcMuteUserData
    /// </summary>
    [DataContract]
    public partial class GcMuteUserData :  IEquatable<GcMuteUserData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GcMuteUserData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GcMuteUserData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GcMuteUserData" /> class.
        /// </summary>
        /// <param name="channelUrl">Specifies the URL of the target channel. (required).</param>
        /// <param name="userId">Specifies the ID of the target user to mute. (required).</param>
        /// <param name="seconds">Specifies the duration of mute status. If set to -1, the user will be muted permanently (10 years, technically). (Default: -1) (required).</param>
        /// <param name="description">Specifies a reason for the muting. (required).</param>
        public GcMuteUserData(string channelUrl = default(string), string userId = default(string), int seconds = default(int), string description = default(string))
        {
            // to ensure "channelUrl" is required (not null)
            if (channelUrl == null)
            {
                throw new InvalidDataException("channelUrl is a required property for GcMuteUserData and cannot be null");
            }
            else
            {
                this.ChannelUrl = channelUrl;
            }

            // to ensure "userId" is required (not null)
            if (userId == null)
            {
                throw new InvalidDataException("userId is a required property for GcMuteUserData and cannot be null");
            }
            else
            {
                this.UserId = userId;
            }

            // to ensure "seconds" is required (not null)
            if (seconds == null)
            {
                throw new InvalidDataException("seconds is a required property for GcMuteUserData and cannot be null");
            }
            else
            {
                this.Seconds = seconds;
            }

            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new InvalidDataException("description is a required property for GcMuteUserData and cannot be null");
            }
            else
            {
                this.Description = description;
            }

        }

        /// <summary>
        /// Specifies the URL of the target channel.
        /// </summary>
        /// <value>Specifies the URL of the target channel.</value>
        [DataMember(Name="channel_url", EmitDefaultValue=true)]
        public string ChannelUrl { get; set; }

        /// <summary>
        /// Specifies the ID of the target user to mute.
        /// </summary>
        /// <value>Specifies the ID of the target user to mute.</value>
        [DataMember(Name="user_id", EmitDefaultValue=true)]
        public string UserId { get; set; }

        /// <summary>
        /// Specifies the duration of mute status. If set to -1, the user will be muted permanently (10 years, technically). (Default: -1)
        /// </summary>
        /// <value>Specifies the duration of mute status. If set to -1, the user will be muted permanently (10 years, technically). (Default: -1)</value>
        [DataMember(Name="seconds", EmitDefaultValue=true)]
        public int Seconds { get; set; }

        /// <summary>
        /// Specifies a reason for the muting.
        /// </summary>
        /// <value>Specifies a reason for the muting.</value>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GcMuteUserData {\n");
            sb.Append("  ChannelUrl: ").Append(ChannelUrl).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Seconds: ").Append(Seconds).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return this.Equals(input as GcMuteUserData);
        }

        /// <summary>
        /// Returns true if GcMuteUserData instances are equal
        /// </summary>
        /// <param name="input">Instance of GcMuteUserData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GcMuteUserData input)
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
                    this.Seconds == input.Seconds ||
                    (this.Seconds != null &&
                    this.Seconds.Equals(input.Seconds))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                if (this.Seconds != null)
                    hashCode = hashCode * 59 + this.Seconds.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
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