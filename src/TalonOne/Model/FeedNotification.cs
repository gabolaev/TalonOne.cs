/* 
 * Talon.One API
 *
 * Use the Talon.One API to integrate with your application and to manage applications and campaigns:  - Use the operations in the [Integration API section](#integration-api) are used to integrate with our platform - Use the operation in the [Management API section](#management-api) to manage applications and campaigns.  ## Determining the base URL of the endpoints  The API is available at the same hostname as your Campaign Manager deployment. For example, if you are reading this page at `https://mycompany.talon.one/docs/api/`, the URL for the [updateCustomerSession](https://docs.talon.one/integration-api/#operation/updateCustomerSessionV2) endpoint is `https://mycompany.talon.one/v2/customer_sessions/{Id}` 
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
    /// A feed notification for CAMA users
    /// </summary>
    [DataContract]
    public partial class FeedNotification :  IEquatable<FeedNotification>, IValidatableObject
    {
        /// <summary>
        /// The type of the feed notification
        /// </summary>
        /// <value>The type of the feed notification</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Feed for value: feed
            /// </summary>
            [EnumMember(Value = "feed")]
            Feed = 1,

            /// <summary>
            /// Enum Feature for value: feature
            /// </summary>
            [EnumMember(Value = "feature")]
            Feature = 2,

            /// <summary>
            /// Enum Announcement for value: announcement
            /// </summary>
            [EnumMember(Value = "announcement")]
            Announcement = 3,

            /// <summary>
            /// Enum Alert for value: alert
            /// </summary>
            [EnumMember(Value = "alert")]
            Alert = 4,

            /// <summary>
            /// Enum Test for value: test
            /// </summary>
            [EnumMember(Value = "test")]
            Test = 5

        }

        /// <summary>
        /// The type of the feed notification
        /// </summary>
        /// <value>The type of the feed notification</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FeedNotification" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FeedNotification() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FeedNotification" /> class.
        /// </summary>
        /// <param name="title">Title of the feed notification (required).</param>
        /// <param name="created">Timestamp of the moment this feed notification was created (required).</param>
        /// <param name="updated">Timestamp of the moment this feed notification was last updated (required).</param>
        /// <param name="articleUrl">URL to the feed notification in the help center (required).</param>
        /// <param name="type">The type of the feed notification (required).</param>
        /// <param name="body">Body of the feed notification (required).</param>
        public FeedNotification(string title = default(string), DateTime created = default(DateTime), DateTime updated = default(DateTime), string articleUrl = default(string), TypeEnum type = default(TypeEnum), string body = default(string))
        {
            // to ensure "title" is required (not null)
            this.Title = title ?? throw new ArgumentNullException("title is a required property for FeedNotification and cannot be null");
            this.Created = created;
            this.Updated = updated;
            // to ensure "articleUrl" is required (not null)
            this.ArticleUrl = articleUrl ?? throw new ArgumentNullException("articleUrl is a required property for FeedNotification and cannot be null");
            this.Type = type;
            // to ensure "body" is required (not null)
            this.Body = body ?? throw new ArgumentNullException("body is a required property for FeedNotification and cannot be null");
        }
        
        /// <summary>
        /// Title of the feed notification
        /// </summary>
        /// <value>Title of the feed notification</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Timestamp of the moment this feed notification was created
        /// </summary>
        /// <value>Timestamp of the moment this feed notification was created</value>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public DateTime Created { get; set; }

        /// <summary>
        /// Timestamp of the moment this feed notification was last updated
        /// </summary>
        /// <value>Timestamp of the moment this feed notification was last updated</value>
        [DataMember(Name="updated", EmitDefaultValue=false)]
        public DateTime Updated { get; set; }

        /// <summary>
        /// URL to the feed notification in the help center
        /// </summary>
        /// <value>URL to the feed notification in the help center</value>
        [DataMember(Name="articleUrl", EmitDefaultValue=false)]
        public string ArticleUrl { get; set; }

        /// <summary>
        /// Body of the feed notification
        /// </summary>
        /// <value>Body of the feed notification</value>
        [DataMember(Name="body", EmitDefaultValue=false)]
        public string Body { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FeedNotification {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Updated: ").Append(Updated).Append("\n");
            sb.Append("  ArticleUrl: ").Append(ArticleUrl).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
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
            return this.Equals(input as FeedNotification);
        }

        /// <summary>
        /// Returns true if FeedNotification instances are equal
        /// </summary>
        /// <param name="input">Instance of FeedNotification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FeedNotification input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.Updated == input.Updated ||
                    (this.Updated != null &&
                    this.Updated.Equals(input.Updated))
                ) && 
                (
                    this.ArticleUrl == input.ArticleUrl ||
                    (this.ArticleUrl != null &&
                    this.ArticleUrl.Equals(input.ArticleUrl))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
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
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.Updated != null)
                    hashCode = hashCode * 59 + this.Updated.GetHashCode();
                if (this.ArticleUrl != null)
                    hashCode = hashCode * 59 + this.ArticleUrl.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Body != null)
                    hashCode = hashCode * 59 + this.Body.GetHashCode();
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
