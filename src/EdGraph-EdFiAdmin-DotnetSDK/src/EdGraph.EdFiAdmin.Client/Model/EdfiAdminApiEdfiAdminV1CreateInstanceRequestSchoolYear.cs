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
    /// EdfiAdminApiEdfiAdminV1CreateInstanceRequestSchoolYear
    /// </summary>
    [DataContract(Name = "EdfiAdminApi.EdfiAdmin.V1.CreateInstanceRequestSchoolYear")]
    public partial class EdfiAdminApiEdfiAdminV1CreateInstanceRequestSchoolYear : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdfiAdminApiEdfiAdminV1CreateInstanceRequestSchoolYear" /> class.
        /// </summary>
        /// <param name="year">year.</param>
        /// <param name="selectedTierId">selectedTierId.</param>
        /// <param name="odsBackupCode">odsBackupCode.</param>
        public EdfiAdminApiEdfiAdminV1CreateInstanceRequestSchoolYear(int year = default(int), string selectedTierId = default(string), string odsBackupCode = default(string))
        {
            this.Year = year;
            this.SelectedTierId = selectedTierId;
            this.OdsBackupCode = odsBackupCode;
        }

        /// <summary>
        /// Gets or Sets Year
        /// </summary>
        [DataMember(Name = "year", EmitDefaultValue = false)]
        public int Year { get; set; }

        /// <summary>
        /// Gets or Sets SelectedTierId
        /// </summary>
        [DataMember(Name = "selectedTierId", EmitDefaultValue = true)]
        public string SelectedTierId { get; set; }

        /// <summary>
        /// Gets or Sets OdsBackupCode
        /// </summary>
        [DataMember(Name = "odsBackupCode", EmitDefaultValue = true)]
        public string OdsBackupCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdfiAdminApiEdfiAdminV1CreateInstanceRequestSchoolYear {\n");
            sb.Append("  Year: ").Append(Year).Append("\n");
            sb.Append("  SelectedTierId: ").Append(SelectedTierId).Append("\n");
            sb.Append("  OdsBackupCode: ").Append(OdsBackupCode).Append("\n");
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
