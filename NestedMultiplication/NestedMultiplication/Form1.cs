using System;
using System.Collections.Generic;
using System.Windows.Forms;

using org.mariuszgromada.math.mxparser;


namespace NestedMultiplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate_nested_Click(object sender, EventArgs e)
        {
            var func = funcTextBox.Text;
            var arg = argTextBox.Text;
            int power;
            string[] nodesS;
            try
            {
                power = int.Parse(derivativeTextBox.Text);
            } catch 
            {
                power = 1;
                MessageBox.Show("Неверный формат степени производной.");
            }

            try
            {
                nodesS = nodesTextBox.Text.Split(',');

                Console.WriteLine(nodesS);
            }
            catch
            {
                nodesS = new string[] { "0" };
                MessageBox.Show("Неверный формат узлов.");
            }

           
            var nodesExp = new List<Expression>();
            foreach(var n in nodesS)
            {
                nodesExp.Add(new Expression(n));
            }



            //for (int i = 0; i < nodesExp.Count; i++)
            //    mXparser.consolePrintln("Res: " + nodesExp[i].getExpressionString() + " = " + nodesExp[i].calculate());
            //return;

            //0,pi/4,pi/2,3*pi/4,pi

            for (int k = 0; k < power; k++)
            {
                var newNodesExp = new List<Expression> { nodesExp[0] };
                for (int i = 1; i < nodesExp.Count; i++)
                {
                    var x0 = nodesExp[i - 1]; //0
                    var x1 = nodesExp[i];     //pi/4

                    var fx0 = new Expression(String.Format("{0}({1})", func, x0.getExpressionString()));
                    var fx1 = new Expression(String.Format("{0}({1})", func, x1.getExpressionString()));

                    mXparser.consolePrintln(fx0.getExpressionString());
                    mXparser.consolePrintln(fx1.getExpressionString());


                    newNodesExp.Add(new Expression(String.Format("({0} - {1}) / ({2} - {3})", fx1.getExpressionString(), fx0.getExpressionString(), x1.getExpressionString(), x0.getExpressionString())));
                }
                nodesExp = newNodesExp;
                for (int i = 0; i < nodesExp.Count; i++)
                    Console.WriteLine("Res: " + nodesExp[i].getExpressionString() + " = " + nodesExp[i].calculate());

            }

            //Expression exp = new Expression(String.Format("{0}({1})", func, arg));
            //var answer = "Res: " + exp.getExpressionString() + " = " + exp.calculate();



            //mXparser.consolePrintln(answer);
            //answerLabel.Text = answer;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void funcTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
