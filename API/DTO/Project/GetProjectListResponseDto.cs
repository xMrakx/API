using API.DTO.Bundle;

namespace API.DTO.Project
{
    public class GetProjectListResponseDto
    {
        public bool Success { get; set; }
        public List<ProjectDataDto> Data { get; set; }
    }

    public class ProjectDataDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    
}
