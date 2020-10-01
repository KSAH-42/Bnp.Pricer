using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bnp.Pricer.Tests
{
	using Bnp.Pricer.Data;
	using Bnp.Pricer.Data.Calculators;

	[TestClass]
	public class BlackScholesCalculatorTest2
	{
		private BlackScholesCalculator                _calculator   = null;
		private BlackScholesCalculatorPricingResults  _result       = null;

		[TestInitialize]
		public void Initialize()
		{
			_calculator = new BlackScholesCalculator();

			_result     = _calculator.Calculate( BlackScholesCalculatorPricingData.NewPricingData( 64 , 60 , 0.27M , 0.045M , 180M ) );
		}

		[TestMethod]
		public void Should_D1_Exepcted_Equal()
		{
			Assert.AreEqual( 0.5522M , _result.D1.ToRound( 4 ) );
		}

		[TestMethod]
		public void Should_D2_Exepcted_Equal()
		{
			Assert.AreEqual( 0.3626M , _result.D2.ToRound( 4 ) );
		}

		[TestMethod]
		public void Should_CallOption_Exepcted_Equal()
		{
			Assert.AreEqual( 7.7661M , _result.CallOption.ToRound( 4 ) );
		}

		[TestMethod]
		public void Should_PutOption_Exepcted_Equal()
		{
			Assert.AreEqual( 2.4493M , _result.PutOption.ToRound( 4 ) );
		}
	}
}
