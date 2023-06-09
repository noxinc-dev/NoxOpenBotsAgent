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
    /// Schedule
    /// </summary>
    [DataContract]
        public partial class Schedule :  IEquatable<Schedule>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Schedule" /> class.
        /// </summary>
        /// <param name="agentId">agentId.</param>
        /// <param name="agentName">agentName.</param>
        /// <param name="cronExpression">cronExpression.</param>
        /// <param name="lastExecution">lastExecution.</param>
        /// <param name="nextExecution">nextExecution.</param>
        /// <param name="isDisabled">isDisabled.</param>
        /// <param name="projectId">projectId.</param>
        /// <param name="triggerName">triggerName.</param>
        /// <param name="recurrence">recurrence.</param>
        /// <param name="startingType">startingType.</param>
        /// <param name="startJobOn">startJobOn.</param>
        /// <param name="recurrenceUnit">recurrenceUnit.</param>
        /// <param name="jobRecurEveryUnit">jobRecurEveryUnit.</param>
        /// <param name="endJobOn">endJobOn.</param>
        /// <param name="endJobAtOccurence">endJobAtOccurence.</param>
        /// <param name="noJobEndDate">noJobEndDate.</param>
        /// <param name="status">status.</param>
        /// <param name="expiryDate">expiryDate.</param>
        /// <param name="startDate">startDate.</param>
        /// <param name="processId">processId.</param>
        /// <param name="name">name (required).</param>
        /// <param name="id">id.</param>
        /// <param name="isDeleted">isDeleted (default to false).</param>
        /// <param name="createdBy">createdBy.</param>
        /// <param name="createdOn">createdOn.</param>
        /// <param name="deletedBy">deletedBy.</param>
        /// <param name="deleteOn">deleteOn.</param>
        /// <param name="timestamp">timestamp.</param>
        /// <param name="updatedOn">updatedOn.</param>
        /// <param name="updatedBy">updatedBy.</param>
        public Schedule(Guid? agentId = default(Guid?), string agentName = default(string), string cronExpression = default(string), DateTime? lastExecution = default(DateTime?), DateTime? nextExecution = default(DateTime?), bool? isDisabled = default(bool?), Guid? projectId = default(Guid?), string triggerName = default(string), bool? recurrence = default(bool?), string startingType = default(string), DateTime? startJobOn = default(DateTime?), DateTime? recurrenceUnit = default(DateTime?), DateTime? jobRecurEveryUnit = default(DateTime?), DateTime? endJobOn = default(DateTime?), DateTime? endJobAtOccurence = default(DateTime?), DateTime? noJobEndDate = default(DateTime?), string status = default(string), DateTime? expiryDate = default(DateTime?), DateTime? startDate = default(DateTime?), Guid? processId = default(Guid?), string name = default(string), Guid? id = default(Guid?), bool? isDeleted = false, string createdBy = default(string), DateTime? createdOn = default(DateTime?), string deletedBy = default(string), DateTime? deleteOn = default(DateTime?), byte[] timestamp = default(byte[]), DateTime? updatedOn = default(DateTime?), string updatedBy = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for Schedule and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            this.AgentId = agentId;
            this.AgentName = agentName;
            this.CronExpression = cronExpression;
            this.LastExecution = lastExecution;
            this.NextExecution = nextExecution;
            this.IsDisabled = isDisabled;
            this.ProjectId = projectId;
            this.TriggerName = triggerName;
            this.Recurrence = recurrence;
            this.StartingType = startingType;
            this.StartJobOn = startJobOn;
            this.RecurrenceUnit = recurrenceUnit;
            this.JobRecurEveryUnit = jobRecurEveryUnit;
            this.EndJobOn = endJobOn;
            this.EndJobAtOccurence = endJobAtOccurence;
            this.NoJobEndDate = noJobEndDate;
            this.Status = status;
            this.ExpiryDate = expiryDate;
            this.StartDate = startDate;
            this.ProcessId = processId;
            this.Id = id;
            // use default value if no "isDeleted" provided
            if (isDeleted == null)
            {
                this.IsDeleted = false;
            }
            else
            {
                this.IsDeleted = isDeleted;
            }
            this.CreatedBy = createdBy;
            this.CreatedOn = createdOn;
            this.DeletedBy = deletedBy;
            this.DeleteOn = deleteOn;
            this.Timestamp = timestamp;
            this.UpdatedOn = updatedOn;
            this.UpdatedBy = updatedBy;
        }
        
        /// <summary>
        /// Gets or Sets AgentId
        /// </summary>
        [DataMember(Name="agentId", EmitDefaultValue=false)]
        public Guid? AgentId { get; set; }

        /// <summary>
        /// Gets or Sets AgentName
        /// </summary>
        [DataMember(Name="agentName", EmitDefaultValue=false)]
        public string AgentName { get; set; }

        /// <summary>
        /// Gets or Sets CronExpression
        /// </summary>
        [DataMember(Name="cronExpression", EmitDefaultValue=false)]
        public string CronExpression { get; set; }

        /// <summary>
        /// Gets or Sets LastExecution
        /// </summary>
        [DataMember(Name="lastExecution", EmitDefaultValue=false)]
        public DateTime? LastExecution { get; set; }

        /// <summary>
        /// Gets or Sets NextExecution
        /// </summary>
        [DataMember(Name="nextExecution", EmitDefaultValue=false)]
        public DateTime? NextExecution { get; set; }

        /// <summary>
        /// Gets or Sets IsDisabled
        /// </summary>
        [DataMember(Name="isDisabled", EmitDefaultValue=false)]
        public bool? IsDisabled { get; set; }

        /// <summary>
        /// Gets or Sets ProjectId
        /// </summary>
        [DataMember(Name="projectId", EmitDefaultValue=false)]
        public Guid? ProjectId { get; set; }

        /// <summary>
        /// Gets or Sets TriggerName
        /// </summary>
        [DataMember(Name="triggerName", EmitDefaultValue=false)]
        public string TriggerName { get; set; }

        /// <summary>
        /// Gets or Sets Recurrence
        /// </summary>
        [DataMember(Name="recurrence", EmitDefaultValue=false)]
        public bool? Recurrence { get; set; }

        /// <summary>
        /// Gets or Sets StartingType
        /// </summary>
        [DataMember(Name="startingType", EmitDefaultValue=false)]
        public string StartingType { get; set; }

        /// <summary>
        /// Gets or Sets StartJobOn
        /// </summary>
        [DataMember(Name="startJobOn", EmitDefaultValue=false)]
        public DateTime? StartJobOn { get; set; }

        /// <summary>
        /// Gets or Sets RecurrenceUnit
        /// </summary>
        [DataMember(Name="recurrenceUnit", EmitDefaultValue=false)]
        public DateTime? RecurrenceUnit { get; set; }

        /// <summary>
        /// Gets or Sets JobRecurEveryUnit
        /// </summary>
        [DataMember(Name="jobRecurEveryUnit", EmitDefaultValue=false)]
        public DateTime? JobRecurEveryUnit { get; set; }

        /// <summary>
        /// Gets or Sets EndJobOn
        /// </summary>
        [DataMember(Name="endJobOn", EmitDefaultValue=false)]
        public DateTime? EndJobOn { get; set; }

        /// <summary>
        /// Gets or Sets EndJobAtOccurence
        /// </summary>
        [DataMember(Name="endJobAtOccurence", EmitDefaultValue=false)]
        public DateTime? EndJobAtOccurence { get; set; }

        /// <summary>
        /// Gets or Sets NoJobEndDate
        /// </summary>
        [DataMember(Name="noJobEndDate", EmitDefaultValue=false)]
        public DateTime? NoJobEndDate { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets ExpiryDate
        /// </summary>
        [DataMember(Name="expiryDate", EmitDefaultValue=false)]
        public DateTime? ExpiryDate { get; set; }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Gets or Sets ProcessId
        /// </summary>
        [DataMember(Name="processId", EmitDefaultValue=false)]
        public Guid? ProcessId { get; set; }

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
        /// Gets or Sets IsDeleted
        /// </summary>
        [DataMember(Name="isDeleted", EmitDefaultValue=false)]
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Gets or Sets CreatedOn
        /// </summary>
        [DataMember(Name="createdOn", EmitDefaultValue=false)]
        public DateTime? CreatedOn { get; set; }

        /// <summary>
        /// Gets or Sets DeletedBy
        /// </summary>
        [DataMember(Name="deletedBy", EmitDefaultValue=false)]
        public string DeletedBy { get; set; }

        /// <summary>
        /// Gets or Sets DeleteOn
        /// </summary>
        [DataMember(Name="deleteOn", EmitDefaultValue=false)]
        public DateTime? DeleteOn { get; set; }

        /// <summary>
        /// Gets or Sets Timestamp
        /// </summary>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public byte[] Timestamp { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedOn
        /// </summary>
        [DataMember(Name="updatedOn", EmitDefaultValue=false)]
        public DateTime? UpdatedOn { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedBy
        /// </summary>
        [DataMember(Name="updatedBy", EmitDefaultValue=false)]
        public string UpdatedBy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Schedule {\n");
            sb.Append("  AgentId: ").Append(AgentId).Append("\n");
            sb.Append("  AgentName: ").Append(AgentName).Append("\n");
            sb.Append("  CronExpression: ").Append(CronExpression).Append("\n");
            sb.Append("  LastExecution: ").Append(LastExecution).Append("\n");
            sb.Append("  NextExecution: ").Append(NextExecution).Append("\n");
            sb.Append("  IsDisabled: ").Append(IsDisabled).Append("\n");
            sb.Append("  ProjectId: ").Append(ProjectId).Append("\n");
            sb.Append("  TriggerName: ").Append(TriggerName).Append("\n");
            sb.Append("  Recurrence: ").Append(Recurrence).Append("\n");
            sb.Append("  StartingType: ").Append(StartingType).Append("\n");
            sb.Append("  StartJobOn: ").Append(StartJobOn).Append("\n");
            sb.Append("  RecurrenceUnit: ").Append(RecurrenceUnit).Append("\n");
            sb.Append("  JobRecurEveryUnit: ").Append(JobRecurEveryUnit).Append("\n");
            sb.Append("  EndJobOn: ").Append(EndJobOn).Append("\n");
            sb.Append("  EndJobAtOccurence: ").Append(EndJobAtOccurence).Append("\n");
            sb.Append("  NoJobEndDate: ").Append(NoJobEndDate).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ExpiryDate: ").Append(ExpiryDate).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  ProcessId: ").Append(ProcessId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IsDeleted: ").Append(IsDeleted).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  DeletedBy: ").Append(DeletedBy).Append("\n");
            sb.Append("  DeleteOn: ").Append(DeleteOn).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  UpdatedOn: ").Append(UpdatedOn).Append("\n");
            sb.Append("  UpdatedBy: ").Append(UpdatedBy).Append("\n");
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
            return this.Equals(input as Schedule);
        }

        /// <summary>
        /// Returns true if Schedule instances are equal
        /// </summary>
        /// <param name="input">Instance of Schedule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Schedule input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AgentId == input.AgentId ||
                    (this.AgentId != null &&
                    this.AgentId.Equals(input.AgentId))
                ) && 
                (
                    this.AgentName == input.AgentName ||
                    (this.AgentName != null &&
                    this.AgentName.Equals(input.AgentName))
                ) && 
                (
                    this.CronExpression == input.CronExpression ||
                    (this.CronExpression != null &&
                    this.CronExpression.Equals(input.CronExpression))
                ) && 
                (
                    this.LastExecution == input.LastExecution ||
                    (this.LastExecution != null &&
                    this.LastExecution.Equals(input.LastExecution))
                ) && 
                (
                    this.NextExecution == input.NextExecution ||
                    (this.NextExecution != null &&
                    this.NextExecution.Equals(input.NextExecution))
                ) && 
                (
                    this.IsDisabled == input.IsDisabled ||
                    (this.IsDisabled != null &&
                    this.IsDisabled.Equals(input.IsDisabled))
                ) && 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.TriggerName == input.TriggerName ||
                    (this.TriggerName != null &&
                    this.TriggerName.Equals(input.TriggerName))
                ) && 
                (
                    this.Recurrence == input.Recurrence ||
                    (this.Recurrence != null &&
                    this.Recurrence.Equals(input.Recurrence))
                ) && 
                (
                    this.StartingType == input.StartingType ||
                    (this.StartingType != null &&
                    this.StartingType.Equals(input.StartingType))
                ) && 
                (
                    this.StartJobOn == input.StartJobOn ||
                    (this.StartJobOn != null &&
                    this.StartJobOn.Equals(input.StartJobOn))
                ) && 
                (
                    this.RecurrenceUnit == input.RecurrenceUnit ||
                    (this.RecurrenceUnit != null &&
                    this.RecurrenceUnit.Equals(input.RecurrenceUnit))
                ) && 
                (
                    this.JobRecurEveryUnit == input.JobRecurEveryUnit ||
                    (this.JobRecurEveryUnit != null &&
                    this.JobRecurEveryUnit.Equals(input.JobRecurEveryUnit))
                ) && 
                (
                    this.EndJobOn == input.EndJobOn ||
                    (this.EndJobOn != null &&
                    this.EndJobOn.Equals(input.EndJobOn))
                ) && 
                (
                    this.EndJobAtOccurence == input.EndJobAtOccurence ||
                    (this.EndJobAtOccurence != null &&
                    this.EndJobAtOccurence.Equals(input.EndJobAtOccurence))
                ) && 
                (
                    this.NoJobEndDate == input.NoJobEndDate ||
                    (this.NoJobEndDate != null &&
                    this.NoJobEndDate.Equals(input.NoJobEndDate))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.ExpiryDate == input.ExpiryDate ||
                    (this.ExpiryDate != null &&
                    this.ExpiryDate.Equals(input.ExpiryDate))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.ProcessId == input.ProcessId ||
                    (this.ProcessId != null &&
                    this.ProcessId.Equals(input.ProcessId))
                ) && 
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
                    this.IsDeleted == input.IsDeleted ||
                    (this.IsDeleted != null &&
                    this.IsDeleted.Equals(input.IsDeleted))
                ) && 
                (
                    this.CreatedBy == input.CreatedBy ||
                    (this.CreatedBy != null &&
                    this.CreatedBy.Equals(input.CreatedBy))
                ) && 
                (
                    this.CreatedOn == input.CreatedOn ||
                    (this.CreatedOn != null &&
                    this.CreatedOn.Equals(input.CreatedOn))
                ) && 
                (
                    this.DeletedBy == input.DeletedBy ||
                    (this.DeletedBy != null &&
                    this.DeletedBy.Equals(input.DeletedBy))
                ) && 
                (
                    this.DeleteOn == input.DeleteOn ||
                    (this.DeleteOn != null &&
                    this.DeleteOn.Equals(input.DeleteOn))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
                ) && 
                (
                    this.UpdatedOn == input.UpdatedOn ||
                    (this.UpdatedOn != null &&
                    this.UpdatedOn.Equals(input.UpdatedOn))
                ) && 
                (
                    this.UpdatedBy == input.UpdatedBy ||
                    (this.UpdatedBy != null &&
                    this.UpdatedBy.Equals(input.UpdatedBy))
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
                if (this.AgentId != null)
                    hashCode = hashCode * 59 + this.AgentId.GetHashCode();
                if (this.AgentName != null)
                    hashCode = hashCode * 59 + this.AgentName.GetHashCode();
                if (this.CronExpression != null)
                    hashCode = hashCode * 59 + this.CronExpression.GetHashCode();
                if (this.LastExecution != null)
                    hashCode = hashCode * 59 + this.LastExecution.GetHashCode();
                if (this.NextExecution != null)
                    hashCode = hashCode * 59 + this.NextExecution.GetHashCode();
                if (this.IsDisabled != null)
                    hashCode = hashCode * 59 + this.IsDisabled.GetHashCode();
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.TriggerName != null)
                    hashCode = hashCode * 59 + this.TriggerName.GetHashCode();
                if (this.Recurrence != null)
                    hashCode = hashCode * 59 + this.Recurrence.GetHashCode();
                if (this.StartingType != null)
                    hashCode = hashCode * 59 + this.StartingType.GetHashCode();
                if (this.StartJobOn != null)
                    hashCode = hashCode * 59 + this.StartJobOn.GetHashCode();
                if (this.RecurrenceUnit != null)
                    hashCode = hashCode * 59 + this.RecurrenceUnit.GetHashCode();
                if (this.JobRecurEveryUnit != null)
                    hashCode = hashCode * 59 + this.JobRecurEveryUnit.GetHashCode();
                if (this.EndJobOn != null)
                    hashCode = hashCode * 59 + this.EndJobOn.GetHashCode();
                if (this.EndJobAtOccurence != null)
                    hashCode = hashCode * 59 + this.EndJobAtOccurence.GetHashCode();
                if (this.NoJobEndDate != null)
                    hashCode = hashCode * 59 + this.NoJobEndDate.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.ExpiryDate != null)
                    hashCode = hashCode * 59 + this.ExpiryDate.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.ProcessId != null)
                    hashCode = hashCode * 59 + this.ProcessId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IsDeleted != null)
                    hashCode = hashCode * 59 + this.IsDeleted.GetHashCode();
                if (this.CreatedBy != null)
                    hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.CreatedOn != null)
                    hashCode = hashCode * 59 + this.CreatedOn.GetHashCode();
                if (this.DeletedBy != null)
                    hashCode = hashCode * 59 + this.DeletedBy.GetHashCode();
                if (this.DeleteOn != null)
                    hashCode = hashCode * 59 + this.DeleteOn.GetHashCode();
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                if (this.UpdatedOn != null)
                    hashCode = hashCode * 59 + this.UpdatedOn.GetHashCode();
                if (this.UpdatedBy != null)
                    hashCode = hashCode * 59 + this.UpdatedBy.GetHashCode();
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
