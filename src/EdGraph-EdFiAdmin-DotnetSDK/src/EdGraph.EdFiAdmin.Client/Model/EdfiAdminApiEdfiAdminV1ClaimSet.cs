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
    /// EdfiAdminApiEdfiAdminV1ClaimSet
    /// </summary>
    [DataContract(Name = "EdfiAdminApi.EdfiAdmin.V1.ClaimSet")]
    public partial class EdfiAdminApiEdfiAdminV1ClaimSet : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdfiAdminApiEdfiAdminV1ClaimSet" /> class.
        /// </summary>
        /// <param name="claimSetId">claimSetId.</param>
        /// <param name="claimSetName">claimSetName.</param>
        /// <param name="isSystemReserved">isSystemReserved.</param>
        /// <param name="applicationsCount">applicationsCount.</param>
        public EdfiAdminApiEdfiAdminV1ClaimSet(int claimSetId = default(int), string claimSetName = default(string), bool isSystemReserved = default(bool), int applicationsCount = default(int))
        {
            this.ClaimSetId = claimSetId;
            this.ClaimSetName = claimSetName;
            this.IsSystemReserved = isSystemReserved;
            this.ApplicationsCount = applicationsCount;
        }

        /// <summary>
        /// Gets or Sets ClaimSetId
        /// </summary>
        [DataMember(Name = "claimSetId", EmitDefaultValue = false)]
        public int ClaimSetId { get; set; }

        /// <summary>
        /// Gets or Sets ClaimSetName
        /// </summary>
        [DataMember(Name = "claimSetName", EmitDefaultValue = true)]
        public string ClaimSetName { get; set; }

        /// <summary>
        /// Gets or Sets IsSystemReserved
        /// </summary>
        [DataMember(Name = "isSystemReserved", EmitDefaultValue = true)]
        public bool IsSystemReserved { get; set; }

        /// <summary>
        /// Gets or Sets ApplicationsCount
        /// </summary>
        [DataMember(Name = "applicationsCount", EmitDefaultValue = false)]
        public int ApplicationsCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdfiAdminApiEdfiAdminV1ClaimSet {\n");
            sb.Append("  ClaimSetId: ").Append(ClaimSetId).Append("\n");
            sb.Append("  ClaimSetName: ").Append(ClaimSetName).Append("\n");
            sb.Append("  IsSystemReserved: ").Append(IsSystemReserved).Append("\n");
            sb.Append("  ApplicationsCount: ").Append(ApplicationsCount).Append("\n");
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