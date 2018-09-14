using Microsoft.IdentityModel.Tokens;
using System.Security.Cryptography;

namespace ProjectBaseX.Api.Auth
{
    public class SigningConfigurations
    {
       
        /// <summary>
        /// Chave de criptografia utilizada na criação de tokens;
        /// </summary>
        public SecurityKey Key { get; }

        /// <summary>
        /// Chave de criptografia e o algoritmo de segurança empregados 
        /// na geração de assinaturas digitais para tokens
        /// </summary>
        public SigningCredentials SigningCredentials { get; }

        /// <summary>
        /// Construtor responsável pela inicialização das propriedades 
        /// Key e SigningCredentials
        /// </summary>
        public SigningConfigurations()
        {
            using (var provider = new RSACryptoServiceProvider(2048))
            {
                Key = new RsaSecurityKey(provider.ExportParameters(true));
            }

            SigningCredentials = new SigningCredentials(
                Key, SecurityAlgorithms.RsaSha256Signature);
        }
    }
}
