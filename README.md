# Trezor.Net

## [Follow Me on Twitter](https://twitter.com/intent/follow?screen_name=cfdevelop&tw_p=followbutton) ##

Cross Platform C# Library for the [Trezor Cryptocurrency Hardwarewallet](https://trezor.io/)

This library allows you to communicate with both Trezor hardwarewallets in the same way that the Trezor browser wallet app communicates with them. It can be used to build apps that send or receive crypto currencies like Bitcoin in a secure way.

Currently supports: .NET Framework, .NET Core, Android, UWP , See [MacOS and Linux Support](https://github.com/MelbourneDeveloper/Device.Net/wiki/Linux-and-MacOS-Support)

[Would you like to contribute?](https://christianfindlay.com/2019/04/28/calling-all-c-crypto-developers/)

## Quick Start

- Clone the repo and open the solution
- There is a console sample, Xamarin Forms sample and unit tests for UWP, and .NET
- Compile one of the unit test apps, run the UWP/Android Xamarin Forms apps or,
- Go to Test->Windows->Text Explorer in Visual Studio
- Run one of the unit tests in the pane.
- Note that the UWP unit test has a UI for entering the pin. Please read instructions there. 

All Trezor messages are in the Trezor.Net.Contracts namespace. To implement them, you need to call SendMessageAsync

NuGet: Install-Package Trezor.Net

[Example](https://github.com/MelbourneDeveloper/Trezor.Net/blob/656c12ba3b0126a8aa5c3f7b576fd535e5286fb7/src/Trezor.Net.UWPUnitTest/UnitTestBase.cs#L46):
````cs
public async Task<string> GetAddressAsync()
{
    //Register the factory for creating Usb devices. Trezor One Firmware 1.7.x, 1.8.x / Trezor Model T 2.1.x
    WindowsUsbDeviceFactory.Register();
    //Register the factory for creating Hid devices. Trezor One Firmware 1.6.x
    WindowsHidDeviceFactory.Register();

    var trezorManagerBroker = new TrezorManagerBroker(GetPin, 2000, new DefaultCoinUtility());

    var trezorManager =  await trezorManagerBroker.WaitForFirstTrezorAsync();

    var bip44AddressPath = AddressPathBase.Parse<BIP44AddressPath>("m/49'/0'/0'/0/0");

    return await trezorManager.GetAddressAsync(bip44AddressPath, false, true);
}
````
## Contact

- Join us on [Discord](https://discord.gg/ZcvXARm)
- PM me on [Twitter](https://twitter.com/cfdevelop)
- Blog: https://christianfindlay.com/

## [Contribution](https://github.com/MelbourneDeveloper/Trezor.Net/blob/master/CONTRIBUTING.md)

The community needs your help! Unit tests, integration tests, more app integrations and bug fixes please! Check out the Issues section.

## Donate

All my libraries are open source and free. Your donations will contribute to making sure that these libraries keep up with the latest firmware, functions are implemented, and the quality is maintained.

| Coin           | Address |
| -------------  |:-------------:|
| Bitcoin        | [33LrG1p81kdzNUHoCnsYGj6EHRprTKWu3U](https://www.blockchain.com/btc/address/33LrG1p81kdzNUHoCnsYGj6EHRprTKWu3U) |
| Ethereum       | [0x7ba0ea9975ac0efb5319886a287dcf5eecd3038e](https://etherdonation.com/d?to=0x7ba0ea9975ac0efb5319886a287dcf5eecd3038e) |

## Based On

| Library           | Description |
| -------------  |:-------------:|
| [Hardwarewallets.Net](https://github.com/MelbourneDeveloper/Hardwarewallets.Net) | This library is part of the Hardwarewallets.Net suite. It is aimed toward putting a set of common C# interfaces, and utilities that will work with all hardwarewallets. |
| [Hid.Net, Usb.Net](https://github.com/MelbourneDeveloper/Device.Net)             | Trezor.Net communicates with the devices via the Hid.Net and Usb.Net libraries. You can see the repo for this library here. |

## See Also

| Library           | Description |
| -------------  |:-------------:|
| [KeepKey.Net](https://github.com/MelbourneDeveloper/KeepKey.Net)                 | KeepKey Hardwarewallet Library |
| [Ledger.Net](https://github.com/MelbourneDeveloper/Ledger.Net)                   | Ledger Hardwarewallet Library |
| [Ledger .NET API](https://github.com/LedgerHQ/ledger-dotnet-api)                 | A similar Ledger library |
| [Ledger Bitcoin App](https://github.com/LedgerHQ/blue-app-btc)                   | Bitcoin wallet application for Ledger Blue and Nano S |
| [Ledger Ethereum App](https://github.com/LedgerHQ/blue-app-eth)                  | Ethereum wallet application for Ledger Blue and Nano S |

## Hardfolio - Store App Production Usage

https://play.google.com/store/apps/details?id=com.Hardfolio (Android)

https://www.microsoft.com/en-au/p/hardfolio/9p8xx70n5d2j (UWP)
