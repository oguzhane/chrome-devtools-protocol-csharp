// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Chrome.DevTools.Models
{
    /// <summary> Fired when the virtual machine stopped on breakpoint or exception or any other stop criteria. </summary>
    public partial class EventPausedParams
    {
        /// <summary> Initializes a new instance of EventPausedParams. </summary>
        /// <param name="callFrames"> Call stack the virtual machine stopped on. </param>
        /// <param name="reason"> Pause reason. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="callFrames"/> or <paramref name="reason"/> is null. </exception>
        public EventPausedParams(IEnumerable<TypeCallFrame> callFrames, string reason)
        {
            Argument.AssertNotNull(callFrames, nameof(callFrames));
            Argument.AssertNotNull(reason, nameof(reason));

            CallFrames = callFrames.ToList();
            Reason = reason;
            HitBreakpoints = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of EventPausedParams. </summary>
        /// <param name="callFrames"> Call stack the virtual machine stopped on. </param>
        /// <param name="reason"> Pause reason. </param>
        /// <param name="data"> Object containing break-specific auxiliary properties. </param>
        /// <param name="hitBreakpoints"> Hit breakpoints IDs. </param>
        /// <param name="asyncStackTrace"> Async stack trace, if any. </param>
        /// <param name="asyncStackTraceId"> Async stack trace, if any. </param>
        /// <param name="asyncCallStackTraceId"> Never present, will be removed. </param>
        internal EventPausedParams(IList<TypeCallFrame> callFrames, string reason, object data, IList<string> hitBreakpoints, TypeStackTrace asyncStackTrace, TypeStackTraceId asyncStackTraceId, TypeStackTraceId asyncCallStackTraceId)
        {
            CallFrames = callFrames;
            Reason = reason;
            Data = data;
            HitBreakpoints = hitBreakpoints;
            AsyncStackTrace = asyncStackTrace;
            AsyncStackTraceId = asyncStackTraceId;
            AsyncCallStackTraceId = asyncCallStackTraceId;
        }

        /// <summary> Call stack the virtual machine stopped on. </summary>
        public IList<TypeCallFrame> CallFrames { get; }
        /// <summary> Pause reason. </summary>
        public string Reason { get; set; }
        /// <summary> Object containing break-specific auxiliary properties. </summary>
        public object Data { get; set; }
        /// <summary> Hit breakpoints IDs. </summary>
        public IList<string> HitBreakpoints { get; }
        /// <summary> Async stack trace, if any. </summary>
        public TypeStackTrace AsyncStackTrace { get; set; }
        /// <summary> Async stack trace, if any. </summary>
        public TypeStackTraceId AsyncStackTraceId { get; set; }
        /// <summary> Never present, will be removed. </summary>
        public TypeStackTraceId AsyncCallStackTraceId { get; set; }
    }
}
