using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Stringier.Glyphs {
	/// <summary>
	/// Represents a variancy table used for glyph variant lookups.
	/// </summary>
	public static class VariancyTable {
		/// <summary>
		/// The set of variants in this table.
		/// </summary>
		private static readonly Dictionary<Int32, String[]> Variants = new Dictionary<Int32, String[]> {
				#region Latin-1 Supplement
				{ 'À', new[] { "\u00C0", "\u0041\u0300" } },
				{ 'Á', new[] { "\u00C1", "\u0041\u0301" } },
				{ 'Â', new[] { "\u00C2", "\u0041\u0302" } },
				{ 'Ã', new[] { "\u00C3", "\u0041\u0303" } },
				{ 'Ä', new[] { "\u00C4", "\u0041\u0308" } },
				{ 'Å', new[] { "\u00C5", "\u0041\u030A" } },
				{ 'Ç', new[] { "\u00C7", "\u0043\u0327" } },
				{ 'È', new[] { "\u00C8", "\u0045\u0300" } },
				{ 'É', new[] { "\u00C9", "\u0045\u0301" } },
				{ 'Ê', new[] { "\u00CA", "\u0045\u0302" } },
				{ 'Ë', new[] { "\u00CB", "\u0045\u0308" } },
				{ 'Ì', new[] { "\u00CC", "\u0049\u0300" } },
				{ 'Í', new[] { "\u00CD", "\u0049\u0301" } },
				{ 'Î', new[] { "\u00CF", "\u0049\u0308" } },
				{ 'Ñ', new[] { "\u00D1", "\u004E\u0303" } },
				{ 'Ò', new[] { "\u00D2", "\u004F\u0300" } },
				{ 'Ó', new[] { "\u00D3", "\u004F\u0301" } },
				{ 'Ô', new[] { "\u00D4", "\u004F\u0302" } },
				{ 'Õ', new[] { "\u00D5", "\u004F\u0303" } },
				{ 'Ö', new[] { "\u00D6", "\u004F\u0308" } },
				{ 'Ù', new[] { "\u00D9", "\u0055\u0300" } },
				{ 'Ú', new[] { "\u00DA", "\u0055\u0301" } },
				{ 'Û', new[] { "\u00DB", "\u0055\u0302" } },
				{ 'Ü', new[] { "\u00DC", "\u0055\u0308" } },
				{ 'Ý', new[] { "\u00DD", "\u0059\u0301" } },
				{ 'à', new[] { "\u00E0", "\u0061\u0300" } },
				{ 'á', new[] { "\u00E1", "\u0061\u0301" } },
				{ 'â', new[] { "\u00E2", "\u0061\u0302" } },
				{ 'ã', new[] { "\u00E3", "\u0061\u0303" } },
				{ 'ä', new[] { "\u00E4", "\u0061\u0308" } },
				{ 'å', new[] { "\u00E5", "\u0061\u030A" } },
				{ 'ç', new[] { "\u00E7", "\u0063\u0327" } },
				{ 'è', new[] { "\u00E8", "\u0065\u0300" } },
				{ 'é', new[] { "\u00E9", "\u0065\u0301" } },
				{ 'ê', new[] { "\u00EA", "\u0065\u0302" } },
				{ 'ë', new[] { "\u00EB", "\u0065\u0308" } },
				{ 'ì', new[] { "\u00EC", "\u0069\u0300" } },
				{ 'í', new[] { "\u00ED", "\u0069\u0301" } },
				{ 'î', new[] { "\u00EE", "\u0069\u0302" } },
				{ 'ï', new[] { "\u00EF", "\u0069\u0308" } },
				{ 'ñ', new[] { "\u00F1", "\u006E\u0303" } },
				{ 'ò', new[] { "\u00F2", "\u006F\u0300" } },
				{ 'ó', new[] { "\u00F3", "\u006F\u0301" } },
				{ 'ô', new[] { "\u00F4", "\u006F\u0302" } },
				{ 'õ', new[] { "\u00F5", "\u006F\u0303" } },
				{ 'ö', new[] { "\u00F6", "\u006F\u0308" } },
				{ 'ù', new[] { "\u00F9", "\u0075\u0300" } },
				{ 'ú', new[] { "\u00FA", "\u0075\u0301" } },
				{ 'û', new[] { "\u00FB", "\u0075\u0302" } },
				{ 'ü', new[] { "\u00FC", "\u0075\u0308" } },
				{ 'ý', new[] { "\u00FD", "\u0070\u0301" } },
				{ 'ÿ', new[] { "\u00FE", "\u0079\u0308" } },
				#endregion
			};

		/// <summary>
		/// Gets the value associated with the specified key.
		/// </summary>
		/// <param name="key">The key of the value to get.</param>
		/// <param name="value">When this method returns, contains the value associated with the specified key, if the key is found; otherwise, the default value for the type of the <paramref name="value"/> parameter. This parameter is passed uninitialized.</param>
		/// <returns><see langword="true"/> if the <see cref="VariancyTable"/> contains an element with the specified key; otherwise, <see langword="false"/>.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Boolean TryGetValue(Int32 key, out String[] value) => Variants.TryGetValue(key, out value);
	}
}
