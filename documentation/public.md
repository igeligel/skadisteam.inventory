# skadisteam.inventory Documentation

Classes:
- [SkadiInventoryClient](#skadiinventoryclient)
- [SkadiInventory](#skadiinventory)
- [SkadiItem](#skadiitem)
- [SkadiItemDescription](#skadiitemdescription)
- [SkadiItemDescriptionAppData](#skadiitemdescriptionappdata)
- [SkadiItemTag](#skadiitemtag)
- [SkadiLoadInventoryConfiguration](#skadiloadinventoryconfiguration)
- [SkadiLoadPartnerInventoryConfiguration](#skadiloadpartnerinventoryconfiguration)

Interfaces:
- [ISkadiInventory](#iskadiinventory)
- [ISkadiItem](#iskadiitem)
- [ISkadiItemDescription](#iskadiitemdescription)
- [ISkadiItemDescriptionAppData](#iskadiitemdescriptionappdata)
- [ISkadiItemTag](#iskadiitemtag)
- [ISkadiLoadInventoryConfiguration](#iskadiloadinventoryconfiguration)
- [ISkadiLoadPartnerInventoryConfiguration](#iskadiloadpartnerinventoryconfiguration)

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
| skadiLoadInventory | [ISkadiLoadInventoryConfiguration](#iskadiloadinventoryconfiguration) | Configuration Instance of [ISkadiLoadInventoryConfiguration](#iskadiloadinventoryconfiguration). | 

*Returns*
> An instance of [ISkadiInventory](#iskadiinventory). Its a simplified formatted data structure which holds the inventory.

A sample of the the prices instance can be found [here](http://i.imgur.com/EMp0o9Z.png).

---------------------------------

### public static ISkadiInventory LoadPartnerInventory(ISkadiLoadPartnerInventoryConfiguration skadiLoadPartnerInventoryConfiguration)

*Summary*
> Method to request the inventory of a private accessible inventory.

*Parameters*

| Name | Type | Description |
| ---- | ---- | ----------- |
| skadiLoadPartnerInventoryConfiguration | [ISkadiLoadPartnerInventoryConfiguration](#iskadiloadpartnerinventoryconfiguration) | Configuration for loading partner inventories. For further reference lookup [ISkadiLoadPartnerInventoryConfiguration](#iskadiloadpartnerinventoryconfiguration). | 

*Returns*
> An instance of [ISkadiInventory](#iskadiinventory). Its a simplified formatted data structure which holds the inventory.

A sample of the the prices instance can be found [here](http://i.imgur.com/EMp0o9Z.png).

---------------------------------

## SkadiInventory

> Implements [ISkadiInventory](#iskadiinventory)

*Summary*
> Class to define a data structure which holds all items of an inventory. This will just hold a list of [ISkadiItem](#iskadiitem). This model is simplified and not based on dictionaries which make working with inventories easier.

*Properties*

| Name | Type | Description |
| ---- | ---- | ----------- |
| Items | List\<[ISkadiItem](#iskadiitem)\> | List of [ISkadiItem](#iskadiitem). | 

---------------------------------

## SkadiItem

> Implements [ISkadiItem](#iskadiitem)

*Summary*
> Class for defining items in the inventory of a user.

*Properties*

| Name | Type | Description |
| ---- | ---- | ----------- |
| Amount | int | Amount of items. This is only used for special items like gems of the Steam Community. | 
| AssetId | long |  Asset Id of the item, which is used in several trading parts. | 
| BackgroundColor | string | Background color of the item. This property is related to the game. Some games do not have this color. | 
| ClassId |long | Id of the class. The class is describing the item. | 
| Commodity | int | Is describing the actual content of the description. | 
| Description | List\<[ISkadiItemDescription](#iskadiitemdescription)\> | Contains a list of more specific descriptions. For further information lookup [ISkadiItemDescription](#iskadiitemdescription). | 
| IconDragUrl | string | URL for the icon which is used to drag in the steamcommunity services. | 
| IconUrl | string | Icon URL which is used for icons in the steamcommunity services. | 
| InstanceId | long | Instance id of the item. This id is related to the class id. There can be several items with the same instance id but they have different classes. So the combination out of class id and instance id is unique for one inventory. | 
| MarketHashName | string | Market hash name which is used by the steam market.|
| MarketName | string | Simple Market name for the steamcommunity market which is used for representation of the item. | 
| MarketTradableRestriction | int | Value which describes if the item has a market or trading restriction. | 
| Name | string | Name of the item. | 
| Position | int | Position of the item in the inventory. | 
| Tags | List\<[ISkadiItemTag](#iskadiitemtag)\> | List of special tags for the items. For further information lookup [SkadiItemTag](#iskadiitemtag). | 
| Tradable | int | Value which describes if the item is tradable or | 
| Type | string | Value which describes the type of the item. |

---------------------------------

## SkadiItemDescription

> Implements [ISkadiItemDescription](#iskadiitemdescription)

*Summary*
> Class which gives additional information to one description.

*Properties*

| Name          | Type   | Description |
| ------------- | ------ | ----------- |
| DefIndex      | string | Definition Index of the item. |
| IsItemSetName | int    | Value which describes if an item set name is set. |
| Limited       | int    | Value which describes if an item was limited by Steam. |

---------------------------------

## SkadiItemDescriptionAppData

> Implements [ISkadiItemDescriptionAppData](#iskadiitemdescriptionappdata)

*Summary*
> Specific information of an item. The propertie's value is related to the app which is requested.

*Properties*

| Name          | Type   | Description |
| ------------- | ------ | ----------- |
| DefIndex      | string | Definition Index of the item. |
| IsItemSetName | int    | Value which describes if an item set name is set. |
| Limited       | int    | Value which describes if an item was limited by Steam. |

---------------------------------

## SkadiItemTag

> Implements [ISkadiItemTag](#iskadiitemtag)

*Summary*
> Tags for items used. There are different types which are differentiated by the category. This tag contains additional information of the item.

*Properties*

| Name         | Type   | Description |
| ------------ | ------ | ----------- |
| Category     | string | Category of the tag. |
| CategoryName | string | Name of the category. |
| Color        | string | Color of the category. |
| InternalName | string | Internal name of the tag. |
| Name         | string | Name of the tag to show. |

---------------------------------

## SkadiLoadInventoryConfiguration

> Implements [ISkadiLoadInventoryConfiguration](#iskadiloadinventoryconfiguration)

*Summary*
> Configuration Class for providing special properties to the actual procedure of requesting the inventory.

*Properties*

| Name               | Type | Description |
| ------------------ | ---- | ----------- |
| AppId              | int  | Which app id should be requested. |
| ContextId          | int  | Context id to the app id. |
| PartnerCommunityId | long | Steam community id of the inventory requested. |
| TradableItems      | bool | Value to decide if jsut tradable items should be in the output or not. |

---------------------------------

## SkadiLoadPartnerInventoryConfiguration

> Implements [ISkadiLoadPartnerInventoryConfiguration](#iskadiloadpartnerinventoryconfiguration)

*Summary*
> Configuration class for loading the partner inventory.

*Properties*

| Name               | Type   | Description |
| ------------------ | ------ | ----------- |
| AppId              | int    | App Id which should be requested. |
| ContextId          | int    | Context Id related to app id. |
| PartnerCommunityId | long   | Steam community id of the inventory requested. |
| SessionId          | string | Session id of a login session. |
| SteamLoginSecure   | string | Steam login secure value of a login session. |
| TradeToken         | string | Trade token of the profile which the inventory is requested for. |
| TradableItems      | bool   | Value which filters just for tradable items. |

---------------------------------

## ISkadiInventory

*Summary*
> Interface to define a data structure which holds all items of an inventory. This will just hold a list of ISkadiItem. This model is simplified and not based on dictionaries which make working with inventories easier.

*Properties*

| Name | Type | Description |
| ---- | ---- | ----------- |
| Items | List\<[ISkadiItem](#iskadiitem)\> | List of [ISkadiItem](#iskadiitem). | 

---------------------------------

## ISkadiItem

*Summary*
> Interface to structure items in the steam inventory.

*Properties*

| Name | Type | Description |
| ---- | ---- | ----------- |
| Amount | int | Amount of items. This is only used for special items like gems of the Steam Community. | 
| AssetId | long |  Asset Id of the item, which is used in several trading parts. | 
| BackgroundColor | string | Background color of the item. This property is related to the game. Some games do not have this color. | 
| ClassId |long | Id of the class. The class is describing the item. | 
| Commodity | int | Is describing the actual content of the description. | 
| Description | List\<[ISkadiItemDescription](#iskadiitemdescription)\> | Contains a list of more specific descriptions. For further information lookup [ISkadiItemDescription](#iskadiitemdescription). | 
| IconDragUrl | string | URL for the icon which is used to drag in the steamcommunity services. | 
| IconUrl | string | Icon URL which is used for icons in the steamcommunity services. | 
| InstanceId | long | Instance id of the item. This id is related to the class id. There can be several items with the same instance id but they have different classes. So the combination out of class id and instance id is unique for one inventory. | 
| MarketHashName | string | Market hash name which is used by the steam market.|
| MarketName | string | Simple Market name for the steamcommunity market which is used for representation of the item. | 
| MarketTradableRestriction | int | Value which describes if the item has a market or trading restriction. | 
| Name | string | Name of the item. | 
| Position | int | Position of the item in the inventory. | 
| Tags | List\<[ISkadiItemTag](#iskadiitemtag)\> | List of special tags for the items. For further information lookup [SkadiItemTag](#iskadiitemtag). | 
| Tradable | int | Value which describes if the item is tradable or | 
| Type | string | Value which describes the type of the item. |


---------------------------------

## ISkadiItemDescription

*Summary*
> Interface to define the structure of internal descriptions for the items in the inventory.

*Properties*

| Name    | Type | Description |
| ------- | ---- | ----------- |
| AppData | [ISkadiItemDescriptionAppData](#iskadiitemdescriptionappdata) | Specific information of the app. For more information lookup [SkadiItemDescriptionAppData](#iskadiitemdescriptionappdata). |
| Color   | string | Color of the description. |
| Type    | string | Type of the extra description. |
| Value   | string | Value regarding to the type of the description. |

---------------------------------

## ISkadiItemDescriptionAppData

*Summary*
> Interace which defines properties of the app data extension in descriptions.

*Properties*

| Name          | Type   | Description |
| ------------- | ------ | ----------- |
| DefIndex      | string | Definition Index of the item. |
| IsItemSetName | int    | Value which describes if an item set name is set. |
| Limited       | int    | Value which describes if an item was limited by Steam. |

---------------------------------

## ISkadiItemTag

*Summary*
> Tags for items used. There are different types which are differentiated by the category. This tag contains additional information of the item.

*Properties*

| Name         | Type   | Description |
| ------------ | ------ | ----------- |
| Category     | string | Category of the tag. |
| CategoryName | string | Name of the category. |
| Color        | string | Color of the category. |
| InternalName | string | Internal name of the tag. |
| Name         | string | Name of the tag to show. |

---------------------------------

## ISkadiLoadInventoryConfiguration

*Summary*
> Interface to declare minimum of parameters given to load public steam inventories.

*Properties*

| Name               | Type | Description |
| ------------------ | ---- | ----------- |
| AppId              | int  | Which app id should be requested. |
| ContextId          | int  | Context id to the app id. |
| PartnerCommunityId | long | Steam community id of the inventory requested. |
| TradableItems      | bool | Value to decide if jsut tradable items should be in the output or not. |

---------------------------------

## ISkadiLoadPartnerInventoryConfiguration

*Summary*
> Interface to declare minimum of parameters given to load private steam inventories.

*Properties*

| Name               | Type   | Description |
| ------------------ | ------ | ----------- |
| AppId              | int    | App Id which should be requested. |
| ContextId          | int    | Context Id related to app id. |
| PartnerCommunityId | long   | Steam community id of the inventory requested. |
| SessionId          | string | Session id of a login session. |
| SteamLoginSecure   | string | Steam login secure value of a login session. |
| TradeToken         | string | Trade token of the profile which the inventory is requested for. |
| TradableItems      | bool   | Value which filters just for tradable items. |

---------------------------------
