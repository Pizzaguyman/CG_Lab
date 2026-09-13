using System.Drawing.Drawing2D;
using System.Numerics;

namespace CG_Lab
{
    public partial class Form1 : Form
    {
        private double[,] worldCoords =
        {
            {-12, -3, 1},       //1
            {-9.5, -2, 1},      //2
            {-8, 1.5, 1},       //3
            {-7.5, 2, 1},       //4
            {-6.5, 2.5, 1},     //5
            {-5.75, 3, 1},
            {-5, 3.5, 1},
            {-4.5, 4.5, 1},
            {-10, 4, 1},
            {-10.5, 10.5, 1},   //10
            {-5, 7, 1},
            {-9, 8, 1},
            {-3.5, 4, 1},
            {-3, 6.5, 1},
            {-2, 7, 1},         //15
            {-2, 6, 1},
            {0.5, 7.5, 1},
            {1.5, 8.5, 1},
            {1, 6.5, 1},
            {2.5, 7.5, 1},      //20
            {5, 7, 1},
            {6.5, 7.75, 1},
            {11, 10.5, 1},
            {7, 8, 1},
            {6.25, 7, 1},       //25
            {7, 7, 1},
            {6, 5, 1},
            {5, 4.75, 1},
            {3.5, 4, 1},
            {3, 3, 1},          //30
            {4.75, 3.75, 1},
            {6, 3, 1},
            {9.75, 8.5, 1},
            {7, 2.25, 1},
            {10.5, 5.5, 1},     //35
            {8, 1.5, 1},
            {9.5, -2, 1},
            {12, -3, 1},
            {10, -5, 1},
            {6, -8, 1},         //40
            {3, -9, 1},
            {-3, -9, 1},
            {-6, -8, 1},
            {-10, -5, 1},
            {-7, -4, 1},        //45
            {-1, -4, 1},
            {1, -4, 1},
            {0, -5.25, 1},
            {7, -4, 1},
            {5, -2, 1},         //50
            {5.5, -1.25, 1},
            {5, -0.5, 1},
            {4.5, -1.25, 1},
            {-5, -2, 1},
            {-4.5, -1.25, 1},   //55
            {-5, -0.5, 1},
            {-5.5, -1.25, 1}    //57
        };
        private int[,] vectorMap =
        {
            {1,2},
            {2,3},
            {3,4},
            {4,5},
            {5,6},
            {6,7},
            {7,8},
            {4,9},
            {9,10},
            {10,11},
            {11,8},
            {5,12},
            {12,6},
            {7,13},
            {8,14},
            {14,15},
            {15,16},
            {16,17},
            {17,18},
            {18,19},
            {19,20},
            {20,21},
            {21,22},
            {22,24},
            {23,24},
            {24,25},
            {25,26},
            {26,27},
            {27,28},
            {28,29},
            {29,30},
            {30,31},
            {28,31},
            {31,32},
            {32,33},
            {33,34},
            {32,34},
            {23,35},
            {34,36},
            {35,36},
            {36,37},
            {37,38},
            {38,39},
            {39,40},
            {40,41},
            {41,42},
            {42,43},
            {43,44},
            {44,1},
            {1,45},
            {45,46},
            {46,47},
            {47,48},
            {46,48},
            {47,49},
            {49,38},
            {50,51},
            {51,52},
            {52,53},
            {53,50},
            {54,55},
            {55,56},
            {56,57},
            {57,54}
        };
        private double[,] compPixelCoords;
        private bool ShouldDraw
        {
            get;
            set
            {
                field = value;
                button2.Enabled = value;
                button3.Enabled = value;
                button4.Enabled = value;
            }
        }
        private bool shouldSaveRatio = false;
        public Form1()
        {
            InitializeComponent();
            ShouldDraw = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double t = (double)numericUpDown1.Value;
            compPixelCoords = new double[worldCoords.GetLength(0), worldCoords.GetLength(1)];
            for (int i = 0; i < worldCoords.GetLength(0); i++)
            {
                for (int j = 0; j < worldCoords.GetLength(1); j++)
                {
                    compPixelCoords[i, j] = (int)(worldCoords[i, j] * 4 * t);
                }
            }
            ShouldDraw = true;
            drawingBoard.Invalidate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (ShouldDraw)
            {
                Graphics g = e.Graphics;
                Pen pen = new Pen(Color.Black, 2);
                Point startingPoint = drawingBoard.Location + drawingBoard.Size / 2;
                for (int i = 0; i < vectorMap.GetLength(0); i++)
                {
                    int x1 = (int)(startingPoint.X + compPixelCoords[vectorMap[i, 0] - 1, 0]);
                    int y1 = (int)(startingPoint.Y - compPixelCoords[vectorMap[i, 0] - 1, 1]);
                    int x2 = (int)(startingPoint.X + compPixelCoords[vectorMap[i, 1] - 1, 0]);
                    int y2 = (int)(startingPoint.Y - compPixelCoords[vectorMap[i, 1] - 1, 1]);
                    g.DrawLine(pen, x1, y1, x2, y2);
                }
            }
        }

        private T[,] MultiplyMatrixes<T>(T[,] A, T[,] B) where T : INumber<T>
        {
            int rowsA = A.GetLength(0);
            int columnsA = A.GetLength(1);
            int rowsB = B.GetLength(0);
            int columnsB = B.GetLength(1);
            if (columnsA != rowsB)
            {
                MessageBox.Show("Матрицы не перемножаемы!");
                return new T[0, 0];
            }
            T temp;
            T[,] ans = new T[rowsA, columnsB];
            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < columnsB; j++)
                {
                    temp = T.Zero;
                    for (int k = 0; k < columnsA; k++)
                    {
                        temp += A[i, k] * B[k, j];
                    }
                    ans[i, j] = temp;
                }
            }
            return ans;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int deltaX = (int)numericUpDown2.Value;
            int deltaY = (int)numericUpDown3.Value;
            double[,] movingMatrix =
            {
                {1, 0, 0 },
                {0, 1, 0 },
                {deltaX, deltaY, 1}
            };
            compPixelCoords = MultiplyMatrixes(compPixelCoords, movingMatrix);
            drawingBoard.Invalidate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double turnAngleDeg = (double)numericUpDown4.Value;
            double turnAngleRad = turnAngleDeg * Math.PI / 180;
            double[,] turningMatrix =
            {
                {Math.Cos(turnAngleRad), Math.Sin(turnAngleRad), 0},
                {-Math.Sin(turnAngleRad), Math.Cos(turnAngleRad), 0},
                {0, 0, 1}
            };
            compPixelCoords = MultiplyMatrixes(compPixelCoords, turningMatrix);
            drawingBoard.Invalidate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int multX = (int)numericUpDown5.Value;
            int multY = (int)numericUpDown6.Value;
            double[,] scalingMatrix =
            {
                {multX, 0, 0 },
                {0, multY, 0 },
                {0, 0, 1}
            };
            compPixelCoords = MultiplyMatrixes(compPixelCoords, scalingMatrix);
            drawingBoard.Invalidate();
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            if (shouldSaveRatio) numericUpDown6.Value = numericUpDown5.Value;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            shouldSaveRatio = checkBox1.Checked;
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            if (shouldSaveRatio) numericUpDown6.Value = numericUpDown5.Value;
        }
    }
}
