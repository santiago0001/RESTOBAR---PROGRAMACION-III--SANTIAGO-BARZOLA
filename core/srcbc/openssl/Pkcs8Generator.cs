/*
    This file is part of the iText (R) project.
    Copyright (c) 1998-2019 iText Group NV
    Authors: iText Software.

This program is free software; you can redistribute it and/or modify it under the terms of the GNU Affero General Public License version 3 as published by the Free Software Foundation with the addition of the following permission added to Section 15 as permitted in Section 7(a): FOR ANY PART OF THE COVERED WORK IN WHICH THE COPYRIGHT IS OWNED BY iText Group NV, iText Group NV DISCLAIMS THE WARRANTY OF NON INFRINGEMENT OF THIRD PARTY RIGHTS.

This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU Affero General Public License for more details.
You should have received a copy of the GNU Affero General Public License along with this program; if not, see http://www.gnu.org/licenses or write to the Free Software Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA, 02110-1301 USA, or download the license from the following URL:

http://itextpdf.com/terms-of-use/

The interactive user interfaces in modified source and object code versions of this program must display Appropriate Legal Notices, as required under Section 5 of the GNU Affero General Public License.

In accordance with Section 7(b) of the GNU Affero General Public License, a covered work must retain the producer line in every PDF that is created or manipulated using iText.

You can be released from the requirements of the license by purchasing a commercial license. Buying such a license is mandatory as soon as you develop commercial activities involving the iText software without disclosing the source code of your own applications.
These activities include: offering paid services to customers as an ASP, serving PDFs on the fly in a web application, shipping iText with a closed source product.

For more information, please contact iText Software Corp. at this address: sales@itextpdf.com */
using System;
using System.Collections;
using System.IO;

using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Nist;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Pkcs;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities.IO.Pem;

namespace Org.BouncyCastle.OpenSsl
{
	public class Pkcs8Generator
		: PemObjectGenerator
	{
		// FIXME See PbeUtilities static constructor
//		public static readonly string Aes128Cbc = NistObjectIdentifiers.IdAes128Cbc.Id;
//		public static readonly string Aes192Cbc = NistObjectIdentifiers.IdAes192Cbc.Id;
//		public static readonly string Aes256Cbc = NistObjectIdentifiers.IdAes256Cbc.Id;
//
//		public static readonly string Des3Cbc = PkcsObjectIdentifiers.DesEde3Cbc.Id;

		public static readonly string PbeSha1_RC4_128 = PkcsObjectIdentifiers.PbeWithShaAnd128BitRC4.Id;
		public static readonly string PbeSha1_RC4_40 = PkcsObjectIdentifiers.PbeWithShaAnd40BitRC4.Id;
		public static readonly string PbeSha1_3DES = PkcsObjectIdentifiers.PbeWithShaAnd3KeyTripleDesCbc.Id;
		public static readonly string PbeSha1_2DES = PkcsObjectIdentifiers.PbeWithShaAnd2KeyTripleDesCbc.Id;
		public static readonly string PbeSha1_RC2_128 = PkcsObjectIdentifiers.PbeWithShaAnd128BitRC2Cbc.Id;
		public static readonly string PbeSha1_RC2_40 = PkcsObjectIdentifiers.PbewithShaAnd40BitRC2Cbc.Id;

		private char[]					password;
		private string					algorithm;
		private int						iterationCount;
		private AsymmetricKeyParameter	privKey;
		private SecureRandom			random;

		/**
		* Constructor for an unencrypted private key PEM object.
		*
		* @param key private key to be encoded.
		*/
		public Pkcs8Generator(AsymmetricKeyParameter privKey)
		{
			this.privKey = privKey;
		}

		/**
		* Constructor for an encrypted private key PEM object.
		*
		* @param key       private key to be encoded
		* @param algorithm encryption algorithm to use
		* @param provider  provider to use
		* @throws NoSuchAlgorithmException if algorithm/mode cannot be found
		*/
		public Pkcs8Generator(AsymmetricKeyParameter privKey, string algorithm)
		{
			// TODO Check privKey.IsPrivate
			this.privKey = privKey;
			this.algorithm = algorithm;
			this.iterationCount = 2048;
		}

		public SecureRandom SecureRandom
		{
			set { this.random = value; }
		}

		public char[] Password
		{
			set { this.password = value; }
		}

		public int IterationCount
		{
			set { this.iterationCount = value; }
		}

		public PemObject Generate()
		{
			if (algorithm == null)
			{
				PrivateKeyInfo pki = PrivateKeyInfoFactory.CreatePrivateKeyInfo(privKey);

				return new PemObject("PRIVATE KEY", pki.GetEncoded());
			}

			// TODO Theoretically, the amount of salt needed depends on the algorithm
			byte[] salt = new byte[20];
			if (random == null)
			{
				random = new SecureRandom();
			}
			random.NextBytes(salt);

			try
			{
				EncryptedPrivateKeyInfo epki = EncryptedPrivateKeyInfoFactory.CreateEncryptedPrivateKeyInfo(
					algorithm, password, salt, iterationCount, privKey);
	
				return new PemObject("ENCRYPTED PRIVATE KEY", epki.GetEncoded());
			}
			catch (Exception e)
			{
				throw new PemGenerationException("Couldn't encrypt private key", e);
			}
		}
	}
}
