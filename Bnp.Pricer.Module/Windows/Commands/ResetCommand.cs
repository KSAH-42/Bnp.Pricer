using System;

namespace Bnp.Pricer.Windows.Commands
{
	using Bnp.Pricer.Windows.ViewsModels;

	/// <summary>
	/// Represent the reset calculator command
	/// </summary>
	public sealed class ResetCommand : Command
	{
		/// <summary>
		/// The model
		/// </summary>
		private readonly CalculatorViewModel _viewModel	= null;


		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="viewModel">the view model</param>
		/// <exception cref="ArgumentNullException"/>
		public ResetCommand( CalculatorViewModel viewModel )
		{
			_viewModel = viewModel ?? throw new ArgumentNullException( nameof( viewModel ) ); ;
		}


		/// <summary>
		/// Check if the command can be executed
		/// </summary>
		/// <param name="parameter">the parameter</param>
		/// <returns>returns true for a success, otherwise false.</returns>
		public override bool CanExecute( object parameter )
		{
			return true;
		}

		/// <summary>
		/// Execute the command
		/// </summary>
		/// <param name="parameter">the parameter</param>
		public override void Execute( object parameter )
		{
			_viewModel.ClearParameters();
			_viewModel.ClearResults();
		}
	}
}
