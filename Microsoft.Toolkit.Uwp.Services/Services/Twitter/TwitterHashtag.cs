﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Newtonsoft.Json;

namespace Microsoft.Toolkit.Uwp.Services.Twitter
{
    /// <summary>
    /// Twitter Hashtag object containing all hashtags in a tweet.
    /// </summary>
    public class TwitterHashtag
    {
        /// <summary>
        /// Gets or sets indices of hashtag location in tweet string.
        /// </summary>
        [JsonProperty("indices")]
        public int[] Indices { get; set; }

        /// <summary>
        /// Gets or sets hashtag text, excluding #.
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }
    }
}