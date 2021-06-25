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
    /// CreateTemplateCampaignResponse
    /// </summary>
    [DataContract]
    public partial class CreateTemplateCampaignResponse :  IEquatable<CreateTemplateCampaignResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTemplateCampaignResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateTemplateCampaignResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTemplateCampaignResponse" /> class.
        /// </summary>
        /// <param name="campaign">campaign (required).</param>
        /// <param name="ruleset">ruleset (required).</param>
        public CreateTemplateCampaignResponse(Campaign campaign = default(Campaign), Ruleset ruleset = default(Ruleset))
        {
            // to ensure "campaign" is required (not null)
            this.Campaign = campaign ?? throw new ArgumentNullException("campaign is a required property for CreateTemplateCampaignResponse and cannot be null");
            // to ensure "ruleset" is required (not null)
            this.Ruleset = ruleset ?? throw new ArgumentNullException("ruleset is a required property for CreateTemplateCampaignResponse and cannot be null");
        }
        
        /// <summary>
        /// Gets or Sets Campaign
        /// </summary>
        [DataMember(Name="campaign", EmitDefaultValue=false)]
        public Campaign Campaign { get; set; }

        /// <summary>
        /// Gets or Sets Ruleset
        /// </summary>
        [DataMember(Name="ruleset", EmitDefaultValue=false)]
        public Ruleset Ruleset { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateTemplateCampaignResponse {\n");
            sb.Append("  Campaign: ").Append(Campaign).Append("\n");
            sb.Append("  Ruleset: ").Append(Ruleset).Append("\n");
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
            return this.Equals(input as CreateTemplateCampaignResponse);
        }

        /// <summary>
        /// Returns true if CreateTemplateCampaignResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateTemplateCampaignResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateTemplateCampaignResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Campaign == input.Campaign ||
                    (this.Campaign != null &&
                    this.Campaign.Equals(input.Campaign))
                ) && 
                (
                    this.Ruleset == input.Ruleset ||
                    (this.Ruleset != null &&
                    this.Ruleset.Equals(input.Ruleset))
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
                if (this.Campaign != null)
                    hashCode = hashCode * 59 + this.Campaign.GetHashCode();
                if (this.Ruleset != null)
                    hashCode = hashCode * 59 + this.Ruleset.GetHashCode();
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
