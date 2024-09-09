namespace OM.DTO
{
    public class DepartmentDTO
    {
        public int DepartmentId { get; set; }
        public string? DepartmentName { get; set; }
    }

    public class ManagerDTO
    {
        public int ManagerId { get; set; }
        public int DepartmentId { get; set; }
        public string? ManagerName { get; set; }
    }

    public class OfficeDTO
    {
        public int OfficeId { get; set; }
        public string? OfficeName { get; set; }
    }

    public class CreateOfficeDTO
    {
        public string? OfficeName { get; set; }
    }

    public class ProjectDTO
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public int? TeamMemberId { get; set; }
    }

    public class MessageHelper
    {
        public string? Message { get; set; }
        public int StatusCode { get; set; }
    }

    public class UpdateOfficeDTO
    {
        public int OfficeId { get; set; }
        public string? OfficeName { get; set; }
    }

    public class CommonDDLDTO
    {
        public int Value { get; set; }
        public string? Label { get; set; }
    }
}
