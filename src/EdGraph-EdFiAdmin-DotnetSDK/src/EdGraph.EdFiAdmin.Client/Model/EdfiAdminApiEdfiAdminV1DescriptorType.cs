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
    /// EdfiAdminApiEdfiAdminV1DescriptorType
    /// </summary>
    [DataContract(Name = "EdfiAdminApi.EdfiAdmin.V1.DescriptorType")]
    public partial class EdfiAdminApiEdfiAdminV1DescriptorType : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdfiAdminApiEdfiAdminV1DescriptorType" /> class.
        /// </summary>
        /// <param name="descriptorId">descriptorId.</param>
        /// <param name="varNamespace">varNamespace.</param>
        /// <param name="codeValue">codeValue.</param>
        /// <param name="shortDescription">shortDescription.</param>
        /// <param name="description">description.</param>
        public EdfiAdminApiEdfiAdminV1DescriptorType(int descriptorId = default(int), string varNamespace = default(string), string codeValue = default(string), string shortDescription = default(string), string description = default(string))
        {
            this.DescriptorId = descriptorId;
            this.VarNamespace = varNamespace;
            this.CodeValue = codeValue;
            this.ShortDescription = shortDescription;
            this.Description = description;
        }

        /// <summary>
        /// Gets or Sets DescriptorId
        /// </summary>
        [DataMember(Name = "descriptorId", EmitDefaultValue = false)]
        public int DescriptorId { get; set; }

        /// <summary>
        /// Gets or Sets VarNamespace
        /// </summary>
        [DataMember(Name = "namespace", EmitDefaultValue = true)]
        public string VarNamespace { get; set; }

        /// <summary>
        /// Gets or Sets CodeValue
        /// </summary>
        [DataMember(Name = "codeValue", EmitDefaultValue = true)]
        public string CodeValue { get; set; }

        /// <summary>
        /// Gets or Sets ShortDescription
        /// </summary>
        [DataMember(Name = "shortDescription", EmitDefaultValue = true)]
        public string ShortDescription { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdfiAdminApiEdfiAdminV1DescriptorType {\n");
            sb.Append("  DescriptorId: ").Append(DescriptorId).Append("\n");
            sb.Append("  VarNamespace: ").Append(VarNamespace).Append("\n");
            sb.Append("  CodeValue: ").Append(CodeValue).Append("\n");
            sb.Append("  ShortDescription: ").Append(ShortDescription).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
