namespace API.DTO.Project
{
    public class CreateProjectResponseDto
    {
        public bool Success { get; set; }
        public ProjectDetailsDataDto Data { get; set; }
        public string description { get; set; }
        public string author { get; set; }
        public string responsible { get; set; }
    }
}
