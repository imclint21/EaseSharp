using System;
using System.Text;

namespace ClintSharp
{
	public static class EncodingExtension
	{
		/// <summary>
		/// Encode to base64
		/// </summary>
		public static string ToBas64(this string value) => Convert.ToBase64String(Encoding.UTF8.GetBytes(value));
		
		/// <summary>
		/// Decode from base64
		/// </summary>
		public static string FromBas64(this string value) => Encoding.UTF8.GetString(Convert.FromBase64String(value));

		// public static string ToHtmlEncode(this string value) => HttpUtility.HtmlEncode(value);
		
		// public static string ToHtmlEncode(this string value) => HttpUtility.HtmlDecode(value);
	}
}