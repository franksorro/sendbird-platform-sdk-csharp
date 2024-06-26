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
    /// ChooseWhichEventsToSubscribeToData
    /// </summary>
    [DataContract]
    public partial class ChooseWhichEventsToSubscribeToData :  IEquatable<ChooseWhichEventsToSubscribeToData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChooseWhichEventsToSubscribeToData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChooseWhichEventsToSubscribeToData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChooseWhichEventsToSubscribeToData" /> class.
        /// </summary>
        /// <param name="enabled">Determines whether webhooks are turned on in your Sendbird application or not. (Default: false) (required).</param>
        /// <param name="url">Specifies the URL of your webhook server to receive payloads for events. (required).</param>
        /// <param name="includeMembers">Determines whether to include the information on the members of group channels in payloads. (Default: false).</param>
        /// <param name="enabledEvents">Specifies an array of one or more [events](#2-webhook-events) for your webhook server to subscribe to. If set to an asterisk () only, the server will subscribe to all supported events. If set to an empty array, the server will unsubscribe from all (which indicates turning off webhooks)..</param>
        public ChooseWhichEventsToSubscribeToData(bool enabled = default(bool), string url = default, bool includeMembers = default(bool), List<string> enabledEvents = default)
        {
            // to ensure "enabled" is required (not null)
            if (enabled == null)
            {
                throw new InvalidDataException("enabled is a required property for ChooseWhichEventsToSubscribeToData and cannot be null");
            }
            else
            {
                this.Enabled = enabled;
            }

            // to ensure "url" is required (not null)
            if (url == null)
            {
                throw new InvalidDataException("url is a required property for ChooseWhichEventsToSubscribeToData and cannot be null");
            }
            else
            {
                this.Url = url;
            }

            this.IncludeMembers = includeMembers;
            this.EnabledEvents = enabledEvents;
        }

        /// <summary>
        /// Determines whether webhooks are turned on in your Sendbird application or not. (Default: false)
        /// </summary>
        /// <value>Determines whether webhooks are turned on in your Sendbird application or not. (Default: false)</value>
        [DataMember(Name="enabled", EmitDefaultValue=true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Specifies the URL of your webhook server to receive payloads for events.
        /// </summary>
        /// <value>Specifies the URL of your webhook server to receive payloads for events.</value>
        [DataMember(Name="url", EmitDefaultValue=true)]
        public string Url { get; set; }

        /// <summary>
        /// Determines whether to include the information on the members of group channels in payloads. (Default: false)
        /// </summary>
        /// <value>Determines whether to include the information on the members of group channels in payloads. (Default: false)</value>
        [DataMember(Name="include_members", EmitDefaultValue=false)]
        public bool IncludeMembers { get; set; }

        /// <summary>
        /// Specifies an array of one or more [events](#2-webhook-events) for your webhook server to subscribe to. If set to an asterisk () only, the server will subscribe to all supported events. If set to an empty array, the server will unsubscribe from all (which indicates turning off webhooks).
        /// </summary>
        /// <value>Specifies an array of one or more [events](#2-webhook-events) for your webhook server to subscribe to. If set to an asterisk () only, the server will subscribe to all supported events. If set to an empty array, the server will unsubscribe from all (which indicates turning off webhooks).</value>
        [DataMember(Name="enabled_events", EmitDefaultValue=false)]
        public List<string> EnabledEvents { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChooseWhichEventsToSubscribeToData {\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  IncludeMembers: ").Append(IncludeMembers).Append("\n");
            sb.Append("  EnabledEvents: ").Append(EnabledEvents).Append("\n");
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
            return this.Equals(input as ChooseWhichEventsToSubscribeToData);
        }

        /// <summary>
        /// Returns true if ChooseWhichEventsToSubscribeToData instances are equal
        /// </summary>
        /// <param name="input">Instance of ChooseWhichEventsToSubscribeToData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChooseWhichEventsToSubscribeToData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.IncludeMembers == input.IncludeMembers ||
                    (this.IncludeMembers != null &&
                    this.IncludeMembers.Equals(input.IncludeMembers))
                ) && 
                (
                    this.EnabledEvents == input.EnabledEvents ||
                    this.EnabledEvents != null &&
                    input.EnabledEvents != null &&
                    this.EnabledEvents.SequenceEqual(input.EnabledEvents)
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
                if (this.Enabled != null)
                    hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.IncludeMembers != null)
                    hashCode = hashCode * 59 + this.IncludeMembers.GetHashCode();
                if (this.EnabledEvents != null)
                    hashCode = hashCode * 59 + this.EnabledEvents.GetHashCode();
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
