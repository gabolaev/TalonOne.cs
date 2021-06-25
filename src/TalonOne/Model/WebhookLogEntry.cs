/* 
 * Talon.One API
 *
 * The Talon.One API is used to manage applications and campaigns, as well as to integrate with your application. The operations in the _Integration API_ section are used to integrate with our platform, while the other operations are used to manage applications and campaigns.  ### Where is the API?  The API is available at the same hostname as these docs. For example, if you are reading this page at `https://mycompany.talon.one/docs/api/`, the URL for the [updateCustomerProfile][] operation is `https://mycompany.talon.one/v1/customer_profiles/id`  [updateCustomerProfile]: #operation- -v1-customer_profiles- -integrationId- -put 
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
using OpenAPIDateConverter = TalonOne.Client.OpenAPIDateConverter;

namespace TalonOne.Model
{
    /// <summary>
    /// Log of webhook api calls
    /// </summary>
    [DataContract]
    public partial class WebhookLogEntry :  IEquatable<WebhookLogEntry>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookLogEntry" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WebhookLogEntry() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookLogEntry" /> class.
        /// </summary>
        /// <param name="id">UUID reference of the webhook request (required).</param>
        /// <param name="integrationRequestUuid">UUID reference of the integration request linked to this webhook request (required).</param>
        /// <param name="webhookId">ID of the webhook that triggered the request (required).</param>
        /// <param name="applicationId">ID of the application that triggered the webhook.</param>
        /// <param name="url">Target url of request (required).</param>
        /// <param name="request">Request message (required).</param>
        /// <param name="response">Response message.</param>
        /// <param name="status">HTTP status code of response.</param>
        /// <param name="requestTime">Timestamp of request (required).</param>
        /// <param name="responseTime">Timestamp of response.</param>
        public WebhookLogEntry(string id = default(string), string integrationRequestUuid = default(string), int webhookId = default(int), int applicationId = default(int), string url = default(string), string request = default(string), string response = default(string), int status = default(int), DateTime requestTime = default(DateTime), DateTime responseTime = default(DateTime))
        {
            // to ensure "id" is required (not null)
            this.Id = id ?? throw new ArgumentNullException("id is a required property for WebhookLogEntry and cannot be null");
            // to ensure "integrationRequestUuid" is required (not null)
            this.IntegrationRequestUuid = integrationRequestUuid ?? throw new ArgumentNullException("integrationRequestUuid is a required property for WebhookLogEntry and cannot be null");
            this.WebhookId = webhookId;
            // to ensure "url" is required (not null)
            this.Url = url ?? throw new ArgumentNullException("url is a required property for WebhookLogEntry and cannot be null");
            // to ensure "request" is required (not null)
            this.Request = request ?? throw new ArgumentNullException("request is a required property for WebhookLogEntry and cannot be null");
            this.RequestTime = requestTime;
            this.ApplicationId = applicationId;
            this.Response = response;
            this.Status = status;
            this.ResponseTime = responseTime;
        }
        
        /// <summary>
        /// UUID reference of the webhook request
        /// </summary>
        /// <value>UUID reference of the webhook request</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// UUID reference of the integration request linked to this webhook request
        /// </summary>
        /// <value>UUID reference of the integration request linked to this webhook request</value>
        [DataMember(Name="integrationRequestUuid", EmitDefaultValue=false)]
        public string IntegrationRequestUuid { get; set; }

        /// <summary>
        /// ID of the webhook that triggered the request
        /// </summary>
        /// <value>ID of the webhook that triggered the request</value>
        [DataMember(Name="webhookId", EmitDefaultValue=false)]
        public int WebhookId { get; set; }

        /// <summary>
        /// ID of the application that triggered the webhook
        /// </summary>
        /// <value>ID of the application that triggered the webhook</value>
        [DataMember(Name="applicationId", EmitDefaultValue=false)]
        public int ApplicationId { get; set; }

        /// <summary>
        /// Target url of request
        /// </summary>
        /// <value>Target url of request</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// Request message
        /// </summary>
        /// <value>Request message</value>
        [DataMember(Name="request", EmitDefaultValue=false)]
        public string Request { get; set; }

        /// <summary>
        /// Response message
        /// </summary>
        /// <value>Response message</value>
        [DataMember(Name="response", EmitDefaultValue=false)]
        public string Response { get; set; }

        /// <summary>
        /// HTTP status code of response
        /// </summary>
        /// <value>HTTP status code of response</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public int Status { get; set; }

        /// <summary>
        /// Timestamp of request
        /// </summary>
        /// <value>Timestamp of request</value>
        [DataMember(Name="requestTime", EmitDefaultValue=false)]
        public DateTime RequestTime { get; set; }

        /// <summary>
        /// Timestamp of response
        /// </summary>
        /// <value>Timestamp of response</value>
        [DataMember(Name="responseTime", EmitDefaultValue=false)]
        public DateTime ResponseTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebhookLogEntry {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IntegrationRequestUuid: ").Append(IntegrationRequestUuid).Append("\n");
            sb.Append("  WebhookId: ").Append(WebhookId).Append("\n");
            sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Request: ").Append(Request).Append("\n");
            sb.Append("  Response: ").Append(Response).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  RequestTime: ").Append(RequestTime).Append("\n");
            sb.Append("  ResponseTime: ").Append(ResponseTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as WebhookLogEntry);
        }

        /// <summary>
        /// Returns true if WebhookLogEntry instances are equal
        /// </summary>
        /// <param name="input">Instance of WebhookLogEntry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookLogEntry input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.IntegrationRequestUuid == input.IntegrationRequestUuid ||
                    (this.IntegrationRequestUuid != null &&
                    this.IntegrationRequestUuid.Equals(input.IntegrationRequestUuid))
                ) && 
                (
                    this.WebhookId == input.WebhookId ||
                    this.WebhookId.Equals(input.WebhookId)
                ) && 
                (
                    this.ApplicationId == input.ApplicationId ||
                    this.ApplicationId.Equals(input.ApplicationId)
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.Request == input.Request ||
                    (this.Request != null &&
                    this.Request.Equals(input.Request))
                ) && 
                (
                    this.Response == input.Response ||
                    (this.Response != null &&
                    this.Response.Equals(input.Response))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.RequestTime == input.RequestTime ||
                    (this.RequestTime != null &&
                    this.RequestTime.Equals(input.RequestTime))
                ) && 
                (
                    this.ResponseTime == input.ResponseTime ||
                    (this.ResponseTime != null &&
                    this.ResponseTime.Equals(input.ResponseTime))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IntegrationRequestUuid != null)
                    hashCode = hashCode * 59 + this.IntegrationRequestUuid.GetHashCode();
                hashCode = hashCode * 59 + this.WebhookId.GetHashCode();
                hashCode = hashCode * 59 + this.ApplicationId.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.Request != null)
                    hashCode = hashCode * 59 + this.Request.GetHashCode();
                if (this.Response != null)
                    hashCode = hashCode * 59 + this.Response.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.RequestTime != null)
                    hashCode = hashCode * 59 + this.RequestTime.GetHashCode();
                if (this.ResponseTime != null)
                    hashCode = hashCode * 59 + this.ResponseTime.GetHashCode();
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
