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
    /// V3ApplicationsSettingsGlobalCustomTypeProfanityFilterRegexFilters
    /// </summary>
    [DataContract]
    public partial class V3ApplicationsSettingsGlobalCustomTypeProfanityFilterRegexFilters :  IEquatable<V3ApplicationsSettingsGlobalCustomTypeProfanityFilterRegexFilters>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V3ApplicationsSettingsGlobalCustomTypeProfanityFilterRegexFilters" /> class.
        /// </summary>
        /// <param name="regex">regex.</param>
        public V3ApplicationsSettingsGlobalCustomTypeProfanityFilterRegexFilters(string regex = default(string))
        {
            this.Regex = regex;
        }

        /// <summary>
        /// Gets or Sets Regex
        /// </summary>
        [DataMember(Name="regex", EmitDefaultValue=false)]
        public string Regex { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V3ApplicationsSettingsGlobalCustomTypeProfanityFilterRegexFilters {\n");
            sb.Append("  Regex: ").Append(Regex).Append("\n");
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
            return this.Equals(input as V3ApplicationsSettingsGlobalCustomTypeProfanityFilterRegexFilters);
        }

        /// <summary>
        /// Returns true if V3ApplicationsSettingsGlobalCustomTypeProfanityFilterRegexFilters instances are equal
        /// </summary>
        /// <param name="input">Instance of V3ApplicationsSettingsGlobalCustomTypeProfanityFilterRegexFilters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V3ApplicationsSettingsGlobalCustomTypeProfanityFilterRegexFilters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Regex == input.Regex ||
                    (this.Regex != null &&
                    this.Regex.Equals(input.Regex))
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
                if (this.Regex != null)
                    hashCode = hashCode * 59 + this.Regex.GetHashCode();
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
