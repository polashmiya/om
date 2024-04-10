using System;
using System.Collections.Generic;

namespace OM.Models
{
    public partial class Employee
    {
        public int Id { get; set; }
        public string? EmployeeId { get; set; }
        public string? EmployeeName { get; set; }
        public int DesignationId { get; set; }
        public string DesignationName { get; set; } = null!;
        public string MobileNo { get; set; } = null!;
        public string Emaill { get; set; } = null!;
        public DateTime JoiningDate { get; set; }
        public DateTime? ConfirmationDate { get; set; }
        public int? EmployeeTypeId { get; set; }
        public string? EmployeeTypeName { get; set; }
        public int OfficeId { get; set; }
        public string OfficeName { get; set; } = null!;
        public int? DepartmentId { get; set; }
        public string? DepartmentName { get; set; }
        public int? ReligionId { get; set; }
        public string? ReligionName { get; set; }
        public int? GenderId { get; set; }
        public string? GenderName { get; set; }
        public int? BloodGroupId { get; set; }
        public string? BloodGroupName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? OfficialContact { get; set; }
        public string? Nid { get; set; }
        public string? PresentAddress { get; set; }
        public string? PermanentAddress { get; set; }
        public int? SupervisorId { get; set; }
        public int? LineManagerId { get; set; }
        public bool? IsUser { get; set; }
        public bool? IsMasterUser { get; set; }
        public bool? IsAdmin { get; set; }
    }
}
