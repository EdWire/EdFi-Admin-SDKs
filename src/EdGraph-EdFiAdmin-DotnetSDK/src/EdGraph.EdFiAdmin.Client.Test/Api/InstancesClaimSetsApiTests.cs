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
    ///  Class for testing InstancesClaimSetsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class InstancesClaimSetsApiTests : IDisposable
    {
        private InstancesClaimSetsApi instance;

        public InstancesClaimSetsApiTests()
        {
            instance = new InstancesClaimSetsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of InstancesClaimSetsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' InstancesClaimSetsApi
            //Assert.IsType<InstancesClaimSetsApi>(instance);
        }

        /// <summary>
        /// Test CreateClaimSetAsync
        /// </summary>
        [Fact]
        public void CreateClaimSetAsyncTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tenantId = null;
            //string instanceId = null;
            //string? apiVersion = null;
            //string? xVersion = null;
            //EdfiAdminApiEdfiAdminV1SaveClaimSetRequest? edfiAdminApiEdfiAdminV1SaveClaimSetRequest = null;
            //var response = instance.CreateClaimSetAsync(tenantId, instanceId, apiVersion, xVersion, edfiAdminApiEdfiAdminV1SaveClaimSetRequest);
            //Assert.IsType<EdfiAdminApiEdfiAdminV1SaveClaimSetResponse>(response);
        }

        /// <summary>
        /// Test DeleteClaimSetAsync
        /// </summary>
        [Fact]
        public void DeleteClaimSetAsyncTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tenantId = null;
            //string instanceId = null;
            //int claimSetId = null;
            //string? apiVersion = null;
            //string? xVersion = null;
            //instance.DeleteClaimSetAsync(tenantId, instanceId, claimSetId, apiVersion, xVersion);
        }

        /// <summary>
        /// Test GetClaimSetByIdAsync
        /// </summary>
        [Fact]
        public void GetClaimSetByIdAsyncTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tenantId = null;
            //string instanceId = null;
            //int claimSetId = null;
            //string? apiVersion = null;
            //string? xVersion = null;
            //var response = instance.GetClaimSetByIdAsync(tenantId, instanceId, claimSetId, apiVersion, xVersion);
            //Assert.IsType<EdfiAdminApiEdfiAdminV1ClaimSet>(response);
        }

        /// <summary>
        /// Test GetClaimSetsAsync
        /// </summary>
        [Fact]
        public void GetClaimSetsAsyncTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tenantId = null;
            //string instanceId = null;
            //int? pageSize = null;
            //int? pageIndex = null;
            //string? orderBy = null;
            //string? filter = null;
            //string? apiVersion = null;
            //string? xVersion = null;
            //var response = instance.GetClaimSetsAsync(tenantId, instanceId, pageSize, pageIndex, orderBy, filter, apiVersion, xVersion);
            //Assert.IsType<EdfiAdminApiEdfiAdminV1ClaimSetPaginatedItemsViewModel>(response);
        }

        /// <summary>
        /// Test GetResourceClaimsGridAsync
        /// </summary>
        [Fact]
        public void GetResourceClaimsGridAsyncTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tenantId = null;
            //string instanceId = null;
            //int claimSetId = null;
            //string? apiVersion = null;
            //string? xVersion = null;
            //var response = instance.GetResourceClaimsGridAsync(tenantId, instanceId, claimSetId, apiVersion, xVersion);
            //Assert.IsType<EdfiAdminApiEdfiAdminV1GetResourceClaimsGridResponse>(response);
        }

        /// <summary>
        /// Test SyncClaimSetAsync
        /// </summary>
        [Fact]
        public void SyncClaimSetAsyncTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tenantId = null;
            //string instanceId = null;
            //int claimSetId = null;
            //string? apiVersion = null;
            //string? xVersion = null;
            //EdfiAdminApiEdfiAdminV1SyncClaimSetRequest? edfiAdminApiEdfiAdminV1SyncClaimSetRequest = null;
            //instance.SyncClaimSetAsync(tenantId, instanceId, claimSetId, apiVersion, xVersion, edfiAdminApiEdfiAdminV1SyncClaimSetRequest);
        }

        /// <summary>
        /// Test UpdateClaimSetAsync
        /// </summary>
        [Fact]
        public void UpdateClaimSetAsyncTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tenantId = null;
            //string instanceId = null;
            //int claimSetId = null;
            //string? apiVersion = null;
            //string? xVersion = null;
            //EdfiAdminApiEdfiAdminV1SaveClaimSetRequest? edfiAdminApiEdfiAdminV1SaveClaimSetRequest = null;
            //var response = instance.UpdateClaimSetAsync(tenantId, instanceId, claimSetId, apiVersion, xVersion, edfiAdminApiEdfiAdminV1SaveClaimSetRequest);
            //Assert.IsType<EdfiAdminApiEdfiAdminV1SaveClaimSetResponse>(response);
        }
    }
}