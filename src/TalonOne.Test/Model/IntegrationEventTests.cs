/* 
 * Talon.One API
 *
 * The Talon.One API is used to manage applications and campaigns, as well as to integrate with your application. The operations in the _Integration API_ section are used to integrate with our platform, while the other operations are used to manage applications and campaigns.  ### Where is the API?  The API is available at the same hostname as these docs. For example, if you are reading this page at `https://mycompany.talon.one/docs/api/`, the URL for the [updateCustomerProfile][] operation is `https://mycompany.talon.one/v1/customer_profiles/id`  [updateCustomerProfile]: #operation- -v1-customer_profiles- -integrationId- -put 
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


using NUnit.Framework;

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
    ///  Class for testing IntegrationEvent
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class IntegrationEventTests
    {
        // TODO uncomment below to declare an instance variable for IntegrationEvent
        //private IntegrationEvent instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of IntegrationEvent
            //instance = new IntegrationEvent();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of IntegrationEvent
        /// </summary>
        [Test]
        public void IntegrationEventInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" IntegrationEvent
            //Assert.IsInstanceOfType<IntegrationEvent> (instance, "variable 'instance' is a IntegrationEvent");
        }


        /// <summary>
        /// Test the property 'ProfileId'
        /// </summary>
        [Test]
        public void ProfileIdTest()
        {
            // TODO unit test for the property 'ProfileId'
        }
        /// <summary>
        /// Test the property 'Type'
        /// </summary>
        [Test]
        public void TypeTest()
        {
            // TODO unit test for the property 'Type'
        }
        /// <summary>
        /// Test the property 'Attributes'
        /// </summary>
        [Test]
        public void AttributesTest()
        {
            // TODO unit test for the property 'Attributes'
        }

    }

}
