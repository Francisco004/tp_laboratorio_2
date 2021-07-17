using System;
using System.Data;
using System.Data.SqlClient;

namespace Entidades
{
    public class SQLCelular : ISQL
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
        public SQLCelular()
        {
            this.conexion = new SqlConnection(Constante.ConexionSQL);
        }
        #endregion

        #region Metodos

        /// <summary>
        /// Metodo que inserta un celular en la base de datos
        /// </summary>
        /// <param name="Celular">Celular a ser ingresado a la base de datos</param>
        /// <returns>Retorna un booleano indicando si se singreso correctamente o no</returns>
        public bool InsertarCelularSql(FabricaCelular Celular)
        {
            bool retorno;
            
            string gpu = Celular.GRAFICOS.ToString();
            string camara = Celular.CAMARA.ToString();
            string marca = Celular.MARCA_CPU.ToString();
            string bateria = Celular.BATERIA.ToString();
            string ram = Celular.MEMORIA_RAM.ToString();
            string material = Celular.CARCASA.ToString();
            string pulgadas = Celular.PULGADAS.ToString();
            string resolucion = Celular.RESOLUCION.ToString();
            string almacenamiento = Celular.ALMACENAMIENTO.ToString();
            string sistemaOperativo = Celular.SISTEMA_OPERATIVO.ToString();

            string sql = "INSERT INTO Tabla_Celular (UPC, Marca, GPU, Ram, SistemaOperativo, Almacenamiento, Camara, Bateria, Material, Pulgadas, Resolucion, Jack, Huella) ";
            sql += "VALUES (@UPC, @Marca, @GPU, @Ram, @SistemaOperativo, @Almacenamiento, @Camara, @Bateria, @Material, @Pulgadas, @Resolucion, @Jack, @Huella)";

            try
            {
                if (ExisteProductoEnElSqlCelular(Celular) == -1)
                {
                    this.comando = new SqlCommand();

                    this.comando.CommandType = CommandType.Text;

                    this.comando.Connection = this.conexion;

                    this.comando.Parameters.AddWithValue("@GPU", gpu);
                    this.comando.Parameters.AddWithValue("@Ram", ram);
                    this.comando.Parameters.AddWithValue("@Marca", marca);
                    this.comando.Parameters.AddWithValue("@Camara", camara);
                    this.comando.Parameters.AddWithValue("@Bateria", bateria);
                    this.comando.Parameters.AddWithValue("@Material", material);
                    this.comando.Parameters.AddWithValue("@Pulgadas", pulgadas);
                    this.comando.Parameters.AddWithValue("@Jack", Celular.JACK);
                    this.comando.Parameters.AddWithValue("@Huella", Celular.HUELLA);
                    this.comando.Parameters.AddWithValue("@UPC", Celular.CODIGO_DE_BARRAS);
                    this.comando.Parameters.AddWithValue("@Resolucion", resolucion);
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
        /// Metodo que borra un celular de la base de datos
        /// </summary>
        /// <param name="UPC">Codigo de barras del producto a ser eliminado</param>
        /// <returns>Retorna un booleano indicando si se borro correctamente o no el celular de la base de datos</returns>
        public bool BorrarCelularSql(int UPC)
        {
            bool retorno;
            int validacion;

            try
            {
                this.comando = new SqlCommand();

                this.comando.Parameters.AddWithValue("@UPC", UPC);

                string sql = "DELETE FROM Tabla_Celular ";
                sql += "WHERE UPC = @UPC";

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = sql;
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                this.comando.ExecuteNonQuery();

                validacion = this.comando.ExecuteNonQuery();

                if (validacion > 0)
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
        /// Metodo que obtienes los datos de los celulares y los inserta al almacen de productos fabricados
        /// </summary>
        /// <param name="Almacen">Almacen al que se le van a insertar los celulares</param>
        /// <returns>Retorna el almacen con los datos actualizados</returns>
        public AlmacenProdutosFabricados<Producto> ObtenerListaCelularSql(AlmacenProdutosFabricados<Producto> Almacen)
        {
            try
            {
                this.comando = new SqlCommand();

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = "SELECT * FROM Tabla_Celular";
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                this.lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    int upc = (int)lector["UPC"];

                    
                    GPU gpu = (GPU)Enum.Parse(typeof(GPU), (string)lector["GPU"]);
                    RAM ram = (RAM)Enum.Parse(typeof(RAM), (string)lector["Ram"]);
                    Camara camara = (Camara)Enum.Parse(typeof(Camara), (string)lector["Camara"]);
                    MarcaCPU marca = (MarcaCPU)Enum.Parse(typeof(MarcaCPU), (string)lector["Marca"]);
                    Bateria bateria = (Bateria)Enum.Parse(typeof(Bateria), (string)lector["Bateria"]);
                    SistemaOP sistemaOperativo = (SistemaOP)Enum.Parse(typeof(SistemaOP), (string)lector["SistemaOperativo"]);
                    MaterialCarcasa carcasa = (MaterialCarcasa)Enum.Parse(typeof(MaterialCarcasa), (string)lector["Material"]);
                    PantallaPulgadas pulgadas = (PantallaPulgadas)Enum.Parse(typeof(PantallaPulgadas), (string)lector["Pulgadas"]);
                    Almacenamiento almacenamiento = (Almacenamiento)Enum.Parse(typeof(Almacenamiento), (string)lector["Almacenamiento"]);
                    PantallaResolucion resolucion = (PantallaResolucion)Enum.Parse(typeof(PantallaResolucion), (string)lector["Resolucion"]);

                    int Jack = (int)lector["Jack"];
                    int Huella = (int)lector["Huella"];

                    FabricaCelular Celular = new FabricaCelular(marca, gpu, ram, sistemaOperativo, almacenamiento, upc, camara, bateria, carcasa, pulgadas, resolucion, this.EnteroABooleano(Jack), this.EnteroABooleano(Huella));

                    Almacen += Celular;
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

        /// <summary>
        /// Metodo que se encarga de buscar si existe el producto en el SQL, si no existe retorna -1 y significa que se podra insertar en el SQL
        /// </summary>
        /// <param name="Celular">Celular a comprobar si existe</param>
        /// <returns>-1 si no se encuentra en el almacen</returns>
        private int ExisteProductoEnElSqlCelular(FabricaCelular Celular)
        {
            int aux;

            AlmacenProdutosFabricados<Producto> AlmacenValidacion = new AlmacenProdutosFabricados<Producto>("AlmacenPruebaCelular");

            AlmacenValidacion = this.ObtenerListaCelularSql(AlmacenValidacion);

            aux = AlmacenValidacion | Celular;

            return aux;
        }
        #endregion
    }
}
