using System;
using System.Xml;

namespace Entidades
{
    public class XMLaSQL
    {
        #region Metodos

        /// <summary>
        /// Metodo el cual pasa los datos del archivo XML a la base de datos
        /// </summary>
        /// <param name="path">Directorio donde se encuentra el XML</param>
        public static void XMLASQL(string path)
        {
            #region Atributos

            //Producto
            string UPC;
            string GPU;
            string Ram;
            string MarcaCpu;
            string SistemaOperativo;
            string Almacenamiento;

            //PC
            string Procesador;
            string Mother;
            string Gabinete;
            string Fuente;
            string LectorCD;

            //Celular
            string Camara;
            string Bateria;
            string Carcasa;
            string Pulgadas;
            string Resolucion;
            string Jack;
            string Huella;
            #endregion

            using (XmlReader reader = XmlReader.Create(path))
            {
                while (reader.Read())
                {
                    if (reader.Name.ToString() == "GRAFICOS")
                    {
                        if (reader.IsStartElement("GRAFICOS"))
                        {
                            GPU = reader.ReadElementContentAsString();
                            UPC = reader.ReadElementContentAsString();
                            Ram = reader.ReadElementContentAsString();
                            MarcaCpu = reader.ReadElementContentAsString();
                            SistemaOperativo = reader.ReadElementContentAsString();
                            Almacenamiento = reader.ReadElementContentAsString();

                            if (GPU[0] == 'R' || GPU[0] == 'G')
                            {
                                Procesador = reader.ReadElementContentAsString();
                                Mother = reader.ReadElementContentAsString();
                                Gabinete = reader.ReadElementContentAsString();
                                Fuente = reader.ReadElementContentAsString();
                                LectorCD = reader.ReadElementContentAsString();

                                PCXMLToSQL(GPU, UPC, Ram, MarcaCpu, SistemaOperativo, Almacenamiento, Procesador, Mother, Gabinete, Fuente, LectorCD);
                            }
                            else
                            {
                                Camara = reader.ReadElementContentAsString();
                                Bateria = reader.ReadElementContentAsString();
                                Carcasa = reader.ReadElementContentAsString();
                                Pulgadas = reader.ReadElementContentAsString();
                                Resolucion = reader.ReadElementContentAsString();
                                Jack = reader.ReadElementContentAsString();
                                Huella = reader.ReadElementContentAsString();

                                CelularXMLToSQL(GPU, UPC, Ram, MarcaCpu, SistemaOperativo, Almacenamiento, Camara, Bateria, Carcasa, Pulgadas, Resolucion, Jack, Huella);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Metodo el cual obtiene los atributos de una PC del XML y la pasa a la base de datos
        /// </summary>
        /// <param name="gpu"></param>
        /// <param name="upc"></param>
        /// <param name="ram"></param>
        /// <param name="marca"></param>
        /// <param name="sistemaOP"></param>
        /// <param name="almacenamiento"></param>
        /// <param name="procesador"></param>
        /// <param name="mother"></param>
        /// <param name="gabinete"></param>
        /// <param name="fuente"></param>
        /// <param name="lector"></param>
        private static void PCXMLToSQL(string gpu, string upc, string ram, string marca, string sistemaOP, string almacenamiento, string procesador, string mother, string gabinete, string fuente, string lector)
        {
            int UPC = Convert.ToInt32(upc);

            GPU EGpu = (GPU)Enum.Parse(typeof(GPU), gpu);
            RAM ERam = (RAM)Enum.Parse(typeof(RAM), ram);
            Fuente EFuente = (Fuente)Enum.Parse(typeof(Fuente), fuente);
            MarcaCPU EMarca = (MarcaCPU)Enum.Parse(typeof(MarcaCPU), marca);
            Gabinete EGabinete = (Gabinete)Enum.Parse(typeof(Gabinete), gabinete);
            SistemaOP ESistemaOp = (SistemaOP)Enum.Parse(typeof(SistemaOP), sistemaOP);
            Motherboard EMother = (Motherboard)Enum.Parse(typeof(Motherboard), mother);
            Procesador EProcesador = (Procesador)Enum.Parse(typeof(Procesador), procesador);
            Almacenamiento EAlmacenamiento = (Almacenamiento)Enum.Parse(typeof(Almacenamiento), almacenamiento);

            FabricaPC SQLPC = new FabricaPC(EMarca, EProcesador, EMother, EGpu, ERam, EFuente, EGabinete, ESistemaOp, EAlmacenamiento, BoolRetorno(lector), UPC);

            SQLPC SQL = new SQLPC();

            SQL.InsertarPC(SQLPC);
        }

        /// <summary>
        /// Metodo el cual obtiene los atributos de un Celular del XML y la pasa a la base de datos
        /// </summary>
        /// <param name="gpu"></param>
        /// <param name="upc"></param>
        /// <param name="ram"></param>
        /// <param name="marca"></param>
        /// <param name="sistemaOP"></param>
        /// <param name="almacenamiento"></param>
        /// <param name="camara"></param>
        /// <param name="bateria"></param>
        /// <param name="carcasa"></param>
        /// <param name="pulgadas"></param>
        /// <param name="resolucion"></param>
        /// <param name="jack"></param>
        /// <param name="huella"></param>
        private static void CelularXMLToSQL(string gpu, string upc, string ram, string marca, string sistemaOP, string almacenamiento, string camara, string bateria, string carcasa, string pulgadas, string resolucion, string jack, string huella)
        {
            int UPC = Convert.ToInt32(upc);

            GPU EGpu = (GPU)Enum.Parse(typeof(GPU), gpu);
            RAM ERam = (RAM)Enum.Parse(typeof(RAM), ram);
            Camara ECamara = (Camara)Enum.Parse(typeof(Camara), camara);
            MarcaCPU EMarca = (MarcaCPU)Enum.Parse(typeof(MarcaCPU), marca);
            Bateria EBateria = (Bateria)Enum.Parse(typeof(Bateria), bateria);
            SistemaOP ESistemaOp = (SistemaOP)Enum.Parse(typeof(SistemaOP), sistemaOP);
            MaterialCarcasa EMaterial = (MaterialCarcasa)Enum.Parse(typeof(MaterialCarcasa), carcasa);
            PantallaPulgadas EPulgadas = (PantallaPulgadas)Enum.Parse(typeof(PantallaPulgadas), pulgadas);
            Almacenamiento EAlmacenamiento = (Almacenamiento)Enum.Parse(typeof(Almacenamiento), almacenamiento);
           
            PantallaResolucion EResolucion = (PantallaResolucion)Enum.Parse(typeof(PantallaResolucion), resolucion);

            FabricaCelular SQLPC = new FabricaCelular(EMarca, EGpu, ERam, ESistemaOp, EAlmacenamiento, UPC, ECamara, EBateria, EMaterial, EPulgadas, EResolucion, BoolRetorno(jack), BoolRetorno(huella));

            SQLCelular SQL = new SQLCelular();

            SQL.InsertarCelular(SQLPC);
        }

        /// <summary>
        /// Metodo el cual transforma un string a un booleano
        /// </summary>
        /// <param name="aux">String a ser validado</param>
        /// <returns>Retorna un booleano dependiendo del string ingresado, si el string es "true" retorna true, caso contrario retorna false</returns>
        private static bool BoolRetorno(string aux)
        {
            bool retorno;

            if(aux == "true")
            {
                retorno = true;
            }
            else
            {
                retorno = false;
            }

            return retorno;
        }
        #endregion
    }
}
