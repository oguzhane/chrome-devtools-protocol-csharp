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
    /// <summary> Information about the Frame on the page. </summary>
    public partial class TypeFrame
    {
        /// <summary> Initializes a new instance of TypeFrame. </summary>
        /// <param name="id"> Frame unique identifier. </param>
        /// <param name="loaderId"> Identifier of the loader associated with this frame. </param>
        /// <param name="url"> Frame document&apos;s URL without fragment. </param>
        /// <param name="domainAndRegistry">
        /// Frame document&apos;s registered domain, taking the public suffixes list into account.
        /// Extracted from the Frame&apos;s url.
        /// Example URLs: http://www.google.com/file.html -&gt; &quot;google.com&quot;
        ///               http://a.b.co.uk/file.html      -&gt; &quot;b.co.uk&quot;
        /// </param>
        /// <param name="securityOrigin"> Frame document&apos;s security origin. </param>
        /// <param name="mimeType"> Frame document&apos;s mimeType as determined by the browser. </param>
        /// <param name="secureContextType"> Indicates whether the main document is a secure context and explains why that is the case. </param>
        /// <param name="crossOriginIsolatedContextType"> Indicates whether this is a cross origin isolated context. </param>
        /// <param name="gatedAPIFeatures"> Indicated which gated APIs / features are available. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/>, <paramref name="loaderId"/>, <paramref name="url"/>, <paramref name="domainAndRegistry"/>, <paramref name="securityOrigin"/>, <paramref name="mimeType"/>, <paramref name="secureContextType"/>, <paramref name="crossOriginIsolatedContextType"/> or <paramref name="gatedAPIFeatures"/> is null. </exception>
        public TypeFrame(string id, string loaderId, string url, string domainAndRegistry, string securityOrigin, string mimeType, string secureContextType, string crossOriginIsolatedContextType, IEnumerable<string> gatedAPIFeatures)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(loaderId, nameof(loaderId));
            Argument.AssertNotNull(url, nameof(url));
            Argument.AssertNotNull(domainAndRegistry, nameof(domainAndRegistry));
            Argument.AssertNotNull(securityOrigin, nameof(securityOrigin));
            Argument.AssertNotNull(mimeType, nameof(mimeType));
            Argument.AssertNotNull(secureContextType, nameof(secureContextType));
            Argument.AssertNotNull(crossOriginIsolatedContextType, nameof(crossOriginIsolatedContextType));
            Argument.AssertNotNull(gatedAPIFeatures, nameof(gatedAPIFeatures));

            Id = id;
            LoaderId = loaderId;
            Url = url;
            DomainAndRegistry = domainAndRegistry;
            SecurityOrigin = securityOrigin;
            MimeType = mimeType;
            SecureContextType = secureContextType;
            CrossOriginIsolatedContextType = crossOriginIsolatedContextType;
            GatedAPIFeatures = gatedAPIFeatures.ToList();
        }

        /// <summary> Initializes a new instance of TypeFrame. </summary>
        /// <param name="id"> Frame unique identifier. </param>
        /// <param name="parentId"> Parent frame identifier. </param>
        /// <param name="loaderId"> Identifier of the loader associated with this frame. </param>
        /// <param name="name"> Frame&apos;s name as specified in the tag. </param>
        /// <param name="url"> Frame document&apos;s URL without fragment. </param>
        /// <param name="urlFragment"> Frame document&apos;s URL fragment including the &apos;#&apos;. </param>
        /// <param name="domainAndRegistry">
        /// Frame document&apos;s registered domain, taking the public suffixes list into account.
        /// Extracted from the Frame&apos;s url.
        /// Example URLs: http://www.google.com/file.html -&gt; &quot;google.com&quot;
        ///               http://a.b.co.uk/file.html      -&gt; &quot;b.co.uk&quot;
        /// </param>
        /// <param name="securityOrigin"> Frame document&apos;s security origin. </param>
        /// <param name="mimeType"> Frame document&apos;s mimeType as determined by the browser. </param>
        /// <param name="unreachableUrl"> If the frame failed to load, this contains the URL that could not be loaded. Note that unlike url above, this URL may contain a fragment. </param>
        /// <param name="adFrameStatus"> Indicates whether this frame was tagged as an ad and why. </param>
        /// <param name="secureContextType"> Indicates whether the main document is a secure context and explains why that is the case. </param>
        /// <param name="crossOriginIsolatedContextType"> Indicates whether this is a cross origin isolated context. </param>
        /// <param name="gatedAPIFeatures"> Indicated which gated APIs / features are available. </param>
        internal TypeFrame(string id, string parentId, string loaderId, string name, string url, string urlFragment, string domainAndRegistry, string securityOrigin, string mimeType, string unreachableUrl, TypeAdFrameStatus adFrameStatus, string secureContextType, string crossOriginIsolatedContextType, IList<string> gatedAPIFeatures)
        {
            Id = id;
            ParentId = parentId;
            LoaderId = loaderId;
            Name = name;
            Url = url;
            UrlFragment = urlFragment;
            DomainAndRegistry = domainAndRegistry;
            SecurityOrigin = securityOrigin;
            MimeType = mimeType;
            UnreachableUrl = unreachableUrl;
            AdFrameStatus = adFrameStatus;
            SecureContextType = secureContextType;
            CrossOriginIsolatedContextType = crossOriginIsolatedContextType;
            GatedAPIFeatures = gatedAPIFeatures;
        }

        /// <summary> Frame unique identifier. </summary>
        public string Id { get; set; }
        /// <summary> Parent frame identifier. </summary>
        public string ParentId { get; set; }
        /// <summary> Identifier of the loader associated with this frame. </summary>
        public string LoaderId { get; set; }
        /// <summary> Frame&apos;s name as specified in the tag. </summary>
        public string Name { get; set; }
        /// <summary> Frame document&apos;s URL without fragment. </summary>
        public string Url { get; set; }
        /// <summary> Frame document&apos;s URL fragment including the &apos;#&apos;. </summary>
        public string UrlFragment { get; set; }
        /// <summary>
        /// Frame document&apos;s registered domain, taking the public suffixes list into account.
        /// Extracted from the Frame&apos;s url.
        /// Example URLs: http://www.google.com/file.html -&gt; &quot;google.com&quot;
        ///               http://a.b.co.uk/file.html      -&gt; &quot;b.co.uk&quot;
        /// </summary>
        public string DomainAndRegistry { get; set; }
        /// <summary> Frame document&apos;s security origin. </summary>
        public string SecurityOrigin { get; set; }
        /// <summary> Frame document&apos;s mimeType as determined by the browser. </summary>
        public string MimeType { get; set; }
        /// <summary> If the frame failed to load, this contains the URL that could not be loaded. Note that unlike url above, this URL may contain a fragment. </summary>
        public string UnreachableUrl { get; set; }
        /// <summary> Indicates whether this frame was tagged as an ad and why. </summary>
        public TypeAdFrameStatus AdFrameStatus { get; set; }
        /// <summary> Indicates whether the main document is a secure context and explains why that is the case. </summary>
        public string SecureContextType { get; set; }
        /// <summary> Indicates whether this is a cross origin isolated context. </summary>
        public string CrossOriginIsolatedContextType { get; set; }
        /// <summary> Indicated which gated APIs / features are available. </summary>
        public IList<string> GatedAPIFeatures { get; }
    }
}
