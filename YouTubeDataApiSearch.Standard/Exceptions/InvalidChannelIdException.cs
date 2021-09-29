// <copyright file="InvalidChannelIdException.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace YouTubeDataApiSearch.Standard.Exceptions
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using JsonSubTypes;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using YouTubeDataApiSearch.Standard;
    using YouTubeDataApiSearch.Standard.Http.Client;
    using YouTubeDataApiSearch.Standard.Models;
    using YouTubeDataApiSearch.Standard.Utilities;

    /// <summary>
    /// InvalidChannelIdException.
    /// </summary>
    public class InvalidChannelIdException : ApiException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidChannelIdException"/> class.
        /// </summary>
        /// <param name="reason"> The reason for throwing exception.</param>
        /// <param name="context"> The HTTP context that encapsulates request and response objects.</param>
        public InvalidChannelIdException(string reason, HttpContext context)
            : base(reason, context)
        {
        }
    }
}