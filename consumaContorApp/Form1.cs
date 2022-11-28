namespace consumaContorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public consumator client1 = new consumator("numele","prenumele");
        public float indexactual;
        private void Form1_Load(object sender, EventArgs e)
        {
            client1.contoare.Add(new contor("bucatarie", "aparece"));
            client1.contoare[0].inregistrareContor(100.1f);
             indexactual = client1.contoare[0].citireContor();
            this.textBox1.Text += client1.nume + " \r\t " + client1.prenume + " \r\t " + indexactual.ToString() + " \r\t " + client1.contoare[0].diferentadintreultimeledouacitiri().ToString();

            this.textBox1.Text += "\r\n";

            client1.contoare[0].inregistrareContor(200.1f);
             indexactual = client1.contoare[0].citireContor();
            this.textBox1.Text += client1.nume + " \r\t " + client1.prenume + " \r\t " + indexactual.ToString() + " \r\t " + client1.contoare[0].diferentadintreultimeledouacitiri().ToString();

        }
    }
}