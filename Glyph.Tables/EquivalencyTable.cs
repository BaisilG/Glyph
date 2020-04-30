using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Stringier {
	/// <summary>
	/// Represents an equivalency table used for glyphwise equality and comparisons.
	/// </summary>
	public static class EquivalencyTable {
		/// <summary>
		/// The set of equivalencies in this table.
		/// </summary>
		private static readonly Dictionary<String, Char> Equivalences = new Dictionary<String, Char>(StringComparer.Ordinal) {
				#region Latin-1 Supplement
				{ "\u0041\u0300", 'À' },
				{ "\u0041\u0301", 'Á' },
				{ "\u0041\u0302", 'Â' },
				{ "\u0041\u0303", 'Ã' },
				{ "\u0041\u0308", 'Ä' },
				{ "\u0041\u030A", 'Å' },
				{ "\u0043\u0327", 'Ç' },
				{ "\u0045\u0300", 'È' },
				{ "\u0045\u0301", 'É' },
				{ "\u0045\u0302", 'Ê' },
				{ "\u0045\u0308", 'Ë' },
				{ "\u0049\u0300", 'Ì' },
				{ "\u0049\u0301", 'Í' },
				{ "\u0049\u0302", 'Î' },
				{ "\u0049\u0308", 'Ï' },
				{ "\u004E\u0303", 'Ñ' },
				{ "\u004F\u0300", 'Ò' },
				{ "\u004F\u0301", 'Ó' },
				{ "\u004F\u0302", 'Ô' },
				{ "\u004F\u0303", 'Õ' },
				{ "\u004F\u0308", 'Ö' },
				{ "\u0055\u0300", 'Ù' },
				{ "\u0055\u0301", 'Ú' },
				{ "\u0055\u0302", 'Û' },
				{ "\u0055\u0308", 'Ü' },
				{ "\u0059\u0301", 'Ý' },
				{ "\u0061\u0300", 'à' },
				{ "\u0061\u0301", 'á' },
				{ "\u0061\u0302", 'â' },
				{ "\u0061\u0303", 'ã' },
				{ "\u0061\u0308", 'ä' },
				{ "\u0061\u030A", 'å' },
				{ "\u0063\u0327", 'ç' },
				{ "\u0065\u0300", 'è' },
				{ "\u0065\u0301", 'é' },
				{ "\u0065\u0302", 'ê' },
				{ "\u0065\u0308", 'ë' },
				{ "\u0069\u0300", 'ì' },
				{ "\u0069\u0301", 'í' },
				{ "\u0069\u0302", 'î' },
				{ "\u0069\u0308", 'ï' },
				{ "\u006E\u0303", 'ñ' },
				{ "\u006F\u0300", 'ò' },
				{ "\u006F\u0301", 'ó' },
				{ "\u006F\u0302", 'ô' },
				{ "\u006F\u0303", 'õ' },
				{ "\u006F\u0308", 'ö' },
				{ "\u0075\u0300", 'ù' },
				{ "\u0075\u0301", 'ú' },
				{ "\u0075\u0302", 'û' },
				{ "\u0075\u0308", 'ü' },
				{ "\u0079\u0301", 'ý' },
				{ "\u0079\u0308", 'ÿ' },
				#endregion
				#region Latin Extended-A
				{ "\u0041\u0304", 'Ā' },
				{ "\u0061\u0304", 'ā' },
				{ "\u0041\u0306", 'Ă' },
				{ "\u0061\u0306", 'ă' },
				{ "\u0041\u0328", 'Ą' },
				{ "\u0061\u0328", 'ą' },
				{ "\u0043\u0301", 'Ć' },
				{ "\u0063\u0301", 'ć' },
				{ "\u0043\u0302", 'Ĉ' },
				{ "\u0063\u0302", 'ĉ' },
				{ "\u0043\u0307", 'Ċ' },
				{ "\u0063\u0307", 'ċ' },
				{ "\u0043\u030C", 'Č' },
				{ "\u0063\u030C", 'č' },
				{ "\u0044\u030C", 'Ď' },
				{ "\u0064\u030C", 'ď' },
				{ "\u0045\u0304", 'Ē' },
				{ "\u0065\u0304", 'ē' },
				{ "\u0045\u0306", 'Ĕ' },
				{ "\u0065\u0306", 'ĕ' },
				{ "\u0045\u0307", 'Ė' },
				{ "\u0065\u0307", 'ė' },
				{ "\u0045\u0328", 'Ę' },
				{ "\u0065\u0328", 'ę' },
				{ "\u0045\u030C", 'Ě' },
				{ "\u0065\u030C", 'ě' },
				{ "\u0047\u0302", 'Ĝ' },
				{ "\u0067\u0302", 'ĝ' },
				{ "\u0047\u0306", 'Ğ' },
				{ "\u0067\u0306", 'ğ' },
				{ "\u0047\u0307", 'Ġ' },
				{ "\u0067\u0307", 'ġ' },
				{ "\u0047\u0327", 'Ģ' },
				{ "\u0067\u0327", 'ģ' },
				{ "\u0048\u0302", 'Ĥ' },
				{ "\u0068\u0302", 'ĥ' },
				{ "\u0049\u0303", 'Ĩ' },
				{ "\u0069\u0303", 'ĩ' },
				{ "\u0131\u0303", 'ĩ' },
				{ "\u0049\u0304", 'Ī' },
				{ "\u0069\u0304", 'ī' },
				{ "\u0131\u0304", 'ī' },
				{ "\u0049\u0306", 'Ĭ' },
				{ "\u0069\u0306", 'ĭ' },
				{ "\u0131\u0306", 'ĭ' },
				{ "\u0049\u0328", 'Į' },
				{ "\u0069\u0328", 'į' },
				{ "\u0049\u0307", 'İ' },
				{ "\u0131\u0307", 'i' },
				{ "\u004A\u0302", 'Ĵ' },
				{ "\u006A\u0307", 'ĵ' },
				{ "\u004B\u0327", 'Ķ' },
				{ "\u006B\u0327", 'ķ' },
				{ "\u004C\u0304", 'Ĺ' },
				{ "\u006C\u0304", 'ĺ' },
				{ "\u004C\u0327", 'Ļ' },
				{ "\u006C\u0327", 'ļ' },
				{ "\u004C\u030C", 'Ľ' },
				{ "\u006C\u030C", 'ľ' },
				#endregion
			};

		/// <summary>
		/// Gets the value associated with the specified key.
		/// </summary>
		/// <param name="key">The key of the value to get.</param>
		/// <param name="value">When this method returns, contains the value associated with the specified key, if the key is found; otherwise, the default value for the type of the <paramref name="value"/> parameter. This parameter is passed uninitialized.</param>
		/// <returns><see langword="true"/> if the <see cref="EquivalencyTable"/> contains an element with the specified key; otherwise, <see langword="false"/>.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static Boolean TryGetValue(String key, out Int32 value) {
			if (Equivalences.TryGetValue(key, out Char val)) {
				value = val;
				return true;
			} else {
				value = -1;
				return false;
			}
		}
	}
}
