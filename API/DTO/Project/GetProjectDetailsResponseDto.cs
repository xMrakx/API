﻿namespace API.DTO.Project
{
    public class GetProjectDetailsResponseDto
    {
        public bool Success { get; set; }
        public ProjectDetailsDataDto Data { get; set; }
    }

    public class ProjectDetailsDataDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ProjectDataBundlesDto> Bundles { get; set; }
    }

    public class ProjectDataBundlesDto
    {
        public int Id { get; set; }
        public int Count { get; set; }
        public string Name { get; set; }
    }
}