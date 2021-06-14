using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            AlmacenProdutosFabricados<Producto> AlmacenFabrica;

            ////Creo un almacen 
            AlmacenFabrica = "Productos fabricados de Francisco Rocha";

            ////Le asigno el directorio al almacen para cargar y guardar los datos XML
            AlmacenFabrica.Directorio = AppDomain.CurrentDomain.BaseDirectory + "ProductosFabricadosEnConsola.xml";

            ////Fabrico las PC en caso de tener componentes y codigo de barras compatibles
            FabricaPC PC1 = new FabricaPC(MarcaCPU.Intel, Procesador.i3_7100, Motherboard.GIGABYTE_GA_B250M_D3H, GPU.GTX_1070_TI_8GB, RAM.Corsair_Vengeance_LPX_16GB, Fuente.ASUS_ROG_Thor_850P, Gabinete.Razer_Tomahawk_ATX, SistemaOP.Windows_10, Almacenamiento.HDD_SATA_10TB, true, 4);
            FabricaPC PC2 = new FabricaPC(MarcaCPU.Intel, Procesador.i9_10900k, Motherboard.GIGABYTE_Z390_AORUS_PRO, GPU.RTX_3080_TI_12GB, RAM.Corsair_Vengeance_LPX_16GB, Fuente.ASUS_ROG_Thor_850P, Gabinete.Razer_Tomahawk_ATX, SistemaOP.Windows_10, Almacenamiento.SSD_ADATA_SU800_256GB, true, 4);
            FabricaPC PC3 = new FabricaPC(MarcaCPU.Intel, Procesador.i9_10900, Motherboard.GIGABYTE_GA_B250M_D3H, GPU.RX_5700XT_8GB, RAM.XPG_Spectrix_D80_32GB, Fuente.Bitfenix_Formula_650W, Gabinete.Razer_Tomahawk_ATX, SistemaOP.Windows_7, Almacenamiento.SSD_Samsung_860_PRO_516GB, true, 44);
            FabricaPC PC4 = new FabricaPC(MarcaCPU.Mediatek, Procesador.i3_7100, Motherboard.ASUS_TUF_X299_MARK, GPU.RX_6800XT_16GB, RAM.TeamGroup_Xcalibur_RGB_16GB, Fuente.ASUS_ROG_Thor_850P, Gabinete.Razer_Tomahawk_ATX, SistemaOP.Linux_Ubuntu, Almacenamiento.SSD_Kioxia_Exceria_SSD_480GB, true, 48);
            FabricaPC PC5 = new FabricaPC(MarcaCPU.AMD, Procesador.AMD_Ryzen_9_5900X, Motherboard.ASUS_ROG_Strix_B550_F_Gaming, GPU.RTX_2060_Super_8GB, RAM.GSkill_TridentZ_8GB, Fuente.Corsair_SF600_Platinum, Gabinete.Razer_Tomahawk_ATX, SistemaOP.Linux_Debian, Almacenamiento.SSD_Crucial_MX500_2TB, false, 455);
            FabricaPC PC6 = new FabricaPC(MarcaCPU.AMD, Procesador.AMD_Ryzen_5_3400G, Motherboard.MSI_MPG_B550_GAMING_EDGE, GPU.RTX_2080_8GB, RAM.HyperX_Fury_RGB_8GB, Fuente.ASUS_ROG_Thor_850P, Gabinete.Razer_Tomahawk_ATX, SistemaOP.Linux_Ubuntu, Almacenamiento.SSD_Kingston_A400_2TB, false, 3);

            ////Esta PC se añade ya que tiene componentes y codigo de barras compatible
            AlmacenFabrica += PC1;

            ////Esta PC no se añade debido a que tiene el mismo codigo de barras que el de arriba
            AlmacenFabrica += PC2;

            ////Estas PCs no se añaden debido a que no tienen componentes compatibles
            AlmacenFabrica += PC3;
            AlmacenFabrica += PC4;

            ////Estas PCs se añaden ya que tienen componentes y codigo de barras compatibles
            AlmacenFabrica += PC5;
            AlmacenFabrica += PC6;


            ////Fabrico los Celulares en caso de tener componentes y codigo de barras compatibles 
            FabricaCelular Celular1 = new FabricaCelular(MarcaCPU.Mediatek, GPU.Adreno_540, RAM._6GB, SistemaOP.Android_11, Almacenamiento._256GB, 498, Camara._24MP, Bateria._5000_mAh, MaterialCarcasa.Metal, PantallaPulgadas._6_1, PantallaResolucion._3840x2160_Pixeles, true, false);
            FabricaCelular Celular2 = new FabricaCelular(MarcaCPU.HiSilicon, GPU.Adreno_650, RAM._16GB, SistemaOP.Android_Lollipop, Almacenamiento._128GB, 4, Camara._24MP, Bateria._5000_mAh, MaterialCarcasa.Metal, PantallaPulgadas._6_1, PantallaResolucion._3840x2160_Pixeles, true, false);

            ////Este Celular se añade ya que tiene componentes y codigo de barras compatibles
            AlmacenFabrica += Celular1;

            ////Esta Celular no se añade debido a que tiene el mismo codigo de barras que el de PC1
            AlmacenFabrica += Celular2;

            //Muestro los datos cargados del almacen
            Console.WriteLine(AlmacenFabrica.ToString());

            ////Guardo los datos del almacen en un xml que se encuentra en el path de la linea 20
            Archivos<Producto>.GuardarFabrica(AlmacenFabrica);

            Console.ReadKey(true);



            Console.WriteLine("\n\n\n**********************************ALMACEN QUE FUE COPIADO DEL XML**********************************\n\n\n\n");


            ////Almacen al que se le van a asignar los datos guardados del XML
            AlmacenProdutosFabricados<Producto> AlmacenCopiado;

            ////Creo un almacen 
            AlmacenCopiado = "AlmacenCopiado";

            ////Le asigno el directorio al almacen para cargar y guardar los datos XML
            AlmacenCopiado.Directorio = AppDomain.CurrentDomain.BaseDirectory + "ProductosFabricadosEnConsola.xml";

            //Cargo los datos de Almacen a AlmacenCopiado
            AlmacenCopiado = Archivos<Producto>.CargarFabrica(AlmacenCopiado);

            ////Muestro el Almacen Copiado
            Console.WriteLine(AlmacenCopiado.ToString());

            Console.ReadKey(true);
        }
    }
}
