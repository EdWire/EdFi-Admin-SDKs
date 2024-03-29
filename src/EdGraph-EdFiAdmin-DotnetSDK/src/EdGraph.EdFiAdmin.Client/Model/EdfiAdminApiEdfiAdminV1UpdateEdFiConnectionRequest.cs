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
    /// EdfiAdminApiEdfiAdminV1UpdateEdFiConnectionRequest
    /// </summary>
    [DataContract(Name = "EdfiAdminApi.EdfiAdmin.V1.UpdateEdFiConnectionRequest")]
    public partial class EdfiAdminApiEdfiAdminV1UpdateEdFiConnectionRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdfiAdminApiEdfiAdminV1UpdateEdFiConnectionRequest" /> class.
        /// </summary>
        /// <param name="connectionId">connectionId.</param>
        /// <param name="tenantId">tenantId.</param>
        /// <param name="connectionName">connectionName.</param>
        /// <param name="edFiVersion">edFiVersion.</param>
        /// <param name="edFiExtension">edFiExtension.</param>
        /// <param name="metadataUrl">metadataUrl.</param>
        /// <param name="clientId">clientId.</param>
        /// <param name="clientSecret">clientSecret.</param>
        /// <param name="tokenUrl">tokenUrl.</param>
        /// <param name="resourcesUrl">resourcesUrl.</param>
        public EdfiAdminApiEdfiAdminV1UpdateEdFiConnectionRequest(string connectionId = default(string), string tenantId = default(string), string connectionName = default(string), string edFiVersion = default(string), string edFiExtension = default(string), string metadataUrl = default(string), string clientId = default(string), string clientSecret = default(string), string tokenUrl = default(string), string resourcesUrl = default(string))
        {
            this.ConnectionId = connectionId;
            this.TenantId = tenantId;
            this.ConnectionName = connectionName;
            this.EdFiVersion = edFiVersion;
            this.EdFiExtension = edFiExtension;
            this.MetadataUrl = metadataUrl;
            this.ClientId = clientId;
            this.ClientSecret = clientSecret;
            this.TokenUrl = tokenUrl;
            this.ResourcesUrl = resourcesUrl;
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
        /// Gets or Sets ConnectionName
        /// </summary>
        [DataMember(Name = "connectionName", EmitDefaultValue = true)]
        public string ConnectionName { get; set; }

        /// <summary>
        /// Gets or Sets EdFiVersion
        /// </summary>
        [DataMember(Name = "edFiVersion", EmitDefaultValue = true)]
        public string EdFiVersion { get; set; }

        /// <summary>
        /// Gets or Sets EdFiExtension
        /// </summary>
        [DataMember(Name = "edFiExtension", EmitDefaultValue = true)]
        public string EdFiExtension { get; set; }

        /// <summary>
        /// Gets or Sets MetadataUrl
        /// </summary>
        [DataMember(Name = "metadataUrl", EmitDefaultValue = true)]
        public string MetadataUrl { get; set; }

        /// <summary>
        /// Gets or Sets ClientId
        /// </summary>
        [DataMember(Name = "clientId", EmitDefaultValue = true)]
        public string ClientId { get; set; }

        /// <summary>
        /// Gets or Sets ClientSecret
        /// </summary>
        [DataMember(Name = "clientSecret", EmitDefaultValue = true)]
        public string ClientSecret { get; set; }

        /// <summary>
        /// Gets or Sets TokenUrl
        /// </summary>
        [DataMember(Name = "tokenUrl", EmitDefaultValue = true)]
        public string TokenUrl { get; set; }

        /// <summary>
        /// Gets or Sets ResourcesUrl
        /// </summary>
        [DataMember(Name = "resourcesUrl", EmitDefaultValue = true)]
        public string ResourcesUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdfiAdminApiEdfiAdminV1UpdateEdFiConnectionRequest {\n");
            sb.Append("  ConnectionId: ").Append(ConnectionId).Append("\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  ConnectionName: ").Append(ConnectionName).Append("\n");
            sb.Append("  EdFiVersion: ").Append(EdFiVersion).Append("\n");
            sb.Append("  EdFiExtension: ").Append(EdFiExtension).Append("\n");
            sb.Append("  MetadataUrl: ").Append(MetadataUrl).Append("\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  ClientSecret: ").Append(ClientSecret).Append("\n");
            sb.Append("  TokenUrl: ").Append(TokenUrl).Append("\n");
            sb.Append("  ResourcesUrl: ").Append(ResourcesUrl).Append("\n");
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