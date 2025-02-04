﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace Bittrex.Net.Objects
{
    /// <summary>
    /// Stream exchange state update
    /// </summary>
    public class BittrexStreamUpdateExchangeState
    {
        /// <summary>
        /// Nonce
        /// </summary>
        [JsonProperty("N")]
        public long Nonce { get; set; }

        /// <summary>
        /// Name of the market
        /// </summary>
        [JsonProperty("M")]
        public string MarketName { get; set; }

        /// <summary>
        /// Buys in the order book
        /// </summary>
        [JsonProperty("Z")]
        public List<BittrexStreamOrderBookUpdateEntry> Buys { get; set; }

        /// <summary>
        /// Sells in the order book
        /// </summary>
        [JsonProperty("S")]
        public List<BittrexStreamOrderBookUpdateEntry> Sells { get; set; }
        /// <summary>
        /// Market history
        /// </summary>
        [JsonProperty("f")]
        public List<BittrexStreamFill> Fills { get; set; }
    }

    /// <summary>
    /// Stream query state
    /// </summary>
    public class BittrexStreamQueryExchangeState
    {
        /// <summary>
        /// Nonce
        /// </summary>
        [JsonProperty("N")]
        public long Nonce { get; set; }

        /// <summary>
        /// Name of the market
        /// </summary>
        [JsonProperty("M")]
        public string MarketName { get; set; }

        /// <summary>
        /// Buys in the order book
        /// </summary>
        [JsonProperty("Z")]
        public List<BittrexStreamOrderBookEntry> Buys { get; set; }

        /// <summary>
        /// Sells in the order book
        /// </summary>
        [JsonProperty("S")]
        public List<BittrexStreamOrderBookEntry> Sells { get; set; }
        /// <summary>
        /// Market history
        /// </summary>
        [JsonProperty("f")]
        public List<BittrexStreamMarketHistory> Fills { get; set; }
    }
}
