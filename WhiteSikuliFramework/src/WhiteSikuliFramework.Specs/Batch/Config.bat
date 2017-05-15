@echo off

COLOR 0a

:: PROJECT FILES
SET ProjectHome=C:\Users\TechTeam\Desktop\UnifaceAutomationFramework\
SET LivingDocFolder=%ProjectHome%\UnifaceAutomationFramework.Specs\bin\Debug\LivingDoc
SET FeatureFolder=%ProjectHome%\UnifaceAutomationFramework.Specs\FeatureFiles
SET SpecsDLL=UnifaceAutomationFramework.Specs\bin\Debug\UnifaceAutomationFramework.Specs.dll
SET BDDTestProject="%ProjectHome%\UnifaceAutomationFramework.Specs\UnifaceAutomationFramework.Specs.csproj"

:: UTILITIES
SET PicklesExe=%ProjectHome%\packages\Pickles.CommandLine.2.15.0\tools\pickles.exe
SET MSTestExe="%ProgramFiles(x86)%\Microsoft Visual Studio 14.0\Common7\IDE\MSTest.exe"
SET SpecflowExecutable=%ProjectHome%\packages\SpecFlow.2.1.0\tools\specflow.exe

::C:\Users\TechTeam\Desktop\UnifaceAutomationFramework\packages\Pickles.CommandLine.2.15.0\tools\pickles.exe


:: FILE NAMES
SET StepDefHTMLOutput=StepDefinitionReport.html
SET MsTestResultFile="TestResults.trx"
SET HTMLTestOutput="TestResults.html"

