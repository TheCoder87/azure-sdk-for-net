// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using System.Linq;

    /// <summary>
    /// Usage metrics for a pool across an aggregation interval.
    /// </summary>
    public partial class PoolUsageMetrics
    {
        /// <summary>
        /// Initializes a new instance of the PoolUsageMetrics class.
        /// </summary>
        public PoolUsageMetrics() { }

        /// <summary>
        /// Initializes a new instance of the PoolUsageMetrics class.
        /// </summary>
        /// <param name="poolId">The ID of the pool whose metrics are
        /// aggregated in this entry.</param>
        /// <param name="startTime">The start time of the aggregation interval
        /// covered by this entry.</param>
        /// <param name="endTime">The end time of the aggregation interval
        /// covered by this entry.</param>
        /// <param name="vmSize">The size of virtual machines in the pool. All
        /// VMs in a pool are the same size.</param>
        /// <param name="totalCoreHours">The total core hours used in the pool
        /// during this aggregation interval.</param>
        /// <param name="dataIngressGiB">The cross data center network ingress
        /// to the pool during this interval, in GiB.</param>
        /// <param name="dataEgressGiB">The cross data center network egress
        /// from the pool during this interval, in GiB.</param>
        public PoolUsageMetrics(string poolId, System.DateTime startTime, System.DateTime endTime, string vmSize, double totalCoreHours, double dataIngressGiB, double dataEgressGiB)
        {
            PoolId = poolId;
            StartTime = startTime;
            EndTime = endTime;
            VmSize = vmSize;
            TotalCoreHours = totalCoreHours;
            DataIngressGiB = dataIngressGiB;
            DataEgressGiB = dataEgressGiB;
        }

        /// <summary>
        /// Gets or sets the ID of the pool whose metrics are aggregated in
        /// this entry.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "poolId")]
        public string PoolId { get; set; }

        /// <summary>
        /// Gets or sets the start time of the aggregation interval covered by
        /// this entry.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "startTime")]
        public System.DateTime StartTime { get; set; }

        /// <summary>
        /// Gets or sets the end time of the aggregation interval covered by
        /// this entry.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "endTime")]
        public System.DateTime EndTime { get; set; }

        /// <summary>
        /// Gets or sets the size of virtual machines in the pool. All VMs in a
        /// pool are the same size.
        /// </summary>
        /// <remarks>
        /// For information about available sizes of virtual machines for Cloud
        /// Services pools (pools created with cloudServiceConfiguration), see
        /// Sizes for Cloud Services
        /// (http://azure.microsoft.com/documentation/articles/cloud-services-sizes-specs/).
        /// Batch supports all Cloud Services VM sizes except ExtraSmall, A1V2
        /// and A2V2. For information about available VM sizes for pools using
        /// images from the Virtual Machines Marketplace (pools created with
        /// virtualMachineConfiguration) see Sizes for Virtual Machines (Linux)
        /// (https://azure.microsoft.com/documentation/articles/virtual-machines-linux-sizes/)
        /// or Sizes for Virtual Machines (Windows)
        /// (https://azure.microsoft.com/documentation/articles/virtual-machines-windows-sizes/).
        /// Batch supports all Azure VM sizes except STANDARD_A0 and those with
        /// premium storage (STANDARD_GS, STANDARD_DS, and STANDARD_DSV2
        /// series).
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "vmSize")]
        public string VmSize { get; set; }

        /// <summary>
        /// Gets or sets the total core hours used in the pool during this
        /// aggregation interval.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "totalCoreHours")]
        public double TotalCoreHours { get; set; }

        /// <summary>
        /// Gets or sets the cross data center network ingress to the pool
        /// during this interval, in GiB.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "dataIngressGiB")]
        public double DataIngressGiB { get; set; }

        /// <summary>
        /// Gets or sets the cross data center network egress from the pool
        /// during this interval, in GiB.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "dataEgressGiB")]
        public double DataEgressGiB { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (PoolId == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "PoolId");
            }
            if (VmSize == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "VmSize");
            }
        }
    }
}