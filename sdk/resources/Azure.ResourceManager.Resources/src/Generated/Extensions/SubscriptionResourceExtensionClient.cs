// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Resources
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _armApplicationApplicationsClientDiagnostics;
        private ApplicationsRestOperations _armApplicationApplicationsRestClient;
        private ClientDiagnostics _jitRequestClientDiagnostics;
        private JitRequestsRestOperations _jitRequestRestClient;
        private ClientDiagnostics _armDeploymentScriptDeploymentScriptsClientDiagnostics;
        private DeploymentScriptsRestOperations _armDeploymentScriptDeploymentScriptsRestClient;
        private ClientDiagnostics _templateSpecClientDiagnostics;
        private TemplateSpecsRestOperations _templateSpecRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class for mocking. </summary>
        protected SubscriptionResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SubscriptionResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics ArmApplicationApplicationsClientDiagnostics => _armApplicationApplicationsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Resources", ArmApplicationResource.ResourceType.Namespace, Diagnostics);
        private ApplicationsRestOperations ArmApplicationApplicationsRestClient => _armApplicationApplicationsRestClient ??= new ApplicationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(ArmApplicationResource.ResourceType));
        private ClientDiagnostics JitRequestClientDiagnostics => _jitRequestClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Resources", JitRequestResource.ResourceType.Namespace, Diagnostics);
        private JitRequestsRestOperations JitRequestRestClient => _jitRequestRestClient ??= new JitRequestsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(JitRequestResource.ResourceType));
        private ClientDiagnostics ArmDeploymentScriptDeploymentScriptsClientDiagnostics => _armDeploymentScriptDeploymentScriptsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Resources", ArmDeploymentScriptResource.ResourceType.Namespace, Diagnostics);
        private DeploymentScriptsRestOperations ArmDeploymentScriptDeploymentScriptsRestClient => _armDeploymentScriptDeploymentScriptsRestClient ??= new DeploymentScriptsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(ArmDeploymentScriptResource.ResourceType));
        private ClientDiagnostics TemplateSpecClientDiagnostics => _templateSpecClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Resources", TemplateSpecResource.ResourceType.Namespace, Diagnostics);
        private TemplateSpecsRestOperations TemplateSpecRestClient => _templateSpecRestClient ??= new TemplateSpecsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(TemplateSpecResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of ArmDeploymentResources in the SubscriptionResource. </summary>
        /// <returns> An object representing collection of ArmDeploymentResources and their operations over a ArmDeploymentResource. </returns>
        public virtual ArmDeploymentCollection GetArmDeployments()
        {
            return GetCachedClient(Client => new ArmDeploymentCollection(Client, Id));
        }

        /// <summary>
        /// Gets all the applications within a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Solutions/applications</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Applications_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ArmApplicationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ArmApplicationResource> GetArmApplicationsAsync(CancellationToken cancellationToken = default)
        {
            Core.HttpMessage FirstPageRequest(int? pageSizeHint) => ArmApplicationApplicationsRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            Core.HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ArmApplicationApplicationsRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ArmApplicationResource(Client, ArmApplicationData.DeserializeArmApplicationData(e)), ArmApplicationApplicationsClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetArmApplications", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all the applications within a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Solutions/applications</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Applications_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ArmApplicationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ArmApplicationResource> GetArmApplications(CancellationToken cancellationToken = default)
        {
            Core.HttpMessage FirstPageRequest(int? pageSizeHint) => ArmApplicationApplicationsRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            Core.HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ArmApplicationApplicationsRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ArmApplicationResource(Client, ArmApplicationData.DeserializeArmApplicationData(e)), ArmApplicationApplicationsClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetArmApplications", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Retrieves all JIT requests within the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Solutions/jitRequests</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>jitRequests_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="JitRequestResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<JitRequestResource> GetJitRequestDefinitionsAsync(CancellationToken cancellationToken = default)
        {
            Core.HttpMessage FirstPageRequest(int? pageSizeHint) => JitRequestRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new JitRequestResource(Client, JitRequestData.DeserializeJitRequestData(e)), JitRequestClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetJitRequestDefinitions", "value", null, cancellationToken);
        }

        /// <summary>
        /// Retrieves all JIT requests within the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Solutions/jitRequests</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>jitRequests_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="JitRequestResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<JitRequestResource> GetJitRequestDefinitions(CancellationToken cancellationToken = default)
        {
            Core.HttpMessage FirstPageRequest(int? pageSizeHint) => JitRequestRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            return PageableHelpers.CreatePageable(FirstPageRequest, null, e => new JitRequestResource(Client, JitRequestData.DeserializeJitRequestData(e)), JitRequestClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetJitRequestDefinitions", "value", null, cancellationToken);
        }

        /// <summary>
        /// Lists all deployment scripts for a given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Resources/deploymentScripts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeploymentScripts_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ArmDeploymentScriptResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ArmDeploymentScriptResource> GetArmDeploymentScriptsAsync(CancellationToken cancellationToken = default)
        {
            Core.HttpMessage FirstPageRequest(int? pageSizeHint) => ArmDeploymentScriptDeploymentScriptsRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            Core.HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ArmDeploymentScriptDeploymentScriptsRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ArmDeploymentScriptResource(Client, ArmDeploymentScriptData.DeserializeArmDeploymentScriptData(e)), ArmDeploymentScriptDeploymentScriptsClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetArmDeploymentScripts", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all deployment scripts for a given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Resources/deploymentScripts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeploymentScripts_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ArmDeploymentScriptResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ArmDeploymentScriptResource> GetArmDeploymentScripts(CancellationToken cancellationToken = default)
        {
            Core.HttpMessage FirstPageRequest(int? pageSizeHint) => ArmDeploymentScriptDeploymentScriptsRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            Core.HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ArmDeploymentScriptDeploymentScriptsRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ArmDeploymentScriptResource(Client, ArmDeploymentScriptData.DeserializeArmDeploymentScriptData(e)), ArmDeploymentScriptDeploymentScriptsClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetArmDeploymentScripts", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all the Template Specs within the specified subscriptions.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Resources/templateSpecs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TemplateSpecs_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> Allows for expansion of additional Template Spec details in the response. Optional. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="TemplateSpecResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<TemplateSpecResource> GetTemplateSpecsAsync(TemplateSpecExpandKind? expand = null, CancellationToken cancellationToken = default)
        {
            Core.HttpMessage FirstPageRequest(int? pageSizeHint) => TemplateSpecRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId, expand);
            Core.HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => TemplateSpecRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId, expand);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new TemplateSpecResource(Client, TemplateSpecData.DeserializeTemplateSpecData(e)), TemplateSpecClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetTemplateSpecs", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all the Template Specs within the specified subscriptions.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Resources/templateSpecs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TemplateSpecs_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> Allows for expansion of additional Template Spec details in the response. Optional. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="TemplateSpecResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<TemplateSpecResource> GetTemplateSpecs(TemplateSpecExpandKind? expand = null, CancellationToken cancellationToken = default)
        {
            Core.HttpMessage FirstPageRequest(int? pageSizeHint) => TemplateSpecRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId, expand);
            Core.HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => TemplateSpecRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId, expand);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new TemplateSpecResource(Client, TemplateSpecData.DeserializeTemplateSpecData(e)), TemplateSpecClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetTemplateSpecs", "value", "nextLink", cancellationToken);
        }
    }
}
