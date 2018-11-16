// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The result of listing the subtasks of a task.
    /// </summary>
    public partial class CloudTaskListSubtasksResult
    {
        /// <summary>
        /// Initializes a new instance of the CloudTaskListSubtasksResult
        /// class.
        /// </summary>
        public CloudTaskListSubtasksResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CloudTaskListSubtasksResult
        /// class.
        /// </summary>
        /// <param name="value">The list of subtasks.</param>
        public CloudTaskListSubtasksResult(IList<SubtaskInformation> value = default(IList<SubtaskInformation>))
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the list of subtasks.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<SubtaskInformation> Value { get; set; }

    }
}