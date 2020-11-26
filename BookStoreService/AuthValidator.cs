using System;
using System.Collections.Generic;
using System.IdentityModel.Selectors;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace BookStoreService
{
    public class AuthValidator : UserNamePasswordValidator
    {
        public override void Validate(string userName, string password)
        {
            if (null == userName || null == password)
            {
                throw new ArgumentNullException();
            }

            if (!(userName == "test1" && password == "1tset"))
            {
                throw new FaultException("Unknown Username or Incorrect Password");
            }
        }
    }
}