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
    /// EdfiAdminApiEdfiAdminV1InstanceDatabaseJobs
    /// </summary>
    [DataContract(Name = "EdfiAdminApi.EdfiAdmin.V1.InstanceDatabaseJobs")]
    public partial class EdfiAdminApiEdfiAdminV1InstanceDatabaseJobs : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdfiAdminApiEdfiAdminV1InstanceDatabaseJobs" /> class.
        /// </summary>
        /// <param name="createJobId">createJobId.</param>
        /// <param name="deleteJobId">deleteJobId.</param>
        /// <param name="resetDeleteJobId">resetDeleteJobId.</param>
        /// <param name="resetCreateJobId">resetCreateJobId.</param>
        /// <param name="generateReportsJobId">generateReportsJobId.</param>
        public EdfiAdminApiEdfiAdminV1InstanceDatabaseJobs(string createJobId = default(string), string deleteJobId = default(string), string resetDeleteJobId = default(string), string resetCreateJobId = default(string), string generateReportsJobId = default(string))
        {
            this.CreateJobId = createJobId;
            this.DeleteJobId = deleteJobId;
            this.ResetDeleteJobId = resetDeleteJobId;
            this.ResetCreateJobId = resetCreateJobId;
            this.GenerateReportsJobId = generateReportsJobId;
        }

        /// <summary>
        /// Gets or Sets CreateJobId
        /// </summary>
        [DataMember(Name = "createJobId", EmitDefaultValue = true)]
        public string CreateJobId { get; set; }

        /// <summary>
        /// Gets or Sets DeleteJobId
        /// </summary>
        [DataMember(Name = "deleteJobId", EmitDefaultValue = true)]
        public string DeleteJobId { get; set; }

        /// <summary>
        /// Gets or Sets ResetDeleteJobId
        /// </summary>
        [DataMember(Name = "resetDeleteJobId", EmitDefaultValue = true)]
        public string ResetDeleteJobId { get; set; }

        /// <summary>
        /// Gets or Sets ResetCreateJobId
        /// </summary>
        [DataMember(Name = "resetCreateJobId", EmitDefaultValue = true)]
        public string ResetCreateJobId { get; set; }

        /// <summary>
        /// Gets or Sets GenerateReportsJobId
        /// </summary>
        [DataMember(Name = "generateReportsJobId", EmitDefaultValue = true)]
        public string GenerateReportsJobId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdfiAdminApiEdfiAdminV1InstanceDatabaseJobs {\n");
            sb.Append("  CreateJobId: ").Append(CreateJobId).Append("\n");
            sb.Append("  DeleteJobId: ").Append(DeleteJobId).Append("\n");
            sb.Append("  ResetDeleteJobId: ").Append(ResetDeleteJobId).Append("\n");
            sb.Append("  ResetCreateJobId: ").Append(ResetCreateJobId).Append("\n");
            sb.Append("  GenerateReportsJobId: ").Append(GenerateReportsJobId).Append("\n");
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
