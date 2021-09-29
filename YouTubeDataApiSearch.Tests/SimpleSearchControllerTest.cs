// <copyright file="SimpleSearchControllerTest.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace YouTubeDataApiSearch.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Threading.Tasks;
    using Newtonsoft.Json.Converters;
    using NUnit.Framework;
    using YouTubeDataApiSearch.Standard;
    using YouTubeDataApiSearch.Standard.Controllers;
    using YouTubeDataApiSearch.Standard.Exceptions;
    using YouTubeDataApiSearch.Standard.Http.Client;
    using YouTubeDataApiSearch.Standard.Http.Response;
    using YouTubeDataApiSearch.Standard.Utilities;
    using YouTubeDataApiSearch.Tests.Helpers;

    /// <summary>
    /// SimpleSearchControllerTest.
    /// </summary>
    [TestFixture]
    public class SimpleSearchControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private SimpleSearchController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.SimpleSearchController;
        }

        /// <summary>
        /// Search according to given.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestSearch()
        {
            // Parameters for the API call
            Standard.Models.TypeSearchEnum type = (Standard.Models.TypeSearchEnum)Enum.Parse(typeof(Standard.Models.TypeSearchEnum), "search");
            string part = "snippet";
            int maxResults = 25;
            string key = "AIzaSyAzYmRVV7HvVqh6OcNgbB4AC8NcjyXJBR4";
            string q = "surfing";

            // Perform API call
            dynamic result = null;
            try
            {
                result = await this.controller.DoSearchAsync(type, part, maxResults, key, q);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.IsTrue(
                    TestHelper.IsJsonObjectProperSubsetOf(
                    "{\n   \"regionCode\": \"US\"\n}",
                    TestHelper.ConvertStreamToString(this.HttpCallBackHandler.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }
    }
}