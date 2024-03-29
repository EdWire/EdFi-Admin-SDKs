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
    /// EdfiAdminApiEdfiAdminV1ClaimSetDetailsResourceClaim
    /// </summary>
    [DataContract(Name = "EdfiAdminApi.EdfiAdmin.V1.ClaimSetDetailsResourceClaim")]
    public partial class EdfiAdminApiEdfiAdminV1ClaimSetDetailsResourceClaim : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdfiAdminApiEdfiAdminV1ClaimSetDetailsResourceClaim" /> class.
        /// </summary>
        /// <param name="resourceClaimId">resourceClaimId.</param>
        /// <param name="name">name.</param>
        /// <param name="create">create.</param>
        /// <param name="createAuthStrategy">createAuthStrategy.</param>
        /// <param name="createAuthStrategyOverride">createAuthStrategyOverride.</param>
        /// <param name="read">read.</param>
        /// <param name="readAuthStrategy">readAuthStrategy.</param>
        /// <param name="readAuthStrategyOverride">readAuthStrategyOverride.</param>
        /// <param name="update">update.</param>
        /// <param name="updateAuthStrategy">updateAuthStrategy.</param>
        /// <param name="updateAuthStrategyOverride">updateAuthStrategyOverride.</param>
        /// <param name="delete">delete.</param>
        /// <param name="deleteAuthStrategy">deleteAuthStrategy.</param>
        /// <param name="deleteAuthStrategyOverride">deleteAuthStrategyOverride.</param>
        /// <param name="readChanges">readChanges.</param>
        /// <param name="readChangesAuthStrategy">readChangesAuthStrategy.</param>
        /// <param name="readChangesAuthStrategyOverride">readChangesAuthStrategyOverride.</param>
        public EdfiAdminApiEdfiAdminV1ClaimSetDetailsResourceClaim(int resourceClaimId = default(int), string name = default(string), bool create = default(bool), string createAuthStrategy = default(string), string createAuthStrategyOverride = default(string), bool read = default(bool), string readAuthStrategy = default(string), string readAuthStrategyOverride = default(string), bool update = default(bool), string updateAuthStrategy = default(string), string updateAuthStrategyOverride = default(string), bool delete = default(bool), string deleteAuthStrategy = default(string), string deleteAuthStrategyOverride = default(string), bool readChanges = default(bool), string readChangesAuthStrategy = default(string), string readChangesAuthStrategyOverride = default(string))
        {
            this.ResourceClaimId = resourceClaimId;
            this.Name = name;
            this.Create = create;
            this.CreateAuthStrategy = createAuthStrategy;
            this.CreateAuthStrategyOverride = createAuthStrategyOverride;
            this.Read = read;
            this.ReadAuthStrategy = readAuthStrategy;
            this.ReadAuthStrategyOverride = readAuthStrategyOverride;
            this.Update = update;
            this.UpdateAuthStrategy = updateAuthStrategy;
            this.UpdateAuthStrategyOverride = updateAuthStrategyOverride;
            this.Delete = delete;
            this.DeleteAuthStrategy = deleteAuthStrategy;
            this.DeleteAuthStrategyOverride = deleteAuthStrategyOverride;
            this.ReadChanges = readChanges;
            this.ReadChangesAuthStrategy = readChangesAuthStrategy;
            this.ReadChangesAuthStrategyOverride = readChangesAuthStrategyOverride;
        }

        /// <summary>
        /// Gets or Sets ResourceClaimId
        /// </summary>
        [DataMember(Name = "resourceClaimId", EmitDefaultValue = false)]
        public int ResourceClaimId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Create
        /// </summary>
        [DataMember(Name = "create", EmitDefaultValue = true)]
        public bool Create { get; set; }

        /// <summary>
        /// Gets or Sets CreateAuthStrategy
        /// </summary>
        [DataMember(Name = "createAuthStrategy", EmitDefaultValue = true)]
        public string CreateAuthStrategy { get; set; }

        /// <summary>
        /// Gets or Sets CreateAuthStrategyOverride
        /// </summary>
        [DataMember(Name = "createAuthStrategyOverride", EmitDefaultValue = true)]
        public string CreateAuthStrategyOverride { get; set; }

        /// <summary>
        /// Gets or Sets Read
        /// </summary>
        [DataMember(Name = "read", EmitDefaultValue = true)]
        public bool Read { get; set; }

        /// <summary>
        /// Gets or Sets ReadAuthStrategy
        /// </summary>
        [DataMember(Name = "readAuthStrategy", EmitDefaultValue = true)]
        public string ReadAuthStrategy { get; set; }

        /// <summary>
        /// Gets or Sets ReadAuthStrategyOverride
        /// </summary>
        [DataMember(Name = "readAuthStrategyOverride", EmitDefaultValue = true)]
        public string ReadAuthStrategyOverride { get; set; }

        /// <summary>
        /// Gets or Sets Update
        /// </summary>
        [DataMember(Name = "update", EmitDefaultValue = true)]
        public bool Update { get; set; }

        /// <summary>
        /// Gets or Sets UpdateAuthStrategy
        /// </summary>
        [DataMember(Name = "updateAuthStrategy", EmitDefaultValue = true)]
        public string UpdateAuthStrategy { get; set; }

        /// <summary>
        /// Gets or Sets UpdateAuthStrategyOverride
        /// </summary>
        [DataMember(Name = "updateAuthStrategyOverride", EmitDefaultValue = true)]
        public string UpdateAuthStrategyOverride { get; set; }

        /// <summary>
        /// Gets or Sets Delete
        /// </summary>
        [DataMember(Name = "delete", EmitDefaultValue = true)]
        public bool Delete { get; set; }

        /// <summary>
        /// Gets or Sets DeleteAuthStrategy
        /// </summary>
        [DataMember(Name = "deleteAuthStrategy", EmitDefaultValue = true)]
        public string DeleteAuthStrategy { get; set; }

        /// <summary>
        /// Gets or Sets DeleteAuthStrategyOverride
        /// </summary>
        [DataMember(Name = "deleteAuthStrategyOverride", EmitDefaultValue = true)]
        public string DeleteAuthStrategyOverride { get; set; }

        /// <summary>
        /// Gets or Sets Children
        /// </summary>
        [DataMember(Name = "children", EmitDefaultValue = true)]
        public List<EdfiAdminApiEdfiAdminV1ClaimSetDetailsResourceClaim> Children { get; private set; }

        /// <summary>
        /// Returns false as Children should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeChildren()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets ReadChanges
        /// </summary>
        [DataMember(Name = "readChanges", EmitDefaultValue = true)]
        public bool ReadChanges { get; set; }

        /// <summary>
        /// Gets or Sets ReadChangesAuthStrategy
        /// </summary>
        [DataMember(Name = "readChangesAuthStrategy", EmitDefaultValue = true)]
        public string ReadChangesAuthStrategy { get; set; }

        /// <summary>
        /// Gets or Sets ReadChangesAuthStrategyOverride
        /// </summary>
        [DataMember(Name = "readChangesAuthStrategyOverride", EmitDefaultValue = true)]
        public string ReadChangesAuthStrategyOverride { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdfiAdminApiEdfiAdminV1ClaimSetDetailsResourceClaim {\n");
            sb.Append("  ResourceClaimId: ").Append(ResourceClaimId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Create: ").Append(Create).Append("\n");
            sb.Append("  CreateAuthStrategy: ").Append(CreateAuthStrategy).Append("\n");
            sb.Append("  CreateAuthStrategyOverride: ").Append(CreateAuthStrategyOverride).Append("\n");
            sb.Append("  Read: ").Append(Read).Append("\n");
            sb.Append("  ReadAuthStrategy: ").Append(ReadAuthStrategy).Append("\n");
            sb.Append("  ReadAuthStrategyOverride: ").Append(ReadAuthStrategyOverride).Append("\n");
            sb.Append("  Update: ").Append(Update).Append("\n");
            sb.Append("  UpdateAuthStrategy: ").Append(UpdateAuthStrategy).Append("\n");
            sb.Append("  UpdateAuthStrategyOverride: ").Append(UpdateAuthStrategyOverride).Append("\n");
            sb.Append("  Delete: ").Append(Delete).Append("\n");
            sb.Append("  DeleteAuthStrategy: ").Append(DeleteAuthStrategy).Append("\n");
            sb.Append("  DeleteAuthStrategyOverride: ").Append(DeleteAuthStrategyOverride).Append("\n");
            sb.Append("  Children: ").Append(Children).Append("\n");
            sb.Append("  ReadChanges: ").Append(ReadChanges).Append("\n");
            sb.Append("  ReadChangesAuthStrategy: ").Append(ReadChangesAuthStrategy).Append("\n");
            sb.Append("  ReadChangesAuthStrategyOverride: ").Append(ReadChangesAuthStrategyOverride).Append("\n");
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