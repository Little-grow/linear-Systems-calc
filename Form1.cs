using System.Globalization;
using System.Runtime.Serialization;

namespace Solve_Linear_Systems
{
    public partial class Form1 : Form
    {
        GauusSystem GLS = new GauusSystem();
        int Max;

        public void ClearGrid()
        {
            int i;
            int j;

            try
            {
                for (i = 0; i <= Max; i++)
                {
                    for (j = 0; j <= Max; j++)
                    {
                        dataGridView1.Rows[i].Cells[j].Value = " ";
                    }
                    dataGridView1.Rows[i].Cells[7].Value = " ";
                }
            }
            catch
            {
            }

            dataGridView1.Rows.Clear();

        }
        public void ArrayToGrid(int Max)
        {
            int i;
            int j;

            for (i = 0; i <= Max; i++)
            {
                for (j = 0; j <= Max; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = GLS.GetXVal(i, j);
                }
                dataGridView1.Rows[i].Cells[7].Value = GLS.GetKVal(i);
            }
        }
        public void GridToArray(int Max)
        {
            int i;
            int j;

            try
            {
                for (i = 0; i <= Max; i++)
                {
                    for (j = 0; j <= Max; j++)
                    {
                        if (dataGridView1.Rows[i].Cells[j].Value != " ")
                        {
                            GLS.SetXVal(i, j, Convert.ToDouble(dataGridView1.Rows[i].Cells[j].Value));
                        }
                    }
                    if (dataGridView1.Rows[i].Cells[7].Value != " ")
                    {
                        GLS.SetKVal(i, Convert.ToDouble(dataGridView1.Rows[i].Cells[7].Value));
                    }
                }
            }
            catch
            {
            }
        }
        public void ResToList(int Max)
        {
            int i;

            listBox1.Items.Clear();
            for (i = 0; i <= Max; i++)
            {
                listBox1.Items.Add(Convert.ToString(GLS.GetRes(i)));
            }

        }
        public void DemoToGird()
        {
            if (dataGridView1.Rows.Count < 3)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows.Add();
                dataGridView1.Rows.Add();
            }
            dataGridView1.Rows[0].Cells[0].Value = 1;
            dataGridView1.Rows[1].Cells[0].Value = 2;
            dataGridView1.Rows[2].Cells[0].Value = 4;

            dataGridView1.Rows[0].Cells[1].Value = 1;
            dataGridView1.Rows[1].Cells[1].Value = -3;
            dataGridView1.Rows[2].Cells[1].Value = -5;

            dataGridView1.Rows[0].Cells[2].Value = 1;
            dataGridView1.Rows[1].Cells[2].Value = -1;
            dataGridView1.Rows[2].Cells[2].Value = -1;

            dataGridView1.Rows[0].Cells[7].Value = 3;
            dataGridView1.Rows[1].Cells[7].Value = 2;
            dataGridView1.Rows[2].Cells[7].Value = 1;

        }
        public int ChkMax()
        {
            int i;
            int j;

            j = 0;
            for (i = 0; i <= dataGridView1.Rows.Count - 1; i++)
            {
                if ((dataGridView1.Rows[i].Cells[0].Value != "") && (dataGridView1.Rows[i].Cells[0].Value != " "))
                {
                    j = j + 1;
                }
            }
            return (j - 2);
        }

        public Form1()
        {
            InitializeComponent();

            dataGridView1.Rows.Add();
            dataGridView1.Rows.Add();
            dataGridView1.Rows.Add();

            GLS.SetMax(2);
            GLS.ResetResults(2);
            GLS.SetDemo();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Max = ChkMax();
            GLS.SetMax(Max);
            GLS.ResetResults(Max);
            GridToArray(Max);
            GLS.CalcGls();
            ResToList(Max);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearGrid();
            listBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Max = 2;
            ClearGrid();
            GLS.ResetResults(2);
            dataGridView1.AutoResizeColumn(2);
            DemoToGird();
            GridToArray(2);
            GLS.SetMax(2);
            GLS.CalcGls();
            ResToList(2);
        }

        public class GauusSystem
        {
            double[,] factors = new double[,] { { 0, 0, 0, 0, 0, 0 },
                                    { 0, 0, 0, 0, 0, 0 },
                                    { 0, 0, 0, 0, 0, 0 },
                                    { 0, 0, 0, 0, 0, 0 },
                                    { 0, 0, 0, 0, 0, 0 },
                                    { 0, 0, 0, 0, 0, 0 } };
            double[] consts = new double[6] { 0, 0, 0, 0, 0, 0 };
            double[] results = new double[6] { 0, 0, 0, 0, 0, 0 };

            int rows;
            int cols;

            double result;


            public void SetDemo()
            {
                cols = 2; rows = 2;

                factors[0, 0] = 1;
                factors[1, 0] = 2;
                factors[2, 0] = 4;

                factors[0, 1] = 1;
                factors[1, 1] = -3;
                factors[2, 1] = -5;

                factors[0, 2] = 1;
                factors[1, 2] = -1;
                factors[2, 2] = -1;

                consts[0] = 3;
                consts[1] = 2;
                consts[2] = 1;

            }

            public void SetMax(int Max)
            {
                rows = Max;
                cols = Max;
            }

            public double GetXVal(int x, int y)
            {
                return (factors[x, y]);
            }

            public void SetXVal(int x, int y, double XVal)
            {
                factors[x, y] = XVal;
            }

            public double GetKVal(int y)
            {
                return (consts[y]);
            }

            public void SetKVal(int y, double KVal)
            {
                consts[y] = KVal;
            }


            public double GetRes(int y)
            {
                return (results[y]);
            }

            public void ResetResults(int Max)
            {
                int i;

                for (i = 0; i <= Max; i++)
                {
                    results[i] = 0;
                }
            }

            public void CGls(int s)
            {
                for (int r = s + 1; r <= rows; r++)
                {
                    if (factors[r, s] != 0)
                    {
                        double factorial = (-1 * factors[r, s]) / factors[s, s];
                        for (int id = 0; id <= cols; id++)
                        {
                            factors[r, id] = factors[r, id] + (factors[s, id] * factorial);
                        }
                        consts[r] = consts[r] + (consts[s] * factorial);
                    }
                }
            }

            public void Cfactors()
            {
                double sum;
                for (int r = rows; r >= 0; r--)
                {
                    sum = 0;
                    for (int id = 0; id <= cols; id++)
                    {
                        sum = sum + (results[id] * factors[r, id]);
                    }
                    results[r] = (consts[r] + sum * -1) / factors[r, r];
                    result = results[r];
                }
            }

            public void CalcGls()
            {
                for (int i = 0; i <= cols; i++)
                {
                    CGls(i);
                }
                Cfactors();
            }
        }

    }

    class GFG
    {
        static int M = 10;

        // Function to print the matrix
        static void PrintMatrix(float[,] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= n; j++)
                    Console.Write(a[i, j] + " ");
                Console.WriteLine();
            }
        }

        // function to reduce matrix to reduced
        // row echelon form.
        static int PerformOperation(float[,] a, int n)
        {
            int i, j, k = 0, c, flag = 0;

            // Performing elementary operations
            for (i = 0; i < n; i++)
            {
                if (a[i, i] == 0)
                {
                    c = 1;
                    while ((i + c) < n && a[i + c, i] == 0)
                        c++;
                    if ((i + c) == n)
                    {
                        flag = 1;
                        break;
                    }
                    for (j = i, k = 0; k <= n; k++)
                    {
                        float temp = a[j, k];
                        a[j, k] = a[j + c, k];
                        a[j + c, k] = temp;
                    }
                }

                for (j = 0; j < n; j++)
                {

                    // Excluding all i == j
                    if (i != j)
                    {

                        // Converting Matrix to reduced row
                        // echelon form(diagonal matrix)
                        float p = a[j, i] / a[i, i];

                        for (k = 0; k <= n; k++)
                            a[j, k] = a[j, k] - (a[i, k]) * p;
                    }
                }
            }
            return flag;
        }

        // Function to print the desired result
        // if unique solutions exists, otherwise
        // prints no solution or infinite solutions
        // depending upon the input given.
        static void PrintResult(float[,] a,
                                int n, int flag)
        {
            Console.Write("Result is : ");

            if (flag == 2)
                Console.WriteLine("Infinite Solutions Exists");
            else if (flag == 3)
                Console.WriteLine("No Solution Exists");

            // Printing the solution by dividing
            // constants by their respective
            // diagonal elements
            else
            {
                for (int i = 0; i < n; i++)
                    Console.Write(a[i, n] / a[i, i] + " ");
            }
        }

        // To check whether infinite solutions
        // exists or no solution exists
        static int CheckConsistency(float[,] a,
                                    int n, int flag)
        {
            int i, j;
            float sum;

            // flag == 2 for infinite solution
            // flag == 3 for No solution
            flag = 3;
            for (i = 0; i < n; i++)
            {
                sum = 0;
                for (j = 0; j < n; j++)
                    sum = sum + a[i, j];
                if (sum == a[i, j])
                    flag = 2;
            }
            return flag;
        }
    }

}