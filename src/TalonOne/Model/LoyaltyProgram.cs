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
    /// LoyaltyProgram
    /// </summary>
    [DataContract]
    public partial class LoyaltyProgram :  IEquatable<LoyaltyProgram>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoyaltyProgram" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LoyaltyProgram() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LoyaltyProgram" /> class.
        /// </summary>
        /// <param name="id">The ID of loyalty program. Unique ID for this entity. (required).</param>
        /// <param name="created">The exact moment this entity was created. (required).</param>
        /// <param name="title">The display title for the Loyalty Program. (required).</param>
        /// <param name="description">Description of our Loyalty Program. (required).</param>
        /// <param name="subscribedApplications">A list containing the IDs of all applications that are subscribed to this Loyalty Program. (required).</param>
        /// <param name="defaultValidity">Indicates the default duration after which new loyalty points should expire. The format is a number, followed by one letter indicating the unit; like &#39;1h&#39; or &#39;40m&#39;. (required).</param>
        /// <param name="defaultPending">Indicates the default duration for the pending time, after which points will be valid. The format is a number followed by a duration unit, like &#39;1h&#39; or &#39;40m&#39;. (required).</param>
        /// <param name="allowSubledger">Indicates if this program supports subledgers inside the program (required).</param>
        /// <param name="accountID">The ID of the Talon.One account that owns this program. (required).</param>
        /// <param name="name">The internal name for the Loyalty Program. This is an immutable value. (required).</param>
        /// <param name="tiers">The tiers in this loyalty program.</param>
        public LoyaltyProgram(int id = default(int), DateTime created = default(DateTime), string title = default(string), string description = default(string), List<int> subscribedApplications = default(List<int>), string defaultValidity = default(string), string defaultPending = default(string), bool allowSubledger = default(bool), int accountID = default(int), string name = default(string), List<LoyaltyTier> tiers = default(List<LoyaltyTier>))
        {
            this.Id = id;
            this.Created = created;
            // to ensure "title" is required (not null)
            this.Title = title ?? throw new ArgumentNullException("title is a required property for LoyaltyProgram and cannot be null");
            // to ensure "description" is required (not null)
            this.Description = description ?? throw new ArgumentNullException("description is a required property for LoyaltyProgram and cannot be null");
            // to ensure "subscribedApplications" is required (not null)
            this.SubscribedApplications = subscribedApplications ?? throw new ArgumentNullException("subscribedApplications is a required property for LoyaltyProgram and cannot be null");
            // to ensure "defaultValidity" is required (not null)
            this.DefaultValidity = defaultValidity ?? throw new ArgumentNullException("defaultValidity is a required property for LoyaltyProgram and cannot be null");
            // to ensure "defaultPending" is required (not null)
            this.DefaultPending = defaultPending ?? throw new ArgumentNullException("defaultPending is a required property for LoyaltyProgram and cannot be null");
            this.AllowSubledger = allowSubledger;
            this.AccountID = accountID;
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for LoyaltyProgram and cannot be null");
            this.Tiers = tiers;
        }
        
        /// <summary>
        /// The ID of loyalty program. Unique ID for this entity.
        /// </summary>
        /// <value>The ID of loyalty program. Unique ID for this entity.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int Id { get; set; }

        /// <summary>
        /// The exact moment this entity was created.
        /// </summary>
        /// <value>The exact moment this entity was created.</value>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public DateTime Created { get; set; }

        /// <summary>
        /// The display title for the Loyalty Program.
        /// </summary>
        /// <value>The display title for the Loyalty Program.</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Description of our Loyalty Program.
        /// </summary>
        /// <value>Description of our Loyalty Program.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// A list containing the IDs of all applications that are subscribed to this Loyalty Program.
        /// </summary>
        /// <value>A list containing the IDs of all applications that are subscribed to this Loyalty Program.</value>
        [DataMember(Name="subscribedApplications", EmitDefaultValue=false)]
        public List<int> SubscribedApplications { get; set; }

        /// <summary>
        /// Indicates the default duration after which new loyalty points should expire. The format is a number, followed by one letter indicating the unit; like &#39;1h&#39; or &#39;40m&#39;.
        /// </summary>
        /// <value>Indicates the default duration after which new loyalty points should expire. The format is a number, followed by one letter indicating the unit; like &#39;1h&#39; or &#39;40m&#39;.</value>
        [DataMember(Name="defaultValidity", EmitDefaultValue=false)]
        public string DefaultValidity { get; set; }

        /// <summary>
        /// Indicates the default duration for the pending time, after which points will be valid. The format is a number followed by a duration unit, like &#39;1h&#39; or &#39;40m&#39;.
        /// </summary>
        /// <value>Indicates the default duration for the pending time, after which points will be valid. The format is a number followed by a duration unit, like &#39;1h&#39; or &#39;40m&#39;.</value>
        [DataMember(Name="defaultPending", EmitDefaultValue=false)]
        public string DefaultPending { get; set; }

        /// <summary>
        /// Indicates if this program supports subledgers inside the program
        /// </summary>
        /// <value>Indicates if this program supports subledgers inside the program</value>
        [DataMember(Name="allowSubledger", EmitDefaultValue=false)]
        public bool AllowSubledger { get; set; }

        /// <summary>
        /// The ID of the Talon.One account that owns this program.
        /// </summary>
        /// <value>The ID of the Talon.One account that owns this program.</value>
        [DataMember(Name="accountID", EmitDefaultValue=false)]
        public int AccountID { get; set; }

        /// <summary>
        /// The internal name for the Loyalty Program. This is an immutable value.
        /// </summary>
        /// <value>The internal name for the Loyalty Program. This is an immutable value.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The tiers in this loyalty program
        /// </summary>
        /// <value>The tiers in this loyalty program</value>
        [DataMember(Name="tiers", EmitDefaultValue=false)]
        public List<LoyaltyTier> Tiers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoyaltyProgram {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  SubscribedApplications: ").Append(SubscribedApplications).Append("\n");
            sb.Append("  DefaultValidity: ").Append(DefaultValidity).Append("\n");
            sb.Append("  DefaultPending: ").Append(DefaultPending).Append("\n");
            sb.Append("  AllowSubledger: ").Append(AllowSubledger).Append("\n");
            sb.Append("  AccountID: ").Append(AccountID).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Tiers: ").Append(Tiers).Append("\n");
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
            return this.Equals(input as LoyaltyProgram);
        }

        /// <summary>
        /// Returns true if LoyaltyProgram instances are equal
        /// </summary>
        /// <param name="input">Instance of LoyaltyProgram to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoyaltyProgram input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.SubscribedApplications == input.SubscribedApplications ||
                    this.SubscribedApplications != null &&
                    input.SubscribedApplications != null &&
                    this.SubscribedApplications.SequenceEqual(input.SubscribedApplications)
                ) && 
                (
                    this.DefaultValidity == input.DefaultValidity ||
                    (this.DefaultValidity != null &&
                    this.DefaultValidity.Equals(input.DefaultValidity))
                ) && 
                (
                    this.DefaultPending == input.DefaultPending ||
                    (this.DefaultPending != null &&
                    this.DefaultPending.Equals(input.DefaultPending))
                ) && 
                (
                    this.AllowSubledger == input.AllowSubledger ||
                    this.AllowSubledger.Equals(input.AllowSubledger)
                ) && 
                (
                    this.AccountID == input.AccountID ||
                    this.AccountID.Equals(input.AccountID)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Tiers == input.Tiers ||
                    this.Tiers != null &&
                    input.Tiers != null &&
                    this.Tiers.SequenceEqual(input.Tiers)
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
                hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.SubscribedApplications != null)
                    hashCode = hashCode * 59 + this.SubscribedApplications.GetHashCode();
                if (this.DefaultValidity != null)
                    hashCode = hashCode * 59 + this.DefaultValidity.GetHashCode();
                if (this.DefaultPending != null)
                    hashCode = hashCode * 59 + this.DefaultPending.GetHashCode();
                hashCode = hashCode * 59 + this.AllowSubledger.GetHashCode();
                hashCode = hashCode * 59 + this.AccountID.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Tiers != null)
                    hashCode = hashCode * 59 + this.Tiers.GetHashCode();
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
