using System;

namespace Dialler.API.Dialer.Data;

public class EncryptionSetting
{
public bool EnableEncryption { get; set; }
public string EncryptionAlgorithm { get; set; }
public string PublicKey { get; set; }
public string PrivateKey { get; set; }

}
