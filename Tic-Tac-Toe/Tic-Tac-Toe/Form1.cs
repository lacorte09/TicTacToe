namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        char turn = 'X';

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = turn.ToString();
            button1.Enabled = false;
            if (turn == 'X')
            {
                turn = 'O';
            }
            else
            {
                turn = 'X';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = turn.ToString();
            button2.Enabled = false;
            if (turn == 'X')
            {
                turn = 'O';
            }
            else
            {
                turn = 'X';
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = turn.ToString();
            button3.Enabled = false;
            if (turn == 'X')
            {
                turn = 'O';
            }
            else
            {
                turn = 'X';
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = turn.ToString();
            button4.Enabled = false;
            if (turn == 'X')
            {
                turn = 'O';
            }
            else
            {
                turn = 'X';
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = turn.ToString();
            button5.Enabled = false;
            if (turn == 'X')
            {
                turn = 'O';
            }
            else
            {
                turn = 'X';
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text = turn.ToString();
            button6.Enabled = false;
            if (turn == 'X')
            {
                turn = 'O';
            }
            else
            {
                turn = 'X';
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Text = turn.ToString();
            button7.Enabled = false;
            if (turn == 'X')
            {
                turn = 'O';
            }
            else
            {
                turn = 'X';
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Text = turn.ToString();
            button8.Enabled = false;
            if (turn == 'X')
            {
                turn = 'O';
            }
            else
            {
                turn = 'X';
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Text = turn.ToString();
            button9.Enabled = false;
            if (turn == 'X')
            {
                turn = 'O';
            }
            else
            {
                turn = 'X';
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
        }
    }
}