/* 
 * Talon.One API
 *
 * Use the Talon.One API to integrate with your application and to manage applications and campaigns:  - Use the operations in the [Integration API section](#integration-api) are used to integrate with our platform - Use the operation in the [Management API section](#management-api) to manage applications and campaigns.  ## Determining the base URL of the endpoints  The API is available at the same hostname as your Campaign Manager deployment. For example, if you access the Campaign Manager at `https://yourbaseurl.talon.one/`, the URL for the [updateCustomerSessionV2](https://docs.talon.one/integration-api#operation/updateCustomerSessionV2) endpoint is `https://yourbaseurl.talon.one/v2/customer_sessions/{Id}` 
 *
 * 
 * Contact: devs@talon.one
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
    /// RoleV2Permissions
    /// </summary>
    [DataContract]
    public partial class RoleV2Permissions :  IEquatable<RoleV2Permissions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoleV2Permissions" /> class.
        /// </summary>
        /// <param name="permissionSets">List of grouped operation IDs to use as a reference in the roles section. Each group of operation IDs has a name..</param>
        /// <param name="roles">roles.</param>
        public RoleV2Permissions(List<RoleV2PermissionSet> permissionSets = default(List<RoleV2PermissionSet>), RoleV2PermissionsRoles roles = default(RoleV2PermissionsRoles))
        {
            this.PermissionSets = permissionSets;
            this.Roles = roles;
        }
        
        /// <summary>
        /// List of grouped operation IDs to use as a reference in the roles section. Each group of operation IDs has a name.
        /// </summary>
        /// <value>List of grouped operation IDs to use as a reference in the roles section. Each group of operation IDs has a name.</value>
        [DataMember(Name="permissionSets", EmitDefaultValue=false)]
        public List<RoleV2PermissionSet> PermissionSets { get; set; }

        /// <summary>
        /// Gets or Sets Roles
        /// </summary>
        [DataMember(Name="roles", EmitDefaultValue=false)]
        public RoleV2PermissionsRoles Roles { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RoleV2Permissions {\n");
            sb.Append("  PermissionSets: ").Append(PermissionSets).Append("\n");
            sb.Append("  Roles: ").Append(Roles).Append("\n");
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
            return this.Equals(input as RoleV2Permissions);
        }

        /// <summary>
        /// Returns true if RoleV2Permissions instances are equal
        /// </summary>
        /// <param name="input">Instance of RoleV2Permissions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RoleV2Permissions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PermissionSets == input.PermissionSets ||
                    this.PermissionSets != null &&
                    input.PermissionSets != null &&
                    this.PermissionSets.SequenceEqual(input.PermissionSets)
                ) && 
                (
                    this.Roles == input.Roles ||
                    (this.Roles != null &&
                    this.Roles.Equals(input.Roles))
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
                if (this.PermissionSets != null)
                    hashCode = hashCode * 59 + this.PermissionSets.GetHashCode();
                if (this.Roles != null)
                    hashCode = hashCode * 59 + this.Roles.GetHashCode();
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
