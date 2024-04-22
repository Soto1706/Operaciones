namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.cmbOperaciones.Items.Add("Suma");
            this.cmbOperaciones.Items.Add("Resta");
            this.cmbOperaciones.Items.Add("Division");
            this.cmbOperaciones.Items.Add("Multiplicacion");
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int resultado = 0;
            string operacion=this.cmbOperaciones.SelectedItem.ToString();
            switch (operacion)
            {
                case "Suma":resultado = int.Parse(this.txtNum1.Text) + int.Parse(this.txtNum2.Text);
                    break;
                case "Resta":
                    resultado = int.Parse(this.txtNum1.Text) - int.Parse(this.txtNum2.Text);
                    break;
                case "Divicion":
                    resultado = int.Parse(this.txtNum1.Text) / int.Parse(this.txtNum2.Text);
                    break;
                case "Multiplicacion":
                    resultado = int.Parse(this.txtNum1.Text) * int.Parse(this.txtNum2.Text);
                    break;

                default:
                    break;
            } 
            this.txtResultado.Text = resultado.ToString();

        }
    }
}
