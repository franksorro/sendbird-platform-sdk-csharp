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
    /// RemoveReactionFromAMessageResponse
    /// </summary>
    [DataContract]
    public partial class RemoveReactionFromAMessageResponse :  IEquatable<RemoveReactionFromAMessageResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveReactionFromAMessageResponse" /> class.
        /// </summary>
        /// <param name="reaction">reaction.</param>
        /// <param name="userId">userId.</param>
        /// <param name="success">success.</param>
        /// <param name="msgId">msgId.</param>
        /// <param name="updatedAt">updatedAt.</param>
        /// <param name="operation">operation.</param>
        public RemoveReactionFromAMessageResponse(string reaction = default, decimal userId = default(decimal), bool success = default(bool), decimal msgId = default(decimal), decimal updatedAt = default(decimal), string operation = default)
        {
            this.Reaction = reaction;
            this.UserId = userId;
            this.Success = success;
            this.MsgId = msgId;
            this.UpdatedAt = updatedAt;
            this.Operation = operation;
        }

        /// <summary>
        /// Gets or Sets Reaction
        /// </summary>
        [DataMember(Name="reaction", EmitDefaultValue=false)]
        public string Reaction { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="user_id", EmitDefaultValue=false)]
        public decimal UserId { get; set; }

        /// <summary>
        /// Gets or Sets Success
        /// </summary>
        [DataMember(Name="success", EmitDefaultValue=false)]
        public bool Success { get; set; }

        /// <summary>
        /// Gets or Sets MsgId
        /// </summary>
        [DataMember(Name="msg_id", EmitDefaultValue=false)]
        public decimal MsgId { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        public decimal UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Operation
        /// </summary>
        [DataMember(Name="operation", EmitDefaultValue=false)]
        public string Operation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RemoveReactionFromAMessageResponse {\n");
            sb.Append("  Reaction: ").Append(Reaction).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
            sb.Append("  MsgId: ").Append(MsgId).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Operation: ").Append(Operation).Append("\n");
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
            return this.Equals(input as RemoveReactionFromAMessageResponse);
        }

        /// <summary>
        /// Returns true if RemoveReactionFromAMessageResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of RemoveReactionFromAMessageResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RemoveReactionFromAMessageResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Reaction == input.Reaction ||
                    (this.Reaction != null &&
                    this.Reaction.Equals(input.Reaction))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.Success == input.Success ||
                    (this.Success != null &&
                    this.Success.Equals(input.Success))
                ) && 
                (
                    this.MsgId == input.MsgId ||
                    (this.MsgId != null &&
                    this.MsgId.Equals(input.MsgId))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.Operation == input.Operation ||
                    (this.Operation != null &&
                    this.Operation.Equals(input.Operation))
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
                if (this.Reaction != null)
                    hashCode = hashCode * 59 + this.Reaction.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.Success != null)
                    hashCode = hashCode * 59 + this.Success.GetHashCode();
                if (this.MsgId != null)
                    hashCode = hashCode * 59 + this.MsgId.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.Operation != null)
                    hashCode = hashCode * 59 + this.Operation.GetHashCode();
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
