﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace AppCalculatorOfMonsters.ViewModels
{
    //Vie model de la ventana principal
    class MainPageViewModel
    {
        public MainPageViewModel()
        {
            cargadeDatos();
        }

        private async void cargadeDatos()
        {

            //apertura del fichero de forma asincrona pasando ruta.
            Uri uri = new Uri("ms-appx:///Datos/monstruos.json");
            System.Diagnostics.Debug.WriteLine("Ruta cogida= " + uri.AbsolutePath);
            StorageFile fichero = await StorageFile.GetFileFromApplicationUriAsync(uri);


            //lectura como texto plano de un fichero
            string salida = await Windows.Storage.FileIO.ReadTextAsync(fichero);


            //obtencion del objeto principal del json
            JObject principal = JObject.Parse(salida);

            System.Diagnostics.Debug.WriteLine("Hola mundo");
        }
    }
}
