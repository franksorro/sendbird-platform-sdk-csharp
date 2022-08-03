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
    /// SetDomainFilterDataDomainFilter
    /// </summary>
    [DataContract]
    public partial class SetDomainFilterDataDomainFilter :  IEquatable<SetDomainFilterDataDomainFilter>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SetDomainFilterDataDomainFilter" /> class.
        /// </summary>
        /// <param name="domains">domains.</param>
        /// <param name="type">type.</param>
        /// <param name="shouldCheckGlobal">shouldCheckGlobal.</param>
        public SetDomainFilterDataDomainFilter(List<string> domains = default(List<string>), int type = default(int), bool shouldCheckGlobal = default(bool))
        {
            this.Domains = domains;
            this.Type = type;
            this.ShouldCheckGlobal = shouldCheckGlobal;
        }

        /// <summary>
        /// Gets or Sets Domains
        /// </summary>
        [DataMember(Name="domains", EmitDefaultValue=false)]
        public List<string> Domains { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public int Type { get; set; }

        /// <summary>
        /// Gets or Sets ShouldCheckGlobal
        /// </summary>
        [DataMember(Name="should_check_global", EmitDefaultValue=false)]
        public bool ShouldCheckGlobal { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SetDomainFilterDataDomainFilter {\n");
            sb.Append("  Domains: ").Append(Domains).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ShouldCheckGlobal: ").Append(ShouldCheckGlobal).Append("\n");
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
            return this.Equals(input as SetDomainFilterDataDomainFilter);
        }

        /// <summary>
        /// Returns true if SetDomainFilterDataDomainFilter instances are equal
        /// </summary>
        /// <param name="input">Instance of SetDomainFilterDataDomainFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SetDomainFilterDataDomainFilter input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Domains == input.Domains ||
                    this.Domains != null &&
                    input.Domains != null &&
                    this.Domains.SequenceEqual(input.Domains)
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.ShouldCheckGlobal == input.ShouldCheckGlobal ||
                    (this.ShouldCheckGlobal != null &&
                    this.ShouldCheckGlobal.Equals(input.ShouldCheckGlobal))
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
                if (this.Domains != null)
                    hashCode = hashCode * 59 + this.Domains.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.ShouldCheckGlobal != null)
                    hashCode = hashCode * 59 + this.ShouldCheckGlobal.GetHashCode();
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