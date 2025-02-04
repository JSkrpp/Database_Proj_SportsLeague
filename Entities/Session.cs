using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ligga
{
    public class Session
    {
        public Boolean isLogged;

        public Session()
        {
            this.isLogged = false;
        }

        public Boolean getStatus()
        {
            return this.isLogged;
        }
        public void setStatus(Boolean isLogged)
        {
            this.isLogged = isLogged;
        }

    }
}
