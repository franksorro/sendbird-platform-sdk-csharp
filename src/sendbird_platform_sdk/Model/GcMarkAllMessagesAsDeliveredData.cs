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
    /// GcMarkAllMessagesAsDeliveredData
    /// </summary>
    [DataContract]
    public partial class GcMarkAllMessagesAsDeliveredData :  IEquatable<GcMarkAllMessagesAsDeliveredData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GcMarkAllMessagesAsDeliveredData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GcMarkAllMessagesAsDeliveredData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GcMarkAllMessagesAsDeliveredData" /> class.
        /// </summary>
        /// <param name="applicationId">Specifies the unique ID of your application. (required).</param>
        /// <param name="channelUrl">Specifies the URL of the target channel. (required).</param>
        /// <param name="userId">Specifies the ID of the recipient to mark messages as delivered. (required).</param>
        public GcMarkAllMessagesAsDeliveredData(string applicationId = default, string channelUrl = default, string userId = default)
        {
            // to ensure "applicationId" is required (not null)
            if (applicationId == null)
            {
                throw new InvalidDataException("applicationId is a required property for GcMarkAllMessagesAsDeliveredData and cannot be null");
            }
            else
            {
                this.ApplicationId = applicationId;
            }

            // to ensure "channelUrl" is required (not null)
            if (channelUrl == null)
            {
                throw new InvalidDataException("channelUrl is a required property for GcMarkAllMessagesAsDeliveredData and cannot be null");
            }
            else
            {
                this.ChannelUrl = channelUrl;
            }

            // to ensure "userId" is required (not null)
            if (userId == null)
            {
                throw new InvalidDataException("userId is a required property for GcMarkAllMessagesAsDeliveredData and cannot be null");
            }
            else
            {
                this.UserId = userId;
            }

        }

        /// <summary>
        /// Specifies the unique ID of your application.
        /// </summary>
        /// <value>Specifies the unique ID of your application.</value>
        [DataMember(Name="application_id", EmitDefaultValue=true)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Specifies the URL of the target channel.
        /// </summary>
        /// <value>Specifies the URL of the target channel.</value>
        [DataMember(Name="channel_url", EmitDefaultValue=true)]
        public string ChannelUrl { get; set; }

        /// <summary>
        /// Specifies the ID of the recipient to mark messages as delivered.
        /// </summary>
        /// <value>Specifies the ID of the recipient to mark messages as delivered.</value>
        [DataMember(Name="user_id", EmitDefaultValue=true)]
        public string UserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GcMarkAllMessagesAsDeliveredData {\n");
            sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
            sb.Append("  ChannelUrl: ").Append(ChannelUrl).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
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
            return this.Equals(input as GcMarkAllMessagesAsDeliveredData);
        }

        /// <summary>
        /// Returns true if GcMarkAllMessagesAsDeliveredData instances are equal
        /// </summary>
        /// <param name="input">Instance of GcMarkAllMessagesAsDeliveredData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GcMarkAllMessagesAsDeliveredData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ApplicationId == input.ApplicationId ||
                    (this.ApplicationId != null &&
                    this.ApplicationId.Equals(input.ApplicationId))
                ) && 
                (
                    this.ChannelUrl == input.ChannelUrl ||
                    (this.ChannelUrl != null &&
                    this.ChannelUrl.Equals(input.ChannelUrl))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
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
                if (this.ApplicationId != null)
                    hashCode = hashCode * 59 + this.ApplicationId.GetHashCode();
                if (this.ChannelUrl != null)
                    hashCode = hashCode * 59 + this.ChannelUrl.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
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
