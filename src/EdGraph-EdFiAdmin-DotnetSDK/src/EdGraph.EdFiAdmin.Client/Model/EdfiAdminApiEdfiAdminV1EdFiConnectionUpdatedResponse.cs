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
    /// EdfiAdminApiEdfiAdminV1EdFiConnectionUpdatedResponse
    /// </summary>
    [DataContract(Name = "EdfiAdminApi.EdfiAdmin.V1.EdFiConnectionUpdatedResponse")]
    public partial class EdfiAdminApiEdfiAdminV1EdFiConnectionUpdatedResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdfiAdminApiEdfiAdminV1EdFiConnectionUpdatedResponse" /> class.
        /// </summary>
        /// <param name="connectionId">connectionId.</param>
        /// <param name="tenantId">tenantId.</param>
        public EdfiAdminApiEdfiAdminV1EdFiConnectionUpdatedResponse(string connectionId = default(string), string tenantId = default(string))
        {
            this.ConnectionId = connectionId;
            this.TenantId = tenantId;
        }

        /// <summary>
        /// Gets or Sets ConnectionId
        /// </summary>
        [DataMember(Name = "connectionId", EmitDefaultValue = true)]
        public string ConnectionId { get; set; }

        /// <summary>
        /// Gets or Sets TenantId
        /// </summary>
        [DataMember(Name = "tenantId", EmitDefaultValue = true)]
        public string TenantId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdfiAdminApiEdfiAdminV1EdFiConnectionUpdatedResponse {\n");
            sb.Append("  ConnectionId: ").Append(ConnectionId).Append("\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
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
