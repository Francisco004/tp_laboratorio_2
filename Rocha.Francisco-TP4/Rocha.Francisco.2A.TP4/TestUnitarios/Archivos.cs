using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Entidades;
using System.Text;

namespace TestUnitarios
{
    [TestClass]
    public class Archivos
    {
        #region Testeos
        [TestMethod]
        //Pruebo crear un archivo de LogErrores
        public void ProbarGuardarArchivoError()
        {
            string Prueba = "Test Method";
            Archivos<Producto>.LogErrores(Prueba);
        }

        [TestMethod]
        //Pruebo serializar el listado de productos fabricados
        public void ProbarGuardarListadoProductosFabricados()
        {
            AlmacenProdutosFabricados<Producto> Almacen;
            Almacen = "Fabrica de Francisco Rocha";
            Almacen.Directorio = AppDomain.CurrentDomain.BaseDirectory + "TestMethod.xml";

            Entidades.FabricaPC PC1 = new Entidades.FabricaPC(MarcaCPU.Intel, Procesador.i3_7100, Motherboard.GIGABYTE_GA_B250M_D3H, GPU.GTX_1070_TI_8GB, RAM.Corsair_Vengeance_LPX_16GB, Fuente.ASUS_ROG_Thor_850P, Gabinete.Razer_Tomahawk_ATX, SistemaOP.Windows_10, Almacenamiento.HDD_SATA_10TB, true, 44);
            Almacen += PC1;

            Archivos<Producto>.GuardarFabrica(Almacen);
        }

        [TestMethod]
        //Pruebo deserializar el almacen de productos fabricados
        public void ProbarCargarListadoProductosFabricados()
        {
            AlmacenProdutosFabricados<Producto> Almacen;
            Almacen = "TestMethod";

            AlmacenProdutosFabricados<Producto> Almacen2;
            Almacen2 = "TestMethod";

            Almacen.Directorio = AppDomain.CurrentDomain.BaseDirectory + "TestMethod.xml";
            Almacen2.Directorio = AppDomain.CurrentDomain.BaseDirectory + "TestMethod.xml";

            Entidades.FabricaPC PC1 = new Entidades.FabricaPC(MarcaCPU.Intel, Procesador.i3_7100, Motherboard.GIGABYTE_GA_B250M_D3H, GPU.GTX_1070_TI_8GB, RAM.Corsair_Vengeance_LPX_16GB, Fuente.ASUS_ROG_Thor_850P, Gabinete.Razer_Tomahawk_ATX, SistemaOP.Windows_10, Almacenamiento.HDD_SATA_10TB, true, 44);
            Almacen += PC1;

            Archivos<Producto>.GuardarFabrica(Almacen);

            Almacen2 = Archivos<Producto>.CargarFabrica(Almacen2);

            Assert.IsTrue(Almacen.CantidadGenerica == Almacen2.CantidadGenerica);
        }
        #endregion   
    }
}