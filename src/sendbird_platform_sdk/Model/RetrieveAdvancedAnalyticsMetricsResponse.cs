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
    /// RetrieveAdvancedAnalyticsMetricsResponse
    /// </summary>
    [DataContract]
    public partial class RetrieveAdvancedAnalyticsMetricsResponse :  IEquatable<RetrieveAdvancedAnalyticsMetricsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RetrieveAdvancedAnalyticsMetricsResponse" /> class.
        /// </summary>
        /// <param name="segments">segments.</param>
        /// <param name="date">date.</param>
        /// <param name="value">value.</param>
        /// <param name="channelType">channelType.</param>
        /// <param name="customChannelType">customChannelType.</param>
        /// <param name="customMessageType">customMessageType.</param>
        public RetrieveAdvancedAnalyticsMetricsResponse(string segments = default, string date = default, decimal value = default(decimal), string channelType = default, string customChannelType = default, string customMessageType = default)
        {
            this.Segments = segments;
            this.Date = date;
            this.Value = value;
            this.ChannelType = channelType;
            this.CustomChannelType = customChannelType;
            this.CustomMessageType = customMessageType;
        }

        /// <summary>
        /// Gets or Sets Segments
        /// </summary>
        [DataMember(Name="segments", EmitDefaultValue=false)]
        public string Segments { get; set; }

        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name="date", EmitDefaultValue=false)]
        public string Date { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public decimal Value { get; set; }

        /// <summary>
        /// Gets or Sets ChannelType
        /// </summary>
        [DataMember(Name="channel_type", EmitDefaultValue=false)]
        public string ChannelType { get; set; }

        /// <summary>
        /// Gets or Sets CustomChannelType
        /// </summary>
        [DataMember(Name="custom_channel_type", EmitDefaultValue=false)]
        public string CustomChannelType { get; set; }

        /// <summary>
        /// Gets or Sets CustomMessageType
        /// </summary>
        [DataMember(Name="custom_message_type", EmitDefaultValue=false)]
        public string CustomMessageType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RetrieveAdvancedAnalyticsMetricsResponse {\n");
            sb.Append("  Segments: ").Append(Segments).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  ChannelType: ").Append(ChannelType).Append("\n");
            sb.Append("  CustomChannelType: ").Append(CustomChannelType).Append("\n");
            sb.Append("  CustomMessageType: ").Append(CustomMessageType).Append("\n");
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
            return this.Equals(input as RetrieveAdvancedAnalyticsMetricsResponse);
        }

        /// <summary>
        /// Returns true if RetrieveAdvancedAnalyticsMetricsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of RetrieveAdvancedAnalyticsMetricsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RetrieveAdvancedAnalyticsMetricsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Segments == input.Segments ||
                    (this.Segments != null &&
                    this.Segments.Equals(input.Segments))
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.ChannelType == input.ChannelType ||
                    (this.ChannelType != null &&
                    this.ChannelType.Equals(input.ChannelType))
                ) && 
                (
                    this.CustomChannelType == input.CustomChannelType ||
                    (this.CustomChannelType != null &&
                    this.CustomChannelType.Equals(input.CustomChannelType))
                ) && 
                (
                    this.CustomMessageType == input.CustomMessageType ||
                    (this.CustomMessageType != null &&
                    this.CustomMessageType.Equals(input.CustomMessageType))
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
                if (this.Segments != null)
                    hashCode = hashCode * 59 + this.Segments.GetHashCode();
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.ChannelType != null)
                    hashCode = hashCode * 59 + this.ChannelType.GetHashCode();
                if (this.CustomChannelType != null)
                    hashCode = hashCode * 59 + this.CustomChannelType.GetHashCode();
                if (this.CustomMessageType != null)
                    hashCode = hashCode * 59 + this.CustomMessageType.GetHashCode();
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
