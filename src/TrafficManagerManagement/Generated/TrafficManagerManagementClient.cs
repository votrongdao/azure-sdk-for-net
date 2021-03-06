// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Common;
using Microsoft.WindowsAzure.Management.TrafficManager;
using Microsoft.WindowsAzure.Management.TrafficManager.Models;

namespace Microsoft.WindowsAzure.Management.TrafficManager
{
    /// <summary>
    /// The Windows Azure Traffic Manager management API provides a RESTful set
    /// of web services that interact with Windows Azure Traffic Manager
    /// service for creating, updating, listing, and deleting Traffic Manager
    /// profiles and definitions.  (see
    /// http://msdn.microsoft.com/en-us/library/windowsazure/dn166981.aspx for
    /// more information)
    /// </summary>
    public partial class TrafficManagerManagementClient : ServiceClient<TrafficManagerManagementClient>, ITrafficManagerManagementClient
    {
        private Uri _baseUri;
        
        /// <summary>
        /// The URI used as the base for all Service Management requests.
        /// </summary>
        public Uri BaseUri
        {
            get { return this._baseUri; }
        }
        
        private SubscriptionCloudCredentials _credentials;
        
        /// <summary>
        /// When you create a Windows Azure subscription, it is uniquely
        /// identified by a subscription ID. The subscription ID forms part of
        /// the URI for every call that you make to the Service Management
        /// API.  The Windows Azure Service ManagementAPI use mutual
        /// authentication of management certificates over SSL to ensure that
        /// a request made to the service is secure.  No anonymous requests
        /// are allowed.
        /// </summary>
        public SubscriptionCloudCredentials Credentials
        {
            get { return this._credentials; }
        }
        
        private IDefinitionOperations _definitions;
        
        /// <summary>
        /// The Traffic Manager API includes operations for managing
        /// definitions for a specified profile.
        /// </summary>
        public virtual IDefinitionOperations Definitions
        {
            get { return this._definitions; }
        }
        
        private IProfileOperations _profiles;
        
        /// <summary>
        /// The Traffic Manager API includes operations for managing Traffic
        /// Manager profiles.
        /// </summary>
        public virtual IProfileOperations Profiles
        {
            get { return this._profiles; }
        }
        
        /// <summary>
        /// Initializes a new instance of the TrafficManagerManagementClient
        /// class.
        /// </summary>
        private TrafficManagerManagementClient()
            : base()
        {
            this._definitions = new DefinitionOperations(this);
            this._profiles = new ProfileOperations(this);
            this.HttpClient.Timeout = TimeSpan.FromSeconds(300);
        }
        
        /// <summary>
        /// Initializes a new instance of the TrafficManagerManagementClient
        /// class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. When you create a Windows Azure subscription, it is
        /// uniquely identified by a subscription ID. The subscription ID
        /// forms part of the URI for every call that you make to the Service
        /// Management API.  The Windows Azure Service ManagementAPI use
        /// mutual authentication of management certificates over SSL to
        /// ensure that a request made to the service is secure.  No anonymous
        /// requests are allowed.
        /// </param>
        /// <param name='baseUri'>
        /// Required. The URI used as the base for all Service Management
        /// requests.
        /// </param>
        public TrafficManagerManagementClient(SubscriptionCloudCredentials credentials, Uri baseUri)
            : this()
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            this._credentials = credentials;
            this._baseUri = baseUri;
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Initializes a new instance of the TrafficManagerManagementClient
        /// class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. When you create a Windows Azure subscription, it is
        /// uniquely identified by a subscription ID. The subscription ID
        /// forms part of the URI for every call that you make to the Service
        /// Management API.  The Windows Azure Service ManagementAPI use
        /// mutual authentication of management certificates over SSL to
        /// ensure that a request made to the service is secure.  No anonymous
        /// requests are allowed.
        /// </param>
        public TrafficManagerManagementClient(SubscriptionCloudCredentials credentials)
            : this()
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            this._credentials = credentials;
            this._baseUri = new Uri("https://management.core.windows.net");
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Parse enum values for type DefinitionMonitorProtocol.
        /// </summary>
        /// <param name='value'>
        /// The value to parse.
        /// </param>
        /// <returns>
        /// The enum value.
        /// </returns>
        internal static DefinitionMonitorProtocol ParseDefinitionMonitorProtocol(string value)
        {
            if ("HTTP".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return DefinitionMonitorProtocol.Http;
            }
            if ("HTTPS".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return DefinitionMonitorProtocol.Https;
            }
            throw new ArgumentOutOfRangeException("value");
        }
        
        /// <summary>
        /// Convert an enum of type DefinitionMonitorProtocol to a string.
        /// </summary>
        /// <param name='value'>
        /// The value to convert to a string.
        /// </param>
        /// <returns>
        /// The enum value as a string.
        /// </returns>
        internal static string DefinitionMonitorProtocolToString(DefinitionMonitorProtocol value)
        {
            if (value == DefinitionMonitorProtocol.Http)
            {
                return "HTTP";
            }
            if (value == DefinitionMonitorProtocol.Https)
            {
                return "HTTPS";
            }
            throw new ArgumentOutOfRangeException("value");
        }
    }
}
