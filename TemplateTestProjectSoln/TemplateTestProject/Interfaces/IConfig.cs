using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateTestProject.Configuration;

namespace TemplateTestProject.Interfaces
{
    public interface IConfig
    {
        void GetBrowser(); 
        string GetUsername();
        string GetPassword();

    }
}
