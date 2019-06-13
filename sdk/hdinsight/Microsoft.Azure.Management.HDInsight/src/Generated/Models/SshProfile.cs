// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.HDInsight.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The list of SSH public keys.
    /// </summary>
    public partial class SshProfile
    {
        /// <summary>
        /// Initializes a new instance of the SshProfile class.
        /// </summary>
        public SshProfile()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SshProfile class.
        /// </summary>
        /// <param name="publicKeys">The list of SSH public keys.</param>
        public SshProfile(IList<SshPublicKey> publicKeys = default(IList<SshPublicKey>))
        {
            PublicKeys = publicKeys;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the list of SSH public keys.
        /// </summary>
        [JsonProperty(PropertyName = "publicKeys")]
        public IList<SshPublicKey> PublicKeys { get; set; }

    }
}