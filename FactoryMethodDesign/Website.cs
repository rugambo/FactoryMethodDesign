using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesign
{
    public class Website : AbstractSoftware
    {
        protected override IAuthentication BuildAuthorization()
        {
            SignInAuthentication signIn = new SignInAuthentication();

            //Console.WriteLine("Must return IAuthorization here");
            return signIn;
        }
    }
}
