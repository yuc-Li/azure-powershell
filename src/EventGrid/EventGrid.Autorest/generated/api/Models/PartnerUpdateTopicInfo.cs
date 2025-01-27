// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Extensions;

    /// <summary>Update properties for the corresponding partner topic of a channel.</summary>
    public partial class PartnerUpdateTopicInfo :
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IPartnerUpdateTopicInfo,
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IPartnerUpdateTopicInfoInternal
    {

        /// <summary>Backing field for <see cref="EventTypeInfo" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IEventTypeInfo _eventTypeInfo;

        /// <summary>Event type info for the partner topic</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IEventTypeInfo EventTypeInfo { get => (this._eventTypeInfo = this._eventTypeInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.EventTypeInfo()); set => this._eventTypeInfo = value; }

        /// <summary>
        /// A collection of inline event types for the resource. The inline event type keys are of type string which represents the
        /// name of the event.
        /// An example of a valid inline event name is "Contoso.OrderCreated".
        /// The inline event type values are of type InlineEventProperties and will contain additional information for every inline
        /// event type.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IEventTypeInfoInlineEventTypes EventTypeInfoInlineEventType { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IEventTypeInfoInternal)EventTypeInfo).InlineEventType; set => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IEventTypeInfoInternal)EventTypeInfo).InlineEventType = value ?? null /* model class */; }

        /// <summary>The kind of event type used.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PropertyOrigin.Inlined)]
        public string EventTypeInfoKind { get => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IEventTypeInfoInternal)EventTypeInfo).Kind; set => ((Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IEventTypeInfoInternal)EventTypeInfo).Kind = value ?? null; }

        /// <summary>Internal Acessors for EventTypeInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IEventTypeInfo Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IPartnerUpdateTopicInfoInternal.EventTypeInfo { get => (this._eventTypeInfo = this._eventTypeInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.EventTypeInfo()); set { {_eventTypeInfo = value;} } }

        /// <summary>Creates an new <see cref="PartnerUpdateTopicInfo" /> instance.</summary>
        public PartnerUpdateTopicInfo()
        {

        }
    }
    /// Update properties for the corresponding partner topic of a channel.
    public partial interface IPartnerUpdateTopicInfo :
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.IJsonSerializable
    {
        /// <summary>
        /// A collection of inline event types for the resource. The inline event type keys are of type string which represents the
        /// name of the event.
        /// An example of a valid inline event name is "Contoso.OrderCreated".
        /// The inline event type values are of type InlineEventProperties and will contain additional information for every inline
        /// event type.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"A collection of inline event types for the resource. The inline event type keys are of type string which represents the name of the event.
        An example of a valid inline event name is ""Contoso.OrderCreated"".
        The inline event type values are of type InlineEventProperties and will contain additional information for every inline event type.",
        SerializedName = @"inlineEventTypes",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IEventTypeInfoInlineEventTypes) })]
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IEventTypeInfoInlineEventTypes EventTypeInfoInlineEventType { get; set; }
        /// <summary>The kind of event type used.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The kind of event type used.",
        SerializedName = @"kind",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PSArgumentCompleterAttribute("Inline")]
        string EventTypeInfoKind { get; set; }

    }
    /// Update properties for the corresponding partner topic of a channel.
    internal partial interface IPartnerUpdateTopicInfoInternal

    {
        /// <summary>Event type info for the partner topic</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IEventTypeInfo EventTypeInfo { get; set; }
        /// <summary>
        /// A collection of inline event types for the resource. The inline event type keys are of type string which represents the
        /// name of the event.
        /// An example of a valid inline event name is "Contoso.OrderCreated".
        /// The inline event type values are of type InlineEventProperties and will contain additional information for every inline
        /// event type.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IEventTypeInfoInlineEventTypes EventTypeInfoInlineEventType { get; set; }
        /// <summary>The kind of event type used.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PSArgumentCompleterAttribute("Inline")]
        string EventTypeInfoKind { get; set; }

    }
}