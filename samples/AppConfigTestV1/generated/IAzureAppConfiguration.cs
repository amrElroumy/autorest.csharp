// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Appconfiguration
{
    using Microsoft.Rest;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// </summary>
    public partial interface IAzureAppConfiguration : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Used to guarantee real-time consistency between requests.
        /// </summary>
        string SyncToken { get; set; }

        /// <summary>
        /// The API version to be used with the HTTP request.
        /// </summary>
        string ApiVersion { get; set; }

        /// <summary>
        /// The endpoint of the App Configuration instance to send requests to.
        /// </summary>
        string Endpoint { get; set; }


        /// <summary>
        /// Gets a list of keys.
        /// </summary>
        /// <param name='name'>
        /// A filter for the name of the returned keys.
        /// </param>
        /// <param name='after'>
        /// Instructs the server to return elements that appear after the
        /// element referred to by the specified token.
        /// </param>
        /// <param name='acceptDatetime'>
        /// Requests the server to respond with the state of the resource at
        /// the specified time.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<KeyListResult,GetKeysHeaders>> GetKeysWithHttpMessagesAsync(string name = default(string), string after = default(string), string acceptDatetime = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Requests the headers and status of the given resource.
        /// </summary>
        /// <param name='name'>
        /// A filter for the name of the returned keys.
        /// </param>
        /// <param name='after'>
        /// Instructs the server to return elements that appear after the
        /// element referred to by the specified token.
        /// </param>
        /// <param name='acceptDatetime'>
        /// Requests the server to respond with the state of the resource at
        /// the specified time.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationHeaderResponse<CheckKeysHeaders>> CheckKeysWithHttpMessagesAsync(string name = default(string), string after = default(string), string acceptDatetime = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets a list of key-values.
        /// </summary>
        /// <param name='key'>
        /// A filter used to match keys.
        /// </param>
        /// <param name='label'>
        /// A filter used to match labels
        /// </param>
        /// <param name='after'>
        /// Instructs the server to return elements that appear after the
        /// element referred to by the specified token.
        /// </param>
        /// <param name='acceptDatetime'>
        /// Requests the server to respond with the state of the resource at
        /// the specified time.
        /// </param>
        /// <param name='select'>
        /// Used to select what fields are present in the returned resource(s).
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<KeyValueListResult,GetKeyValuesHeaders>> GetKeyValuesWithHttpMessagesAsync(string key = default(string), string label = default(string), string after = default(string), string acceptDatetime = default(string), IList<string> select = default(IList<string>), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Requests the headers and status of the given resource.
        /// </summary>
        /// <param name='key'>
        /// A filter used to match keys.
        /// </param>
        /// <param name='label'>
        /// A filter used to match labels
        /// </param>
        /// <param name='after'>
        /// Instructs the server to return elements that appear after the
        /// element referred to by the specified token.
        /// </param>
        /// <param name='acceptDatetime'>
        /// Requests the server to respond with the state of the resource at
        /// the specified time.
        /// </param>
        /// <param name='select'>
        /// Used to select what fields are present in the returned resource(s).
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationHeaderResponse<CheckKeyValuesHeaders>> CheckKeyValuesWithHttpMessagesAsync(string key = default(string), string label = default(string), string after = default(string), string acceptDatetime = default(string), IList<string> select = default(IList<string>), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets a single key-value.
        /// </summary>
        /// <param name='key'>
        /// The key of the key-value to retrieve.
        /// </param>
        /// <param name='label'>
        /// The label of the key-value to retrieve.
        /// </param>
        /// <param name='acceptDatetime'>
        /// Requests the server to respond with the state of the resource at
        /// the specified time.
        /// </param>
        /// <param name='ifMatch'>
        /// Used to perform an operation only if the targeted resource's etag
        /// matches the value provided.
        /// </param>
        /// <param name='ifNoneMatch'>
        /// Used to perform an operation only if the targeted resource's etag
        /// does not match the value provided.
        /// </param>
        /// <param name='select'>
        /// Used to select what fields are present in the returned resource(s).
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<KeyValue,GetKeyValueHeaders>> GetKeyValueWithHttpMessagesAsync(string key, string label = default(string), string acceptDatetime = default(string), string ifMatch = default(string), string ifNoneMatch = default(string), IList<string> select = default(IList<string>), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates a key-value.
        /// </summary>
        /// <param name='key'>
        /// The key of the key-value to create.
        /// </param>
        /// <param name='label'>
        /// The label of the key-value to create.
        /// </param>
        /// <param name='entity'>
        /// The key-value to create.
        /// </param>
        /// <param name='ifMatch'>
        /// Used to perform an operation only if the targeted resource's etag
        /// matches the value provided.
        /// </param>
        /// <param name='ifNoneMatch'>
        /// Used to perform an operation only if the targeted resource's etag
        /// does not match the value provided.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<KeyValue,PutKeyValueHeaders>> PutKeyValueWithHttpMessagesAsync(string key, string label = default(string), KeyValue entity = default(KeyValue), string ifMatch = default(string), string ifNoneMatch = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes a key-value.
        /// </summary>
        /// <param name='key'>
        /// The key of the key-value to delete.
        /// </param>
        /// <param name='label'>
        /// The label of the key-value to delete.
        /// </param>
        /// <param name='ifMatch'>
        /// Used to perform an operation only if the targeted resource's etag
        /// matches the value provided.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<KeyValue,DeleteKeyValueHeaders>> DeleteKeyValueWithHttpMessagesAsync(string key, string label = default(string), string ifMatch = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Requests the headers and status of the given resource.
        /// </summary>
        /// <param name='key'>
        /// The key of the key-value to retrieve.
        /// </param>
        /// <param name='label'>
        /// The label of the key-value to retrieve.
        /// </param>
        /// <param name='acceptDatetime'>
        /// Requests the server to respond with the state of the resource at
        /// the specified time.
        /// </param>
        /// <param name='ifMatch'>
        /// Used to perform an operation only if the targeted resource's etag
        /// matches the value provided.
        /// </param>
        /// <param name='ifNoneMatch'>
        /// Used to perform an operation only if the targeted resource's etag
        /// does not match the value provided.
        /// </param>
        /// <param name='select'>
        /// Used to select what fields are present in the returned resource(s).
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationHeaderResponse<CheckKeyValueHeaders>> CheckKeyValueWithHttpMessagesAsync(string key, string label = default(string), string acceptDatetime = default(string), string ifMatch = default(string), string ifNoneMatch = default(string), IList<string> select = default(IList<string>), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets a list of labels.
        /// </summary>
        /// <param name='name'>
        /// A filter for the name of the returned labels.
        /// </param>
        /// <param name='after'>
        /// Instructs the server to return elements that appear after the
        /// element referred to by the specified token.
        /// </param>
        /// <param name='acceptDatetime'>
        /// Requests the server to respond with the state of the resource at
        /// the specified time.
        /// </param>
        /// <param name='select'>
        /// Used to select what fields are present in the returned resource(s).
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<LabelListResult,GetLabelsHeaders>> GetLabelsWithHttpMessagesAsync(string name = default(string), string after = default(string), string acceptDatetime = default(string), IList<string> select = default(IList<string>), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Requests the headers and status of the given resource.
        /// </summary>
        /// <param name='name'>
        /// A filter for the name of the returned labels.
        /// </param>
        /// <param name='after'>
        /// Instructs the server to return elements that appear after the
        /// element referred to by the specified token.
        /// </param>
        /// <param name='acceptDatetime'>
        /// Requests the server to respond with the state of the resource at
        /// the specified time.
        /// </param>
        /// <param name='select'>
        /// Used to select what fields are present in the returned resource(s).
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationHeaderResponse<CheckLabelsHeaders>> CheckLabelsWithHttpMessagesAsync(string name = default(string), string after = default(string), string acceptDatetime = default(string), IList<string> select = default(IList<string>), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Locks a key-value.
        /// </summary>
        /// <param name='key'>
        /// The key of the key-value to lock.
        /// </param>
        /// <param name='label'>
        /// The label, if any, of the key-value to lock.
        /// </param>
        /// <param name='ifMatch'>
        /// Used to perform an operation only if the targeted resource's etag
        /// matches the value provided.
        /// </param>
        /// <param name='ifNoneMatch'>
        /// Used to perform an operation only if the targeted resource's etag
        /// does not match the value provided.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<KeyValue,PutLockHeaders>> PutLockWithHttpMessagesAsync(string key, string label = default(string), string ifMatch = default(string), string ifNoneMatch = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Unlocks a key-value.
        /// </summary>
        /// <param name='key'>
        /// The key of the key-value to unlock.
        /// </param>
        /// <param name='label'>
        /// The label, if any, of the key-value to unlock.
        /// </param>
        /// <param name='ifMatch'>
        /// Used to perform an operation only if the targeted resource's etag
        /// matches the value provided.
        /// </param>
        /// <param name='ifNoneMatch'>
        /// Used to perform an operation only if the targeted resource's etag
        /// does not match the value provided.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<KeyValue,DeleteLockHeaders>> DeleteLockWithHttpMessagesAsync(string key, string label = default(string), string ifMatch = default(string), string ifNoneMatch = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets a list of key-value revisions.
        /// </summary>
        /// <param name='key'>
        /// A filter used to match keys.
        /// </param>
        /// <param name='label'>
        /// A filter used to match labels
        /// </param>
        /// <param name='after'>
        /// Instructs the server to return elements that appear after the
        /// element referred to by the specified token.
        /// </param>
        /// <param name='acceptDatetime'>
        /// Requests the server to respond with the state of the resource at
        /// the specified time.
        /// </param>
        /// <param name='select'>
        /// Used to select what fields are present in the returned resource(s).
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<KeyValueListResult,GetRevisionsHeaders>> GetRevisionsWithHttpMessagesAsync(string key = default(string), string label = default(string), string after = default(string), string acceptDatetime = default(string), IList<string> select = default(IList<string>), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Requests the headers and status of the given resource.
        /// </summary>
        /// <param name='key'>
        /// A filter used to match keys.
        /// </param>
        /// <param name='label'>
        /// A filter used to match labels
        /// </param>
        /// <param name='after'>
        /// Instructs the server to return elements that appear after the
        /// element referred to by the specified token.
        /// </param>
        /// <param name='acceptDatetime'>
        /// Requests the server to respond with the state of the resource at
        /// the specified time.
        /// </param>
        /// <param name='select'>
        /// Used to select what fields are present in the returned resource(s).
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationHeaderResponse<CheckRevisionsHeaders>> CheckRevisionsWithHttpMessagesAsync(string key = default(string), string label = default(string), string after = default(string), string acceptDatetime = default(string), IList<string> select = default(IList<string>), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

    }
}