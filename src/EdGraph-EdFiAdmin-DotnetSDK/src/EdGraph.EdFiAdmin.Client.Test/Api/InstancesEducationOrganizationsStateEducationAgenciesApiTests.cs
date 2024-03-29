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
    ///  Class for testing InstancesEducationOrganizationsStateEducationAgenciesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class InstancesEducationOrganizationsStateEducationAgenciesApiTests : IDisposable
    {
        private InstancesEducationOrganizationsStateEducationAgenciesApi instance;

        public InstancesEducationOrganizationsStateEducationAgenciesApiTests()
        {
            instance = new InstancesEducationOrganizationsStateEducationAgenciesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of InstancesEducationOrganizationsStateEducationAgenciesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' InstancesEducationOrganizationsStateEducationAgenciesApi
            //Assert.IsType<InstancesEducationOrganizationsStateEducationAgenciesApi>(instance);
        }

        /// <summary>
        /// Test CreateStateEducationAgencyAsync
        /// </summary>
        [Fact]
        public void CreateStateEducationAgencyAsyncTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid tenantId = null;
            //string instanceId = null;
            //int year = null;
            //string? apiVersion = null;
            //string? xVersion = null;
            //EdfiAdminApiEdfiAdminV1CreateStateEducationAgencyRequest? edfiAdminApiEdfiAdminV1CreateStateEducationAgencyRequest = null;
            //var response = instance.CreateStateEducationAgencyAsync(tenantId, instanceId, year, apiVersion, xVersion, edfiAdminApiEdfiAdminV1CreateStateEducationAgencyRequest);
            //Assert.IsType<EdfiAdminApiEdfiAdminV1StateEducationAgencyCreatedResponse>(response);
        }

        /// <summary>
        /// Test DeleteStateEducationAgencyAsync
        /// </summary>
        [Fact]
        public void DeleteStateEducationAgencyAsyncTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid tenantId = null;
            //string instanceId = null;
            //int year = null;
            //Guid stateEducationAgencyId = null;
            //string? apiVersion = null;
            //string? xVersion = null;
            //instance.DeleteStateEducationAgencyAsync(tenantId, instanceId, year, stateEducationAgencyId, apiVersion, xVersion);
        }

        /// <summary>
        /// Test GetStateEducationAgencyByIdAsync
        /// </summary>
        [Fact]
        public void GetStateEducationAgencyByIdAsyncTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid tenantId = null;
            //string instanceId = null;
            //int year = null;
            //Guid stateEducationAgencyId = null;
            //string? apiVersion = null;
            //string? xVersion = null;
            //var response = instance.GetStateEducationAgencyByIdAsync(tenantId, instanceId, year, stateEducationAgencyId, apiVersion, xVersion);
            //Assert.IsType<EdfiAdminApiEdfiAdminV1StateEducationAgency>(response);
        }

        /// <summary>
        /// Test UpdateStateEducationAgencyAsync
        /// </summary>
        [Fact]
        public void UpdateStateEducationAgencyAsyncTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid tenantId = null;
            //string instanceId = null;
            //int year = null;
            //Guid stateEducationAgencyId = null;
            //string? apiVersion = null;
            //string? xVersion = null;
            //EdfiAdminApiEdfiAdminV1UpdateStateEducationAgencyRequest? edfiAdminApiEdfiAdminV1UpdateStateEducationAgencyRequest = null;
            //instance.UpdateStateEducationAgencyAsync(tenantId, instanceId, year, stateEducationAgencyId, apiVersion, xVersion, edfiAdminApiEdfiAdminV1UpdateStateEducationAgencyRequest);
        }
    }
}
