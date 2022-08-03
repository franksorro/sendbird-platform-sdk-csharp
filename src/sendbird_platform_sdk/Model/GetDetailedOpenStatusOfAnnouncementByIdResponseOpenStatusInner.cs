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
    /// GetDetailedOpenStatusOfAnnouncementByIdResponseOpenStatusInner
    /// </summary>
    [DataContract]
    public partial class GetDetailedOpenStatusOfAnnouncementByIdResponseOpenStatusInner :  IEquatable<GetDetailedOpenStatusOfAnnouncementByIdResponseOpenStatusInner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDetailedOpenStatusOfAnnouncementByIdResponseOpenStatusInner" /> class.
        /// </summary>
        /// <param name="userId">userId.</param>
        /// <param name="channelUrl">channelUrl.</param>
        /// <param name="hasOpened">hasOpened.</param>
        /// <param name="sentAt">sentAt.</param>
        /// <param name="openAt">openAt.</param>
        public GetDetailedOpenStatusOfAnnouncementByIdResponseOpenStatusInner(string userId = default(string), string channelUrl = default(string), bool hasOpened = default(bool), decimal sentAt = default(decimal), decimal openAt = default(decimal))
        {
            this.UserId = userId;
            this.ChannelUrl = channelUrl;
            this.HasOpened = hasOpened;
            this.SentAt = sentAt;
            this.OpenAt = openAt;
        }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="user_id", EmitDefaultValue=false)]
        public string UserId { get; set; }

        /// <summary>
        /// Gets or Sets ChannelUrl
        /// </summary>
        [DataMember(Name="channel_url", EmitDefaultValue=false)]
        public string ChannelUrl { get; set; }

        /// <summary>
        /// Gets or Sets HasOpened
        /// </summary>
        [DataMember(Name="has_opened", EmitDefaultValue=false)]
        public bool HasOpened { get; set; }

        /// <summary>
        /// Gets or Sets SentAt
        /// </summary>
        [DataMember(Name="sent_at", EmitDefaultValue=false)]
        public decimal SentAt { get; set; }

        /// <summary>
        /// Gets or Sets OpenAt
        /// </summary>
        [DataMember(Name="open_at", EmitDefaultValue=false)]
        public decimal OpenAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetDetailedOpenStatusOfAnnouncementByIdResponseOpenStatusInner {\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  ChannelUrl: ").Append(ChannelUrl).Append("\n");
            sb.Append("  HasOpened: ").Append(HasOpened).Append("\n");
            sb.Append("  SentAt: ").Append(SentAt).Append("\n");
            sb.Append("  OpenAt: ").Append(OpenAt).Append("\n");
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
            return this.Equals(input as GetDetailedOpenStatusOfAnnouncementByIdResponseOpenStatusInner);
        }

        /// <summary>
        /// Returns true if GetDetailedOpenStatusOfAnnouncementByIdResponseOpenStatusInner instances are equal
        /// </summary>
        /// <param name="input">Instance of GetDetailedOpenStatusOfAnnouncementByIdResponseOpenStatusInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetDetailedOpenStatusOfAnnouncementByIdResponseOpenStatusInner input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.ChannelUrl == input.ChannelUrl ||
                    (this.ChannelUrl != null &&
                    this.ChannelUrl.Equals(input.ChannelUrl))
                ) && 
                (
                    this.HasOpened == input.HasOpened ||
                    (this.HasOpened != null &&
                    this.HasOpened.Equals(input.HasOpened))
                ) && 
                (
                    this.SentAt == input.SentAt ||
                    (this.SentAt != null &&
                    this.SentAt.Equals(input.SentAt))
                ) && 
                (
                    this.OpenAt == input.OpenAt ||
                    (this.OpenAt != null &&
                    this.OpenAt.Equals(input.OpenAt))
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
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.ChannelUrl != null)
                    hashCode = hashCode * 59 + this.ChannelUrl.GetHashCode();
                if (this.HasOpened != null)
                    hashCode = hashCode * 59 + this.HasOpened.GetHashCode();
                if (this.SentAt != null)
                    hashCode = hashCode * 59 + this.SentAt.GetHashCode();
                if (this.OpenAt != null)
                    hashCode = hashCode * 59 + this.OpenAt.GetHashCode();
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