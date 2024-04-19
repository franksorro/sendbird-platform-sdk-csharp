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
    /// ResetPushPreferencesResponse
    /// </summary>
    [DataContract]
    public partial class ResetPushPreferencesResponse :  IEquatable<ResetPushPreferencesResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResetPushPreferencesResponse" /> class.
        /// </summary>
        /// <param name="snoozeStartTs">snoozeStartTs.</param>
        /// <param name="startHour">startHour.</param>
        /// <param name="snoozeEnabled">snoozeEnabled.</param>
        /// <param name="endMin">endMin.</param>
        /// <param name="timezone">timezone.</param>
        /// <param name="blockPushFromBots">blockPushFromBots.</param>
        /// <param name="pushBlockedBotIds">pushBlockedBotIds.</param>
        /// <param name="startMin">startMin.</param>
        /// <param name="snoozeEndTs">snoozeEndTs.</param>
        /// <param name="doNotDisturb">doNotDisturb.</param>
        /// <param name="endHour">endHour.</param>
        /// <param name="enablePushForReplies">enablePushForReplies.</param>
        /// <param name="pushSound">pushSound.</param>
        /// <param name="pushTriggerOption">pushTriggerOption.</param>
        public ResetPushPreferencesResponse(string snoozeStartTs = default, decimal startHour = default(decimal), bool snoozeEnabled = default(bool), decimal endMin = default(decimal), string timezone = default, bool blockPushFromBots = default(bool), List<decimal> pushBlockedBotIds = default(List<decimal>), decimal startMin = default(decimal), string snoozeEndTs = default, bool doNotDisturb = default(bool), decimal endHour = default(decimal), bool enablePushForReplies = default(bool), string pushSound = default, string pushTriggerOption = default)
        {
            this.SnoozeStartTs = snoozeStartTs;
            this.StartHour = startHour;
            this.SnoozeEnabled = snoozeEnabled;
            this.EndMin = endMin;
            this.Timezone = timezone;
            this.BlockPushFromBots = blockPushFromBots;
            this.PushBlockedBotIds = pushBlockedBotIds;
            this.StartMin = startMin;
            this.SnoozeEndTs = snoozeEndTs;
            this.DoNotDisturb = doNotDisturb;
            this.EndHour = endHour;
            this.EnablePushForReplies = enablePushForReplies;
            this.PushSound = pushSound;
            this.PushTriggerOption = pushTriggerOption;
        }

        /// <summary>
        /// Gets or Sets SnoozeStartTs
        /// </summary>
        [DataMember(Name="snooze_start_ts", EmitDefaultValue=false)]
        public string SnoozeStartTs { get; set; }

        /// <summary>
        /// Gets or Sets StartHour
        /// </summary>
        [DataMember(Name="start_hour", EmitDefaultValue=false)]
        public decimal StartHour { get; set; }

        /// <summary>
        /// Gets or Sets SnoozeEnabled
        /// </summary>
        [DataMember(Name="snooze_enabled", EmitDefaultValue=false)]
        public bool SnoozeEnabled { get; set; }

        /// <summary>
        /// Gets or Sets EndMin
        /// </summary>
        [DataMember(Name="end_min", EmitDefaultValue=false)]
        public decimal EndMin { get; set; }

        /// <summary>
        /// Gets or Sets Timezone
        /// </summary>
        [DataMember(Name="timezone", EmitDefaultValue=false)]
        public string Timezone { get; set; }

        /// <summary>
        /// Gets or Sets BlockPushFromBots
        /// </summary>
        [DataMember(Name="block_push_from_bots", EmitDefaultValue=false)]
        public bool BlockPushFromBots { get; set; }

        /// <summary>
        /// Gets or Sets PushBlockedBotIds
        /// </summary>
        [DataMember(Name="push_blocked_bot_ids", EmitDefaultValue=false)]
        public List<decimal> PushBlockedBotIds { get; set; }

        /// <summary>
        /// Gets or Sets StartMin
        /// </summary>
        [DataMember(Name="start_min", EmitDefaultValue=false)]
        public decimal StartMin { get; set; }

        /// <summary>
        /// Gets or Sets SnoozeEndTs
        /// </summary>
        [DataMember(Name="snooze_end_ts", EmitDefaultValue=false)]
        public string SnoozeEndTs { get; set; }

        /// <summary>
        /// Gets or Sets DoNotDisturb
        /// </summary>
        [DataMember(Name="do_not_disturb", EmitDefaultValue=false)]
        public bool DoNotDisturb { get; set; }

        /// <summary>
        /// Gets or Sets EndHour
        /// </summary>
        [DataMember(Name="end_hour", EmitDefaultValue=false)]
        public decimal EndHour { get; set; }

        /// <summary>
        /// Gets or Sets EnablePushForReplies
        /// </summary>
        [DataMember(Name="enable_push_for_replies", EmitDefaultValue=false)]
        public bool EnablePushForReplies { get; set; }

        /// <summary>
        /// Gets or Sets PushSound
        /// </summary>
        [DataMember(Name="push_sound", EmitDefaultValue=false)]
        public string PushSound { get; set; }

        /// <summary>
        /// Gets or Sets PushTriggerOption
        /// </summary>
        [DataMember(Name="push_trigger_option", EmitDefaultValue=false)]
        public string PushTriggerOption { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResetPushPreferencesResponse {\n");
            sb.Append("  SnoozeStartTs: ").Append(SnoozeStartTs).Append("\n");
            sb.Append("  StartHour: ").Append(StartHour).Append("\n");
            sb.Append("  SnoozeEnabled: ").Append(SnoozeEnabled).Append("\n");
            sb.Append("  EndMin: ").Append(EndMin).Append("\n");
            sb.Append("  Timezone: ").Append(Timezone).Append("\n");
            sb.Append("  BlockPushFromBots: ").Append(BlockPushFromBots).Append("\n");
            sb.Append("  PushBlockedBotIds: ").Append(PushBlockedBotIds).Append("\n");
            sb.Append("  StartMin: ").Append(StartMin).Append("\n");
            sb.Append("  SnoozeEndTs: ").Append(SnoozeEndTs).Append("\n");
            sb.Append("  DoNotDisturb: ").Append(DoNotDisturb).Append("\n");
            sb.Append("  EndHour: ").Append(EndHour).Append("\n");
            sb.Append("  EnablePushForReplies: ").Append(EnablePushForReplies).Append("\n");
            sb.Append("  PushSound: ").Append(PushSound).Append("\n");
            sb.Append("  PushTriggerOption: ").Append(PushTriggerOption).Append("\n");
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
            return this.Equals(input as ResetPushPreferencesResponse);
        }

        /// <summary>
        /// Returns true if ResetPushPreferencesResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ResetPushPreferencesResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResetPushPreferencesResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SnoozeStartTs == input.SnoozeStartTs ||
                    (this.SnoozeStartTs != null &&
                    this.SnoozeStartTs.Equals(input.SnoozeStartTs))
                ) && 
                (
                    this.StartHour == input.StartHour ||
                    (this.StartHour != null &&
                    this.StartHour.Equals(input.StartHour))
                ) && 
                (
                    this.SnoozeEnabled == input.SnoozeEnabled ||
                    (this.SnoozeEnabled != null &&
                    this.SnoozeEnabled.Equals(input.SnoozeEnabled))
                ) && 
                (
                    this.EndMin == input.EndMin ||
                    (this.EndMin != null &&
                    this.EndMin.Equals(input.EndMin))
                ) && 
                (
                    this.Timezone == input.Timezone ||
                    (this.Timezone != null &&
                    this.Timezone.Equals(input.Timezone))
                ) && 
                (
                    this.BlockPushFromBots == input.BlockPushFromBots ||
                    (this.BlockPushFromBots != null &&
                    this.BlockPushFromBots.Equals(input.BlockPushFromBots))
                ) && 
                (
                    this.PushBlockedBotIds == input.PushBlockedBotIds ||
                    this.PushBlockedBotIds != null &&
                    input.PushBlockedBotIds != null &&
                    this.PushBlockedBotIds.SequenceEqual(input.PushBlockedBotIds)
                ) && 
                (
                    this.StartMin == input.StartMin ||
                    (this.StartMin != null &&
                    this.StartMin.Equals(input.StartMin))
                ) && 
                (
                    this.SnoozeEndTs == input.SnoozeEndTs ||
                    (this.SnoozeEndTs != null &&
                    this.SnoozeEndTs.Equals(input.SnoozeEndTs))
                ) && 
                (
                    this.DoNotDisturb == input.DoNotDisturb ||
                    (this.DoNotDisturb != null &&
                    this.DoNotDisturb.Equals(input.DoNotDisturb))
                ) && 
                (
                    this.EndHour == input.EndHour ||
                    (this.EndHour != null &&
                    this.EndHour.Equals(input.EndHour))
                ) && 
                (
                    this.EnablePushForReplies == input.EnablePushForReplies ||
                    (this.EnablePushForReplies != null &&
                    this.EnablePushForReplies.Equals(input.EnablePushForReplies))
                ) && 
                (
                    this.PushSound == input.PushSound ||
                    (this.PushSound != null &&
                    this.PushSound.Equals(input.PushSound))
                ) && 
                (
                    this.PushTriggerOption == input.PushTriggerOption ||
                    (this.PushTriggerOption != null &&
                    this.PushTriggerOption.Equals(input.PushTriggerOption))
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
                if (this.SnoozeStartTs != null)
                    hashCode = hashCode * 59 + this.SnoozeStartTs.GetHashCode();
                if (this.StartHour != null)
                    hashCode = hashCode * 59 + this.StartHour.GetHashCode();
                if (this.SnoozeEnabled != null)
                    hashCode = hashCode * 59 + this.SnoozeEnabled.GetHashCode();
                if (this.EndMin != null)
                    hashCode = hashCode * 59 + this.EndMin.GetHashCode();
                if (this.Timezone != null)
                    hashCode = hashCode * 59 + this.Timezone.GetHashCode();
                if (this.BlockPushFromBots != null)
                    hashCode = hashCode * 59 + this.BlockPushFromBots.GetHashCode();
                if (this.PushBlockedBotIds != null)
                    hashCode = hashCode * 59 + this.PushBlockedBotIds.GetHashCode();
                if (this.StartMin != null)
                    hashCode = hashCode * 59 + this.StartMin.GetHashCode();
                if (this.SnoozeEndTs != null)
                    hashCode = hashCode * 59 + this.SnoozeEndTs.GetHashCode();
                if (this.DoNotDisturb != null)
                    hashCode = hashCode * 59 + this.DoNotDisturb.GetHashCode();
                if (this.EndHour != null)
                    hashCode = hashCode * 59 + this.EndHour.GetHashCode();
                if (this.EnablePushForReplies != null)
                    hashCode = hashCode * 59 + this.EnablePushForReplies.GetHashCode();
                if (this.PushSound != null)
                    hashCode = hashCode * 59 + this.PushSound.GetHashCode();
                if (this.PushTriggerOption != null)
                    hashCode = hashCode * 59 + this.PushTriggerOption.GetHashCode();
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
