namespace CalcSimple
{
    public partial class Form1 : Form
    {
        decimal num1 = 0;
        int numIndex = 0, res, num2;
        char lastSign = ' ';
        public Form1()
        {
            InitializeComponent();
        }

        private void calcBox_TextChanged(object sender, EventArgs e)
        {
            if (calcBox.Text.Length == 0)
            {
                calcBox.Text = "00";
            }

        }

        private void oneBtn_MouseClick(object sender, MouseEventArgs e)
        {
            if (calcBox.Text == "00") calcBox.Text = "1";
            else if (num1.ToString() != calcBox.Text)
                calcBox.Text += "1";
        }

        private void twoBtn_MouseClick(object sender, MouseEventArgs e)
        {
            if (calcBox.Text == "00") calcBox.Text = "2";
            else if (num1.ToString() != calcBox.Text)
                calcBox.Text += "2";
        }

        private void threeBtn_MouseClick(object sender, MouseEventArgs e)
        {
            if (calcBox.Text == "00") calcBox.Text = "3";
            else if (num1.ToString() != calcBox.Text)
                calcBox.Text += "3";
        }

        private void fourBtn_MouseClick(object sender, MouseEventArgs e)
        {
            if (calcBox.Text == "00") calcBox.Text = "4";
            else if (num1.ToString() != calcBox.Text)
                calcBox.Text += "4";
        }

        private void fiveBtn_MouseClick(object sender, MouseEventArgs e)
        {
            if (calcBox.Text == "00") calcBox.Text = "5";
            else if (num1.ToString() != calcBox.Text) 
                calcBox.Text += "5";
        }

        private void sixBtn_MouseClick(object sender, MouseEventArgs e)
        {
            if (calcBox.Text == "00") calcBox.Text = "6";
            else if (num1.ToString() != calcBox.Text)
                calcBox.Text += "6";
        }

        private void sevenBtn_MouseClick(object sender, MouseEventArgs e)
        {
            if (calcBox.Text == "00") calcBox.Text = "7";
            else if (num1.ToString() != calcBox.Text)
                calcBox.Text += "7";
        }

        private void eightBtn_MouseClick(object sender, MouseEventArgs e)
        {
            if (calcBox.Text == "00") calcBox.Text = "8";
            else if (num1.ToString() != calcBox.Text)
                calcBox.Text += "8";
        }

        private void nineBtn_MouseClick(object sender, MouseEventArgs e)
        {
            if (calcBox.Text == "00") calcBox.Text = "9";
            else if (num1.ToString() != calcBox.Text)
                calcBox.Text += "9";
        }

        private void zeroBtn_MouseClick(object sender, MouseEventArgs e)
        {
            if (calcBox.Text == "00") calcBox.Text = "0";
            else if (num1.ToString() != calcBox.Text)
                calcBox.Text += "0";
        }

        private void dotBtn_MouseClick(object sender, MouseEventArgs e)
        {
            //if (calcBox.Text[calcBox.Text.Length - 1] != '+' && calcBox.Text[calcBox.Text.Length - 1] != '*'
            //    && calcBox.Text[calcBox.Text.Length - 1] != '-' && calcBox.Text[calcBox.Text.Length - 1] != '/')
            if (calcBox.Text == "00") calcBox.Text = "0.";
            else if (num1.ToString() != calcBox.Text)
                calcBox.Text += ".";
        }

        private void acBtn_MouseClick(object sender, MouseEventArgs e)
        {
            calcBox.Text = "0";
            numIndex = 0;
            num1 = 0;
            lastSign = ' ';
        }

        private void addBtn_MouseClick(object sender, MouseEventArgs e)
        {
            Operation();
            lastSign = '+';
            calcBox.Text += "+";
        }

        private void subBtn_MouseClick(object sender, MouseEventArgs e)
        {
            Operation();
            lastSign = '-';
            calcBox.Text += "-";
        }

        private void multiBtn_MouseClick(object sender, MouseEventArgs e)
        {
            Operation();
            lastSign = '*';
            calcBox.Text += "*";
        }

        private void divBtn_MouseClick(object sender, MouseEventArgs e)
        {
            Operation();
            lastSign = '/';
            calcBox.Text += "/";
        }

        private void equalBtn_MouseClick(object sender, MouseEventArgs e)
        {
            Operation();
            lastSign = '=';
            calcBox.Text = num1.ToString();
        }

        private void perBtn_MouseClick(object sender, MouseEventArgs e)
        {
            //------------------
        }

        private void signBtn_MouseClick(object sender, MouseEventArgs e)
        {
            //--------------------
        }

        private void Operation()
        {
            if (lastSign == '+' || lastSign == ' ')
            {
                num1 += decimal.Parse(calcBox.Text.Substring(numIndex));
            }
            else if (lastSign == '-')
            {
                num1 -= decimal.Parse(calcBox.Text.Substring(numIndex));
            }
            else if (lastSign == '*')
            {
                num1 *= decimal.Parse(calcBox.Text.Substring(numIndex));
            }
            else if (lastSign == '/')
            {
                num1 /= decimal.Parse(calcBox.Text.Substring(numIndex));
            }
            else if (lastSign == '%')
            {
                if (Int32.TryParse(num1.ToString(), out res) && Int32.TryParse(calcBox.Text.Substring(numIndex), out num2))
                {
                    res %= num2;
                }
                num1 %= decimal.Parse(calcBox.Text.Substring(numIndex));
            }
            numIndex = calcBox.Text.Length + 1;
        }

    }
}