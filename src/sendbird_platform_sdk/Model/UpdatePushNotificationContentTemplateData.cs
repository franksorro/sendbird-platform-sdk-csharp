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
    /// UpdatePushNotificationContentTemplateData
    /// </summary>
    [DataContract]
    public partial class UpdatePushNotificationContentTemplateData :  IEquatable<UpdatePushNotificationContentTemplateData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePushNotificationContentTemplateData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdatePushNotificationContentTemplateData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePushNotificationContentTemplateData" /> class.
        /// </summary>
        /// <param name="templateName">Specifies the name of a push notification content template to update. Acceptable values are default and alternative. (required).</param>
        /// <param name="template">The push notification content template of which content types to be updated and their detailed format. (required).</param>
        /// <param name="templateMESG">Specifies a format for text messages. We support customization of two fields, which are the sender_name and message. These fields will be replaced with actual corresponding values when sending notification requests to FCM, HMS, or APNs. (required).</param>
        /// <param name="templateFILE">Specifies a format for file messages. We support customization with variables including filename and file_type_friendly. When sending notification requests to FCM, HMS, or APNs, the filename will be replaced with the corresponding string value while the file_type_friendly will indicate the type of the file sent, such as &#x60;Audio&#x60;, &#x60;Image&#x60;, and &#x60;Video&#x60;. (required).</param>
        /// <param name="templateADMN">Specifies a format for admin messages. We support customization of one field, which is the message. This field will be replaced with actual corresponding values when sending notification requests to FCM, HMS, or APNs. (required).</param>
        public UpdatePushNotificationContentTemplateData(string templateName = default, string template = default, string templateMESG = default, string templateFILE = default, string templateADMN = default)
        {
            // to ensure "templateName" is required (not null)
            if (templateName == null)
            {
                throw new InvalidDataException("templateName is a required property for UpdatePushNotificationContentTemplateData and cannot be null");
            }
            else
            {
                this.TemplateName = templateName;
            }

            // to ensure "template" is required (not null)
            if (template == null)
            {
                throw new InvalidDataException("template is a required property for UpdatePushNotificationContentTemplateData and cannot be null");
            }
            else
            {
                this.Template = template;
            }

            // to ensure "templateMESG" is required (not null)
            if (templateMESG == null)
            {
                throw new InvalidDataException("templateMESG is a required property for UpdatePushNotificationContentTemplateData and cannot be null");
            }
            else
            {
                this.TemplateMESG = templateMESG;
            }

            // to ensure "templateFILE" is required (not null)
            if (templateFILE == null)
            {
                throw new InvalidDataException("templateFILE is a required property for UpdatePushNotificationContentTemplateData and cannot be null");
            }
            else
            {
                this.TemplateFILE = templateFILE;
            }

            // to ensure "templateADMN" is required (not null)
            if (templateADMN == null)
            {
                throw new InvalidDataException("templateADMN is a required property for UpdatePushNotificationContentTemplateData and cannot be null");
            }
            else
            {
                this.TemplateADMN = templateADMN;
            }

        }

        /// <summary>
        /// Specifies the name of a push notification content template to update. Acceptable values are default and alternative.
        /// </summary>
        /// <value>Specifies the name of a push notification content template to update. Acceptable values are default and alternative.</value>
        [DataMember(Name="template_name", EmitDefaultValue=true)]
        public string TemplateName { get; set; }

        /// <summary>
        /// The push notification content template of which content types to be updated and their detailed format.
        /// </summary>
        /// <value>The push notification content template of which content types to be updated and their detailed format.</value>
        [DataMember(Name="template", EmitDefaultValue=true)]
        public string Template { get; set; }

        /// <summary>
        /// Specifies a format for text messages. We support customization of two fields, which are the sender_name and message. These fields will be replaced with actual corresponding values when sending notification requests to FCM, HMS, or APNs.
        /// </summary>
        /// <value>Specifies a format for text messages. We support customization of two fields, which are the sender_name and message. These fields will be replaced with actual corresponding values when sending notification requests to FCM, HMS, or APNs.</value>
        [DataMember(Name="template.MESG", EmitDefaultValue=true)]
        public string TemplateMESG { get; set; }

        /// <summary>
        /// Specifies a format for file messages. We support customization with variables including filename and file_type_friendly. When sending notification requests to FCM, HMS, or APNs, the filename will be replaced with the corresponding string value while the file_type_friendly will indicate the type of the file sent, such as &#x60;Audio&#x60;, &#x60;Image&#x60;, and &#x60;Video&#x60;.
        /// </summary>
        /// <value>Specifies a format for file messages. We support customization with variables including filename and file_type_friendly. When sending notification requests to FCM, HMS, or APNs, the filename will be replaced with the corresponding string value while the file_type_friendly will indicate the type of the file sent, such as &#x60;Audio&#x60;, &#x60;Image&#x60;, and &#x60;Video&#x60;.</value>
        [DataMember(Name="template.FILE", EmitDefaultValue=true)]
        public string TemplateFILE { get; set; }

        /// <summary>
        /// Specifies a format for admin messages. We support customization of one field, which is the message. This field will be replaced with actual corresponding values when sending notification requests to FCM, HMS, or APNs.
        /// </summary>
        /// <value>Specifies a format for admin messages. We support customization of one field, which is the message. This field will be replaced with actual corresponding values when sending notification requests to FCM, HMS, or APNs.</value>
        [DataMember(Name="template.ADMN", EmitDefaultValue=true)]
        public string TemplateADMN { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdatePushNotificationContentTemplateData {\n");
            sb.Append("  TemplateName: ").Append(TemplateName).Append("\n");
            sb.Append("  Template: ").Append(Template).Append("\n");
            sb.Append("  TemplateMESG: ").Append(TemplateMESG).Append("\n");
            sb.Append("  TemplateFILE: ").Append(TemplateFILE).Append("\n");
            sb.Append("  TemplateADMN: ").Append(TemplateADMN).Append("\n");
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
            return this.Equals(input as UpdatePushNotificationContentTemplateData);
        }

        /// <summary>
        /// Returns true if UpdatePushNotificationContentTemplateData instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdatePushNotificationContentTemplateData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdatePushNotificationContentTemplateData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TemplateName == input.TemplateName ||
                    (this.TemplateName != null &&
                    this.TemplateName.Equals(input.TemplateName))
                ) && 
                (
                    this.Template == input.Template ||
                    (this.Template != null &&
                    this.Template.Equals(input.Template))
                ) && 
                (
                    this.TemplateMESG == input.TemplateMESG ||
                    (this.TemplateMESG != null &&
                    this.TemplateMESG.Equals(input.TemplateMESG))
                ) && 
                (
                    this.TemplateFILE == input.TemplateFILE ||
                    (this.TemplateFILE != null &&
                    this.TemplateFILE.Equals(input.TemplateFILE))
                ) && 
                (
                    this.TemplateADMN == input.TemplateADMN ||
                    (this.TemplateADMN != null &&
                    this.TemplateADMN.Equals(input.TemplateADMN))
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
                if (this.TemplateName != null)
                    hashCode = hashCode * 59 + this.TemplateName.GetHashCode();
                if (this.Template != null)
                    hashCode = hashCode * 59 + this.Template.GetHashCode();
                if (this.TemplateMESG != null)
                    hashCode = hashCode * 59 + this.TemplateMESG.GetHashCode();
                if (this.TemplateFILE != null)
                    hashCode = hashCode * 59 + this.TemplateFILE.GetHashCode();
                if (this.TemplateADMN != null)
                    hashCode = hashCode * 59 + this.TemplateADMN.GetHashCode();
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
