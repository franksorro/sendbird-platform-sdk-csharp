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
    /// OcBanUserResponse
    /// </summary>
    [DataContract]
    public partial class OcBanUserResponse :  IEquatable<OcBanUserResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OcBanUserResponse" /> class.
        /// </summary>
        /// <param name="startAt">startAt.</param>
        /// <param name="endAt">endAt.</param>
        /// <param name="description">description.</param>
        /// <param name="userId">userId.</param>
        /// <param name="user">user.</param>
        /// <param name="nextUrl">nextUrl.</param>
        /// <param name="requireAuthForProfileImage">requireAuthForProfileImage.</param>
        /// <param name="nickname">nickname.</param>
        /// <param name="profileUrl">profileUrl.</param>
        /// <param name="metadata">metadata.</param>
        public OcBanUserResponse(decimal startAt = default(decimal), decimal endAt = default(decimal), string description = default, string userId = default, SendBirdUser user = default(SendBirdUser), string nextUrl = default, bool requireAuthForProfileImage = default(bool), string nickname = default, string profileUrl = default, OcDeleteChannelByUrl200Response metadata = default(OcDeleteChannelByUrl200Response))
        {
            this.StartAt = startAt;
            this.EndAt = endAt;
            this.Description = description;
            this.UserId = userId;
            this.User = user;
            this.NextUrl = nextUrl;
            this.RequireAuthForProfileImage = requireAuthForProfileImage;
            this.Nickname = nickname;
            this.ProfileUrl = profileUrl;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Gets or Sets StartAt
        /// </summary>
        [DataMember(Name="start_at", EmitDefaultValue=false)]
        public decimal StartAt { get; set; }

        /// <summary>
        /// Gets or Sets EndAt
        /// </summary>
        [DataMember(Name="end_at", EmitDefaultValue=false)]
        public decimal EndAt { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="user_id", EmitDefaultValue=false)]
        public string UserId { get; set; }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public SendBirdUser User { get; set; }

        /// <summary>
        /// Gets or Sets NextUrl
        /// </summary>
        [DataMember(Name="next_url", EmitDefaultValue=false)]
        public string NextUrl { get; set; }

        /// <summary>
        /// Gets or Sets RequireAuthForProfileImage
        /// </summary>
        [DataMember(Name="require_auth_for_profile_image", EmitDefaultValue=false)]
        public bool RequireAuthForProfileImage { get; set; }

        /// <summary>
        /// Gets or Sets Nickname
        /// </summary>
        [DataMember(Name="nickname", EmitDefaultValue=false)]
        public string Nickname { get; set; }

        /// <summary>
        /// Gets or Sets ProfileUrl
        /// </summary>
        [DataMember(Name="profile_url", EmitDefaultValue=false)]
        public string ProfileUrl { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public OcDeleteChannelByUrl200Response Metadata { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OcBanUserResponse {\n");
            sb.Append("  StartAt: ").Append(StartAt).Append("\n");
            sb.Append("  EndAt: ").Append(EndAt).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  NextUrl: ").Append(NextUrl).Append("\n");
            sb.Append("  RequireAuthForProfileImage: ").Append(RequireAuthForProfileImage).Append("\n");
            sb.Append("  Nickname: ").Append(Nickname).Append("\n");
            sb.Append("  ProfileUrl: ").Append(ProfileUrl).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
            return this.Equals(input as OcBanUserResponse);
        }

        /// <summary>
        /// Returns true if OcBanUserResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of OcBanUserResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OcBanUserResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StartAt == input.StartAt ||
                    (this.StartAt != null &&
                    this.StartAt.Equals(input.StartAt))
                ) && 
                (
                    this.EndAt == input.EndAt ||
                    (this.EndAt != null &&
                    this.EndAt.Equals(input.EndAt))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && 
                (
                    this.NextUrl == input.NextUrl ||
                    (this.NextUrl != null &&
                    this.NextUrl.Equals(input.NextUrl))
                ) && 
                (
                    this.RequireAuthForProfileImage == input.RequireAuthForProfileImage ||
                    (this.RequireAuthForProfileImage != null &&
                    this.RequireAuthForProfileImage.Equals(input.RequireAuthForProfileImage))
                ) && 
                (
                    this.Nickname == input.Nickname ||
                    (this.Nickname != null &&
                    this.Nickname.Equals(input.Nickname))
                ) && 
                (
                    this.ProfileUrl == input.ProfileUrl ||
                    (this.ProfileUrl != null &&
                    this.ProfileUrl.Equals(input.ProfileUrl))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
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
                if (this.StartAt != null)
                    hashCode = hashCode * 59 + this.StartAt.GetHashCode();
                if (this.EndAt != null)
                    hashCode = hashCode * 59 + this.EndAt.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.NextUrl != null)
                    hashCode = hashCode * 59 + this.NextUrl.GetHashCode();
                if (this.RequireAuthForProfileImage != null)
                    hashCode = hashCode * 59 + this.RequireAuthForProfileImage.GetHashCode();
                if (this.Nickname != null)
                    hashCode = hashCode * 59 + this.Nickname.GetHashCode();
                if (this.ProfileUrl != null)
                    hashCode = hashCode * 59 + this.ProfileUrl.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
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
