namespace ProgrammingSkills
{
    using System.Collections.Generic;
    using System.ServiceModel;
    using System.ServiceModel.Description;
    using System.ServiceProcess;

    public class ServiceHost : ServiceHostBase
    {
        public ServiceHost()
        {
            this.Authorization.ServiceAuthorizationManager = new ServiceAuthorizationManager();
        }

        protected override ServiceDescription CreateDescription(out IDictionary<string, ContractDescription> implementedContracts)
        {
            throw new System.NotImplementedException();
        }
    }
}
