using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dialler.API.Dialer.DTO
{
    public class EncryptionSettingDto
    {
        public bool EnableEncryption { get; set; }
        public string EncryptionAlgorithm { get; set; }
        public string PublicKey { get; set; }
        public string PrivateKey { get; set; }
    }
}