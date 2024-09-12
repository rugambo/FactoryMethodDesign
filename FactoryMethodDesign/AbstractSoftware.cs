using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesign
{
    public abstract class AbstractSoftware
    {
        abstract protected IAuthentication BuildAuthorization();

        public void AuthenticateSoftware()
        {
            IAuthentication newSignIn = BuildAuthorization();
            newSignIn.Authenticate();
        }
    }
}
