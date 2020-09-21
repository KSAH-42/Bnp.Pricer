using System;

namespace Bnp.Pricer.Windows.Commands
{
	/// <summary>
	/// Represent a simple relay command
	/// </summary>
	public sealed class RelayCommand : Command
	{
		/// <summary>
		/// The execute routine
		/// </summary>
		private readonly Action<object>      _execute     = null;

		/// <summary>
		/// The evaluation routine
		/// </summary>
		private readonly Predicate<object>	 _canExecute  = null;




		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="execute">the execution routine</param>
		/// <exception cref="ArgumentNullException"/>
		public RelayCommand( Action<object> execute )
		{
			_execute = execute ?? throw new ArgumentNullException( nameof( execute ) );
		}


		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="execute">the execution routine</param>
		/// <param name="canExecute">the evaluation routine</param>
		/// <exception cref="ArgumentNullException"/>
		public RelayCommand( Action<object> execute , Predicate<object> canExecute )
		{
			_execute    =    execute ?? throw new ArgumentNullException( nameof( execute ) );
			_canExecute	= canExecute ?? throw new ArgumentNullException( nameof( canExecute ) );
		}




		/// <summary>
		/// Check if the command can be executed
		/// </summary>
		/// <param name="parameter">the parameter</param>
		/// <returns>returns true for a success, otherwise false.</returns>
		public override bool CanExecute( object parameter )
		{
			return _canExecute == null || _canExecute.Invoke( parameter );
		}

		/// <summary>
		/// Execute the command
		/// </summary>
		/// <param name="parameter">the parameter</param>
		public override void Execute( object parameter )
		{
			try
			{
				_execute.Invoke( parameter );
			}
			catch ( Exception ex )
			{
				AlertBox.ShowError( ex );
			}
		}
	}
}
