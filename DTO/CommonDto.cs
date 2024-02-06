namespace OM.DTOs
{
    public class DepartmentDTO
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
    }

    public class EmployeeDTO
    {
        public int EmployeeId { get; set; }
        public int DepartmentId { get; set; }
        public int? ManagerId { get; set; }
        public string EmployeeName { get; set; }
        public decimal Salary { get; set; }
    }

    public class ManagerDTO
    {
        public int ManagerId { get; set; }
        public int DepartmentId { get; set; }
        public string ManagerName { get; set; }
    }

    public class OfficeDTO
    {
        public int OfficeId { get; set; }
        public string OfficeName { get; set; }
    }
    public class CreateOfficeDTO
    {
        public string OfficeName { get; set; }
        // Add other properties as needed
    }
    public class ProjectDTO
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public int? TeamMemberId { get; set; }
    }

    public class UpdateOfficeDTO
    {
        public int OfficeId { get; set; }
        public string OfficeName { get; set; }
    }


}
