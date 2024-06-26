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
    /// EdfiAdminApiEdfiAdminV1SaveClaimSetRequest
    /// </summary>
    [DataContract(Name = "EdfiAdminApi.EdfiAdmin.V1.SaveClaimSetRequest")]
    public partial class EdfiAdminApiEdfiAdminV1SaveClaimSetRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdfiAdminApiEdfiAdminV1SaveClaimSetRequest" /> class.
        /// </summary>
        /// <param name="tenantId">tenantId.</param>
        /// <param name="instanceId">instanceId.</param>
        /// <param name="claimSetId">claimSetId.</param>
        /// <param name="claimSetName">claimSetName.</param>
        /// <param name="applicationId">applicationId.</param>
        public EdfiAdminApiEdfiAdminV1SaveClaimSetRequest(string tenantId = default(string), string instanceId = default(string), int claimSetId = default(int), string claimSetName = default(string), int applicationId = default(int))
        {
            this.TenantId = tenantId;
            this.InstanceId = instanceId;
            this.ClaimSetId = claimSetId;
            this.ClaimSetName = claimSetName;
            this.ApplicationId = applicationId;
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
        /// Gets or Sets ApplicationId
        /// </summary>
        [DataMember(Name = "applicationId", EmitDefaultValue = false)]
        public int ApplicationId { get; set; }

        /// <summary>
        /// Gets or Sets ResourceClaims
        /// </summary>
        [DataMember(Name = "resourceClaims", EmitDefaultValue = true)]
        public List<EdfiAdminApiEdfiAdminV1ClaimSetDetailsResourceClaim> ResourceClaims { get; private set; }

        /// <summary>
        /// Returns false as ResourceClaims should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeResourceClaims()
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
            sb.Append("class EdfiAdminApiEdfiAdminV1SaveClaimSetRequest {\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  InstanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  ClaimSetId: ").Append(ClaimSetId).Append("\n");
            sb.Append("  ClaimSetName: ").Append(ClaimSetName).Append("\n");
            sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
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
