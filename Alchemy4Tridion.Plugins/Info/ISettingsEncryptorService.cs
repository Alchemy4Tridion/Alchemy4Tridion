
using System;
namespace Alchemy4Tridion.Plugins.Info
{
    /// <summary>
    /// Interface for service responsible for encrypting and decrypting custom configuration settings.
    /// </summary>
    public interface ISettingsEncryptorService
    {
        /// <summary>
        /// Sets the encryption key (can only be set once).
        /// </summary>
        string EncryptionKey
        {
            set;
        }

        /// <summary>
        /// Encrypts a given text into diciphered text.
        /// </summary>
        /// <param name="clearText">The clear undeciphered text.</param>
        /// <returns>The deciphered text.</returns>
        string Encrypt(string clearText);

        /// <summary>
        /// Decrypts a given diciphered text back into clear text.
        /// </summary>
        /// <param name="decipherText">The deciphered text.</param>
        /// <param name="encryptionKey">The encryption key to decrypt settings with.</param>
        /// <returns></returns>
        string Decrypt(string decipherText, string encryptionKey);

        /// <summary>
        /// Gets whether or not a given value is encrypted or not.
        /// </summary>
        /// <param name="value">The value to check.</param>
        /// <returns>True if the value is encrypted, or false if its not.</returns>
        bool IsValueEncrypted(string value);

        /// <summary>
        /// Gets whether or not a given key matches the plugin's encryption key.
        /// </summary>
        /// <param name="encryptionKey"></param>
        /// <returns></returns>
        bool MatchesEncryptionKey(string encryptionKey);
    }
}
