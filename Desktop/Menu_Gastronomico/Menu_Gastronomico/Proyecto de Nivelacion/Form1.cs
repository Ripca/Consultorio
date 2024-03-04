using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmMenuGastronomico : Form
    {
        public frmMenuGastronomico()
        {
            InitializeComponent();
        }

        private void frmMenuGastronomico_Load(object sender, EventArgs e)
        {

        }

        private void rbtnDesayuno_CheckedChanged(object sender, EventArgs e)
        {
            lblOp1.Text="Cereal con fresas";
            lblPrecioOp1.Text = "18.00";
            Image imagenOp1 = Image.FromFile("Desayuno1_Cereal.jpg");
            ptbOp1.Image = imagenOp1;
            ptbOp1.SizeMode = PictureBoxSizeMode.StretchImage;
            nudCantidadOp1.Value = 0;
            nudCantidadOp1.Value = 0;

            lblOp2.Text = "Huevos Rancheros";
            lblPrecioOp2.Text = "20.00";            
            Image imagenOp2 = Image.FromFile("Desayuno2_Huevos-rancheros.png");
            ptbOp2.Image = imagenOp2;
            ptbOp2.SizeMode = PictureBoxSizeMode.StretchImage;
            nudCantidadOp2.Value = 0;
            nudCantidadOp2.Value = 0;

            lblOp3.Text = "Cafe con Pan";
            lblPrecioOp3.Text = "15.00";
            Image imagenOp3 = Image.FromFile("Desayuno3_Pan-con-cafe.png");
            ptbOp3.Image = imagenOp3;
            ptbOp3.SizeMode = PictureBoxSizeMode.StretchImage;
            nudCantidadOp3.Value = 0;
            nudCantidadOp3.Value = 0;

            lblOp4.Text = "Panqueques";
            lblPrecioOp4.Text = "40.00";
            Image imagenOp4 = Image.FromFile("Desayuno4_Panqueques.jpg");
            ptbOp4.Image = imagenOp4;
            ptbOp4.SizeMode = PictureBoxSizeMode.StretchImage;
            nudCantidadOp4.Value = 0;
            nudCantidadOp4.Value = 0;

            lblOp5.Text = "Huevos y frijoles";
            lblPrecioOp5.Text = "20.00";
            Image imagenOp5 = Image.FromFile("Desayuno5_Huevos y frijoles.jpg");
            ptbOp5.Image = imagenOp5;
            ptbOp5.SizeMode = PictureBoxSizeMode.StretchImage;
            nudCantidadOp5.Value = 0;
            nudCantidadOp5.Value = 0;     
        }
        private void rbtnAlmuerzo_CheckedChanged_1(object sender, EventArgs e)
        {
            lblOp1.Text = "Hamburguesa";
            lblPrecioOp1.Text = "65.00";
            Image imagenOp1 = Image.FromFile("Almuerzo1_Hamburguesa.jpeg");
            ptbOp1.Image = imagenOp1;
            ptbOp1.SizeMode = PictureBoxSizeMode.StretchImage;
            nudCantidadOp1.Value = 0;
            nudCantidadOp1.Value = 0;

            lblOp2.Text = "Caldo de pollo";
            lblPrecioOp2.Text = "30.00";
            Image imagenOp2 = Image.FromFile("Almuerzo2_Caldo de pollo.jpg");
            ptbOp2.Image = imagenOp2;
            ptbOp2.SizeMode = PictureBoxSizeMode.StretchImage;
            nudCantidadOp2.Value = 0;
            nudCantidadOp2.Value = 0;

            lblOp3.Text = "Pizza";
            lblPrecioOp3.Text = "40.00";
            Image imagenOp3 = Image.FromFile("Almuerzo3_Pizza.png");
            ptbOp3.Image = imagenOp3;
            ptbOp3.SizeMode = PictureBoxSizeMode.StretchImage;
            nudCantidadOp3.Value = 0;
            nudCantidadOp3.Value = 0;

            lblOp4.Text = "Carne con papas";
            lblPrecioOp4.Text = "65.00";
            Image imagenOp4 = Image.FromFile("Almuerzo4_Carne con papas.jpg");
            ptbOp4.Image = imagenOp4;
            ptbOp4.SizeMode = PictureBoxSizeMode.StretchImage;
            nudCantidadOp4.Value = 0;
            nudCantidadOp4.Value = 0;

            lblOp5.Text = "Pescado con arroz";
            lblPrecioOp5.Text = "40.00";
            Image imagenOp5 = Image.FromFile("Almuerzo5_Pescado con arroz.jpg");
            ptbOp5.Image = imagenOp5;
            ptbOp5.SizeMode = PictureBoxSizeMode.StretchImage;
            nudCantidadOp5.Value = 0;
            nudCantidadOp5.Value = 0;
        }
        private void rbtnCena_CheckedChanged(object sender, EventArgs e)
        {
            lblOp1.Text = "Spaghetti";
            lblPrecioOp1.Text = "25.00";
            Image imagenOp1 = Image.FromFile("Cena1_Spaghetti.jpg");
            ptbOp1.Image = imagenOp1;
            ptbOp1.SizeMode = PictureBoxSizeMode.StretchImage;
            nudCantidadOp1.Value = 0;
            nudCantidadOp1.Value = 0;

            lblOp2.Text = "Ratatouille";
            lblPrecioOp2.Text = "45.00";
            Image imagenOp2 = Image.FromFile("Cena2_Ratatouille.jpg");
            ptbOp2.Image = imagenOp2;
            ptbOp2.SizeMode = PictureBoxSizeMode.StretchImage;
            nudCantidadOp2.Value = 0;
            nudCantidadOp2.Value = 0;

            lblOp3.Text = "Omelette";
            lblPrecioOp3.Text = "15.00";
            Image imagenOp3 = Image.FromFile("Cena3_Omelette.jpg");
            ptbOp3.Image = imagenOp3;
            ptbOp3.SizeMode = PictureBoxSizeMode.StretchImage;
            nudCantidadOp3.Value = 0;
            nudCantidadOp3.Value = 0;

            lblOp4.Text = "Pollo asado";
            lblPrecioOp4.Text = "65.00";
            Image imagenOp4 = Image.FromFile("Cena4_Pollo asado.jpg");
            ptbOp4.Image = imagenOp4;
            ptbOp4.SizeMode = PictureBoxSizeMode.StretchImage;
            nudCantidadOp4.Value = 0;
            nudCantidadOp4.Value = 0;

            lblOp5.Text = "Chilaquiles";
            lblPrecioOp5.Text = "40.00";
            Image imagenOp5 = Image.FromFile("Cena5_Chilaquiles.jpg");
            ptbOp5.Image = imagenOp5;
            ptbOp5.SizeMode = PictureBoxSizeMode.StretchImage;
            nudCantidadOp5.Value = 0;
            nudCantidadOp5.Value = 0;
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            double precioOp1 = double.Parse(lblPrecioOp1.Text);
            double precioOp2 = double.Parse(lblPrecioOp2.Text);
            double precioOp3 = double.Parse(lblPrecioOp3.Text);
            double precioOp4 = double.Parse(lblPrecioOp4.Text);
            double precioOp5 = double.Parse(lblPrecioOp5.Text);

            int canOp1 = int.Parse(nudCantidadOp1.Value.ToString());
            int canOp2 = int.Parse(nudCantidadOp2.Value.ToString());
            int canOp3 = int.Parse(nudCantidadOp3.Value.ToString());
            int canOp4 = int.Parse(nudCantidadOp4.Value.ToString());
            int canOp5 = int.Parse(nudCantidadOp5.Value.ToString());

            double totalFinal = (precioOp1 * canOp1) + (precioOp2 * canOp2) + (precioOp3 * canOp3) + (precioOp4 * canOp4) + (precioOp5 * canOp5);
            lblTotal.Text = "Q. " + totalFinal.ToString() + ".00"; 
            //No utilice el ToString ya que al iniciar con comillas todo lo que sigue se transforma en
            //en una cadena automaticamente, lo que transforma la varible double en string


        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            nudCantidadOp1.Value=0;
            nudCantidadOp2.Value = 0;
            nudCantidadOp3.Value = 0;
            nudCantidadOp4.Value = 0;
            nudCantidadOp5.Value = 0;
            lblTotal.Text = "";
        }
    }
}
