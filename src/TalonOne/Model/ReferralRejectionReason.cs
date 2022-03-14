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
    /// Holds a reference to the campaign, the referral and the reason for which that referral was rejected. Should only be present when there is a &#39;rejectReferral&#39; effect.
    /// </summary>
    [DataContract]
    public partial class ReferralRejectionReason :  IEquatable<ReferralRejectionReason>, IValidatableObject
    {
        /// <summary>
        /// Defines Reason
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ReasonEnum
        {
            /// <summary>
            /// Enum ReferralNotFound for value: ReferralNotFound
            /// </summary>
            [EnumMember(Value = "ReferralNotFound")]
            ReferralNotFound = 1,

            /// <summary>
            /// Enum ReferralRecipientIdSameAsAdvocate for value: ReferralRecipientIdSameAsAdvocate
            /// </summary>
            [EnumMember(Value = "ReferralRecipientIdSameAsAdvocate")]
            ReferralRecipientIdSameAsAdvocate = 2,

            /// <summary>
            /// Enum ReferralPartOfNotRunningCampaign for value: ReferralPartOfNotRunningCampaign
            /// </summary>
            [EnumMember(Value = "ReferralPartOfNotRunningCampaign")]
            ReferralPartOfNotRunningCampaign = 3,

            /// <summary>
            /// Enum ReferralLimitReached for value: ReferralLimitReached
            /// </summary>
            [EnumMember(Value = "ReferralLimitReached")]
            ReferralLimitReached = 4,

            /// <summary>
            /// Enum CampaignLimitReached for value: CampaignLimitReached
            /// </summary>
            [EnumMember(Value = "CampaignLimitReached")]
            CampaignLimitReached = 5,

            /// <summary>
            /// Enum ProfileLimitReached for value: ProfileLimitReached
            /// </summary>
            [EnumMember(Value = "ProfileLimitReached")]
            ProfileLimitReached = 6,

            /// <summary>
            /// Enum ReferralRecipientDoesNotMatch for value: ReferralRecipientDoesNotMatch
            /// </summary>
            [EnumMember(Value = "ReferralRecipientDoesNotMatch")]
            ReferralRecipientDoesNotMatch = 7,

            /// <summary>
            /// Enum ReferralExpired for value: ReferralExpired
            /// </summary>
            [EnumMember(Value = "ReferralExpired")]
            ReferralExpired = 8,

            /// <summary>
            /// Enum ReferralStartDateInFuture for value: ReferralStartDateInFuture
            /// </summary>
            [EnumMember(Value = "ReferralStartDateInFuture")]
            ReferralStartDateInFuture = 9,

            /// <summary>
            /// Enum ReferralRejectedByCondition for value: ReferralRejectedByCondition
            /// </summary>
            [EnumMember(Value = "ReferralRejectedByCondition")]
            ReferralRejectedByCondition = 10,

            /// <summary>
            /// Enum EffectCouldNotBeApplied for value: EffectCouldNotBeApplied
            /// </summary>
            [EnumMember(Value = "EffectCouldNotBeApplied")]
            EffectCouldNotBeApplied = 11

        }

        /// <summary>
        /// Gets or Sets Reason
        /// </summary>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public ReasonEnum Reason { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReferralRejectionReason" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ReferralRejectionReason() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReferralRejectionReason" /> class.
        /// </summary>
        /// <param name="campaignId">campaignId (required).</param>
        /// <param name="referralId">referralId (required).</param>
        /// <param name="reason">reason (required).</param>
        public ReferralRejectionReason(int campaignId = default(int), int referralId = default(int), ReasonEnum reason = default(ReasonEnum))
        {
            this.CampaignId = campaignId;
            this.ReferralId = referralId;
            this.Reason = reason;
        }
        
        /// <summary>
        /// Gets or Sets CampaignId
        /// </summary>
        [DataMember(Name="campaignId", EmitDefaultValue=false)]
        public int CampaignId { get; set; }

        /// <summary>
        /// Gets or Sets ReferralId
        /// </summary>
        [DataMember(Name="referralId", EmitDefaultValue=false)]
        public int ReferralId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReferralRejectionReason {\n");
            sb.Append("  CampaignId: ").Append(CampaignId).Append("\n");
            sb.Append("  ReferralId: ").Append(ReferralId).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
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
            return this.Equals(input as ReferralRejectionReason);
        }

        /// <summary>
        /// Returns true if ReferralRejectionReason instances are equal
        /// </summary>
        /// <param name="input">Instance of ReferralRejectionReason to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReferralRejectionReason input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CampaignId == input.CampaignId ||
                    this.CampaignId.Equals(input.CampaignId)
                ) && 
                (
                    this.ReferralId == input.ReferralId ||
                    this.ReferralId.Equals(input.ReferralId)
                ) && 
                (
                    this.Reason == input.Reason ||
                    this.Reason.Equals(input.Reason)
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
                hashCode = hashCode * 59 + this.CampaignId.GetHashCode();
                hashCode = hashCode * 59 + this.ReferralId.GetHashCode();
                hashCode = hashCode * 59 + this.Reason.GetHashCode();
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
