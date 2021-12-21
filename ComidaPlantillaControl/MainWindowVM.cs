using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComidaPlantillaControl
{
    class MainWindowVM : ObservableObject

    {

        private ObservableCollection<Comida> listaPlatos;

        public ObservableCollection<Comida> ListaPlatos
        {
            get { return listaPlatos; }
            set { SetProperty(ref listaPlatos, value); }
        }

        private ObservableCollection<string> tiposComida;

        public ObservableCollection<string> TiposComida
        {
            get { return tiposComida; }
            set { SetProperty(ref tiposComida, value); }
        }


        private Comida platoSeleccionado;

        public Comida PlatoSeleccionado
        {
            get { return platoSeleccionado; }
            set { SetProperty(ref platoSeleccionado, value); }
        }

        public MainWindowVM()
        {
            ListaPlatos = Comida.GetSamples();
            TiposComida = new ObservableCollection<string> { "Mexicana", "Americana", "China" };
        }

        public void QuitarSeleccion()
        {
            PlatoSeleccionado = null;
        }


    }
}
