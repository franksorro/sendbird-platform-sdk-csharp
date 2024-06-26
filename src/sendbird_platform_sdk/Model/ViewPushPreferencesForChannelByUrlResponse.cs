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
    /// ViewPushPreferencesForChannelByUrlResponse
    /// </summary>
    [DataContract]
    public partial class ViewPushPreferencesForChannelByUrlResponse :  IEquatable<ViewPushPreferencesForChannelByUrlResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewPushPreferencesForChannelByUrlResponse" /> class.
        /// </summary>
        /// <param name="pushTriggerOption">pushTriggerOption.</param>
        /// <param name="doNotDisturb">doNotDisturb.</param>
        /// <param name="startHour">startHour.</param>
        /// <param name="startMin">startMin.</param>
        /// <param name="endHour">endHour.</param>
        /// <param name="endMin">endMin.</param>
        /// <param name="snoozeEnabled">snoozeEnabled.</param>
        /// <param name="snoozeStartTs">snoozeStartTs.</param>
        /// <param name="snoozeEndTs">snoozeEndTs.</param>
        /// <param name="timezone">timezone.</param>
        /// <param name="pushSound">pushSound.</param>
        /// <param name="enable">enable.</param>
        public ViewPushPreferencesForChannelByUrlResponse(string pushTriggerOption = default, bool doNotDisturb = default(bool), decimal startHour = default(decimal), decimal startMin = default(decimal), decimal endHour = default(decimal), decimal endMin = default(decimal), bool snoozeEnabled = default(bool), decimal snoozeStartTs = default(decimal), decimal snoozeEndTs = default(decimal), string timezone = default, string pushSound = default, bool enable = default(bool))
        {
            this.PushTriggerOption = pushTriggerOption;
            this.DoNotDisturb = doNotDisturb;
            this.StartHour = startHour;
            this.StartMin = startMin;
            this.EndHour = endHour;
            this.EndMin = endMin;
            this.SnoozeEnabled = snoozeEnabled;
            this.SnoozeStartTs = snoozeStartTs;
            this.SnoozeEndTs = snoozeEndTs;
            this.Timezone = timezone;
            this.PushSound = pushSound;
            this.Enable = enable;
        }

        /// <summary>
        /// Gets or Sets PushTriggerOption
        /// </summary>
        [DataMember(Name="push_trigger_option", EmitDefaultValue=false)]
        public string PushTriggerOption { get; set; }

        /// <summary>
        /// Gets or Sets DoNotDisturb
        /// </summary>
        [DataMember(Name="do_not_disturb", EmitDefaultValue=false)]
        public bool DoNotDisturb { get; set; }

        /// <summary>
        /// Gets or Sets StartHour
        /// </summary>
        [DataMember(Name="start_hour", EmitDefaultValue=false)]
        public decimal StartHour { get; set; }

        /// <summary>
        /// Gets or Sets StartMin
        /// </summary>
        [DataMember(Name="start_min", EmitDefaultValue=false)]
        public decimal StartMin { get; set; }

        /// <summary>
        /// Gets or Sets EndHour
        /// </summary>
        [DataMember(Name="end_hour", EmitDefaultValue=false)]
        public decimal EndHour { get; set; }

        /// <summary>
        /// Gets or Sets EndMin
        /// </summary>
        [DataMember(Name="end_min", EmitDefaultValue=false)]
        public decimal EndMin { get; set; }

        /// <summary>
        /// Gets or Sets SnoozeEnabled
        /// </summary>
        [DataMember(Name="snooze_enabled", EmitDefaultValue=false)]
        public bool SnoozeEnabled { get; set; }

        /// <summary>
        /// Gets or Sets SnoozeStartTs
        /// </summary>
        [DataMember(Name="snooze_start_ts", EmitDefaultValue=false)]
        public decimal SnoozeStartTs { get; set; }

        /// <summary>
        /// Gets or Sets SnoozeEndTs
        /// </summary>
        [DataMember(Name="snooze_end_ts", EmitDefaultValue=false)]
        public decimal SnoozeEndTs { get; set; }

        /// <summary>
        /// Gets or Sets Timezone
        /// </summary>
        [DataMember(Name="timezone", EmitDefaultValue=false)]
        public string Timezone { get; set; }

        /// <summary>
        /// Gets or Sets PushSound
        /// </summary>
        [DataMember(Name="push_sound", EmitDefaultValue=false)]
        public string PushSound { get; set; }

        /// <summary>
        /// Gets or Sets Enable
        /// </summary>
        [DataMember(Name="enable", EmitDefaultValue=false)]
        public bool Enable { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ViewPushPreferencesForChannelByUrlResponse {\n");
            sb.Append("  PushTriggerOption: ").Append(PushTriggerOption).Append("\n");
            sb.Append("  DoNotDisturb: ").Append(DoNotDisturb).Append("\n");
            sb.Append("  StartHour: ").Append(StartHour).Append("\n");
            sb.Append("  StartMin: ").Append(StartMin).Append("\n");
            sb.Append("  EndHour: ").Append(EndHour).Append("\n");
            sb.Append("  EndMin: ").Append(EndMin).Append("\n");
            sb.Append("  SnoozeEnabled: ").Append(SnoozeEnabled).Append("\n");
            sb.Append("  SnoozeStartTs: ").Append(SnoozeStartTs).Append("\n");
            sb.Append("  SnoozeEndTs: ").Append(SnoozeEndTs).Append("\n");
            sb.Append("  Timezone: ").Append(Timezone).Append("\n");
            sb.Append("  PushSound: ").Append(PushSound).Append("\n");
            sb.Append("  Enable: ").Append(Enable).Append("\n");
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
            return this.Equals(input as ViewPushPreferencesForChannelByUrlResponse);
        }

        /// <summary>
        /// Returns true if ViewPushPreferencesForChannelByUrlResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ViewPushPreferencesForChannelByUrlResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ViewPushPreferencesForChannelByUrlResponse input)
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
                    this.DoNotDisturb == input.DoNotDisturb ||
                    (this.DoNotDisturb != null &&
                    this.DoNotDisturb.Equals(input.DoNotDisturb))
                ) && 
                (
                    this.StartHour == input.StartHour ||
                    (this.StartHour != null &&
                    this.StartHour.Equals(input.StartHour))
                ) && 
                (
                    this.StartMin == input.StartMin ||
                    (this.StartMin != null &&
                    this.StartMin.Equals(input.StartMin))
                ) && 
                (
                    this.EndHour == input.EndHour ||
                    (this.EndHour != null &&
                    this.EndHour.Equals(input.EndHour))
                ) && 
                (
                    this.EndMin == input.EndMin ||
                    (this.EndMin != null &&
                    this.EndMin.Equals(input.EndMin))
                ) && 
                (
                    this.SnoozeEnabled == input.SnoozeEnabled ||
                    (this.SnoozeEnabled != null &&
                    this.SnoozeEnabled.Equals(input.SnoozeEnabled))
                ) && 
                (
                    this.SnoozeStartTs == input.SnoozeStartTs ||
                    (this.SnoozeStartTs != null &&
                    this.SnoozeStartTs.Equals(input.SnoozeStartTs))
                ) && 
                (
                    this.SnoozeEndTs == input.SnoozeEndTs ||
                    (this.SnoozeEndTs != null &&
                    this.SnoozeEndTs.Equals(input.SnoozeEndTs))
                ) && 
                (
                    this.Timezone == input.Timezone ||
                    (this.Timezone != null &&
                    this.Timezone.Equals(input.Timezone))
                ) && 
                (
                    this.PushSound == input.PushSound ||
                    (this.PushSound != null &&
                    this.PushSound.Equals(input.PushSound))
                ) && 
                (
                    this.Enable == input.Enable ||
                    (this.Enable != null &&
                    this.Enable.Equals(input.Enable))
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
                if (this.DoNotDisturb != null)
                    hashCode = hashCode * 59 + this.DoNotDisturb.GetHashCode();
                if (this.StartHour != null)
                    hashCode = hashCode * 59 + this.StartHour.GetHashCode();
                if (this.StartMin != null)
                    hashCode = hashCode * 59 + this.StartMin.GetHashCode();
                if (this.EndHour != null)
                    hashCode = hashCode * 59 + this.EndHour.GetHashCode();
                if (this.EndMin != null)
                    hashCode = hashCode * 59 + this.EndMin.GetHashCode();
                if (this.SnoozeEnabled != null)
                    hashCode = hashCode * 59 + this.SnoozeEnabled.GetHashCode();
                if (this.SnoozeStartTs != null)
                    hashCode = hashCode * 59 + this.SnoozeStartTs.GetHashCode();
                if (this.SnoozeEndTs != null)
                    hashCode = hashCode * 59 + this.SnoozeEndTs.GetHashCode();
                if (this.Timezone != null)
                    hashCode = hashCode * 59 + this.Timezone.GetHashCode();
                if (this.PushSound != null)
                    hashCode = hashCode * 59 + this.PushSound.GetHashCode();
                if (this.Enable != null)
                    hashCode = hashCode * 59 + this.Enable.GetHashCode();
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
