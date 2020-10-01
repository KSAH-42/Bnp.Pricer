using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bnp.Pricer.Tests
{
	using Bnp.Pricer.Data;
	using Bnp.Pricer.Data.Calculators;

	[TestClass]
	public class BlackScholesCalculatorTest5
	{
		private BlackScholesCalculator                _calculator   = null;
		private BlackScholesCalculatorPricingResults  _result       = null;

		[TestInitialize]
		public void Initialize()
		{
			_calculator = new BlackScholesCalculator();

			_result     = _calculator.Calculate( BlackScholesCalculatorPricingData.NewPricingData( 56 , 32 , 0.74M , 0.02M , 99M ) );
		}

		[TestMethod]
		public void Should_D1_Exepcted_Equal()
		{
			Assert.AreEqual( 1.6588M , _result.D1.ToRound( 4 ) );
		}

		[TestMethod]
		public void Should_D2_Exepcted_Equal()
		{
			Assert.AreEqual( 1.2734M , _result.D2.ToRound( 4 ) );
		}

		[TestMethod]
		public void Should_CallOption_Exepcted_Equal()
		{
			Assert.AreEqual( 24.6812M , _result.CallOption.ToRound( 4 ) );
		}

		[TestMethod]
		public void Should_PutOption_Exepcted_Equal()
		{
			Assert.AreEqual( 0.508M , _result.PutOption.ToRound( 4 ) );
		}
	}
}
