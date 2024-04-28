namespace API.DTO.Category
{
    public class EditCategoryRequestDto
    {
        public string AccessToken { get; set; }
        public string CategoryId { get; set; }
        public string Name { get; set; }
        public List<int > BundleIds { get; set; }
    }
}
