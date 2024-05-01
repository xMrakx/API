namespace API.DTO.Bundle
{
    public class GetBundleDetailsResponseDto
    {
        public bool Success { get; set; }
        public BundleDataDto Data { get; set; }
    }

    public class BundleDataDto
    {
        public int BundleId { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public List<string> Images { get; set; }
        public List<BundleItemDto> BundleItems { get; set; }

    }

    public class BundleItemDto
    {
        public int BundleItemId { get; set; }
        public int Count { get; set; }
        public string Name { get; set; }
        //public List<ITEMS?>
        public int FunctionalType { get; set; }
        public bool Available { get; set; }
        public string UnavailableReason { get; set; }
    }
}
