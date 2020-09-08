# Black Scholes Calculator

The purpose of this project is to explore a different ways to build WPF applications. This project doesn't really used MVVM, but it is very similar. During my professional experience, I was faced to some scalabilty issues. Not issues related to the performance, but when the amount of code grows, and we need to add more and more business logics.

I have see some ViewModel classes that contains so many private methods, and become to look like as God objects. And sometimes it becomes hard to modify or fix a bug inside a large ViewModel class.

If you are famillar to use the traditional ViewModel implementation with Relay/DelegateCommand and so on, I recommand to stay on the official implementation of the ViewModel. There is one drawback with my approach, that's why I recommand to stay on the official ViewModel implementation. 

In this project, you will not see any classes called ViewModel, but instead you will find a class called Controller, perphaps the name of this class can be changed. 




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
