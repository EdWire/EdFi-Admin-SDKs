# EdGraph.EdFiAdmin.Client.Api.ClaimsetsApi

All URIs are relative to *http://localhost/edfi-admin/v1.3/districtspecific*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**V1ClaimsetsGet**](ClaimsetsApi.md#v1claimsetsget) | **GET** /v1/claimsets | Retrieves all claimsets. |
| [**V1ClaimsetsIdDelete**](ClaimsetsApi.md#v1claimsetsiddelete) | **DELETE** /v1/claimsets/{id} | Deletes an existing claimset using the resource identifier. |
| [**V1ClaimsetsIdGet**](ClaimsetsApi.md#v1claimsetsidget) | **GET** /v1/claimsets/{id} | Retrieves a specific claimset based on the identifier. |
| [**V1ClaimsetsIdPut**](ClaimsetsApi.md#v1claimsetsidput) | **PUT** /v1/claimsets/{id} | Updates claimset based on the resource identifier. |
| [**V1ClaimsetsPost**](ClaimsetsApi.md#v1claimsetspost) | **POST** /v1/claimsets | Creates claimset based on the supplied values. |

<a id="v1claimsetsget"></a>
# **V1ClaimsetsGet**
> List&lt;EdFiOdsAdminApiFeaturesClaimSetsClaimSetModel&gt; V1ClaimsetsGet ()

Retrieves all claimsets.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.EdFiAdmin.Client.Api;
using EdGraph.EdFiAdmin.Client.Client;
using EdGraph.EdFiAdmin.Client.Model;

namespace Example
{
    public class V1ClaimsetsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/edfi-admin/v1.3/districtspecific";
            // Configure OAuth2 access token for authorization: oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ClaimsetsApi(config);

            try
            {
                // Retrieves all claimsets.
                List<EdFiOdsAdminApiFeaturesClaimSetsClaimSetModel> result = apiInstance.V1ClaimsetsGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClaimsetsApi.V1ClaimsetsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1ClaimsetsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves all claimsets.
    ApiResponse<List<EdFiOdsAdminApiFeaturesClaimSetsClaimSetModel>> response = apiInstance.V1ClaimsetsGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClaimsetsApi.V1ClaimsetsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;EdFiOdsAdminApiFeaturesClaimSetsClaimSetModel&gt;**](EdFiOdsAdminApiFeaturesClaimSetsClaimSetModel.md)

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

<a id="v1claimsetsiddelete"></a>
# **V1ClaimsetsIdDelete**
> void V1ClaimsetsIdDelete (int id)

Deletes an existing claimset using the resource identifier.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.EdFiAdmin.Client.Api;
using EdGraph.EdFiAdmin.Client.Client;
using EdGraph.EdFiAdmin.Client.Model;

namespace Example
{
    public class V1ClaimsetsIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/edfi-admin/v1.3/districtspecific";
            // Configure OAuth2 access token for authorization: oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ClaimsetsApi(config);
            var id = 56;  // int | 

            try
            {
                // Deletes an existing claimset using the resource identifier.
                apiInstance.V1ClaimsetsIdDelete(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClaimsetsApi.V1ClaimsetsIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1ClaimsetsIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes an existing claimset using the resource identifier.
    apiInstance.V1ClaimsetsIdDeleteWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClaimsetsApi.V1ClaimsetsIdDeleteWithHttpInfo: " + e.Message);
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

<a id="v1claimsetsidget"></a>
# **V1ClaimsetsIdGet**
> EdFiOdsAdminApiFeaturesClaimSetsClaimSetDetailsModel V1ClaimsetsIdGet (int id)

Retrieves a specific claimset based on the identifier.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.EdFiAdmin.Client.Api;
using EdGraph.EdFiAdmin.Client.Client;
using EdGraph.EdFiAdmin.Client.Model;

namespace Example
{
    public class V1ClaimsetsIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/edfi-admin/v1.3/districtspecific";
            // Configure OAuth2 access token for authorization: oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ClaimsetsApi(config);
            var id = 56;  // int | 

            try
            {
                // Retrieves a specific claimset based on the identifier.
                EdFiOdsAdminApiFeaturesClaimSetsClaimSetDetailsModel result = apiInstance.V1ClaimsetsIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClaimsetsApi.V1ClaimsetsIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1ClaimsetsIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific claimset based on the identifier.
    ApiResponse<EdFiOdsAdminApiFeaturesClaimSetsClaimSetDetailsModel> response = apiInstance.V1ClaimsetsIdGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClaimsetsApi.V1ClaimsetsIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |

### Return type

[**EdFiOdsAdminApiFeaturesClaimSetsClaimSetDetailsModel**](EdFiOdsAdminApiFeaturesClaimSetsClaimSetDetailsModel.md)

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

<a id="v1claimsetsidput"></a>
# **V1ClaimsetsIdPut**
> EdFiOdsAdminApiFeaturesClaimSetsClaimSetDetailsModel V1ClaimsetsIdPut (int id, EdFiOdsAdminApiFeaturesClaimSetsEditClaimSetRequest edFiOdsAdminApiFeaturesClaimSetsEditClaimSetRequest)

Updates claimset based on the resource identifier.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.EdFiAdmin.Client.Api;
using EdGraph.EdFiAdmin.Client.Client;
using EdGraph.EdFiAdmin.Client.Model;

namespace Example
{
    public class V1ClaimsetsIdPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/edfi-admin/v1.3/districtspecific";
            // Configure OAuth2 access token for authorization: oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ClaimsetsApi(config);
            var id = 56;  // int | 
            var edFiOdsAdminApiFeaturesClaimSetsEditClaimSetRequest = new EdFiOdsAdminApiFeaturesClaimSetsEditClaimSetRequest(); // EdFiOdsAdminApiFeaturesClaimSetsEditClaimSetRequest | 

            try
            {
                // Updates claimset based on the resource identifier.
                EdFiOdsAdminApiFeaturesClaimSetsClaimSetDetailsModel result = apiInstance.V1ClaimsetsIdPut(id, edFiOdsAdminApiFeaturesClaimSetsEditClaimSetRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClaimsetsApi.V1ClaimsetsIdPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1ClaimsetsIdPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates claimset based on the resource identifier.
    ApiResponse<EdFiOdsAdminApiFeaturesClaimSetsClaimSetDetailsModel> response = apiInstance.V1ClaimsetsIdPutWithHttpInfo(id, edFiOdsAdminApiFeaturesClaimSetsEditClaimSetRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClaimsetsApi.V1ClaimsetsIdPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |
| **edFiOdsAdminApiFeaturesClaimSetsEditClaimSetRequest** | [**EdFiOdsAdminApiFeaturesClaimSetsEditClaimSetRequest**](EdFiOdsAdminApiFeaturesClaimSetsEditClaimSetRequest.md) |  |  |

### Return type

[**EdFiOdsAdminApiFeaturesClaimSetsClaimSetDetailsModel**](EdFiOdsAdminApiFeaturesClaimSetsClaimSetDetailsModel.md)

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

<a id="v1claimsetspost"></a>
# **V1ClaimsetsPost**
> EdFiOdsAdminApiFeaturesClaimSetsClaimSetDetailsModel V1ClaimsetsPost (EdFiOdsAdminApiFeaturesClaimSetsAddClaimSetRequest edFiOdsAdminApiFeaturesClaimSetsAddClaimSetRequest)

Creates claimset based on the supplied values.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.EdFiAdmin.Client.Api;
using EdGraph.EdFiAdmin.Client.Client;
using EdGraph.EdFiAdmin.Client.Model;

namespace Example
{
    public class V1ClaimsetsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost/edfi-admin/v1.3/districtspecific";
            // Configure OAuth2 access token for authorization: oauth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ClaimsetsApi(config);
            var edFiOdsAdminApiFeaturesClaimSetsAddClaimSetRequest = new EdFiOdsAdminApiFeaturesClaimSetsAddClaimSetRequest(); // EdFiOdsAdminApiFeaturesClaimSetsAddClaimSetRequest | 

            try
            {
                // Creates claimset based on the supplied values.
                EdFiOdsAdminApiFeaturesClaimSetsClaimSetDetailsModel result = apiInstance.V1ClaimsetsPost(edFiOdsAdminApiFeaturesClaimSetsAddClaimSetRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClaimsetsApi.V1ClaimsetsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1ClaimsetsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates claimset based on the supplied values.
    ApiResponse<EdFiOdsAdminApiFeaturesClaimSetsClaimSetDetailsModel> response = apiInstance.V1ClaimsetsPostWithHttpInfo(edFiOdsAdminApiFeaturesClaimSetsAddClaimSetRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClaimsetsApi.V1ClaimsetsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **edFiOdsAdminApiFeaturesClaimSetsAddClaimSetRequest** | [**EdFiOdsAdminApiFeaturesClaimSetsAddClaimSetRequest**](EdFiOdsAdminApiFeaturesClaimSetsAddClaimSetRequest.md) |  |  |

### Return type

[**EdFiOdsAdminApiFeaturesClaimSetsClaimSetDetailsModel**](EdFiOdsAdminApiFeaturesClaimSetsClaimSetDetailsModel.md)

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

