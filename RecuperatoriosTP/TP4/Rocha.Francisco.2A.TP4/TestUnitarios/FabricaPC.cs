using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Entidades;
using System.Text;

namespace TestUnitarios
{
    [TestClass]
    public class FabricaPC
    {
        #region Testeos
        [TestMethod]
        //Pruebo si la sobrecarga del operador igual del producto es verdadera
        public void ProbarSobrecaraIgual_True()
        {
            Entidades.FabricaPC PC1 = new Entidades.FabricaPC(MarcaCPU.Intel, Procesador.i3_7100, Motherboard.GIGABYTE_GA_B250M_D3H, GPU.GTX_1070_TI_8GB, RAM.Corsair_Vengeance_LPX_16GB, Fuente.ASUS_ROG_Thor_850P, Gabinete.Razer_Tomahawk_ATX, SistemaOP.Windows_10, Almacenamiento.HDD_SATA_10TB, true, 44);
            Entidades.FabricaPC PC2 = new Entidades.FabricaPC(MarcaCPU.Intel, Procesador.i3_7100, Motherboard.GIGABYTE_GA_B250M_D3H, GPU.GTX_1070_TI_8GB, RAM.Corsair_Vengeance_LPX_16GB, Fuente.ASUS_ROG_Thor_850P, Gabinete.Razer_Tomahawk_ATX, SistemaOP.Windows_10, Almacenamiento.HDD_SATA_10TB, true, 44);

            Assert.IsTrue(PC1 == PC2);
        }

        [TestMethod]
        //Pruebo si la sobrecarga del operador igual del producto es falsa
        public void ProbarSobrecaraIgual_False()
        {
            Entidades.FabricaPC PC1 = new Entidades.FabricaPC(MarcaCPU.Intel, Procesador.i3_7100, Motherboard.GIGABYTE_GA_B250M_D3H, GPU.GTX_1070_TI_8GB, RAM.Corsair_Vengeance_LPX_16GB, Fuente.ASUS_ROG_Thor_850P, Gabinete.Razer_Tomahawk_ATX, SistemaOP.Windows_10, Almacenamiento.HDD_SATA_10TB, true, 44);
            Entidades.FabricaPC PC2 = new Entidades.FabricaPC(MarcaCPU.AMD, Procesador.AMD_Ryzen_5_3600X, Motherboard.ASUS_Prime_B450M_A_II, GPU.RTX_3080_TI_12GB, RAM.Corsair_Vengeance_LPX_16GB, Fuente.ASUS_ROG_Thor_850P, Gabinete.Razer_Tomahawk_ATX, SistemaOP.Windows_10, Almacenamiento.SSD_ADATA_SU800_256GB, true, 45);

            Assert.IsFalse(PC1 == PC2);
        }

        [TestMethod]
        //Pruebo si la sobrecarga del operador distinto del producto es verdadera
        public void ProbarSobrecaraDistinto_True()
        {
            Entidades.FabricaPC PC2 = new Entidades.FabricaPC(MarcaCPU.Intel, Procesador.i7_7700, Motherboard.GIGABYTE_GA_B250M_D3H, GPU.RTX_3080_TI_12GB, RAM.Corsair_Vengeance_LPX_16GB, Fuente.ASUS_ROG_Thor_850P, Gabinete.Razer_Tomahawk_ATX, SistemaOP.Windows_10, Almacenamiento.SSD_ADATA_SU800_256GB, true, 45);
            Entidades.FabricaPC PC3 = new Entidades.FabricaPC(MarcaCPU.Intel, Procesador.i9_10900k, Motherboard.GIGABYTE_Z390_AORUS_PRO, GPU.RTX_3080_TI_12GB, RAM.Corsair_Vengeance_LPX_16GB, Fuente.ASUS_ROG_Thor_850P, Gabinete.Razer_Tomahawk_ATX, SistemaOP.Windows_10, Almacenamiento.SSD_ADATA_SU800_256GB, true, 44);

            Assert.IsTrue(PC2 != PC3);
        }

        [TestMethod]
        //Pruebo si la sobrecarga del operador distinto del producto es falsa
        public void ProbarSobrecaraDistinto_False()
        {
            Entidades.FabricaPC PC1 = new Entidades.FabricaPC(MarcaCPU.Intel, Procesador.i3_7100, Motherboard.GIGABYTE_GA_B250M_D3H, GPU.GTX_1070_TI_8GB, RAM.Corsair_Vengeance_LPX_16GB, Fuente.ASUS_ROG_Thor_850P, Gabinete.Razer_Tomahawk_ATX, SistemaOP.Windows_10, Almacenamiento.HDD_SATA_10TB, true, 44);
            Entidades.FabricaPC PC3 = new Entidades.FabricaPC(MarcaCPU.Intel, Procesador.i9_10900k, Motherboard.GIGABYTE_Z390_AORUS_PRO, GPU.RTX_3080_TI_12GB, RAM.Corsair_Vengeance_LPX_16GB, Fuente.ASUS_ROG_Thor_850P, Gabinete.Razer_Tomahawk_ATX, SistemaOP.Windows_10, Almacenamiento.SSD_ADATA_SU800_256GB, true, 44);

            Assert.IsFalse(PC1 != PC3);
        }


        [TestMethod]
        //Pruebo si la sobrecarga del equals del producto es verdadera
        public void ProbarEquals_True()
        {
            Entidades.FabricaPC PC1 = new Entidades.FabricaPC(MarcaCPU.Intel, Procesador.i3_7100, Motherboard.GIGABYTE_GA_B250M_D3H, GPU.GTX_1070_TI_8GB, RAM.Corsair_Vengeance_LPX_16GB, Fuente.ASUS_ROG_Thor_850P, Gabinete.Razer_Tomahawk_ATX, SistemaOP.Windows_10, Almacenamiento.HDD_SATA_10TB, true, 44);
            Entidades.FabricaPC PC3 = new Entidades.FabricaPC(MarcaCPU.Intel, Procesador.i9_10900k, Motherboard.GIGABYTE_Z390_AORUS_PRO, GPU.RTX_3080_TI_12GB, RAM.Corsair_Vengeance_LPX_16GB, Fuente.ASUS_ROG_Thor_850P, Gabinete.Razer_Tomahawk_ATX, SistemaOP.Windows_10, Almacenamiento.SSD_ADATA_SU800_256GB, true, 44);

            Assert.IsTrue(PC1.Equals(PC3));
        }

        [TestMethod]
        //Pruebo si la sobrecarga del equals del producto es falsa
        public void ProbarEquals_False()
        {
            Entidades.FabricaPC PC2 = new Entidades.FabricaPC(MarcaCPU.Intel, Procesador.i7_7700, Motherboard.GIGABYTE_GA_B250M_D3H, GPU.RTX_3080_TI_12GB, RAM.Corsair_Vengeance_LPX_16GB, Fuente.ASUS_ROG_Thor_850P, Gabinete.Razer_Tomahawk_ATX, SistemaOP.Windows_10, Almacenamiento.SSD_ADATA_SU800_256GB, true, 45);
            Entidades.FabricaPC PC3 = new Entidades.FabricaPC(MarcaCPU.Intel, Procesador.i9_10900k, Motherboard.GIGABYTE_Z390_AORUS_PRO, GPU.RTX_3080_TI_12GB, RAM.Corsair_Vengeance_LPX_16GB, Fuente.ASUS_ROG_Thor_850P, Gabinete.Razer_Tomahawk_ATX, SistemaOP.Windows_10, Almacenamiento.SSD_ADATA_SU800_256GB, true, 44);

            Assert.IsFalse(PC2.Equals(PC3));
        }

        [TestMethod]
        //Pruebo si el metodo no mostrar retorna true
        public void ProbarNoMostrar_True()
        {
            Entidades.FabricaPC PC4 = new Entidades.FabricaPC(MarcaCPU.Mediatek, Procesador.i3_7100, Motherboard.ASUS_TUF_X299_MARK, GPU.RX_6800XT_16GB, RAM.TeamGroup_Xcalibur_RGB_16GB, Fuente.ASUS_ROG_Thor_850P, Gabinete.Razer_Tomahawk_ATX, SistemaOP.Linux_Ubuntu, Almacenamiento.SSD_Kioxia_Exceria_SSD_480GB, true, 48);

            Assert.IsTrue(PC4.NoMostrar());
        }

        [TestMethod]
        //Pruebo si el metodo no mostrar retorna false
        public void ProbarNoMostrar_False()
        {
            Entidades.FabricaPC PC1 = new Entidades.FabricaPC(MarcaCPU.Intel, Procesador.i3_7100, Motherboard.GIGABYTE_GA_B250M_D3H, GPU.GTX_1070_TI_8GB, RAM.Corsair_Vengeance_LPX_16GB, Fuente.ASUS_ROG_Thor_850P, Gabinete.Razer_Tomahawk_ATX, SistemaOP.Windows_10, Almacenamiento.HDD_SATA_10TB, true, 44);

            Assert.IsFalse(PC1.NoMostrar());
        }

        [TestMethod]
        //Pruebo si una PC es de tipo IProducto
        public void ProbarInstancia_True()
        {
            Entidades.FabricaPC PC1 = new Entidades.FabricaPC(MarcaCPU.Intel, Procesador.i3_7100, Motherboard.GIGABYTE_GA_B250M_D3H, GPU.GTX_1070_TI_8GB, RAM.Corsair_Vengeance_LPX_16GB, Fuente.ASUS_ROG_Thor_850P, Gabinete.Razer_Tomahawk_ATX, SistemaOP.Windows_10, Almacenamiento.HDD_SATA_10TB, true, 44);

            Assert.IsInstanceOfType(PC1, typeof(IProductos));
        }

        [TestMethod]
        //Pruebo si una PC es de tipo Almacen
        public void ProbarInstancia_False()
        {
            Entidades.FabricaPC PC1 = new Entidades.FabricaPC(MarcaCPU.Intel, Procesador.i3_7100, Motherboard.GIGABYTE_GA_B250M_D3H, GPU.GTX_1070_TI_8GB, RAM.Corsair_Vengeance_LPX_16GB, Fuente.ASUS_ROG_Thor_850P, Gabinete.Razer_Tomahawk_ATX, SistemaOP.Windows_10, Almacenamiento.HDD_SATA_10TB, true, 44);

            Assert.IsNotInstanceOfType(PC1, typeof(AlmacenProdutosFabricados<IProductos>));
        }

        [TestMethod]
        //Pruebo si la informacion de la PC no es nula
        public void ProbarInformacion_NoNull()
        {
            Entidades.FabricaPC PC1 = new Entidades.FabricaPC(MarcaCPU.Intel, Procesador.i3_7100, Motherboard.GIGABYTE_GA_B250M_D3H, GPU.GTX_1070_TI_8GB, RAM.Corsair_Vengeance_LPX_16GB, Fuente.ASUS_ROG_Thor_850P, Gabinete.Razer_Tomahawk_ATX, SistemaOP.Windows_10, Almacenamiento.HDD_SATA_10TB, true, 44);

            Assert.IsNotNull(PC1.Informacion());
        }

        [TestMethod]
        //Pruebo si los metodos validar funcionan en caso de ingresar componentes correctos
        public void ProbarValidacionComponentes_True()
        {
            Entidades.FabricaPC PC1 = new Entidades.FabricaPC(MarcaCPU.Intel, Procesador.i3_7100, Motherboard.GIGABYTE_GA_B250M_D3H, GPU.GTX_1070_TI_8GB, RAM.Corsair_Vengeance_LPX_16GB, Fuente.ASUS_ROG_Thor_850P, Gabinete.Razer_Tomahawk_ATX, SistemaOP.Windows_10, Almacenamiento.HDD_SATA_10TB, true, 44);

            Assert.IsNotNull(PC1.ValidarGpu(PC1.GRAFICOS));
            Assert.IsNotNull(PC1.ValidarRam(PC1.MEMORIA_RAM));
            Assert.IsNotNull(PC1.ValidarMarca(PC1.MARCA_CPU));
            Assert.IsNotNull(PC1.ValidarAlmacenamiento(PC1.ALMACENAMIENTO));
            Assert.IsNotNull(PC1.ValidarSistemaOperativo(PC1.SISTEMA_OPERATIVO));
        }
        #endregion
    }
}
