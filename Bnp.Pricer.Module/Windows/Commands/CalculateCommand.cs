using System;

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
		private readonly CalculatorViewModel      _viewModel    = null;

		/// <summary>
		/// The calculator 
		/// </summary>
		private readonly BlackScholesCalculator   _calculator   = null;




		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="viewModel">the view model</param>
		/// <exception cref="ArgumentNullException"/>
		public CalculateCommand( CalculatorViewModel viewModel )
		{
			_viewModel  = viewModel ?? throw new ArgumentNullException( nameof( viewModel ) ); ;
			_calculator = new BlackScholesCalculator();
		}




		/// <summary>
		/// Check if the command can be executed
		/// </summary>
		/// <param name="parameter">the parameter</param>
		/// <returns>returns true for a success, otherwise false.</returns>
		public override bool CanExecute( object parameter )
		{
			return _viewModel.IsValid();
		}

		/// <summary>
		/// Execute the command
		/// </summary>
		/// <param name="parameter">the parameter</param>
		public override void Execute( object parameter )
		{
			_viewModel.ClearResults();

			try
			{
				var result = _calculator.Calculate( BlackScholesCalculatorPricingData.NewPricingData(
						_viewModel.StockPrice , 
						_viewModel.StrikePrice , 
						_viewModel.StandardDeviation / 100M , 
						_viewModel.RiskInterest / 100M , 
						_viewModel.Time 
						) );
				
				_viewModel.D1         = result.D1          .ToRound( _viewModel.Precision );
				_viewModel.D2         = result.D2          .ToRound( _viewModel.Precision );
				_viewModel.CallOption = result.CallOption  .ToRound( _viewModel.Precision );
				_viewModel.PutOption  = result.PutOption   .ToRound( _viewModel.Precision );
			}
			catch ( Exception ex )
			{
				AlertBox.ShowError( ex );
			}
		}
	}
}
