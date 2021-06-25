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
    /// MultipleCustomerProfileIntegrationRequestItem
    /// </summary>
    [DataContract]
    public partial class MultipleCustomerProfileIntegrationRequestItem :  IEquatable<MultipleCustomerProfileIntegrationRequestItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MultipleCustomerProfileIntegrationRequestItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MultipleCustomerProfileIntegrationRequestItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MultipleCustomerProfileIntegrationRequestItem" /> class.
        /// </summary>
        /// <param name="attributes">Arbitrary properties associated with this item.</param>
        /// <param name="integrationId">The custom identifier for this profile, must be unique within the account. (required).</param>
        public MultipleCustomerProfileIntegrationRequestItem(Object attributes = default(Object), string integrationId = default(string))
        {
            // to ensure "integrationId" is required (not null)
            this.IntegrationId = integrationId ?? throw new ArgumentNullException("integrationId is a required property for MultipleCustomerProfileIntegrationRequestItem and cannot be null");
            this.Attributes = attributes;
        }
        
        /// <summary>
        /// Arbitrary properties associated with this item
        /// </summary>
        /// <value>Arbitrary properties associated with this item</value>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public Object Attributes { get; set; }

        /// <summary>
        /// The custom identifier for this profile, must be unique within the account.
        /// </summary>
        /// <value>The custom identifier for this profile, must be unique within the account.</value>
        [DataMember(Name="integrationId", EmitDefaultValue=false)]
        public string IntegrationId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MultipleCustomerProfileIntegrationRequestItem {\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  IntegrationId: ").Append(IntegrationId).Append("\n");
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
            return this.Equals(input as MultipleCustomerProfileIntegrationRequestItem);
        }

        /// <summary>
        /// Returns true if MultipleCustomerProfileIntegrationRequestItem instances are equal
        /// </summary>
        /// <param name="input">Instance of MultipleCustomerProfileIntegrationRequestItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MultipleCustomerProfileIntegrationRequestItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Attributes == input.Attributes ||
                    (this.Attributes != null &&
                    this.Attributes.Equals(input.Attributes))
                ) && 
                (
                    this.IntegrationId == input.IntegrationId ||
                    (this.IntegrationId != null &&
                    this.IntegrationId.Equals(input.IntegrationId))
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
                if (this.Attributes != null)
                    hashCode = hashCode * 59 + this.Attributes.GetHashCode();
                if (this.IntegrationId != null)
                    hashCode = hashCode * 59 + this.IntegrationId.GetHashCode();
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
