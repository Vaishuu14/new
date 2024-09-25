namespace LibraryManagmentSystem.WebAPI
{
    public class Jwtsettings
    {
        public string SecreteKey {  get; set; }
        public string Issuer { get; set; }
        public string Audience { get; set; }
        public int ExpiryMinutes { get; set; }

    }
}
