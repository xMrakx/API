namespace API.DTO.Profile
{
    public class UserDataResponseDto
    {
        public bool Success { get; set; }
        public UserDataDto Data { get; set; }
    }

    public class UserDataDto
    {
        public int UserId { get; set; }
        public string LastName { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public int UserRole { get; set; }
        public string Email { get; set; }
    }
}
