/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
/// currently do not have developer preview access, please contact help@twilio.com.
/// 
/// FormResource
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

namespace Twilio.Rest.Authy.V1 
{

    public class FormResource : Resource 
    {
        public sealed class FormTypeEnum : StringEnum 
        {
            private FormTypeEnum(string value) : base(value) {}
            public FormTypeEnum() {}
            public static implicit operator FormTypeEnum(string value)
            {
                return new FormTypeEnum(value);
            }

            public static readonly FormTypeEnum FormAppPush = new FormTypeEnum("form-app-push");
            public static readonly FormTypeEnum FormSms = new FormTypeEnum("form-sms");
            public static readonly FormTypeEnum FormTotp = new FormTypeEnum("form-totp");
        }

        private static Request BuildFetchRequest(FetchFormOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Authy,
                "/v1/Forms/" + options.PathFormType + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// Fetch the forms for a specific form type.
        /// </summary>
        /// <param name="options"> Fetch Form parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Form </returns> 
        public static FormResource Fetch(FetchFormOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Fetch the forms for a specific form type.
        /// </summary>
        /// <param name="options"> Fetch Form parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Form </returns> 
        public static async System.Threading.Tasks.Task<FormResource> FetchAsync(FetchFormOptions options, 
                                                                                 ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Fetch the forms for a specific form type.
        /// </summary>
        /// <param name="pathFormType"> The Form Type of this Form </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Form </returns> 
        public static FormResource Fetch(FormResource.FormTypeEnum pathFormType, ITwilioRestClient client = null)
        {
            var options = new FetchFormOptions(pathFormType);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// Fetch the forms for a specific form type.
        /// </summary>
        /// <param name="pathFormType"> The Form Type of this Form </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Form </returns> 
        public static async System.Threading.Tasks.Task<FormResource> FetchAsync(FormResource.FormTypeEnum pathFormType, 
                                                                                 ITwilioRestClient client = null)
        {
            var options = new FetchFormOptions(pathFormType);
            return await FetchAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a FormResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> FormResource object represented by the provided JSON </returns> 
        public static FormResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<FormResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The Form Type of this Form
        /// </summary>
        [JsonProperty("form_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public FormResource.FormTypeEnum FormType { get; private set; }
        /// <summary>
        /// Object that contains the available forms for this form type.
        /// </summary>
        [JsonProperty("forms")]
        public object Forms { get; private set; }
        /// <summary>
        /// Additional information for the available forms for this form type.
        /// </summary>
        [JsonProperty("form_meta")]
        public object FormMeta { get; private set; }
        /// <summary>
        /// The URL to access the forms for this form type.
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        private FormResource()
        {

        }
    }

}