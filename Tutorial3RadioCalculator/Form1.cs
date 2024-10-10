namespace Tutorial3RadioCalculator
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal answer = 0, firstOperand, secondOperand;
            if (decimal.TryParse(txtFirstOperand.Text, out firstOperand) && decimal.TryParse(txtSecondOperand.Text, out secondOperand))
            {
                if (rdoAdd.Checked)
                {
                    answer = firstOperand + secondOperand;
                }
                //TODO: put other operations here

                txtAns.Text = answer.ToString();
            }
            else
            {
                MessageBox.Show("Please ensure you have entered two numbers into the textboxes!");
            }
        }
    }
}
