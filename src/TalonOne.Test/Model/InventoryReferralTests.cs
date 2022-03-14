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
    ///  Class for testing InventoryReferral
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class InventoryReferralTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for InventoryReferral
        //private InventoryReferral instance;

        public InventoryReferralTests()
        {
            // TODO uncomment below to create an instance of InventoryReferral
            //instance = new InventoryReferral();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of InventoryReferral
        /// </summary>
        [Fact]
        public void InventoryReferralInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" InventoryReferral
            //Assert.IsInstanceOfType<InventoryReferral> (instance, "variable 'instance' is a InventoryReferral");
        }


        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Fact]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }
        /// <summary>
        /// Test the property 'Created'
        /// </summary>
        [Fact]
        public void CreatedTest()
        {
            // TODO unit test for the property 'Created'
        }
        /// <summary>
        /// Test the property 'StartDate'
        /// </summary>
        [Fact]
        public void StartDateTest()
        {
            // TODO unit test for the property 'StartDate'
        }
        /// <summary>
        /// Test the property 'ExpiryDate'
        /// </summary>
        [Fact]
        public void ExpiryDateTest()
        {
            // TODO unit test for the property 'ExpiryDate'
        }
        /// <summary>
        /// Test the property 'UsageLimit'
        /// </summary>
        [Fact]
        public void UsageLimitTest()
        {
            // TODO unit test for the property 'UsageLimit'
        }
        /// <summary>
        /// Test the property 'CampaignId'
        /// </summary>
        [Fact]
        public void CampaignIdTest()
        {
            // TODO unit test for the property 'CampaignId'
        }
        /// <summary>
        /// Test the property 'AdvocateProfileIntegrationId'
        /// </summary>
        [Fact]
        public void AdvocateProfileIntegrationIdTest()
        {
            // TODO unit test for the property 'AdvocateProfileIntegrationId'
        }
        /// <summary>
        /// Test the property 'FriendProfileIntegrationId'
        /// </summary>
        [Fact]
        public void FriendProfileIntegrationIdTest()
        {
            // TODO unit test for the property 'FriendProfileIntegrationId'
        }
        /// <summary>
        /// Test the property 'Attributes'
        /// </summary>
        [Fact]
        public void AttributesTest()
        {
            // TODO unit test for the property 'Attributes'
        }
        /// <summary>
        /// Test the property 'ImportId'
        /// </summary>
        [Fact]
        public void ImportIdTest()
        {
            // TODO unit test for the property 'ImportId'
        }
        /// <summary>
        /// Test the property 'Code'
        /// </summary>
        [Fact]
        public void CodeTest()
        {
            // TODO unit test for the property 'Code'
        }
        /// <summary>
        /// Test the property 'UsageCounter'
        /// </summary>
        [Fact]
        public void UsageCounterTest()
        {
            // TODO unit test for the property 'UsageCounter'
        }
        /// <summary>
        /// Test the property 'BatchId'
        /// </summary>
        [Fact]
        public void BatchIdTest()
        {
            // TODO unit test for the property 'BatchId'
        }
        /// <summary>
        /// Test the property 'ReferredCustomers'
        /// </summary>
        [Fact]
        public void ReferredCustomersTest()
        {
            // TODO unit test for the property 'ReferredCustomers'
        }

    }

}
