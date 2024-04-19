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
    /// GcJoinChannelData
    /// </summary>
    [DataContract]
    public partial class GcJoinChannelData :  IEquatable<GcJoinChannelData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GcJoinChannelData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GcJoinChannelData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GcJoinChannelData" /> class.
        /// </summary>
        /// <param name="channelUrl">Specifies the URL of the channel to join. (required).</param>
        /// <param name="userId">Specifies the unique ID of the user to join the public group channel. (required).</param>
        /// <param name="accessCode">This property should be specified if the public group channel to join requires an access code to users, which means that the is_access_code_required property of the channel resource is true. (required).</param>
        public GcJoinChannelData(string channelUrl = default, string userId = default, string accessCode = default)
        {
            // to ensure "channelUrl" is required (not null)
            if (channelUrl == null)
            {
                throw new InvalidDataException("channelUrl is a required property for GcJoinChannelData and cannot be null");
            }
            else
            {
                this.ChannelUrl = channelUrl;
            }

            // to ensure "userId" is required (not null)
            if (userId == null)
            {
                throw new InvalidDataException("userId is a required property for GcJoinChannelData and cannot be null");
            }
            else
            {
                this.UserId = userId;
            }

            // to ensure "accessCode" is required (not null)
            if (accessCode == null)
            {
                throw new InvalidDataException("accessCode is a required property for GcJoinChannelData and cannot be null");
            }
            else
            {
                this.AccessCode = accessCode;
            }

        }

        /// <summary>
        /// Specifies the URL of the channel to join.
        /// </summary>
        /// <value>Specifies the URL of the channel to join.</value>
        [DataMember(Name="channel_url", EmitDefaultValue=true)]
        public string ChannelUrl { get; set; }

        /// <summary>
        /// Specifies the unique ID of the user to join the public group channel.
        /// </summary>
        /// <value>Specifies the unique ID of the user to join the public group channel.</value>
        [DataMember(Name="user_id", EmitDefaultValue=true)]
        public string UserId { get; set; }

        /// <summary>
        /// This property should be specified if the public group channel to join requires an access code to users, which means that the is_access_code_required property of the channel resource is true.
        /// </summary>
        /// <value>This property should be specified if the public group channel to join requires an access code to users, which means that the is_access_code_required property of the channel resource is true.</value>
        [DataMember(Name="access_code", EmitDefaultValue=true)]
        public string AccessCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GcJoinChannelData {\n");
            sb.Append("  ChannelUrl: ").Append(ChannelUrl).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  AccessCode: ").Append(AccessCode).Append("\n");
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
            return this.Equals(input as GcJoinChannelData);
        }

        /// <summary>
        /// Returns true if GcJoinChannelData instances are equal
        /// </summary>
        /// <param name="input">Instance of GcJoinChannelData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GcJoinChannelData input)
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
                    this.AccessCode == input.AccessCode ||
                    (this.AccessCode != null &&
                    this.AccessCode.Equals(input.AccessCode))
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
                if (this.AccessCode != null)
                    hashCode = hashCode * 59 + this.AccessCode.GetHashCode();
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
