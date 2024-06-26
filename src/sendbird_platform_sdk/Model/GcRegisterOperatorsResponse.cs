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
    /// GcRegisterOperatorsResponse
    /// </summary>
    [DataContract]
    public partial class GcRegisterOperatorsResponse :  IEquatable<GcRegisterOperatorsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GcRegisterOperatorsResponse" /> class.
        /// </summary>
        /// <param name="operatorIds">operatorIds.</param>
        public GcRegisterOperatorsResponse(List<string> operatorIds = default)
        {
            this.OperatorIds = operatorIds;
        }

        /// <summary>
        /// Gets or Sets OperatorIds
        /// </summary>
        [DataMember(Name="operator_ids", EmitDefaultValue=false)]
        public List<string> OperatorIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GcRegisterOperatorsResponse {\n");
            sb.Append("  OperatorIds: ").Append(OperatorIds).Append("\n");
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
            return this.Equals(input as GcRegisterOperatorsResponse);
        }

        /// <summary>
        /// Returns true if GcRegisterOperatorsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GcRegisterOperatorsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GcRegisterOperatorsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OperatorIds == input.OperatorIds ||
                    this.OperatorIds != null &&
                    input.OperatorIds != null &&
                    this.OperatorIds.SequenceEqual(input.OperatorIds)
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
                if (this.OperatorIds != null)
                    hashCode = hashCode * 59 + this.OperatorIds.GetHashCode();
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
