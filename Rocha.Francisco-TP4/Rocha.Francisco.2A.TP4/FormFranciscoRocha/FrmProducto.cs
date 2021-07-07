using System;
using System.Windows.Forms;
using Entidades;

namespace FormFranciscoRocha
{
    public partial class FrmProducto : Form
    {
        #region Propiedad

        public virtual Producto ProductoDelForm { get; }
        #endregion

        public FrmProducto()
        {
            InitializeComponent();
        }

        #region Metodos
        protected virtual string ComboboxToStringOriginal(int indice)
        {
            return "Base";
        }

        protected virtual string ReformarString(string Aux)
        {
            return Aux;
        }


        protected virtual bool BoolSelec(int index)
        {
            return false;
        }

        protected virtual void FrmProducto_Load(object sender, EventArgs e)
        {
            
        }

        protected virtual void ComboBoxMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
