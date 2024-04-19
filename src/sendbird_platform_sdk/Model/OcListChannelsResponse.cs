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
    /// OcListChannelsResponse
    /// </summary>
    [DataContract]
    public partial class OcListChannelsResponse :  IEquatable<OcListChannelsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OcListChannelsResponse" /> class.
        /// </summary>
        /// <param name="channels">channels.</param>
        /// <param name="next">next.</param>
        /// <param name="ts">ts.</param>
        public OcListChannelsResponse(List<SendBirdOpenChannel> channels = default(List<SendBirdOpenChannel>), string next = default, decimal ts = default(decimal))
        {
            this.Channels = channels;
            this.Next = next;
            this.Ts = ts;
        }

        /// <summary>
        /// Gets or Sets Channels
        /// </summary>
        [DataMember(Name="channels", EmitDefaultValue=false)]
        public List<SendBirdOpenChannel> Channels { get; set; }

        /// <summary>
        /// Gets or Sets Next
        /// </summary>
        [DataMember(Name="next", EmitDefaultValue=false)]
        public string Next { get; set; }

        /// <summary>
        /// Gets or Sets Ts
        /// </summary>
        [DataMember(Name="ts", EmitDefaultValue=false)]
        public decimal Ts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OcListChannelsResponse {\n");
            sb.Append("  Channels: ").Append(Channels).Append("\n");
            sb.Append("  Next: ").Append(Next).Append("\n");
            sb.Append("  Ts: ").Append(Ts).Append("\n");
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
            return this.Equals(input as OcListChannelsResponse);
        }

        /// <summary>
        /// Returns true if OcListChannelsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of OcListChannelsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OcListChannelsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Channels == input.Channels ||
                    this.Channels != null &&
                    input.Channels != null &&
                    this.Channels.SequenceEqual(input.Channels)
                ) && 
                (
                    this.Next == input.Next ||
                    (this.Next != null &&
                    this.Next.Equals(input.Next))
                ) && 
                (
                    this.Ts == input.Ts ||
                    (this.Ts != null &&
                    this.Ts.Equals(input.Ts))
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
                if (this.Channels != null)
                    hashCode = hashCode * 59 + this.Channels.GetHashCode();
                if (this.Next != null)
                    hashCode = hashCode * 59 + this.Next.GetHashCode();
                if (this.Ts != null)
                    hashCode = hashCode * 59 + this.Ts.GetHashCode();
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
