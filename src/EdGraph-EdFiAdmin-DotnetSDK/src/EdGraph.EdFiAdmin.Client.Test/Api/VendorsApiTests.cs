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
    ///  Class for testing VendorsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class VendorsApiTests : IDisposable
    {
        private VendorsApi instance;

        public VendorsApiTests()
        {
            instance = new VendorsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of VendorsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' VendorsApi
            //Assert.IsType<VendorsApi>(instance);
        }

        /// <summary>
        /// Test V1VendorsGet
        /// </summary>
        [Fact]
        public void V1VendorsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.V1VendorsGet();
            //Assert.IsType<List<EdFiOdsAdminApiFeaturesVendorsVendorModel>>(response);
        }

        /// <summary>
        /// Test V1VendorsIdApplicationsGet
        /// </summary>
        [Fact]
        public void V1VendorsIdApplicationsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //var response = instance.V1VendorsIdApplicationsGet(id);
            //Assert.IsType<List<EdFiOdsAdminApiFeaturesApplicationsApplicationModel>>(response);
        }

        /// <summary>
        /// Test V1VendorsIdDelete
        /// </summary>
        [Fact]
        public void V1VendorsIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //instance.V1VendorsIdDelete(id);
        }

        /// <summary>
        /// Test V1VendorsIdGet
        /// </summary>
        [Fact]
        public void V1VendorsIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //var response = instance.V1VendorsIdGet(id);
            //Assert.IsType<EdFiOdsAdminApiFeaturesVendorsVendorModel>(response);
        }

        /// <summary>
        /// Test V1VendorsIdPut
        /// </summary>
        [Fact]
        public void V1VendorsIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //EdFiOdsAdminApiFeaturesVendorsEditVendorRequest body = null;
            //var response = instance.V1VendorsIdPut(id, body);
            //Assert.IsType<EdFiOdsAdminApiFeaturesVendorsVendorModel>(response);
        }

        /// <summary>
        /// Test V1VendorsPost
        /// </summary>
        [Fact]
        public void V1VendorsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //EdFiOdsAdminApiFeaturesVendorsAddVendorRequest body = null;
            //var response = instance.V1VendorsPost(body);
            //Assert.IsType<EdFiOdsAdminApiFeaturesVendorsVendorModel>(response);
        }
    }
}
