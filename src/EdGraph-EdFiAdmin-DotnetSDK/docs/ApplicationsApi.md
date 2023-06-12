# EdGraph.EdFiAdmin.Client.Api.ApplicationsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**V1ApplicationsGet**](ApplicationsApi.md#v1applicationsget) | **GET** /v1/applications | Retrieves all applications. |
| [**V1ApplicationsIdDelete**](ApplicationsApi.md#v1applicationsiddelete) | **DELETE** /v1/applications/{id} | Deletes an existing application using the resource identifier. |
| [**V1ApplicationsIdGet**](ApplicationsApi.md#v1applicationsidget) | **GET** /v1/applications/{id} | Retrieves a specific application based on the identifier. |
| [**V1ApplicationsIdPut**](ApplicationsApi.md#v1applicationsidput) | **PUT** /v1/applications/{id} | Updates application based on the resource identifier. |
| [**V1ApplicationsIdResetCredentialPut**](ApplicationsApi.md#v1applicationsidresetcredentialput) | **PUT** /v1/applications/{id}/reset-credential | Reset application credentials. Returns new key and secret. |
| [**V1ApplicationsPost**](ApplicationsApi.md#v1applicationspost) | **POST** /v1/applications | Creates application based on the supplied values. |

<a id="v1applicationsget"></a>
# **V1ApplicationsGet**
> List&lt;EdFiOdsAdminApiFeaturesApplicationsApplicationModel&gt; V1ApplicationsGet ()

Retrieves all applications.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.EdFiAdmin.Client.Api;
using EdGraph.EdFiAdmin.Client.Client;
using EdGraph.EdFiAdmin.Client.Model;

namespace Example
{
    public class V1ApplicationsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ApplicationsApi(config);

            try
            {
                // Retrieves all applications.
                List<EdFiOdsAdminApiFeaturesApplicationsApplicationModel> result = apiInstance.V1ApplicationsGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ApplicationsApi.V1ApplicationsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1ApplicationsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves all applications.
    ApiResponse<List<EdFiOdsAdminApiFeaturesApplicationsApplicationModel>> response = apiInstance.V1ApplicationsGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ApplicationsApi.V1ApplicationsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
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
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="v1applicationsiddelete"></a>
# **V1ApplicationsIdDelete**
> void V1ApplicationsIdDelete (int id)

Deletes an existing application using the resource identifier.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.EdFiAdmin.Client.Api;
using EdGraph.EdFiAdmin.Client.Client;
using EdGraph.EdFiAdmin.Client.Model;

namespace Example
{
    public class V1ApplicationsIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ApplicationsApi(config);
            var id = 56;  // int | 

            try
            {
                // Deletes an existing application using the resource identifier.
                apiInstance.V1ApplicationsIdDelete(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ApplicationsApi.V1ApplicationsIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1ApplicationsIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes an existing application using the resource identifier.
    apiInstance.V1ApplicationsIdDeleteWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ApplicationsApi.V1ApplicationsIdDeleteWithHttpInfo: " + e.Message);
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

<a id="v1applicationsidget"></a>
# **V1ApplicationsIdGet**
> EdFiOdsAdminApiFeaturesApplicationsApplicationModel V1ApplicationsIdGet (int id)

Retrieves a specific application based on the identifier.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.EdFiAdmin.Client.Api;
using EdGraph.EdFiAdmin.Client.Client;
using EdGraph.EdFiAdmin.Client.Model;

namespace Example
{
    public class V1ApplicationsIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ApplicationsApi(config);
            var id = 56;  // int | 

            try
            {
                // Retrieves a specific application based on the identifier.
                EdFiOdsAdminApiFeaturesApplicationsApplicationModel result = apiInstance.V1ApplicationsIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ApplicationsApi.V1ApplicationsIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1ApplicationsIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific application based on the identifier.
    ApiResponse<EdFiOdsAdminApiFeaturesApplicationsApplicationModel> response = apiInstance.V1ApplicationsIdGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ApplicationsApi.V1ApplicationsIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |

### Return type

[**EdFiOdsAdminApiFeaturesApplicationsApplicationModel**](EdFiOdsAdminApiFeaturesApplicationsApplicationModel.md)

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

<a id="v1applicationsidput"></a>
# **V1ApplicationsIdPut**
> EdFiOdsAdminApiFeaturesApplicationsApplicationModel V1ApplicationsIdPut (int id, EdFiOdsAdminApiFeaturesApplicationsEditApplicationRequest body)

Updates application based on the resource identifier.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.EdFiAdmin.Client.Api;
using EdGraph.EdFiAdmin.Client.Client;
using EdGraph.EdFiAdmin.Client.Model;

namespace Example
{
    public class V1ApplicationsIdPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ApplicationsApi(config);
            var id = 56;  // int | 
            var body = new EdFiOdsAdminApiFeaturesApplicationsEditApplicationRequest();  // EdFiOdsAdminApiFeaturesApplicationsEditApplicationRequest | 

            try
            {
                // Updates application based on the resource identifier.
                EdFiOdsAdminApiFeaturesApplicationsApplicationModel result = apiInstance.V1ApplicationsIdPut(id, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ApplicationsApi.V1ApplicationsIdPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1ApplicationsIdPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates application based on the resource identifier.
    ApiResponse<EdFiOdsAdminApiFeaturesApplicationsApplicationModel> response = apiInstance.V1ApplicationsIdPutWithHttpInfo(id, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ApplicationsApi.V1ApplicationsIdPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |
| **body** | **EdFiOdsAdminApiFeaturesApplicationsEditApplicationRequest** |  |  |

### Return type

[**EdFiOdsAdminApiFeaturesApplicationsApplicationModel**](EdFiOdsAdminApiFeaturesApplicationsApplicationModel.md)

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

<a id="v1applicationsidresetcredentialput"></a>
# **V1ApplicationsIdResetCredentialPut**
> EdFiOdsAdminApiFeaturesApplicationsApplicationResult V1ApplicationsIdResetCredentialPut (int id)

Reset application credentials. Returns new key and secret.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.EdFiAdmin.Client.Api;
using EdGraph.EdFiAdmin.Client.Client;
using EdGraph.EdFiAdmin.Client.Model;

namespace Example
{
    public class V1ApplicationsIdResetCredentialPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ApplicationsApi(config);
            var id = 56;  // int | 

            try
            {
                // Reset application credentials. Returns new key and secret.
                EdFiOdsAdminApiFeaturesApplicationsApplicationResult result = apiInstance.V1ApplicationsIdResetCredentialPut(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ApplicationsApi.V1ApplicationsIdResetCredentialPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1ApplicationsIdResetCredentialPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reset application credentials. Returns new key and secret.
    ApiResponse<EdFiOdsAdminApiFeaturesApplicationsApplicationResult> response = apiInstance.V1ApplicationsIdResetCredentialPutWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ApplicationsApi.V1ApplicationsIdResetCredentialPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |

### Return type

[**EdFiOdsAdminApiFeaturesApplicationsApplicationResult**](EdFiOdsAdminApiFeaturesApplicationsApplicationResult.md)

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
| **400** | Bad Request. The request was invalid and cannot be completed. See the response body for details. |  -  |
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="v1applicationspost"></a>
# **V1ApplicationsPost**
> EdFiOdsAdminApiFeaturesApplicationsApplicationResult V1ApplicationsPost (EdFiOdsAdminApiFeaturesApplicationsAddApplicationRequest body)

Creates application based on the supplied values.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.EdFiAdmin.Client.Api;
using EdGraph.EdFiAdmin.Client.Client;
using EdGraph.EdFiAdmin.Client.Model;

namespace Example
{
    public class V1ApplicationsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ApplicationsApi(config);
            var body = new EdFiOdsAdminApiFeaturesApplicationsAddApplicationRequest();  // EdFiOdsAdminApiFeaturesApplicationsAddApplicationRequest | 

            try
            {
                // Creates application based on the supplied values.
                EdFiOdsAdminApiFeaturesApplicationsApplicationResult result = apiInstance.V1ApplicationsPost(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ApplicationsApi.V1ApplicationsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1ApplicationsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates application based on the supplied values.
    ApiResponse<EdFiOdsAdminApiFeaturesApplicationsApplicationResult> response = apiInstance.V1ApplicationsPostWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ApplicationsApi.V1ApplicationsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | **EdFiOdsAdminApiFeaturesApplicationsAddApplicationRequest** |  |  |

### Return type

[**EdFiOdsAdminApiFeaturesApplicationsApplicationResult**](EdFiOdsAdminApiFeaturesApplicationsApplicationResult.md)

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

