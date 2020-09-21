# Black Scholes Calculator

This application represents an example of an implementation for a trading options Black Scholes calculator using C# and WPF. 
For more details, take a look too see how looks like the [formula](https://en.wikipedia.org/wiki/Black–Scholes_model#Black–Scholes_formula)



# Project structure

So here, we have the following projects :

| Project name                 | Assembly type               |
| ---------------------------- | --------------------------- |
| Bnp.Pricer                   | .exe                        |
| Bnp.Pricer.Module            | .dll                        |
| Bnp.Pricer.Module.Tests      | .dll                        |


The majority of the code are located in the following assembly :

> Bnp.Pricer.Module.dll 

# About the calculator

The calculator implementation is located under the following namespaces :

* Bnp.Pricer.Data
* Bnp.Pricer.Data.Calculators
* Bnp.Pricer.Data.Calculators.Formulas


# Additional informations

In this section, you will find the tools and the technologies used during the development for this application :

* Visual Studio Express edition (2017)
* C#
* WPF
* MSTest
* Design patterns
