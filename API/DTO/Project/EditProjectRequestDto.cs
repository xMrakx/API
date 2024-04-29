namespace API.DTO.Project
{
    public class EditProjectRequestDto
    {
        public string accessToken { get; set; }
        public int projectId { get; set; }
        public string name { get; set; }
    }
}
