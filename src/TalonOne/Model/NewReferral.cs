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
    /// NewReferral
    /// </summary>
    [DataContract]
    public partial class NewReferral :  IEquatable<NewReferral>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NewReferral" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NewReferral() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NewReferral" /> class.
        /// </summary>
        /// <param name="campaignId">ID of the campaign from which the referral received the referral code. (required).</param>
        /// <param name="advocateProfileIntegrationId">The Integration Id of the Advocate&#39;s Profile (required).</param>
        /// <param name="friendProfileIntegrationId">An optional Integration ID of the Friend&#39;s Profile.</param>
        /// <param name="startDate">Timestamp at which point the referral code becomes valid..</param>
        /// <param name="expiryDate">Expiry date of the referral code. Referral never expires if this is omitted, zero, or negative..</param>
        public NewReferral(int? campaignId = default(int?), string advocateProfileIntegrationId = default(string), string friendProfileIntegrationId = default(string), DateTime? startDate = default(DateTime?), DateTime? expiryDate = default(DateTime?))
        {
            // to ensure "campaignId" is required (not null)
            if (campaignId == null)
            {
                throw new InvalidDataException("campaignId is a required property for NewReferral and cannot be null");
            }
            else
            {
                this.CampaignId = campaignId;
            }
            // to ensure "advocateProfileIntegrationId" is required (not null)
            if (advocateProfileIntegrationId == null)
            {
                throw new InvalidDataException("advocateProfileIntegrationId is a required property for NewReferral and cannot be null");
            }
            else
            {
                this.AdvocateProfileIntegrationId = advocateProfileIntegrationId;
            }
            this.FriendProfileIntegrationId = friendProfileIntegrationId;
            this.StartDate = startDate;
            this.ExpiryDate = expiryDate;
        }
        
        /// <summary>
        /// ID of the campaign from which the referral received the referral code.
        /// </summary>
        /// <value>ID of the campaign from which the referral received the referral code.</value>
        [DataMember(Name="campaignId", EmitDefaultValue=false)]
        public int? CampaignId { get; set; }

        /// <summary>
        /// The Integration Id of the Advocate&#39;s Profile
        /// </summary>
        /// <value>The Integration Id of the Advocate&#39;s Profile</value>
        [DataMember(Name="advocateProfileIntegrationId", EmitDefaultValue=false)]
        public string AdvocateProfileIntegrationId { get; set; }

        /// <summary>
        /// An optional Integration ID of the Friend&#39;s Profile
        /// </summary>
        /// <value>An optional Integration ID of the Friend&#39;s Profile</value>
        [DataMember(Name="friendProfileIntegrationId", EmitDefaultValue=false)]
        public string FriendProfileIntegrationId { get; set; }

        /// <summary>
        /// Timestamp at which point the referral code becomes valid.
        /// </summary>
        /// <value>Timestamp at which point the referral code becomes valid.</value>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Expiry date of the referral code. Referral never expires if this is omitted, zero, or negative.
        /// </summary>
        /// <value>Expiry date of the referral code. Referral never expires if this is omitted, zero, or negative.</value>
        [DataMember(Name="expiryDate", EmitDefaultValue=false)]
        public DateTime? ExpiryDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NewReferral {\n");
            sb.Append("  CampaignId: ").Append(CampaignId).Append("\n");
            sb.Append("  AdvocateProfileIntegrationId: ").Append(AdvocateProfileIntegrationId).Append("\n");
            sb.Append("  FriendProfileIntegrationId: ").Append(FriendProfileIntegrationId).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  ExpiryDate: ").Append(ExpiryDate).Append("\n");
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
            return this.Equals(input as NewReferral);
        }

        /// <summary>
        /// Returns true if NewReferral instances are equal
        /// </summary>
        /// <param name="input">Instance of NewReferral to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NewReferral input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CampaignId == input.CampaignId ||
                    (this.CampaignId != null &&
                    this.CampaignId.Equals(input.CampaignId))
                ) && 
                (
                    this.AdvocateProfileIntegrationId == input.AdvocateProfileIntegrationId ||
                    (this.AdvocateProfileIntegrationId != null &&
                    this.AdvocateProfileIntegrationId.Equals(input.AdvocateProfileIntegrationId))
                ) && 
                (
                    this.FriendProfileIntegrationId == input.FriendProfileIntegrationId ||
                    (this.FriendProfileIntegrationId != null &&
                    this.FriendProfileIntegrationId.Equals(input.FriendProfileIntegrationId))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.ExpiryDate == input.ExpiryDate ||
                    (this.ExpiryDate != null &&
                    this.ExpiryDate.Equals(input.ExpiryDate))
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
                if (this.CampaignId != null)
                    hashCode = hashCode * 59 + this.CampaignId.GetHashCode();
                if (this.AdvocateProfileIntegrationId != null)
                    hashCode = hashCode * 59 + this.AdvocateProfileIntegrationId.GetHashCode();
                if (this.FriendProfileIntegrationId != null)
                    hashCode = hashCode * 59 + this.FriendProfileIntegrationId.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.ExpiryDate != null)
                    hashCode = hashCode * 59 + this.ExpiryDate.GetHashCode();
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
