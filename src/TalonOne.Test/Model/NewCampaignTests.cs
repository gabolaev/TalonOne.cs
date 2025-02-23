/* 
 * Talon.One API
 *
 * Use the Talon.One API to integrate with your application and to manage applications and campaigns:  - Use the operations in the [Integration API section](#integration-api) are used to integrate with our platform - Use the operation in the [Management API section](#management-api) to manage applications and campaigns.  ## Determining the base URL of the endpoints  The API is available at the same hostname as your Campaign Manager deployment. For example, if you access the Campaign Manager at `https://yourbaseurl.talon.one/`, the URL for the [updateCustomerSessionV2](https://docs.talon.one/integration-api#operation/updateCustomerSessionV2) endpoint is `https://yourbaseurl.talon.one/v2/customer_sessions/{Id}` 
 *
 * 
 * Contact: devs@talon.one
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
    ///  Class for testing NewCampaign
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class NewCampaignTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for NewCampaign
        //private NewCampaign instance;

        public NewCampaignTests()
        {
            // TODO uncomment below to create an instance of NewCampaign
            //instance = new NewCampaign();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of NewCampaign
        /// </summary>
        [Fact]
        public void NewCampaignInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" NewCampaign
            //Assert.IsInstanceOfType<NewCampaign> (instance, "variable 'instance' is a NewCampaign");
        }


        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Fact]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }
        /// <summary>
        /// Test the property 'Description'
        /// </summary>
        [Fact]
        public void DescriptionTest()
        {
            // TODO unit test for the property 'Description'
        }
        /// <summary>
        /// Test the property 'StartTime'
        /// </summary>
        [Fact]
        public void StartTimeTest()
        {
            // TODO unit test for the property 'StartTime'
        }
        /// <summary>
        /// Test the property 'EndTime'
        /// </summary>
        [Fact]
        public void EndTimeTest()
        {
            // TODO unit test for the property 'EndTime'
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
        /// Test the property 'State'
        /// </summary>
        [Fact]
        public void StateTest()
        {
            // TODO unit test for the property 'State'
        }
        /// <summary>
        /// Test the property 'ActiveRulesetId'
        /// </summary>
        [Fact]
        public void ActiveRulesetIdTest()
        {
            // TODO unit test for the property 'ActiveRulesetId'
        }
        /// <summary>
        /// Test the property 'Tags'
        /// </summary>
        [Fact]
        public void TagsTest()
        {
            // TODO unit test for the property 'Tags'
        }
        /// <summary>
        /// Test the property 'Features'
        /// </summary>
        [Fact]
        public void FeaturesTest()
        {
            // TODO unit test for the property 'Features'
        }
        /// <summary>
        /// Test the property 'CouponSettings'
        /// </summary>
        [Fact]
        public void CouponSettingsTest()
        {
            // TODO unit test for the property 'CouponSettings'
        }
        /// <summary>
        /// Test the property 'ReferralSettings'
        /// </summary>
        [Fact]
        public void ReferralSettingsTest()
        {
            // TODO unit test for the property 'ReferralSettings'
        }
        /// <summary>
        /// Test the property 'Limits'
        /// </summary>
        [Fact]
        public void LimitsTest()
        {
            // TODO unit test for the property 'Limits'
        }
        /// <summary>
        /// Test the property 'CampaignGroups'
        /// </summary>
        [Fact]
        public void CampaignGroupsTest()
        {
            // TODO unit test for the property 'CampaignGroups'
        }

    }

}
