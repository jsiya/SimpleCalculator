namespace CalcSimple
{
    public partial class Form1 : Form
    {
        decimal num1 = 0, num2 = 0;
        int numIndex = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void calcBox_TextChanged(object sender, EventArgs e)
        {
            if (calcBox.Text.Length == 0)
            {
                calcBox.Text = "0";
            }

        }

        private void oneBtn_MouseClick(object sender, MouseEventArgs e)
        {
            if (calcBox.Text == "0") calcBox.Text = "1";
            else
                calcBox.Text += "1";
        }

        private void twoBtn_MouseClick(object sender, MouseEventArgs e)
        {
            if (calcBox.Text == "0") calcBox.Text = "2";
            else
                calcBox.Text += "2";
        }

        private void threeBtn_MouseClick(object sender, MouseEventArgs e)
        {
            if (calcBox.Text == "0") calcBox.Text = "3";
            else
                calcBox.Text += "3";
        }

        private void fourBtn_MouseClick(object sender, MouseEventArgs e)
        {
            if (calcBox.Text == "0") calcBox.Text = "4";
            else
                calcBox.Text += "4";
        }

        private void fiveBtn_MouseClick(object sender, MouseEventArgs e)
        {
            if (calcBox.Text == "0") calcBox.Text = "5";
            else
                calcBox.Text += "5";
        }

        private void sixBtn_MouseClick(object sender, MouseEventArgs e)
        {
            if (calcBox.Text == "0") calcBox.Text = "6";
            else
                calcBox.Text += "6";
        }

        private void sevenBtn_MouseClick(object sender, MouseEventArgs e)
        {
            if (calcBox.Text == "0") calcBox.Text = "7";
            else
                calcBox.Text += "7";
        }

        private void eightBtn_MouseClick(object sender, MouseEventArgs e)
        {
            if (calcBox.Text == "0") calcBox.Text = "8";
            else
                calcBox.Text += "8";
        }

        private void nineBtn_MouseClick(object sender, MouseEventArgs e)
        {
            if (calcBox.Text == "0") calcBox.Text = "9";
            else
                calcBox.Text += "9";
        }

        private void zeroBtn_MouseClick(object sender, MouseEventArgs e)
        {
            if (calcBox.Text == "0") calcBox.Text = "0";
            else
                calcBox.Text += "0";
        }

        private void dotBtn_MouseClick(object sender, MouseEventArgs e)
        {
            calcBox.Text += ".";
        }

        private void acBtn_MouseClick(object sender, MouseEventArgs e)
        {
            calcBox.Text = "0";
        }

        private void addBtn_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void subBtn_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void multiBtn_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void divBtn_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void equalBtn_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void perBtn_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void signBtn_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
    }
}