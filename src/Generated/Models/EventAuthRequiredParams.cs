// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Chrome.DevTools.Models
{
    /// <summary>
    /// Issued when the domain is enabled with handleAuthRequests set to true.
    /// The request is paused until client responds with continueWithAuth.
    /// </summary>
    public partial class EventAuthRequiredParams
    {
        /// <summary> Initializes a new instance of EventAuthRequiredParams. </summary>
        /// <param name="requestId"> Each request the page makes will have a unique id. </param>
        /// <param name="request"> The details of the request. </param>
        /// <param name="frameId"> The id of the frame that initiated the request. </param>
        /// <param name="resourceType"> How the requested resource will be used. </param>
        /// <param name="authChallenge">
        /// Details of the Authorization Challenge encountered.
        /// If this is set, client should respond with continueRequest that
        /// contains AuthChallengeResponse.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="requestId"/>, <paramref name="request"/>, <paramref name="frameId"/>, <paramref name="resourceType"/> or <paramref name="authChallenge"/> is null. </exception>
        public EventAuthRequiredParams(string requestId, TypeRequest request, string frameId, string resourceType, TypeAuthChallenge authChallenge)
        {
            Argument.AssertNotNull(requestId, nameof(requestId));
            Argument.AssertNotNull(request, nameof(request));
            Argument.AssertNotNull(frameId, nameof(frameId));
            Argument.AssertNotNull(resourceType, nameof(resourceType));
            Argument.AssertNotNull(authChallenge, nameof(authChallenge));

            RequestId = requestId;
            Request = request;
            FrameId = frameId;
            ResourceType = resourceType;
            AuthChallenge = authChallenge;
        }

        /// <summary> Each request the page makes will have a unique id. </summary>
        public string RequestId { get; set; }
        /// <summary> The details of the request. </summary>
        public TypeRequest Request { get; set; }
        /// <summary> The id of the frame that initiated the request. </summary>
        public string FrameId { get; set; }
        /// <summary> How the requested resource will be used. </summary>
        public string ResourceType { get; set; }
        /// <summary>
        /// Details of the Authorization Challenge encountered.
        /// If this is set, client should respond with continueRequest that
        /// contains AuthChallengeResponse.
        /// </summary>
        public TypeAuthChallenge AuthChallenge { get; set; }
    }
}
