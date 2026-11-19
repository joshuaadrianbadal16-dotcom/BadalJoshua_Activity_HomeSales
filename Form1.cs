namespace BadalJoshua_Activity_HomeSales
{
    public partial class Form1 : Form
    {
        double Danielle = 0;
        double Edward = 0;
        double Fatima = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void getSalesPerson_Amount(String salesInitial, double salesAmount)
        {
            string message = "";

            switch (salesInitial.ToUpper())
            {
                case "D":
                    Danielle += salesAmount;
                    message = "Salesperson: Danielle\n" +
                              "\nSale Amount: " + salesAmount.ToString("C2") + "\n" +
                              "\nTotal Sales: " + Danielle.ToString("C2");
                    break;
                case "E":
                    Edward += salesAmount;
                    message = "Salesperson: Edward\n" +
                              "\nSale Amount: " + salesAmount.ToString("C2") + "\n" +
                              "\nTotal Sales: " + Edward.ToString("C2");
                    break;
                case "F":
                    Fatima += salesAmount;
                    message = "Salesperson: Fatima\n" +
                              "\nSale Amount: " + salesAmount.ToString("C2") + "\n" +
                              "\nTotal Sales: " + Fatima.ToString("C2");
                    break;
                default:
                    message = "Invalid Sales Person Initial";
                    break;

            }

            Lbl_Display.Text = message;
        }

        private void clearEntry()
        {
            Txt_SalesInitial.Clear();
            Txt_SalesAmount.Clear();
            Lbl_Display.Text = "";

            Txt_SalesInitial.Focus();
        }

        private void Btn_Submit_Click(object sender, EventArgs e)
        {
            string salesInitial = Txt_SalesInitial.Text.Trim();
            double salesAmount;

            if (salesInitial == "")
            {
                MessageBox.Show("Please enter a salesperson initial.");
                Txt_SalesInitial.Focus();
                return;
            }

            if (!double.TryParse(Txt_SalesAmount.Text, out salesAmount))
            {
                MessageBox.Show("Please enter a valid sale amount.");
                Txt_SalesAmount.Focus();
                return;
            }

            if (salesAmount < 0)
            {
                MessageBox.Show("Sale amount cannot be negative.");
                return;
            }

            if (salesInitial.ToUpper() != "D" &&
                salesInitial.ToUpper() != "E" &&
                salesInitial.ToUpper() != "F")
            {
                MessageBox.Show("Invalid initial! Enter D, E, or F.");
                Txt_SalesInitial.Focus();
                return;
            }

            getSalesPerson_Amount(salesInitial, salesAmount);
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            clearEntry();
        }

        private void Btn_Print_Click(object sender, EventArgs e)
        {
            Form2 report = new Form2(Danielle, Edward, Fatima);

            report.ShowDialog();
        }
    }
}

