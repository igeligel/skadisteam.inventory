# skadisteam.inventory Documentation

Classes:
- [SkadiInventoryClient](#SkadiInventoryClient)

Interfaces:
- ISkadiInventory
- b

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

## ISkadiInventory

*Summary*
> Interface to define a data structure which holds all items of an inventory. This will just hold a list of ISkadiItem. This model is simplified and not based on dictionaries which make working with inventories easier.

*Properties*
| Name | Type | Description |
| - | - | - |
| Items | List<ISkadiItem> | List of ISkadiItem. | 

---------------------------------

## ISkadiItem

*Summary*
> Interface to structure items in the steam inventory.

*Properties*

| Name | Type | Description |
| - | - | - |
| Amount | int | Amount of items. This is only used for special items like gems of the Steam Community. | 
| AssetId | long |  Asset Id of the item, which is used in several trading parts. | 
| BackgroundColor | string | Background color of the item. This property is related to the game. Some games do not have this color. | 
| ClassId |long | Id of the class. The class is describing the item. | 
| Commodity | int | Is describing the actual content of the description. | 
| Description | List<ISkadiItemDescription> | Contains a list of more specific descriptions. For further information lookup ISkadiItemDescription. | 
| IconDragUrl | string | URL for the icon which is used to drag in the steamcommunity services. | 
| IconUrl | string | Icon URL which is used for icons in the steamcommunity services. | 
| InstanceId | long | Instance id of the item. This id is related to the class id. There can be several items with the same instance id but they have different classes. So the combination out of class id and instance id is unique for one inventory. | 
| MarketHashName | string | Market hash name which is used by the steam market.|
| MarketName | string | Simple Market name for the steamcommunity market which is used for representation of the item. | 
| MarketTradableRestriction | int | Value which describes if the item has a market or trading restriction. | 
| Name | string | Name of the item. | 
| Position | int | Position of the item in the inventory. | 
| Tags | List<ISkadiItemTag> | List of special tags for the items. For further information lookup SkadiItemTag. | 
| Tradable | int | Value which describes if the item is tradable or | 
| Type | string | Value which describes the type of the item. | 


---------------------------------

## ISkadiItemDescription

---------------------------------

## ISkadiItemDescriptionAppData

---------------------------------

## ISkadiLoadInventoryConfiguration

---------------------------------

## ISkadiLoadPartnerInventoryConfiguration

---------------------------------
