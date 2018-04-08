using sistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema.DAL
{
    public class DataContextFactory
    {
        //Criando um novo objeto recebendo o data context
        private static sistemaDataContext dataContext;
         
        //Chamando o objeto principal
        public static sistemaDataContext DataContext {
            get {
                if (dataContext == null)
                    dataContext = new sistemaDataContext();
                return dataContext;
            }
        }
    }
}