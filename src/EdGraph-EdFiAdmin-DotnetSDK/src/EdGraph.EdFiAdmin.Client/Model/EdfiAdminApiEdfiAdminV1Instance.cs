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
    /// EdfiAdminApiEdfiAdminV1Instance
    /// </summary>
    [DataContract(Name = "EdfiAdminApi.EdfiAdmin.V1.Instance")]
    public partial class EdfiAdminApiEdfiAdminV1Instance : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdfiAdminApiEdfiAdminV1Instance" /> class.
        /// </summary>
        /// <param name="id">Details.</param>
        /// <param name="instanceName">instanceName.</param>
        /// <param name="useCustomId">useCustomId.</param>
        /// <param name="customId">customId.</param>
        /// <param name="description">description.</param>
        /// <param name="connectionName">connectionName.</param>
        /// <param name="selectedConnectionId">Connection.</param>
        /// <param name="selectedConnection">selectedConnection.</param>
        /// <param name="databases">databases.</param>
        /// <param name="password">API Client.</param>
        /// <param name="apiClientKey">apiClientKey.</param>
        /// <param name="apiClientSecret">apiClientSecret.</param>
        /// <param name="isApiClientSecretSecured">isApiClientSecretSecured.</param>
        /// <param name="tenantId">Metadata.</param>
        /// <param name="createdBy">createdBy.</param>
        /// <param name="createdDateTime">createdDateTime.</param>
        /// <param name="isDeleted">isDeleted.</param>
        /// <param name="lastModifiedBy">lastModifiedBy.</param>
        /// <param name="lastModifiedDateTime">lastModifiedDateTime.</param>
        /// <param name="apiAuthUrl">URLs.</param>
        /// <param name="selectedConnectionType">Connection.</param>
        /// <param name="isDefault">IsDefault.</param>
        /// <param name="provider">Provider.</param>
        /// <param name="onboarding">onboarding.</param>
        public EdfiAdminApiEdfiAdminV1Instance(string id = default(string), string instanceName = default(string), bool useCustomId = default(bool), string customId = default(string), string description = default(string), string connectionName = default(string), string selectedConnectionId = default(string), EdfiAdminApiEdfiAdminV1EdFiConnection selectedConnection = default(EdfiAdminApiEdfiAdminV1EdFiConnection), EdfiAdminApiEdfiAdminV1InstanceDatabases databases = default(EdfiAdminApiEdfiAdminV1InstanceDatabases), string password = default(string), string apiClientKey = default(string), string apiClientSecret = default(string), string isApiClientSecretSecured = default(string), string tenantId = default(string), string createdBy = default(string), string createdDateTime = default(string), bool isDeleted = default(bool), string lastModifiedBy = default(string), string lastModifiedDateTime = default(string), string apiAuthUrl = default(string), string selectedConnectionType = default(string), bool? isDefault = default(bool?), string provider = default(string), EdfiAdminApiEdfiAdminV1Onboarding onboarding = default(EdfiAdminApiEdfiAdminV1Onboarding))
        {
            this.Id = id;
            this.InstanceName = instanceName;
            this.UseCustomId = useCustomId;
            this.CustomId = customId;
            this.Description = description;
            this.ConnectionName = connectionName;
            this.SelectedConnectionId = selectedConnectionId;
            this.SelectedConnection = selectedConnection;
            this.Databases = databases;
            this.Password = password;
            this.ApiClientKey = apiClientKey;
            this.ApiClientSecret = apiClientSecret;
            this.IsApiClientSecretSecured = isApiClientSecretSecured;
            this.TenantId = tenantId;
            this.CreatedBy = createdBy;
            this.CreatedDateTime = createdDateTime;
            this.IsDeleted = isDeleted;
            this.LastModifiedBy = lastModifiedBy;
            this.LastModifiedDateTime = lastModifiedDateTime;
            this.ApiAuthUrl = apiAuthUrl;
            this.SelectedConnectionType = selectedConnectionType;
            this.IsDefault = isDefault;
            this.Provider = provider;
            this.Onboarding = onboarding;
        }

        /// <summary>
        /// Details
        /// </summary>
        /// <value>Details</value>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets InstanceName
        /// </summary>
        [DataMember(Name = "instanceName", EmitDefaultValue = true)]
        public string InstanceName { get; set; }

        /// <summary>
        /// Gets or Sets UseCustomId
        /// </summary>
        [DataMember(Name = "useCustomId", EmitDefaultValue = true)]
        public bool UseCustomId { get; set; }

        /// <summary>
        /// Gets or Sets CustomId
        /// </summary>
        [DataMember(Name = "customId", EmitDefaultValue = true)]
        public string CustomId { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets ConnectionName
        /// </summary>
        [DataMember(Name = "connectionName", EmitDefaultValue = true)]
        public string ConnectionName { get; set; }

        /// <summary>
        /// Connection
        /// </summary>
        /// <value>Connection</value>
        [DataMember(Name = "selectedConnectionId", EmitDefaultValue = true)]
        public string SelectedConnectionId { get; set; }

        /// <summary>
        /// Gets or Sets SelectedConnection
        /// </summary>
        [DataMember(Name = "selectedConnection", EmitDefaultValue = false)]
        public EdfiAdminApiEdfiAdminV1EdFiConnection SelectedConnection { get; set; }

        /// <summary>
        /// Gets or Sets Databases
        /// </summary>
        [DataMember(Name = "databases", EmitDefaultValue = false)]
        public EdfiAdminApiEdfiAdminV1InstanceDatabases Databases { get; set; }

        /// <summary>
        /// API Client
        /// </summary>
        /// <value>API Client</value>
        [DataMember(Name = "password", EmitDefaultValue = true)]
        public string Password { get; set; }

        /// <summary>
        /// Gets or Sets ApiClientKey
        /// </summary>
        [DataMember(Name = "apiClientKey", EmitDefaultValue = true)]
        public string ApiClientKey { get; set; }

        /// <summary>
        /// Gets or Sets ApiClientSecret
        /// </summary>
        [DataMember(Name = "apiClientSecret", EmitDefaultValue = true)]
        public string ApiClientSecret { get; set; }

        /// <summary>
        /// Gets or Sets IsApiClientSecretSecured
        /// </summary>
        [DataMember(Name = "isApiClientSecretSecured", EmitDefaultValue = true)]
        public string IsApiClientSecretSecured { get; set; }

        /// <summary>
        /// Metadata
        /// </summary>
        /// <value>Metadata</value>
        [DataMember(Name = "tenantId", EmitDefaultValue = true)]
        public string TenantId { get; set; }

        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name = "createdBy", EmitDefaultValue = true)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Gets or Sets CreatedDateTime
        /// </summary>
        [DataMember(Name = "createdDateTime", EmitDefaultValue = true)]
        public string CreatedDateTime { get; set; }

        /// <summary>
        /// Gets or Sets IsDeleted
        /// </summary>
        [DataMember(Name = "isDeleted", EmitDefaultValue = true)]
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Gets or Sets LastModifiedBy
        /// </summary>
        [DataMember(Name = "lastModifiedBy", EmitDefaultValue = true)]
        public string LastModifiedBy { get; set; }

        /// <summary>
        /// Gets or Sets LastModifiedDateTime
        /// </summary>
        [DataMember(Name = "lastModifiedDateTime", EmitDefaultValue = true)]
        public string LastModifiedDateTime { get; set; }

        /// <summary>
        /// URLs
        /// </summary>
        /// <value>URLs</value>
        [DataMember(Name = "apiAuthUrl", EmitDefaultValue = true)]
        public string ApiAuthUrl { get; set; }

        /// <summary>
        /// Gets or Sets ApiResourcesUrls
        /// </summary>
        [DataMember(Name = "apiResourcesUrls", EmitDefaultValue = true)]
        public List<string> ApiResourcesUrls { get; private set; }

        /// <summary>
        /// Returns false as ApiResourcesUrls should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeApiResourcesUrls()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets ApiCompositesUrls
        /// </summary>
        [DataMember(Name = "apiCompositesUrls", EmitDefaultValue = true)]
        public List<string> ApiCompositesUrls { get; private set; }

        /// <summary>
        /// Returns false as ApiCompositesUrls should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeApiCompositesUrls()
        {
            return false;
        }
        /// <summary>
        /// Connection
        /// </summary>
        /// <value>Connection</value>
        [DataMember(Name = "selectedConnectionType", EmitDefaultValue = true)]
        public string SelectedConnectionType { get; set; }

        /// <summary>
        /// IsDefault
        /// </summary>
        /// <value>IsDefault</value>
        [DataMember(Name = "isDefault", EmitDefaultValue = true)]
        public bool? IsDefault { get; set; }

        /// <summary>
        /// Provider
        /// </summary>
        /// <value>Provider</value>
        [DataMember(Name = "provider", EmitDefaultValue = true)]
        public string Provider { get; set; }

        /// <summary>
        /// Gets or Sets Onboarding
        /// </summary>
        [DataMember(Name = "onboarding", EmitDefaultValue = false)]
        public EdfiAdminApiEdfiAdminV1Onboarding Onboarding { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdfiAdminApiEdfiAdminV1Instance {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  InstanceName: ").Append(InstanceName).Append("\n");
            sb.Append("  UseCustomId: ").Append(UseCustomId).Append("\n");
            sb.Append("  CustomId: ").Append(CustomId).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ConnectionName: ").Append(ConnectionName).Append("\n");
            sb.Append("  SelectedConnectionId: ").Append(SelectedConnectionId).Append("\n");
            sb.Append("  SelectedConnection: ").Append(SelectedConnection).Append("\n");
            sb.Append("  Databases: ").Append(Databases).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  ApiClientKey: ").Append(ApiClientKey).Append("\n");
            sb.Append("  ApiClientSecret: ").Append(ApiClientSecret).Append("\n");
            sb.Append("  IsApiClientSecretSecured: ").Append(IsApiClientSecretSecured).Append("\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  CreatedDateTime: ").Append(CreatedDateTime).Append("\n");
            sb.Append("  IsDeleted: ").Append(IsDeleted).Append("\n");
            sb.Append("  LastModifiedBy: ").Append(LastModifiedBy).Append("\n");
            sb.Append("  LastModifiedDateTime: ").Append(LastModifiedDateTime).Append("\n");
            sb.Append("  ApiAuthUrl: ").Append(ApiAuthUrl).Append("\n");
            sb.Append("  ApiResourcesUrls: ").Append(ApiResourcesUrls).Append("\n");
            sb.Append("  ApiCompositesUrls: ").Append(ApiCompositesUrls).Append("\n");
            sb.Append("  SelectedConnectionType: ").Append(SelectedConnectionType).Append("\n");
            sb.Append("  IsDefault: ").Append(IsDefault).Append("\n");
            sb.Append("  Provider: ").Append(Provider).Append("\n");
            sb.Append("  Onboarding: ").Append(Onboarding).Append("\n");
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
