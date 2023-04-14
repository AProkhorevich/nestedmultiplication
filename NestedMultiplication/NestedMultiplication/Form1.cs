using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

using org.mariuszgromada.math.mxparser;


namespace NestedMultiplication
{
    public partial class Form1 : Form
    {


        string arg;
        List<string> nodesS = new List<string>();
        List<double> a = new List<double>();
        public Form1()
        {
            InitializeComponent();
            License.iConfirmNonCommercialUse("kek");
        }


        private Expression calcA(int leftBound, int rightBound, string func, int k)
        {
            if (k == 0)
            {
                return new Expression(String.Format("{0}({1})", func, arg));
            }

            if (k == 1)
            {
                var x0 = nodesS[leftBound];
                var x1 = nodesS[rightBound];

                var fx0 = new Expression(String.Format("{0}({1})", func, x0));
                var fx1 = new Expression(String.Format("{0}({1})", func, x1));
                return new Expression(String.Format("({0} - {1}) / ({2} - {3})", fx1.getExpressionString(), fx0.getExpressionString(), nodesS[rightBound], nodesS[leftBound]));
            }
            return new Expression(String.Format("({0} - {1}) / ({2} - {3})",
                calcA(leftBound + 1, rightBound, func, k - 1).getExpressionString(),
                calcA(leftBound, rightBound - 1, func, k - 1).getExpressionString(),
                nodesS[rightBound], nodesS[leftBound]));
        }

        private void calculate_nested_Click(object sender, EventArgs e)
        {
            var func = funcTextBox.Text;
            arg = argTextBox.Text;
            int power;

            try
            {
                power = int.Parse(derivativeTextBox.Text);
            }
            catch
            {
                power = 1;
                MessageBox.Show("Неверный формат степени производной.");
            }

            try
            {
                nodesS = nodesTextBox.Text.Split(',').ToList();

                Console.WriteLine(nodesS);
            }
            catch
            {
                nodesS = new string[] { "0" }.ToList();
                MessageBox.Show("Неверный формат узлов.");
            }

            //0,pi/4,pi/2,3*pi/4,pi



            for (int k = 0; k < nodesS.Count; k++)
            {
                var exp = calcA(0, k, func, k);
                var a_i = "a_i: " + k + exp.getExpressionString() + " = " + exp.calculate();
                mXparser.consolePrintln(a_i);
                a.Add(exp.calculate());
            }

            for (int k = 0; k < power; k++)
            {
                for (int i = a.Count - 2; i >= 1; i--)
                {
                    var exp = new Expression(String.Format("({0}-{1})", arg, nodesS[i])).calculate();
                    //if (i == 0 && k == 0)
                    //{
                    //    a[i] = a[i] + exp;
                    //}
                    a[i] = a[i] + exp * a[i + 1];
                    mXparser.consolePrintln(a[i]);
                }
                    mXparser.consolePrintln(a[0]);

                nodesS.Insert(0, arg);
                nodesS.RemoveAt(nodesS.Count - 1);
            }

            for (int i = 0; i <= power; i++)
            {
                var answer = a[i];
                mXparser.consolePrintln(String.Format("derivative power of {0}: {1}", i, answer));
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
