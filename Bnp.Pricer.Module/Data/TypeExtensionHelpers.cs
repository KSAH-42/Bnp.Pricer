using System;

namespace Bnp.Pricer.Data
{
	/// <summary>
	/// Represent a data type extension helpers
	/// </summary>
	public static class TypeExtensionHelpers
	{
		/// <summary>
		/// Round the value
		/// </summary>
		/// <param name="value">the value</param>
		/// <returns>Returns a value.</returns>
		public static decimal ToRound( this decimal value )
		{
			return Math.Round( value );
		}

		/// <summary>
		/// Round the value
		/// </summary>
		/// <param name="value">the value</param>
		/// <param name="numberOfDigits">the number of digits</param>
		/// <returns>Returns a value.</returns>
		/// <exception cref="ArgumentException"/>
		public static decimal ToRound( this decimal value , int numberOfDigits )
		{
			if ( 0 >= numberOfDigits )
			{
				throw new ArgumentException( nameof( numberOfDigits ) );
			}

			return Math.Round( value , numberOfDigits );
		}
	}
}
