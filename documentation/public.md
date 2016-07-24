# skadisteam.inventory Documentation

Classes:
- [SkadiInventoryClient](#SkadiInventoryClient)

## SkadiInventoryClient

*Summary*
> Class which is used for requesting inventories. Just call the methods without instancing this class.

*Example*
```csharp
// Public inventory
var inventory = SkadiInventoryClient.LoadInventory(...);
// Partner Inventory
var privateInventory = 
    SkadiInventoryClient.LoadPartnerInventory(...);
```

*Methods*
- [public static ISkadiInventory LoadInventory(ISkadiLoadInventoryConfiguration skadiLoadInventory)](#public-static-iskadiinventory-loadinventoryiskadiloadinventoryconfiguration-skadiloadinventory)
- [public static ISkadiInventory LoadPartnerInventory(ISkadiLoadPartnerInventoryConfiguration skadiLoadPartnerInventoryConfiguration)](#public-static-iskadiinventory-loadpartnerinventoryiskadiloadpartnerinventoryconfiguration-skadiloadpartnerinventoryconfiguration)


---------------------------------

### public static ISkadiInventory LoadInventory(ISkadiLoadInventoryConfiguration skadiLoadInventory)

*Summary*
> Method to request the inventory of a public accessible inventory.

*Parameters*

| Name | Type | Description |
| ---- | ---- | ----------- |
| skadiLoadInventory | ISkadiLoadInventoryConfiguration | Configuration Instance of ISkadiLoadInventoryConfiguration | 

*Returns*
> An instance of ISkadiInventory. Its a simplified formatted data structure which holds the inventory.


A sample of the the prices instance can be found [here](http://i.imgur.com/EMp0o9Z.png).

---------------------------------

### public static ISkadiInventory LoadPartnerInventory(ISkadiLoadPartnerInventoryConfiguration skadiLoadPartnerInventoryConfiguration)

*Summary*
> Method to request the inventory of a private accessible inventory.

*Parameters*
| Name | Type | Description |
| - | - | - |
| skadiLoadPartnerInventoryConfiguration | ISkadiLoadPartnerInventoryConfiguration | Configuration for loading partner inventories. For further reference lookup ISkadiLoadPartnerInventoryConfiguration. | 

*Returns*
> An instance of [ISkadiInventory](). Its a simplified formatted data structure which holds the inventory.

A sample of the the prices instance can be found [here](http://i.imgur.com/EMp0o9Z.png).

---------------------------------
