using System;
using System.Web.UI;

namespace WeBcalculadora
{
    public partial class Calculadora : Page
    {
        protected void Page_Load(object sender, EventArgs e) { }

        private void AgregarNumero(string num)
        {
            lresultado.Text += num;
        }

        protected void b1_Click(object sender, EventArgs e) { AgregarNumero("1"); }
        protected void b2_Click(object sender, EventArgs e) { AgregarNumero("2"); }
        protected void b3_Click(object sender, EventArgs e) { AgregarNumero("3"); }
        protected void b4_Click(object sender, EventArgs e) { AgregarNumero("4"); }
        protected void b5_Click(object sender, EventArgs e) { AgregarNumero("5"); }
        protected void b6_Click(object sender, EventArgs e) { AgregarNumero("6"); }
        protected void b7_Click(object sender, EventArgs e) { AgregarNumero("7"); }
        protected void b8_Click(object sender, EventArgs e) { AgregarNumero("8"); }
        protected void b9_Click(object sender, EventArgs e) { AgregarNumero("9"); }
        protected void b0_Click(object sender, EventArgs e) { AgregarNumero("0"); }

        // OPERACIONES
        protected void bsuma_Click(object sender, EventArgs e)
        {
            ClsOperacion.valor1 = float.Parse(lresultado.Text);
            ClsOperacion.sumar = true;
            lresultado.Text = "";
        }

        protected void bresta_Click(object sender, EventArgs e)
        {
            ClsOperacion.valor1 = float.Parse(lresultado.Text);
            ClsOperacion.restar = true;
            lresultado.Text = "";
        }

        protected void bmulti_Click(object sender, EventArgs e)
        {
            ClsOperacion.valor1 = float.Parse(lresultado.Text);
            ClsOperacion.multiplicar = true;
            lresultado.Text = "";
        }

        protected void bdivi_Click(object sender, EventArgs e)
        {
            ClsOperacion.valor1 = float.Parse(lresultado.Text);
            ClsOperacion.dividir = true;
            lresultado.Text = "";
        }

        // ESPECIALES
        protected void bpot2_Click(object sender, EventArgs e)
        {
            float r = ClsOperacion.metodo_exponente2(float.Parse(lresultado.Text));
            lresultado.Text = r.ToString();
        }

        protected void bpot3_Click(object sender, EventArgs e)
        {
            float r = ClsOperacion.metodo_exponente3(float.Parse(lresultado.Text));
            lresultado.Text = r.ToString();
        }

        protected void braiz_Click(object sender, EventArgs e)
        {
            float r = ClsOperacion.metodo_raiz(float.Parse(lresultado.Text));
            lresultado.Text = r.ToString();
        }

        protected void bfactorial_Click(object sender, EventArgs e)
        {
            float r = ClsOperacion.metodo_factorial(float.Parse(lresultado.Text));
            lresultado.Text = r.ToString();
        }

        protected void bfibo_Click(object sender, EventArgs e)
        {
            float r = ClsOperacion.metodo_fibonacci(float.Parse(lresultado.Text));
            lresultado.Text = r.ToString();
        }

        // RESULTADO =
        protected void bresultado_Click(object sender, EventArgs e)
        {
            ClsOperacion.valor2 = float.Parse(lresultado.Text);
            float res = 0;

            if (ClsOperacion.sumar)
                res = ClsOperacion.metodo_sumar(ClsOperacion.valor1, ClsOperacion.valor2);

            if (ClsOperacion.restar)
                res = ClsOperacion.metodo_restar(ClsOperacion.valor1, ClsOperacion.valor2);

            if (ClsOperacion.multiplicar)
                res = ClsOperacion.metodo_multiplicar(ClsOperacion.valor1, ClsOperacion.valor2);

            if (ClsOperacion.dividir)
            {
                if (ClsOperacion.valor2 == 0)
                {
                    lresultado.Text = "Error";
                    return;
                }
                res = ClsOperacion.metodo_dividir(ClsOperacion.valor1, ClsOperacion.valor2);
            }

            lresultado.Text = res.ToString();
            ClsOperacion.limpiar();
        }

        protected void bclear_Click(object sender, EventArgs e)
        {
            lresultado.Text = "";
            ClsOperacion.limpiar();
        }
    }
}