# Bittrex.Net ![Icon](https://github.com/JKorf/Bittrex.Net/blob/master/Resources/icon.png?raw=true)

![Build status](https://travis-ci.org/JKorf/Bittrex.Net.svg?branch=master)

Bittrex.Net is a .Net wrapper for the Bittrex API as described on [Bittrex](https://bittrex.com/Home/Api). It includes all features the API provides using clear and readable C# objects including but not limited to
* Reading market info
* Placing and managing orders
* Reading balances and funds

Next to that it adds some convenience features like:
* Access to the (undocumented) SignalR websocket, allowing for realtime updates
* Automatic (re)connection handling for the websocket
* Configurable rate limiting
* Autmatic logging

**If you think something is broken, something is missing or have any questions, please open an [Issue](https://github.com/JKorf/Bittrex.Net/issues)**

## Installation
![Nuget version](https://img.shields.io/nuget/v/bittrex.net.svg) ![Nuget downloads](https://img.shields.io/nuget/dt/Bittrex.Net.svg)

Available on [NuGet](https://www.nuget.org/packages/Bittrex.Net/):
```
PM> Install-Package Bittrex.Net
```
For more details on installing refer to the [Wiki](https://github.com/JKorf/Bittrex.Net/wiki/Installation)

## Getting started
[Getting started](https://github.com/JKorf/Bittrex.Net/wiki/Getting-started)

## Release notes
* Version 1.3.14 - 21 feb 2018
	* Fix for Trade updates from websocket not containing Price/Rate

* Version 1.3.13 - 20 feb 2018 
	* Fix for ExchangeDeltas update for a market being called for all subscriptions

* Version 1.3.12 - 20 feb 2018 
	* Added V2 order endpoint to support conditional orders
	* Combined BittrexExchangeState and BittrexStreamExchangeState

* Version 1.3.11 - 15 feb 2018
	* Fix for freezes when making calls from UI thread

* Version 1.3.10 - 15 feb 2018
	* Fix for MarketName being Null in QueryExchangeState
	* Cleaned BittrexSocketClient and ExchangeState objects
	* Fix for error messages being duplicated

* Version 1.3.9 - 07 feb 2018
	* Fix for deadlock if certain methods were called from the UI thread

* Version 1.3.8 - 31 jan 2018
	* Added Notice field to BittrexCurrency response
	* Added Notice, LogoUrl and IsSponsored fields to BittrexMarketSummary response, removed DisplayMarketName which is no longer returned (was always null)
	* Changed BittrexMarketSummary fields to nullable decimals since they can be null for new markets

* Version 1.3.7 - 17 jan 2018
	* Updated CloudFlareUtilities package to fix socket connection

* Version 1.3.6 - 12 jan 2018
	* Added missing merge

* Version 1.3.5 - 12 jan 2018
	* Added orderbook websocket endpoints
	* Added basic proxy functionality
	* Small fixed in order json parsing
	* Fix for nullreference when theres no connection

* Version 1.3.4 - 04 jan 2018
	* Fix for websockets for all platforms

* Version 1.3.3 - 02 jan 2018
	* Fix for stream connections on platforms with Websocket protocol supported
	* Parallel foreach for stream event callbacks to improve performance

* Version 1.3.2 - 11 dec 2017
	* Added baseUrl parameter to constructor for mocking
	* Added IBittrexClient interface for mocking

* Version 1.3.1 - 29 nov 2017
	* Added candle endpoints
	* Made ExecuteRequest and GetUrl protected so they can be overridden
	* Fixed some small potential threading problems
	
* Version 1.3.0 - 24 nov 2017
	* Changed websocket implementation to support new Bittrex socket implementation on all platforms
	* Added SubscribeToMarketDeltaStreamAsync which returns a Task

* Version 1.2.2 - 20 nov 2017
	* Temporary fix for `BittrexSocketClient` connection after changes on the Bittrex socket API

* Version 1.2.1 - 15 nov 2017
	* CloudFlare is now used as backup, it'll first try without. This should improve connection time when CloudFlare isn't enabled

* Version 1.2.0 - 13 nov 2017
	* **NETStandard2.0 supported now**
	* Extended CloudFlare bypass for more platforms

* Version 1.1.3 - 13 nov 2017
	* Added CloudFlare bypass in socket client

* Version 1.1.2 - 10 nov 2017
	* Added ratelimiting options
	* Added connection lost/restored events in socket client
	* Added log verbosity None to be able to mute all logging
	* Added encryptor to dispose

* Version 1.1.1 - 9 nov 2017
	* Fix for error in wrong category
	* Small code documentation fixes

* Version 1.1.0 - 9 nov 2017
	* Added automatic configurable retry on server errors
	* Refactor on error returns

* Version 1.0.1 - 8 nov 2017
	* Added reconnect functionality in socket client as long as there are still subscriptions open

* Version 1.0.0 - 6 nov 2017
	* Release version 1.0.0
	* Additional unit tests, also for the socket client	
	* Small refactoring for unit testability
	* Small cleanup
	
* Version 0.0.4 - 4 nov 2017
	* Added icon

* Version 0.0.3 - 1 nov 2017
	* Small naming changes in socket client
	* Added api key checks in private endpoints
	* Updated documentation
	* Added example project

* Version 0.0.2 - 1 nov 2017
	* Added BittrexSocketClient
	* Updated documentation