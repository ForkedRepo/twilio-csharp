using Twilio.Base;
using Twilio.Clients;
using Twilio.Exceptions;
using Twilio.Http;

#if NET40
using System.Threading.Tasks;
#endif

namespace Twilio.Rest.IpMessaging.V1 {

    public class CredentialCreator : Creator<CredentialResource> {
        private CredentialResource.PushService type;
        private string friendlyName;
        private string certificate;
        private string privateKey;
        private bool? sandbox;
        private string apiKey;
    
        /// <summary>
        /// Construct a new CredentialCreator
        /// </summary>
        ///
        /// <param name="type"> The type </param>
        public CredentialCreator(CredentialResource.PushService type) {
            this.type = type;
        }
    
        /// <summary>
        /// The friendly_name
        /// </summary>
        ///
        /// <param name="friendlyName"> The friendly_name </param>
        /// <returns> this </returns> 
        public CredentialCreator setFriendlyName(string friendlyName) {
            this.friendlyName = friendlyName;
            return this;
        }
    
        /// <summary>
        /// The certificate
        /// </summary>
        ///
        /// <param name="certificate"> The certificate </param>
        /// <returns> this </returns> 
        public CredentialCreator setCertificate(string certificate) {
            this.certificate = certificate;
            return this;
        }
    
        /// <summary>
        /// The private_key
        /// </summary>
        ///
        /// <param name="privateKey"> The private_key </param>
        /// <returns> this </returns> 
        public CredentialCreator setPrivateKey(string privateKey) {
            this.privateKey = privateKey;
            return this;
        }
    
        /// <summary>
        /// The sandbox
        /// </summary>
        ///
        /// <param name="sandbox"> The sandbox </param>
        /// <returns> this </returns> 
        public CredentialCreator setSandbox(bool? sandbox) {
            this.sandbox = sandbox;
            return this;
        }
    
        /// <summary>
        /// The api_key
        /// </summary>
        ///
        /// <param name="apiKey"> The api_key </param>
        /// <returns> this </returns> 
        public CredentialCreator setApiKey(string apiKey) {
            this.apiKey = apiKey;
            return this;
        }
    
        #if NET40
        /// <summary>
        /// Make the request to the Twilio API to perform the create
        /// </summary>
        ///
        /// <param name="client"> ITwilioRestClient with which to make the request </param>
        /// <returns> Created CredentialResource </returns> 
        public override async Task<CredentialResource> CreateAsync(ITwilioRestClient client) {
            var request = new Request(
                Twilio.Http.HttpMethod.POST,
                Domains.IP_MESSAGING,
                "/v1/Credentials"
            );
            
            addPostParams(request);
            var response = await client.RequestAsync(request);
            if (response == null)
            {
                throw new ApiConnectionException("CredentialResource creation failed: Unable to connect to server");
            }
            
            if (response.StatusCode < System.Net.HttpStatusCode.OK || response.StatusCode > System.Net.HttpStatusCode.NoContent)
            {
                var restException = RestException.FromJson(response.Content);
                if (restException == null)
                {
                    throw new ApiException("Server Error, no content");
                }
            
                throw new ApiException(
                    restException.Code,
                    (int)response.StatusCode,
                    restException.Message ?? "Unable to create record, " + response.StatusCode,
                    restException.MoreInfo
                );
            }
            
            return CredentialResource.FromJson(response.Content);
        }
        #endif
    
        /// <summary>
        /// Make the request to the Twilio API to perform the create
        /// </summary>
        ///
        /// <param name="client"> ITwilioRestClient with which to make the request </param>
        /// <returns> Created CredentialResource </returns> 
        public override CredentialResource Create(ITwilioRestClient client) {
            var request = new Request(
                Twilio.Http.HttpMethod.POST,
                Domains.IP_MESSAGING,
                "/v1/Credentials"
            );
            
            addPostParams(request);
            var response = client.Request(request);
            if (response == null)
            {
                throw new ApiConnectionException("CredentialResource creation failed: Unable to connect to server");
            }
            
            if (response.StatusCode < System.Net.HttpStatusCode.OK || response.StatusCode > System.Net.HttpStatusCode.NoContent)
            {
                var restException = RestException.FromJson(response.Content);
                if (restException == null)
                {
                    throw new ApiException("Server Error, no content");
                }
            
                throw new ApiException(
                    restException.Code,
                    (int)response.StatusCode,
                    restException.Message ?? "Unable to create record, " + response.StatusCode,
                    restException.MoreInfo
                );
            }
            
            return CredentialResource.FromJson(response.Content);
        }
    
        /// <summary>
        /// Add the requested post parameters to the Request
        /// </summary>
        ///
        /// <param name="request"> Request to add post params to </param>
        private void addPostParams(Request request) {
            if (type != null) {
                request.AddPostParam("Type", type.ToString());
            }
            
            if (friendlyName != null) {
                request.AddPostParam("FriendlyName", friendlyName);
            }
            
            if (certificate != null) {
                request.AddPostParam("Certificate", certificate);
            }
            
            if (privateKey != null) {
                request.AddPostParam("PrivateKey", privateKey);
            }
            
            if (sandbox != null) {
                request.AddPostParam("Sandbox", sandbox.ToString());
            }
            
            if (apiKey != null) {
                request.AddPostParam("ApiKey", apiKey);
            }
        }
    }
}