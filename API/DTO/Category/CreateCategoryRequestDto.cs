namespace API.DTO.Category
{
    public class CreateCategoryRequestDto
    {
        public string AccessToken { get; set; }
        public string Name { get; set; }
        public List<int> BundleIds { get; set; }
    }
}
