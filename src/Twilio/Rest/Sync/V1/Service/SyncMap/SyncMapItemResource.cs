/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
/// 
/// SyncMapItemResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Types;

namespace Twilio.Rest.Sync.V1.Service.SyncMap 
{

    public class SyncMapItemResource : Resource 
    {
        public sealed class QueryResultOrderEnum : StringEnum 
        {
            private QueryResultOrderEnum(string value) : base(value) {}
            public QueryResultOrderEnum() {}
            public static implicit operator QueryResultOrderEnum(string value)
            {
                return new QueryResultOrderEnum(value);
            }

            public static readonly QueryResultOrderEnum Asc = new QueryResultOrderEnum("asc");
            public static readonly QueryResultOrderEnum Desc = new QueryResultOrderEnum("desc");
        }

        public sealed class QueryFromBoundTypeEnum : StringEnum 
        {
            private QueryFromBoundTypeEnum(string value) : base(value) {}
            public QueryFromBoundTypeEnum() {}
            public static implicit operator QueryFromBoundTypeEnum(string value)
            {
                return new QueryFromBoundTypeEnum(value);
            }

            public static readonly QueryFromBoundTypeEnum Inclusive = new QueryFromBoundTypeEnum("inclusive");
            public static readonly QueryFromBoundTypeEnum Exclusive = new QueryFromBoundTypeEnum("exclusive");
        }

        private static Request BuildFetchRequest(FetchSyncMapItemOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Sync,
                "/v1/Services/" + options.PathServiceSid + "/Maps/" + options.PathMapSid + "/Items/" + options.PathKey + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch SyncMapItem parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SyncMapItem </returns> 
        public static SyncMapItemResource Fetch(FetchSyncMapItemOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch SyncMapItem parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SyncMapItem </returns> 
        public static async System.Threading.Tasks.Task<SyncMapItemResource> FetchAsync(FetchSyncMapItemOptions options, 
                                                                                        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathMapSid"> The map_sid </param>
        /// <param name="pathKey"> The key </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SyncMapItem </returns> 
        public static SyncMapItemResource Fetch(string pathServiceSid, 
                                                string pathMapSid, 
                                                string pathKey, 
                                                ITwilioRestClient client = null)
        {
            var options = new FetchSyncMapItemOptions(pathServiceSid, pathMapSid, pathKey);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathMapSid"> The map_sid </param>
        /// <param name="pathKey"> The key </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SyncMapItem </returns> 
        public static async System.Threading.Tasks.Task<SyncMapItemResource> FetchAsync(string pathServiceSid, 
                                                                                        string pathMapSid, 
                                                                                        string pathKey, 
                                                                                        ITwilioRestClient client = null)
        {
            var options = new FetchSyncMapItemOptions(pathServiceSid, pathMapSid, pathKey);
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildDeleteRequest(DeleteSyncMapItemOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Sync,
                "/v1/Services/" + options.PathServiceSid + "/Maps/" + options.PathMapSid + "/Items/" + options.PathKey + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// delete
        /// </summary>
        /// <param name="options"> Delete SyncMapItem parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SyncMapItem </returns> 
        public static bool Delete(DeleteSyncMapItemOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary>
        /// delete
        /// </summary>
        /// <param name="options"> Delete SyncMapItem parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SyncMapItem </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteSyncMapItemOptions options, 
                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary>
        /// delete
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathMapSid"> The map_sid </param>
        /// <param name="pathKey"> The key </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SyncMapItem </returns> 
        public static bool Delete(string pathServiceSid, string pathMapSid, string pathKey, ITwilioRestClient client = null)
        {
            var options = new DeleteSyncMapItemOptions(pathServiceSid, pathMapSid, pathKey);
            return Delete(options, client);
        }

        #if !NET35
        /// <summary>
        /// delete
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathMapSid"> The map_sid </param>
        /// <param name="pathKey"> The key </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SyncMapItem </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathServiceSid, 
                                                                          string pathMapSid, 
                                                                          string pathKey, 
                                                                          ITwilioRestClient client = null)
        {
            var options = new DeleteSyncMapItemOptions(pathServiceSid, pathMapSid, pathKey);
            return await DeleteAsync(options, client);
        }
        #endif

        private static Request BuildCreateRequest(CreateSyncMapItemOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Sync,
                "/v1/Services/" + options.PathServiceSid + "/Maps/" + options.PathMapSid + "/Items",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// create
        /// </summary>
        /// <param name="options"> Create SyncMapItem parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SyncMapItem </returns> 
        public static SyncMapItemResource Create(CreateSyncMapItemOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        /// <param name="options"> Create SyncMapItem parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SyncMapItem </returns> 
        public static async System.Threading.Tasks.Task<SyncMapItemResource> CreateAsync(CreateSyncMapItemOptions options, 
                                                                                         ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// create
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathMapSid"> The map_sid </param>
        /// <param name="key"> The unique user-defined key of this Map Item. </param>
        /// <param name="data"> Contains arbitrary user-defined, schema-less data that this Map Item stores, represented by a
        ///            JSON object, up to 16KB. </param>
        /// <param name="ttl"> Alias for item_ttl </param>
        /// <param name="itemTtl"> Time-to-live of this item in seconds, defaults to no expiration. </param>
        /// <param name="collectionTtl"> Time-to-live of this item's parent Map in seconds, defaults to no expiration. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SyncMapItem </returns> 
        public static SyncMapItemResource Create(string pathServiceSid, 
                                                 string pathMapSid, 
                                                 string key, 
                                                 object data, 
                                                 int? ttl = null, 
                                                 int? itemTtl = null, 
                                                 int? collectionTtl = null, 
                                                 ITwilioRestClient client = null)
        {
            var options = new CreateSyncMapItemOptions(pathServiceSid, pathMapSid, key, data){Ttl = ttl, ItemTtl = itemTtl, CollectionTtl = collectionTtl};
            return Create(options, client);
        }

        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathMapSid"> The map_sid </param>
        /// <param name="key"> The unique user-defined key of this Map Item. </param>
        /// <param name="data"> Contains arbitrary user-defined, schema-less data that this Map Item stores, represented by a
        ///            JSON object, up to 16KB. </param>
        /// <param name="ttl"> Alias for item_ttl </param>
        /// <param name="itemTtl"> Time-to-live of this item in seconds, defaults to no expiration. </param>
        /// <param name="collectionTtl"> Time-to-live of this item's parent Map in seconds, defaults to no expiration. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SyncMapItem </returns> 
        public static async System.Threading.Tasks.Task<SyncMapItemResource> CreateAsync(string pathServiceSid, 
                                                                                         string pathMapSid, 
                                                                                         string key, 
                                                                                         object data, 
                                                                                         int? ttl = null, 
                                                                                         int? itemTtl = null, 
                                                                                         int? collectionTtl = null, 
                                                                                         ITwilioRestClient client = null)
        {
            var options = new CreateSyncMapItemOptions(pathServiceSid, pathMapSid, key, data){Ttl = ttl, ItemTtl = itemTtl, CollectionTtl = collectionTtl};
            return await CreateAsync(options, client);
        }
        #endif

        private static Request BuildReadRequest(ReadSyncMapItemOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Sync,
                "/v1/Services/" + options.PathServiceSid + "/Maps/" + options.PathMapSid + "/Items",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// read
        /// </summary>
        /// <param name="options"> Read SyncMapItem parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SyncMapItem </returns> 
        public static ResourceSet<SyncMapItemResource> Read(ReadSyncMapItemOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<SyncMapItemResource>.FromJson("items", response.Content);
            return new ResourceSet<SyncMapItemResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        /// <param name="options"> Read SyncMapItem parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SyncMapItem </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<SyncMapItemResource>> ReadAsync(ReadSyncMapItemOptions options, 
                                                                                                    ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<SyncMapItemResource>.FromJson("items", response.Content);
            return new ResourceSet<SyncMapItemResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// read
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathMapSid"> The map_sid </param>
        /// <param name="order"> A string; asc or desc. Map Items are ordered lexicographically by Item key. </param>
        /// <param name="from"> The Item key offset (including the specified key). </param>
        /// <param name="bounds"> The bounds </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SyncMapItem </returns> 
        public static ResourceSet<SyncMapItemResource> Read(string pathServiceSid, 
                                                            string pathMapSid, 
                                                            SyncMapItemResource.QueryResultOrderEnum order = null, 
                                                            string from = null, 
                                                            SyncMapItemResource.QueryFromBoundTypeEnum bounds = null, 
                                                            int? pageSize = null, 
                                                            long? limit = null, 
                                                            ITwilioRestClient client = null)
        {
            var options = new ReadSyncMapItemOptions(pathServiceSid, pathMapSid){Order = order, From = from, Bounds = bounds, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathMapSid"> The map_sid </param>
        /// <param name="order"> A string; asc or desc. Map Items are ordered lexicographically by Item key. </param>
        /// <param name="from"> The Item key offset (including the specified key). </param>
        /// <param name="bounds"> The bounds </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SyncMapItem </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<SyncMapItemResource>> ReadAsync(string pathServiceSid, 
                                                                                                    string pathMapSid, 
                                                                                                    SyncMapItemResource.QueryResultOrderEnum order = null, 
                                                                                                    string from = null, 
                                                                                                    SyncMapItemResource.QueryFromBoundTypeEnum bounds = null, 
                                                                                                    int? pageSize = null, 
                                                                                                    long? limit = null, 
                                                                                                    ITwilioRestClient client = null)
        {
            var options = new ReadSyncMapItemOptions(pathServiceSid, pathMapSid){Order = order, From = from, Bounds = bounds, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns> 
        public static Page<SyncMapItemResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<SyncMapItemResource>.FromJson("items", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns> 
        public static Page<SyncMapItemResource> NextPage(Page<SyncMapItemResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Sync,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<SyncMapItemResource>.FromJson("items", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns> 
        public static Page<SyncMapItemResource> PreviousPage(Page<SyncMapItemResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(
                    Rest.Domain.Sync,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<SyncMapItemResource>.FromJson("items", response.Content);
        }

        private static Request BuildUpdateRequest(UpdateSyncMapItemOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Sync,
                "/v1/Services/" + options.PathServiceSid + "/Maps/" + options.PathMapSid + "/Items/" + options.PathKey + "",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// update
        /// </summary>
        /// <param name="options"> Update SyncMapItem parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SyncMapItem </returns> 
        public static SyncMapItemResource Update(UpdateSyncMapItemOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// update
        /// </summary>
        /// <param name="options"> Update SyncMapItem parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SyncMapItem </returns> 
        public static async System.Threading.Tasks.Task<SyncMapItemResource> UpdateAsync(UpdateSyncMapItemOptions options, 
                                                                                         ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// update
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathMapSid"> The map_sid </param>
        /// <param name="pathKey"> The key </param>
        /// <param name="data"> Contains an arbitrary JSON object to be stored in this Map Item. </param>
        /// <param name="ttl"> Alias for item_ttl </param>
        /// <param name="itemTtl"> Time-to-live of this item in seconds, defaults to no expiration. </param>
        /// <param name="collectionTtl"> Time-to-live of this item's parent Map in seconds, defaults to no expiration. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SyncMapItem </returns> 
        public static SyncMapItemResource Update(string pathServiceSid, 
                                                 string pathMapSid, 
                                                 string pathKey, 
                                                 object data = null, 
                                                 int? ttl = null, 
                                                 int? itemTtl = null, 
                                                 int? collectionTtl = null, 
                                                 ITwilioRestClient client = null)
        {
            var options = new UpdateSyncMapItemOptions(pathServiceSid, pathMapSid, pathKey){Data = data, Ttl = ttl, ItemTtl = itemTtl, CollectionTtl = collectionTtl};
            return Update(options, client);
        }

        #if !NET35
        /// <summary>
        /// update
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathMapSid"> The map_sid </param>
        /// <param name="pathKey"> The key </param>
        /// <param name="data"> Contains an arbitrary JSON object to be stored in this Map Item. </param>
        /// <param name="ttl"> Alias for item_ttl </param>
        /// <param name="itemTtl"> Time-to-live of this item in seconds, defaults to no expiration. </param>
        /// <param name="collectionTtl"> Time-to-live of this item's parent Map in seconds, defaults to no expiration. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SyncMapItem </returns> 
        public static async System.Threading.Tasks.Task<SyncMapItemResource> UpdateAsync(string pathServiceSid, 
                                                                                         string pathMapSid, 
                                                                                         string pathKey, 
                                                                                         object data = null, 
                                                                                         int? ttl = null, 
                                                                                         int? itemTtl = null, 
                                                                                         int? collectionTtl = null, 
                                                                                         ITwilioRestClient client = null)
        {
            var options = new UpdateSyncMapItemOptions(pathServiceSid, pathMapSid, pathKey){Data = data, Ttl = ttl, ItemTtl = itemTtl, CollectionTtl = collectionTtl};
            return await UpdateAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a SyncMapItemResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> SyncMapItemResource object represented by the provided JSON </returns> 
        public static SyncMapItemResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<SyncMapItemResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The unique user-defined key of this Map Item.
        /// </summary>
        [JsonProperty("key")]
        public string Key { get; private set; }
        /// <summary>
        /// The unique SID identifier of the Twilio Account.
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The unique SID identifier of the Service Instance that hosts this Map object.
        /// </summary>
        [JsonProperty("service_sid")]
        public string ServiceSid { get; private set; }
        /// <summary>
        /// The unique 34-character SID identifier of the Map containing this Item.
        /// </summary>
        [JsonProperty("map_sid")]
        public string MapSid { get; private set; }
        /// <summary>
        /// The absolute URL for this Map.
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }
        /// <summary>
        /// Contains the current revision of this Map, represented by a string identifier.
        /// </summary>
        [JsonProperty("revision")]
        public string Revision { get; private set; }
        /// <summary>
        /// Contains arbitrary user-defined, schema-less data that this Map Item stores, represented by a JSON object, up to 16KB.
        /// </summary>
        [JsonProperty("data")]
        public object Data { get; private set; }
        /// <summary>
        /// Contains the date this Map expires and gets deleted automatically.
        /// </summary>
        [JsonProperty("date_expires")]
        public DateTime? DateExpires { get; private set; }
        /// <summary>
        /// The date this Map was created, given in UTC ISO 8601 format.
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// Specifies the date this Map was last updated, given in UTC ISO 8601 format.
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// The identity of the Map creator.
        /// </summary>
        [JsonProperty("created_by")]
        public string CreatedBy { get; private set; }

        private SyncMapItemResource()
        {

        }
    }

}