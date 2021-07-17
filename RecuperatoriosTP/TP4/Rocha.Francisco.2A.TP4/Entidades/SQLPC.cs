using System;
using System.Data;
using System.Data.SqlClient;

namespace Entidades
{
    public class SQLPC : ISQL
    {
        #region Atributos

        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;
        #endregion

        #region Constructor

        /// <summary>
        /// Constructor sin parametros que inicializa el atributo de conexion
        /// </summary>
        public SQLPC()
        {
            this.conexion = new SqlConnection(Constante.ConexionSQL);
        }
        #endregion

        #region Metodos

        /// <summary>
        /// Metodo que inserta una PC en la base de datos
        /// </summary>
        /// <param name="PC">PC a ser ingresado a la base de datos</param>
        /// <returns>Retorna un booleano indicando si se singreso correctamente o no</returns>
        public bool InsertarPcSql(FabricaPC PC)
        {
            bool retorno;

            string gpu = PC.GRAFICOS.ToString();
            string fuente = PC.FUENTE.ToString();
            string cpu = PC.PROCESADOR.ToString();
            string marca = PC.MARCA_CPU.ToString();
            string gabinete = PC.GABINETE.ToString();
            string placamadre = PC.PLACA_MADRE.ToString();
            string memoriaRam = PC.MEMORIA_RAM.ToString();
            string almacenamiento = PC.ALMACENAMIENTO.ToString();
            string sistemaOperativo = PC.SISTEMA_OPERATIVO.ToString();

            string sql = "INSERT INTO Tabla_PC (UPC, Marca, Procesador, Motherboard, GPU, Ram, Fuente, Gabinete, SistemaOperativo, Almacenamiento, LectorCD) ";
            sql += "VALUES (@UPC, @Marca, @Procesador, @Motherboard, @GPU, @Ram, @Fuente, @Gabinete, @SistemaOperativo, @Almacenamiento, @LectorCD)";

            try
            {
                if (ExisteProductoEnElSqlPC(PC) == -1)
                {
                    this.comando = new SqlCommand();

                    this.comando.CommandType = CommandType.Text;

                    this.comando.Connection = this.conexion;

                    this.comando.Parameters.AddWithValue("@GPU", gpu);
                    this.comando.Parameters.AddWithValue("@Marca", marca);
                    this.comando.Parameters.AddWithValue("@Fuente", fuente);
                    this.comando.Parameters.AddWithValue("@Ram", memoriaRam);
                    this.comando.Parameters.AddWithValue("@Procesador", cpu);
                    this.comando.Parameters.AddWithValue("@Gabinete", gabinete);
                    this.comando.Parameters.AddWithValue("@LectorCD", PC.LECTOR_CD);
                    this.comando.Parameters.AddWithValue("@Motherboard", placamadre);
                    this.comando.Parameters.AddWithValue("@UPC", PC.CODIGO_DE_BARRAS);
                    this.comando.Parameters.AddWithValue("@Almacenamiento", almacenamiento);
                    this.comando.Parameters.AddWithValue("@SistemaOperativo", sistemaOperativo);

                    this.comando.CommandText = sql;

                    this.conexion.Open();

                    this.comando.ExecuteNonQuery();
                }

                retorno = true;
            }
            catch (Exception ex)
            {
                Archivos<Producto>.LogErrores(ex.ToString());
                retorno = false;
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return retorno;
        }

        /// <summary>
        /// Metodo que borra una PC de la base de datos
        /// </summary>
        /// <param name="UPC">Codigo de barras del producto a ser eliminado</param>
        /// <returns>Retorna un booleano indicando si se borro correctamente o no la PC de la base de datos</returns>
        public bool BorrarPcSql(int UPC)
        {
            bool retorno;
            int validacion;

            try
            {
                this.comando = new SqlCommand();

                this.comando.Parameters.AddWithValue("@UPC", UPC);

                string sql = "DELETE FROM Tabla_PC ";
                sql += "WHERE UPC = @UPC";

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = sql;
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                validacion = this.comando.ExecuteNonQuery();

                if(validacion > 0)
                {
                    retorno = true;
                }
                else
                {
                    retorno = false;
                }
            }
            catch (Exception ex)
            {
                Archivos<Producto>.LogErrores(ex.ToString());
                retorno = false;
                throw new ConexionSQLException();
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return retorno;
        }

        /// <summary>
        /// Metodo que obtienes los datos de las PCs y los inserta al almacen de productos fabricados
        /// </summary>
        /// <param name="Almacen">Almacen al que se le van a insertar las PCs</param>
        /// <returns>Retorna el almacen con los datos actualizados</returns>
        public AlmacenProdutosFabricados<Producto> ObtenerListaPcSql(AlmacenProdutosFabricados<Producto> Almacen)
        { 
            try
            {
                this.comando = new SqlCommand();

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = "SELECT * FROM Tabla_PC";
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                this.lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    int upc = (int)lector["UPC"];
                    
                    GPU gpu = (GPU)Enum.Parse(typeof(GPU), (string)lector["GPU"]);
                    RAM ram = (RAM)Enum.Parse(typeof(RAM), (string)lector["Ram"]);
                    Fuente fuente = (Fuente)Enum.Parse(typeof(Fuente), (string)lector["Fuente"]);
                    MarcaCPU marca = (MarcaCPU)Enum.Parse(typeof(MarcaCPU), (string)lector["Marca"]);
                    Gabinete gabinete = (Gabinete)Enum.Parse(typeof(Gabinete), (string)lector["Gabinete"]);
                    Procesador procesador = (Procesador)Enum.Parse(typeof(Procesador), (string)lector["Procesador"]);
                    Motherboard motherboard = (Motherboard)Enum.Parse(typeof(Motherboard), (string)lector["Motherboard"]);
                    SistemaOP sistemaOperativo = (SistemaOP)Enum.Parse(typeof(SistemaOP), (string)lector["SistemaOperativo"]);
                    Almacenamiento almacenamiento = (Almacenamiento)Enum.Parse(typeof(Almacenamiento), (string)lector["Almacenamiento"]);
                    int lectorCD = (int)lector["LectorCD"];

                    FabricaPC pc = new FabricaPC(marca, procesador, motherboard, gpu, ram, fuente, gabinete, sistemaOperativo, almacenamiento, this.EnteroABooleano(lectorCD), upc);

                    Almacen += pc;
                }

                lector.Close();

            }
            catch (SqlException ex)
            {
                Archivos<Producto>.LogErrores(ex.ToString());
                throw new ConexionSQLException();
            }
            catch (Exception ex)
            {
                Archivos<Producto>.LogErrores(ex.ToString());
                throw new DatoErroneoSQLException();
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return Almacen;
        }

        private int ExisteProductoEnElSqlPC(FabricaPC PC)
        {
            int aux;

            AlmacenProdutosFabricados<Producto> AlmacenValidacion = new AlmacenProdutosFabricados<Producto>("AlmacenPruebaPc");

            AlmacenValidacion = this.ObtenerListaPcSql(AlmacenValidacion);

            aux = AlmacenValidacion | PC;

            return aux;
        }
        #endregion
    }
}
