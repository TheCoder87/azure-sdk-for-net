// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Search.Models
{
    using Azure;
    using Search;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for PhoneticEncoder.
    /// </summary>
    [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PhoneticEncoder
    {
        [EnumMember(Value = "metaphone")]
        Metaphone,
        [EnumMember(Value = "doubleMetaphone")]
        DoubleMetaphone,
        [EnumMember(Value = "soundex")]
        Soundex,
        [EnumMember(Value = "refinedSoundex")]
        RefinedSoundex,
        [EnumMember(Value = "caverphone1")]
        Caverphone1,
        [EnumMember(Value = "caverphone2")]
        Caverphone2,
        [EnumMember(Value = "cologne")]
        Cologne,
        [EnumMember(Value = "nysiis")]
        Nysiis,
        [EnumMember(Value = "koelnerPhonetik")]
        KoelnerPhonetik,
        [EnumMember(Value = "haasePhonetik")]
        HaasePhonetik,
        [EnumMember(Value = "beiderMorse")]
        BeiderMorse
    }
}

