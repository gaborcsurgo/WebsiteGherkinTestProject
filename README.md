## WebsiteGherkinTestProject
2018-05-15

### Used softwares

  - Visual Studio 2017 Community
  - Google Chrome (latest)
  - Firefox ESR
  - Selenium IDE 2.9.1	

## GherkinTCs project

This is an automated test project for website testing.
In the DoclerWebsiteTestScenariosSteps.cs please change the path of the browser driver for the required operation.

This project is a standard console application with a SpecFlow feature file. In this project
we are using the gherkin language. The aim of this project is to write test cases to reach 
100% requirement coverage. The .feature file contains the 5 scenarios which cover the 12 test
requirements. The Steps.cs contains the step definitions using NUnit and Selenium commands.
For more information please check the .feature description. In Visual Studio use Test Explorer 
to run the tests.

### Contains

  - DoclerWebsiteTestScenarios.feature (+ DoclerWebsiteTestScenarios.cs)
  - DoclerWebsiteTestScenariosSteps.cs

### Packages

  - SpecFlow.2.3.2
  - SpecFLow.NUnit.2.3.2
  - NUnit.3.0.0
  - Selenium.Chrome.WebDriver.2.38
  - Selenium.Support.3.12.0
  - Selenium.WeDriver.3.12.0
  - Newtonsoft.Json.9.0.1
  - System.ValueTuple.4.3.0
