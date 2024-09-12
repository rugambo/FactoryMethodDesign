using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesign
{
    public class SignInAuthentication : IAuthentication
    {
        public void Authenticate()
        {
            Console.WriteLine("Sign in to authenticate");

        }
    }
}
