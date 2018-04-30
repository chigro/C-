using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateTestProject.Interfaces;

namespace TemplateTestProject.Configuration
{
   public class AppConfigReader : IConfig 
    {
       public void GetBrowser()
        {
            
        }

       public string GetUsername()
       {
           throw new NotImplementedException();
       }

       public string GetPassword()
       {
           throw new NotImplementedException();
       }
    }
}
