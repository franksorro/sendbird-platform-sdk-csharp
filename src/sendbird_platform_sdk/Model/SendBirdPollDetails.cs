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
    /// SendBirdPollDetails
    /// </summary>
    [DataContract]
    public partial class SendBirdPollDetails :  IEquatable<SendBirdPollDetails>, IValidatableObject
    {
        /// <summary>
        /// Defines Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Closed for value: closed
            /// </summary>
            [EnumMember(Value = "closed")]
            Closed = 1,

            /// <summary>
            /// Enum Open for value: open
            /// </summary>
            [EnumMember(Value = "open")]
            Open = 2,

            /// <summary>
            /// Enum Removed for value: removed
            /// </summary>
            [EnumMember(Value = "removed")]
            Removed = 3

        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SendBirdPollDetails" /> class.
        /// </summary>
        /// <param name="allowMultipleVotes">allowMultipleVotes.</param>
        /// <param name="allowUserSuggestion">allowUserSuggestion.</param>
        /// <param name="closeAt">closeAt.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="createdBy">createdBy.</param>
        /// <param name="isAnonymous">isAnonymous.</param>
        /// <param name="options">options.</param>
        /// <param name="status">status.</param>
        /// <param name="updatedAt">updatedAt.</param>
        /// <param name="voterCount">voterCount.</param>
        public SendBirdPollDetails(bool allowMultipleVotes = default(bool), bool allowUserSuggestion = default(bool), decimal closeAt = default(decimal), decimal createdAt = default(decimal), string createdBy = default, bool isAnonymous = default(bool), List<SendBirdPollOption> options = default(List<SendBirdPollOption>), StatusEnum? status = default(StatusEnum?), decimal updatedAt = default(decimal), decimal voterCount = default(decimal))
        {
            this.AllowMultipleVotes = allowMultipleVotes;
            this.AllowUserSuggestion = allowUserSuggestion;
            this.CloseAt = closeAt;
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
            this.IsAnonymous = isAnonymous;
            this.Options = options;
            this.Status = status;
            this.UpdatedAt = updatedAt;
            this.VoterCount = voterCount;
        }

        /// <summary>
        /// Gets or Sets AllowMultipleVotes
        /// </summary>
        [DataMember(Name="allow_multiple_votes", EmitDefaultValue=false)]
        public bool AllowMultipleVotes { get; set; }

        /// <summary>
        /// Gets or Sets AllowUserSuggestion
        /// </summary>
        [DataMember(Name="allow_user_suggestion", EmitDefaultValue=false)]
        public bool AllowUserSuggestion { get; set; }

        /// <summary>
        /// Gets or Sets CloseAt
        /// </summary>
        [DataMember(Name="close_at", EmitDefaultValue=false)]
        public decimal CloseAt { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public decimal CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name="created_by", EmitDefaultValue=false)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Gets or Sets IsAnonymous
        /// </summary>
        [DataMember(Name="is_anonymous", EmitDefaultValue=false)]
        public bool IsAnonymous { get; set; }

        /// <summary>
        /// Gets or Sets Options
        /// </summary>
        [DataMember(Name="options", EmitDefaultValue=false)]
        public List<SendBirdPollOption> Options { get; set; }


        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        public decimal UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets VoterCount
        /// </summary>
        [DataMember(Name="voter_count", EmitDefaultValue=false)]
        public decimal VoterCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SendBirdPollDetails {\n");
            sb.Append("  AllowMultipleVotes: ").Append(AllowMultipleVotes).Append("\n");
            sb.Append("  AllowUserSuggestion: ").Append(AllowUserSuggestion).Append("\n");
            sb.Append("  CloseAt: ").Append(CloseAt).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  IsAnonymous: ").Append(IsAnonymous).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  VoterCount: ").Append(VoterCount).Append("\n");
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
            return this.Equals(input as SendBirdPollDetails);
        }

        /// <summary>
        /// Returns true if SendBirdPollDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of SendBirdPollDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SendBirdPollDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AllowMultipleVotes == input.AllowMultipleVotes ||
                    (this.AllowMultipleVotes != null &&
                    this.AllowMultipleVotes.Equals(input.AllowMultipleVotes))
                ) && 
                (
                    this.AllowUserSuggestion == input.AllowUserSuggestion ||
                    (this.AllowUserSuggestion != null &&
                    this.AllowUserSuggestion.Equals(input.AllowUserSuggestion))
                ) && 
                (
                    this.CloseAt == input.CloseAt ||
                    (this.CloseAt != null &&
                    this.CloseAt.Equals(input.CloseAt))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.CreatedBy == input.CreatedBy ||
                    (this.CreatedBy != null &&
                    this.CreatedBy.Equals(input.CreatedBy))
                ) && 
                (
                    this.IsAnonymous == input.IsAnonymous ||
                    (this.IsAnonymous != null &&
                    this.IsAnonymous.Equals(input.IsAnonymous))
                ) && 
                (
                    this.Options == input.Options ||
                    this.Options != null &&
                    input.Options != null &&
                    this.Options.SequenceEqual(input.Options)
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.VoterCount == input.VoterCount ||
                    (this.VoterCount != null &&
                    this.VoterCount.Equals(input.VoterCount))
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
                if (this.AllowMultipleVotes != null)
                    hashCode = hashCode * 59 + this.AllowMultipleVotes.GetHashCode();
                if (this.AllowUserSuggestion != null)
                    hashCode = hashCode * 59 + this.AllowUserSuggestion.GetHashCode();
                if (this.CloseAt != null)
                    hashCode = hashCode * 59 + this.CloseAt.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.CreatedBy != null)
                    hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.IsAnonymous != null)
                    hashCode = hashCode * 59 + this.IsAnonymous.GetHashCode();
                if (this.Options != null)
                    hashCode = hashCode * 59 + this.Options.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.VoterCount != null)
                    hashCode = hashCode * 59 + this.VoterCount.GetHashCode();
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
