// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Search.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for StopwordsList.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StopwordsList
    {
        [EnumMember(Value = "arabic")]
        Arabic,
        [EnumMember(Value = "armenian")]
        Armenian,
        [EnumMember(Value = "basque")]
        Basque,
        [EnumMember(Value = "brazilian")]
        Brazilian,
        [EnumMember(Value = "bulgarian")]
        Bulgarian,
        [EnumMember(Value = "catalan")]
        Catalan,
        [EnumMember(Value = "czech")]
        Czech,
        [EnumMember(Value = "danish")]
        Danish,
        [EnumMember(Value = "dutch")]
        Dutch,
        [EnumMember(Value = "english")]
        English,
        [EnumMember(Value = "finnish")]
        Finnish,
        [EnumMember(Value = "french")]
        French,
        [EnumMember(Value = "galician")]
        Galician,
        [EnumMember(Value = "german")]
        German,
        [EnumMember(Value = "greek")]
        Greek,
        [EnumMember(Value = "hindi")]
        Hindi,
        [EnumMember(Value = "hungarian")]
        Hungarian,
        [EnumMember(Value = "indonesian")]
        Indonesian,
        [EnumMember(Value = "irish")]
        Irish,
        [EnumMember(Value = "italian")]
        Italian,
        [EnumMember(Value = "latvian")]
        Latvian,
        [EnumMember(Value = "norwegian")]
        Norwegian,
        [EnumMember(Value = "persian")]
        Persian,
        [EnumMember(Value = "portuguese")]
        Portuguese,
        [EnumMember(Value = "romanian")]
        Romanian,
        [EnumMember(Value = "russian")]
        Russian,
        [EnumMember(Value = "sorani")]
        Sorani,
        [EnumMember(Value = "spanish")]
        Spanish,
        [EnumMember(Value = "swedish")]
        Swedish,
        [EnumMember(Value = "thai")]
        Thai,
        [EnumMember(Value = "turkish")]
        Turkish
    }
}