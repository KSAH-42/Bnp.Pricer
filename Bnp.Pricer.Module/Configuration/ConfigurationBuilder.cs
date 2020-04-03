using System;
using System.Collections.Generic;

namespace Bnp.Pricer.Configuration
{
	/// <summary>
	/// Represent a configuration setting builder
	/// </summary>
	public sealed class ConfigurationBuilder
	{
		/// <summary>
		/// The settings list
		/// </summary>
		private readonly ConfigurationSettingList       _settings      = null;

		/// <summary>
		/// The collection used to build
		/// </summary>
		private readonly IList<ConfigurationSetting>    _items         = null;

		/// <summary>
		/// Variable used to perform to remove all elements before the build operation
		/// </summary>
		private bool                                    _autoClear     = false;



		/// <summary>
		/// Constructor
		/// </summary>
		/// <exception cref="ArgumentNullException"/>
		public ConfigurationBuilder( ConfigurationSettingList settings )
		{
			if ( null == settings )
			{
				throw new ArgumentNullException( nameof( settings ) );
			}

			_settings = settings;
			_items    = new List<ConfigurationSetting>();
		}



		/// <summary>
		/// Gets / Sets the auto clear
		/// </summary>
		public bool AutoClear
		{
			get => _autoClear;
			set => _autoClear = value;
		}



		/// <summary>
		/// Add a setting
		/// </summary>
		/// <param name="name">the name of the setting</param>
		/// <param name="defaultValue">the default value</param>
		public void AddSetting( string name , bool defaultValue )
		{
			AddSetting( name , defaultValue.ToString() );
		}

		/// <summary>
		/// Add a setting
		/// </summary>
		/// <param name="name">the name of the setting</param>
		/// <param name="defaultValue">the default value</param>
		public void AddSetting( string name , char defaultValue )
		{
			AddSetting( name , defaultValue.ToString() );
		}

		/// <summary>
		/// Add a setting
		/// </summary>
		/// <param name="name">the name of the setting</param>
		/// <param name="defaultValue">the default value</param>
		public void AddSetting( string name , byte defaultValue )
		{
			AddSetting( name , defaultValue.ToString() );
		}

		/// <summary>
		/// Add a setting
		/// </summary>
		/// <param name="name">the name of the setting</param>
		/// <param name="defaultValue">the default value</param>
		public void AddSetting( string name , sbyte defaultValue )
		{
			AddSetting( name , defaultValue.ToString() );
		}

		/// <summary>
		/// Add a setting
		/// </summary>
		/// <param name="name">the name of the setting</param>
		/// <param name="defaultValue">the default value</param>
		public void AddSetting( string name , short defaultValue )
		{
			AddSetting( name , defaultValue.ToString() );
		}

		/// <summary>
		/// Add a setting
		/// </summary>
		/// <param name="name">the name of the setting</param>
		/// <param name="defaultValue">the default value</param>
		public void AddSetting( string name , ushort defaultValue )
		{
			AddSetting( name , defaultValue.ToString() );
		}

		/// <summary>
		/// Add a setting
		/// </summary>
		/// <param name="name">the name of the setting</param>
		/// <param name="defaultValue">the default value</param>
		public void AddSetting( string name , int defaultValue )
		{
			AddSetting( name , defaultValue.ToString() );
		}

		/// <summary>
		/// Add a setting
		/// </summary>
		/// <param name="name">the name of the setting</param>
		/// <param name="defaultValue">the default value</param>
		public void AddSetting( string name , uint defaultValue )
		{
			AddSetting( name , defaultValue.ToString() );
		}

		/// <summary>
		/// Add a setting
		/// </summary>
		/// <param name="name">the name of the setting</param>
		/// <param name="defaultValue">the default value</param>
		public void AddSetting( string name , long defaultValue )
		{
			AddSetting( name , defaultValue.ToString() );
		}

		/// <summary>
		/// Add a setting
		/// </summary>
		/// <param name="name">the name of the setting</param>
		/// <param name="defaultValue">the default value</param>
		public void AddSetting( string name , ulong defaultValue )
		{
			AddSetting( name , defaultValue.ToString() );
		}

		/// <summary>
		/// Add a setting
		/// </summary>
		/// <param name="name">the name of the setting</param>
		/// <param name="defaultValue">the default value</param>
		public void AddSetting( string name , float defaultValue )
		{
			AddSetting( name , defaultValue.ToString() );
		}

		/// <summary>
		/// Add a setting
		/// </summary>
		/// <param name="name">the name of the setting</param>
		/// <param name="defaultValue">the default value</param>
		public void AddSetting( string name , decimal defaultValue )
		{
			AddSetting( name , defaultValue.ToString() );
		}

		/// <summary>
		/// Add a setting
		/// </summary>
		/// <param name="name">the name of the setting</param>
		/// <param name="defaultValue">the default value</param>
		public void AddSetting( string name , double defaultValue )
		{
			AddSetting( name , defaultValue.ToString() );
		}

		/// <summary>
		/// Add a setting
		/// </summary>
		/// <param name="name">the name of the setting</param>
		/// <param name="defaultValue">the default value</param>
		public void AddSetting( string name , DateTime defaultValue )
		{
			AddSetting( name , defaultValue.ToString() );
		}

		/// <summary>
		/// Add a setting
		/// </summary>
		/// <param name="name">the name of the setting</param>
		/// <param name="defaultValue">the default value</param>
		public void AddSetting( string name , TimeSpan defaultValue )
		{
			AddSetting( name , defaultValue.ToString() );
		}

		/// <summary>
		/// Add a setting
		/// </summary>
		/// <param name="name">the name of the setting</param>
		/// <param name="defaultValue">the default value</param>
		public void AddSetting( string name , Guid defaultValue )
		{
			AddSetting( name , defaultValue.ToString() );
		}

		/// <summary>
		/// Add a setting
		/// </summary>
		/// <param name="name">the name of the setting</param>
		/// <param name="defaultValue">the default value</param>
		public void AddSetting( string name , string defaultValue )
		{
			_items.Add( new ConfigurationSetting( name , defaultValue ) );
		}
				
		/// <summary>
		/// Remove all properties previously added
		/// </summary>
		public void Cancel()
		{
			_items.Clear();
		}

		/// <summary>
		/// Build
		/// </summary>
		public void Build()
		{
			if ( _autoClear )
			{
				_settings.Clear();
			}

			_settings.AddRange( _items );
		}
	}
}
