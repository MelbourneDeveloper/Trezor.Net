# Trezor.Net

Join us on Slack:
https://hardwarewallets.slack.com

## Quick Start

- Clone the repo and open the solution
- There is a console sample, Xamarin Forms sample and unit tests for UWP, and .NET
- Compile one of the unit test apps, run the UWP/Android Xamarin Forms apps or,
- Go to Test->Windows->Text Explorer in Visual Studio
- Run one of the unit tests in the pane.
- Note that the UWP unit test has a UI for entering the pin. Please read instructions there. 

These samples only show you how to get addresses, but samples for other messages will be added soon.

Note: not all messages have a public method, but all messages exist. If you want to send a message to the Trezor you need to construct the message object and send it to the Trezor with the SendMessageAsync method. This requires that you know the result type before calling.

## NuGet

Install-Package Trezor.Net

## Suported Platforms

- .NET Framework
- .NET Core
- Android
- UWP 

## Live App

You can see the library in action in the app Hardfolio:

Windows Store
https://www.microsoft.com/en-au/p/hardfolio/9p8xx70n5d2j

Google Play
https://play.google.com/store/apps/details?id=com.Hardfolio

## Donate

Bitcoin: 33LrG1p81kdzNUHoCnsYGj6EHRprTKWu3U

Ethereum: 0x7ba0ea9975ac0efb5319886a287dcf5eecd3038e

Litecoin: MVAbLaNPq7meGXvZMU4TwypUsDEuU6stpY

## Hid.Net

Trezor.Net is based on Hid.Net. You can see the repo for this library here:

https://github.com/MelbourneDeveloper/Hid.Net

## Contribution

Contribution is welcome. Please fork, tighten up the code (real tight), test, and submit a pull request.


