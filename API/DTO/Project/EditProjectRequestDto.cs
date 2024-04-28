namespace API.DTO.Project
{
    public class EditProjectRequestDto
    {
        public string AccessToken { get; set; }
        public int ProjectId { get; set; }
        public string Name { get; set; }
    }
}
