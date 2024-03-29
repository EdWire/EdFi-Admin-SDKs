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
    /// EdfiAdminApiEdfiAdminV1EdFiApplicationApiClientProfileResponse
    /// </summary>
    [DataContract(Name = "EdfiAdminApi.EdfiAdmin.V1.EdFiApplicationApiClientProfileResponse")]
    public partial class EdfiAdminApiEdfiAdminV1EdFiApplicationApiClientProfileResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdfiAdminApiEdfiAdminV1EdFiApplicationApiClientProfileResponse" /> class.
        /// </summary>
        /// <param name="tenantId">tenantId.</param>
        /// <param name="instanceId">instanceId.</param>
        /// <param name="apiClientId">apiClientId.</param>
        /// <param name="key">key.</param>
        /// <param name="secret">secret.</param>
        /// <param name="name">name.</param>
        /// <param name="isApproved">isApproved.</param>
        /// <param name="useSandbox">useSandbox.</param>
        /// <param name="sandboxType">sandboxType.</param>
        /// <param name="applicationId">applicationId.</param>
        /// <param name="secretIsHashed">secretIsHashed.</param>
        /// <param name="keyStatus">keyStatus.</param>
        public EdfiAdminApiEdfiAdminV1EdFiApplicationApiClientProfileResponse(string tenantId = default(string), string instanceId = default(string), int apiClientId = default(int), string key = default(string), string secret = default(string), string name = default(string), bool isApproved = default(bool), bool useSandbox = default(bool), int sandboxType = default(int), int applicationId = default(int), bool secretIsHashed = default(bool), string keyStatus = default(string))
        {
            this.TenantId = tenantId;
            this.InstanceId = instanceId;
            this.ApiClientId = apiClientId;
            this.Key = key;
            this.Secret = secret;
            this.Name = name;
            this.IsApproved = isApproved;
            this.UseSandbox = useSandbox;
            this.SandboxType = sandboxType;
            this.ApplicationId = applicationId;
            this.SecretIsHashed = secretIsHashed;
            this.KeyStatus = keyStatus;
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
        /// Gets or Sets ApiClientId
        /// </summary>
        [DataMember(Name = "apiClientId", EmitDefaultValue = false)]
        public int ApiClientId { get; set; }

        /// <summary>
        /// Gets or Sets Key
        /// </summary>
        [DataMember(Name = "key", EmitDefaultValue = true)]
        public string Key { get; set; }

        /// <summary>
        /// Gets or Sets Secret
        /// </summary>
        [DataMember(Name = "secret", EmitDefaultValue = true)]
        public string Secret { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets IsApproved
        /// </summary>
        [DataMember(Name = "isApproved", EmitDefaultValue = true)]
        public bool IsApproved { get; set; }

        /// <summary>
        /// Gets or Sets UseSandbox
        /// </summary>
        [DataMember(Name = "useSandbox", EmitDefaultValue = true)]
        public bool UseSandbox { get; set; }

        /// <summary>
        /// Gets or Sets SandboxType
        /// </summary>
        [DataMember(Name = "sandboxType", EmitDefaultValue = false)]
        public int SandboxType { get; set; }

        /// <summary>
        /// Gets or Sets ApplicationId
        /// </summary>
        [DataMember(Name = "applicationId", EmitDefaultValue = false)]
        public int ApplicationId { get; set; }

        /// <summary>
        /// Gets or Sets SecretIsHashed
        /// </summary>
        [DataMember(Name = "secretIsHashed", EmitDefaultValue = true)]
        public bool SecretIsHashed { get; set; }

        /// <summary>
        /// Gets or Sets KeyStatus
        /// </summary>
        [DataMember(Name = "keyStatus", EmitDefaultValue = true)]
        public string KeyStatus { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdfiAdminApiEdfiAdminV1EdFiApplicationApiClientProfileResponse {\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  InstanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  ApiClientId: ").Append(ApiClientId).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Secret: ").Append(Secret).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  IsApproved: ").Append(IsApproved).Append("\n");
            sb.Append("  UseSandbox: ").Append(UseSandbox).Append("\n");
            sb.Append("  SandboxType: ").Append(SandboxType).Append("\n");
            sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
            sb.Append("  SecretIsHashed: ").Append(SecretIsHashed).Append("\n");
            sb.Append("  KeyStatus: ").Append(KeyStatus).Append("\n");
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