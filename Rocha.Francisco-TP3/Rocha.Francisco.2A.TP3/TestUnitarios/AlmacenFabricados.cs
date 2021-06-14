using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Entidades;
using System.Text;

namespace TestUnitarios
{
    [TestClass]
    public class AlmacenFabricados
    {
        [TestMethod]
        public void ProbarSobrecargaOperadorMas_True()
        {
            AlmacenProdutosFabricados<Producto> Almacen;
            Almacen = "Test Method Francisco Rocha";

            Entidades.FabricaPC PC1 = new Entidades.FabricaPC(MarcaCPU.Intel, Procesador.i3_7100, Motherboard.GIGABYTE_GA_B250M_D3H, GPU.GTX_1070_TI_8GB, RAM.Corsair_Vengeance_LPX_16GB, Fuente.ASUS_ROG_Thor_850P, Gabinete.Razer_Tomahawk_ATX, SistemaOP.Windows_10, Almacenamiento.HDD_SATA_10TB, true, 4);

            Almacen += PC1;

            int indice = Almacen | PC1;

            Assert.IsTrue(indice != -1);
        }

        [TestMethod]
        public void ProbarSobrecargaOperadorMas_False()
        {
            AlmacenProdutosFabricados<Producto> Almacen;
            Almacen = "Test Method Francisco Rocha";

            Entidades.FabricaPC PC1 = new Entidades.FabricaPC(MarcaCPU.Intel, Procesador.i3_7100, Motherboard.GIGABYTE_GA_B250M_D3H, GPU.GTX_1070_TI_8GB, RAM.Corsair_Vengeance_LPX_16GB, Fuente.ASUS_ROG_Thor_850P, Gabinete.Razer_Tomahawk_ATX, SistemaOP.Windows_10, Almacenamiento.HDD_SATA_10TB, true, 4);
            Almacen += PC1;

            int indice = Almacen | PC1;

            Assert.IsFalse(indice == -1);
        }

        [TestMethod]
        public void ProbarCantidadGenerica_True()
        {
            AlmacenProdutosFabricados<Producto> Almacen;
            Almacen = "Test Method Francisco Rocha";

            Entidades.FabricaPC PC1 = new Entidades.FabricaPC(MarcaCPU.Intel, Procesador.i3_7100, Motherboard.GIGABYTE_GA_B250M_D3H, GPU.GTX_1070_TI_8GB, RAM.Corsair_Vengeance_LPX_16GB, Fuente.ASUS_ROG_Thor_850P, Gabinete.Razer_Tomahawk_ATX, SistemaOP.Windows_10, Almacenamiento.HDD_SATA_10TB, true, 4);
            Entidades.FabricaCelular Celular1 = new Entidades.FabricaCelular(MarcaCPU.Mediatek, GPU.Adreno_540, RAM._6GB, SistemaOP.Android_11, Almacenamiento._256GB, 498, Camara._24MP, Bateria._5000_mAh, MaterialCarcasa.Metal, PantallaPulgadas._6_1, PantallaResolucion._3840x2160_Pixeles, true, false);
           
            Almacen += PC1;
            Almacen += Celular1;

            Assert.IsTrue(2 == Almacen.CantidadGenerica);
        }

        [TestMethod]
        public void ProbarCantidadGenerica_False()
        {
            AlmacenProdutosFabricados<Producto> Almacen;
            Almacen = "Test Method Francisco Rocha";

            Entidades.FabricaPC PC1 = new Entidades.FabricaPC(MarcaCPU.Intel, Procesador.i3_7100, Motherboard.GIGABYTE_GA_B250M_D3H, GPU.GTX_1070_TI_8GB, RAM.Corsair_Vengeance_LPX_16GB, Fuente.ASUS_ROG_Thor_850P, Gabinete.Razer_Tomahawk_ATX, SistemaOP.Windows_10, Almacenamiento.HDD_SATA_10TB, true, 4);
            Entidades.FabricaCelular Celular1 = new Entidades.FabricaCelular(MarcaCPU.Mediatek, GPU.Adreno_540, RAM._6GB, SistemaOP.Android_11, Almacenamiento._256GB, 498, Camara._24MP, Bateria._5000_mAh, MaterialCarcasa.Metal, PantallaPulgadas._6_1, PantallaResolucion._3840x2160_Pixeles, true, false);

            Almacen += PC1;
            Almacen += Celular1;

            Assert.IsFalse(1 == Almacen.CantidadGenerica);
        }

        [TestMethod]
        public void ProbarDirectorioNull_True()
        {
            AlmacenProdutosFabricados<Producto> Almacen;
            Almacen = "Test Method Francisco Rocha";

            Assert.IsNull(Almacen.Directorio);
        }

        [TestMethod]
        public void ProbarDirectorioNull_False()
        {
            AlmacenProdutosFabricados<Producto> Almacen;
            Almacen = "Test Method Francisco Rocha";

            Almacen.Directorio = AppDomain.CurrentDomain.BaseDirectory + "ProductosFabricadosEnConsola.xml";
            Assert.IsNotNull(Almacen.Directorio);
        }

        [TestMethod]
        public void ProbarToStringNull_False()
        {
            AlmacenProdutosFabricados<Producto> Almacen;
            Almacen = "Test Method Francisco Rocha";

            Almacen.Directorio = AppDomain.CurrentDomain.BaseDirectory + "ProductosFabricadosEnConsola.xml";

            Entidades.FabricaPC PC1 = new Entidades.FabricaPC(MarcaCPU.Intel, Procesador.i3_7100, Motherboard.GIGABYTE_GA_B250M_D3H, GPU.GTX_1070_TI_8GB, RAM.Corsair_Vengeance_LPX_16GB, Fuente.ASUS_ROG_Thor_850P, Gabinete.Razer_Tomahawk_ATX, SistemaOP.Windows_10, Almacenamiento.HDD_SATA_10TB, true, 4);

            Almacen += PC1;

            Assert.IsNotNull(Almacen.ToString());
        }
    }
}