/*
 * Admin API Documentation
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1
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
    /// EdFiOdsAdminApiFeaturesVendorsAddVendorRequest
    /// </summary>
    [DataContract(Name = "EdFi.Ods.AdminApi.Features.Vendors.AddVendor.Request")]
    public partial class EdFiOdsAdminApiFeaturesVendorsAddVendorRequest : IEquatable<EdFiOdsAdminApiFeaturesVendorsAddVendorRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiOdsAdminApiFeaturesVendorsAddVendorRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiOdsAdminApiFeaturesVendorsAddVendorRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiOdsAdminApiFeaturesVendorsAddVendorRequest" /> class.
        /// </summary>
        /// <param name="company">Vendor/ company name (required).</param>
        /// <param name="namespacePrefixes">Namespace prefix for the vendor. Multiple namespace prefixes can be provided as comma separated list if required. (required).</param>
        /// <param name="contactName">Vendor contact name (required).</param>
        /// <param name="contactEmailAddress">Vendor contact email id (required).</param>
        public EdFiOdsAdminApiFeaturesVendorsAddVendorRequest(string company = default(string), string namespacePrefixes = default(string), string contactName = default(string), string contactEmailAddress = default(string))
        {
            // to ensure "company" is required (not null)
            if (company == null)
            {
                throw new ArgumentNullException("company is a required property for EdFiOdsAdminApiFeaturesVendorsAddVendorRequest and cannot be null");
            }
            this.Company = company;
            // to ensure "namespacePrefixes" is required (not null)
            if (namespacePrefixes == null)
            {
                throw new ArgumentNullException("namespacePrefixes is a required property for EdFiOdsAdminApiFeaturesVendorsAddVendorRequest and cannot be null");
            }
            this.NamespacePrefixes = namespacePrefixes;
            // to ensure "contactName" is required (not null)
            if (contactName == null)
            {
                throw new ArgumentNullException("contactName is a required property for EdFiOdsAdminApiFeaturesVendorsAddVendorRequest and cannot be null");
            }
            this.ContactName = contactName;
            // to ensure "contactEmailAddress" is required (not null)
            if (contactEmailAddress == null)
            {
                throw new ArgumentNullException("contactEmailAddress is a required property for EdFiOdsAdminApiFeaturesVendorsAddVendorRequest and cannot be null");
            }
            this.ContactEmailAddress = contactEmailAddress;
        }

        /// <summary>
        /// Vendor/ company name
        /// </summary>
        /// <value>Vendor/ company name</value>
        [DataMember(Name = "company", IsRequired = true, EmitDefaultValue = true)]
        public string Company { get; set; }

        /// <summary>
        /// Namespace prefix for the vendor. Multiple namespace prefixes can be provided as comma separated list if required.
        /// </summary>
        /// <value>Namespace prefix for the vendor. Multiple namespace prefixes can be provided as comma separated list if required.</value>
        [DataMember(Name = "namespacePrefixes", IsRequired = true, EmitDefaultValue = true)]
        public string NamespacePrefixes { get; set; }

        /// <summary>
        /// Vendor contact name
        /// </summary>
        /// <value>Vendor contact name</value>
        [DataMember(Name = "contactName", IsRequired = true, EmitDefaultValue = true)]
        public string ContactName { get; set; }

        /// <summary>
        /// Vendor contact email id
        /// </summary>
        /// <value>Vendor contact email id</value>
        [DataMember(Name = "contactEmailAddress", IsRequired = true, EmitDefaultValue = true)]
        public string ContactEmailAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdFiOdsAdminApiFeaturesVendorsAddVendorRequest {\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  NamespacePrefixes: ").Append(NamespacePrefixes).Append("\n");
            sb.Append("  ContactName: ").Append(ContactName).Append("\n");
            sb.Append("  ContactEmailAddress: ").Append(ContactEmailAddress).Append("\n");
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
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as EdFiOdsAdminApiFeaturesVendorsAddVendorRequest);
        }

        /// <summary>
        /// Returns true if EdFiOdsAdminApiFeaturesVendorsAddVendorRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiOdsAdminApiFeaturesVendorsAddVendorRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiOdsAdminApiFeaturesVendorsAddVendorRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Company == input.Company ||
                    (this.Company != null &&
                    this.Company.Equals(input.Company))
                ) && 
                (
                    this.NamespacePrefixes == input.NamespacePrefixes ||
                    (this.NamespacePrefixes != null &&
                    this.NamespacePrefixes.Equals(input.NamespacePrefixes))
                ) && 
                (
                    this.ContactName == input.ContactName ||
                    (this.ContactName != null &&
                    this.ContactName.Equals(input.ContactName))
                ) && 
                (
                    this.ContactEmailAddress == input.ContactEmailAddress ||
                    (this.ContactEmailAddress != null &&
                    this.ContactEmailAddress.Equals(input.ContactEmailAddress))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Company != null)
                {
                    hashCode = (hashCode * 59) + this.Company.GetHashCode();
                }
                if (this.NamespacePrefixes != null)
                {
                    hashCode = (hashCode * 59) + this.NamespacePrefixes.GetHashCode();
                }
                if (this.ContactName != null)
                {
                    hashCode = (hashCode * 59) + this.ContactName.GetHashCode();
                }
                if (this.ContactEmailAddress != null)
                {
                    hashCode = (hashCode * 59) + this.ContactEmailAddress.GetHashCode();
                }
                return hashCode;
            }
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
