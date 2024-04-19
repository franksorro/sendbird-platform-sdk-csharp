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
    /// OcViewMuteByIdResponse
    /// </summary>
    [DataContract]
    public partial class OcViewMuteByIdResponse :  IEquatable<OcViewMuteByIdResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OcViewMuteByIdResponse" /> class.
        /// </summary>
        /// <param name="isMuted">isMuted.</param>
        /// <param name="remainingDuration">remainingDuration.</param>
        /// <param name="startAt">startAt.</param>
        /// <param name="endAt">endAt.</param>
        /// <param name="description">description.</param>
        public OcViewMuteByIdResponse(bool isMuted = default(bool), decimal remainingDuration = default(decimal), decimal startAt = default(decimal), decimal endAt = default(decimal), string description = default)
        {
            this.IsMuted = isMuted;
            this.RemainingDuration = remainingDuration;
            this.StartAt = startAt;
            this.EndAt = endAt;
            this.Description = description;
        }

        /// <summary>
        /// Gets or Sets IsMuted
        /// </summary>
        [DataMember(Name="is_muted", EmitDefaultValue=false)]
        public bool IsMuted { get; set; }

        /// <summary>
        /// Gets or Sets RemainingDuration
        /// </summary>
        [DataMember(Name="remaining_duration", EmitDefaultValue=false)]
        public decimal RemainingDuration { get; set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OcViewMuteByIdResponse {\n");
            sb.Append("  IsMuted: ").Append(IsMuted).Append("\n");
            sb.Append("  RemainingDuration: ").Append(RemainingDuration).Append("\n");
            sb.Append("  StartAt: ").Append(StartAt).Append("\n");
            sb.Append("  EndAt: ").Append(EndAt).Append("\n");
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
            return this.Equals(input as OcViewMuteByIdResponse);
        }

        /// <summary>
        /// Returns true if OcViewMuteByIdResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of OcViewMuteByIdResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OcViewMuteByIdResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsMuted == input.IsMuted ||
                    (this.IsMuted != null &&
                    this.IsMuted.Equals(input.IsMuted))
                ) && 
                (
                    this.RemainingDuration == input.RemainingDuration ||
                    (this.RemainingDuration != null &&
                    this.RemainingDuration.Equals(input.RemainingDuration))
                ) && 
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
                if (this.IsMuted != null)
                    hashCode = hashCode * 59 + this.IsMuted.GetHashCode();
                if (this.RemainingDuration != null)
                    hashCode = hashCode * 59 + this.RemainingDuration.GetHashCode();
                if (this.StartAt != null)
                    hashCode = hashCode * 59 + this.StartAt.GetHashCode();
                if (this.EndAt != null)
                    hashCode = hashCode * 59 + this.EndAt.GetHashCode();
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
