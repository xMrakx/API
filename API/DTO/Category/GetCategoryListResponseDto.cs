namespace API.DTO.Category
{
    public class GetCategoryListResponseDto
    {
        public bool Success { get; set; }
        public List<CategoryDataDto> Data { get; set; }
    }

    public class CategoryDataDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<CategoryBundleDto> Bundles { get; set; }
    }

    public class CategoryBundleDto
    {
        public int Id { get; set; }
        public int Count { get; set; }
        public string Name { get; set; }
    }
}
