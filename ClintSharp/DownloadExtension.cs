using System;
using System.Net;

namespace ClintSharp
{
	public static class DownloadExtension
	{
		public static string Download(this Uri value) => new WebClient().DownloadString(value);
		
		public static string Upload(this Uri value, string data) => new WebClient().UploadString(value, data);
	}
}