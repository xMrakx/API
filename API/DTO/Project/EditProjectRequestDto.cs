﻿namespace API.DTO.Project
{
    public class EditProjectRequestDto
    {
        public string accessToken { get; set; }
        public int projectId { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string author { get; set; }
        public string responsible { get; set; }
    }
}
