namespace ServicesVeawerLib
{
    public struct Service
    {
        public string BehaviorName;
        public string ServiceBehaviorConfiguration;
        public string ServiceName;
        public string EndpointBinding;
        public string EndpointContract;
        public string BaseAddress;

        public Service(string behaviorName,string serviceBehaviorConfiguration, string serviceName,
            string endpointBinding, string endpointContract, string baseAddress)
        {
            this.BehaviorName = behaviorName;
            this.ServiceBehaviorConfiguration = serviceBehaviorConfiguration;
            this.ServiceName = serviceName;
            this.EndpointBinding = endpointBinding;
            this.EndpointContract = endpointContract;
            this.BaseAddress = baseAddress;
        }
    }
}

