/* 
 * Talon.One API
 *
 * Use the Talon.One API to integrate with your application and to manage applications and campaigns:  - Use the operations in the [Integration API section](#integration-api) are used to integrate with our platform - Use the operation in the [Management API section](#management-api) to manage applications and campaigns.  ## Determining the base URL of the endpoints  The API is available at the same hostname as your Campaign Manager deployment. For example, if you are reading this page at `https://mycompany.talon.one/docs/api/`, the URL for the [updateCustomerSession](https://docs.talon.one/integration-api/#operation/updateCustomerSessionV2) endpoint is `https://mycompany.talon.one/v2/customer_sessions/{Id}` 
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using TalonOne.Api;
using TalonOne.Model;
using TalonOne.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace TalonOne.Test
{
    /// <summary>
    ///  Class for testing InlineResponse20015
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class InlineResponse20015Tests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for InlineResponse20015
        //private InlineResponse20015 instance;

        public InlineResponse20015Tests()
        {
            // TODO uncomment below to create an instance of InlineResponse20015
            //instance = new InlineResponse20015();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of InlineResponse20015
        /// </summary>
        [Fact]
        public void InlineResponse20015InstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" InlineResponse20015
            //Assert.IsInstanceOfType<InlineResponse20015> (instance, "variable 'instance' is a InlineResponse20015");
        }


        /// <summary>
        /// Test the property 'HasMore'
        /// </summary>
        [Fact]
        public void HasMoreTest()
        {
            // TODO unit test for the property 'HasMore'
        }
        /// <summary>
        /// Test the property 'Data'
        /// </summary>
        [Fact]
        public void DataTest()
        {
            // TODO unit test for the property 'Data'
        }

    }

}
