# skadisteam.inventory

[![NuGet](https://img.shields.io/nuget/v/skadiprices.csgofast.svg)](https://www.nuget.org/packages/skadiprices.csgofast/0.1.0)
[![Discord](https://img.shields.io/badge/discord-join%20chat-blue.svg)](https://discord.gg/0i5X3oDHJbDUsiGC)

If you join the discord, message igeligel.

|               | Build Status  | 
| ------------- |:-------------:| 
| Linux/Mac     | WIP           | 
| Windows       | [![Build status](https://ci.appveyor.com/api/projects/status/37o4mjjhds93tgha?svg=true)](https://ci.appveyor.com/project/igeligel/skadiprices-csgofast) |

## Project
.net core library to get inventories in the [Steam Community](http://steamcommunity.com/).
It will enable you to:
- Get public inventories in a nice and easy to understand datastructure (No Dictionaries)
- Get private inventories by login data and trade tokens

## Dependencies

| Package             | Version     | 
| ------------------- |-------------| 
| NETStandard.Library | 1.6.0       |
| Newtonsoft.Json     | 9.0.1       |

## Installation

### As Nuget Package (Recommended)

> WIP

### Referenced as built package
1. You need to install .net core. For instructions head over [here](https://www.microsoft.com/net/core).
2. Open your command line.
3. Change directory to the package's source.
4. 
   ```
   $ dotnet restore
   ```
5. 
   ```
   $ dotnet build
   ```
6. Reference your build like this:

   ```
   "skadisteam.inventory": "0.1.0-*"
   ```

   in your project.json file. For an example watch the [testing package](https://github.com/igeligel/skadisteam.inventory/tree/master/src/skadisteam.inventory.test).

## How to use

All the core functionalities are built around the [SkadiInventoryClient](https://github.com/igeligel/skadisteam.inventory/blob/master/src/skadisteam.inventory/SkadiInventoryClient.cs). For documentation check out the [documentation](https://github.com/igeligel/skadisteam.inventory/blob/master/documentation/public.md#skadiinventoryclient).

To use the public available inventory you need to do these steps:

1. Create the configuration instace

    ```csharp
    var skadiLoadInventoryConfiguration =
        new SkadiLoadInventoryConfiguration
        {
            AppId = 730,
            ContextId = 2,
            PartnerCommunityId = 76561198028630048,
            TradableItems = true
        };
    ```
    This will create the configuration for requesting inventories. It will request the appid, contextid, partner community id and a boolean if the items should be tradable.

2. Now we need to transfer the instance as parameter to a function given by the SkadiInventoryClient.
    ```csharp
    var inventory = SkadiInventoryClient.LoadInventory(skadiLoadInventoryConfiguration);
    ```
    The inventory instance will hold now an inventory modelled by the [SkadiInventory](https://github.com/igeligel/skadisteam.inventory/blob/master/documentation/public.md#skadiinventory) class.

We can also request private profiles if we have the trade token and successful login information:

1. Create an instance of [SkadiLoadPartnerInventoryConfiguration](https://github.com/igeligel/skadisteam.inventory/blob/master/documentation/public.md#skadiloadpartnerinventoryconfiguration)

    ```csharp
    var skadiLoadPartnerInventoryConfiguration =
        new SkadiLoadPartnerInventoryConfiguration
            {
                AppId = 730,
                ContextId = 2,
                PartnerCommunityId = 76561198028630048,
                SessionId = "XXX,
                SteamLoginSecure =
                    "76561198028630048XXXXXX",
                TradeToken = "XXXXXXXX",
                TradableItems = false
            };
    ```
    This configuration got similar properties compared to the inventory configuration of the public inventory.

2. This instance needs to be transferred as parameter to a function of the SkadiInventoryClient.
    ```csharp
    var inventory = SkadiInventoryClient
        .LoadPartnerInventory(skadiLoadPartnerInventoryConfiguration);
    ```
    The inventory instance will hold now an inventory modelled by the [SkadiInventory](https://github.com/igeligel/skadisteam.inventory/blob/master/documentation/public.md#skadiinventory) class.

## Documentation
The documentation is referenced here:

[Click me](https://github.com/igeligel/skadisteam.inventory/blob/master/documentation/public.md) to get to the documentation

## Contribute
Watch the [master repository](https://github.com/igeligel/skadisteam) for more information.

## Authors
- [igeligel](https://github.com/igeligel)

## Contact
[![Steam](https://raw.githubusercontent.com/encharm/Font-Awesome-SVG-PNG/master/black/png/16/steam-square.png "Steam Account") Steam](http://steamcommunity.com/profiles/76561198028630048/)

[![Twitter](https://raw.githubusercontent.com/encharm/Font-Awesome-SVG-PNG/master/black/png/16/twitter.png "Twitter") Twitter](https://twitter.com/kevinpeters_)

[![Discord](http://i.imgur.com/wlwOQpl.png "Discord") Discord (I am igeligel there. Just send me a direct message)](https://discord.gg/0i5X3oDHJbDUsiGC)

## License
[MIT](https://github.com/igeligel/skadisteam.inventory/blob/master/LICENSE)