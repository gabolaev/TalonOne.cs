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
    /// LimitCounter
    /// </summary>
    [DataContract]
    public partial class LimitCounter :  IEquatable<LimitCounter>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LimitCounter" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LimitCounter() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LimitCounter" /> class.
        /// </summary>
        /// <param name="campaignId">The ID of the campaign that owns this entity. (required).</param>
        /// <param name="applicationId">The ID of the application that owns this entity. (required).</param>
        /// <param name="accountId">The ID of the account that owns this entity. (required).</param>
        /// <param name="id">Unique ID for this entity. (required).</param>
        /// <param name="action">The limitable action of the limit counter. (required).</param>
        /// <param name="profileId">The profile ID for which this limit counter is used..</param>
        /// <param name="profileIntegrationId">The profile integration ID for which this limit counter is used..</param>
        /// <param name="couponId">The coupon ID for which this limit counter is used..</param>
        /// <param name="couponValue">The coupon value for which this limit counter is used..</param>
        /// <param name="referralId">The referral ID for which this limit counter is used..</param>
        /// <param name="referralValue">The referral value for which this limit counter is used..</param>
        /// <param name="identifier">The arbitrary identifier for which this limit counter is used..</param>
        /// <param name="period">The time period for which this limit counter is used..</param>
        /// <param name="limit">The highest possible value for this limit counter. (required).</param>
        /// <param name="counter">The current value for this limit counter. (required).</param>
        public LimitCounter(int campaignId = default(int), int applicationId = default(int), int accountId = default(int), int id = default(int), string action = default(string), int profileId = default(int), string profileIntegrationId = default(string), int couponId = default(int), string couponValue = default(string), int referralId = default(int), string referralValue = default(string), int identifier = default(int), string period = default(string), decimal limit = default(decimal), decimal counter = default(decimal))
        {
            this.CampaignId = campaignId;
            this.ApplicationId = applicationId;
            this.AccountId = accountId;
            this.Id = id;
            // to ensure "action" is required (not null)
            this.Action = action ?? throw new ArgumentNullException("action is a required property for LimitCounter and cannot be null");
            this.Limit = limit;
            this.Counter = counter;
            this.ProfileId = profileId;
            this.ProfileIntegrationId = profileIntegrationId;
            this.CouponId = couponId;
            this.CouponValue = couponValue;
            this.ReferralId = referralId;
            this.ReferralValue = referralValue;
            this.Identifier = identifier;
            this.Period = period;
        }
        
        /// <summary>
        /// The ID of the campaign that owns this entity.
        /// </summary>
        /// <value>The ID of the campaign that owns this entity.</value>
        [DataMember(Name="campaignId", EmitDefaultValue=false)]
        public int CampaignId { get; set; }

        /// <summary>
        /// The ID of the application that owns this entity.
        /// </summary>
        /// <value>The ID of the application that owns this entity.</value>
        [DataMember(Name="applicationId", EmitDefaultValue=false)]
        public int ApplicationId { get; set; }

        /// <summary>
        /// The ID of the account that owns this entity.
        /// </summary>
        /// <value>The ID of the account that owns this entity.</value>
        [DataMember(Name="accountId", EmitDefaultValue=false)]
        public int AccountId { get; set; }

        /// <summary>
        /// Unique ID for this entity.
        /// </summary>
        /// <value>Unique ID for this entity.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int Id { get; set; }

        /// <summary>
        /// The limitable action of the limit counter.
        /// </summary>
        /// <value>The limitable action of the limit counter.</value>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public string Action { get; set; }

        /// <summary>
        /// The profile ID for which this limit counter is used.
        /// </summary>
        /// <value>The profile ID for which this limit counter is used.</value>
        [DataMember(Name="profileId", EmitDefaultValue=false)]
        public int ProfileId { get; set; }

        /// <summary>
        /// The profile integration ID for which this limit counter is used.
        /// </summary>
        /// <value>The profile integration ID for which this limit counter is used.</value>
        [DataMember(Name="profileIntegrationId", EmitDefaultValue=false)]
        public string ProfileIntegrationId { get; set; }

        /// <summary>
        /// The coupon ID for which this limit counter is used.
        /// </summary>
        /// <value>The coupon ID for which this limit counter is used.</value>
        [DataMember(Name="couponId", EmitDefaultValue=false)]
        public int CouponId { get; set; }

        /// <summary>
        /// The coupon value for which this limit counter is used.
        /// </summary>
        /// <value>The coupon value for which this limit counter is used.</value>
        [DataMember(Name="couponValue", EmitDefaultValue=false)]
        public string CouponValue { get; set; }

        /// <summary>
        /// The referral ID for which this limit counter is used.
        /// </summary>
        /// <value>The referral ID for which this limit counter is used.</value>
        [DataMember(Name="referralId", EmitDefaultValue=false)]
        public int ReferralId { get; set; }

        /// <summary>
        /// The referral value for which this limit counter is used.
        /// </summary>
        /// <value>The referral value for which this limit counter is used.</value>
        [DataMember(Name="referralValue", EmitDefaultValue=false)]
        public string ReferralValue { get; set; }

        /// <summary>
        /// The arbitrary identifier for which this limit counter is used.
        /// </summary>
        /// <value>The arbitrary identifier for which this limit counter is used.</value>
        [DataMember(Name="identifier", EmitDefaultValue=false)]
        public int Identifier { get; set; }

        /// <summary>
        /// The time period for which this limit counter is used.
        /// </summary>
        /// <value>The time period for which this limit counter is used.</value>
        [DataMember(Name="period", EmitDefaultValue=false)]
        public string Period { get; set; }

        /// <summary>
        /// The highest possible value for this limit counter.
        /// </summary>
        /// <value>The highest possible value for this limit counter.</value>
        [DataMember(Name="limit", EmitDefaultValue=false)]
        public decimal Limit { get; set; }

        /// <summary>
        /// The current value for this limit counter.
        /// </summary>
        /// <value>The current value for this limit counter.</value>
        [DataMember(Name="counter", EmitDefaultValue=false)]
        public decimal Counter { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LimitCounter {\n");
            sb.Append("  CampaignId: ").Append(CampaignId).Append("\n");
            sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  ProfileId: ").Append(ProfileId).Append("\n");
            sb.Append("  ProfileIntegrationId: ").Append(ProfileIntegrationId).Append("\n");
            sb.Append("  CouponId: ").Append(CouponId).Append("\n");
            sb.Append("  CouponValue: ").Append(CouponValue).Append("\n");
            sb.Append("  ReferralId: ").Append(ReferralId).Append("\n");
            sb.Append("  ReferralValue: ").Append(ReferralValue).Append("\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  Period: ").Append(Period).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  Counter: ").Append(Counter).Append("\n");
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
            return this.Equals(input as LimitCounter);
        }

        /// <summary>
        /// Returns true if LimitCounter instances are equal
        /// </summary>
        /// <param name="input">Instance of LimitCounter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LimitCounter input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CampaignId == input.CampaignId ||
                    this.CampaignId.Equals(input.CampaignId)
                ) && 
                (
                    this.ApplicationId == input.ApplicationId ||
                    this.ApplicationId.Equals(input.ApplicationId)
                ) && 
                (
                    this.AccountId == input.AccountId ||
                    this.AccountId.Equals(input.AccountId)
                ) && 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                ) && 
                (
                    this.ProfileId == input.ProfileId ||
                    this.ProfileId.Equals(input.ProfileId)
                ) && 
                (
                    this.ProfileIntegrationId == input.ProfileIntegrationId ||
                    (this.ProfileIntegrationId != null &&
                    this.ProfileIntegrationId.Equals(input.ProfileIntegrationId))
                ) && 
                (
                    this.CouponId == input.CouponId ||
                    this.CouponId.Equals(input.CouponId)
                ) && 
                (
                    this.CouponValue == input.CouponValue ||
                    (this.CouponValue != null &&
                    this.CouponValue.Equals(input.CouponValue))
                ) && 
                (
                    this.ReferralId == input.ReferralId ||
                    this.ReferralId.Equals(input.ReferralId)
                ) && 
                (
                    this.ReferralValue == input.ReferralValue ||
                    (this.ReferralValue != null &&
                    this.ReferralValue.Equals(input.ReferralValue))
                ) && 
                (
                    this.Identifier == input.Identifier ||
                    this.Identifier.Equals(input.Identifier)
                ) && 
                (
                    this.Period == input.Period ||
                    (this.Period != null &&
                    this.Period.Equals(input.Period))
                ) && 
                (
                    this.Limit == input.Limit ||
                    this.Limit.Equals(input.Limit)
                ) && 
                (
                    this.Counter == input.Counter ||
                    this.Counter.Equals(input.Counter)
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
                hashCode = hashCode * 59 + this.ApplicationId.GetHashCode();
                hashCode = hashCode * 59 + this.AccountId.GetHashCode();
                hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Action != null)
                    hashCode = hashCode * 59 + this.Action.GetHashCode();
                hashCode = hashCode * 59 + this.ProfileId.GetHashCode();
                if (this.ProfileIntegrationId != null)
                    hashCode = hashCode * 59 + this.ProfileIntegrationId.GetHashCode();
                hashCode = hashCode * 59 + this.CouponId.GetHashCode();
                if (this.CouponValue != null)
                    hashCode = hashCode * 59 + this.CouponValue.GetHashCode();
                hashCode = hashCode * 59 + this.ReferralId.GetHashCode();
                if (this.ReferralValue != null)
                    hashCode = hashCode * 59 + this.ReferralValue.GetHashCode();
                hashCode = hashCode * 59 + this.Identifier.GetHashCode();
                if (this.Period != null)
                    hashCode = hashCode * 59 + this.Period.GetHashCode();
                hashCode = hashCode * 59 + this.Limit.GetHashCode();
                hashCode = hashCode * 59 + this.Counter.GetHashCode();
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
