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
    /// SetDomainFilterData
    /// </summary>
    [DataContract]
    public partial class SetDomainFilterData :  IEquatable<SetDomainFilterData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SetDomainFilterData" /> class.
        /// </summary>
        /// <param name="domainFilter">domainFilter.</param>
        /// <param name="profanityFilter">profanityFilter.</param>
        /// <param name="profanityTriggeredModeration">profanityTriggeredModeration.</param>
        /// <param name="imageModeration">imageModeration.</param>
        public SetDomainFilterData(V3ApplicationsSettingsGlobalCustomTypeDomainFilter domainFilter = default(V3ApplicationsSettingsGlobalCustomTypeDomainFilter), V3ApplicationsSettingsGlobalCustomTypeProfanityFilter profanityFilter = default(V3ApplicationsSettingsGlobalCustomTypeProfanityFilter), V3ApplicationsSettingsGlobalCustomTypeProfanityTriggeredModeration profanityTriggeredModeration = default(V3ApplicationsSettingsGlobalCustomTypeProfanityTriggeredModeration), V3ApplicationsSettingsGlobalCustomTypeImageModeration imageModeration = default(V3ApplicationsSettingsGlobalCustomTypeImageModeration))
        {
            this.DomainFilter = domainFilter;
            this.ProfanityFilter = profanityFilter;
            this.ProfanityTriggeredModeration = profanityTriggeredModeration;
            this.ImageModeration = imageModeration;
        }

        /// <summary>
        /// Gets or Sets DomainFilter
        /// </summary>
        [DataMember(Name="domain_filter", EmitDefaultValue=false)]
        public V3ApplicationsSettingsGlobalCustomTypeDomainFilter DomainFilter { get; set; }

        /// <summary>
        /// Gets or Sets ProfanityFilter
        /// </summary>
        [DataMember(Name="profanity_filter", EmitDefaultValue=false)]
        public V3ApplicationsSettingsGlobalCustomTypeProfanityFilter ProfanityFilter { get; set; }

        /// <summary>
        /// Gets or Sets ProfanityTriggeredModeration
        /// </summary>
        [DataMember(Name="profanity_triggered_moderation", EmitDefaultValue=false)]
        public V3ApplicationsSettingsGlobalCustomTypeProfanityTriggeredModeration ProfanityTriggeredModeration { get; set; }

        /// <summary>
        /// Gets or Sets ImageModeration
        /// </summary>
        [DataMember(Name="image_moderation", EmitDefaultValue=false)]
        public V3ApplicationsSettingsGlobalCustomTypeImageModeration ImageModeration { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SetDomainFilterData {\n");
            sb.Append("  DomainFilter: ").Append(DomainFilter).Append("\n");
            sb.Append("  ProfanityFilter: ").Append(ProfanityFilter).Append("\n");
            sb.Append("  ProfanityTriggeredModeration: ").Append(ProfanityTriggeredModeration).Append("\n");
            sb.Append("  ImageModeration: ").Append(ImageModeration).Append("\n");
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
            return this.Equals(input as SetDomainFilterData);
        }

        /// <summary>
        /// Returns true if SetDomainFilterData instances are equal
        /// </summary>
        /// <param name="input">Instance of SetDomainFilterData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SetDomainFilterData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DomainFilter == input.DomainFilter ||
                    (this.DomainFilter != null &&
                    this.DomainFilter.Equals(input.DomainFilter))
                ) && 
                (
                    this.ProfanityFilter == input.ProfanityFilter ||
                    (this.ProfanityFilter != null &&
                    this.ProfanityFilter.Equals(input.ProfanityFilter))
                ) && 
                (
                    this.ProfanityTriggeredModeration == input.ProfanityTriggeredModeration ||
                    (this.ProfanityTriggeredModeration != null &&
                    this.ProfanityTriggeredModeration.Equals(input.ProfanityTriggeredModeration))
                ) && 
                (
                    this.ImageModeration == input.ImageModeration ||
                    (this.ImageModeration != null &&
                    this.ImageModeration.Equals(input.ImageModeration))
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
                if (this.DomainFilter != null)
                    hashCode = hashCode * 59 + this.DomainFilter.GetHashCode();
                if (this.ProfanityFilter != null)
                    hashCode = hashCode * 59 + this.ProfanityFilter.GetHashCode();
                if (this.ProfanityTriggeredModeration != null)
                    hashCode = hashCode * 59 + this.ProfanityTriggeredModeration.GetHashCode();
                if (this.ImageModeration != null)
                    hashCode = hashCode * 59 + this.ImageModeration.GetHashCode();
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
