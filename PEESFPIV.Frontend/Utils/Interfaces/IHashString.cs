namespace PEESFPIV.Frontend.Utils.Interfaces;

public interface IHashString
{
    string HashString(string key);
    string HashPassword(string key, out byte[] salt);
    /// <summary>
    /// return <c>true</c> if password 
    /// is equal otherwise return <c>false</c>
    /// </summary>
    bool VerifyPassword(string password, string hashedPassword, byte[] salt);
}