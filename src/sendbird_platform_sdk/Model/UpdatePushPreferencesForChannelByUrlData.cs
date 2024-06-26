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
    /// UpdatePushPreferencesForChannelByUrlData
    /// </summary>
    [DataContract]
    public partial class UpdatePushPreferencesForChannelByUrlData :  IEquatable<UpdatePushPreferencesForChannelByUrlData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePushPreferencesForChannelByUrlData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdatePushPreferencesForChannelByUrlData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePushPreferencesForChannelByUrlData" /> class.
        /// </summary>
        /// <param name="pushTriggerOption">Determines the type of push notification trigger to apply to the speficied channel. Acceptable values are limited to the following:&lt;br /&gt;- default: the user&#39;s push notification trigger setting automatically applies to the channel. This is the default setting.&lt;br /&gt;- all: when disconnected from Sendbird server, the user receives notifications for all new messages in the channel including messages the user has been mentioned in.&lt;br /&gt;- mention_only: when disconnected from Sendbird server, the user only receives notifications for messages in the channel the user has been mentioned in.&lt;br /&gt;- off: the user doesn&#39;t receive any notifications in the channel. (required).</param>
        /// <param name="enable">(Deprecated) Determines whether notification messages for the user are delivered to the group channel. (default: true) (required).</param>
        /// <param name="pushSound">Specifies the name of a sound file to be played when a push notification is delivered to the specified channel. (required).</param>
        public UpdatePushPreferencesForChannelByUrlData(string pushTriggerOption = default, bool enable = default(bool), string pushSound = default)
        {
            // to ensure "pushTriggerOption" is required (not null)
            if (pushTriggerOption == null)
            {
                throw new InvalidDataException("pushTriggerOption is a required property for UpdatePushPreferencesForChannelByUrlData and cannot be null");
            }
            else
            {
                this.PushTriggerOption = pushTriggerOption;
            }

            // to ensure "enable" is required (not null)
            if (enable == null)
            {
                throw new InvalidDataException("enable is a required property for UpdatePushPreferencesForChannelByUrlData and cannot be null");
            }
            else
            {
                this.Enable = enable;
            }

            // to ensure "pushSound" is required (not null)
            if (pushSound == null)
            {
                throw new InvalidDataException("pushSound is a required property for UpdatePushPreferencesForChannelByUrlData and cannot be null");
            }
            else
            {
                this.PushSound = pushSound;
            }

        }

        /// <summary>
        /// Determines the type of push notification trigger to apply to the speficied channel. Acceptable values are limited to the following:&lt;br /&gt;- default: the user&#39;s push notification trigger setting automatically applies to the channel. This is the default setting.&lt;br /&gt;- all: when disconnected from Sendbird server, the user receives notifications for all new messages in the channel including messages the user has been mentioned in.&lt;br /&gt;- mention_only: when disconnected from Sendbird server, the user only receives notifications for messages in the channel the user has been mentioned in.&lt;br /&gt;- off: the user doesn&#39;t receive any notifications in the channel.
        /// </summary>
        /// <value>Determines the type of push notification trigger to apply to the speficied channel. Acceptable values are limited to the following:&lt;br /&gt;- default: the user&#39;s push notification trigger setting automatically applies to the channel. This is the default setting.&lt;br /&gt;- all: when disconnected from Sendbird server, the user receives notifications for all new messages in the channel including messages the user has been mentioned in.&lt;br /&gt;- mention_only: when disconnected from Sendbird server, the user only receives notifications for messages in the channel the user has been mentioned in.&lt;br /&gt;- off: the user doesn&#39;t receive any notifications in the channel.</value>
        [DataMember(Name="push_trigger_option", EmitDefaultValue=true)]
        public string PushTriggerOption { get; set; }

        /// <summary>
        /// (Deprecated) Determines whether notification messages for the user are delivered to the group channel. (default: true)
        /// </summary>
        /// <value>(Deprecated) Determines whether notification messages for the user are delivered to the group channel. (default: true)</value>
        [DataMember(Name="enable", EmitDefaultValue=true)]
        public bool Enable { get; set; }

        /// <summary>
        /// Specifies the name of a sound file to be played when a push notification is delivered to the specified channel.
        /// </summary>
        /// <value>Specifies the name of a sound file to be played when a push notification is delivered to the specified channel.</value>
        [DataMember(Name="push_sound", EmitDefaultValue=true)]
        public string PushSound { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdatePushPreferencesForChannelByUrlData {\n");
            sb.Append("  PushTriggerOption: ").Append(PushTriggerOption).Append("\n");
            sb.Append("  Enable: ").Append(Enable).Append("\n");
            sb.Append("  PushSound: ").Append(PushSound).Append("\n");
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
            return this.Equals(input as UpdatePushPreferencesForChannelByUrlData);
        }

        /// <summary>
        /// Returns true if UpdatePushPreferencesForChannelByUrlData instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdatePushPreferencesForChannelByUrlData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdatePushPreferencesForChannelByUrlData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PushTriggerOption == input.PushTriggerOption ||
                    (this.PushTriggerOption != null &&
                    this.PushTriggerOption.Equals(input.PushTriggerOption))
                ) && 
                (
                    this.Enable == input.Enable ||
                    (this.Enable != null &&
                    this.Enable.Equals(input.Enable))
                ) && 
                (
                    this.PushSound == input.PushSound ||
                    (this.PushSound != null &&
                    this.PushSound.Equals(input.PushSound))
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
                if (this.PushTriggerOption != null)
                    hashCode = hashCode * 59 + this.PushTriggerOption.GetHashCode();
                if (this.Enable != null)
                    hashCode = hashCode * 59 + this.Enable.GetHashCode();
                if (this.PushSound != null)
                    hashCode = hashCode * 59 + this.PushSound.GetHashCode();
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
