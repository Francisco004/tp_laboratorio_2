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
            SQLPC SQLPC = new SQLPC();
            SQLCelular SQLCelular = new SQLCelular();
            SQLAlmacen SQLAlmacen = new SQLAlmacen();
            AlmacenProdutosFabricados<Producto> AlmacenFabrica;

            ////Creo un almacen 
            AlmacenFabrica = "Productos fabricados de Francisco Rocha";

            ////Le asigno el directorio al almacen para cargar y guardar los datos XML
            AlmacenFabrica.Directorio = AppDomain.CurrentDomain.BaseDirectory + "ProductosFabricadosEnConsola.xml";

            ////Fabrico las PC en caso de tener componentes y codigo de barras compatibles
            FabricaPC PC1 = new FabricaPC(MarcaCPU.Intel, Procesador.i3_7100, Motherboard.GIGABYTE_GA_B250M_D3H, GPU.GTX_1070_TI_8GB, RAM.Corsair_Vengeance_LPX_16GB, Fuente.ASUS_ROG_Thor_850P, Gabinete.Razer_Tomahawk_ATX, SistemaOP.Windows_10, Almacenamiento.HDD_SATA_10TB, true, 123123);
            FabricaPC PC2 = new FabricaPC(MarcaCPU.Intel, Procesador.i9_10900k, Motherboard.GIGABYTE_Z390_AORUS_PRO, GPU.RTX_3080_TI_12GB, RAM.Corsair_Vengeance_LPX_16GB, Fuente.ASUS_ROG_Thor_850P, Gabinete.Razer_Tomahawk_ATX, SistemaOP.Windows_10, Almacenamiento.SSD_ADATA_SU800_256GB, true, 123123);
            FabricaPC PC3 = new FabricaPC(MarcaCPU.Intel, Procesador.i9_10900, Motherboard.GIGABYTE_GA_B250M_D3H, GPU.RX_5700XT_8GB, RAM.XPG_Spectrix_D80_32GB, Fuente.Bitfenix_Formula_650W, Gabinete.Razer_Tomahawk_ATX, SistemaOP.Windows_7, Almacenamiento.SSD_Samsung_860_PRO_516GB, true, 456854);
            FabricaPC PC4 = new FabricaPC(MarcaCPU.Mediatek, Procesador.i3_7100, Motherboard.ASUS_TUF_X299_MARK, GPU.RX_6800XT_16GB, RAM.TeamGroup_Xcalibur_RGB_16GB, Fuente.ASUS_ROG_Thor_850P, Gabinete.Razer_Tomahawk_ATX, SistemaOP.Linux_Ubuntu, Almacenamiento.SSD_Kioxia_Exceria_SSD_480GB, true, 945132);
            FabricaPC PC5 = new FabricaPC(MarcaCPU.AMD, Procesador.AMD_Ryzen_9_5900X, Motherboard.ASUS_ROG_Strix_B550_F_Gaming, GPU.RTX_2060_Super_8GB, RAM.GSkill_TridentZ_8GB, Fuente.Corsair_SF600_Platinum, Gabinete.Razer_Tomahawk_ATX, SistemaOP.Linux_Debian, Almacenamiento.SSD_Crucial_MX500_2TB, false, 612458);
            FabricaPC PC6 = new FabricaPC(MarcaCPU.AMD, Procesador.AMD_Ryzen_5_3400G, Motherboard.MSI_MPG_B550_GAMING_EDGE, GPU.RTX_2080_8GB, RAM.HyperX_Fury_RGB_8GB, Fuente.ASUS_ROG_Thor_850P, Gabinete.Razer_Tomahawk_ATX, SistemaOP.Linux_Ubuntu, Almacenamiento.SSD_Kingston_A400_2TB, false, 128745);
            FabricaPC PC7 = new FabricaPC(MarcaCPU.Intel, Procesador.i3_7100, Motherboard.GIGABYTE_GA_B250M_D3H, GPU.GTX_1070_TI_8GB, RAM.Corsair_Vengeance_LPX_16GB, Fuente.ASUS_ROG_Thor_850P, Gabinete.Razer_Tomahawk_ATX, SistemaOP.Windows_10, Almacenamiento.HDD_SATA_10TB, true, 68454872);


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


            Console.WriteLine("Muestro los datos del Almacen");
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey(true);
            Console.Clear();

            //Muestro los datos cargados del almacen
            Console.WriteLine(AlmacenFabrica.ToString());

            ////Guardo los datos del almacen en un xml que se encuentra en el path de la linea 20
            Archivos<Producto>.GuardarFabrica(AlmacenFabrica);




            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey(true);
            Console.Clear();




            Console.WriteLine("**********************************ALMACEN QUE FUE COPIADO DEL XML**********************************\n\n");
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey(true);

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




            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey(true);
            Console.Clear();




            ////Pruebo la excepcion personalizada
            Console.WriteLine("Pruebo la excepcion personalizada");
            try
            {
                AlmacenFabrica.BuscarUPC("64655465");
            }
            catch (NoSeEncontroException ex)
            {
                Console.WriteLine("Excepcion: " + ex.InformarExcepcion());

                ////Pruebo el log de errores que se guarda en mi documentos
                Console.WriteLine("Se guardo el error en mis documentos...");
                Archivos<IProductos>.LogErrores(ex.InformarExcepcion());
            }

            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey(true);
            Console.Clear();




            //Trato de insertar una pc en Tabla_PC
            Console.WriteLine("Ingreso una PC a Tabla_PC en el SQL");
            try
            {
                SQLPC.InsertarPC(PC1);
            }
            catch (ConexionSQLException ex)
            {
                Console.WriteLine(ex.InformarExcepcionSQL());
            }
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey(true);
            Console.Clear();




            //Trato de obtener todas las PC que tengo en la Tabla_PC
            Console.WriteLine("Cargo las PC que guarde en el SQL al almacen");
            AlmacenProdutosFabricados<Producto> AlmacenSQL;
            AlmacenSQL = "Productos del SQL";
            try
            {
                AlmacenSQL = SQLPC.ObtenerListaDato(AlmacenSQL);
            }
            catch (ConexionSQLException ex)
            {
                Console.WriteLine(ex.InformarExcepcionSQL());
            }
            Console.WriteLine(AlmacenSQL.ToString());
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey(true);
            Console.Clear();




            //Trato de borrar la pc de Tabla_PC cargada en el punto anterior
            Console.WriteLine("Borro la PC cargada de la Tabla_PC");
            try
            {
                SQLPC.BorrarPC(PC1.CODIGO_DE_BARRAS);
            }
            catch (ConexionSQLException ex)
            {
                Console.WriteLine(ex.InformarExcepcionSQL());
            }
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey(true);
            Console.Clear();




            //Trato de insertar un Celular en Tabla_Celular
            Console.WriteLine("Ingreso un Celular a Tabla_Celular en el SQL");
            try
            {
                SQLCelular.InsertarCelular(Celular1);
            }
            catch (ConexionSQLException ex)
            {
                Console.WriteLine(ex.InformarExcepcionSQL());
            }
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey(true);
            Console.Clear();




            //Trato de obtener todas los Celulares que tengo en la Tabla_Celular
            Console.WriteLine("Cargo los Celulares que guarde en el SQL al almacen");
            try
            {
                AlmacenSQL = SQLCelular.ObtenerListaDato(AlmacenSQL);
            }
            catch (ConexionSQLException ex)
            {
                Console.WriteLine(ex.InformarExcepcionSQL());
            }
            Console.WriteLine(AlmacenSQL.ToString()); 
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey(true);
            Console.Clear();




            //Trato de borrar el Calular de Tabla_Celular cargado en el punto anterior
            Console.WriteLine("Borro el Celular cargado de la Tabla_Celular en el SQL");
            try
            {
                SQLCelular.BorrarCelular(Celular1.CODIGO_DE_BARRAS);
            }
            catch (ConexionSQLException ex)
            {
                Console.WriteLine(ex.InformarExcepcionSQL());
            }
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey(true);
            Console.Clear();




            //Trato de insertar un Almacen en la tabla del SQL
            Console.WriteLine("Inserto un Almacen en Table_Almacen en el SQL");
            try
            {
                SQLAlmacen.InsertarAlmacen(AlmacenSQL);
            }
            catch (ConexionSQLException ex)
            {
                Console.WriteLine(ex.InformarExcepcionSQL());
            }
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey(true);
            Console.Clear();




            //Modifico la cantidad de productos del Almacen en Table_Almacen
            Console.WriteLine("Modifico la cantidad de productos del Almacen en Table_Almacen en el SQL");
            AlmacenSQL += PC7;
            try
            {
                SQLAlmacen.ModificarCantidad(AlmacenSQL);
            }
            catch (ConexionSQLException ex)
            {
                Console.WriteLine(ex.InformarExcepcionSQL());
            }
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey(true);
            Console.Clear();
        }
    }
}
