namespace DomashnayaKniga.Tests
{
    public class EncryptorTests
    {
        [Fact]
        public void HashesAreRandomized()
        {
            string hash1 = Encryptor.Hasher("password", null);
            string hash2 = Encryptor.Hasher("password", null);
            Assert.NotEqual(hash1, hash2);        }

        [Fact]
        public void HashMatchSuccess()
        {
            string hash1 = Encryptor.Hasher("password", null);
            string hash2 = Encryptor.Hasher("password", Encryptor.Extract(hash1));
            Assert.Equal(hash1, hash2);
        }

        [Fact]
        public void HashMatchFailure()
        {
            string hash1 = Encryptor.Hasher("password", null);
            string hash2 = Encryptor.Hasher("wrong", Encryptor.Extract(hash1));
            Assert.NotEqual(hash1, hash2);
        }
    }
}