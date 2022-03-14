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
    /// The source of the current error, exactly one of &#x60;pointer&#x60;, &#x60;parameter&#x60; or &#x60;line&#x60; will be defined. 
    /// </summary>
    [DataContract]
    public partial class ErrorSource :  IEquatable<ErrorSource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorSource" /> class.
        /// </summary>
        /// <param name="pointer">Pointer to the path in the payload that caused this error..</param>
        /// <param name="_parameter">Query parameter that caused this error..</param>
        /// <param name="line">Line number in uploaded multipart file that caused this error. &#39;N/A&#39; if unknown..</param>
        /// <param name="resource">Pointer to the resource that caused this error.</param>
        public ErrorSource(string pointer = default(string), string _parameter = default(string), string line = default(string), string resource = default(string))
        {
            this.Pointer = pointer;
            this.Parameter = _parameter;
            this.Line = line;
            this.Resource = resource;
        }
        
        /// <summary>
        /// Pointer to the path in the payload that caused this error.
        /// </summary>
        /// <value>Pointer to the path in the payload that caused this error.</value>
        [DataMember(Name="pointer", EmitDefaultValue=false)]
        public string Pointer { get; set; }

        /// <summary>
        /// Query parameter that caused this error.
        /// </summary>
        /// <value>Query parameter that caused this error.</value>
        [DataMember(Name="parameter", EmitDefaultValue=false)]
        public string Parameter { get; set; }

        /// <summary>
        /// Line number in uploaded multipart file that caused this error. &#39;N/A&#39; if unknown.
        /// </summary>
        /// <value>Line number in uploaded multipart file that caused this error. &#39;N/A&#39; if unknown.</value>
        [DataMember(Name="line", EmitDefaultValue=false)]
        public string Line { get; set; }

        /// <summary>
        /// Pointer to the resource that caused this error
        /// </summary>
        /// <value>Pointer to the resource that caused this error</value>
        [DataMember(Name="resource", EmitDefaultValue=false)]
        public string Resource { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ErrorSource {\n");
            sb.Append("  Pointer: ").Append(Pointer).Append("\n");
            sb.Append("  Parameter: ").Append(Parameter).Append("\n");
            sb.Append("  Line: ").Append(Line).Append("\n");
            sb.Append("  Resource: ").Append(Resource).Append("\n");
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
            return this.Equals(input as ErrorSource);
        }

        /// <summary>
        /// Returns true if ErrorSource instances are equal
        /// </summary>
        /// <param name="input">Instance of ErrorSource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ErrorSource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Pointer == input.Pointer ||
                    (this.Pointer != null &&
                    this.Pointer.Equals(input.Pointer))
                ) && 
                (
                    this.Parameter == input.Parameter ||
                    (this.Parameter != null &&
                    this.Parameter.Equals(input.Parameter))
                ) && 
                (
                    this.Line == input.Line ||
                    (this.Line != null &&
                    this.Line.Equals(input.Line))
                ) && 
                (
                    this.Resource == input.Resource ||
                    (this.Resource != null &&
                    this.Resource.Equals(input.Resource))
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
                if (this.Pointer != null)
                    hashCode = hashCode * 59 + this.Pointer.GetHashCode();
                if (this.Parameter != null)
                    hashCode = hashCode * 59 + this.Parameter.GetHashCode();
                if (this.Line != null)
                    hashCode = hashCode * 59 + this.Line.GetHashCode();
                if (this.Resource != null)
                    hashCode = hashCode * 59 + this.Resource.GetHashCode();
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
