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
    /// EdfiAdminApiEdfiAdminV1StudentProgramRepresentation
    /// </summary>
    [DataContract(Name = "EdfiAdminApi.EdfiAdmin.V1.StudentProgramRepresentation")]
    public partial class EdfiAdminApiEdfiAdminV1StudentProgramRepresentation : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdfiAdminApiEdfiAdminV1StudentProgramRepresentation" /> class.
        /// </summary>
        /// <param name="programName">programName.</param>
        /// <param name="percentOfTotalStudents">percentOfTotalStudents.</param>
        public EdfiAdminApiEdfiAdminV1StudentProgramRepresentation(string programName = default(string), double percentOfTotalStudents = default(double))
        {
            this.ProgramName = programName;
            this.PercentOfTotalStudents = percentOfTotalStudents;
        }

        /// <summary>
        /// Gets or Sets ProgramName
        /// </summary>
        [DataMember(Name = "programName", EmitDefaultValue = true)]
        public string ProgramName { get; set; }

        /// <summary>
        /// Gets or Sets PercentOfTotalStudents
        /// </summary>
        [DataMember(Name = "percentOfTotalStudents", EmitDefaultValue = false)]
        public double PercentOfTotalStudents { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdfiAdminApiEdfiAdminV1StudentProgramRepresentation {\n");
            sb.Append("  ProgramName: ").Append(ProgramName).Append("\n");
            sb.Append("  PercentOfTotalStudents: ").Append(PercentOfTotalStudents).Append("\n");
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
