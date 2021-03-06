// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Language.LUIS.Authoring.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Pattern
    /// </summary>
    public partial class PatternRule
    {
        /// <summary>
        /// Initializes a new instance of the PatternRule class.
        /// </summary>
        public PatternRule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PatternRule class.
        /// </summary>
        /// <param name="pattern">The pattern text.</param>
        /// <param name="intent">The intent's name where the pattern belongs
        /// to.</param>
        public PatternRule(string pattern = default(string), string intent = default(string))
        {
            Pattern = pattern;
            Intent = intent;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the pattern text.
        /// </summary>
        [JsonProperty(PropertyName = "pattern")]
        public string Pattern { get; set; }

        /// <summary>
        /// Gets or sets the intent's name where the pattern belongs to.
        /// </summary>
        [JsonProperty(PropertyName = "intent")]
        public string Intent { get; set; }

    }
}
