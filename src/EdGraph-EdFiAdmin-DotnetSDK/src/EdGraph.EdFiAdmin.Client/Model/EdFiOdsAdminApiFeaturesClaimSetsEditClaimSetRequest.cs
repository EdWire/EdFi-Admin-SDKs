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
    /// EdFiOdsAdminApiFeaturesClaimSetsEditClaimSetRequest
    /// </summary>
    [DataContract(Name = "EdFi.Ods.AdminApi.Features.ClaimSets.EditClaimSet.Request")]
    public partial class EdFiOdsAdminApiFeaturesClaimSetsEditClaimSetRequest : IEquatable<EdFiOdsAdminApiFeaturesClaimSetsEditClaimSetRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiOdsAdminApiFeaturesClaimSetsEditClaimSetRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiOdsAdminApiFeaturesClaimSetsEditClaimSetRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiOdsAdminApiFeaturesClaimSetsEditClaimSetRequest" /> class.
        /// </summary>
        /// <param name="id">ClaimSet id (required).</param>
        /// <param name="name">Claim set name (required).</param>
        /// <param name="resourceClaims">Resource Claims (required).</param>
        public EdFiOdsAdminApiFeaturesClaimSetsEditClaimSetRequest(int id = default(int), string name = default(string), List<EdFiOdsAdminApiFeaturesClaimSetsResourceClaimModel> resourceClaims = default(List<EdFiOdsAdminApiFeaturesClaimSetsResourceClaimModel>))
        {
            this.Id = id;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for EdFiOdsAdminApiFeaturesClaimSetsEditClaimSetRequest and cannot be null");
            }
            this.Name = name;
            // to ensure "resourceClaims" is required (not null)
            if (resourceClaims == null)
            {
                throw new ArgumentNullException("resourceClaims is a required property for EdFiOdsAdminApiFeaturesClaimSetsEditClaimSetRequest and cannot be null");
            }
            this.ResourceClaims = resourceClaims;
        }

        /// <summary>
        /// ClaimSet id
        /// </summary>
        /// <value>ClaimSet id</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public int Id { get; set; }

        /// <summary>
        /// Claim set name
        /// </summary>
        /// <value>Claim set name</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Resource Claims
        /// </summary>
        /// <value>Resource Claims</value>
        [DataMember(Name = "resourceClaims", IsRequired = true, EmitDefaultValue = true)]
        public List<EdFiOdsAdminApiFeaturesClaimSetsResourceClaimModel> ResourceClaims { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdFiOdsAdminApiFeaturesClaimSetsEditClaimSetRequest {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ResourceClaims: ").Append(ResourceClaims).Append("\n");
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
            return this.Equals(input as EdFiOdsAdminApiFeaturesClaimSetsEditClaimSetRequest);
        }

        /// <summary>
        /// Returns true if EdFiOdsAdminApiFeaturesClaimSetsEditClaimSetRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiOdsAdminApiFeaturesClaimSetsEditClaimSetRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiOdsAdminApiFeaturesClaimSetsEditClaimSetRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ResourceClaims == input.ResourceClaims ||
                    this.ResourceClaims != null &&
                    input.ResourceClaims != null &&
                    this.ResourceClaims.SequenceEqual(input.ResourceClaims)
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
                hashCode = (hashCode * 59) + this.Id.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.ResourceClaims != null)
                {
                    hashCode = (hashCode * 59) + this.ResourceClaims.GetHashCode();
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
