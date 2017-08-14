// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.StorSimple.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.StorSimple;
    using Microsoft.Azure.Management.StorSimple.Fluent;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The time settings of a device.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class TimeSettingsInner : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the TimeSettingsInner class.
        /// </summary>
        public TimeSettingsInner()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TimeSettingsInner class.
        /// </summary>
        /// <param name="timeZone">The timezone of device, like '(UTC -06:00)
        /// Central America'</param>
        /// <param name="id">The path ID that uniquely identifies the
        /// object.</param>
        /// <param name="name">The name of the object.</param>
        /// <param name="type">The hierarchical type of the object.</param>
        /// <param name="kind">The Kind of the object. Currently only
        /// Series8000 is supported. Possible values include:
        /// 'Series8000'</param>
        /// <param name="primaryTimeServer">The primary Network Time Protocol
        /// (NTP) server name, like 'time.windows.com'.</param>
        /// <param name="secondaryTimeServer">The secondary Network Time
        /// Protocol (NTP) server name, like 'time.contoso.com'. It's
        /// optional.</param>
        public TimeSettingsInner(string timeZone, string id = default(string), string name = default(string), string type = default(string), Kind? kind = default(Kind?), string primaryTimeServer = default(string), IList<string> secondaryTimeServer = default(IList<string>))
            : base(id, name, type, kind)
        {
            TimeZone = timeZone;
            PrimaryTimeServer = primaryTimeServer;
            SecondaryTimeServer = secondaryTimeServer;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the timezone of device, like '(UTC -06:00) Central
        /// America'
        /// </summary>
        [JsonProperty(PropertyName = "properties.timeZone")]
        public string TimeZone { get; set; }

        /// <summary>
        /// Gets or sets the primary Network Time Protocol (NTP) server name,
        /// like 'time.windows.com'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.primaryTimeServer")]
        public string PrimaryTimeServer { get; set; }

        /// <summary>
        /// Gets or sets the secondary Network Time Protocol (NTP) server name,
        /// like 'time.contoso.com'. It's optional.
        /// </summary>
        [JsonProperty(PropertyName = "properties.secondaryTimeServer")]
        public IList<string> SecondaryTimeServer { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (TimeZone == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TimeZone");
            }
        }
    }
}