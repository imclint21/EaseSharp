using System;
using System.Security.Cryptography;
using System.Text;

namespace ClintSharp
{
	public static class CryptoExtension
	{
		/// <summary>
		/// Compute a Md5 hash
		/// </summary>
		public static string ToMd5(this string value) => BitConverter.ToString(MD5.Create()
			.ComputeHash(Encoding.UTF8.GetBytes(value))).Clean();
		
		/// <summary>
		/// Compute a Sha1 hash
		/// </summary>
		public static string ToSha1(this string value) => BitConverter.ToString(new SHA1Managed()
			.ComputeHash(Encoding.UTF8.GetBytes(value))).Clean();
		
		/// <summary>
		/// Compute a Sha256 hash
		/// </summary>
		public static string ToSha256(this string value) => BitConverter.ToString(new SHA256Managed()
			.ComputeHash(Encoding.UTF8.GetBytes(value))).Clean();
		
		/// <summary>
		/// Compute a Sha512 hash
		/// </summary>
		public static string ToSha512(this string value) => BitConverter.ToString(new SHA512Managed()
			.ComputeHash(Encoding.UTF8.GetBytes(value))).Clean();

		private static string Clean(this string value) => value.Trim().Replace("-", "").ToLower();
	}
}