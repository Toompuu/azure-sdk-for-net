// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Mutable batch inference settings per deployment. </summary>
    public partial class PartialBatchDeployment
    {
        /// <summary> Initializes a new instance of PartialBatchDeployment. </summary>
        public PartialBatchDeployment()
        {
            EnvironmentVariables = new ChangeTrackingDictionary<string, string>();
            Properties = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Code configuration for the endpoint deployment. </summary>
        public PartialCodeConfiguration CodeConfiguration { get; set; }
        /// <summary> Compute binding definition. </summary>
        public string Compute { get; set; }
        /// <summary> Description of the endpoint deployment. </summary>
        public string Description { get; set; }
        /// <summary> ARM resource ID of the environment specification for the endpoint deployment. </summary>
        public string EnvironmentId { get; set; }
        /// <summary> Environment variables configuration for the deployment. </summary>
        public IDictionary<string, string> EnvironmentVariables { get; set; }
        /// <summary>
        /// Error threshold, if the error count for the entire input goes above this value,
        /// the batch inference will be aborted. Range is [-1, int.MaxValue].
        /// For FileDataset, this value is the count of file failures.
        /// For TabularDataset, this value is the count of record failures.
        /// If set to -1 (the lower bound), all failures during batch inference will be ignored.
        /// </summary>
        public int? ErrorThreshold { get; set; }
        /// <summary> Logging level for batch inference operation. </summary>
        public BatchLoggingLevel? LoggingLevel { get; set; }
        /// <summary> Indicates number of processes per instance. </summary>
        public int? MaxConcurrencyPerInstance { get; set; }
        /// <summary>
        /// Size of the mini-batch passed to each batch invocation.
        /// For FileDataset, this is the number of files per mini-batch.
        /// For TabularDataset, this is the size of the records in bytes, per mini-batch.
        /// </summary>
        public long? MiniBatchSize { get; set; }
        /// <summary> Reference to the model asset for the endpoint deployment. </summary>
        public PartialAssetReferenceBase Model { get; set; }
        /// <summary> Indicates how the output will be organized. </summary>
        public BatchOutputAction? OutputAction { get; set; }
        /// <summary> Customized output file name for append_row output action. </summary>
        public string OutputFileName { get; set; }
        /// <summary> Property dictionary. Properties can be added, but not removed or altered. </summary>
        public IDictionary<string, string> Properties { get; set; }
        /// <summary> Retry Settings for the batch inference operation. </summary>
        public PartialBatchRetrySettings RetrySettings { get; set; }
    }
}
