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
    /// MultiApplicationEntity
    /// </summary>
    [DataContract]
    public partial class MultiApplicationEntity :  IEquatable<MultiApplicationEntity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MultiApplicationEntity" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MultiApplicationEntity() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MultiApplicationEntity" /> class.
        /// </summary>
        /// <param name="applicationIds">The IDs of the applications that are related to this entity. (required).</param>
        public MultiApplicationEntity(List<int> applicationIds = default(List<int>))
        {
            // to ensure "applicationIds" is required (not null)
            this.ApplicationIds = applicationIds ?? throw new ArgumentNullException("applicationIds is a required property for MultiApplicationEntity and cannot be null");
        }
        
        /// <summary>
        /// The IDs of the applications that are related to this entity.
        /// </summary>
        /// <value>The IDs of the applications that are related to this entity.</value>
        [DataMember(Name="applicationIds", EmitDefaultValue=false)]
        public List<int> ApplicationIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MultiApplicationEntity {\n");
            sb.Append("  ApplicationIds: ").Append(ApplicationIds).Append("\n");
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
            return this.Equals(input as MultiApplicationEntity);
        }

        /// <summary>
        /// Returns true if MultiApplicationEntity instances are equal
        /// </summary>
        /// <param name="input">Instance of MultiApplicationEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MultiApplicationEntity input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ApplicationIds == input.ApplicationIds ||
                    this.ApplicationIds != null &&
                    input.ApplicationIds != null &&
                    this.ApplicationIds.SequenceEqual(input.ApplicationIds)
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
                if (this.ApplicationIds != null)
                    hashCode = hashCode * 59 + this.ApplicationIds.GetHashCode();
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
