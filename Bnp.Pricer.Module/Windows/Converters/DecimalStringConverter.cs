using System;
using System.Globalization;
using System.Windows.Data;

namespace Bnp.Pricer.Windows.Converters
{
	/// <summary>
	/// Represent a convert
	/// </summary>
	public class DecimalStringConverter : IValueConverter
	{
		/// <summary>
		/// Convert
		/// </summary>
		/// <param name="value">value</param>
		/// <param name="targetType">target type</param>
		/// <param name="parameter">parameter</param>
		/// <param name="culture">culture</param>
		/// <returns>returns a converted value</returns>
		public object Convert( object value , Type targetType , object parameter , CultureInfo culture )
		{
			if ( null == value )
			{
				return string.Empty;
			}

			if ( value is decimal )
			{
				return value.ToString();
			}

			return string.Empty;
		}

		/// <summary>
		/// Reverse convert
		/// </summary>
		/// <param name="value">value</param>
		/// <param name="targetType">target type</param>
		/// <param name="parameter">parameter</param>
		/// <param name="culture">culture</param>
		/// <returns>returns a converted value</returns>
		public object ConvertBack( object value , Type targetType , object parameter , CultureInfo culture )
		{
			if ( string.IsNullOrWhiteSpace( value as string ) )
			{
				return 0;
			}

			decimal result = 0;

			if ( ! decimal.TryParse( value.ToString() , out result ) )
			{
				return 0;
			}

			return result;
		}
	}
}
