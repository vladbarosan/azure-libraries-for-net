// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.AppService.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.AppService;
    using Microsoft.Azure.Management.AppService.Fluent;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for CertificateOrderStatus.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CertificateOrderStatus
    {
        [EnumMember(Value = "Pendingissuance")]
        Pendingissuance,
        [EnumMember(Value = "Issued")]
        Issued,
        [EnumMember(Value = "Revoked")]
        Revoked,
        [EnumMember(Value = "Canceled")]
        Canceled,
        [EnumMember(Value = "Denied")]
        Denied,
        [EnumMember(Value = "Pendingrevocation")]
        Pendingrevocation,
        [EnumMember(Value = "PendingRekey")]
        PendingRekey,
        [EnumMember(Value = "Unused")]
        Unused,
        [EnumMember(Value = "Expired")]
        Expired,
        [EnumMember(Value = "NotSubmitted")]
        NotSubmitted
    }
    internal static class CertificateOrderStatusEnumExtension
    {
        internal static string ToSerializedValue(this CertificateOrderStatus? value)  =>
            value == null ? null : ((CertificateOrderStatus)value).ToSerializedValue();

        internal static string ToSerializedValue(this CertificateOrderStatus value)
        {
            switch( value )
            {
                case CertificateOrderStatus.Pendingissuance:
                    return "Pendingissuance";
                case CertificateOrderStatus.Issued:
                    return "Issued";
                case CertificateOrderStatus.Revoked:
                    return "Revoked";
                case CertificateOrderStatus.Canceled:
                    return "Canceled";
                case CertificateOrderStatus.Denied:
                    return "Denied";
                case CertificateOrderStatus.Pendingrevocation:
                    return "Pendingrevocation";
                case CertificateOrderStatus.PendingRekey:
                    return "PendingRekey";
                case CertificateOrderStatus.Unused:
                    return "Unused";
                case CertificateOrderStatus.Expired:
                    return "Expired";
                case CertificateOrderStatus.NotSubmitted:
                    return "NotSubmitted";
            }
            return null;
        }

        internal static CertificateOrderStatus? ParseCertificateOrderStatus(this string value)
        {
            switch( value )
            {
                case "Pendingissuance":
                    return CertificateOrderStatus.Pendingissuance;
                case "Issued":
                    return CertificateOrderStatus.Issued;
                case "Revoked":
                    return CertificateOrderStatus.Revoked;
                case "Canceled":
                    return CertificateOrderStatus.Canceled;
                case "Denied":
                    return CertificateOrderStatus.Denied;
                case "Pendingrevocation":
                    return CertificateOrderStatus.Pendingrevocation;
                case "PendingRekey":
                    return CertificateOrderStatus.PendingRekey;
                case "Unused":
                    return CertificateOrderStatus.Unused;
                case "Expired":
                    return CertificateOrderStatus.Expired;
                case "NotSubmitted":
                    return CertificateOrderStatus.NotSubmitted;
            }
            return null;
        }
    }
}
