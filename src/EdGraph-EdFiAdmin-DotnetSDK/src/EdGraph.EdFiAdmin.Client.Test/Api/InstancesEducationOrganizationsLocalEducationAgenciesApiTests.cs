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
    ///  Class for testing InstancesEducationOrganizationsLocalEducationAgenciesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class InstancesEducationOrganizationsLocalEducationAgenciesApiTests : IDisposable
    {
        private InstancesEducationOrganizationsLocalEducationAgenciesApi instance;

        public InstancesEducationOrganizationsLocalEducationAgenciesApiTests()
        {
            instance = new InstancesEducationOrganizationsLocalEducationAgenciesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of InstancesEducationOrganizationsLocalEducationAgenciesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' InstancesEducationOrganizationsLocalEducationAgenciesApi
            //Assert.IsType<InstancesEducationOrganizationsLocalEducationAgenciesApi>(instance);
        }

        /// <summary>
        /// Test CreateLocalEducationAgencyAsync
        /// </summary>
        [Fact]
        public void CreateLocalEducationAgencyAsyncTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tenantId = null;
            //string instanceId = null;
            //int year = null;
            //string? apiVersion = null;
            //string? xVersion = null;
            //EdfiAdminApiEdfiAdminV1CreateLocalEducationAgencyRequest? edfiAdminApiEdfiAdminV1CreateLocalEducationAgencyRequest = null;
            //var response = instance.CreateLocalEducationAgencyAsync(tenantId, instanceId, year, apiVersion, xVersion, edfiAdminApiEdfiAdminV1CreateLocalEducationAgencyRequest);
            //Assert.IsType<EdfiAdminApiEdfiAdminV1LocalEducationAgencyCreatedResponse>(response);
        }

        /// <summary>
        /// Test DeleteLocalEducationAgencyAsync
        /// </summary>
        [Fact]
        public void DeleteLocalEducationAgencyAsyncTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tenantId = null;
            //string instanceId = null;
            //int year = null;
            //string localEducationAgencyId = null;
            //string? apiVersion = null;
            //string? xVersion = null;
            //instance.DeleteLocalEducationAgencyAsync(tenantId, instanceId, year, localEducationAgencyId, apiVersion, xVersion);
        }

        /// <summary>
        /// Test GetLocalEducationAgencyByIdAsync
        /// </summary>
        [Fact]
        public void GetLocalEducationAgencyByIdAsyncTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tenantId = null;
            //string instanceId = null;
            //int year = null;
            //string localEducationAgencyId = null;
            //string? apiVersion = null;
            //string? xVersion = null;
            //var response = instance.GetLocalEducationAgencyByIdAsync(tenantId, instanceId, year, localEducationAgencyId, apiVersion, xVersion);
            //Assert.IsType<EdfiAdminApiEdfiAdminV1GetLocalEducationAgencyProfileResponse>(response);
        }

        /// <summary>
        /// Test GetlLocalEducationAgenciesAsync
        /// </summary>
        [Fact]
        public void GetlLocalEducationAgenciesAsyncTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tenantId = null;
            //string instanceId = null;
            //int year = null;
            //int? pageSize = null;
            //int? pageIndex = null;
            //string? orderBy = null;
            //string? filter = null;
            //string? apiVersion = null;
            //string? xVersion = null;
            //var response = instance.GetlLocalEducationAgenciesAsync(tenantId, instanceId, year, pageSize, pageIndex, orderBy, filter, apiVersion, xVersion);
            //Assert.IsType<EdfiAdminApiEdfiAdminV1LocalEducationAgencyTableViewResponsePaginatedItemsViewModel>(response);
        }

        /// <summary>
        /// Test SyncLocalEducationAgencyAsync
        /// </summary>
        [Fact]
        public void SyncLocalEducationAgencyAsyncTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tenantId = null;
            //string instanceId = null;
            //int year = null;
            //int localEducationAgencyId = null;
            //string? apiVersion = null;
            //string? xVersion = null;
            //EdfiAdminApiEdfiAdminV1SyncLocalEducationAgencyRequest? edfiAdminApiEdfiAdminV1SyncLocalEducationAgencyRequest = null;
            //var response = instance.SyncLocalEducationAgencyAsync(tenantId, instanceId, year, localEducationAgencyId, apiVersion, xVersion, edfiAdminApiEdfiAdminV1SyncLocalEducationAgencyRequest);
            //Assert.IsType<EdfiAdminApiEdfiAdminV1SyncResponse>(response);
        }

        /// <summary>
        /// Test UpdateLocalEducationAgencyAsync
        /// </summary>
        [Fact]
        public void UpdateLocalEducationAgencyAsyncTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tenantId = null;
            //string instanceId = null;
            //int year = null;
            //string localEducationAgencyId = null;
            //string? apiVersion = null;
            //string? xVersion = null;
            //EdfiAdminApiEdfiAdminV1UpdateLocalEducationAgencyRequest? edfiAdminApiEdfiAdminV1UpdateLocalEducationAgencyRequest = null;
            //instance.UpdateLocalEducationAgencyAsync(tenantId, instanceId, year, localEducationAgencyId, apiVersion, xVersion, edfiAdminApiEdfiAdminV1UpdateLocalEducationAgencyRequest);
        }
    }
}
