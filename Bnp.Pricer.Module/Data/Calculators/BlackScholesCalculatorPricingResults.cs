﻿using System;

namespace Bnp.Pricer.Data.Calculators
{
	/// <summary>
	/// Represent the data output generated by a black scholes calculator
	/// </summary>
	public sealed class BlackScholesCalculatorPricingResults
	{
		/// <summary>
		/// D1 backing field
		/// </summary>
		private readonly decimal          _d1          = 0;

		/// <summary>
		/// D2 backing field
		/// </summary>
		private readonly decimal          _d2          = 0;

		/// <summary>
		/// Call option backing field
		/// </summary>
		private readonly decimal          _callOption  = 0;

		/// <summary>
		/// Put option backing field
		/// </summary>
		private readonly decimal          _putOption   = 0;

		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="d1">the d1 parameter</param>
		/// <param name="d2">the d2 parameter</param>
		/// <param name="callOption">the call option</param>
		/// <param name="putOption">the put option</param>
		public BlackScholesCalculatorPricingResults( decimal d1 , decimal d2 , decimal callOption , decimal putOption )
		{
			_d1         = d1;
			_d2         = d2;
			_callOption = callOption;
			_putOption  = putOption;
		}


		/// <summary>
		/// Gets the d1 parameter
		/// </summary>
		public decimal D1
		{ 
			get => _d1;
		}
		
		/// <summary>
		/// Gets the d2 parameter
		/// </summary>
		public decimal D2
		{ 
			get => _d2;
		}

		/// <summary>
		/// Gets the call option
		/// </summary>
		public decimal CallOption
		{ 
			get => _callOption;
		}

		/// <summary>
		/// Gets / Sets the put option
		/// </summary>
		public decimal PutOption
		{ 
			get => _putOption;
		}
	}
}
