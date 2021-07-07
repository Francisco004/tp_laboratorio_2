using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Entidades;
using System.Text;

namespace TestUnitarios
{
    [TestClass]
    public class FabricaCelular
    {
        #region Testeos
        [TestMethod]
        //Pruebo si la sobrecarga del operador igual del producto es verdadera
        public void ProbarSobrecaraIgual_True()
        {
            Entidades.FabricaCelular Celular1 = new Entidades.FabricaCelular(MarcaCPU.Mediatek, GPU.Adreno_540, RAM._6GB, SistemaOP.Android_11, Almacenamiento._256GB, 498, Camara._24MP, Bateria._5000_mAh, MaterialCarcasa.Metal, PantallaPulgadas._6_1, PantallaResolucion._3840x2160_Pixeles, true, false);
            Entidades.FabricaCelular Celular3 = new Entidades.FabricaCelular(MarcaCPU.QualcommSnapdragon, GPU.Adreno_650, RAM._6GB, SistemaOP.Android_Nougat, Almacenamiento._512GB, 498, Camara._16MP, Bateria._8000_mAh, MaterialCarcasa.Plastico, PantallaPulgadas._6_5, PantallaResolucion._2560x1440_Pixeles, true, false);
  
            Assert.IsTrue(Celular1 == Celular3);
        }

        [TestMethod]
        //Pruebo si la sobrecarga del operador igual del producto es falsa
        public void ProbarSobrecaraIgual_False()
        {
            Entidades.FabricaCelular Celular1 = new Entidades.FabricaCelular(MarcaCPU.Mediatek, GPU.Adreno_540, RAM._6GB, SistemaOP.Android_11, Almacenamiento._256GB, 498, Camara._24MP, Bateria._5000_mAh, MaterialCarcasa.Metal, PantallaPulgadas._6_1, PantallaResolucion._3840x2160_Pixeles, true, false);
            Entidades.FabricaCelular Celular2 = new Entidades.FabricaCelular(MarcaCPU.HiSilicon, GPU.Adreno_615, RAM._6GB, SistemaOP.iOS_11, Almacenamiento._1TB, 55, Camara._24MP, Bateria._3000_mAh, MaterialCarcasa.Aluminio, PantallaPulgadas._5_7, PantallaResolucion._1280x720_Pixeles, true, false);
           
            Assert.IsFalse(Celular1 == Celular2);
        }

        //Pruebo si la sobrecarga del operador distinto del producto es verdadera
        public void ProbarSobrecaraDistinto_True()
        {
            Entidades.FabricaCelular Celular2 = new Entidades.FabricaCelular(MarcaCPU.HiSilicon, GPU.Adreno_615, RAM._6GB, SistemaOP.iOS_11, Almacenamiento._1TB, 55, Camara._24MP, Bateria._3000_mAh, MaterialCarcasa.Aluminio, PantallaPulgadas._5_7, PantallaResolucion._1280x720_Pixeles, true, false);
            Entidades.FabricaCelular Celular3 = new Entidades.FabricaCelular(MarcaCPU.QualcommSnapdragon, GPU.Adreno_650, RAM._6GB, SistemaOP.Android_Nougat, Almacenamiento._512GB, 498, Camara._16MP, Bateria._8000_mAh, MaterialCarcasa.Plastico, PantallaPulgadas._6_5, PantallaResolucion._2560x1440_Pixeles, true, false);

            Assert.IsTrue(Celular2 != Celular3);
        }

        [TestMethod]
        //Pruebo si la sobrecarga del operador distinto del producto es falsa
        public void ProbarSobrecaraDistinto_False()
        {
            Entidades.FabricaCelular Celular1 = new Entidades.FabricaCelular(MarcaCPU.Mediatek, GPU.Adreno_540, RAM._6GB, SistemaOP.Android_11, Almacenamiento._256GB, 498, Camara._24MP, Bateria._5000_mAh, MaterialCarcasa.Metal, PantallaPulgadas._6_1, PantallaResolucion._3840x2160_Pixeles, true, false);
            Entidades.FabricaCelular Celular3 = new Entidades.FabricaCelular(MarcaCPU.QualcommSnapdragon, GPU.Adreno_650, RAM._6GB, SistemaOP.Android_Nougat, Almacenamiento._512GB, 498, Camara._16MP, Bateria._8000_mAh, MaterialCarcasa.Plastico, PantallaPulgadas._6_5, PantallaResolucion._2560x1440_Pixeles, true, false);

            Assert.IsFalse(Celular1 != Celular3);
        }

        [TestMethod]
        //Pruebo si la sobrecarga del equals del producto es verdadera
        public void ProbarEquals_True()
        {
            Entidades.FabricaCelular Celular1 = new Entidades.FabricaCelular(MarcaCPU.Mediatek, GPU.Adreno_540, RAM._6GB, SistemaOP.Android_11, Almacenamiento._256GB, 498, Camara._24MP, Bateria._5000_mAh, MaterialCarcasa.Metal, PantallaPulgadas._6_1, PantallaResolucion._3840x2160_Pixeles, true, false);
             Entidades.FabricaCelular Celular3 = new Entidades.FabricaCelular(MarcaCPU.QualcommSnapdragon, GPU.Adreno_650, RAM._6GB, SistemaOP.Android_Nougat, Almacenamiento._512GB, 498, Camara._16MP, Bateria._8000_mAh, MaterialCarcasa.Plastico, PantallaPulgadas._6_5, PantallaResolucion._2560x1440_Pixeles, true, false);

            Assert.IsTrue(Celular1.Equals(Celular3));
        }

        [TestMethod]
        //Pruebo si la sobrecarga del equals del producto es falsa
        public void ProbarEquals_False()
        {
            Entidades.FabricaCelular Celular2 = new Entidades.FabricaCelular(MarcaCPU.HiSilicon, GPU.Adreno_615, RAM._6GB, SistemaOP.iOS_11, Almacenamiento._1TB, 55, Camara._24MP, Bateria._3000_mAh, MaterialCarcasa.Aluminio, PantallaPulgadas._5_7, PantallaResolucion._1280x720_Pixeles, true, false);
            Entidades.FabricaCelular Celular3 = new Entidades.FabricaCelular(MarcaCPU.QualcommSnapdragon, GPU.Adreno_650, RAM._6GB, SistemaOP.Android_Nougat, Almacenamiento._512GB, 498, Camara._16MP, Bateria._8000_mAh, MaterialCarcasa.Plastico, PantallaPulgadas._6_5, PantallaResolucion._2560x1440_Pixeles, true, false);

            Assert.IsFalse(Celular2.Equals(Celular3));
        }

        [TestMethod]
        //Pruebo si el metodo no mostrar retorna true
        public void ProbarNoMostrar_True()
        {
            Entidades.FabricaCelular Celular4 = new Entidades.FabricaCelular(MarcaCPU.AMD, GPU.GTX_1080_TI_11GB, RAM.Corsair_Dominator_Platinum_RGB_16GB, SistemaOP.Windows_8, Almacenamiento._512GB, 498, Camara._16MP, Bateria._8000_mAh, MaterialCarcasa.Plastico, PantallaPulgadas._6_5, PantallaResolucion._2560x1440_Pixeles, true, false);

            Assert.IsTrue(Celular4.NoMostrar());
        }

        [TestMethod]
        //Pruebo si el metodo no mostrar retorna false
        public void ProbarNoMostrar_False()
        {
            Entidades.FabricaCelular Celular3 = new Entidades.FabricaCelular(MarcaCPU.QualcommSnapdragon, GPU.Adreno_650, RAM._6GB, SistemaOP.Android_Nougat, Almacenamiento._512GB, 498, Camara._16MP, Bateria._8000_mAh, MaterialCarcasa.Plastico, PantallaPulgadas._6_5, PantallaResolucion._2560x1440_Pixeles, true, false);

            Assert.IsFalse(Celular3.NoMostrar());
        }

        [TestMethod]
        //Pruebo si un celular es de tipo IProducto
        public void ProbarInstancia_True()
        {
            Entidades.FabricaCelular Celular3 = new Entidades.FabricaCelular(MarcaCPU.QualcommSnapdragon, GPU.Adreno_650, RAM._6GB, SistemaOP.Android_Nougat, Almacenamiento._512GB, 498, Camara._16MP, Bateria._8000_mAh, MaterialCarcasa.Plastico, PantallaPulgadas._6_5, PantallaResolucion._2560x1440_Pixeles, true, false);

            Assert.IsInstanceOfType(Celular3, typeof(IProductos));
        }

        [TestMethod]
        //Pruebo si un celular es de tipo Almacen
        public void ProbarInstancia_False()
        {
            Entidades.FabricaCelular Celular3 = new Entidades.FabricaCelular(MarcaCPU.QualcommSnapdragon, GPU.Adreno_650, RAM._6GB, SistemaOP.Android_Nougat, Almacenamiento._512GB, 498, Camara._16MP, Bateria._8000_mAh, MaterialCarcasa.Plastico, PantallaPulgadas._6_5, PantallaResolucion._2560x1440_Pixeles, true, false);

            Assert.IsNotInstanceOfType(Celular3, typeof(AlmacenProdutosFabricados<IProductos>));
        }

        [TestMethod]
        //Pruebo si la informacion del celular no es nula
        public void ProbarInformacion_NoNull()
        {
            Entidades.FabricaCelular Celular3 = new Entidades.FabricaCelular(MarcaCPU.QualcommSnapdragon, GPU.Adreno_650, RAM._6GB, SistemaOP.Android_Nougat, Almacenamiento._512GB, 498, Camara._16MP, Bateria._8000_mAh, MaterialCarcasa.Plastico, PantallaPulgadas._6_5, PantallaResolucion._2560x1440_Pixeles, true, false);

            Assert.IsNotNull(Celular3.Informacion());
        }

        [TestMethod]
        //Pruebo si el metodo FixPulgadas de celular no retorna null
        public void ProbarFixPulgadas_NoNull()
        {
            Entidades.FabricaCelular Celular3 = new Entidades.FabricaCelular(MarcaCPU.QualcommSnapdragon, GPU.Adreno_650, RAM._6GB, SistemaOP.Android_Nougat, Almacenamiento._512GB, 498, Camara._16MP, Bateria._8000_mAh, MaterialCarcasa.Plastico, PantallaPulgadas._6_5, PantallaResolucion._2560x1440_Pixeles, true, false);

            Assert.IsNotNull(Celular3.FixPulgadas(Celular3.PULGADAS.ToString()));
        }

        [TestMethod]
        //Pruebo si los metodos validar funcionan en caso de ingresar componentes correctos
        public void ProbarValidacionComponentes_True()
        {
            Entidades.FabricaCelular Celular3 = new Entidades.FabricaCelular(MarcaCPU.QualcommSnapdragon, GPU.Adreno_650, RAM._6GB, SistemaOP.Android_Nougat, Almacenamiento._512GB, 498, Camara._16MP, Bateria._8000_mAh, MaterialCarcasa.Plastico, PantallaPulgadas._6_5, PantallaResolucion._2560x1440_Pixeles, true, false);

            Assert.IsNotNull(Celular3.ValidarGpu(Celular3.GRAFICOS));
            Assert.IsNotNull(Celular3.ValidarRam(Celular3.MEMORIA_RAM));
            Assert.IsNotNull(Celular3.ValidarMarca(Celular3.MARCA_CPU));
            Assert.IsNotNull(Celular3.ValidarAlmacenamiento(Celular3.ALMACENAMIENTO));
            Assert.IsNotNull(Celular3.ValidarSistemaOperativo(Celular3.SISTEMA_OPERATIVO));
        }

        [TestMethod]
        //Pruebo si los metodos validar funcionan en caso de ingresar componentes incorrectos
        public void ProbarValidacionComponentes_False()
        {
            Entidades.FabricaCelular Celular4 = new Entidades.FabricaCelular(MarcaCPU.AMD, GPU.GTX_1080_TI_11GB, RAM.Corsair_Dominator_Platinum_RGB_16GB, SistemaOP.Windows_8, Almacenamiento.HDD_SATA_10TB, 498, Camara._16MP, Bateria._8000_mAh, MaterialCarcasa.Plastico, PantallaPulgadas._6_5, PantallaResolucion._2560x1440_Pixeles, true, false);

            Assert.IsNotNull(Celular4.ValidarGpu(Celular4.GRAFICOS));
            Assert.IsNotNull(Celular4.ValidarRam(Celular4.MEMORIA_RAM));
            Assert.IsNotNull(Celular4.ValidarMarca(Celular4.MARCA_CPU));
            Assert.IsNotNull(Celular4.ValidarAlmacenamiento(Celular4.ALMACENAMIENTO));
            Assert.IsNotNull(Celular4.ValidarSistemaOperativo(Celular4.SISTEMA_OPERATIVO));
        }
        #endregion
    }
}
