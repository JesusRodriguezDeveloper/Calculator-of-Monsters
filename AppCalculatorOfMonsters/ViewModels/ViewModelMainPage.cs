using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AppCalculatorOfMonsters.ViewModels
{
    public class ViewModelMainPage
    {

        //ObservableCollection<Monstruo> monstruos { get; set; }
        
        public ViewModelMainPage()
        {

            String jsonData = leerTexto();

            JObject principal = JObject.Parse(jsonData);

            System.Diagnostics.Debug.WriteLine(principal.First);
        }

        private String leerTexto() {

           return System.IO.File.ReadAllText(@"C:\Users\Santiago\Calculator-of-Monsters\AppCalculatorOfMonsters\Datos\monstruos.json");

        }
    }
}
