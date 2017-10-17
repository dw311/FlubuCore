﻿namespace FlubuCore.Tasks.Utils
{
    /// <summary>
    /// Creates a service entry in the registry and Service Database.
    /// </summary>
    public class ServiceCreateTask : ServiceControlTaskBase<ServiceCreateTask>
    {
        public ServiceCreateTask(string serviceName, string pathToService) : base(StandardServiceControlCommands.Create.ToString(), serviceName)
        {
            WithArguments($"binPath={pathToService}");
        }

        /// <summary>
        /// Set start mode of the service.
        /// </summary>
        /// <param name="start"></param>
        /// <returns></returns>
        public ServiceCreateTask StartMode(ServiceStartMode start)
        {
            string arg;
            switch (start)
            {
                case ServiceStartMode.DelayedAuto:
                {
                    arg = "Delayed-Auto";
                    break;
                }
                default:
                {
                    arg = start.ToString();
                    break;
                }
            }

            WithArguments($"start={arg}");
            return this;
        }
    }
}
