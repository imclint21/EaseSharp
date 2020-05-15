namespace ClintSharp
{
	public static class HtmlExtension
	{
		public static string Bold(this string value) => $"<strong>{value}</strong>";
		
		public static string Italic(this string value) => $"<em>{value}</em>";
		
		public static string Underline(this string value) => $"<u>{value}</u>";
		
		public static string H1(this string value) => $"<h1>{value}</h1>";
		
		public static string H2(this string value) => $"<h2>{value}</h2>";
		
		public static string Paragraph(this string value) => $"<p>{value}</p>";
		
		public static string Link(this string value, string label) => $"<a href=\"{value}\">{label}</a>";
	}
}