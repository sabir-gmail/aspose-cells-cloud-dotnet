/* 
 * Web API Swagger specification
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Model;

namespace Aspose.Cells.Cloud.SDK.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICellsTaskApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Run tasks  
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Cells.Cloud.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskData"></param>
        /// <returns>System.IO.Stream</returns>
        System.IO.Stream CellsTaskPostRunTask (TaskData taskData);

        /// <summary>
        /// Run tasks  
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Cells.Cloud.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskData"></param>
        /// <returns>ApiResponse of System.IO.Stream</returns>
        ApiResponse<System.IO.Stream> CellsTaskPostRunTaskWithHttpInfo (TaskData taskData);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Run tasks  
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Cells.Cloud.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskData"></param>
        /// <returns>Task of System.IO.Stream</returns>
        System.Threading.Tasks.Task<System.IO.Stream> CellsTaskPostRunTaskAsync (TaskData taskData);

        /// <summary>
        /// Run tasks  
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Cells.Cloud.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskData"></param>
        /// <returns>Task of ApiResponse (System.IO.Stream)</returns>
        System.Threading.Tasks.Task<ApiResponse<System.IO.Stream>> CellsTaskPostRunTaskAsyncWithHttpInfo (TaskData taskData);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class CellsTaskApi : ICellsTaskApi
    {
        private Aspose.Cells.Cloud.SDK.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="CellsTaskApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CellsTaskApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = Aspose.Cells.Cloud.SDK.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CellsTaskApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CellsTaskApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Aspose.Cells.Cloud.SDK.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Aspose.Cells.Cloud.SDK.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Run tasks   
        /// </summary>
        /// <exception cref="Aspose.Cells.Cloud.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskData"></param>
        /// <returns>System.IO.Stream</returns>
        public System.IO.Stream CellsTaskPostRunTask (TaskData taskData)
        {
             ApiResponse<System.IO.Stream> localVarResponse = CellsTaskPostRunTaskWithHttpInfo(taskData);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Run tasks   
        /// </summary>
        /// <exception cref="Aspose.Cells.Cloud.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskData"></param>
        /// <returns>ApiResponse of System.IO.Stream</returns>
        public ApiResponse< System.IO.Stream > CellsTaskPostRunTaskWithHttpInfo (TaskData taskData)
        {
            // verify the required parameter 'taskData' is set
            if (taskData == null)
                throw new ApiException(400, "Missing required parameter 'taskData' when calling CellsTaskApi->CellsTaskPostRunTask");

            var localVarPath = "/cells/task/runtask";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (taskData != null && taskData.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(taskData); // http body (model) parameter
            }
            else
            {
                localVarPostBody = taskData; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CellsTaskPostRunTask", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<System.IO.Stream>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (System.IO.Stream) Configuration.ApiClient.Deserialize(localVarResponse, typeof(System.IO.Stream)));
        }

        /// <summary>
        /// Run tasks   
        /// </summary>
        /// <exception cref="Aspose.Cells.Cloud.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskData"></param>
        /// <returns>Task of System.IO.Stream</returns>
        public async System.Threading.Tasks.Task<System.IO.Stream> CellsTaskPostRunTaskAsync (TaskData taskData)
        {
             ApiResponse<System.IO.Stream> localVarResponse = await CellsTaskPostRunTaskAsyncWithHttpInfo(taskData);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Run tasks   
        /// </summary>
        /// <exception cref="Aspose.Cells.Cloud.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="taskData"></param>
        /// <returns>Task of ApiResponse (System.IO.Stream)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<System.IO.Stream>> CellsTaskPostRunTaskAsyncWithHttpInfo (TaskData taskData)
        {
            // verify the required parameter 'taskData' is set
            if (taskData == null)
                throw new ApiException(400, "Missing required parameter 'taskData' when calling CellsTaskApi->CellsTaskPostRunTask");

            var localVarPath = "/cells/task/runtask";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (taskData != null && taskData.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(taskData); // http body (model) parameter
            }
            else
            {
                localVarPostBody = taskData; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CellsTaskPostRunTask", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<System.IO.Stream>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (System.IO.Stream) Configuration.ApiClient.Deserialize(localVarResponse, typeof(System.IO.Stream)));
        }

    }
}
