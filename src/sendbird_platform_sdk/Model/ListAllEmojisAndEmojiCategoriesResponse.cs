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
    /// ListAllEmojisAndEmojiCategoriesResponse
    /// </summary>
    [DataContract]
    public partial class ListAllEmojisAndEmojiCategoriesResponse :  IEquatable<ListAllEmojisAndEmojiCategoriesResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListAllEmojisAndEmojiCategoriesResponse" /> class.
        /// </summary>
        /// <param name="emojiHash">emojiHash.</param>
        /// <param name="emojiCategories">emojiCategories.</param>
        public ListAllEmojisAndEmojiCategoriesResponse(string emojiHash = default, List<ListAllEmojisAndEmojiCategoriesResponseEmojiCategoriesInner> emojiCategories = default(List<ListAllEmojisAndEmojiCategoriesResponseEmojiCategoriesInner>))
        {
            this.EmojiHash = emojiHash;
            this.EmojiCategories = emojiCategories;
        }

        /// <summary>
        /// Gets or Sets EmojiHash
        /// </summary>
        [DataMember(Name="emoji_hash", EmitDefaultValue=false)]
        public string EmojiHash { get; set; }

        /// <summary>
        /// Gets or Sets EmojiCategories
        /// </summary>
        [DataMember(Name="emoji_categories", EmitDefaultValue=false)]
        public List<ListAllEmojisAndEmojiCategoriesResponseEmojiCategoriesInner> EmojiCategories { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAllEmojisAndEmojiCategoriesResponse {\n");
            sb.Append("  EmojiHash: ").Append(EmojiHash).Append("\n");
            sb.Append("  EmojiCategories: ").Append(EmojiCategories).Append("\n");
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
            return this.Equals(input as ListAllEmojisAndEmojiCategoriesResponse);
        }

        /// <summary>
        /// Returns true if ListAllEmojisAndEmojiCategoriesResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ListAllEmojisAndEmojiCategoriesResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListAllEmojisAndEmojiCategoriesResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EmojiHash == input.EmojiHash ||
                    (this.EmojiHash != null &&
                    this.EmojiHash.Equals(input.EmojiHash))
                ) && 
                (
                    this.EmojiCategories == input.EmojiCategories ||
                    this.EmojiCategories != null &&
                    input.EmojiCategories != null &&
                    this.EmojiCategories.SequenceEqual(input.EmojiCategories)
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
                if (this.EmojiHash != null)
                    hashCode = hashCode * 59 + this.EmojiHash.GetHashCode();
                if (this.EmojiCategories != null)
                    hashCode = hashCode * 59 + this.EmojiCategories.GetHashCode();
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
