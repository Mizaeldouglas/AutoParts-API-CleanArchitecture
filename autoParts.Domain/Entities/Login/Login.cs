namespace autoParts.Domain.Entities.Login;

public class Login
{
    public long Id { get; set; }
    public string UserName { get; set; }
    public byte[] PasswordHash { get; set; }
    public byte[] PasswordSalt { get; set; }
}