// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Chrome.DevTools.Models
{
    /// <summary> ServiceWorker version. </summary>
    public partial class TypeServiceWorkerVersion
    {
        /// <summary> Initializes a new instance of TypeServiceWorkerVersion. </summary>
        /// <param name="versionId"></param>
        /// <param name="registrationId"></param>
        /// <param name="scriptURL"></param>
        /// <param name="runningStatus"></param>
        /// <param name="status"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="versionId"/>, <paramref name="registrationId"/>, <paramref name="scriptURL"/>, <paramref name="runningStatus"/> or <paramref name="status"/> is null. </exception>
        public TypeServiceWorkerVersion(string versionId, string registrationId, string scriptURL, string runningStatus, string status)
        {
            Argument.AssertNotNull(versionId, nameof(versionId));
            Argument.AssertNotNull(registrationId, nameof(registrationId));
            Argument.AssertNotNull(scriptURL, nameof(scriptURL));
            Argument.AssertNotNull(runningStatus, nameof(runningStatus));
            Argument.AssertNotNull(status, nameof(status));

            VersionId = versionId;
            RegistrationId = registrationId;
            ScriptURL = scriptURL;
            RunningStatus = runningStatus;
            Status = status;
            ControlledClients = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of TypeServiceWorkerVersion. </summary>
        /// <param name="versionId"></param>
        /// <param name="registrationId"></param>
        /// <param name="scriptURL"></param>
        /// <param name="runningStatus"></param>
        /// <param name="status"></param>
        /// <param name="scriptLastModified"> The Last-Modified header value of the main script. </param>
        /// <param name="scriptResponseTime">
        /// The time at which the response headers of the main script were received from the server.
        /// For cached script it is the last time the cache entry was validated.
        /// </param>
        /// <param name="controlledClients"></param>
        /// <param name="targetId"></param>
        internal TypeServiceWorkerVersion(string versionId, string registrationId, string scriptURL, string runningStatus, string status, float? scriptLastModified, float? scriptResponseTime, IList<string> controlledClients, string targetId)
        {
            VersionId = versionId;
            RegistrationId = registrationId;
            ScriptURL = scriptURL;
            RunningStatus = runningStatus;
            Status = status;
            ScriptLastModified = scriptLastModified;
            ScriptResponseTime = scriptResponseTime;
            ControlledClients = controlledClients;
            TargetId = targetId;
        }

        /// <summary> Gets or sets the version id. </summary>
        public string VersionId { get; set; }
        /// <summary> Gets or sets the registration id. </summary>
        public string RegistrationId { get; set; }
        /// <summary> Gets or sets the script url. </summary>
        public string ScriptURL { get; set; }
        /// <summary> Gets or sets the running status. </summary>
        public string RunningStatus { get; set; }
        /// <summary> Gets or sets the status. </summary>
        public string Status { get; set; }
        /// <summary> The Last-Modified header value of the main script. </summary>
        public float? ScriptLastModified { get; set; }
        /// <summary>
        /// The time at which the response headers of the main script were received from the server.
        /// For cached script it is the last time the cache entry was validated.
        /// </summary>
        public float? ScriptResponseTime { get; set; }
        /// <summary> Gets the controlled clients. </summary>
        public IList<string> ControlledClients { get; }
        /// <summary> Gets or sets the target id. </summary>
        public string TargetId { get; set; }
    }
}
