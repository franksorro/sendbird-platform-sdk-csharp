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
using OpenAPIDateConverter = sendbird-platform-sdk.Client.OpenAPIDateConverter;

namespace sendbird-platform-sdk.Model
{
    /// <summary>
    /// AddEmojisData
    /// </summary>
    [DataContract]
    public partial class AddEmojisData :  IEquatable<AddEmojisData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddEmojisData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AddEmojisData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddEmojisData" /> class.
        /// </summary>
        /// <param name="emojiCategoryId">Specifies the unique ID of the emoji category that a list of new emojis belong to. (required).</param>
        /// <param name="emojis">Specifies a list of one or more new emojis to register. (required).</param>
        public AddEmojisData(int emojiCategoryId = default(int), List<string> emojis = default(List<string>))
        {
            // to ensure "emojiCategoryId" is required (not null)
            if (emojiCategoryId == null)
            {
                throw new InvalidDataException("emojiCategoryId is a required property for AddEmojisData and cannot be null");
            }
            else
            {
                this.EmojiCategoryId = emojiCategoryId;
            }

            // to ensure "emojis" is required (not null)
            if (emojis == null)
            {
                throw new InvalidDataException("emojis is a required property for AddEmojisData and cannot be null");
            }
            else
            {
                this.Emojis = emojis;
            }

        }

        /// <summary>
        /// Specifies the unique ID of the emoji category that a list of new emojis belong to.
        /// </summary>
        /// <value>Specifies the unique ID of the emoji category that a list of new emojis belong to.</value>
        [DataMember(Name="emoji_category_id", EmitDefaultValue=true)]
        public int EmojiCategoryId { get; set; }

        /// <summary>
        /// Specifies a list of one or more new emojis to register.
        /// </summary>
        /// <value>Specifies a list of one or more new emojis to register.</value>
        [DataMember(Name="emojis", EmitDefaultValue=true)]
        public List<string> Emojis { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddEmojisData {\n");
            sb.Append("  EmojiCategoryId: ").Append(EmojiCategoryId).Append("\n");
            sb.Append("  Emojis: ").Append(Emojis).Append("\n");
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
            return this.Equals(input as AddEmojisData);
        }

        /// <summary>
        /// Returns true if AddEmojisData instances are equal
        /// </summary>
        /// <param name="input">Instance of AddEmojisData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddEmojisData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EmojiCategoryId == input.EmojiCategoryId ||
                    (this.EmojiCategoryId != null &&
                    this.EmojiCategoryId.Equals(input.EmojiCategoryId))
                ) && 
                (
                    this.Emojis == input.Emojis ||
                    this.Emojis != null &&
                    input.Emojis != null &&
                    this.Emojis.SequenceEqual(input.Emojis)
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
                if (this.EmojiCategoryId != null)
                    hashCode = hashCode * 59 + this.EmojiCategoryId.GetHashCode();
                if (this.Emojis != null)
                    hashCode = hashCode * 59 + this.Emojis.GetHashCode();
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