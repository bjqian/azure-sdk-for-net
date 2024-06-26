// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Reservations.Models
{
    /// <summary> Reservation refund details. </summary>
    public partial class ReservationToReturnForExchange
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ReservationToReturnForExchange"/>. </summary>
        internal ReservationToReturnForExchange()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ReservationToReturnForExchange"/>. </summary>
        /// <param name="reservationId"> Fully qualified id of the reservation being returned. </param>
        /// <param name="quantity"> Quantity to be returned. </param>
        /// <param name="billingRefundAmount"> Pricing information containing the amount and the currency code. </param>
        /// <param name="billingInformation"> billing information. </param>
        /// <param name="status"> Status of the individual operation. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ReservationToReturnForExchange(ResourceIdentifier reservationId, int? quantity, PurchasePrice billingRefundAmount, BillingInformation billingInformation, ReservationOperationStatus? status, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ReservationId = reservationId;
            Quantity = quantity;
            BillingRefundAmount = billingRefundAmount;
            BillingInformation = billingInformation;
            Status = status;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Fully qualified id of the reservation being returned. </summary>
        public ResourceIdentifier ReservationId { get; }
        /// <summary> Quantity to be returned. </summary>
        public int? Quantity { get; }
        /// <summary> Pricing information containing the amount and the currency code. </summary>
        public PurchasePrice BillingRefundAmount { get; }
        /// <summary> billing information. </summary>
        public BillingInformation BillingInformation { get; }
        /// <summary> Status of the individual operation. </summary>
        public ReservationOperationStatus? Status { get; }
    }
}
