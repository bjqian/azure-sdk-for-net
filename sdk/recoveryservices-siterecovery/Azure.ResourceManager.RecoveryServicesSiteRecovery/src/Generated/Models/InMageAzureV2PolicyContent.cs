// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> VMWare Azure specific policy Input. </summary>
    public partial class InMageAzureV2PolicyContent : PolicyProviderSpecificContent
    {
        /// <summary> Initializes a new instance of <see cref="InMageAzureV2PolicyContent"/>. </summary>
        /// <param name="multiVmSyncStatus"> A value indicating whether multi-VM sync has to be enabled. Value should be 'Enabled' or 'Disabled'. </param>
        public InMageAzureV2PolicyContent(SetMultiVmSyncStatus multiVmSyncStatus)
        {
            MultiVmSyncStatus = multiVmSyncStatus;
            InstanceType = "InMageAzureV2";
        }

        /// <summary> Initializes a new instance of <see cref="InMageAzureV2PolicyContent"/>. </summary>
        /// <param name="instanceType"> The class type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="recoveryPointThresholdInMinutes"> The recovery point threshold in minutes. </param>
        /// <param name="recoveryPointHistory"> The duration in minutes until which the recovery points need to be stored. </param>
        /// <param name="crashConsistentFrequencyInMinutes"> The crash consistent snapshot frequency (in minutes). </param>
        /// <param name="appConsistentFrequencyInMinutes"> The app consistent snapshot frequency (in minutes). </param>
        /// <param name="multiVmSyncStatus"> A value indicating whether multi-VM sync has to be enabled. Value should be 'Enabled' or 'Disabled'. </param>
        internal InMageAzureV2PolicyContent(string instanceType, IDictionary<string, BinaryData> serializedAdditionalRawData, int? recoveryPointThresholdInMinutes, int? recoveryPointHistory, int? crashConsistentFrequencyInMinutes, int? appConsistentFrequencyInMinutes, SetMultiVmSyncStatus multiVmSyncStatus) : base(instanceType, serializedAdditionalRawData)
        {
            RecoveryPointThresholdInMinutes = recoveryPointThresholdInMinutes;
            RecoveryPointHistory = recoveryPointHistory;
            CrashConsistentFrequencyInMinutes = crashConsistentFrequencyInMinutes;
            AppConsistentFrequencyInMinutes = appConsistentFrequencyInMinutes;
            MultiVmSyncStatus = multiVmSyncStatus;
            InstanceType = instanceType ?? "InMageAzureV2";
        }

        /// <summary> Initializes a new instance of <see cref="InMageAzureV2PolicyContent"/> for deserialization. </summary>
        internal InMageAzureV2PolicyContent()
        {
        }

        /// <summary> The recovery point threshold in minutes. </summary>
        public int? RecoveryPointThresholdInMinutes { get; set; }
        /// <summary> The duration in minutes until which the recovery points need to be stored. </summary>
        public int? RecoveryPointHistory { get; set; }
        /// <summary> The crash consistent snapshot frequency (in minutes). </summary>
        public int? CrashConsistentFrequencyInMinutes { get; set; }
        /// <summary> The app consistent snapshot frequency (in minutes). </summary>
        public int? AppConsistentFrequencyInMinutes { get; set; }
        /// <summary> A value indicating whether multi-VM sync has to be enabled. Value should be 'Enabled' or 'Disabled'. </summary>
        public SetMultiVmSyncStatus MultiVmSyncStatus { get; }
    }
}
