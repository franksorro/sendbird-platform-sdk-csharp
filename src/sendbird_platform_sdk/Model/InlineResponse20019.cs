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
    /// InlineResponse20019
    /// </summary>
    [DataContract]
    public partial class InlineResponse20019 :  IEquatable<InlineResponse20019>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse20019" /> class.
        /// </summary>
        /// <param name="nonSuperGroupChannelUnreadMessageCount">nonSuperGroupChannelUnreadMessageCount.</param>
        /// <param name="superGroupChannelUnreadMessageCount">superGroupChannelUnreadMessageCount.</param>
        /// <param name="groupChannelUnreadMessageCount">groupChannelUnreadMessageCount.</param>
        /// <param name="superGroupChannelInvitationCount">superGroupChannelInvitationCount.</param>
        /// <param name="groupChannelInvitationCount">groupChannelInvitationCount.</param>
        /// <param name="superGroupChannelUnreadMentionCount">superGroupChannelUnreadMentionCount.</param>
        /// <param name="groupChannelUnreadMentionCount">groupChannelUnreadMentionCount.</param>
        /// <param name="nonSuperGroupChannelUnreadMentionCount">nonSuperGroupChannelUnreadMentionCount.</param>
        /// <param name="nonSuperGroupChannelInvitationCount">nonSuperGroupChannelInvitationCount.</param>
        public InlineResponse20019(decimal nonSuperGroupChannelUnreadMessageCount = default(decimal), decimal superGroupChannelUnreadMessageCount = default(decimal), decimal groupChannelUnreadMessageCount = default(decimal), decimal superGroupChannelInvitationCount = default(decimal), decimal groupChannelInvitationCount = default(decimal), decimal superGroupChannelUnreadMentionCount = default(decimal), decimal groupChannelUnreadMentionCount = default(decimal), decimal nonSuperGroupChannelUnreadMentionCount = default(decimal), decimal nonSuperGroupChannelInvitationCount = default(decimal))
        {
            this.NonSuperGroupChannelUnreadMessageCount = nonSuperGroupChannelUnreadMessageCount;
            this.SuperGroupChannelUnreadMessageCount = superGroupChannelUnreadMessageCount;
            this.GroupChannelUnreadMessageCount = groupChannelUnreadMessageCount;
            this.SuperGroupChannelInvitationCount = superGroupChannelInvitationCount;
            this.GroupChannelInvitationCount = groupChannelInvitationCount;
            this.SuperGroupChannelUnreadMentionCount = superGroupChannelUnreadMentionCount;
            this.GroupChannelUnreadMentionCount = groupChannelUnreadMentionCount;
            this.NonSuperGroupChannelUnreadMentionCount = nonSuperGroupChannelUnreadMentionCount;
            this.NonSuperGroupChannelInvitationCount = nonSuperGroupChannelInvitationCount;
        }

        /// <summary>
        /// Gets or Sets NonSuperGroupChannelUnreadMessageCount
        /// </summary>
        [DataMember(Name="non_super_group_channel_unread_message_count", EmitDefaultValue=false)]
        public decimal NonSuperGroupChannelUnreadMessageCount { get; set; }

        /// <summary>
        /// Gets or Sets SuperGroupChannelUnreadMessageCount
        /// </summary>
        [DataMember(Name="super_group_channel_unread_message_count", EmitDefaultValue=false)]
        public decimal SuperGroupChannelUnreadMessageCount { get; set; }

        /// <summary>
        /// Gets or Sets GroupChannelUnreadMessageCount
        /// </summary>
        [DataMember(Name="group_channel_unread_message_count", EmitDefaultValue=false)]
        public decimal GroupChannelUnreadMessageCount { get; set; }

        /// <summary>
        /// Gets or Sets SuperGroupChannelInvitationCount
        /// </summary>
        [DataMember(Name="super_group_channel_invitation_count", EmitDefaultValue=false)]
        public decimal SuperGroupChannelInvitationCount { get; set; }

        /// <summary>
        /// Gets or Sets GroupChannelInvitationCount
        /// </summary>
        [DataMember(Name="group_channel_invitation_count", EmitDefaultValue=false)]
        public decimal GroupChannelInvitationCount { get; set; }

        /// <summary>
        /// Gets or Sets SuperGroupChannelUnreadMentionCount
        /// </summary>
        [DataMember(Name="super_group_channel_unread_mention_count", EmitDefaultValue=false)]
        public decimal SuperGroupChannelUnreadMentionCount { get; set; }

        /// <summary>
        /// Gets or Sets GroupChannelUnreadMentionCount
        /// </summary>
        [DataMember(Name="group_channel_unread_mention_count", EmitDefaultValue=false)]
        public decimal GroupChannelUnreadMentionCount { get; set; }

        /// <summary>
        /// Gets or Sets NonSuperGroupChannelUnreadMentionCount
        /// </summary>
        [DataMember(Name="non_super_group_channel_unread_mention_count", EmitDefaultValue=false)]
        public decimal NonSuperGroupChannelUnreadMentionCount { get; set; }

        /// <summary>
        /// Gets or Sets NonSuperGroupChannelInvitationCount
        /// </summary>
        [DataMember(Name="non_super_group_channel_invitation_count", EmitDefaultValue=false)]
        public decimal NonSuperGroupChannelInvitationCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse20019 {\n");
            sb.Append("  NonSuperGroupChannelUnreadMessageCount: ").Append(NonSuperGroupChannelUnreadMessageCount).Append("\n");
            sb.Append("  SuperGroupChannelUnreadMessageCount: ").Append(SuperGroupChannelUnreadMessageCount).Append("\n");
            sb.Append("  GroupChannelUnreadMessageCount: ").Append(GroupChannelUnreadMessageCount).Append("\n");
            sb.Append("  SuperGroupChannelInvitationCount: ").Append(SuperGroupChannelInvitationCount).Append("\n");
            sb.Append("  GroupChannelInvitationCount: ").Append(GroupChannelInvitationCount).Append("\n");
            sb.Append("  SuperGroupChannelUnreadMentionCount: ").Append(SuperGroupChannelUnreadMentionCount).Append("\n");
            sb.Append("  GroupChannelUnreadMentionCount: ").Append(GroupChannelUnreadMentionCount).Append("\n");
            sb.Append("  NonSuperGroupChannelUnreadMentionCount: ").Append(NonSuperGroupChannelUnreadMentionCount).Append("\n");
            sb.Append("  NonSuperGroupChannelInvitationCount: ").Append(NonSuperGroupChannelInvitationCount).Append("\n");
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
            return this.Equals(input as InlineResponse20019);
        }

        /// <summary>
        /// Returns true if InlineResponse20019 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineResponse20019 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse20019 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NonSuperGroupChannelUnreadMessageCount == input.NonSuperGroupChannelUnreadMessageCount ||
                    (this.NonSuperGroupChannelUnreadMessageCount != null &&
                    this.NonSuperGroupChannelUnreadMessageCount.Equals(input.NonSuperGroupChannelUnreadMessageCount))
                ) && 
                (
                    this.SuperGroupChannelUnreadMessageCount == input.SuperGroupChannelUnreadMessageCount ||
                    (this.SuperGroupChannelUnreadMessageCount != null &&
                    this.SuperGroupChannelUnreadMessageCount.Equals(input.SuperGroupChannelUnreadMessageCount))
                ) && 
                (
                    this.GroupChannelUnreadMessageCount == input.GroupChannelUnreadMessageCount ||
                    (this.GroupChannelUnreadMessageCount != null &&
                    this.GroupChannelUnreadMessageCount.Equals(input.GroupChannelUnreadMessageCount))
                ) && 
                (
                    this.SuperGroupChannelInvitationCount == input.SuperGroupChannelInvitationCount ||
                    (this.SuperGroupChannelInvitationCount != null &&
                    this.SuperGroupChannelInvitationCount.Equals(input.SuperGroupChannelInvitationCount))
                ) && 
                (
                    this.GroupChannelInvitationCount == input.GroupChannelInvitationCount ||
                    (this.GroupChannelInvitationCount != null &&
                    this.GroupChannelInvitationCount.Equals(input.GroupChannelInvitationCount))
                ) && 
                (
                    this.SuperGroupChannelUnreadMentionCount == input.SuperGroupChannelUnreadMentionCount ||
                    (this.SuperGroupChannelUnreadMentionCount != null &&
                    this.SuperGroupChannelUnreadMentionCount.Equals(input.SuperGroupChannelUnreadMentionCount))
                ) && 
                (
                    this.GroupChannelUnreadMentionCount == input.GroupChannelUnreadMentionCount ||
                    (this.GroupChannelUnreadMentionCount != null &&
                    this.GroupChannelUnreadMentionCount.Equals(input.GroupChannelUnreadMentionCount))
                ) && 
                (
                    this.NonSuperGroupChannelUnreadMentionCount == input.NonSuperGroupChannelUnreadMentionCount ||
                    (this.NonSuperGroupChannelUnreadMentionCount != null &&
                    this.NonSuperGroupChannelUnreadMentionCount.Equals(input.NonSuperGroupChannelUnreadMentionCount))
                ) && 
                (
                    this.NonSuperGroupChannelInvitationCount == input.NonSuperGroupChannelInvitationCount ||
                    (this.NonSuperGroupChannelInvitationCount != null &&
                    this.NonSuperGroupChannelInvitationCount.Equals(input.NonSuperGroupChannelInvitationCount))
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
                if (this.NonSuperGroupChannelUnreadMessageCount != null)
                    hashCode = hashCode * 59 + this.NonSuperGroupChannelUnreadMessageCount.GetHashCode();
                if (this.SuperGroupChannelUnreadMessageCount != null)
                    hashCode = hashCode * 59 + this.SuperGroupChannelUnreadMessageCount.GetHashCode();
                if (this.GroupChannelUnreadMessageCount != null)
                    hashCode = hashCode * 59 + this.GroupChannelUnreadMessageCount.GetHashCode();
                if (this.SuperGroupChannelInvitationCount != null)
                    hashCode = hashCode * 59 + this.SuperGroupChannelInvitationCount.GetHashCode();
                if (this.GroupChannelInvitationCount != null)
                    hashCode = hashCode * 59 + this.GroupChannelInvitationCount.GetHashCode();
                if (this.SuperGroupChannelUnreadMentionCount != null)
                    hashCode = hashCode * 59 + this.SuperGroupChannelUnreadMentionCount.GetHashCode();
                if (this.GroupChannelUnreadMentionCount != null)
                    hashCode = hashCode * 59 + this.GroupChannelUnreadMentionCount.GetHashCode();
                if (this.NonSuperGroupChannelUnreadMentionCount != null)
                    hashCode = hashCode * 59 + this.NonSuperGroupChannelUnreadMentionCount.GetHashCode();
                if (this.NonSuperGroupChannelInvitationCount != null)
                    hashCode = hashCode * 59 + this.NonSuperGroupChannelInvitationCount.GetHashCode();
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