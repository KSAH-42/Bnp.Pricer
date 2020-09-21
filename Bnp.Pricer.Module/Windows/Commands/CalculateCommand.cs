﻿using System;

namespace Bnp.Pricer.Windows.Commands
{
	using Bnp.Pricer.Data;
	using Bnp.Pricer.Data.Calculators;
	using Bnp.Pricer.Windows.ViewsModels;
	
	/// <summary>
	/// Represent the calculate command
	/// </summary>
	public sealed class CalculateCommand : Command
	{
		/// <summary>
		/// The model
		/// </summary>
		private readonly CalculatorViewModel      _model        = null;

		/// <summary>
		/// The calculator 
		/// </summary>
		private readonly BlackScholesCalculator   _calculator   = null;




		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="model">the model</param>
		/// <exception cref="ArgumentNullException"/>
		public CalculateCommand( CalculatorViewModel model )
		{
			_model      = model ?? throw new ArgumentNullException( nameof( model ) ); ;
			_calculator = new BlackScholesCalculator();
		}




		/// <summary>
		/// Check if the command can be executed
		/// </summary>
		/// <param name="parameter">the parameter</param>
		/// <returns>returns true for a success, otherwise false.</returns>
		public override bool CanExecute( object parameter )
		{
			return _model.IsValid();
		}

		/// <summary>
		/// Execute the command
		/// </summary>
		/// <param name="parameter">the parameter</param>
		public override void Execute( object parameter )
		{
			_model.ClearResults();

			try
			{
				var result = _calculator.Calculate( BlackScholesCalculatorPricingData.NewPricingData(
						_model.StockPrice , 
						_model.StrikePrice , 
						_model.StandardDeviation / 100M , 
						_model.RiskInterest / 100M , 
						_model.Time 
						) );
				
				_model.D1         = result.D1          .ToRound( _model.Precision );
				_model.D2         = result.D2          .ToRound( _model.Precision );
				_model.CallOption = result.CallOption  .ToRound( _model.Precision );
				_model.PutOption  = result.PutOption   .ToRound( _model.Precision );
			}
			catch ( Exception ex )
			{
				AlertBox.ShowError( ex );
			}
		}
	}
}
