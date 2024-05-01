using API.DTO.Bundle;
using System.Runtime.CompilerServices;

namespace API.DTO.Project
{
    public class GetProjectListResponseDto
    {
        public bool Success { get; set; }
        public List<ProjectDataDto> Data { get; set; }
    }

    public class ProjectDataDto
    {
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public string Responsible { get; set; }
    }
}
