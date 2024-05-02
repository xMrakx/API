namespace API.DTO.Bundle
{
    public class ChangeBundleFunctionalRequestDto
    {
        public string accessToken { get; set; }
        public int bundleItemId { get; set; }
        public int type { get; set; }
    }
}
