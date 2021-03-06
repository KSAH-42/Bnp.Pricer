﻿using System;

namespace Bnp.Pricer.Windows
{
	using Bnp.Pricer.Configuration;

	/// <summary>
	/// Represent the bridge between ui objects that needs to consume parameter and configuration settings. This is used class is for reducing coupling.
	/// </summary>
	public static class UIEnvironment
	{
		/// <summary>
		/// Gets / Sets the calculator output precision
		/// </summary>
		public static int CalculatorPrecision
		{
			get => ConfigurationManager.Settings[ ConfigurationConstants.PrecisionSetting.Name ].ReadInt();
			set => ConfigurationManager.Settings[ ConfigurationConstants.PrecisionSetting.Name ].Write( value );
		}

		/// <summary>
		/// Gets / Sets the test url
		/// </summary>
		public static string TestUrl
		{
			get => ConfigurationManager.Settings[ ConfigurationConstants.TestUrlSetting.Name ].Read();
			set => ConfigurationManager.Settings[ ConfigurationConstants.TestUrlSetting.Name ].Write( value );
		}
	}
}
