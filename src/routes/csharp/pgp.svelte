<script>
    import Highlight  from 'svelte-highlight';
    import csharp from "svelte-highlight/src/languages/csharp";
    import "svelte-highlight/src/styles/base16-monokai.css";
</script>

<h1>RSA PGP decryption in C#</h1>
<p>
    The following is an example of PGP RSA decryption in C#,
    as there are no good examples I have found thus far.
    This code has been tested, is complete,
    and I used ReSharper to clean it up as much as possible while keeping it fully working.
    Enjoy!
</p>

<p>
    Just use the following code, and make sure you set
    <code>_passphrase</code> and <code>_privateKey</code>.
</p>

<h2>Crypto.cs</h2>
<Highlight language={csharp} code="using System;
using System.IO;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Org.BouncyCastle.Bcpg.OpenPgp;

public class Crypto
&#123;
    private readonly string                 _passphrase; // Private key passphrase
    private readonly string                 _privateKey; // Private key in ASCII armor format (not base64)

    public string Decrypt(string inputData)
    &#123;
        using var inputStream = inputData.GetStream();
        using var keyIn       = _privateKey.GetStream(Encoding.ASCII);
        var       output      = Decrypt(inputStream, keyIn, _passphrase);

        return output;
    &#125;

    private string Decrypt(Stream inputStream, Stream privateKeyStream, string passPhrase)
    &#123;
        string output;

        var pgpFactory = new PgpObjectFactory(PgpUtilities.GetDecoderStream(inputStream));
        // find secret key
        var pgpKeyRing = new PgpSecretKeyRingBundle(PgpUtilities.GetDecoderStream(privateKeyStream));
        var pgp        = pgpFactory.NextPgpObject();

        // the first object might be a PGP marker packet.
        PgpEncryptedDataList encryptedData;
        if (pgp is PgpEncryptedDataList list)
            encryptedData = list;
        else
            encryptedData = (PgpEncryptedDataList) pgpFactory.NextPgpObject();

        // decrypt
        PgpPrivateKey             privateKey = null;
        PgpPublicKeyEncryptedData pubKeyData = null;
        foreach (PgpPublicKeyEncryptedData pubKeyDataItem in encryptedData.GetEncryptedDataObjects())
        &#123;
            privateKey = FindSecretKey(pgpKeyRing, pubKeyDataItem.KeyId, passPhrase.ToCharArray());

            if (privateKey == null) continue;
            pubKeyData = pubKeyDataItem;
            break;
        &#125;

        if (privateKey == null) throw new ArgumentException(&quot;Secret key for message not found.&quot;);

        PgpObjectFactory plainFact;
        using (var clear = pubKeyData.GetDataStream(privateKey))
        &#123;
            plainFact = new PgpObjectFactory(clear);
        &#125;

        var message = plainFact.NextPgpObject();

        switch (message)
        &#123;
            case PgpCompressedData data:
                &#123;
                    var              compressedData       = data;
                    PgpObjectFactory pgpCompressedFactory = null;

                    using (var compDataIn = compressedData.GetDataStream())
                    &#123;
                        pgpCompressedFactory = new PgpObjectFactory(compDataIn);
                    &#125;

                    message = pgpCompressedFactory.NextPgpObject();
                    PgpLiteralData literalData                      = null;
                    if (message is PgpOnePassSignatureList) message = pgpCompressedFactory.NextPgpObject();

                    literalData = (PgpLiteralData) message;
                    using (var unc = literalData.GetInputStream())
                    &#123;
                        output = IoHelper.GetString(unc);
                    &#125;

                    break;
                &#125;
            case PgpLiteralData data:
                &#123;
                    var       literalData = data;
                    using var unc         = literalData.GetInputStream();
                    output = IoHelper.GetString(unc);

                    break;
                &#125;
            case PgpOnePassSignatureList _:
                throw new PgpException(&quot;Encrypted message contains a signed message - not literal data.&quot;);
            default:
                throw new PgpException(&quot;Message is not a simple encrypted file - type unknown.&quot;);
        &#125;

        return output;
    &#125;

    private static PgpPrivateKey FindSecretKey(PgpSecretKeyRingBundle pgpSec, long keyId, char[] pass)
        => pgpSec.GetSecretKey(keyId)?.ExtractPrivateKey(pass);
&#125;" />

<h2>IOHelper.cs</h2>
<Highlight language={csharp} code="using System.IO;
using System.Text;

public static class IoHelper
    &#123;
        public static Stream GetStream(this string s, Encoding encoding = null)
        &#123;
            var stream = new MemoryStream();
            var writer = encoding != null ? new StreamWriter(stream, encoding) : new StreamWriter(stream);
            writer.Write(s);
            writer.Flush();
            stream.Position = 0;
            return stream;
        &#125;

        public static string GetString(Stream inputStream)
        &#123;
            using var reader = new StreamReader(inputStream);
            var       output = reader.ReadToEnd();
            return output;
        &#125;

        public static void WriteStream(Stream inputStream, ref byte[] dataBytes)
        &#123;
            using var outputStream = inputStream;
            outputStream.Write(dataBytes, 0, dataBytes.Length);
        &#125;
    &#125;" />
