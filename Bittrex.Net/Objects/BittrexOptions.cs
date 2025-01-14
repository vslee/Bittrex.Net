﻿using Bittrex.Net.Interfaces;
using CryptoExchange.Net.Objects;

namespace Bittrex.Net.Objects
{
    /// <summary>
    /// Options for the Bittrex client
    /// </summary>
    public class BittrexClientOptions : RestClientOptions
    {
        /// <summary>
        /// ctor
        /// </summary>
        public BittrexClientOptions()
        {
            BaseAddress = "https://api.bittrex.com";
        }

        /// <summary>
        /// The V2 API base address
        /// </summary>
        public string BaseAddressV2 { get; set; } = "https://international.bittrex.com";

        /// <summary>
        /// Copy the options
        /// </summary>
        /// <returns></returns>
        public BittrexClientOptions Copy()
        {
            var copy = Copy<BittrexClientOptions>();
            copy.BaseAddressV2 = BaseAddressV2;
            return copy;
        }
    }

    /// <summary>
    /// Options for the Bittrex socket client
    /// </summary>
    public class BittrexSocketClientOptions : SocketClientOptions
    {
        /// <summary>
        /// ctor
        /// </summary>
        public BittrexSocketClientOptions()
        {
            BaseAddress = "https://socket.bittrex.com";
            SocketSubscriptionsCombineTarget = 10;
        }
    }

    /// <summary>
    /// Options for the Bittrex symbol order book
    /// </summary>
    public class BittrexOrderBookOptions : OrderBookOptions
    {
        /// <summary>
        /// The client to use for the socket connection. When using the same client for multiple order books the connection can be shared.
        /// </summary>
        public IBittrexSocketClient SocketClient { get; }

        /// <summary>
        /// </summary>
        /// <param name="socketClient">The client to use for the socket connection. When using the same client for multiple order books the connection can be shared.</param>
        public BittrexOrderBookOptions(IBittrexSocketClient socketClient = null) : base("Bittrex", true)
        {
            SocketClient = socketClient;
        }
    }
}
