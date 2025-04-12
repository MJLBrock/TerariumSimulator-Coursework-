using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

//TO DO
//add drawGrid method
//add substrate
//add ants
//add insect food for testing
//use substrate and ants to test and understand how this will work
//work out the rest from there

namespace TerariumSimulator_Coursework_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //grid size and colour assignments can be changed here for easy testing and debugging
        const int numOfTiles = 400;
        Color Beecolour = Color.LightYellow, Antcolour = Color.Black, Beetlecolour = Color.DarkGray, Snailcolour = Color.SandyBrown;
        Color Substratecolour = Color.Brown, Watercolour = Color.Blue, Aircolour = Color.LightSkyBlue, Hivecolour = Color.DarkGoldenrod;
        Color Honeycolour = Color.Gold, Stemcolour = Color.Green, Flowercolour = Color.Magenta, BeeEggcolour = Color.FloralWhite;
        Color BeetleEggcolour = Color.FloralWhite, AntEggcolour = Color.FloralWhite, Foodcolour = Color.Khaki, Glasscolour = Color.LightSteelBlue;
        Color textColour = Color.Black; 

        //number of columns and rows
        int numColsRows;

        //the 2d array in which tiles will be stored before they're displayed
        string[,] theGrid = new string[(Convert.ToInt32(Math.Sqrt(numOfTiles))), (Convert.ToInt32(Math.Sqrt(numOfTiles)))];


        List<Label> labelList = new List<Label>(numOfTiles);
        Random rand = new Random();
        public string tileHeld;
        public Color tileHeldColour;

        private void DrawGrid() //change GUI to match theGrid
        {
            flowLayoutPanel1.Controls.Clear();
            numColsRows = (int)Math.Sqrt(numOfTiles);
            for (int row = 0; row < numColsRows; row++)
            {
                for (int col = 0; col < numColsRows; col++)
                {
                    Label lblTile = new Label();
                    lblTile.Size = new Size(25, 25);
                    lblTile.AutoSize = false;
                    lblTile.Name = row + "," + col;
                    lblTile.Margin = new Padding(2);
                    lblTile.Font = new Font("Arial", 5);
                    lblTile.Text = theGrid[row, col];
                    lblTile.ForeColor = textColour;
                    lblTile.Click += LblTile_Click;
                    lblTile.BackColor = GetColour(ref col, ref row);
                    flowLayoutPanel1.Controls.Add(lblTile);
                    labelList.Add(lblTile);
                }
            }
            //Error: if the display is redrawn during runtime, colours stop updating in real time
        }

        //determine colour of tile being drawn
        private Color GetColour(ref int row, ref int col)
        {
            if (theGrid[col, row] == "Substrate")
            {
                return Substratecolour;
            }
            if (theGrid[col, row] == "Water")
            {
                return Watercolour;
            }
            if (theGrid[col, row] == "Air")
            {
                return Aircolour;
            }
            if (theGrid[col, row] == "Stem")
            {
                return Stemcolour;
            }
            if (theGrid[col, row] == "Flower")
            {
                return Flowercolour;
            }
            if (theGrid[col, row] == "Hive")
            {
                return Hivecolour;
            }
            if (theGrid[col, row] == "Honey")
            {
                return Honeycolour;
            }
            if (theGrid[col, row] == "Glass")
            {
                return Glasscolour;
            }
            if (theGrid[col, row] == "Bee")
            {
                return Beecolour;
            }
            if (theGrid[col, row] == "Ant")
            {
                return Antcolour;
            }
            if (theGrid[col, row] == "Beetle")
            {
                return Beetlecolour;
            }
            if (theGrid[col, row] == "Snail")
            {
                return Snailcolour;
            }
            if (theGrid[col, row] == "Bee Egg")
            {
                return BeeEggcolour;
            }
            if (theGrid[col, row] == "Ant Egg")
            {
                return AntEggcolour;
            }
            if (theGrid[col, row] == "Beetle Egg")
            {
                return BeetleEggcolour;
            }
            if (theGrid[col, row] == "Food")
            {
                return Foodcolour;
            }
            else
            {
                return Aircolour;
            }
        }

        //determine held tile type
        private void rbSubstrate_CheckedChanged(object sender, EventArgs e)
        {
            tileHeld = "Substrate";
        }
        private void rbWater_CheckedChanged(object sender, EventArgs e)
        {
            tileHeld = "Water";
        }
        private void rbAir_CheckedChanged(object sender, EventArgs e)
        {
            tileHeld = "Air";
        }
        private void rbStem_CheckedChanged(object sender, EventArgs e)
        {
            tileHeld = "Stem";
        }
        private void rbHive_CheckedChanged(object sender, EventArgs e)
        {
            tileHeld = "Hive";
        }
        private void rbGlass_CheckedChanged(object sender, EventArgs e)
        {
            tileHeld = "Glass";
        }
        private void rbHoney_CheckedChanged(object sender, EventArgs e)
        {
            tileHeld = "Honey";
        }
        private void rbBee_CheckedChanged(object sender, EventArgs e)
        {
            tileHeld = "Bee";
        }
        private void rbAnt_CheckedChanged(object sender, EventArgs e)
        {
            tileHeld = "Ant";
        }
        private void rbBeetle_CheckedChanged(object sender, EventArgs e)
        {
            tileHeld = "Beetle";
        }
        private void rbSnail_CheckedChanged(object sender, EventArgs e)
        {
            tileHeld = "Snail";
        }
        private void rbBeeEgg_CheckedChanged(object sender, EventArgs e)
        {
            tileHeld = "Bee Egg";
        }
        private void rbAntEgg_CheckedChanged(object sender, EventArgs e)
        {
            tileHeld = "Ant Egg";
        }
        private void rbBeetleEgg_CheckedChanged(object sender, EventArgs e)
        {
            tileHeld = "Beetle Egg";
        }
        private void rbFood_CheckedChanged(object sender, EventArgs e)
        {
            tileHeld = "Food";
        }
        private void rbFlower_CheckedChanged(object sender, EventArgs e)
        {
            tileHeld = "Flower";
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            NextStep();
        }

        private void NextStep() //check for tiles that can move and assign behaviour to them
        {
            numColsRows = (int)Math.Sqrt(numOfTiles);
            for (int row = 0; row < numColsRows; row++)
            {
                for (int col = 0; col < numColsRows; col++)
                {
                    string Contents = theGrid[row, col];
                    if (Contents == "Bee")
                    {
                        fly(scanArea(row, col), Contents, row, col);
                        
                    }
                }
            }
        }

        private void fly(int[,] vs, string contents, int row, int col) //execute movement for flying tiles
        {
            for (int i = 0; i < numColsRows; i++)
            {
                for (int j = 0; j < numColsRows; j++)
                {
                    if (vs[i,j] == 1)
                    {
                        
                    }
                }
            }
        }

        private int[,] scanArea(int row, int col) //find spaces that a tile can move into
        {
            int[,] viableSpaces = new int[numColsRows, numColsRows];

            for (int i = col - 1; i < col + 1; i++)
            {
                for (int j = row - 1; j < row + 1; j++)
                {
                    string Contents = theGrid[j, i];
                    if (Contents == "Air")
                    {
                        viableSpaces[j, i] = 1;
                    }
                    if (Contents == "Food")
                    {
                        viableSpaces[j, i] = 2;
                    }
                }
            }
            return viableSpaces;
        }




        private void btnPause_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Feature not implemented");
            //when the software runs without user inputs, this will set the tick speed to 0
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Clear Terrarium?", "Confirm reset", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                numColsRows = (int)Math.Sqrt(numOfTiles);
                for (int row = 0; row < numColsRows; row++)
                {
                    for (int col = 0; col < numColsRows - 5; col++)
                    {
                        theGrid[col, row] = "Air";
                    }
                }
                for (int row = 0; row < numColsRows; row++)
                {
                    for (int col = numColsRows - 5; col < numColsRows; col++)
                    {
                        theGrid[col, row] = "Substrate";
                    }
                }
                DrawGrid();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Feature not implemented");
        }

        private void cbRndSnails_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Feature not implemented");
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            DrawGrid();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadGame(ref theGrid);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            numColsRows = (int)Math.Sqrt(numOfTiles);
            for (int row = 0; row < numColsRows; row++)
            {
                for (int col = 0; col < numColsRows - 5; col++)
                {
                    theGrid[col, row] = "Air";
                }
            }
            for (int row = 0; row < numColsRows; row++)
            {
                for (int col = numColsRows - 5; col < numColsRows; col++)
                {
                    theGrid[col, row] = "Substrate";
                }
            }
            DrawGrid();
            tileHeld = "Substrate";
            //save files will probably use run length encoding
            //a clock will be used to keep things going: every tick, each tile's code will be executed and the grid will be redrawn
        }

        private int Getindex(int row, int col)
        {
            int Length = (int)Math.Sqrt(numOfTiles);
            return row * Length + col;
        }

        private void LblTile_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Label theTile = (Label)sender;
            string[] ColRow = theTile.Name.Split(',');
            int row = Convert.ToInt32(ColRow[0]), col = Convert.ToInt32(ColRow[1]);


            if (me.Button == System.Windows.Forms.MouseButtons.Left)
            {
                theGrid[row, col] = tileHeld.ToString();
                labelList[Getindex(row, col)].Text = theGrid[row, col];
                labelList[Getindex(row, col)].BackColor = GetColour(ref col, ref row);//this stops working after a reload
            }
            else if (me.Button == System.Windows.Forms.MouseButtons.Right)
            {
                MessageBox.Show(theGrid[row, col]);
            }

        }

        private static void LoadGame(ref string[,] Grid)
        {
            //string Line = "";
            //StreamReader GridFile = new StreamReader(ActiveSaveFile);
            //DrawGrid(GridFile);
            //GridFile.Close();
            MessageBox.Show("Feature not implemented");
        }
    }
}
