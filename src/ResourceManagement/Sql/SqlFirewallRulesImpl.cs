// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.Sql.Fluent
{
    using ResourceManager.Fluent.Core;
    using ResourceManager.Fluent.Core.CollectionActions;
    using Models;
    using ResourceManager.Fluent.Core.ResourceActions;
    using SqlFirewallRules.SqlFirewallRulesCreatable;
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Implementation for SQLElasticPools and its parent interfaces.
    /// </summary>
    ///GENTHASH:Y29tLm1pY3Jvc29mdC5henVyZS5tYW5hZ2VtZW50LnNxbC5pbXBsZW1lbnRhdGlvbi5TcWxGaXJld2FsbFJ1bGVzSW1wbA==
    internal partial class SqlFirewallRulesImpl :
        IndependentChildrenImpl<ISqlFirewallRule, SqlFirewallRuleImpl, ServerFirewallRuleInner, IServersOperations, ISqlManager, ISqlServer>,
        ISqlFirewallRules,
        ISupportsGettingByParent<ISqlFirewallRule, ISqlServer, ISqlManager>,
        ISupportsListingByParent<ISqlFirewallRule, ISqlServer, ISqlManager>,
        ISqlFirewallRulesCreatable
    {
        ///GENMHASH:94CD9D1734A2AA402A84D7B04BE4E08E:0FCD47CBCD9128C3D4A03458C5796741
        internal SqlFirewallRulesImpl(ISqlManager manager)
            : base(manager.Inner.Servers, manager)
        {
        }

        ///GENMHASH:16CEA22B57032A6757D8EFC1BF423794:F46E4D0A3CDB6C5AE412BF5B7FB52B09
        public IReadOnlyList<ISqlFirewallRule> ListBySqlServer(string resourceGroupName, string sqlServerName)
        {
            return new List<ISqlFirewallRule>(this.ListByParent(resourceGroupName, sqlServerName));
        }

        ///GENMHASH:CD989F8A79EC70D56C4F5154E2B8BE11:57462F0C7FF757AFBBFD3B3561C9F9ED
        public IReadOnlyList<ISqlFirewallRule> ListBySqlServer(ISqlServer sqlServer)
        {
            return new List<ISqlFirewallRule>(this.ListByParent(sqlServer));
        }

        ///GENMHASH:21EB605E5FAA6C13D208A1A4CE8C136D:67032F38ECA8CBB405D18A2581390A32
        public async override Task<IPagedCollection<ISqlFirewallRule>> ListByParentAsync(string resourceGroupName, string parentName, CancellationToken cancellationToken = default(CancellationToken))
        {
            return await PagedCollection<ISqlFirewallRule, ServerFirewallRuleInner>.LoadPage(
                async (cancellation) => await Inner.ListFirewallRulesAsync(resourceGroupName, parentName, cancellation),
                WrapModel, cancellationToken);
        }

        ///GENMHASH:03C6F391A16F96A5127D98827B5423FA:877F7B73190881879934925547D57EAF
        public ISqlFirewallRule GetBySqlServer(string resourceGroup, string sqlServerName, string name)
        {
            return this.GetByParent(resourceGroup, sqlServerName, name);
        }

        ///GENMHASH:6B5394D9B9C62E3B4A3B037DD27B7A20:466DF29CB4850E0593B3C691F625BC2C
        public ISqlFirewallRule GetBySqlServer(ISqlServer sqlServer, string name)
        {
            return this.GetByParent(sqlServer, name);
        }

        ///GENMHASH:1F414E796475F1DA7286F29E3E27589D:9E40C7C36CC9390C7C5D4EB7F13D8D4A
        public async override Task DeleteByParentAsync(string groupName, string parentName, string name, CancellationToken cancellationToken = default(CancellationToken))
        {
            await Inner.DeleteFirewallRuleAsync(groupName, parentName, name, cancellationToken);
        }

        ///GENMHASH:E153333077E8B838087B8132AAA900EF:3E07C2B5BD84D8C41CD65F3910EFB3A1
        public ICreatable<ISqlFirewallRule> DefinedWithSqlServer(string resourceGroupName, string sqlServerName, string firewallRuleName)
        {
            ServerFirewallRuleInner inner = new ServerFirewallRuleInner();

            return new SqlFirewallRuleImpl(
                firewallRuleName,
                inner,
                Manager).WithExistingParentResource(resourceGroupName, sqlServerName);
        }

        ///GENMHASH:C32C5A59EBD92E91959156A49A8C1A95:D9AFFE54BAA276E6A6DADDEBF326C548
        public async override Task<ISqlFirewallRule> GetByParentAsync(string resourceGroup, string parentName, string name, CancellationToken cancellationToken = default(CancellationToken))
        {
            return WrapModel(await Inner.GetFirewallRuleAsync(resourceGroup, parentName, name, cancellationToken));
        }

        ///GENMHASH:2FE8C4C2D5EAD7E37787838DE0B47D92:09C3921CF8225D39924E9982602EA792
        protected override SqlFirewallRuleImpl WrapModel(string name)
        {
            throw new NotImplementedException("Should never hit this code, currently not exposed");
        }

        ///GENMHASH:D734C3213E38BC205A408E11AFDDF7CF:033629455E4435C44D01E364E80E84CE
        protected override ISqlFirewallRule WrapModel(ServerFirewallRuleInner inner)
        {
            if (inner == null)
            {
                return null;
            }
            return new SqlFirewallRuleImpl(inner.Name, inner, Manager);
        }
    }
}
