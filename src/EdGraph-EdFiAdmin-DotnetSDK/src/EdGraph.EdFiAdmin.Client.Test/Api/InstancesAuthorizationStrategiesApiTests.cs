/*
 * Ed-Fi Admin Api
 *
 * Ed-Fi Admin Api - v1.0
 *
 * The version of the OpenAPI document: v1.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using EdGraph.EdFiAdmin.Client.Client;
using EdGraph.EdFiAdmin.Client.Api;
// uncomment below to import models
//using EdGraph.EdFiAdmin.Client.Model;

namespace EdGraph.EdFiAdmin.Client.Test.Api
{
    /// <summary>
    ///  Class for testing InstancesAuthorizationStrategiesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class InstancesAuthorizationStrategiesApiTests : IDisposable
    {
        private InstancesAuthorizationStrategiesApi instance;

        public InstancesAuthorizationStrategiesApiTests()
        {
            instance = new InstancesAuthorizationStrategiesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of InstancesAuthorizationStrategiesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' InstancesAuthorizationStrategiesApi
            //Assert.IsType<InstancesAuthorizationStrategiesApi>(instance);
        }

        /// <summary>
        /// Test GetAuthorizationStrategiesAsync
        /// </summary>
        [Fact]
        public void GetAuthorizationStrategiesAsyncTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tenantId = null;
            //string instanceId = null;
            //int? pageIndex = null;
            //int? pageSize = null;
            //string? orderBy = null;
            //string? filter = null;
            //string? apiVersion = null;
            //string? xVersion = null;
            //var response = instance.GetAuthorizationStrategiesAsync(tenantId, instanceId, pageIndex, pageSize, orderBy, filter, apiVersion, xVersion);
            //Assert.IsType<EdfiAdminApiEdfiAdminV1AuthorizationStrategiesResponse>(response);
        }
    }
}