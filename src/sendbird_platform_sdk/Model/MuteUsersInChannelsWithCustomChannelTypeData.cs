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
    /// MuteUsersInChannelsWithCustomChannelTypeData
    /// </summary>
    [DataContract]
    public partial class MuteUsersInChannelsWithCustomChannelTypeData :  IEquatable<MuteUsersInChannelsWithCustomChannelTypeData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MuteUsersInChannelsWithCustomChannelTypeData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MuteUsersInChannelsWithCustomChannelTypeData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MuteUsersInChannelsWithCustomChannelTypeData" /> class.
        /// </summary>
        /// <param name="userIds">userIds (required).</param>
        /// <param name="seconds">seconds.</param>
        /// <param name="description">description.</param>
        /// <param name="onDemandUpsert">onDemandUpsert.</param>
        public MuteUsersInChannelsWithCustomChannelTypeData(List<string> userIds = default(List<string>), decimal seconds = default(decimal), string description = default(string), bool onDemandUpsert = default(bool))
        {
            // to ensure "userIds" is required (not null)
            if (userIds == null)
            {
                throw new InvalidDataException("userIds is a required property for MuteUsersInChannelsWithCustomChannelTypeData and cannot be null");
            }
            else
            {
                this.UserIds = userIds;
            }

            this.Seconds = seconds;
            this.Description = description;
            this.OnDemandUpsert = onDemandUpsert;
        }

        /// <summary>
        /// Gets or Sets UserIds
        /// </summary>
        [DataMember(Name="user_ids", EmitDefaultValue=true)]
        public List<string> UserIds { get; set; }

        /// <summary>
        /// Gets or Sets Seconds
        /// </summary>
        [DataMember(Name="seconds", EmitDefaultValue=false)]
        public decimal Seconds { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets OnDemandUpsert
        /// </summary>
        [DataMember(Name="on_demand_upsert", EmitDefaultValue=false)]
        public bool OnDemandUpsert { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MuteUsersInChannelsWithCustomChannelTypeData {\n");
            sb.Append("  UserIds: ").Append(UserIds).Append("\n");
            sb.Append("  Seconds: ").Append(Seconds).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  OnDemandUpsert: ").Append(OnDemandUpsert).Append("\n");
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
            return this.Equals(input as MuteUsersInChannelsWithCustomChannelTypeData);
        }

        /// <summary>
        /// Returns true if MuteUsersInChannelsWithCustomChannelTypeData instances are equal
        /// </summary>
        /// <param name="input">Instance of MuteUsersInChannelsWithCustomChannelTypeData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MuteUsersInChannelsWithCustomChannelTypeData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UserIds == input.UserIds ||
                    this.UserIds != null &&
                    input.UserIds != null &&
                    this.UserIds.SequenceEqual(input.UserIds)
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
                ) && 
                (
                    this.OnDemandUpsert == input.OnDemandUpsert ||
                    (this.OnDemandUpsert != null &&
                    this.OnDemandUpsert.Equals(input.OnDemandUpsert))
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
                if (this.UserIds != null)
                    hashCode = hashCode * 59 + this.UserIds.GetHashCode();
                if (this.Seconds != null)
                    hashCode = hashCode * 59 + this.Seconds.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.OnDemandUpsert != null)
                    hashCode = hashCode * 59 + this.OnDemandUpsert.GetHashCode();
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
