// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Chrome.DevTools.Models
{
    /// <summary>
    /// This issue tracks client hints related issues. It&apos;s used to deprecate old
    /// features, encourage the use of new ones, and provide general guidance.
    /// </summary>
    public partial class TypeClientHintIssueDetails
    {
        /// <summary> Initializes a new instance of TypeClientHintIssueDetails. </summary>
        /// <param name="sourceCodeLocation"></param>
        /// <param name="clientHintIssueReason"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceCodeLocation"/> or <paramref name="clientHintIssueReason"/> is null. </exception>
        public TypeClientHintIssueDetails(TypeSourceCodeLocation sourceCodeLocation, string clientHintIssueReason)
        {
            Argument.AssertNotNull(sourceCodeLocation, nameof(sourceCodeLocation));
            Argument.AssertNotNull(clientHintIssueReason, nameof(clientHintIssueReason));

            SourceCodeLocation = sourceCodeLocation;
            ClientHintIssueReason = clientHintIssueReason;
        }

        /// <summary> Gets or sets the source code location. </summary>
        public TypeSourceCodeLocation SourceCodeLocation { get; set; }
        /// <summary> Gets or sets the client hint issue reason. </summary>
        public string ClientHintIssueReason { get; set; }
    }
}
