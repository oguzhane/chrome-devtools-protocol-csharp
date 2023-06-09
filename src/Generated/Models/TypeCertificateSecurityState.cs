// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Chrome.DevTools.Models
{
    /// <summary> Details about the security state of the page certificate. </summary>
    public partial class TypeCertificateSecurityState
    {
        /// <summary> Initializes a new instance of TypeCertificateSecurityState. </summary>
        /// <param name="protocol"> Protocol name (e.g. &quot;TLS 1.2&quot; or &quot;QUIC&quot;). </param>
        /// <param name="keyExchange"> Key Exchange used by the connection, or the empty string if not applicable. </param>
        /// <param name="cipher"> Cipher name. </param>
        /// <param name="certificate"> Page certificate. </param>
        /// <param name="subjectName"> Certificate subject name. </param>
        /// <param name="issuer"> Name of the issuing CA. </param>
        /// <param name="validFrom"> Certificate valid from date. </param>
        /// <param name="validTo"> Certificate valid to (expiration) date. </param>
        /// <param name="certificateHasWeakSignature"> True if the certificate uses a weak signature aglorithm. </param>
        /// <param name="certificateHasSha1Signature"> True if the certificate has a SHA1 signature in the chain. </param>
        /// <param name="modernSSL"> True if modern SSL. </param>
        /// <param name="obsoleteSslProtocol"> True if the connection is using an obsolete SSL protocol. </param>
        /// <param name="obsoleteSslKeyExchange"> True if the connection is using an obsolete SSL key exchange. </param>
        /// <param name="obsoleteSslCipher"> True if the connection is using an obsolete SSL cipher. </param>
        /// <param name="obsoleteSslSignature"> True if the connection is using an obsolete SSL signature. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="protocol"/>, <paramref name="keyExchange"/>, <paramref name="cipher"/>, <paramref name="certificate"/>, <paramref name="subjectName"/> or <paramref name="issuer"/> is null. </exception>
        public TypeCertificateSecurityState(string protocol, string keyExchange, string cipher, IEnumerable<string> certificate, string subjectName, string issuer, float validFrom, float validTo, bool certificateHasWeakSignature, bool certificateHasSha1Signature, bool modernSSL, bool obsoleteSslProtocol, bool obsoleteSslKeyExchange, bool obsoleteSslCipher, bool obsoleteSslSignature)
        {
            Argument.AssertNotNull(protocol, nameof(protocol));
            Argument.AssertNotNull(keyExchange, nameof(keyExchange));
            Argument.AssertNotNull(cipher, nameof(cipher));
            Argument.AssertNotNull(certificate, nameof(certificate));
            Argument.AssertNotNull(subjectName, nameof(subjectName));
            Argument.AssertNotNull(issuer, nameof(issuer));

            Protocol = protocol;
            KeyExchange = keyExchange;
            Cipher = cipher;
            Certificate = certificate.ToList();
            SubjectName = subjectName;
            Issuer = issuer;
            ValidFrom = validFrom;
            ValidTo = validTo;
            CertificateHasWeakSignature = certificateHasWeakSignature;
            CertificateHasSha1Signature = certificateHasSha1Signature;
            ModernSSL = modernSSL;
            ObsoleteSslProtocol = obsoleteSslProtocol;
            ObsoleteSslKeyExchange = obsoleteSslKeyExchange;
            ObsoleteSslCipher = obsoleteSslCipher;
            ObsoleteSslSignature = obsoleteSslSignature;
        }

        /// <summary> Initializes a new instance of TypeCertificateSecurityState. </summary>
        /// <param name="protocol"> Protocol name (e.g. &quot;TLS 1.2&quot; or &quot;QUIC&quot;). </param>
        /// <param name="keyExchange"> Key Exchange used by the connection, or the empty string if not applicable. </param>
        /// <param name="keyExchangeGroup"> (EC)DH group used by the connection, if applicable. </param>
        /// <param name="cipher"> Cipher name. </param>
        /// <param name="mac"> TLS MAC. Note that AEAD ciphers do not have separate MACs. </param>
        /// <param name="certificate"> Page certificate. </param>
        /// <param name="subjectName"> Certificate subject name. </param>
        /// <param name="issuer"> Name of the issuing CA. </param>
        /// <param name="validFrom"> Certificate valid from date. </param>
        /// <param name="validTo"> Certificate valid to (expiration) date. </param>
        /// <param name="certificateNetworkError"> The highest priority network error code, if the certificate has an error. </param>
        /// <param name="certificateHasWeakSignature"> True if the certificate uses a weak signature aglorithm. </param>
        /// <param name="certificateHasSha1Signature"> True if the certificate has a SHA1 signature in the chain. </param>
        /// <param name="modernSSL"> True if modern SSL. </param>
        /// <param name="obsoleteSslProtocol"> True if the connection is using an obsolete SSL protocol. </param>
        /// <param name="obsoleteSslKeyExchange"> True if the connection is using an obsolete SSL key exchange. </param>
        /// <param name="obsoleteSslCipher"> True if the connection is using an obsolete SSL cipher. </param>
        /// <param name="obsoleteSslSignature"> True if the connection is using an obsolete SSL signature. </param>
        internal TypeCertificateSecurityState(string protocol, string keyExchange, string keyExchangeGroup, string cipher, string mac, IList<string> certificate, string subjectName, string issuer, float validFrom, float validTo, string certificateNetworkError, bool certificateHasWeakSignature, bool certificateHasSha1Signature, bool modernSSL, bool obsoleteSslProtocol, bool obsoleteSslKeyExchange, bool obsoleteSslCipher, bool obsoleteSslSignature)
        {
            Protocol = protocol;
            KeyExchange = keyExchange;
            KeyExchangeGroup = keyExchangeGroup;
            Cipher = cipher;
            Mac = mac;
            Certificate = certificate;
            SubjectName = subjectName;
            Issuer = issuer;
            ValidFrom = validFrom;
            ValidTo = validTo;
            CertificateNetworkError = certificateNetworkError;
            CertificateHasWeakSignature = certificateHasWeakSignature;
            CertificateHasSha1Signature = certificateHasSha1Signature;
            ModernSSL = modernSSL;
            ObsoleteSslProtocol = obsoleteSslProtocol;
            ObsoleteSslKeyExchange = obsoleteSslKeyExchange;
            ObsoleteSslCipher = obsoleteSslCipher;
            ObsoleteSslSignature = obsoleteSslSignature;
        }

        /// <summary> Protocol name (e.g. &quot;TLS 1.2&quot; or &quot;QUIC&quot;). </summary>
        public string Protocol { get; set; }
        /// <summary> Key Exchange used by the connection, or the empty string if not applicable. </summary>
        public string KeyExchange { get; set; }
        /// <summary> (EC)DH group used by the connection, if applicable. </summary>
        public string KeyExchangeGroup { get; set; }
        /// <summary> Cipher name. </summary>
        public string Cipher { get; set; }
        /// <summary> TLS MAC. Note that AEAD ciphers do not have separate MACs. </summary>
        public string Mac { get; set; }
        /// <summary> Page certificate. </summary>
        public IList<string> Certificate { get; }
        /// <summary> Certificate subject name. </summary>
        public string SubjectName { get; set; }
        /// <summary> Name of the issuing CA. </summary>
        public string Issuer { get; set; }
        /// <summary> Certificate valid from date. </summary>
        public float ValidFrom { get; set; }
        /// <summary> Certificate valid to (expiration) date. </summary>
        public float ValidTo { get; set; }
        /// <summary> The highest priority network error code, if the certificate has an error. </summary>
        public string CertificateNetworkError { get; set; }
        /// <summary> True if the certificate uses a weak signature aglorithm. </summary>
        public bool CertificateHasWeakSignature { get; set; }
        /// <summary> True if the certificate has a SHA1 signature in the chain. </summary>
        public bool CertificateHasSha1Signature { get; set; }
        /// <summary> True if modern SSL. </summary>
        public bool ModernSSL { get; set; }
        /// <summary> True if the connection is using an obsolete SSL protocol. </summary>
        public bool ObsoleteSslProtocol { get; set; }
        /// <summary> True if the connection is using an obsolete SSL key exchange. </summary>
        public bool ObsoleteSslKeyExchange { get; set; }
        /// <summary> True if the connection is using an obsolete SSL cipher. </summary>
        public bool ObsoleteSslCipher { get; set; }
        /// <summary> True if the connection is using an obsolete SSL signature. </summary>
        public bool ObsoleteSslSignature { get; set; }
    }
}
