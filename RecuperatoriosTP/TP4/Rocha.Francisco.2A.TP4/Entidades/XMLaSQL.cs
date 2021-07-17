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
        public static void XmlASql(string path)
        {
            #region Atributos

            //Producto
            string upc;
            string gpu;
            string ram;
            string marcaCpu;
            string sistemaOperativo;
            string almacenamiento;

            //PC
            string procesador;
            string mother;
            string gabinete;
            string fuente;
            string lectorCd;

            //Celular
            string camara;
            string bateria;
            string carcasa;
            string pulgadas;
            string resolucion;
            string jack;
            string huella;
            #endregion

            using (XmlReader reader = XmlReader.Create(path))
            {
                while (reader.Read())
                {
                    if (reader.Name.ToString() == "GRAFICOS")
                    {
                        if (reader.IsStartElement("GRAFICOS"))
                        {
                            gpu = reader.ReadElementContentAsString();
                            upc = reader.ReadElementContentAsString();
                            ram = reader.ReadElementContentAsString();
                            marcaCpu = reader.ReadElementContentAsString();
                            sistemaOperativo = reader.ReadElementContentAsString();
                            almacenamiento = reader.ReadElementContentAsString();

                            if (gpu[0] == 'R' || gpu[0] == 'G')
                            {
                                procesador = reader.ReadElementContentAsString();
                                mother = reader.ReadElementContentAsString();
                                gabinete = reader.ReadElementContentAsString();
                                fuente = reader.ReadElementContentAsString();
                                lectorCd = reader.ReadElementContentAsString();

                               PcXmlToSql(gpu, upc, ram, marcaCpu, sistemaOperativo, almacenamiento, procesador, mother, gabinete, fuente, lectorCd);
                            }
                            else
                            {
                                camara = reader.ReadElementContentAsString();
                                bateria = reader.ReadElementContentAsString();
                                carcasa = reader.ReadElementContentAsString();
                                pulgadas = reader.ReadElementContentAsString();
                                resolucion = reader.ReadElementContentAsString();
                                jack = reader.ReadElementContentAsString();
                                huella = reader.ReadElementContentAsString();

                                CelularXmlToSql(gpu, upc, ram, marcaCpu, sistemaOperativo, almacenamiento, camara, bateria, carcasa, pulgadas, resolucion, jack, huella);
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
        private static void PcXmlToSql(string gpu, string upc, string ram, string marca, string sistemaOp, string almacenamiento, string procesador, string mother, string gabinete, string fuente, string lector)
        {
            int UPC = Convert.ToInt32(upc);

            GPU EGpu = (GPU)Enum.Parse(typeof(GPU), gpu);
            RAM ERam = (RAM)Enum.Parse(typeof(RAM), ram);
            Fuente EFuente = (Fuente)Enum.Parse(typeof(Fuente), fuente);
            MarcaCPU EMarca = (MarcaCPU)Enum.Parse(typeof(MarcaCPU), marca);
            Gabinete EGabinete = (Gabinete)Enum.Parse(typeof(Gabinete), gabinete);
            SistemaOP ESistemaOp = (SistemaOP)Enum.Parse(typeof(SistemaOP), sistemaOp);
            Motherboard EMother = (Motherboard)Enum.Parse(typeof(Motherboard), mother);
            Procesador EProcesador = (Procesador)Enum.Parse(typeof(Procesador), procesador);
            Almacenamiento EAlmacenamiento = (Almacenamiento)Enum.Parse(typeof(Almacenamiento), almacenamiento);

            FabricaPC SQLPC = new FabricaPC(EMarca, EProcesador, EMother, EGpu, ERam, EFuente, EGabinete, ESistemaOp, EAlmacenamiento, BoolRetorno(lector), UPC);

            SQLPC SQL = new SQLPC();

            SQL.InsertarPcSql(SQLPC);
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
        private static void CelularXmlToSql(string gpu, string upc, string ram, string marca, string sistemaOp, string almacenamiento, string camara, string bateria, string carcasa, string pulgadas, string resolucion, string jack, string huella)
        {
            int UPC = Convert.ToInt32(upc);

            GPU EGpu = (GPU)Enum.Parse(typeof(GPU), gpu);
            RAM ERam = (RAM)Enum.Parse(typeof(RAM), ram);
            Camara ECamara = (Camara)Enum.Parse(typeof(Camara), camara);
            MarcaCPU EMarca = (MarcaCPU)Enum.Parse(typeof(MarcaCPU), marca);
            Bateria EBateria = (Bateria)Enum.Parse(typeof(Bateria), bateria);
            SistemaOP ESistemaOp = (SistemaOP)Enum.Parse(typeof(SistemaOP), sistemaOp);
            MaterialCarcasa EMaterial = (MaterialCarcasa)Enum.Parse(typeof(MaterialCarcasa), carcasa);
            PantallaPulgadas EPulgadas = (PantallaPulgadas)Enum.Parse(typeof(PantallaPulgadas), pulgadas);
            Almacenamiento EAlmacenamiento = (Almacenamiento)Enum.Parse(typeof(Almacenamiento), almacenamiento);
           
            PantallaResolucion EResolucion = (PantallaResolucion)Enum.Parse(typeof(PantallaResolucion), resolucion);

            FabricaCelular SQLCelular = new FabricaCelular(EMarca, EGpu, ERam, ESistemaOp, EAlmacenamiento, UPC, ECamara, EBateria, EMaterial, EPulgadas, EResolucion, BoolRetorno(jack), BoolRetorno(huella));

            SQLCelular SQL = new SQLCelular();

            SQL.InsertarCelularSql(SQLCelular);
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
