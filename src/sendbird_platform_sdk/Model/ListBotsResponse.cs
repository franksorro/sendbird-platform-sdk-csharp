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
    /// ListBotsResponse
    /// </summary>
    [DataContract]
    public partial class ListBotsResponse :  IEquatable<ListBotsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListBotsResponse" /> class.
        /// </summary>
        /// <param name="bots">bots.</param>
        /// <param name="next">next.</param>
        public ListBotsResponse(List<ListBotsResponseBotsInner> bots = default(List<ListBotsResponseBotsInner>), string next = default)
        {
            this.Bots = bots;
            this.Next = next;
        }

        /// <summary>
        /// Gets or Sets Bots
        /// </summary>
        [DataMember(Name="bots", EmitDefaultValue=false)]
        public List<ListBotsResponseBotsInner> Bots { get; set; }

        /// <summary>
        /// Gets or Sets Next
        /// </summary>
        [DataMember(Name="next", EmitDefaultValue=false)]
        public string Next { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListBotsResponse {\n");
            sb.Append("  Bots: ").Append(Bots).Append("\n");
            sb.Append("  Next: ").Append(Next).Append("\n");
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
            return this.Equals(input as ListBotsResponse);
        }

        /// <summary>
        /// Returns true if ListBotsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ListBotsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListBotsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Bots == input.Bots ||
                    this.Bots != null &&
                    input.Bots != null &&
                    this.Bots.SequenceEqual(input.Bots)
                ) && 
                (
                    this.Next == input.Next ||
                    (this.Next != null &&
                    this.Next.Equals(input.Next))
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
                if (this.Bots != null)
                    hashCode = hashCode * 59 + this.Bots.GetHashCode();
                if (this.Next != null)
                    hashCode = hashCode * 59 + this.Next.GetHashCode();
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
