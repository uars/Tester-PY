// <copyright file="TypeSearchEnum.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace YouTubeDataApiSearch.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using YouTubeDataApiSearch.Standard;
    using YouTubeDataApiSearch.Standard.Utilities;

    /// <summary>
    /// TypeSearchEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TypeSearchEnum
    {
        /// <summary>
        /// Search.
        /// </summary>
        [EnumMember(Value = "search")]
        Search,
    }
}