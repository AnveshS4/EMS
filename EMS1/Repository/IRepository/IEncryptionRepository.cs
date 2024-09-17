using System;
namespace EMS1.Repository.IRepository
{
    public interface IEncryptionRepository
    {
        byte[] GenerateSalt();

        string HashPassword(string password, byte[] salt);
    }
}
