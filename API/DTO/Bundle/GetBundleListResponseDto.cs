using API.DTO.Category;

namespace API.DTO.Bundle
{
    public class GetBundleListResponseDto
    {
        public bool Success { get; set; }
        public List<CategoryBundleDto> Data { get; set; }
    }
}
