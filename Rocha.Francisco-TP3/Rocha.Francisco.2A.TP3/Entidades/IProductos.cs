using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    public interface IProductos
    {
        int CODIGO_DE_BARRAS { get; set; }

        GPU GRAFICOS { get; set; }

        RAM MEMORIA_RAM { get; set; }

        MarcaCPU MARCA_CPU { get; set; }

        SistemaOP SISTEMA_OPERATIVO { get; set; }

        Almacenamiento ALMACENAMIENTO { get; set; }

        bool NoMostrar();

        string Informacion();
    }
}
