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

        const int numOfTiles = 400;
        //adding all tile colours here so they can be easily changed for debugging
        //grid size can also be changed for testing, as it is only stored in one place 
        Color Beecolour = Color.LightYellow, Antcolour = Color.Black, Beetlecolour = Color.DarkGray, Snailcolour = Color.SandyBrown;
        Color Substratecolour = Color.Brown, Watercolour = Color.Blue, Aircolour = Color.LightSkyBlue, Hivecolour = Color.LightYellow;
        Color Honeycolour = Color.Gold, Stemcolour = Color.Green, Flowercolour = Color.Magenta, BeeEggcolour = Color.FloralWhite;
        Color BeetleEggcolour = Color.FloralWhite, AntEggcolour = Color.FloralWhite, Foodcolour = Color.Khaki, Glasscolour = Color.Transparent;
        Color textColour = Color.Black;
        int numColsRows;
        string[,] theGrid = new string[(Convert.ToInt32(Math.Sqrt(numOfTiles))), (Convert.ToInt32(Math.Sqrt(numOfTiles)))];//the 2d array in which tiles will be stored before they're displayed
        //note to self: store each tile as a char converted to string, then deconstruct each array space into a char. this way many objects can inhabit one space
        public Form1()
        {
            InitializeComponent();
        }

        List<Label> labelList = new List<Label>(numOfTiles);

        public string tileHeld;
        public Color tileHeldColour;

        public class entity
        {
            bool extant;//whether or not the entity will be displayed as a tile
            int locationX;//where on the X axis the entity is
            int locationY;//where on the X axis the entity is
            bool solid;//whether or not other entities can inhabit the same tile (if solid = true, no other solid entity may share the same tile)
            bool needsAir;//whether or not the entity will be deleted if there are no empty tiles around it
            int tileID;
        } //https://www.w3schools.com/cs/cs_polymorphism.php for guidance on this

        public class creature : entity
        {

        }

        public class material : entity
        {

        }

        private void cbTileLables_CheckedChanged(object sender, EventArgs e)
        {

            if (cbTileLables.Checked == true)
            {
                foreach (Control allLabels in flowLayoutPanel1.Controls)
                {
                    if (allLabels is Label)
                    {
                        string[] ColRow = allLabels.Name.Split(',');
                        int row = Convert.ToInt32(ColRow[0]), col = Convert.ToInt32(ColRow[1]);
                        textColour = GetColour(ref col, ref row);
                    }
                }
            }
            else
            {
                foreach (Control allLabels in flowLayoutPanel1.Controls)
                {
                    if (allLabels is Label)
                    {
                        textColour = Color.Black;
                    }
                }
            }
            DrawGrid();

        }

        private void DrawGrid()
        {
            flowLayoutPanel1.Controls.Clear();
            numColsRows = (int)Math.Sqrt(numOfTiles);
            for (int row = 0; row < numColsRows; row++)
            {
                for (int col = 0; col < numColsRows; col++)
                {
                    Label lblTile = new Label();
                    //lblTile.BackColor = ;
                    lblTile.Size = new Size(25, 25);
                    lblTile.AutoSize = false;
                    lblTile.Name = row + "," + col;
                    lblTile.Margin = new Padding(2);
                    lblTile.Font = new Font("Arial", 5);
                    // theGrid[row, col] = "Air";
                    lblTile.Text = theGrid[row, col];
                    lblTile.ForeColor = textColour;
                    lblTile.Click += LblTile_Click;
                    flowLayoutPanel1.Controls.Add(lblTile);
                    labelList.Add(lblTile);
                    labelList[Getindex(row, col)].BackColor = GetColour(ref col, ref row);//DrawGrid won't display colours but LblTile.click will
                }
            }

        }

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
            if (theGrid[col, row] == "BeeEgg")
            {
                return BeeEggcolour;
            }
            if (theGrid[col, row] == "AntEgg")
            {
                return AntEggcolour;
            }
            if (theGrid[col, row] == "BeetleEgg")
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

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadGame(ref theGrid);
        }

        public class bee : creature
        {

        }

        public class ant : creature
        {
            //id 2
        }

        public class beetle : creature
        {

        }

        public class substrate : material
        {
            //id 1
        }

        public class air : material
        {
            //id 0
            //bool extant;//whether or not the entity will be displayed as a tile
            //int locationX;//where on the X axis the entity is
            //int locationY;//where on the X axis the entity is
            bool solid = true;//whether or not other entities can inhabit the same tile (if solid = true, no other solid entity may share the same tile)
            bool needsAir;//whether or not the entity will be deleted if there are no empty tiles around it
            int tileID;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numColsRows = (int)Math.Sqrt(numOfTiles);
            for (int row = 0; row < numColsRows; row++)
            {
                for (int col = 0; col < numColsRows; col++)
                {
                    theGrid[col, row] = "Air";
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
                labelList[Getindex(row, col)].BackColor = GetColour(ref col, ref row);
            }
            else if (me.Button == System.Windows.Forms.MouseButtons.Right)
            {
                MessageBox.Show(theGrid[row, col]);
            }
            //DrawGrid();
        }

        private static void LoadGame(ref string[,] Grid)
        {
            //string Line = "";
            //StreamReader GridFile = new StreamReader(ActiveSaveFile);
            //DrawGrid(GridFile);
            //GridFile.Close();
        }

        private void UpdateDisplay(int row, int col, Color newColor)
        {
            foreach (Control ctrl in this.flowLayoutPanel1.Controls)
            {
                if (ctrl.Name == row + "," + col)
                {
                    ctrl.Text = theGrid[row, col];
                    break;
                }
            }
        }
    }
}
