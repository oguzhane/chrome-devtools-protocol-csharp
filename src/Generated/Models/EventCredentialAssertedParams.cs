// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Chrome.DevTools.Models
{
    /// <summary> Triggered when a credential is used in a webauthn assertion. </summary>
    public partial class EventCredentialAssertedParams
    {
        /// <summary> Initializes a new instance of EventCredentialAssertedParams. </summary>
        /// <param name="authenticatorId"></param>
        /// <param name="credential"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="authenticatorId"/> or <paramref name="credential"/> is null. </exception>
        public EventCredentialAssertedParams(string authenticatorId, TypeCredential credential)
        {
            Argument.AssertNotNull(authenticatorId, nameof(authenticatorId));
            Argument.AssertNotNull(credential, nameof(credential));

            AuthenticatorId = authenticatorId;
            Credential = credential;
        }

        /// <summary> Gets or sets the authenticator id. </summary>
        public string AuthenticatorId { get; set; }
        /// <summary> Gets or sets the credential. </summary>
        public TypeCredential Credential { get; set; }
    }
}
