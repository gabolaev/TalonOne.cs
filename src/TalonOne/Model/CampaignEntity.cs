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
    /// CampaignEntity
    /// </summary>
    [DataContract]
    public partial class CampaignEntity :  IEquatable<CampaignEntity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignEntity" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CampaignEntity() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignEntity" /> class.
        /// </summary>
        /// <param name="campaignId">The ID of the campaign that owns this entity. (required).</param>
        public CampaignEntity(int? campaignId = default(int?))
        {
            // to ensure "campaignId" is required (not null)
            if (campaignId == null)
            {
                throw new InvalidDataException("campaignId is a required property for CampaignEntity and cannot be null");
            }
            else
            {
                this.CampaignId = campaignId;
            }
        }
        
        /// <summary>
        /// The ID of the campaign that owns this entity.
        /// </summary>
        /// <value>The ID of the campaign that owns this entity.</value>
        [DataMember(Name="campaignId", EmitDefaultValue=false)]
        public int? CampaignId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CampaignEntity {\n");
            sb.Append("  CampaignId: ").Append(CampaignId).Append("\n");
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
            return this.Equals(input as CampaignEntity);
        }

        /// <summary>
        /// Returns true if CampaignEntity instances are equal
        /// </summary>
        /// <param name="input">Instance of CampaignEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CampaignEntity input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CampaignId == input.CampaignId ||
                    (this.CampaignId != null &&
                    this.CampaignId.Equals(input.CampaignId))
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
