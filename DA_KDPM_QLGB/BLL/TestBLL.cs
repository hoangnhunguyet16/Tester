using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class TestBLL
    {
        TestDAL testDAL = new TestDAL();

        public TestBLL() { }

        public string GetUserConnectionString()
        {
            return testDAL.LoadUserConnectionString();
        }
    }
}
