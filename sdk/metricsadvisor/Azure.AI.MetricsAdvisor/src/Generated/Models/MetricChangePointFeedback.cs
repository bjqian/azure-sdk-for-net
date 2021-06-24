// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.AI.MetricsAdvisor.Models;

namespace Azure.AI.MetricsAdvisor
{
    /// <summary> The ChangePointFeedback. </summary>
    public partial class MetricChangePointFeedback : MetricFeedback
    {

        /// <summary> Initializes a new instance of MetricChangePointFeedback. </summary>
        /// <param name="kind"> feedback type. </param>
        /// <param name="id"> feedback unique id. </param>
        /// <param name="createdTime"> feedback created time. </param>
        /// <param name="userPrincipal"> user who gives this feedback. </param>
        /// <param name="metricId"> metric unique id. </param>
        /// <param name="dimensionFilter"> . </param>
        /// <param name="startTime"> the start timestamp of feedback time range. </param>
        /// <param name="endTime"> the end timestamp of feedback time range, when equals to startTime means only one timestamp. </param>
        /// <param name="valueInternal"> . </param>
        internal MetricChangePointFeedback(MetricFeedbackKind kind, string id, DateTimeOffset? createdTime, string userPrincipal, string metricId, GetAllFeedbackFilter dimensionFilter, DateTimeOffset startTime, DateTimeOffset endTime, ChangePointFeedbackValue valueInternal) : base(kind, id, createdTime, userPrincipal, metricId, dimensionFilter)
        {
            StartTime = startTime;
            EndTime = endTime;
            ValueInternal = valueInternal;
            Kind = kind;
        }
    }
}
