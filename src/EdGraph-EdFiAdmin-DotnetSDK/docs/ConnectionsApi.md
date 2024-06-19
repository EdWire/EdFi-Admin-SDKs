# EdGraph.EdFiAdmin.Client.Api.ConnectionsApi

All URIs are relative to *https://api.dev.edgraph.com/tenant*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateEdFiConnection**](ConnectionsApi.md#createedficonnection) | **POST** /tenants/{tenantId}/edfiadmin/connections | Creates a new Ed-Fi Connection. |
| [**DeleteEdFiConnection**](ConnectionsApi.md#deleteedficonnection) | **DELETE** /tenants/{tenantId}/edfiadmin/connections/{connectionId} | Deletes an Ed-Fi Connection. |
| [**GetEdFiConnectionById**](ConnectionsApi.md#getedficonnectionbyid) | **GET** /tenants/{tenantId}/edfiadmin/connections/{connectionId} | Retrieves an Ed-Fi Connection by ID. |
| [**GetEdFiConnectionsAsync**](ConnectionsApi.md#getedficonnectionsasync) | **GET** /tenants/{tenantId}/edfiadmin/connections | Retrieves a list of Ed-Fi Connections. |
| [**GetEdFiOdsBackupCodesDescriptorsAsync**](ConnectionsApi.md#getedfiodsbackupcodesdescriptorsasync) | **GET** /tenants/{tenantId}/edfiadmin/connections/odsbackupcodes | Retrieves a list of Ed-Fi ODS backup codes. |
| [**UpdateEdFiConnection**](ConnectionsApi.md#updateedficonnection) | **PUT** /tenants/{tenantId}/edfiadmin/connections/{connectionId} | Updates an Ed-Fi Connection. |

<a id="createedficonnection"></a>
# **CreateEdFiConnection**
> void CreateEdFiConnection (Guid tenantId, string? apiVersion = null, string? xVersion = null, EdfiAdminApiEdfiAdminV1CreateEdFiConnectionRequest? edfiAdminApiEdfiAdminV1CreateEdFiConnectionRequest = null)

Creates a new Ed-Fi Connection.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.EdFiAdmin.Client.Api;
using EdGraph.EdFiAdmin.Client.Client;
using EdGraph.EdFiAdmin.Client.Model;

namespace Example
{
    public class CreateEdFiConnectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.dev.edgraph.com/tenant";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConnectionsApi(config);
            var tenantId = "tenantId_example";  // Guid | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 
            var edfiAdminApiEdfiAdminV1CreateEdFiConnectionRequest = new EdfiAdminApiEdfiAdminV1CreateEdFiConnectionRequest?(); // EdfiAdminApiEdfiAdminV1CreateEdFiConnectionRequest? |  (optional) 

            try
            {
                // Creates a new Ed-Fi Connection.
                apiInstance.CreateEdFiConnection(tenantId, apiVersion, xVersion, edfiAdminApiEdfiAdminV1CreateEdFiConnectionRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConnectionsApi.CreateEdFiConnection: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateEdFiConnectionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a new Ed-Fi Connection.
    apiInstance.CreateEdFiConnectionWithHttpInfo(tenantId, apiVersion, xVersion, edfiAdminApiEdfiAdminV1CreateEdFiConnectionRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConnectionsApi.CreateEdFiConnectionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **Guid** |  |  |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |
| **edfiAdminApiEdfiAdminV1CreateEdFiConnectionRequest** | [**EdfiAdminApiEdfiAdminV1CreateEdFiConnectionRequest?**](EdfiAdminApiEdfiAdminV1CreateEdFiConnectionRequest?.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **401** | Unauthorized. The request requires authentication. The OAuth bearer token was either not provided or is invalid. The operation may succeed once authentication has been successfully completed. |  -  |
| **403** | Forbidden. The request cannot be completed in the current authorization context. Contact your administrator if you believe this operation should be allowed. |  -  |
| **500** | An unhandled error occurred on the server.See the response body for details. |  -  |
| **200** | Success |  -  |
| **400** | Bad Request. The request was invalid and cannot be completed. See the response body for specific validation errors. This will typically be an issue with the query parameters or the request body values. |  -  |
| **201** | The resource was created. The location of the resource is available in the Location header of the response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteedficonnection"></a>
# **DeleteEdFiConnection**
> EdfiAdminApiEdfiAdminV1EdFiConnectionDeletedResponse DeleteEdFiConnection (string tenantId, string connectionId, string? apiVersion = null, string? xVersion = null)

Deletes an Ed-Fi Connection.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.EdFiAdmin.Client.Api;
using EdGraph.EdFiAdmin.Client.Client;
using EdGraph.EdFiAdmin.Client.Model;

namespace Example
{
    public class DeleteEdFiConnectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.dev.edgraph.com/tenant";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConnectionsApi(config);
            var tenantId = "tenantId_example";  // string | 
            var connectionId = "connectionId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 

            try
            {
                // Deletes an Ed-Fi Connection.
                EdfiAdminApiEdfiAdminV1EdFiConnectionDeletedResponse result = apiInstance.DeleteEdFiConnection(tenantId, connectionId, apiVersion, xVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConnectionsApi.DeleteEdFiConnection: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteEdFiConnectionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes an Ed-Fi Connection.
    ApiResponse<EdfiAdminApiEdfiAdminV1EdFiConnectionDeletedResponse> response = apiInstance.DeleteEdFiConnectionWithHttpInfo(tenantId, connectionId, apiVersion, xVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConnectionsApi.DeleteEdFiConnectionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **connectionId** | **string** |  |  |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |

### Return type

[**EdfiAdminApiEdfiAdminV1EdFiConnectionDeletedResponse**](EdfiAdminApiEdfiAdminV1EdFiConnectionDeletedResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **401** | Unauthorized. The request requires authentication. The OAuth bearer token was either not provided or is invalid. The operation may succeed once authentication has been successfully completed. |  -  |
| **403** | Forbidden. The request cannot be completed in the current authorization context. Contact your administrator if you believe this operation should be allowed. |  -  |
| **500** | An unhandled error occurred on the server.See the response body for details. |  -  |
| **200** | The requested resource was successfully retrieved. |  -  |
| **400** | Bad Request. The request was invalid and cannot be completed. See the response body for specific validation errors. This will typically be an issue with the query parameters or the request body values. |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getedficonnectionbyid"></a>
# **GetEdFiConnectionById**
> EdfiAdminApiEdfiAdminV1EdFiConnection GetEdFiConnectionById (Guid tenantId, Guid connectionId, string? apiVersion = null, string? xVersion = null)

Retrieves an Ed-Fi Connection by ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.EdFiAdmin.Client.Api;
using EdGraph.EdFiAdmin.Client.Client;
using EdGraph.EdFiAdmin.Client.Model;

namespace Example
{
    public class GetEdFiConnectionByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.dev.edgraph.com/tenant";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConnectionsApi(config);
            var tenantId = "tenantId_example";  // Guid | 
            var connectionId = "connectionId_example";  // Guid | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 

            try
            {
                // Retrieves an Ed-Fi Connection by ID.
                EdfiAdminApiEdfiAdminV1EdFiConnection result = apiInstance.GetEdFiConnectionById(tenantId, connectionId, apiVersion, xVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConnectionsApi.GetEdFiConnectionById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEdFiConnectionByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves an Ed-Fi Connection by ID.
    ApiResponse<EdfiAdminApiEdfiAdminV1EdFiConnection> response = apiInstance.GetEdFiConnectionByIdWithHttpInfo(tenantId, connectionId, apiVersion, xVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConnectionsApi.GetEdFiConnectionByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **Guid** |  |  |
| **connectionId** | **Guid** |  |  |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |

### Return type

[**EdfiAdminApiEdfiAdminV1EdFiConnection**](EdfiAdminApiEdfiAdminV1EdFiConnection.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **401** | Unauthorized. The request requires authentication. The OAuth bearer token was either not provided or is invalid. The operation may succeed once authentication has been successfully completed. |  -  |
| **403** | Forbidden. The request cannot be completed in the current authorization context. Contact your administrator if you believe this operation should be allowed. |  -  |
| **500** | An unhandled error occurred on the server.See the response body for details. |  -  |
| **200** | The requested resource was successfully retrieved. |  -  |
| **400** | Bad Request. The request was invalid and cannot be completed. See the response body for specific validation errors. This will typically be an issue with the query parameters or the request body values. |  -  |
| **404** | The resource could not be found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getedficonnectionsasync"></a>
# **GetEdFiConnectionsAsync**
> EdfiAdminApiEdfiAdminV1EdFiConnectionPaginatedItemsResponse GetEdFiConnectionsAsync (string tenantId, int? pageSize = null, int? pageIndex = null, string? orderBy = null, string? filter = null, string? apiVersion = null, string? xVersion = null)

Retrieves a list of Ed-Fi Connections.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.EdFiAdmin.Client.Api;
using EdGraph.EdFiAdmin.Client.Client;
using EdGraph.EdFiAdmin.Client.Model;

namespace Example
{
    public class GetEdFiConnectionsAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.dev.edgraph.com/tenant";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConnectionsApi(config);
            var tenantId = "tenantId_example";  // string | 
            var pageSize = 10;  // int? |  (optional)  (default to 10)
            var pageIndex = 0;  // int? |  (optional)  (default to 0)
            var orderBy = "\"\"";  // string? |  (optional)  (default to "")
            var filter = "\"\"";  // string? |  (optional)  (default to "")
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 

            try
            {
                // Retrieves a list of Ed-Fi Connections.
                EdfiAdminApiEdfiAdminV1EdFiConnectionPaginatedItemsResponse result = apiInstance.GetEdFiConnectionsAsync(tenantId, pageSize, pageIndex, orderBy, filter, apiVersion, xVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConnectionsApi.GetEdFiConnectionsAsync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEdFiConnectionsAsyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a list of Ed-Fi Connections.
    ApiResponse<EdfiAdminApiEdfiAdminV1EdFiConnectionPaginatedItemsResponse> response = apiInstance.GetEdFiConnectionsAsyncWithHttpInfo(tenantId, pageSize, pageIndex, orderBy, filter, apiVersion, xVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConnectionsApi.GetEdFiConnectionsAsyncWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **pageSize** | **int?** |  | [optional] [default to 10] |
| **pageIndex** | **int?** |  | [optional] [default to 0] |
| **orderBy** | **string?** |  | [optional] [default to &quot;&quot;] |
| **filter** | **string?** |  | [optional] [default to &quot;&quot;] |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |

### Return type

[**EdfiAdminApiEdfiAdminV1EdFiConnectionPaginatedItemsResponse**](EdfiAdminApiEdfiAdminV1EdFiConnectionPaginatedItemsResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **401** | Unauthorized. The request requires authentication. The OAuth bearer token was either not provided or is invalid. The operation may succeed once authentication has been successfully completed. |  -  |
| **403** | Forbidden. The request cannot be completed in the current authorization context. Contact your administrator if you believe this operation should be allowed. |  -  |
| **500** | An unhandled error occurred on the server.See the response body for details. |  -  |
| **200** | The requested resource was successfully retrieved. |  -  |
| **400** | Bad Request. The request was invalid and cannot be completed. See the response body for specific validation errors. This will typically be an issue with the query parameters or the request body values. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getedfiodsbackupcodesdescriptorsasync"></a>
# **GetEdFiOdsBackupCodesDescriptorsAsync**
> EdfiAdminApiEdfiAdminV1EdFiOdsBackupDescriptorsPaginatedItemsResponse GetEdFiOdsBackupCodesDescriptorsAsync (string tenantId, int? pageSize = null, int? pageIndex = null, string? orderBy = null, string? filter = null, string? apiVersion = null, string? xVersion = null)

Retrieves a list of Ed-Fi ODS backup codes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.EdFiAdmin.Client.Api;
using EdGraph.EdFiAdmin.Client.Client;
using EdGraph.EdFiAdmin.Client.Model;

namespace Example
{
    public class GetEdFiOdsBackupCodesDescriptorsAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.dev.edgraph.com/tenant";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConnectionsApi(config);
            var tenantId = "tenantId_example";  // string | 
            var pageSize = 10;  // int? |  (optional)  (default to 10)
            var pageIndex = 0;  // int? |  (optional)  (default to 0)
            var orderBy = "\"\"";  // string? |  (optional)  (default to "")
            var filter = "\"\"";  // string? |  (optional)  (default to "")
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 

            try
            {
                // Retrieves a list of Ed-Fi ODS backup codes.
                EdfiAdminApiEdfiAdminV1EdFiOdsBackupDescriptorsPaginatedItemsResponse result = apiInstance.GetEdFiOdsBackupCodesDescriptorsAsync(tenantId, pageSize, pageIndex, orderBy, filter, apiVersion, xVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConnectionsApi.GetEdFiOdsBackupCodesDescriptorsAsync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEdFiOdsBackupCodesDescriptorsAsyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a list of Ed-Fi ODS backup codes.
    ApiResponse<EdfiAdminApiEdfiAdminV1EdFiOdsBackupDescriptorsPaginatedItemsResponse> response = apiInstance.GetEdFiOdsBackupCodesDescriptorsAsyncWithHttpInfo(tenantId, pageSize, pageIndex, orderBy, filter, apiVersion, xVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConnectionsApi.GetEdFiOdsBackupCodesDescriptorsAsyncWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **pageSize** | **int?** |  | [optional] [default to 10] |
| **pageIndex** | **int?** |  | [optional] [default to 0] |
| **orderBy** | **string?** |  | [optional] [default to &quot;&quot;] |
| **filter** | **string?** |  | [optional] [default to &quot;&quot;] |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |

### Return type

[**EdfiAdminApiEdfiAdminV1EdFiOdsBackupDescriptorsPaginatedItemsResponse**](EdfiAdminApiEdfiAdminV1EdFiOdsBackupDescriptorsPaginatedItemsResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **401** | Unauthorized. The request requires authentication. The OAuth bearer token was either not provided or is invalid. The operation may succeed once authentication has been successfully completed. |  -  |
| **403** | Forbidden. The request cannot be completed in the current authorization context. Contact your administrator if you believe this operation should be allowed. |  -  |
| **500** | An unhandled error occurred on the server.See the response body for details. |  -  |
| **200** | The requested resource was successfully retrieved. |  -  |
| **400** | Bad Request. The request was invalid and cannot be completed. See the response body for specific validation errors. This will typically be an issue with the query parameters or the request body values. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateedficonnection"></a>
# **UpdateEdFiConnection**
> EdfiAdminApiEdfiAdminV1EdFiConnectionUpdatedResponse UpdateEdFiConnection (Guid tenantId, Guid connectionId, string? apiVersion = null, string? xVersion = null, EdfiAdminApiEdfiAdminV1UpdateEdFiConnectionRequest? edfiAdminApiEdfiAdminV1UpdateEdFiConnectionRequest = null)

Updates an Ed-Fi Connection.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.EdFiAdmin.Client.Api;
using EdGraph.EdFiAdmin.Client.Client;
using EdGraph.EdFiAdmin.Client.Model;

namespace Example
{
    public class UpdateEdFiConnectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.dev.edgraph.com/tenant";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConnectionsApi(config);
            var tenantId = "tenantId_example";  // Guid | 
            var connectionId = "connectionId_example";  // Guid | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 
            var edfiAdminApiEdfiAdminV1UpdateEdFiConnectionRequest = new EdfiAdminApiEdfiAdminV1UpdateEdFiConnectionRequest?(); // EdfiAdminApiEdfiAdminV1UpdateEdFiConnectionRequest? |  (optional) 

            try
            {
                // Updates an Ed-Fi Connection.
                EdfiAdminApiEdfiAdminV1EdFiConnectionUpdatedResponse result = apiInstance.UpdateEdFiConnection(tenantId, connectionId, apiVersion, xVersion, edfiAdminApiEdfiAdminV1UpdateEdFiConnectionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConnectionsApi.UpdateEdFiConnection: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateEdFiConnectionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates an Ed-Fi Connection.
    ApiResponse<EdfiAdminApiEdfiAdminV1EdFiConnectionUpdatedResponse> response = apiInstance.UpdateEdFiConnectionWithHttpInfo(tenantId, connectionId, apiVersion, xVersion, edfiAdminApiEdfiAdminV1UpdateEdFiConnectionRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConnectionsApi.UpdateEdFiConnectionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **Guid** |  |  |
| **connectionId** | **Guid** |  |  |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |
| **edfiAdminApiEdfiAdminV1UpdateEdFiConnectionRequest** | [**EdfiAdminApiEdfiAdminV1UpdateEdFiConnectionRequest?**](EdfiAdminApiEdfiAdminV1UpdateEdFiConnectionRequest?.md) |  | [optional]  |

### Return type

[**EdfiAdminApiEdfiAdminV1EdFiConnectionUpdatedResponse**](EdfiAdminApiEdfiAdminV1EdFiConnectionUpdatedResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **401** | Unauthorized. The request requires authentication. The OAuth bearer token was either not provided or is invalid. The operation may succeed once authentication has been successfully completed. |  -  |
| **403** | Forbidden. The request cannot be completed in the current authorization context. Contact your administrator if you believe this operation should be allowed. |  -  |
| **500** | An unhandled error occurred on the server.See the response body for details. |  -  |
| **200** | The requested resource was successfully retrieved. |  -  |
| **400** | Bad Request. The request was invalid and cannot be completed. See the response body for specific validation errors. This will typically be an issue with the query parameters or the request body values. |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

