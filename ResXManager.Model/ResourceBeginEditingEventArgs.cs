﻿namespace tomenglertde.ResXManager.Model
{
    using System.ComponentModel;
    using System.Diagnostics.CodeAnalysis;
    using System.Diagnostics.Contracts;
    using System.Globalization;

    /// <summary>
    /// Provides data for the <see cref="ResourceManager.BeginEditing"/> event.
    /// </summary>
    public class ResourceBeginEditingEventArgs : CancelEventArgs
    {
        private readonly ResourceEntity _entity;
        private readonly CultureInfo _culture;

        public ResourceBeginEditingEventArgs(ResourceEntity entity, CultureInfo culture)
        {
            Contract.Requires(entity != null);
            _entity = entity;
            _culture = culture;
        }

        public CultureInfo Culture
        {
            get
            {
                return _culture;
            }
        }

        public ResourceEntity Entity
        {
            get
            {
                Contract.Ensures(Contract.Result<ResourceEntity>() != null);
                return _entity;
            }
        }

        [ContractInvariantMethod]
        [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Justification = "Required for code contracts.")]
        private void ObjectInvariant()
        {
            Contract.Invariant(_entity != null);
        }

    }
}
