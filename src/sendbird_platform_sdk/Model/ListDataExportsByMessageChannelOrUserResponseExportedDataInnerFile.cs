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
    /// ListDataExportsByMessageChannelOrUserResponseExportedDataInnerFile
    /// </summary>
    [DataContract]
    public partial class ListDataExportsByMessageChannelOrUserResponseExportedDataInnerFile :  IEquatable<ListDataExportsByMessageChannelOrUserResponseExportedDataInnerFile>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListDataExportsByMessageChannelOrUserResponseExportedDataInnerFile" /> class.
        /// </summary>
        /// <param name="url">url.</param>
        /// <param name="expiresAt">expiresAt.</param>
        public ListDataExportsByMessageChannelOrUserResponseExportedDataInnerFile(string url = default, decimal expiresAt = default(decimal))
        {
            this.Url = url;
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or Sets ExpiresAt
        /// </summary>
        [DataMember(Name="expires_at", EmitDefaultValue=false)]
        public decimal ExpiresAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListDataExportsByMessageChannelOrUserResponseExportedDataInnerFile {\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  ExpiresAt: ").Append(ExpiresAt).Append("\n");
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
            return this.Equals(input as ListDataExportsByMessageChannelOrUserResponseExportedDataInnerFile);
        }

        /// <summary>
        /// Returns true if ListDataExportsByMessageChannelOrUserResponseExportedDataInnerFile instances are equal
        /// </summary>
        /// <param name="input">Instance of ListDataExportsByMessageChannelOrUserResponseExportedDataInnerFile to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListDataExportsByMessageChannelOrUserResponseExportedDataInnerFile input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.ExpiresAt == input.ExpiresAt ||
                    (this.ExpiresAt != null &&
                    this.ExpiresAt.Equals(input.ExpiresAt))
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
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.ExpiresAt != null)
                    hashCode = hashCode * 59 + this.ExpiresAt.GetHashCode();
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
