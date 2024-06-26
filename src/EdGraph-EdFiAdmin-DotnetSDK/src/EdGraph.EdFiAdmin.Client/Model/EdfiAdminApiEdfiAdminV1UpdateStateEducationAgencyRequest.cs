/*
 * Ed-Fi Admin Api
 *
 * Ed-Fi Admin Api - v1.0
 *
 * The version of the OpenAPI document: v1.0
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
    /// EdfiAdminApiEdfiAdminV1UpdateStateEducationAgencyRequest
    /// </summary>
    [DataContract(Name = "EdfiAdminApi.EdfiAdmin.V1.UpdateStateEducationAgencyRequest")]
    public partial class EdfiAdminApiEdfiAdminV1UpdateStateEducationAgencyRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdfiAdminApiEdfiAdminV1UpdateStateEducationAgencyRequest" /> class.
        /// </summary>
        /// <param name="tenantId">tenantId.</param>
        /// <param name="instanceId">instanceId.</param>
        /// <param name="id">id.</param>
        /// <param name="stateEducationAgencyId">stateEducationAgencyId.</param>
        /// <param name="nameOfInstitution">nameOfInstitution.</param>
        public EdfiAdminApiEdfiAdminV1UpdateStateEducationAgencyRequest(string tenantId = default(string), string instanceId = default(string), string id = default(string), int stateEducationAgencyId = default(int), string nameOfInstitution = default(string))
        {
            this.TenantId = tenantId;
            this.InstanceId = instanceId;
            this.Id = id;
            this.StateEducationAgencyId = stateEducationAgencyId;
            this.NameOfInstitution = nameOfInstitution;
        }

        /// <summary>
        /// Gets or Sets TenantId
        /// </summary>
        [DataMember(Name = "tenantId", EmitDefaultValue = true)]
        public string TenantId { get; set; }

        /// <summary>
        /// Gets or Sets InstanceId
        /// </summary>
        [DataMember(Name = "instanceId", EmitDefaultValue = true)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets StateEducationAgencyId
        /// </summary>
        [DataMember(Name = "stateEducationAgencyId", EmitDefaultValue = false)]
        public int StateEducationAgencyId { get; set; }

        /// <summary>
        /// Gets or Sets NameOfInstitution
        /// </summary>
        [DataMember(Name = "nameOfInstitution", EmitDefaultValue = true)]
        public string NameOfInstitution { get; set; }

        /// <summary>
        /// Gets or Sets EducationOrganizationCategoryDescriptors
        /// </summary>
        [DataMember(Name = "educationOrganizationCategoryDescriptors", EmitDefaultValue = true)]
        public List<string> EducationOrganizationCategoryDescriptors { get; private set; }

        /// <summary>
        /// Returns false as EducationOrganizationCategoryDescriptors should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeEducationOrganizationCategoryDescriptors()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdfiAdminApiEdfiAdminV1UpdateStateEducationAgencyRequest {\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  InstanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  StateEducationAgencyId: ").Append(StateEducationAgencyId).Append("\n");
            sb.Append("  NameOfInstitution: ").Append(NameOfInstitution).Append("\n");
            sb.Append("  EducationOrganizationCategoryDescriptors: ").Append(EducationOrganizationCategoryDescriptors).Append("\n");
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
