using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;


namespace Cwk_ScientificCalculator
{
    public partial class frmCalculator : Form
    {
        MySqlConnection con;
        //This string variable is used to store the value stored and retrieved by the memory functions
        string memory = "";
        //string connectionString = "Server=localhost;Database=one;User Id=root;Password=Aa123456;";
        
        public frmCalculator()
        {
            InitializeComponent();
        }

        // Used as a shared click event for all number buttons and most operation buttons
        private void inputNumberOrOperator(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
                txtDisplay.Clear();

            txtDisplay.Text += ((Button)sender).Text;
        }

        // Used for pressing the '.' button
        private void inputDot(object sender, EventArgs e)
        {
            txtDisplay.Text += ((Button)sender).Text;
        }

        //Changes the button color while it is being clicked to visually show the user the button click
        private void buttonPressEffect(object sender, MouseEventArgs e)
        {
            ((Button)sender).BackColor = Color.RoyalBlue;
        }

        //Changes the button color back to the original to visually show the user that the button click has been released
        private void buttonReleaseEffect(object sender, MouseEventArgs e)
        {
            ((Button)sender).BackColor = Color.MidnightBlue;
        }

        // Clears the display and sets it to 0
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            txtDisplay.Text = "0";
        }

        /* Removes the last character of the display, or if there is a space,
        it will delete all spaces and the most recent number or operator*/
        private void btnBackspace_Click(object sender, EventArgs e)
        {
            for (int i = txtDisplay.Text.Length - 1; i >= 0; i--)
            {
                if (txtDisplay.Text[i] == ' ')
                {
                    txtDisplay.Text = txtDisplay.Text.Remove(i, 1);
                }
                else
                    break;
            }
            if (txtDisplay.Text.Length > 0)
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);

            if (txtDisplay.Text == "")
                txtDisplay.Text = "0";
        }

        // Calculates the answer of the equation contained in the display upon clicking the '=' button
        private void btnEquals_Click(object sender, EventArgs e)
        {
            string calculationString = txtDisplay.Text;
            // This breaks up the input string into individual equations by the spaces between each operator (e.g ' + ')
            List<string> equations = txtDisplay.Text.Split(' ').ToList();
            string connStr = "server=127.0.0.1;port=3306;user=root;password=Aa123456;database=calculator;";
            con = new MySqlConnection(connStr);
            try
            {
                //First calculates any equations between brackets
                List<string> newEquations = calculateBrackets(equations);
                //Once the bracket equations have been evaluated, uses theh calculate method to calculate the final answer
                txtDisplay.Text = calculate(newEquations);

                con.Open();
                string result = txtDisplay.Text;

                // Save the calculation and result to the database
                string query = "INSERT INTO CalculationHistory (CalculationString, Result) VALUES (@CalculationString, @Result)";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@CalculationString", calculationString);
                    cmd.Parameters.AddWithValue("@Result", result);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception exc)
            {
                txtDisplay.Text = "ERROR - Invalid Input";
            }
            
        }

        private List<string> calculateBrackets(List<string> equations)
        {

            for (int i = 0; i < equations.Count; i++)
            {
                //Searches for the first open bracket
                if (equations[i].Equals("("))
                {
                    for (int j = i; j < equations.Count; j++)
                    {
                        //Searches for the first closed bracket after the located open bracket
                        if (equations[j].Equals(")"))
                        {
                            //Creates a list of strings for containing the equations between the open and closed bracket
                            List<string> bracketEquations = new List<string>();

                            for (int k = i + 1; k < j; k++)
                            {
                                bracketEquations.Add(equations[k]);
                            }
                            //Calls the calculate method for the equations located between the brackets
                            string bracketAnswer = calculate(bracketEquations);
                            equations[i] = bracketAnswer;
                            for (int l = j; l > i; l--)
                            {
                                equations.RemoveAt(l);
                            }
                            break;
                        }
                    }
                }
            }
            return equations;
        }

        // Used to calculate the answer from the txtDisplay input
        private string calculate(List<string> equations)
        {

            //Sin Operation
            for (int i = 0; i < equations.Count; i++)
            {
                if (equations[i].Equals("Sin"))
                {
                    int rightValue = i + 1;
                    double result = Math.Sin(double.Parse(equations[rightValue]));

                    equations[i] = result.ToString();
                    equations.RemoveAt(rightValue);
                }
            }

            //Cos Operation
            for (int i = 0; i < equations.Count; i++)
            {
                if (equations[i].Equals("Cos"))
                {
                    int rightValue = i + 1;
                    double result = Math.Cos(double.Parse(equations[rightValue]));

                    equations[i] = result.ToString();
                    equations.RemoveAt(rightValue);
                }
            }

            //Tan Operation
            for (int i = 0; i < equations.Count; i++)
            {
                if (equations[i].Equals("Tan"))
                {
                    int rightValue = i + 1;
                    double result = Math.Tan(double.Parse(equations[rightValue]));

                    equations[i] = result.ToString();
                    equations.RemoveAt(rightValue);
                }
            }

            //Exponent Operation
            for (int i = 0; i < equations.Count; i++)
            {
                if (equations[i].Equals("Exp"))
                {
                    int rightValue = i + 1;
                    double result = Math.Exp(double.Parse(equations[rightValue]));

                    equations[i] = result.ToString();
                    equations.RemoveAt(rightValue);
                }
            }

            //Logarithm Operation
            for (int i = 0; i < equations.Count; i++)
            {
                if (equations[i].Equals("Log"))
                {
                    int rightValue = i + 1;
                    double result = Math.Log(double.Parse(equations[rightValue]));

                    equations[i] = result.ToString();
                    equations.RemoveAt(rightValue);
                }
            }

            //PowerOf Operation
            for (int i = 0; i < equations.Count; i++)
            {
                if (equations[i].Equals("^"))
                {
                    int leftValue = i - 1;
                    int rightValue = i + 1;
                    double result = Math.Pow(double.Parse(equations[leftValue]), double.Parse(equations[rightValue]));

                    equations[i] = result.ToString();
                    equations.RemoveAt(rightValue);
                    equations.RemoveAt(leftValue);
                    i--;
                }
            }

            //Square Root Operation
            for (int i = 0; i < equations.Count; i++)
            {
                if (equations[i].Equals("√"))
                {
                    int rightValue = i + 1;
                    double result = Math.Sqrt(double.Parse(equations[rightValue]));

                    equations[i] = result.ToString();
                    equations.RemoveAt(rightValue);
                }
            }

            //Multiplication Operation
            for (int i = 0; i < equations.Count; i++)
            {
                if (equations[i].Equals("*"))
                {
                    int leftValue = i - 1;
                    int rightValue = i + 1;
                    double result = double.Parse(equations[leftValue]) * double.Parse(equations[rightValue]);

                    equations[i] = result.ToString();
                    equations.RemoveAt(rightValue);
                    equations.RemoveAt(leftValue);
                    i--;
                }
            }

            //Division Operation
            for (int i = 0; i < equations.Count; i++)
            {
                if (equations[i].Equals("/"))
                {
                    int leftValue = i - 1;
                    int rightValue = i + 1;
                    double result = double.Parse(equations[leftValue]) / double.Parse(equations[rightValue]);

                    equations[i] = result.ToString();
                    equations.RemoveAt(rightValue);
                    equations.RemoveAt(leftValue);
                    i--;
                }
            }

            //Mod Operation
            for (int i = 0; i < equations.Count; i++)
            {
                if (equations[i].Equals("%"))
                {
                    int leftValue = i - 1;
                    int rightValue = i + 1;
                    double result = double.Parse(equations[leftValue]) - (int)(double.Parse(equations[leftValue]) / double.Parse(equations[rightValue])) * double.Parse(equations[rightValue]);
                    
                    equations[i] = result.ToString();
                    equations.RemoveAt(rightValue);
                    equations.RemoveAt(leftValue);
                    i--;
                }
            }

            //Subtraction Operation
            for (int i = 0; i < equations.Count; i++)
            {
                if (equations[i].Equals("-"))
                {
                    int leftValue = i - 1;
                    int rightValue = i + 1;
                    double result = double.Parse(equations[leftValue]) - double.Parse(equations[rightValue]);

                    equations[i] = result.ToString();
                    equations.RemoveAt(rightValue);
                    equations.RemoveAt(leftValue);
                    i--;
                }
            }

            //Addition Operation
            for (int i = 0; i < equations.Count; i++)
            {
                if (equations[i].Equals("+"))
                {
                    int leftValue = i - 1;
                    int rightValue = i + 1;
                    double result = double.Parse(equations[leftValue]) + double.Parse(equations[rightValue]);

                    equations[i] = result.ToString();
                    equations.RemoveAt(rightValue);
                    equations.RemoveAt(leftValue);
                    i--;
                }
            }

           
            return equations[0];
        }

        private void btnMS_Click(object sender, EventArgs e)
        {
            List<string> equations = txtDisplay.Text.Split(' ').ToList();
            memory = calculate(equations);
        }

        private void btnMR_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
                txtDisplay.Clear();

            txtDisplay.Text += memory.ToString();

            if (txtDisplay.Text == "")
                txtDisplay.Text = "0";
        }

        private void btnMC_Click(object sender, EventArgs e)
        {
            memory = "";
        }

        private void btnMplus_Click(object sender, EventArgs e)
        {
            List<string> equations = txtDisplay.Text.Split(' ').ToList();
            memory = (double.Parse(memory) + double.Parse(calculate(equations))).ToString();
        }

        private void btnMsubtract_Click(object sender, EventArgs e)
        {
            List<string> equations = txtDisplay.Text.Split(' ').ToList();
            memory = (double.Parse(memory) - double.Parse(calculate(equations))).ToString();
        }

        private void ans_Click(object sender, EventArgs e)
        {

            string connStr = "server=127.0.0.1;port=3306;user=root;password=Aa123456;database=calculator;";
            con = new MySqlConnection(connStr);
           
            try
            {
                
                con.Open();
                string history = "";
                string query = "SELECT CalculationString, Result FROM CalculationHistory ORDER BY ID DESC LIMIT 10";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        
                        while (reader.Read() )
                        {
                            string calculationString = reader.GetString("CalculationString");
                            string result = reader.GetString("Result");
                            history = history+calculationString + " = " + result + "\r\n";
                            
                        }
                    }
                }
                MessageBox.Show(history,"History");
                
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
     }
}

