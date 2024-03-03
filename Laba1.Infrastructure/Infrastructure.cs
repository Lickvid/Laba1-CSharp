using Laba1.Application;
using Laba1.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1.Infrastructure 
{
   public class Infrastructure : ILaba1
    {
        private List<Politic> policy = new List<Politic>();
        public void AddObject(Politic politic)
        {
            policy.Add(politic);
        }
        public void RemoveObject(Politic politic)
        {
            policy.Remove(politic);
        }
    }
}
