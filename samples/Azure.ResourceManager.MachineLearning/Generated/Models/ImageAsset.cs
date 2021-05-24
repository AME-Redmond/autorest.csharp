// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.MachineLearning
{
    /// <summary> An Image asset. </summary>
    public partial class ImageAsset : SubResourceWritable
    {
        /// <summary> Initializes a new instance of ImageAsset. </summary>
        public ImageAsset()
        {
        }

        /// <summary> Initializes a new instance of ImageAsset. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="mimeType"> The mime type. </param>
        /// <param name="url"> The Url of the Asset. </param>
        /// <param name="unpack"> Whether the Asset is unpacked. </param>
        internal ImageAsset(string id, string mimeType, string url, bool? unpack) : base(id)
        {
            MimeType = mimeType;
            Url = url;
            Unpack = unpack;
        }

        /// <summary> The mime type. </summary>
        public string MimeType { get; set; }
        /// <summary> The Url of the Asset. </summary>
        public string Url { get; set; }
        /// <summary> Whether the Asset is unpacked. </summary>
        public bool? Unpack { get; set; }
    }
}
