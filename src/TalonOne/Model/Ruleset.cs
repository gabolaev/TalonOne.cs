/* 
 * Talon.One API
 *
 * The Talon.One API is used to manage applications and campaigns, as well as to integrate with your application. The operations in the _Integration API_ section are used to integrate with our platform, while the other operations are used to manage applications and campaigns.  ### Where is the API?  The API is available at the same hostname as these docs. For example, if you are reading this page at `https://mycompany.talon.one/docs/api/`, the URL for the [updateCustomerProfile][] operation is `https://mycompany.talon.one/v1/customer_profiles/id`  [updateCustomerProfile]: #operation- -v1-customer_profiles- -integrationId- -put 
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using SwaggerDateConverter = TalonOne.Client.SwaggerDateConverter;

namespace TalonOne.Model
{
    /// <summary>
    /// Ruleset
    /// </summary>
    [DataContract]
    public partial class Ruleset :  IEquatable<Ruleset>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ruleset" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Ruleset() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Ruleset" /> class.
        /// </summary>
        /// <param name="id">Unique ID for this entity. (required).</param>
        /// <param name="created">The exact moment this entity was created. (required).</param>
        /// <param name="campaignId">The ID of the campaign that owns this entity. (required).</param>
        /// <param name="userId">The ID of the account that owns this entity. (required).</param>
        /// <param name="rules">Set of rules to apply. (required).</param>
        /// <param name="bindings">An array that provides objects with variable names (name) and talang expressions to whose result they are bound (expression) during rule evaluation. The order of the evaluation is decided by the position in the array. (required).</param>
        /// <param name="rbVersion">A string indicating which version of the rulebuilder was used to create this ruleset..</param>
        /// <param name="activate">A boolean indicating whether this newly created ruleset should also be activated for the campaign owns it.</param>
        /// <param name="activatedAt">Timestamp indicating when this Ruleset was activated..</param>
        public Ruleset(int? id = default(int?), DateTime? created = default(DateTime?), int? campaignId = default(int?), int? userId = default(int?), List<Rule> rules = default(List<Rule>), List<Binding> bindings = default(List<Binding>), string rbVersion = default(string), bool? activate = default(bool?), DateTime? activatedAt = default(DateTime?))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for Ruleset and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "created" is required (not null)
            if (created == null)
            {
                throw new InvalidDataException("created is a required property for Ruleset and cannot be null");
            }
            else
            {
                this.Created = created;
            }
            // to ensure "campaignId" is required (not null)
            if (campaignId == null)
            {
                throw new InvalidDataException("campaignId is a required property for Ruleset and cannot be null");
            }
            else
            {
                this.CampaignId = campaignId;
            }
            // to ensure "userId" is required (not null)
            if (userId == null)
            {
                throw new InvalidDataException("userId is a required property for Ruleset and cannot be null");
            }
            else
            {
                this.UserId = userId;
            }
            // to ensure "rules" is required (not null)
            if (rules == null)
            {
                throw new InvalidDataException("rules is a required property for Ruleset and cannot be null");
            }
            else
            {
                this.Rules = rules;
            }
            // to ensure "bindings" is required (not null)
            if (bindings == null)
            {
                throw new InvalidDataException("bindings is a required property for Ruleset and cannot be null");
            }
            else
            {
                this.Bindings = bindings;
            }
            this.RbVersion = rbVersion;
            this.Activate = activate;
            this.ActivatedAt = activatedAt;
        }
        
        /// <summary>
        /// Unique ID for this entity.
        /// </summary>
        /// <value>Unique ID for this entity.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// The exact moment this entity was created.
        /// </summary>
        /// <value>The exact moment this entity was created.</value>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// The ID of the campaign that owns this entity.
        /// </summary>
        /// <value>The ID of the campaign that owns this entity.</value>
        [DataMember(Name="campaignId", EmitDefaultValue=false)]
        public int? CampaignId { get; set; }

        /// <summary>
        /// The ID of the account that owns this entity.
        /// </summary>
        /// <value>The ID of the account that owns this entity.</value>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public int? UserId { get; set; }

        /// <summary>
        /// Set of rules to apply.
        /// </summary>
        /// <value>Set of rules to apply.</value>
        [DataMember(Name="rules", EmitDefaultValue=false)]
        public List<Rule> Rules { get; set; }

        /// <summary>
        /// An array that provides objects with variable names (name) and talang expressions to whose result they are bound (expression) during rule evaluation. The order of the evaluation is decided by the position in the array.
        /// </summary>
        /// <value>An array that provides objects with variable names (name) and talang expressions to whose result they are bound (expression) during rule evaluation. The order of the evaluation is decided by the position in the array.</value>
        [DataMember(Name="bindings", EmitDefaultValue=false)]
        public List<Binding> Bindings { get; set; }

        /// <summary>
        /// A string indicating which version of the rulebuilder was used to create this ruleset.
        /// </summary>
        /// <value>A string indicating which version of the rulebuilder was used to create this ruleset.</value>
        [DataMember(Name="rbVersion", EmitDefaultValue=false)]
        public string RbVersion { get; set; }

        /// <summary>
        /// A boolean indicating whether this newly created ruleset should also be activated for the campaign owns it
        /// </summary>
        /// <value>A boolean indicating whether this newly created ruleset should also be activated for the campaign owns it</value>
        [DataMember(Name="activate", EmitDefaultValue=false)]
        public bool? Activate { get; set; }

        /// <summary>
        /// Timestamp indicating when this Ruleset was activated.
        /// </summary>
        /// <value>Timestamp indicating when this Ruleset was activated.</value>
        [DataMember(Name="activatedAt", EmitDefaultValue=false)]
        public DateTime? ActivatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ruleset {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  CampaignId: ").Append(CampaignId).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Rules: ").Append(Rules).Append("\n");
            sb.Append("  Bindings: ").Append(Bindings).Append("\n");
            sb.Append("  RbVersion: ").Append(RbVersion).Append("\n");
            sb.Append("  Activate: ").Append(Activate).Append("\n");
            sb.Append("  ActivatedAt: ").Append(ActivatedAt).Append("\n");
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
            return this.Equals(input as Ruleset);
        }

        /// <summary>
        /// Returns true if Ruleset instances are equal
        /// </summary>
        /// <param name="input">Instance of Ruleset to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ruleset input)
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
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.CampaignId == input.CampaignId ||
                    (this.CampaignId != null &&
                    this.CampaignId.Equals(input.CampaignId))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.Rules == input.Rules ||
                    this.Rules != null &&
                    this.Rules.SequenceEqual(input.Rules)
                ) && 
                (
                    this.Bindings == input.Bindings ||
                    this.Bindings != null &&
                    this.Bindings.SequenceEqual(input.Bindings)
                ) && 
                (
                    this.RbVersion == input.RbVersion ||
                    (this.RbVersion != null &&
                    this.RbVersion.Equals(input.RbVersion))
                ) && 
                (
                    this.Activate == input.Activate ||
                    (this.Activate != null &&
                    this.Activate.Equals(input.Activate))
                ) && 
                (
                    this.ActivatedAt == input.ActivatedAt ||
                    (this.ActivatedAt != null &&
                    this.ActivatedAt.Equals(input.ActivatedAt))
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
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.CampaignId != null)
                    hashCode = hashCode * 59 + this.CampaignId.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.Rules != null)
                    hashCode = hashCode * 59 + this.Rules.GetHashCode();
                if (this.Bindings != null)
                    hashCode = hashCode * 59 + this.Bindings.GetHashCode();
                if (this.RbVersion != null)
                    hashCode = hashCode * 59 + this.RbVersion.GetHashCode();
                if (this.Activate != null)
                    hashCode = hashCode * 59 + this.Activate.GetHashCode();
                if (this.ActivatedAt != null)
                    hashCode = hashCode * 59 + this.ActivatedAt.GetHashCode();
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
