using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComidaPlantillaControl
{
    class Comida : ObservableObject
    {
        private string nombrePlato;
        public string NombrePlato
        {
            get => nombrePlato;
            set { SetProperty(ref nombrePlato, value); }
        }

        private string imagenPlato;
        public string ImagenPlato
        {
            get => imagenPlato;
            set { SetProperty(ref imagenPlato, value); }
        }
        private string tipoPlato;
        public string TipoPlato
        {
            get => tipoPlato;
            set { SetProperty(ref tipoPlato, value); }
        }
        private bool gluten;
        public bool Gluten
        {
            get => gluten;
            set { SetProperty(ref gluten, value); }
        }

        private bool soja;
        public bool Soja
        {
            get => soja;
            set { SetProperty(ref soja, value); }
        }

        private bool leche;
        public bool Leche
        {
            get => leche;
            set { SetProperty(ref leche, value); }
        }

        private bool sulfitos;
        public bool Sulfitos
        {
            get => sulfitos;
            set { SetProperty(ref sulfitos, value); }
        }

        public Comida(string nombrePlato, string imagenPlato, string tipoPlato, bool gluten, bool soja, bool leche, bool sulfitos)
        {
            NombrePlato = nombrePlato;
            ImagenPlato = imagenPlato;
            TipoPlato = tipoPlato;
            Gluten = gluten;
            Soja = soja;
            Leche = leche;
            Sulfitos = sulfitos;
        }

        public Comida()
        {
        }

        public static ObservableCollection<Comida> GetSamples()
        {
            ObservableCollection<Comida> lista = new ObservableCollection<Comida>();

            lista.Add(new Comida("Hamburguesa", @"./assets/burguer.jpg", "Americana", true, false, true, true));
            lista.Add(new Comida("Dumplings", "./assets/dumplings.jpg", "China", true, true, false, false));
            lista.Add(new Comida("Tacos",   "./assets/tacos.jpg", "Mexicana", true, false, false, true));
            lista.Add(new Comida("Cerdo agridulce", @"./assets/cerdoagridulce.jpg", "China", true, true, false, true));
            lista.Add(new Comida("Hot dogs","./assets/hotdog.jpg", "Americana", true, true, true, true));
            lista.Add(new Comida("Fajitas",  @"./assets/fajitas.jpg", "Mexicana", true, false, false, true));

            return lista;
        }

      
    }
}
