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
    /// EdfiAdminApiEdfiAdminV1SyncLocalEducationAgencyRequest
    /// </summary>
    [DataContract(Name = "EdfiAdminApi.EdfiAdmin.V1.SyncLocalEducationAgencyRequest")]
    public partial class EdfiAdminApiEdfiAdminV1SyncLocalEducationAgencyRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdfiAdminApiEdfiAdminV1SyncLocalEducationAgencyRequest" /> class.
        /// </summary>
        /// <param name="tenantId">tenantId.</param>
        /// <param name="instanceId">instanceId.</param>
        /// <param name="year">year.</param>
        /// <param name="edOrgId">edOrgId.</param>
        /// <param name="edOrgGuid">edOrgGuid.</param>
        /// <param name="assignToExistingApplications">assignToExistingApplications.</param>
        public EdfiAdminApiEdfiAdminV1SyncLocalEducationAgencyRequest(string tenantId = default(string), string instanceId = default(string), int? year = default(int?), int edOrgId = default(int), string edOrgGuid = default(string), bool assignToExistingApplications = default(bool))
        {
            this.TenantId = tenantId;
            this.InstanceId = instanceId;
            this.Year = year;
            this.EdOrgId = edOrgId;
            this.EdOrgGuid = edOrgGuid;
            this.AssignToExistingApplications = assignToExistingApplications;
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
        /// Gets or Sets Year
        /// </summary>
        [DataMember(Name = "year", EmitDefaultValue = true)]
        public int? Year { get; set; }

        /// <summary>
        /// Gets or Sets EdOrgId
        /// </summary>
        [DataMember(Name = "edOrgId", EmitDefaultValue = false)]
        public int EdOrgId { get; set; }

        /// <summary>
        /// Gets or Sets EdOrgGuid
        /// </summary>
        [DataMember(Name = "edOrgGuid", EmitDefaultValue = true)]
        public string EdOrgGuid { get; set; }

        /// <summary>
        /// Gets or Sets Entries
        /// </summary>
        [DataMember(Name = "entries", EmitDefaultValue = true)]
        public List<EdfiAdminApiEdfiAdminV1SyncEntry> Entries { get; private set; }

        /// <summary>
        /// Returns false as Entries should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeEntries()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets AssignToExistingApplications
        /// </summary>
        [DataMember(Name = "assignToExistingApplications", EmitDefaultValue = true)]
        public bool AssignToExistingApplications { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdfiAdminApiEdfiAdminV1SyncLocalEducationAgencyRequest {\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  InstanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  Year: ").Append(Year).Append("\n");
            sb.Append("  EdOrgId: ").Append(EdOrgId).Append("\n");
            sb.Append("  EdOrgGuid: ").Append(EdOrgGuid).Append("\n");
            sb.Append("  Entries: ").Append(Entries).Append("\n");
            sb.Append("  AssignToExistingApplications: ").Append(AssignToExistingApplications).Append("\n");
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
