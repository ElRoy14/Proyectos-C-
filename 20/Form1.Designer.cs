namespace _20;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>

    public TextBox textBar1;
    public Button number1;
    public Button number2;
    public Button number3;
    public Button number4;
    public Button number5;
    public Button number6;
    public Button number7;
    public Button number8;
    public Button number9;
    public Button number0;
    public Button suma;
    public Button resta;
    public Button multiplicacion;
    public Button division;
    public Button resultado;
    public String texto;

    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Text = "CALCULADORA";

    InitializeMyButton();

    }

    private void InitializeMyButton()
        {

            double num1, num2, resultado;

            this.textBar1 = new System.Windows.Forms.TextBox();
            this.number1 = new System.Windows.Forms.Button();
            this.number1.MouseClick += new MouseEventHandler(number1_click);
            this.number2 = new System.Windows.Forms.Button();
            //this.number2.Click += new EventHandler(number2_click);
            this.number3 = new System.Windows.Forms.Button();
            //this.number3.Click += new EventHandler(number3_click);
            this.number4 = new System.Windows.Forms.Button();
            //this.number4.Click += new EventHandler(number4_click);
            this.number5 = new System.Windows.Forms.Button();
            //this.number5.Click += new EventHandler(number5_click);
            this.number6 = new System.Windows.Forms.Button();
            //this.number6.Click += new EventHandler(number6_click);
            this.number7 = new System.Windows.Forms.Button();
            //this.number7.Click += new EventHandler(number7_click);
            this.number8 = new System.Windows.Forms.Button();
            //this.number8.Click += new EventHandler(number8_click);
            this.number9 = new System.Windows.Forms.Button();
            //this.number9.Click += new EventHandler(number9_click);
            this.number0 = new System.Windows.Forms.Button();
            //this.number0.Click += new EventHandler(number0_click);
            this.suma = new System.Windows.Forms.Button();
            //this.suma.Click += new EventHandler(number1_click);
            this.resta = new System.Windows.Forms.Button();
            //this.resta.Click += new EventHandler(number1_click);
            this.multiplicacion = new System.Windows.Forms.Button();
            //this.multiplicacion.Click += new EventHandler(number1_click);
            this.division = new System.Windows.Forms.Button();
            //this.division.Click += new EventHandler(number1_click);
            this.resultado = new System.Windows.Forms.Button();
            //this.resultado.Click += new EventHandler(number1_click);

            this.Controls.Add(this.textBar1);
            this.Controls.Add(this.number1);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.number3);
            this.Controls.Add(this.number4);
            this.Controls.Add(this.number5);
            this.Controls.Add(this.number6);
            this.Controls.Add(this.number7);
            this.Controls.Add(this.number8);
            this.Controls.Add(this.number9);
            this.Controls.Add(this.number0);
            this.Controls.Add(this.suma);
            this.Controls.Add(this.resta);
            this.Controls.Add(this.multiplicacion);
            this.Controls.Add(this.division);
            this.Controls.Add(this.resultado);

            this.textBar1.Location = new Point(50,50);
            this.textBar1.Size = new Size(147,10);
            this.number1.Location = new Point(50,72);
            this.number1.Text = "1";
            this.number1.Size = new Size(30,30);
            this.number2.Location = new Point(79,72);
            this.number2.Text = "2";
            this.number2.Size = new Size(30,30);
            this.number3.Location = new Point(108,72);
            this.number3.Text = "3";
            this.number3.Size = new Size(30,30);
            this.number4.Location = new Point(50,101);
            this.number4.Text = "4";
            this.number4.Size = new Size(30,30);
            this.number5.Location = new Point(79,101);
            this.number5.Text = "5";
            this.number5.Size = new Size(30,30);
            this.number6.Location = new Point(108,101);
            this.number6.Text = "6";
            this.number6.Size = new Size(30,30);
            this.number7.Location = new Point(50,130);
            this.number7.Text = "7";
            this.number7.Size = new Size(30,30);
            this.number8.Location = new Point(79,130);
            this.number8.Text = "8";
            this.number8.Size = new Size(30,30);
            this.number9.Location = new Point(108,130);
            this.number9.Text = "9";
            this.number9.Size = new Size(30,30);
            this.number0.Location = new Point(137,130);
            this.number0.Text = "0";
            this.number0.Size = new Size(30,30);
            this.suma.Location = new Point(137,72);
            this.suma.Text = "+";
            this.suma.Size = new Size(30,30);
            this.resta.Location = new Point(166,72);
            this.resta.Text = "-";
            this.resta.Size = new Size(30,30);
            this.multiplicacion.Location = new Point(137,101);
            this.multiplicacion.Text = "x";
            this.multiplicacion.Size = new Size(30,30);
            this.division.Location = new Point(166,101);
            this.division.Text = "÷";
            this.division.Size = new Size(30,30);
            this.resultado.Location = new Point(166,130);
            this.resultado.Text = "=";
            this.resultado.Size = new Size(30,30);

            MessageBox.Show("NO TENGO FUELZA YO");



        }

        public void number1_click(object sender, EventArgs e)
        {

            if(textBar1.Text.Length != 0)
            {

                textBar1.Text = (texto + "1");

            }

            this.textBar1.Text = "1";

            texto = textBar1.Text;

        }


    #endregion
}
