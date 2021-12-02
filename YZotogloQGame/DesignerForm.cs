using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static YZotogloQGame.Enum;

namespace YZotogloQGame
{
    public partial class DesignerForm : Form
    {
        const int PIC_WIDTH =55;
        const int PIC_HEIGHT = 56;
        ImageList imageList = new ImageList();
        Tool activeTool = Tool.None;
        StringBuilder sb = new StringBuilder();
        int rows = 0;
        int columns = 0;

        int greenBCount = 0;
        int redBCount = 0;
        int redDCount = 0;
        int greenDCount = 0;
        int wallCount = 0;
        /// <summary>
        /// 
        /// </summary>
        public DesignerForm()
        {
            InitializeComponent();
            btnNone.Tag = Tool.None;
            btnGreenDoor.Tag = Tool.GreenDoor;
            btnGreenBox.Tag = Tool.GreenBox;
            btnRedBox.Tag = Tool.RedBox;
            btnRedDoor.Tag = Tool.RedDoor;
            btnWall.Tag = Tool.Wall;
            pnlToolBox.Enabled = true;

        }
        /// <summary>
        /// Loading the form and the imagesd in buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
         private void DesignerForm_Load(object sender, EventArgs e)
        {
            // Loading the images to the imageList
            imageList.Images.Add(YZotogloQGame.Properties.Resources.green_box);
            imageList.Images.Add(YZotogloQGame.Properties.Resources.green_door);
            imageList.Images.Add(YZotogloQGame.Properties.Resources.none);
            imageList.Images.Add(YZotogloQGame.Properties.Resources.red_box);
            imageList.Images.Add(YZotogloQGame.Properties.Resources.red_door);
            imageList.Images.Add(YZotogloQGame.Properties.Resources.wall);

            // Loading images in the button
            btnNone.ImageList = imageList;
            btnNone.ImageIndex = 2;
            btnNone.ImageAlign = ContentAlignment.MiddleLeft;


            btnWall.ImageList = imageList;
            btnWall.ImageIndex = 5;
            btnWall.ImageAlign = ContentAlignment.MiddleLeft;

            btnRedDoor.ImageList = imageList;
            btnRedDoor.ImageIndex = 4;
            btnRedDoor.ImageAlign = ContentAlignment.MiddleLeft;

            btnGreenDoor.ImageList = imageList;
            btnGreenDoor.ImageIndex = 1;
            btnGreenDoor.ImageAlign = ContentAlignment.MiddleLeft;


            btnRedBox.ImageList = imageList;
            btnRedBox.ImageIndex = 3;
            btnRedBox.ImageAlign = ContentAlignment.MiddleLeft;

            btnGreenBox.ImageList = imageList;
            btnGreenBox.ImageIndex = 0;
            btnGreenBox.ImageAlign = ContentAlignment.MiddleLeft;

        }
        /// <summary>
        /// Handling the click event for the buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tool_Click(object sender, EventArgs e)
        {

            Button button = sender as Button;
            activeTool = (Tool)button.Tag;
        }
        /// <summary>
        /// Generating the cells (PictureBoxes)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            pnlToolBox.Enabled = true;
            StringBuilder sbt = new StringBuilder();
            if(int.TryParse(txtRow.Text,out int row)&& int.TryParse(txtColumn.Text, out int col))
            {
                rows = row;
                columns = col;
                for(int i=0; i<row; i++)
                {
                    for(int j=0; j < col; j++)
                    {
                        PictureBox pb = new PictureBox();

                        pb.Name = $"pb{i}{j}";
                        pb.Size = new Size(PIC_WIDTH, PIC_HEIGHT);
                        pb.Location = new Point(327 + (i * PIC_WIDTH + 1), (j * PIC_HEIGHT + 1) + 120);
                        pb.BorderStyle = BorderStyle.FixedSingle;
                        pb.SizeMode = PictureBoxSizeMode.Zoom;
                        //pb.SizeMode = PictureBoxSizeMode.StretchImage;
                        pb.Click += new EventHandler(pic_Click);
                        Controls.Add(pb);
                    }
                }
            }
            else
            {
                sbt.Append("Please provide valid data for rows and columns(Both must be integers)");
                MessageBox.Show(sbt.ToString(), "QC Game", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        /// <summary>
        /// Handling the click event for the pictureboxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pic_Click(object sender, EventArgs e)
        {
            PictureBox picture = sender as PictureBox;
            if (activeTool == Tool.None)
            {

                picture.Image = null;
            }
            else
            {
                picture.Image = imageList.Images[(int)activeTool];
                picture.Tag = activeTool;
            }
        }
        /// <summary>
        /// Saving to text file the current game level
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Text files (*.txt)|*.txt";
            save.Title = "Save maze";
            DialogResult dr = DialogResult.OK;
            if (save.ShowDialog() == dr)
            {
                string fileName = save.FileName;
                using (StreamWriter sw = File.AppendText(fileName))
                {
                    sw.WriteLine(rows);
                    sw.WriteLine(columns);
                    foreach (PictureBox pb in this.Controls.OfType<PictureBox>())
                    {
                        string name = pb.Name;
                        string pos = name.Substring(2);
                        int pbRow = int.Parse(pos[0].ToString());
                        int pbCol = int.Parse(pos[1].ToString());
                        sw.WriteLine(pbRow);
                        sw.WriteLine(pbCol);
                        if (pb.Tag == null)
                        {
                            sw.WriteLine(6);
                        }
                        else
                        {
                            sw.WriteLine((int)pb.Tag);
                            CheckNumberOfTools((Tool)pb.Tag);
                        }

                    }

                }
                sb.AppendLine("File saved successfuly: ");
                sb.AppendLine($"Total number of Green Boxes: {greenBCount}");
                sb.AppendLine($"Total number of Green Doors: {greenDCount}");
                sb.AppendLine($"Total number of Red Boxes: {redBCount}");
                sb.AppendLine($"Total number of Red Doors: {redDCount}");
                sb.AppendLine($"Total number of Walls: {wallCount}");
                MessageBox.Show(sb.ToString(), "QC Game", MessageBoxButtons.OK, MessageBoxIcon.Information);

                greenBCount = 0;
                redBCount = 0;
                redDCount = 0;
                greenDCount = 0;
                wallCount = 0;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="material"></param>
        private void CheckNumberOfTools(Tool material)
        {

            switch (material)
            {
                case Tool.GreenBox:
                    greenBCount++;
                    break;
                case Tool.GreenDoor:
                    greenDCount++;
                    break;
                case Tool.RedBox:
                    redBCount++;
                    break;
                case Tool.RedDoor:
                    redDCount++;
                    break;
                case Tool.Wall:
                    wallCount++;
                    break;
                default:
                    break;
            }



        }
        /// <summary>
        /// click event for the close button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //StartForm startForm = new StartForm();
            //startForm.ShowDialog();
        }
    }
}
