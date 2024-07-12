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
    /// EdfiAdminApiEdfiAdminV1Onboarding
    /// </summary>
    [DataContract(Name = "EdfiAdminApi.EdfiAdmin.V1.Onboarding")]
    public partial class EdfiAdminApiEdfiAdminV1Onboarding : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdfiAdminApiEdfiAdminV1Onboarding" /> class.
        /// </summary>
        /// <param name="status">status.</param>
        /// <param name="progressPercentage">progressPercentage.</param>
        /// <param name="totalSteps">totalSteps.</param>
        /// <param name="lastCompletedStep">lastCompletedStep.</param>
        /// <param name="startedAt">startedAt.</param>
        /// <param name="completedAt">completedAt.</param>
        public EdfiAdminApiEdfiAdminV1Onboarding(string status = default(string), float progressPercentage = default(float), int totalSteps = default(int), int? lastCompletedStep = default(int?), string startedAt = default(string), string completedAt = default(string))
        {
            this.Status = status;
            this.ProgressPercentage = progressPercentage;
            this.TotalSteps = totalSteps;
            this.LastCompletedStep = lastCompletedStep;
            this.StartedAt = startedAt;
            this.CompletedAt = completedAt;
        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = true)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets ProgressPercentage
        /// </summary>
        [DataMember(Name = "progressPercentage", EmitDefaultValue = false)]
        public float ProgressPercentage { get; set; }

        /// <summary>
        /// Gets or Sets TotalSteps
        /// </summary>
        [DataMember(Name = "totalSteps", EmitDefaultValue = false)]
        public int TotalSteps { get; set; }

        /// <summary>
        /// Gets or Sets LastCompletedStep
        /// </summary>
        [DataMember(Name = "lastCompletedStep", EmitDefaultValue = true)]
        public int? LastCompletedStep { get; set; }

        /// <summary>
        /// Gets or Sets StartedAt
        /// </summary>
        [DataMember(Name = "startedAt", EmitDefaultValue = true)]
        public string StartedAt { get; set; }

        /// <summary>
        /// Gets or Sets CompletedAt
        /// </summary>
        [DataMember(Name = "completedAt", EmitDefaultValue = true)]
        public string CompletedAt { get; set; }

        /// <summary>
        /// Gets or Sets Steps
        /// </summary>
        [DataMember(Name = "steps", EmitDefaultValue = true)]
        public List<EdfiAdminApiEdfiAdminV1OnboardingStep> Steps { get; private set; }

        /// <summary>
        /// Returns false as Steps should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSteps()
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
            sb.Append("class EdfiAdminApiEdfiAdminV1Onboarding {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ProgressPercentage: ").Append(ProgressPercentage).Append("\n");
            sb.Append("  TotalSteps: ").Append(TotalSteps).Append("\n");
            sb.Append("  LastCompletedStep: ").Append(LastCompletedStep).Append("\n");
            sb.Append("  StartedAt: ").Append(StartedAt).Append("\n");
            sb.Append("  CompletedAt: ").Append(CompletedAt).Append("\n");
            sb.Append("  Steps: ").Append(Steps).Append("\n");
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
