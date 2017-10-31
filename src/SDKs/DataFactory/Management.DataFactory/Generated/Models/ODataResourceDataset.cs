// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The Open Data Protocol (OData) resource dataset.
    /// </summary>
    [Newtonsoft.Json.JsonObject("ODataResource")]
    [Rest.Serialization.JsonTransformation]
    public partial class ODataResourceDataset : Dataset
    {
        /// <summary>
        /// Initializes a new instance of the ODataResourceDataset class.
        /// </summary>
        public ODataResourceDataset()
        {
            LinkedServiceName = new LinkedServiceReference();
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ODataResourceDataset class.
        /// </summary>
        /// <param name="linkedServiceName">Linked service reference.</param>
        /// <param name="description">Dataset description.</param>
        /// <param name="structure">Columns that define the structure of the
        /// dataset. Type: array (or Expression with resultType array),
        /// itemType: DatasetDataElement.</param>
        /// <param name="parameters">Parameters for dataset.</param>
        /// <param name="path">The OData resource path. Type: string (or
        /// Expression with resultType string).</param>
        public ODataResourceDataset(LinkedServiceReference linkedServiceName, string description = default(string), object structure = default(object), IDictionary<string, ParameterSpecification> parameters = default(IDictionary<string, ParameterSpecification>), object path = default(object))
            : base(linkedServiceName, description, structure, parameters)
        {
            Path = path;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the OData resource path. Type: string (or Expression
        /// with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.path")]
        public object Path { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}