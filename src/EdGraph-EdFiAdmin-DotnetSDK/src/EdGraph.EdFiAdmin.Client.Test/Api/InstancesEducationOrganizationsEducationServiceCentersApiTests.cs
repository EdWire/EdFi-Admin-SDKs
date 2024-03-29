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
    ///  Class for testing InstancesEducationOrganizationsEducationServiceCentersApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class InstancesEducationOrganizationsEducationServiceCentersApiTests : IDisposable
    {
        private InstancesEducationOrganizationsEducationServiceCentersApi instance;

        public InstancesEducationOrganizationsEducationServiceCentersApiTests()
        {
            instance = new InstancesEducationOrganizationsEducationServiceCentersApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of InstancesEducationOrganizationsEducationServiceCentersApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' InstancesEducationOrganizationsEducationServiceCentersApi
            //Assert.IsType<InstancesEducationOrganizationsEducationServiceCentersApi>(instance);
        }

        /// <summary>
        /// Test CreateEducationServiceCenterAsync
        /// </summary>
        [Fact]
        public void CreateEducationServiceCenterAsyncTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid tenantId = null;
            //string instanceId = null;
            //int year = null;
            //string? apiVersion = null;
            //string? xVersion = null;
            //EdfiAdminApiEdfiAdminV1CreateEducationServiceCenterRequest? edfiAdminApiEdfiAdminV1CreateEducationServiceCenterRequest = null;
            //var response = instance.CreateEducationServiceCenterAsync(tenantId, instanceId, year, apiVersion, xVersion, edfiAdminApiEdfiAdminV1CreateEducationServiceCenterRequest);
            //Assert.IsType<EdfiAdminApiEdfiAdminV1EducationServiceCenterCreatedResponse>(response);
        }

        /// <summary>
        /// Test DeleteEducationServiceCenterAsync
        /// </summary>
        [Fact]
        public void DeleteEducationServiceCenterAsyncTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid tenantId = null;
            //string instanceId = null;
            //int year = null;
            //Guid educationServiceCenterId = null;
            //string? apiVersion = null;
            //string? xVersion = null;
            //instance.DeleteEducationServiceCenterAsync(tenantId, instanceId, year, educationServiceCenterId, apiVersion, xVersion);
        }

        /// <summary>
        /// Test GetEducationServiceCenterByIdAsync
        /// </summary>
        [Fact]
        public void GetEducationServiceCenterByIdAsyncTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid tenantId = null;
            //string instanceId = null;
            //int year = null;
            //Guid educationServiceCenterId = null;
            //string? apiVersion = null;
            //string? xVersion = null;
            //var response = instance.GetEducationServiceCenterByIdAsync(tenantId, instanceId, year, educationServiceCenterId, apiVersion, xVersion);
            //Assert.IsType<EdfiAdminApiEdfiAdminV1EducationServiceCenter>(response);
        }

        /// <summary>
        /// Test UpdateEducationServiceCenterAsync
        /// </summary>
        [Fact]
        public void UpdateEducationServiceCenterAsyncTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid tenantId = null;
            //string instanceId = null;
            //int year = null;
            //Guid educationServiceCenterId = null;
            //string? apiVersion = null;
            //string? xVersion = null;
            //EdfiAdminApiEdfiAdminV1UpdateEducationServiceCenterRequest? edfiAdminApiEdfiAdminV1UpdateEducationServiceCenterRequest = null;
            //instance.UpdateEducationServiceCenterAsync(tenantId, instanceId, year, educationServiceCenterId, apiVersion, xVersion, edfiAdminApiEdfiAdminV1UpdateEducationServiceCenterRequest);
        }
    }
}