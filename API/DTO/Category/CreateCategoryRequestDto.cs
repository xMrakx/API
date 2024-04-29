namespace API.DTO.Category
{
    public class CreateCategoryRequestDto
    {
        public string accessToken { get; set; }
        public string name { get; set; }
        public List<int> bundleIds { get; set; }
    }
}
