using System;
using System.Data;
using System.Data.SqlClient;

namespace Entidades
{
    public class SQLAlmacen
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
        public SQLAlmacen()
        {
            this.conexion = new SqlConnection(Properties.Settings.Default.Conexion);
        }
        #endregion

        #region Metodos

        /// <summary>
        /// Metodo que inserta un Almacen en la base de datos si no existe un Almacen con el mismo nombre
        /// </summary>
        /// <param name="Almacen">Almacen a ser ingresado a la base de datos</param>
        public void InsertarAlmacen(AlmacenProdutosFabricados<Producto> Almacen)
        {
            if(ExisteAlmacen(Almacen) == false)
            {
                string sql = "INSERT INTO Table_Almacen (NombreDelAlamcen, CantidadDeProductos) ";
                sql += "VALUES (@NombreDelAlamcen, @CantidadDeProductos)";

                try
                {
                    this.comando = new SqlCommand();

                    this.comando.CommandType = CommandType.Text;

                    this.comando.Connection = this.conexion;

                    this.comando.Parameters.AddWithValue("@NombreDelAlamcen", Almacen.NombreAlmacen);
                    this.comando.Parameters.AddWithValue("@CantidadDeProductos", Almacen.CantidadGenerica);

                    this.comando.CommandText = sql;

                    this.conexion.Open();

                    this.comando.ExecuteNonQuery();
                }
                catch (Exception)
                {

                }
                finally
                {
                    if (this.conexion.State == ConnectionState.Open)
                    {
                        this.conexion.Close();
                    }
                }
            }
        }

        /// <summary>
        /// Modifica la cantidad de productos del Almacen en la base de datos
        /// </summary>
        /// <param name="Almacen">Almacen a ser modificado a la base de datos</param>
        public void ModificarCantidad(AlmacenProdutosFabricados<Producto> Almacen)
        {
            try
            {
                this.comando = new SqlCommand();

                this.comando.Parameters.AddWithValue("@NombreDelAlamcen", Almacen.NombreAlmacen);
                this.comando.Parameters.AddWithValue("@CantidadDeProductos", Almacen.CantidadGenerica);

                string sql = "UPDATE Table_Almacen ";
                sql += "SET CantidadDeProductos = @CantidadDeProductos ";
                sql += "WHERE NombreDelAlamcen = @NombreDelAlamcen";

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = sql;
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                int filasAfectadas = this.comando.ExecuteNonQuery();

            }
            catch (Exception)
            {

            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }
        }

        /// <summary>
        /// Metodo que verifica si existe un Almacen con el mismo nombre en la base de datos
        /// </summary>
        /// <param name="Almacen">Almacen a ser verificado</param>
        /// <returns>Retorna false si no se encuentra el Almacen en la base de datos, caso contrario retorna true</returns>
        public bool ExisteAlmacen(AlmacenProdutosFabricados<Producto> Almacen)
        {
            string nombreAlmacen;
            bool retorno = false;

            try
            {
                this.comando = new SqlCommand();

                this.comando.Parameters.AddWithValue("@NombreDelAlamcen", Almacen.NombreAlmacen);

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = "SELECT NombreDelAlamcen FROM Table_Almacen WHERE NombreDelAlamcen = @NombreDelAlamcen";
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                this.lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    nombreAlmacen = (string)lector["NombreDelAlamcen"];

                    if (nombreAlmacen != null)
                    {
                        retorno = true;
                        break;
                    }
                    
                }

                lector.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
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

        #endregion
    }
}


