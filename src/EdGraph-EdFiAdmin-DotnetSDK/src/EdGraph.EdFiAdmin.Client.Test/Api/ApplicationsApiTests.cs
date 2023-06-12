/*
 * Admin API Documentation
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1
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
    ///  Class for testing ApplicationsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ApplicationsApiTests : IDisposable
    {
        private ApplicationsApi instance;

        public ApplicationsApiTests()
        {
            instance = new ApplicationsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ApplicationsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ApplicationsApi
            //Assert.IsType<ApplicationsApi>(instance);
        }

        /// <summary>
        /// Test V1ApplicationsGet
        /// </summary>
        [Fact]
        public void V1ApplicationsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.V1ApplicationsGet();
            //Assert.IsType<List<EdFiOdsAdminApiFeaturesApplicationsApplicationModel>>(response);
        }

        /// <summary>
        /// Test V1ApplicationsIdDelete
        /// </summary>
        [Fact]
        public void V1ApplicationsIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //instance.V1ApplicationsIdDelete(id);
        }

        /// <summary>
        /// Test V1ApplicationsIdGet
        /// </summary>
        [Fact]
        public void V1ApplicationsIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //var response = instance.V1ApplicationsIdGet(id);
            //Assert.IsType<EdFiOdsAdminApiFeaturesApplicationsApplicationModel>(response);
        }

        /// <summary>
        /// Test V1ApplicationsIdPut
        /// </summary>
        [Fact]
        public void V1ApplicationsIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //EdFiOdsAdminApiFeaturesApplicationsEditApplicationRequest body = null;
            //var response = instance.V1ApplicationsIdPut(id, body);
            //Assert.IsType<EdFiOdsAdminApiFeaturesApplicationsApplicationModel>(response);
        }

        /// <summary>
        /// Test V1ApplicationsIdResetCredentialPut
        /// </summary>
        [Fact]
        public void V1ApplicationsIdResetCredentialPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //var response = instance.V1ApplicationsIdResetCredentialPut(id);
            //Assert.IsType<EdFiOdsAdminApiFeaturesApplicationsApplicationResult>(response);
        }

        /// <summary>
        /// Test V1ApplicationsPost
        /// </summary>
        [Fact]
        public void V1ApplicationsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //EdFiOdsAdminApiFeaturesApplicationsAddApplicationRequest body = null;
            //var response = instance.V1ApplicationsPost(body);
            //Assert.IsType<EdFiOdsAdminApiFeaturesApplicationsApplicationResult>(response);
        }
    }
}