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
    /// EdfiAdminApiEdfiAdminV1InstanceDatabases
    /// </summary>
    [DataContract(Name = "EdfiAdminApi.EdfiAdmin.V1.InstanceDatabases")]
    public partial class EdfiAdminApiEdfiAdminV1InstanceDatabases : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdfiAdminApiEdfiAdminV1InstanceDatabases" /> class.
        /// </summary>
        /// <param name="admin">admin.</param>
        /// <param name="security">security.</param>
        public EdfiAdminApiEdfiAdminV1InstanceDatabases(EdfiAdminApiEdfiAdminV1InstanceDatabase admin = default(EdfiAdminApiEdfiAdminV1InstanceDatabase), EdfiAdminApiEdfiAdminV1InstanceDatabase security = default(EdfiAdminApiEdfiAdminV1InstanceDatabase))
        {
            this.Admin = admin;
            this.Security = security;
        }

        /// <summary>
        /// Gets or Sets Admin
        /// </summary>
        [DataMember(Name = "admin", EmitDefaultValue = false)]
        public EdfiAdminApiEdfiAdminV1InstanceDatabase Admin { get; set; }

        /// <summary>
        /// Gets or Sets Security
        /// </summary>
        [DataMember(Name = "security", EmitDefaultValue = false)]
        public EdfiAdminApiEdfiAdminV1InstanceDatabase Security { get; set; }

        /// <summary>
        /// Gets or Sets Ods
        /// </summary>
        [DataMember(Name = "ods", EmitDefaultValue = true)]
        public List<EdfiAdminApiEdfiAdminV1InstanceOdsDatabase> Ods { get; private set; }

        /// <summary>
        /// Returns false as Ods should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeOds()
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
            sb.Append("class EdfiAdminApiEdfiAdminV1InstanceDatabases {\n");
            sb.Append("  Admin: ").Append(Admin).Append("\n");
            sb.Append("  Security: ").Append(Security).Append("\n");
            sb.Append("  Ods: ").Append(Ods).Append("\n");
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
