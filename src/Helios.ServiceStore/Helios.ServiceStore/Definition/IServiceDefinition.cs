using System.Collections.Generic;

namespace Helios.ServiceStore.Definition
{
    public interface IServiceDefinition
    {
        /// <summary>
        /// The name of the service - used as the primary lookup criteria
        /// by nodes looking to access it
        /// </summary>
        string ServiceName { get; set; }

        /// <summary>
        /// A central hostname for the service, if applicable. Can be null.
        /// </summary>
        string HostName { get; set; }

        /// <summary>
        /// The list of available nodes in this service
        /// </summary>
        IList<Node> Nodes { get; }

        /// <summary>
        /// A DateTime.Ticks representation of the last time we heard anything
        /// from a node in this service
        /// </summary>
        long LastPulse { get; set; }
    }
}