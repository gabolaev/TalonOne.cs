/* 
 * Talon.One API
 *
 * The Talon.One API is used to manage applications and campaigns, as well as to integrate with your application. The operations in the _Integration API_ section are used to integrate with our platform, while the other operations are used to manage applications and campaigns.  ### Where is the API?  The API is available at the same hostname as these docs. For example, if you are reading this page at `https://mycompany.talon.one/docs/api/`, the URL for the [updateCustomerProfile][] operation is `https://mycompany.talon.one/v1/customer_profiles/id`  [updateCustomerProfile]: #operation- -v1-customer_profiles- -integrationId- -put 
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
    ///  Class for testing Role
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class RoleTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for Role
        //private Role instance;

        public RoleTests()
        {
            // TODO uncomment below to create an instance of Role
            //instance = new Role();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of Role
        /// </summary>
        [Fact]
        public void RoleInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" Role
            //Assert.IsInstanceOfType<Role> (instance, "variable 'instance' is a Role");
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
        /// Test the property 'Modified'
        /// </summary>
        [Fact]
        public void ModifiedTest()
        {
            // TODO unit test for the property 'Modified'
        }
        /// <summary>
        /// Test the property 'AccountId'
        /// </summary>
        [Fact]
        public void AccountIdTest()
        {
            // TODO unit test for the property 'AccountId'
        }
        /// <summary>
        /// Test the property 'CampaignGroupID'
        /// </summary>
        [Fact]
        public void CampaignGroupIDTest()
        {
            // TODO unit test for the property 'CampaignGroupID'
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
        /// Test the property 'Members'
        /// </summary>
        [Fact]
        public void MembersTest()
        {
            // TODO unit test for the property 'Members'
        }
        /// <summary>
        /// Test the property 'Acl'
        /// </summary>
        [Fact]
        public void AclTest()
        {
            // TODO unit test for the property 'Acl'
        }

    }

}
