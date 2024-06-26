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
    /// SendBirdOpenChannel
    /// </summary>
    [DataContract]
    public partial class SendBirdOpenChannel :  IEquatable<SendBirdOpenChannel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SendBirdOpenChannel" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="customType">customType.</param>
        /// <param name="channelUrl">channelUrl.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="coverUrl">coverUrl.</param>
        /// <param name="creator">creator.</param>
        /// <param name="data">data.</param>
        /// <param name="isDynamicPartitioned">isDynamicPartitioned.</param>
        /// <param name="isEphemeral">isEphemeral.</param>
        /// <param name="isFrozen">isFrozen.</param>
        /// <param name="maxLengthMessage">maxLengthMessage.</param>
        /// <param name="operators">operators.</param>
        /// <param name="participantCount">participantCount.</param>
        /// <param name="freeze">freeze.</param>
        public SendBirdOpenChannel(string name = default, string customType = default, string channelUrl = default, decimal createdAt = default(decimal), string coverUrl = default, SendBirdUser creator = default(SendBirdUser), string data = default, bool isDynamicPartitioned = default(bool), bool isEphemeral = default(bool), bool isFrozen = default(bool), decimal maxLengthMessage = default(decimal), List<SendBirdUser> operators = default(List<SendBirdUser>), decimal participantCount = default(decimal), bool freeze = default(bool))
        {
            this.Name = name;
            this.CustomType = customType;
            this.ChannelUrl = channelUrl;
            this.CreatedAt = createdAt;
            this.CoverUrl = coverUrl;
            this.Creator = creator;
            this.Data = data;
            this.IsDynamicPartitioned = isDynamicPartitioned;
            this.IsEphemeral = isEphemeral;
            this.IsFrozen = isFrozen;
            this.MaxLengthMessage = maxLengthMessage;
            this.Operators = operators;
            this.ParticipantCount = participantCount;
            this.Freeze = freeze;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets CustomType
        /// </summary>
        [DataMember(Name="custom_type", EmitDefaultValue=false)]
        public string CustomType { get; set; }

        /// <summary>
        /// Gets or Sets ChannelUrl
        /// </summary>
        [DataMember(Name="channel_url", EmitDefaultValue=false)]
        public string ChannelUrl { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public decimal CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets CoverUrl
        /// </summary>
        [DataMember(Name="cover_url", EmitDefaultValue=false)]
        public string CoverUrl { get; set; }

        /// <summary>
        /// Gets or Sets Creator
        /// </summary>
        [DataMember(Name="creator", EmitDefaultValue=false)]
        public SendBirdUser Creator { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public string Data { get; set; }

        /// <summary>
        /// Gets or Sets IsDynamicPartitioned
        /// </summary>
        [DataMember(Name="is_dynamic_partitioned", EmitDefaultValue=false)]
        public bool IsDynamicPartitioned { get; set; }

        /// <summary>
        /// Gets or Sets IsEphemeral
        /// </summary>
        [DataMember(Name="is_ephemeral", EmitDefaultValue=false)]
        public bool IsEphemeral { get; set; }

        /// <summary>
        /// Gets or Sets IsFrozen
        /// </summary>
        [DataMember(Name="is_frozen", EmitDefaultValue=false)]
        public bool IsFrozen { get; set; }

        /// <summary>
        /// Gets or Sets MaxLengthMessage
        /// </summary>
        [DataMember(Name="max_length_message", EmitDefaultValue=false)]
        public decimal MaxLengthMessage { get; set; }

        /// <summary>
        /// Gets or Sets Operators
        /// </summary>
        [DataMember(Name="operators", EmitDefaultValue=false)]
        public List<SendBirdUser> Operators { get; set; }

        /// <summary>
        /// Gets or Sets ParticipantCount
        /// </summary>
        [DataMember(Name="participant_count", EmitDefaultValue=false)]
        public decimal ParticipantCount { get; set; }

        /// <summary>
        /// Gets or Sets Freeze
        /// </summary>
        [DataMember(Name="freeze", EmitDefaultValue=false)]
        public bool Freeze { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SendBirdOpenChannel {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CustomType: ").Append(CustomType).Append("\n");
            sb.Append("  ChannelUrl: ").Append(ChannelUrl).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  CoverUrl: ").Append(CoverUrl).Append("\n");
            sb.Append("  Creator: ").Append(Creator).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  IsDynamicPartitioned: ").Append(IsDynamicPartitioned).Append("\n");
            sb.Append("  IsEphemeral: ").Append(IsEphemeral).Append("\n");
            sb.Append("  IsFrozen: ").Append(IsFrozen).Append("\n");
            sb.Append("  MaxLengthMessage: ").Append(MaxLengthMessage).Append("\n");
            sb.Append("  Operators: ").Append(Operators).Append("\n");
            sb.Append("  ParticipantCount: ").Append(ParticipantCount).Append("\n");
            sb.Append("  Freeze: ").Append(Freeze).Append("\n");
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
            return this.Equals(input as SendBirdOpenChannel);
        }

        /// <summary>
        /// Returns true if SendBirdOpenChannel instances are equal
        /// </summary>
        /// <param name="input">Instance of SendBirdOpenChannel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SendBirdOpenChannel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.CustomType == input.CustomType ||
                    (this.CustomType != null &&
                    this.CustomType.Equals(input.CustomType))
                ) && 
                (
                    this.ChannelUrl == input.ChannelUrl ||
                    (this.ChannelUrl != null &&
                    this.ChannelUrl.Equals(input.ChannelUrl))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.CoverUrl == input.CoverUrl ||
                    (this.CoverUrl != null &&
                    this.CoverUrl.Equals(input.CoverUrl))
                ) && 
                (
                    this.Creator == input.Creator ||
                    (this.Creator != null &&
                    this.Creator.Equals(input.Creator))
                ) && 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
                ) && 
                (
                    this.IsDynamicPartitioned == input.IsDynamicPartitioned ||
                    (this.IsDynamicPartitioned != null &&
                    this.IsDynamicPartitioned.Equals(input.IsDynamicPartitioned))
                ) && 
                (
                    this.IsEphemeral == input.IsEphemeral ||
                    (this.IsEphemeral != null &&
                    this.IsEphemeral.Equals(input.IsEphemeral))
                ) && 
                (
                    this.IsFrozen == input.IsFrozen ||
                    (this.IsFrozen != null &&
                    this.IsFrozen.Equals(input.IsFrozen))
                ) && 
                (
                    this.MaxLengthMessage == input.MaxLengthMessage ||
                    (this.MaxLengthMessage != null &&
                    this.MaxLengthMessage.Equals(input.MaxLengthMessage))
                ) && 
                (
                    this.Operators == input.Operators ||
                    this.Operators != null &&
                    input.Operators != null &&
                    this.Operators.SequenceEqual(input.Operators)
                ) && 
                (
                    this.ParticipantCount == input.ParticipantCount ||
                    (this.ParticipantCount != null &&
                    this.ParticipantCount.Equals(input.ParticipantCount))
                ) && 
                (
                    this.Freeze == input.Freeze ||
                    (this.Freeze != null &&
                    this.Freeze.Equals(input.Freeze))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.CustomType != null)
                    hashCode = hashCode * 59 + this.CustomType.GetHashCode();
                if (this.ChannelUrl != null)
                    hashCode = hashCode * 59 + this.ChannelUrl.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.CoverUrl != null)
                    hashCode = hashCode * 59 + this.CoverUrl.GetHashCode();
                if (this.Creator != null)
                    hashCode = hashCode * 59 + this.Creator.GetHashCode();
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
                if (this.IsDynamicPartitioned != null)
                    hashCode = hashCode * 59 + this.IsDynamicPartitioned.GetHashCode();
                if (this.IsEphemeral != null)
                    hashCode = hashCode * 59 + this.IsEphemeral.GetHashCode();
                if (this.IsFrozen != null)
                    hashCode = hashCode * 59 + this.IsFrozen.GetHashCode();
                if (this.MaxLengthMessage != null)
                    hashCode = hashCode * 59 + this.MaxLengthMessage.GetHashCode();
                if (this.Operators != null)
                    hashCode = hashCode * 59 + this.Operators.GetHashCode();
                if (this.ParticipantCount != null)
                    hashCode = hashCode * 59 + this.ParticipantCount.GetHashCode();
                if (this.Freeze != null)
                    hashCode = hashCode * 59 + this.Freeze.GetHashCode();
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
