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
    /// EdfiAdminApiEdfiAdminV1StudentEconomicSituationReportResponse
    /// </summary>
    [DataContract(Name = "EdfiAdminApi.EdfiAdmin.V1.StudentEconomicSituationReportResponse")]
    public partial class EdfiAdminApiEdfiAdminV1StudentEconomicSituationReportResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdfiAdminApiEdfiAdminV1StudentEconomicSituationReportResponse" /> class.
        /// </summary>
        /// <param name="tenantId">tenantId.</param>
        /// <param name="instanceId">instanceId.</param>
        /// <param name="localEducationAgencyId">localEducationAgencyId.</param>
        /// <param name="localEducationAgencyName">localEducationAgencyName.</param>
        /// <param name="totalStudentCount">totalStudentCount.</param>
        public EdfiAdminApiEdfiAdminV1StudentEconomicSituationReportResponse(string tenantId = default(string), string instanceId = default(string), int localEducationAgencyId = default(int), string localEducationAgencyName = default(string), int totalStudentCount = default(int))
        {
            this.TenantId = tenantId;
            this.InstanceId = instanceId;
            this.LocalEducationAgencyId = localEducationAgencyId;
            this.LocalEducationAgencyName = localEducationAgencyName;
            this.TotalStudentCount = totalStudentCount;
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
        /// Gets or Sets LocalEducationAgencyId
        /// </summary>
        [DataMember(Name = "localEducationAgencyId", EmitDefaultValue = false)]
        public int LocalEducationAgencyId { get; set; }

        /// <summary>
        /// Gets or Sets LocalEducationAgencyName
        /// </summary>
        [DataMember(Name = "localEducationAgencyName", EmitDefaultValue = true)]
        public string LocalEducationAgencyName { get; set; }

        /// <summary>
        /// Gets or Sets TotalStudentCount
        /// </summary>
        [DataMember(Name = "totalStudentCount", EmitDefaultValue = false)]
        public int TotalStudentCount { get; set; }

        /// <summary>
        /// Gets or Sets StudentEconomicSituationRepresentation
        /// </summary>
        [DataMember(Name = "studentEconomicSituationRepresentation", EmitDefaultValue = true)]
        public List<EdfiAdminApiEdfiAdminV1StudentEconomicSituationRepresentation> StudentEconomicSituationRepresentation { get; private set; }

        /// <summary>
        /// Returns false as StudentEconomicSituationRepresentation should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeStudentEconomicSituationRepresentation()
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
            sb.Append("class EdfiAdminApiEdfiAdminV1StudentEconomicSituationReportResponse {\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  InstanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  LocalEducationAgencyId: ").Append(LocalEducationAgencyId).Append("\n");
            sb.Append("  LocalEducationAgencyName: ").Append(LocalEducationAgencyName).Append("\n");
            sb.Append("  TotalStudentCount: ").Append(TotalStudentCount).Append("\n");
            sb.Append("  StudentEconomicSituationRepresentation: ").Append(StudentEconomicSituationRepresentation).Append("\n");
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
