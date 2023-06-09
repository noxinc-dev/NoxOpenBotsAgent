/* 
 * OpenBots Server API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = OpenBots.Service.API.Client.SwaggerDateConverter;

namespace OpenBots.Service.API.Model
{
    /// <summary>
    /// EmailAttachment
    /// </summary>
    [DataContract]
        public partial class EmailAttachment :  IEquatable<EmailAttachment>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailAttachment" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="contentType">contentType.</param>
        /// <param name="sizeInBytes">sizeInBytes.</param>
        /// <param name="fileName">fileName.</param>
        /// <param name="isContentStored">isContentStored.</param>
        /// <param name="contentStorageAddress">Address where Content of the Attachment is Stored.</param>
        /// <param name="content">content.</param>
        public EmailAttachment(string id = default(string), string name = default(string), string contentType = default(string), double? sizeInBytes = default(double?), string fileName = default(string), string isContentStored = default(string), string contentStorageAddress = default(string), byte[] content = default(byte[]))
        {
            this.Id = id;
            this.Name = name;
            this.ContentType = contentType;
            this.SizeInBytes = sizeInBytes;
            this.FileName = fileName;
            this.IsContentStored = isContentStored;
            this.ContentStorageAddress = contentStorageAddress;
            this.Content = content;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets ContentType
        /// </summary>
        [DataMember(Name="contentType", EmitDefaultValue=false)]
        public string ContentType { get; set; }

        /// <summary>
        /// Gets or Sets SizeInBytes
        /// </summary>
        [DataMember(Name="sizeInBytes", EmitDefaultValue=false)]
        public double? SizeInBytes { get; set; }

        /// <summary>
        /// Gets or Sets FileName
        /// </summary>
        [DataMember(Name="fileName", EmitDefaultValue=false)]
        public string FileName { get; set; }

        /// <summary>
        /// Gets or Sets IsContentStored
        /// </summary>
        [DataMember(Name="isContentStored", EmitDefaultValue=false)]
        public string IsContentStored { get; set; }

        /// <summary>
        /// Address where Content of the Attachment is Stored
        /// </summary>
        /// <value>Address where Content of the Attachment is Stored</value>
        [DataMember(Name="contentStorageAddress", EmitDefaultValue=false)]
        public string ContentStorageAddress { get; set; }

        /// <summary>
        /// Gets or Sets Content
        /// </summary>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public byte[] Content { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmailAttachment {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
            sb.Append("  SizeInBytes: ").Append(SizeInBytes).Append("\n");
            sb.Append("  FileName: ").Append(FileName).Append("\n");
            sb.Append("  IsContentStored: ").Append(IsContentStored).Append("\n");
            sb.Append("  ContentStorageAddress: ").Append(ContentStorageAddress).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as EmailAttachment);
        }

        /// <summary>
        /// Returns true if EmailAttachment instances are equal
        /// </summary>
        /// <param name="input">Instance of EmailAttachment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailAttachment input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ContentType == input.ContentType ||
                    (this.ContentType != null &&
                    this.ContentType.Equals(input.ContentType))
                ) && 
                (
                    this.SizeInBytes == input.SizeInBytes ||
                    (this.SizeInBytes != null &&
                    this.SizeInBytes.Equals(input.SizeInBytes))
                ) && 
                (
                    this.FileName == input.FileName ||
                    (this.FileName != null &&
                    this.FileName.Equals(input.FileName))
                ) && 
                (
                    this.IsContentStored == input.IsContentStored ||
                    (this.IsContentStored != null &&
                    this.IsContentStored.Equals(input.IsContentStored))
                ) && 
                (
                    this.ContentStorageAddress == input.ContentStorageAddress ||
                    (this.ContentStorageAddress != null &&
                    this.ContentStorageAddress.Equals(input.ContentStorageAddress))
                ) && 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ContentType != null)
                    hashCode = hashCode * 59 + this.ContentType.GetHashCode();
                if (this.SizeInBytes != null)
                    hashCode = hashCode * 59 + this.SizeInBytes.GetHashCode();
                if (this.FileName != null)
                    hashCode = hashCode * 59 + this.FileName.GetHashCode();
                if (this.IsContentStored != null)
                    hashCode = hashCode * 59 + this.IsContentStored.GetHashCode();
                if (this.ContentStorageAddress != null)
                    hashCode = hashCode * 59 + this.ContentStorageAddress.GetHashCode();
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
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
