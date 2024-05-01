namespace API.DTO.Bundle
{
    public class ChangeBundleFunctionalRequestDto
    {
        public string accessToken { get; set; }
        public int bundleId { get; set; }
        public int type { get; set; }
    }
}
