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
    /// QueueItemViewModel
    /// </summary>
    [DataContract]
        public partial class QueueItemViewModel :  IEquatable<QueueItemViewModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueueItemViewModel" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="id">id.</param>
        /// <param name="state">state.</param>
        /// <param name="stateMessage">stateMessage.</param>
        /// <param name="isLocked">isLocked.</param>
        /// <param name="lockedBy">lockedBy.</param>
        /// <param name="lockedOnUTC">lockedOnUTC.</param>
        /// <param name="lockedUntilUTC">lockedUntilUTC.</param>
        /// <param name="lockedEndTimeUTC">lockedEndTimeUTC.</param>
        /// <param name="expireOnUTC">expireOnUTC.</param>
        /// <param name="postponeUntilUTC">postponeUntilUTC.</param>
        /// <param name="errorCode">errorCode.</param>
        /// <param name="errorMessage">errorMessage.</param>
        /// <param name="errorSerialized">errorSerialized.</param>
        /// <param name="source">source.</param>
        /// <param name="_event">_event.</param>
        public QueueItemViewModel(string name = default(string), Guid? id = default(Guid?), string state = default(string), string stateMessage = default(string), bool? isLocked = default(bool?), Guid? lockedBy = default(Guid?), DateTime? lockedOnUTC = default(DateTime?), DateTime? lockedUntilUTC = default(DateTime?), DateTime? lockedEndTimeUTC = default(DateTime?), DateTime? expireOnUTC = default(DateTime?), DateTime? postponeUntilUTC = default(DateTime?), string errorCode = default(string), string errorMessage = default(string), string errorSerialized = default(string), string source = default(string), string _event = default(string))
        {
            this.Name = name;
            this.Id = id;
            this.State = state;
            this.StateMessage = stateMessage;
            this.IsLocked = isLocked;
            this.LockedBy = lockedBy;
            this.LockedOnUTC = lockedOnUTC;
            this.LockedUntilUTC = lockedUntilUTC;
            this.LockedEndTimeUTC = lockedEndTimeUTC;
            this.ExpireOnUTC = expireOnUTC;
            this.PostponeUntilUTC = postponeUntilUTC;
            this.ErrorCode = errorCode;
            this.ErrorMessage = errorMessage;
            this.ErrorSerialized = errorSerialized;
            this.Source = source;
            this.Event = _event;
        }
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid? Id { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }

        /// <summary>
        /// Gets or Sets StateMessage
        /// </summary>
        [DataMember(Name="stateMessage", EmitDefaultValue=false)]
        public string StateMessage { get; set; }

        /// <summary>
        /// Gets or Sets IsLocked
        /// </summary>
        [DataMember(Name="isLocked", EmitDefaultValue=false)]
        public bool? IsLocked { get; set; }

        /// <summary>
        /// Gets or Sets LockedBy
        /// </summary>
        [DataMember(Name="lockedBy", EmitDefaultValue=false)]
        public Guid? LockedBy { get; set; }

        /// <summary>
        /// Gets or Sets LockedOnUTC
        /// </summary>
        [DataMember(Name="lockedOnUTC", EmitDefaultValue=false)]
        public DateTime? LockedOnUTC { get; set; }

        /// <summary>
        /// Gets or Sets LockedUntilUTC
        /// </summary>
        [DataMember(Name="lockedUntilUTC", EmitDefaultValue=false)]
        public DateTime? LockedUntilUTC { get; set; }

        /// <summary>
        /// Gets or Sets LockedEndTimeUTC
        /// </summary>
        [DataMember(Name="lockedEndTimeUTC", EmitDefaultValue=false)]
        public DateTime? LockedEndTimeUTC { get; set; }

        /// <summary>
        /// Gets or Sets ExpireOnUTC
        /// </summary>
        [DataMember(Name="expireOnUTC", EmitDefaultValue=false)]
        public DateTime? ExpireOnUTC { get; set; }

        /// <summary>
        /// Gets or Sets PostponeUntilUTC
        /// </summary>
        [DataMember(Name="postponeUntilUTC", EmitDefaultValue=false)]
        public DateTime? PostponeUntilUTC { get; set; }

        /// <summary>
        /// Gets or Sets ErrorCode
        /// </summary>
        [DataMember(Name="errorCode", EmitDefaultValue=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// Gets or Sets ErrorMessage
        /// </summary>
        [DataMember(Name="errorMessage", EmitDefaultValue=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Gets or Sets ErrorSerialized
        /// </summary>
        [DataMember(Name="errorSerialized", EmitDefaultValue=false)]
        public string ErrorSerialized { get; set; }

        /// <summary>
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public string Source { get; set; }

        /// <summary>
        /// Gets or Sets Event
        /// </summary>
        [DataMember(Name="event", EmitDefaultValue=false)]
        public string Event { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueueItemViewModel {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  StateMessage: ").Append(StateMessage).Append("\n");
            sb.Append("  IsLocked: ").Append(IsLocked).Append("\n");
            sb.Append("  LockedBy: ").Append(LockedBy).Append("\n");
            sb.Append("  LockedOnUTC: ").Append(LockedOnUTC).Append("\n");
            sb.Append("  LockedUntilUTC: ").Append(LockedUntilUTC).Append("\n");
            sb.Append("  LockedEndTimeUTC: ").Append(LockedEndTimeUTC).Append("\n");
            sb.Append("  ExpireOnUTC: ").Append(ExpireOnUTC).Append("\n");
            sb.Append("  PostponeUntilUTC: ").Append(PostponeUntilUTC).Append("\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  ErrorSerialized: ").Append(ErrorSerialized).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Event: ").Append(Event).Append("\n");
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
            return this.Equals(input as QueueItemViewModel);
        }

        /// <summary>
        /// Returns true if QueueItemViewModel instances are equal
        /// </summary>
        /// <param name="input">Instance of QueueItemViewModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueueItemViewModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.StateMessage == input.StateMessage ||
                    (this.StateMessage != null &&
                    this.StateMessage.Equals(input.StateMessage))
                ) && 
                (
                    this.IsLocked == input.IsLocked ||
                    (this.IsLocked != null &&
                    this.IsLocked.Equals(input.IsLocked))
                ) && 
                (
                    this.LockedBy == input.LockedBy ||
                    (this.LockedBy != null &&
                    this.LockedBy.Equals(input.LockedBy))
                ) && 
                (
                    this.LockedOnUTC == input.LockedOnUTC ||
                    (this.LockedOnUTC != null &&
                    this.LockedOnUTC.Equals(input.LockedOnUTC))
                ) && 
                (
                    this.LockedUntilUTC == input.LockedUntilUTC ||
                    (this.LockedUntilUTC != null &&
                    this.LockedUntilUTC.Equals(input.LockedUntilUTC))
                ) && 
                (
                    this.LockedEndTimeUTC == input.LockedEndTimeUTC ||
                    (this.LockedEndTimeUTC != null &&
                    this.LockedEndTimeUTC.Equals(input.LockedEndTimeUTC))
                ) && 
                (
                    this.ExpireOnUTC == input.ExpireOnUTC ||
                    (this.ExpireOnUTC != null &&
                    this.ExpireOnUTC.Equals(input.ExpireOnUTC))
                ) && 
                (
                    this.PostponeUntilUTC == input.PostponeUntilUTC ||
                    (this.PostponeUntilUTC != null &&
                    this.PostponeUntilUTC.Equals(input.PostponeUntilUTC))
                ) && 
                (
                    this.ErrorCode == input.ErrorCode ||
                    (this.ErrorCode != null &&
                    this.ErrorCode.Equals(input.ErrorCode))
                ) && 
                (
                    this.ErrorMessage == input.ErrorMessage ||
                    (this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(input.ErrorMessage))
                ) && 
                (
                    this.ErrorSerialized == input.ErrorSerialized ||
                    (this.ErrorSerialized != null &&
                    this.ErrorSerialized.Equals(input.ErrorSerialized))
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.Event == input.Event ||
                    (this.Event != null &&
                    this.Event.Equals(input.Event))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.StateMessage != null)
                    hashCode = hashCode * 59 + this.StateMessage.GetHashCode();
                if (this.IsLocked != null)
                    hashCode = hashCode * 59 + this.IsLocked.GetHashCode();
                if (this.LockedBy != null)
                    hashCode = hashCode * 59 + this.LockedBy.GetHashCode();
                if (this.LockedOnUTC != null)
                    hashCode = hashCode * 59 + this.LockedOnUTC.GetHashCode();
                if (this.LockedUntilUTC != null)
                    hashCode = hashCode * 59 + this.LockedUntilUTC.GetHashCode();
                if (this.LockedEndTimeUTC != null)
                    hashCode = hashCode * 59 + this.LockedEndTimeUTC.GetHashCode();
                if (this.ExpireOnUTC != null)
                    hashCode = hashCode * 59 + this.ExpireOnUTC.GetHashCode();
                if (this.PostponeUntilUTC != null)
                    hashCode = hashCode * 59 + this.PostponeUntilUTC.GetHashCode();
                if (this.ErrorCode != null)
                    hashCode = hashCode * 59 + this.ErrorCode.GetHashCode();
                if (this.ErrorMessage != null)
                    hashCode = hashCode * 59 + this.ErrorMessage.GetHashCode();
                if (this.ErrorSerialized != null)
                    hashCode = hashCode * 59 + this.ErrorSerialized.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.Event != null)
                    hashCode = hashCode * 59 + this.Event.GetHashCode();
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
