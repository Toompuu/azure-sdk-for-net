// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ServiceLinker.Models
{
    /// <summary> The secret info. </summary>
    public partial class SecretInfoBase
    {
        /// <summary> Initializes a new instance of SecretInfoBase. </summary>
        public SecretInfoBase()
        {
        }

        /// <summary> Initializes a new instance of SecretInfoBase. </summary>
        /// <param name="secretType"> The secret type. </param>
        internal SecretInfoBase(SecretType secretType)
        {
            SecretType = secretType;
        }

        /// <summary> The secret type. </summary>
        internal SecretType SecretType { get; set; }
    }
}
