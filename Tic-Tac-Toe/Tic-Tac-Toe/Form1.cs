namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        char turn = 'X';
        int currentTurn = 0;

        public void Winner()
        {
            for (int i = 0; i < 8; i++)
            {
                String combination = "";
                switch (i)
                {
                    case 0:
                        combination = button1.Text + button2.Text + button3.Text;
                        break;
                    case 1:
                        combination = button4.Text + button5.Text + button6.Text;
                        break;
                    case 2:
                        combination = button7.Text + button8.Text + button9.Text;
                        break;
                    case 3:
                        combination = button1.Text + button4.Text + button7.Text;
                        break;
                    case 4:
                        combination = button2.Text + button5.Text + button8.Text;
                        break;
                    case 5:
                        combination = button3.Text + button6.Text + button9.Text;
                        break;
                    case 6:
                        combination = button1.Text + button5.Text + button9.Text;
                        break;
                    case 7:
                        combination = button7.Text + button5.Text + button3.Text;
                        break;
                }
                if (combination.Equals("OOO"))
                {
                    reset();
                    MessageBox.Show("0 has won the game!", "We have a winner!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (combination.Equals("XXX"))
                {
                    reset();
                    MessageBox.Show("X has won the game!", "We have a winner!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (currentTurn == 9)
                    {
                        reset();
                        MessageBox.Show("We have a draw!", "No winner", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }     
        public void reset()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button1.BackColor = System.Drawing.Color.White;
            button2.BackColor = System.Drawing.Color.White;
            button3.BackColor = System.Drawing.Color.White;
            button4.BackColor = System.Drawing.Color.White;
            button5.BackColor = System.Drawing.Color.White;
            button6.BackColor = System.Drawing.Color.White;
            button7.BackColor = System.Drawing.Color.White;
            button8.BackColor = System.Drawing.Color.White;
            button9.BackColor = System.Drawing.Color.White;
            turn = 'X';
            currentTurn = 0;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentTurn++;
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
            if (turn.Equals('X'))
            {
                button1.BackColor = System.Drawing.Color.Red;
            }
            else if (turn.Equals('O'))
            {
                button1.BackColor = System.Drawing.Color.Cyan;
            }
            Winner();
           
        }
        private void button2_Click(object sender, EventArgs e)
        {
            currentTurn++;
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
            if (turn.Equals('X'))
            {
                button2.BackColor = System.Drawing.Color.Red;
            }
            else if (turn.Equals('O'))
            {
                button2.BackColor = System.Drawing.Color.Cyan;
            }
            Winner();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            currentTurn++;
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
            if (turn.Equals('X'))
            {
                button3.BackColor = System.Drawing.Color.Red;
            }
            else if (turn.Equals('O'))
            {
                button3.BackColor = System.Drawing.Color.Cyan;
            }
            Winner();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            currentTurn++;
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
            if (turn.Equals('X'))
            {
                button4.BackColor = System.Drawing.Color.Red;
            }
            else if (turn.Equals('O'))
            {
                button4.BackColor = System.Drawing.Color.Cyan;
            }
            Winner();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            currentTurn++;
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
            if (turn.Equals('X'))
            {
                button5.BackColor = System.Drawing.Color.Red;
            }
            else if (turn.Equals('O'))
            {
                button5.BackColor = System.Drawing.Color.Cyan;
            }
            Winner();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            currentTurn++;
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
            if (turn.Equals('X'))
            {
                button6.BackColor = System.Drawing.Color.Red;
            }
            else if (turn.Equals('O'))
            {
                button6.BackColor = System.Drawing.Color.Cyan;
            }
            Winner();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            currentTurn++;
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
            if (turn.Equals('X'))
            {
                button7.BackColor = System.Drawing.Color.Red;
            }
            else if (turn.Equals('O'))
            {
                button7.BackColor = System.Drawing.Color.Cyan;
            }
            Winner();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            currentTurn++;
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
            if (turn.Equals('X'))
            {
                button8.BackColor = System.Drawing.Color.Red;
            }
            else if (turn.Equals('O'))
            {
                button8.BackColor = System.Drawing.Color.Cyan;
            }
            Winner();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            currentTurn++;
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
            if (turn.Equals('X'))
            {
                button9.BackColor = System.Drawing.Color.Red;
            }
            else if (turn.Equals('O'))
            {
                button9.BackColor = System.Drawing.Color.Cyan;
            }
            Winner();
        }
       
    }
}