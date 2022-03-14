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
    /// LoyaltyCard
    /// </summary>
    [DataContract]
    public partial class LoyaltyCard :  IEquatable<LoyaltyCard>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoyaltyCard" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LoyaltyCard() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LoyaltyCard" /> class.
        /// </summary>
        /// <param name="id">Unique ID for this entity. (required).</param>
        /// <param name="created">The exact moment this entity was created. (required).</param>
        /// <param name="modified">The exact moment this entity was last modified. (required).</param>
        /// <param name="programID">The ID of the loyalty program that owns this entity. (required).</param>
        /// <param name="currentBalance">Sum of currently active points (required).</param>
        /// <param name="pendingBalance">Sum of pending points (required).</param>
        /// <param name="expiredBalance">Sum of expired points (required).</param>
        /// <param name="spentBalance">Sum of spent points (required).</param>
        /// <param name="tentativeCurrentBalance">Sum of currently active points, including points added and deducted in open sessions (required).</param>
        /// <param name="currentTier">currentTier.</param>
        /// <param name="pointsToNextTier">Points required to move up a tier..</param>
        /// <param name="projection">projection.</param>
        /// <param name="status">Status of the loyalty card. Can be one of: [&#39;active&#39;, &#39;disabled&#39;]  (required).</param>
        /// <param name="identifier">Identifier of the loyalty card. (required).</param>
        /// <param name="usersPerCardLimit">The max amount of user profiles a card can be shared with. 0 means unlimited.  (required).</param>
        /// <param name="profiles">Integration IDs of the customers associated with the card..</param>
        public LoyaltyCard(int id = default(int), DateTime created = default(DateTime), DateTime modified = default(DateTime), int programID = default(int), decimal currentBalance = default(decimal), decimal pendingBalance = default(decimal), decimal expiredBalance = default(decimal), decimal spentBalance = default(decimal), decimal tentativeCurrentBalance = default(decimal), Tier currentTier = default(Tier), decimal pointsToNextTier = default(decimal), LoyaltyProjection projection = default(LoyaltyProjection), string status = default(string), string identifier = default(string), int usersPerCardLimit = default(int), List<LoyaltyCardProfileRegistration> profiles = default(List<LoyaltyCardProfileRegistration>))
        {
            this.Id = id;
            this.Created = created;
            this.Modified = modified;
            this.ProgramID = programID;
            this.CurrentBalance = currentBalance;
            this.PendingBalance = pendingBalance;
            this.ExpiredBalance = expiredBalance;
            this.SpentBalance = spentBalance;
            this.TentativeCurrentBalance = tentativeCurrentBalance;
            // to ensure "status" is required (not null)
            this.Status = status ?? throw new ArgumentNullException("status is a required property for LoyaltyCard and cannot be null");
            // to ensure "identifier" is required (not null)
            this.Identifier = identifier ?? throw new ArgumentNullException("identifier is a required property for LoyaltyCard and cannot be null");
            this.UsersPerCardLimit = usersPerCardLimit;
            this.CurrentTier = currentTier;
            this.PointsToNextTier = pointsToNextTier;
            this.Projection = projection;
            this.Profiles = profiles;
        }
        
        /// <summary>
        /// Unique ID for this entity.
        /// </summary>
        /// <value>Unique ID for this entity.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int Id { get; set; }

        /// <summary>
        /// The exact moment this entity was created.
        /// </summary>
        /// <value>The exact moment this entity was created.</value>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public DateTime Created { get; set; }

        /// <summary>
        /// The exact moment this entity was last modified.
        /// </summary>
        /// <value>The exact moment this entity was last modified.</value>
        [DataMember(Name="modified", EmitDefaultValue=false)]
        public DateTime Modified { get; set; }

        /// <summary>
        /// The ID of the loyalty program that owns this entity.
        /// </summary>
        /// <value>The ID of the loyalty program that owns this entity.</value>
        [DataMember(Name="programID", EmitDefaultValue=false)]
        public int ProgramID { get; set; }

        /// <summary>
        /// Sum of currently active points
        /// </summary>
        /// <value>Sum of currently active points</value>
        [DataMember(Name="currentBalance", EmitDefaultValue=false)]
        public decimal CurrentBalance { get; set; }

        /// <summary>
        /// Sum of pending points
        /// </summary>
        /// <value>Sum of pending points</value>
        [DataMember(Name="pendingBalance", EmitDefaultValue=false)]
        public decimal PendingBalance { get; set; }

        /// <summary>
        /// Sum of expired points
        /// </summary>
        /// <value>Sum of expired points</value>
        [DataMember(Name="expiredBalance", EmitDefaultValue=false)]
        public decimal ExpiredBalance { get; set; }

        /// <summary>
        /// Sum of spent points
        /// </summary>
        /// <value>Sum of spent points</value>
        [DataMember(Name="spentBalance", EmitDefaultValue=false)]
        public decimal SpentBalance { get; set; }

        /// <summary>
        /// Sum of currently active points, including points added and deducted in open sessions
        /// </summary>
        /// <value>Sum of currently active points, including points added and deducted in open sessions</value>
        [DataMember(Name="tentativeCurrentBalance", EmitDefaultValue=false)]
        public decimal TentativeCurrentBalance { get; set; }

        /// <summary>
        /// Gets or Sets CurrentTier
        /// </summary>
        [DataMember(Name="currentTier", EmitDefaultValue=false)]
        public Tier CurrentTier { get; set; }

        /// <summary>
        /// Points required to move up a tier.
        /// </summary>
        /// <value>Points required to move up a tier.</value>
        [DataMember(Name="pointsToNextTier", EmitDefaultValue=false)]
        public decimal PointsToNextTier { get; set; }

        /// <summary>
        /// Gets or Sets Projection
        /// </summary>
        [DataMember(Name="projection", EmitDefaultValue=false)]
        public LoyaltyProjection Projection { get; set; }

        /// <summary>
        /// Status of the loyalty card. Can be one of: [&#39;active&#39;, &#39;disabled&#39;] 
        /// </summary>
        /// <value>Status of the loyalty card. Can be one of: [&#39;active&#39;, &#39;disabled&#39;] </value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Identifier of the loyalty card.
        /// </summary>
        /// <value>Identifier of the loyalty card.</value>
        [DataMember(Name="identifier", EmitDefaultValue=false)]
        public string Identifier { get; set; }

        /// <summary>
        /// The max amount of user profiles a card can be shared with. 0 means unlimited. 
        /// </summary>
        /// <value>The max amount of user profiles a card can be shared with. 0 means unlimited. </value>
        [DataMember(Name="usersPerCardLimit", EmitDefaultValue=false)]
        public int UsersPerCardLimit { get; set; }

        /// <summary>
        /// Integration IDs of the customers associated with the card.
        /// </summary>
        /// <value>Integration IDs of the customers associated with the card.</value>
        [DataMember(Name="profiles", EmitDefaultValue=false)]
        public List<LoyaltyCardProfileRegistration> Profiles { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoyaltyCard {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Modified: ").Append(Modified).Append("\n");
            sb.Append("  ProgramID: ").Append(ProgramID).Append("\n");
            sb.Append("  CurrentBalance: ").Append(CurrentBalance).Append("\n");
            sb.Append("  PendingBalance: ").Append(PendingBalance).Append("\n");
            sb.Append("  ExpiredBalance: ").Append(ExpiredBalance).Append("\n");
            sb.Append("  SpentBalance: ").Append(SpentBalance).Append("\n");
            sb.Append("  TentativeCurrentBalance: ").Append(TentativeCurrentBalance).Append("\n");
            sb.Append("  CurrentTier: ").Append(CurrentTier).Append("\n");
            sb.Append("  PointsToNextTier: ").Append(PointsToNextTier).Append("\n");
            sb.Append("  Projection: ").Append(Projection).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  UsersPerCardLimit: ").Append(UsersPerCardLimit).Append("\n");
            sb.Append("  Profiles: ").Append(Profiles).Append("\n");
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
            return this.Equals(input as LoyaltyCard);
        }

        /// <summary>
        /// Returns true if LoyaltyCard instances are equal
        /// </summary>
        /// <param name="input">Instance of LoyaltyCard to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoyaltyCard input)
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
                    this.Modified == input.Modified ||
                    (this.Modified != null &&
                    this.Modified.Equals(input.Modified))
                ) && 
                (
                    this.ProgramID == input.ProgramID ||
                    this.ProgramID.Equals(input.ProgramID)
                ) && 
                (
                    this.CurrentBalance == input.CurrentBalance ||
                    this.CurrentBalance.Equals(input.CurrentBalance)
                ) && 
                (
                    this.PendingBalance == input.PendingBalance ||
                    this.PendingBalance.Equals(input.PendingBalance)
                ) && 
                (
                    this.ExpiredBalance == input.ExpiredBalance ||
                    this.ExpiredBalance.Equals(input.ExpiredBalance)
                ) && 
                (
                    this.SpentBalance == input.SpentBalance ||
                    this.SpentBalance.Equals(input.SpentBalance)
                ) && 
                (
                    this.TentativeCurrentBalance == input.TentativeCurrentBalance ||
                    this.TentativeCurrentBalance.Equals(input.TentativeCurrentBalance)
                ) && 
                (
                    this.CurrentTier == input.CurrentTier ||
                    (this.CurrentTier != null &&
                    this.CurrentTier.Equals(input.CurrentTier))
                ) && 
                (
                    this.PointsToNextTier == input.PointsToNextTier ||
                    this.PointsToNextTier.Equals(input.PointsToNextTier)
                ) && 
                (
                    this.Projection == input.Projection ||
                    (this.Projection != null &&
                    this.Projection.Equals(input.Projection))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Identifier == input.Identifier ||
                    (this.Identifier != null &&
                    this.Identifier.Equals(input.Identifier))
                ) && 
                (
                    this.UsersPerCardLimit == input.UsersPerCardLimit ||
                    this.UsersPerCardLimit.Equals(input.UsersPerCardLimit)
                ) && 
                (
                    this.Profiles == input.Profiles ||
                    this.Profiles != null &&
                    input.Profiles != null &&
                    this.Profiles.SequenceEqual(input.Profiles)
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
                if (this.Modified != null)
                    hashCode = hashCode * 59 + this.Modified.GetHashCode();
                hashCode = hashCode * 59 + this.ProgramID.GetHashCode();
                hashCode = hashCode * 59 + this.CurrentBalance.GetHashCode();
                hashCode = hashCode * 59 + this.PendingBalance.GetHashCode();
                hashCode = hashCode * 59 + this.ExpiredBalance.GetHashCode();
                hashCode = hashCode * 59 + this.SpentBalance.GetHashCode();
                hashCode = hashCode * 59 + this.TentativeCurrentBalance.GetHashCode();
                if (this.CurrentTier != null)
                    hashCode = hashCode * 59 + this.CurrentTier.GetHashCode();
                hashCode = hashCode * 59 + this.PointsToNextTier.GetHashCode();
                if (this.Projection != null)
                    hashCode = hashCode * 59 + this.Projection.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Identifier != null)
                    hashCode = hashCode * 59 + this.Identifier.GetHashCode();
                hashCode = hashCode * 59 + this.UsersPerCardLimit.GetHashCode();
                if (this.Profiles != null)
                    hashCode = hashCode * 59 + this.Profiles.GetHashCode();
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
            // UsersPerCardLimit (int) minimum
            if(this.UsersPerCardLimit < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for UsersPerCardLimit, must be a value greater than or equal to 0.", new [] { "UsersPerCardLimit" });
            }

            yield break;
        }
    }

}
