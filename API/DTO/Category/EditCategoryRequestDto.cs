namespace API.DTO.Category
{
    public class EditCategoryRequestDto
    {
        public string accessToken { get; set; }
        public string categoryId { get; set; }
        public string name { get; set; }
        public List<int> bundleIds { get; set; }
    }
}
