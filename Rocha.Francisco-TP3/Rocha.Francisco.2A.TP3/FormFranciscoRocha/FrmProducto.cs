using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace FormFranciscoRocha
{
    public partial class FrmProducto : Form
    {

        public virtual Producto ProductoDelForm { get; }

        public FrmProducto()
        {
            InitializeComponent();
        }

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

    }
}
