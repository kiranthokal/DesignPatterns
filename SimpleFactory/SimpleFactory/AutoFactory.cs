using SimpleFactory.Autos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class AutoFactory
    {
        Dictionary<string, Type> autos;

        public AutoFactory()
        {
            LoadTypesInCarReturn();
        }

        public IAuto CreateInstance(string carname)
        {
            Type t = GetTypeToCreate(carname);

            if(t == null)
            {
                return new NullCar();
            }

            return Activator.CreateInstance(t) as IAuto;
        }

        private Type GetTypeToCreate(string carname)
        {
            foreach (var car in autos)
            {
                if(car.Key.ToString().Equals(carname.ToLower()))
                {
                    return autos[car.Key];
                }
            }

            return null;
        }

        private void LoadTypesInCarReturn()
        {
            autos = new Dictionary<string, Type>();

            var typesInAssembly = Assembly.GetExecutingAssembly().GetTypes();

            foreach(var type in typesInAssembly)
            {
                if(type.GetInterface(typeof(IAuto).ToString()) != null)
                {
                    autos.Add(type.Name.ToLower(), type);
                }
            }
        }
    }
}
