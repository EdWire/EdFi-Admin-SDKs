/*
 * Admin API Documentation
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = EdGraph.EdFiAdmin.Client.Client.OpenAPIDateConverter;

namespace EdGraph.EdFiAdmin.Client.Model
{
    /// <summary>
    /// EdFiOdsAdminApiFeaturesApplicationsProfile
    /// </summary>
    [DataContract(Name = "EdFi.Ods.AdminApi.Features.Applications.Profile")]
    public partial class EdFiOdsAdminApiFeaturesApplicationsProfile : IEquatable<EdFiOdsAdminApiFeaturesApplicationsProfile>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiOdsAdminApiFeaturesApplicationsProfile" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiOdsAdminApiFeaturesApplicationsProfile() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiOdsAdminApiFeaturesApplicationsProfile" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        public EdFiOdsAdminApiFeaturesApplicationsProfile(int? id = default(int?))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for EdFiOdsAdminApiFeaturesApplicationsProfile and cannot be null");
            }
            this.Id = id;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public int? Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdFiOdsAdminApiFeaturesApplicationsProfile {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as EdFiOdsAdminApiFeaturesApplicationsProfile);
        }

        /// <summary>
        /// Returns true if EdFiOdsAdminApiFeaturesApplicationsProfile instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiOdsAdminApiFeaturesApplicationsProfile to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiOdsAdminApiFeaturesApplicationsProfile input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
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