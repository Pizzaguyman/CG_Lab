using System.Numerics;

namespace CG_Lab_3D
{
    public partial class Form1 : Form
    {
        private double[,] worldCoords =
        {
            {-12, -3, 0, 1},       //1
            {-9.5, -2, 0, 1},      //2
            {-7.5, 2, 0, 1},       //3
            {-6.5, 2.5, 0, 1},     //4
            {-5.75, 3, 0, 1},      //5
            {-5, 3.5, 0, 1},
            {-4.5, 4.5, 0, 1},
            {-10, 4, 0, 1},
            {-10.5, 10.5, 0, 1},
            {-5, 7, 0, 1},         //10
            {-9, 8, 0, 1},
            {-3.5, 4, 0, 1},
            {-3, 6.5, 0, 1},
            {-2, 7, 0, 1},
            {-2, 6, 0, 1},
            {0.5, 7.5, 0, 1},
            {1.5, 8.5, 0, 1},
            {1, 6.5, 0, 1},
            {2.5, 7.5, 0, 1},
            {5, 7, 0, 1},          //20
            {6.5, 7.75, 0, 1},
            {11, 10.5, 0, 1},
            {7, 8, 0, 1},
            {6.25, 7, 0, 1},
            {7, 7, 0, 1},
            {6, 5, 0, 1},
            {5, 4.75, 0, 1},
            {3.5, 4, 0, 1},
            {4.75, 3.75, 0, 1},
            {6, 3, 0, 1},          //30
            {9.75, 8.5, 0, 1},
            {7, 2.25, 0, 1},
            {10.5, 5.5, 0, 1},
            {8, 1.5, 0, 1},
            {9.5, -2, 0, 1},
            {12, -3, 0, 1},
            {10, -5, 0, 1},
            {6, -8, 0, 1},
            {3, -9, 0, 1},
            {-3, -9, 0, 1},        //40
            {-6, -8, 0, 1},
            {-10, -5, 0, 1},
            {-7, -4, 0, 1},
            {-1, -4, 0, 1},
            {1, -4, 0, 1},
            {0, -5.25, 0, 1},
            {7, -4, 0, 1},
            {5, -2, 0, 1},
            {5.5, -1.25, 0, 1},
            {5, -0.5, 0, 1},       //50
            {4.5, -1.25, 0, 1},
            {-5, -2, 0, 1},
            {-4.5, -1.25, 0, 1},
            {-5, -0.5, 0, 1},
            {-5.5, -1.25, 0, 1},   //55
            {-12, -3, 3, 1},       //56
            {-9.5, -2, 3, 1},      //57
            {-7.5, 2, 3, 1},       //58
            {-6.5, 2.5, 3, 1},     //59
            {-5.75, 3, 3, 1},      //60
            {-5, 3.5, 3, 1},
            {-4.5, 4.5, 3, 1},
            {-10, 4, 3, 1},
            {-10.5, 10.5, 3, 1},
            {-5, 7, 3, 1},         //65
            {-9, 8, 3, 1},
            {-3.5, 4, 3, 1},
            {-3, 6.5, 3, 1},
            {-2, 7, 3, 1},
            {-2, 6, 3, 1},
            {0.5, 7.5, 3, 1},
            {1.5, 8.5, 3, 1},
            {1, 6.5, 3, 1},
            {2.5, 7.5, 3, 1},
            {5, 7, 3, 1},          //75
            {6.5, 7.75, 3, 1},
            {11, 10.5, 3, 1},
            {7, 8, 3, 1},
            {6.25, 7, 3, 1},
            {7, 7, 3, 1},
            {6, 5, 3, 1},
            {5, 4.75, 3, 1},
            {3.5, 4, 3, 1},
            {4.75, 3.75, 3, 1},
            {6, 3, 3, 1},          //85
            {9.75, 8.5, 3, 1},
            {7, 2.25, 3, 1},
            {10.5, 5.5, 3, 1},
            {8, 1.5, 3, 1},
            {9.5, -2, 3, 1},
            {12, -3, 3, 1},
            {10, -5, 3, 1},
            {6, -8, 3, 1},
            {3, -9, 3, 1},
            {-3, -9, 3, 1},        //95
            {-6, -8, 3, 1},
            {-10, -5, 3, 1},
            {-7, -4, 3, 1},
            {-1, -4, 3, 1},
            {1, -4, 3, 1},
            {0, -5.25, 3, 1},
            {7, -4, 3, 1},
            {5, -2, 3, 1},
            {5.5, -1.25, 3, 1},
            {5, -0.5, 3, 1},       //105
            {4.5, -1.25, 3, 1},
            {-5, -2, 3, 1},
            {-4.5, -1.25, 3, 1},
            {-5, -0.5, 3, 1},
            {-5.5, -1.25, 3, 1}    //110
        };
        private int[,] vectorMap =
        {
            {1,2},
            {2,3},
            {3,4},
            {4,5},
            {5,6},
            {6,7},
            {3,8},
            {8,9},
            {9,10},
            {10,7},
            {4,11},
            {11,5},
            {6,12},
            {7,13},
            {13,14},
            {14,15},
            {15,16},
            {16,17},
            {17,18},
            {18,19},
            {19,20},
            {20,21},
            {21,23},
            {22,23},
            {23,24},
            {24,25},
            {25,26},
            {26,27},
            {27,28},
            {27,29},
            {28,29},
            {29,30},
            {30,31},
            {31,32},
            {30,32},
            {22,33},
            {32,34},
            {33,34},
            {34,35},
            {35,36},
            {36,37},
            {37,38},
            {38,39},
            {39,40},
            {40,41},
            {41,42},
            {42,1},
            {1,43},
            {43,44},
            {44,45},
            {45,46},
            {44,46},
            {45,47},
            {47,36},
            {48,49},
            {49,50},
            {50,51},
            {51,48},
            {52,53},
            {53,54},
            {54,55},
            {55,52},
            {56,57},
            {57,58},
            {58,59},
            {59,60},
            {60,61},
            {61,62},
            {58,63},
            {63,64},
            {64,65},
            {65,62},
            {59,66},
            {66,60},
            {61,67},
            {62,68},
            {68,69},
            {69,70},
            {70,71},
            {71,72},
            {72,73},
            {73,74},
            {74,75},
            {75,76},
            {76,78},
            {77,78},
            {78,79},
            {79,80},
            {80,81},
            {81,82},
            {82,83},
            {82,84},
            {83,84},
            {84,85},
            {85,86},
            {86,87},
            {85,87},
            {77,88},
            {87,89},
            {88,89},
            {89,90},
            {90,91},
            {91,92},
            {92,93},
            {93,94},
            {94,95},
            {95,96},
            {96,97},
            {97,56},
            {56,98},
            {98,99},
            {99,100},
            {100,101},
            {99,101},
            {100,102},
            {102,91},
            {103,104},
            {104,105},
            {105,106},
            {106,103},
            {107,108},
            {108,109},
            {109,110},
            {110,107},
            {1, 56},
            {2, 57},
            {3, 58},
            {4, 59},
            {5, 60},
            {6, 61},
            {7, 62},
            {8, 63},
            {9, 64},
            {10, 65},
            {11, 66},
            {12, 67},
            {13, 68},
            {14, 69},
            {15, 70},
            {16, 71},
            {17, 72},
            {18, 73},
            {19, 74},
            {20, 75},
            {21, 76},
            {22, 77},
            {23, 78},
            {24, 79},
            {25, 80},
            {26, 81},
            {27, 82},
            {28, 83},
            {29, 84},
            {30, 85},
            {31, 86},
            {32, 87},
            {33, 88},
            {34, 89},
            {35, 90},
            {36, 91},
            {37, 92},
            {38, 93},
            {39, 94},
            {40, 95},
            {41, 96},
            {42, 97},
            {43, 98},
            {44, 99},
            {45, 100},
            {46, 101},
            {47, 102},
            {48, 103},
            {49, 104},
            {50, 105},
            {51, 106},
            {52, 107},
            {53, 108},
            {54, 109},
            {55, 110}
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
            compPixelCoords = new double[worldCoords.GetLength(0), worldCoords.GetLength(1)];
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double t = (double)numericUpDown1.Value;
            for (int i = 0; i < worldCoords.GetLength(0); i++)
            {
                for (int j = 0; j < worldCoords.GetLength(1) - 1; j++)
                {
                    compPixelCoords[i, j] = (int)(worldCoords[i, j] * 4 * t);
                }
                compPixelCoords[i, worldCoords.GetLength(1) - 1] = 1;
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
            int deltaX = (int)moveXVal.Value;
            int deltaY = (int)moveYVal.Value;
            int deltaZ = (int)moveZVal.Value;
            double[,] movingMatrix =
            {
                {1, 0, 0, 0},
                {0, 1, 0, 0},
                {0, 0, 1, 0},
                {deltaX, deltaY, deltaZ, 1}
            };
            compPixelCoords = MultiplyMatrixes(compPixelCoords, movingMatrix);
            drawingBoard.Invalidate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double turnAngleDegX = (double)turnXVal.Value;
            double turnAngleRadX = turnAngleDegX * Math.PI / 180;
            double turnAngleDegY = (double)turnYVal.Value;
            double turnAngleRadY = turnAngleDegY * Math.PI / 180;
            double turnAngleDegZ = (double)turnZVal.Value;
            double turnAngleRadZ = turnAngleDegZ * Math.PI / 180;
            double[,] turningMatrixX =
            {
                {1, 0, 0, 0},
                {0, Math.Cos(turnAngleRadX), Math.Sin(turnAngleRadX), 0},
                {0, -Math.Sin(turnAngleRadX), Math.Cos(turnAngleRadX), 0},
                {0, 0, 0, 1}
            };
            double[,] turningMatrixY =
            {
                {Math.Cos(turnAngleRadY), 0,  -Math.Sin(turnAngleRadY), 0},
                {0, 1, 0, 0},
                {Math.Sin(turnAngleRadY), 0, Math.Cos(turnAngleRadY), 0},
                {0, 0, 0, 1}
            };
            double[,] turningMatrixZ =
            {
                {Math.Cos(turnAngleRadZ), Math.Sin(turnAngleRadZ), 0, 0},
                {-Math.Sin(turnAngleRadZ), Math.Cos(turnAngleRadZ), 0, 0},
                {0, 0, 1, 0},
                {0, 0, 0, 1}
            };
            compPixelCoords = MultiplyMatrixes(MultiplyMatrixes(MultiplyMatrixes(compPixelCoords, turningMatrixY), turningMatrixX), turningMatrixZ);
            drawingBoard.Invalidate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double multX = (double)resizeXVal.Value;
            double multY = (double)resizeYVal.Value;
            double multZ = (double)resizeZVal.Value;
            double[,] scalingMatrix =
            {
                {multX, 0, 0, 0 },
                {0, multY, 0, 0 },
                {0, 0, multZ, 0},
                {0, 0, 0, 1}
            };
            compPixelCoords = MultiplyMatrixes(compPixelCoords, scalingMatrix);
            drawingBoard.Invalidate();
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            if (shouldSaveRatio) resizeYVal.Value = resizeXVal.Value;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            shouldSaveRatio = checkBox1.Checked;
            if (shouldSaveRatio) resizeYVal.Value = resizeXVal.Value;
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            if (shouldSaveRatio) resizeXVal.Value = resizeYVal.Value;
        }
    }
}
