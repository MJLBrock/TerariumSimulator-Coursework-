using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

//TO DO
//add substrate
//add ants
//add insect food for testing
//use substrate and ants to test and understand how this will work
//add drawGrid method
//work out the rest from there

namespace TerariumSimulator_Coursework_
{
    public partial class Form1 : Form
    {
        //Dictionary<string, Color> page = new Dictionary<int, string>();
        //page.Add("Beecolour", LightYellow);

        const int numOfTiles = 400;
        //adding all tile colours here so they can be easily changed for debugging
        //grid size can also be changed for testing, as it is only stored in one place 
        Color Beecolour = Color.LightYellow, Antcolour = Color.Black, Beetlecolour = Color.DarkGray, Snailcolour = Color.SandyBrown;
        Color Substratecolour = Color.Brown, Watercolour = Color.Blue, Aircolour = Color.LightSkyBlue, Hivecolour = Color.LightYellow;
        Color Honeycolour = Color.Gold, Stemcolour = Color.Green, Flowercolour = Color.Magenta, BeeEggcolour = Color.FloralWhite;
        Color BeetleEggcolour = Color.FloralWhite, AntEggcolour = Color.FloralWhite, Foodcolour = Color.Khaki;
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
                        textColour = Color.Transparent;
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
            //add draw grid method here when it is complete, as tile labels will probably only change when the grid is reloaded

        }

        private void drawGrid() //I apologise to future Maddie, as I have left this a buggy mess. I was working on the load function, but that required the drawGrid to be completed
            //so now I'm trying to establish a dictionary so I could reference colours in a way c# didn't like
        {
            flowLayoutPanel1.Controls.Clear();
            numColsRows = (int)Math.Sqrt(numOfTiles);
            for (int row = 0; row < numColsRows; row++)
            {
                for (int col = 0; col < numColsRows; col++)
                {
                    Label lblTile = new Label();
                    string colourName = theGrid[row, col] + "colour";
                    lblTile.BackColor = colourName;
                    lblTile.Size = new Size(25, 25);
                    lblTile.AutoSize = false;
                    lblTile.Name = row + "," + col;
                    lblTile.Margin = new Padding(2);
                    lblTile.Font = new Font("Arial", 5);
                    theGrid[row, col] = "Air";
                    lblTile.Text = theGrid[row, col];
                    lblTile.ForeColor = textColour;
                    lblTile.Click += LblTile_Click;
                    flowLayoutPanel1.Controls.Add(lblTile);
                    labelList.Add(lblTile);
                    labelList[Getindex(row, col)].BackColor = Aircolour;
                }
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
                    Label lblTile = new Label();
                    lblTile.BackColor = aircolour;
                    lblTile.Size = new Size(25, 25);
                    lblTile.AutoSize = false;
                    lblTile.Name = row + "," + col;
                    lblTile.Margin = new Padding(2);
                    lblTile.Font = new Font("Arial", 5);
                    theGrid[row, col] = "Air";
                    lblTile.Text = theGrid[row, col];
                    lblTile.ForeColor = textColour;
                    lblTile.Click += LblTile_Click;
                    flowLayoutPanel1.Controls.Add(lblTile);
                    labelList.Add(lblTile);
                    labelList[Getindex(row, col)].BackColor = aircolour;
                }
            }
            tileHeld = "Substrate";
            //this will be replaced with a drawGrid method attached to a save file
            //by default the save file will be a blank grid with only air tiles
            //save files will probably use run length encoding

            //a clock will be used to keep things going: every tick, each tile's code will be executed and the grid will be redrawn
        }



        private int Getindex(int row, int col)
        {
            return row * (int)Math.Sqrt(numOfTiles) + col;
        }

        private void LblTile_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Label theTile = (Label)sender;
            string[] ColRow = theTile.Name.Split(',');
            int col = Convert.ToInt32(ColRow[0]), row = Convert.ToInt32(ColRow[1]);


            if (me.Button == System.Windows.Forms.MouseButtons.Left)
            {
                theGrid[row, col] = tileHeld.ToString();
            }
            else if (me.Button == System.Windows.Forms.MouseButtons.Right)
            {
                MessageBox.Show(theGrid[row, col]);
            }


        }

        private static void LoadGame(ref string[,] Grid)
        {
            string Line = "";
            StreamReader GridFile = new StreamReader(ActiveSaveFile);
            DrawGrid(GridFile);
            GridFile.Close();
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
