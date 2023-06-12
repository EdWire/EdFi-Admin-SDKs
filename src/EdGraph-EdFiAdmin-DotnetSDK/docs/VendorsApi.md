# EdGraph.EdFiAdmin.Client.Api.VendorsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**V1VendorsGet**](VendorsApi.md#v1vendorsget) | **GET** /v1/vendors | Retrieves all vendors. |
| [**V1VendorsIdApplicationsGet**](VendorsApi.md#v1vendorsidapplicationsget) | **GET** /v1/vendors/{id}/applications | Retrieves applications assigned to a specific vendor based on the resource identifier. |
| [**V1VendorsIdDelete**](VendorsApi.md#v1vendorsiddelete) | **DELETE** /v1/vendors/{id} | Deletes an existing vendor using the resource identifier. |
| [**V1VendorsIdGet**](VendorsApi.md#v1vendorsidget) | **GET** /v1/vendors/{id} | Retrieves a specific vendor based on the identifier. |
| [**V1VendorsIdPut**](VendorsApi.md#v1vendorsidput) | **PUT** /v1/vendors/{id} | Updates vendor based on the resource identifier. |
| [**V1VendorsPost**](VendorsApi.md#v1vendorspost) | **POST** /v1/vendors | Creates vendor based on the supplied values. |

<a id="v1vendorsget"></a>
# **V1VendorsGet**
> List&lt;EdFiOdsAdminApiFeaturesVendorsVendorModel&gt; V1VendorsGet ()

Retrieves all vendors.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.EdFiAdmin.Client.Api;
using EdGraph.EdFiAdmin.Client.Client;
using EdGraph.EdFiAdmin.Client.Model;

namespace Example
{
    public class V1VendorsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VendorsApi(config);

            try
            {
                // Retrieves all vendors.
                List<EdFiOdsAdminApiFeaturesVendorsVendorModel> result = apiInstance.V1VendorsGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VendorsApi.V1VendorsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1VendorsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves all vendors.
    ApiResponse<List<EdFiOdsAdminApiFeaturesVendorsVendorModel>> response = apiInstance.V1VendorsGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VendorsApi.V1VendorsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;EdFiOdsAdminApiFeaturesVendorsVendorModel&gt;**](EdFiOdsAdminApiFeaturesVendorsVendorModel.md)

### Authorization

[oauth](../README.md#oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **401** | Unauthorized. The request requires authentication |  -  |
| **403** | Forbidden. The request is authenticated, but not authorized to access this resource |  -  |
| **500** | Internal server error. An unhandled error occurred on the server. See the response body for details. |  -  |
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="v1vendorsidapplicationsget"></a>
# **V1VendorsIdApplicationsGet**
> List&lt;EdFiOdsAdminApiFeaturesApplicationsApplicationModel&gt; V1VendorsIdApplicationsGet (int id)

Retrieves applications assigned to a specific vendor based on the resource identifier.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.EdFiAdmin.Client.Api;
using EdGraph.EdFiAdmin.Client.Client;
using EdGraph.EdFiAdmin.Client.Model;

namespace Example
{
    public class V1VendorsIdApplicationsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VendorsApi(config);
            var id = 56;  // int | 

            try
            {
                // Retrieves applications assigned to a specific vendor based on the resource identifier.
                List<EdFiOdsAdminApiFeaturesApplicationsApplicationModel> result = apiInstance.V1VendorsIdApplicationsGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VendorsApi.V1VendorsIdApplicationsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1VendorsIdApplicationsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves applications assigned to a specific vendor based on the resource identifier.
    ApiResponse<List<EdFiOdsAdminApiFeaturesApplicationsApplicationModel>> response = apiInstance.V1VendorsIdApplicationsGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VendorsApi.V1VendorsIdApplicationsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |

### Return type

[**List&lt;EdFiOdsAdminApiFeaturesApplicationsApplicationModel&gt;**](EdFiOdsAdminApiFeaturesApplicationsApplicationModel.md)

### Authorization

[oauth](../README.md#oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **401** | Unauthorized. The request requires authentication |  -  |
| **403** | Forbidden. The request is authenticated, but not authorized to access this resource |  -  |
| **500** | Internal server error. An unhandled error occurred on the server. See the response body for details. |  -  |
| **404** | Not found. A resource with given identifier could not be found. |  -  |
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="v1vendorsiddelete"></a>
# **V1VendorsIdDelete**
> void V1VendorsIdDelete (int id)

Deletes an existing vendor using the resource identifier.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.EdFiAdmin.Client.Api;
using EdGraph.EdFiAdmin.Client.Client;
using EdGraph.EdFiAdmin.Client.Model;

namespace Example
{
    public class V1VendorsIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VendorsApi(config);
            var id = 56;  // int | 

            try
            {
                // Deletes an existing vendor using the resource identifier.
                apiInstance.V1VendorsIdDelete(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VendorsApi.V1VendorsIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1VendorsIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes an existing vendor using the resource identifier.
    apiInstance.V1VendorsIdDeleteWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VendorsApi.V1VendorsIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |

### Return type

void (empty response body)

### Authorization

[oauth](../README.md#oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **401** | Unauthorized. The request requires authentication |  -  |
| **403** | Forbidden. The request is authenticated, but not authorized to access this resource |  -  |
| **500** | Internal server error. An unhandled error occurred on the server. See the response body for details. |  -  |
| **404** | Not found. A resource with given identifier could not be found. |  -  |
| **200** | Resource was successfully deleted. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="v1vendorsidget"></a>
# **V1VendorsIdGet**
> EdFiOdsAdminApiFeaturesVendorsVendorModel V1VendorsIdGet (int id)

Retrieves a specific vendor based on the identifier.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.EdFiAdmin.Client.Api;
using EdGraph.EdFiAdmin.Client.Client;
using EdGraph.EdFiAdmin.Client.Model;

namespace Example
{
    public class V1VendorsIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VendorsApi(config);
            var id = 56;  // int | 

            try
            {
                // Retrieves a specific vendor based on the identifier.
                EdFiOdsAdminApiFeaturesVendorsVendorModel result = apiInstance.V1VendorsIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VendorsApi.V1VendorsIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1VendorsIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific vendor based on the identifier.
    ApiResponse<EdFiOdsAdminApiFeaturesVendorsVendorModel> response = apiInstance.V1VendorsIdGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VendorsApi.V1VendorsIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |

### Return type

[**EdFiOdsAdminApiFeaturesVendorsVendorModel**](EdFiOdsAdminApiFeaturesVendorsVendorModel.md)

### Authorization

[oauth](../README.md#oauth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **401** | Unauthorized. The request requires authentication |  -  |
| **403** | Forbidden. The request is authenticated, but not authorized to access this resource |  -  |
| **500** | Internal server error. An unhandled error occurred on the server. See the response body for details. |  -  |
| **404** | Not found. A resource with given identifier could not be found. |  -  |
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="v1vendorsidput"></a>
# **V1VendorsIdPut**
> EdFiOdsAdminApiFeaturesVendorsVendorModel V1VendorsIdPut (int id, EdFiOdsAdminApiFeaturesVendorsEditVendorRequest body)

Updates vendor based on the resource identifier.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.EdFiAdmin.Client.Api;
using EdGraph.EdFiAdmin.Client.Client;
using EdGraph.EdFiAdmin.Client.Model;

namespace Example
{
    public class V1VendorsIdPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VendorsApi(config);
            var id = 56;  // int | 
            var body = new EdFiOdsAdminApiFeaturesVendorsEditVendorRequest();  // EdFiOdsAdminApiFeaturesVendorsEditVendorRequest | 

            try
            {
                // Updates vendor based on the resource identifier.
                EdFiOdsAdminApiFeaturesVendorsVendorModel result = apiInstance.V1VendorsIdPut(id, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VendorsApi.V1VendorsIdPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1VendorsIdPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates vendor based on the resource identifier.
    ApiResponse<EdFiOdsAdminApiFeaturesVendorsVendorModel> response = apiInstance.V1VendorsIdPutWithHttpInfo(id, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VendorsApi.V1VendorsIdPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |
| **body** | **EdFiOdsAdminApiFeaturesVendorsEditVendorRequest** |  |  |

### Return type

[**EdFiOdsAdminApiFeaturesVendorsVendorModel**](EdFiOdsAdminApiFeaturesVendorsVendorModel.md)

### Authorization

[oauth](../README.md#oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **401** | Unauthorized. The request requires authentication |  -  |
| **403** | Forbidden. The request is authenticated, but not authorized to access this resource |  -  |
| **500** | Internal server error. An unhandled error occurred on the server. See the response body for details. |  -  |
| **404** | Not found. A resource with given identifier could not be found. |  -  |
| **400** | Bad Request. The request was invalid and cannot be completed. See the response body for details. |  -  |
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="v1vendorspost"></a>
# **V1VendorsPost**
> EdFiOdsAdminApiFeaturesVendorsVendorModel V1VendorsPost (EdFiOdsAdminApiFeaturesVendorsAddVendorRequest body)

Creates vendor based on the supplied values.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.EdFiAdmin.Client.Api;
using EdGraph.EdFiAdmin.Client.Client;
using EdGraph.EdFiAdmin.Client.Model;

namespace Example
{
    public class V1VendorsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VendorsApi(config);
            var body = new EdFiOdsAdminApiFeaturesVendorsAddVendorRequest();  // EdFiOdsAdminApiFeaturesVendorsAddVendorRequest | 

            try
            {
                // Creates vendor based on the supplied values.
                EdFiOdsAdminApiFeaturesVendorsVendorModel result = apiInstance.V1VendorsPost(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VendorsApi.V1VendorsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1VendorsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates vendor based on the supplied values.
    ApiResponse<EdFiOdsAdminApiFeaturesVendorsVendorModel> response = apiInstance.V1VendorsPostWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VendorsApi.V1VendorsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | **EdFiOdsAdminApiFeaturesVendorsAddVendorRequest** |  |  |

### Return type

[**EdFiOdsAdminApiFeaturesVendorsVendorModel**](EdFiOdsAdminApiFeaturesVendorsVendorModel.md)

### Authorization

[oauth](../README.md#oauth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **401** | Unauthorized. The request requires authentication |  -  |
| **403** | Forbidden. The request is authenticated, but not authorized to access this resource |  -  |
| **500** | Internal server error. An unhandled error occurred on the server. See the response body for details. |  -  |
| **400** | Bad Request. The request was invalid and cannot be completed. See the response body for details. |  -  |
| **201** | Created |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

