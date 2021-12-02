
namespace YZotogloQGame
{
    partial class DesignerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlRowCol = new System.Windows.Forms.Panel();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblColumns = new System.Windows.Forms.Label();
            this.txtColumn = new System.Windows.Forms.TextBox();
            this.txtRow = new System.Windows.Forms.TextBox();
            this.lblRow = new System.Windows.Forms.Label();
            this.pnlToolBox = new System.Windows.Forms.Panel();
            this.btnGreenBox = new System.Windows.Forms.Button();
            this.btnRedBox = new System.Windows.Forms.Button();
            this.btnGreenDoor = new System.Windows.Forms.Button();
            this.btnRedDoor = new System.Windows.Forms.Button();
            this.btnWall = new System.Windows.Forms.Button();
            this.btnNone = new System.Windows.Forms.Button();
            this.lblToolBox = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlRowCol.SuspendLayout();
            this.pnlToolBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRowCol
            // 
            this.pnlRowCol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRowCol.Controls.Add(this.btnGenerate);
            this.pnlRowCol.Controls.Add(this.lblColumns);
            this.pnlRowCol.Controls.Add(this.txtColumn);
            this.pnlRowCol.Controls.Add(this.txtRow);
            this.pnlRowCol.Controls.Add(this.lblRow);
            this.pnlRowCol.Location = new System.Drawing.Point(12, 32);
            this.pnlRowCol.Name = "pnlRowCol";
            this.pnlRowCol.Size = new System.Drawing.Size(786, 46);
            this.pnlRowCol.TabIndex = 0;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(430, 12);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(120, 23);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblColumns
            // 
            this.lblColumns.AutoSize = true;
            this.lblColumns.Location = new System.Drawing.Point(215, 17);
            this.lblColumns.Name = "lblColumns";
            this.lblColumns.Size = new System.Drawing.Size(50, 13);
            this.lblColumns.TabIndex = 3;
            this.lblColumns.Text = "Columns:";
            // 
            // txtColumn
            // 
            this.txtColumn.Location = new System.Drawing.Point(271, 14);
            this.txtColumn.Name = "txtColumn";
            this.txtColumn.Size = new System.Drawing.Size(119, 20);
            this.txtColumn.TabIndex = 2;
            // 
            // txtRow
            // 
            this.txtRow.Location = new System.Drawing.Point(57, 17);
            this.txtRow.Name = "txtRow";
            this.txtRow.Size = new System.Drawing.Size(119, 20);
            this.txtRow.TabIndex = 1;
            // 
            // lblRow
            // 
            this.lblRow.AutoSize = true;
            this.lblRow.Location = new System.Drawing.Point(14, 17);
            this.lblRow.Name = "lblRow";
            this.lblRow.Size = new System.Drawing.Size(37, 13);
            this.lblRow.TabIndex = 0;
            this.lblRow.Text = "Rows:";
            // 
            // pnlToolBox
            // 
            this.pnlToolBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlToolBox.Controls.Add(this.btnGreenBox);
            this.pnlToolBox.Controls.Add(this.btnRedBox);
            this.pnlToolBox.Controls.Add(this.btnGreenDoor);
            this.pnlToolBox.Controls.Add(this.btnRedDoor);
            this.pnlToolBox.Controls.Add(this.btnWall);
            this.pnlToolBox.Controls.Add(this.btnNone);
            this.pnlToolBox.Controls.Add(this.lblToolBox);
            this.pnlToolBox.Location = new System.Drawing.Point(12, 84);
            this.pnlToolBox.Name = "pnlToolBox";
            this.pnlToolBox.Size = new System.Drawing.Size(140, 332);
            this.pnlToolBox.TabIndex = 1;
            // 
            // btnGreenBox
            // 
            this.btnGreenBox.Location = new System.Drawing.Point(24, 261);
            this.btnGreenBox.Name = "btnGreenBox";
            this.btnGreenBox.Size = new System.Drawing.Size(98, 39);
            this.btnGreenBox.TabIndex = 6;
            this.btnGreenBox.Text = "Green Box";
            this.btnGreenBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGreenBox.UseVisualStyleBackColor = true;
            this.btnGreenBox.Click += new System.EventHandler(this.Tool_Click);
            // 
            // btnRedBox
            // 
            this.btnRedBox.Location = new System.Drawing.Point(24, 216);
            this.btnRedBox.Name = "btnRedBox";
            this.btnRedBox.Size = new System.Drawing.Size(98, 39);
            this.btnRedBox.TabIndex = 5;
            this.btnRedBox.Text = "Red Box";
            this.btnRedBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRedBox.UseVisualStyleBackColor = true;
            this.btnRedBox.Click += new System.EventHandler(this.Tool_Click);
            // 
            // btnGreenDoor
            // 
            this.btnGreenDoor.Location = new System.Drawing.Point(24, 174);
            this.btnGreenDoor.Name = "btnGreenDoor";
            this.btnGreenDoor.Size = new System.Drawing.Size(98, 36);
            this.btnGreenDoor.TabIndex = 4;
            this.btnGreenDoor.Text = "Green Door";
            this.btnGreenDoor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGreenDoor.UseVisualStyleBackColor = true;
            this.btnGreenDoor.Click += new System.EventHandler(this.Tool_Click);
            // 
            // btnRedDoor
            // 
            this.btnRedDoor.Location = new System.Drawing.Point(24, 130);
            this.btnRedDoor.Name = "btnRedDoor";
            this.btnRedDoor.Size = new System.Drawing.Size(98, 38);
            this.btnRedDoor.TabIndex = 3;
            this.btnRedDoor.Text = "Red Door";
            this.btnRedDoor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRedDoor.UseVisualStyleBackColor = true;
            this.btnRedDoor.Click += new System.EventHandler(this.Tool_Click);
            // 
            // btnWall
            // 
            this.btnWall.Location = new System.Drawing.Point(24, 87);
            this.btnWall.Name = "btnWall";
            this.btnWall.Size = new System.Drawing.Size(98, 37);
            this.btnWall.TabIndex = 2;
            this.btnWall.Text = "Wall";
            this.btnWall.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWall.UseVisualStyleBackColor = true;
            this.btnWall.Click += new System.EventHandler(this.Tool_Click);
            // 
            // btnNone
            // 
            this.btnNone.Location = new System.Drawing.Point(24, 41);
            this.btnNone.Name = "btnNone";
            this.btnNone.Size = new System.Drawing.Size(98, 40);
            this.btnNone.TabIndex = 1;
            this.btnNone.Text = "None";
            this.btnNone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNone.UseVisualStyleBackColor = true;
            this.btnNone.Click += new System.EventHandler(this.Tool_Click);
            // 
            // lblToolBox
            // 
            this.lblToolBox.AutoSize = true;
            this.lblToolBox.Location = new System.Drawing.Point(29, 13);
            this.lblToolBox.Name = "lblToolBox";
            this.lblToolBox.Size = new System.Drawing.Size(46, 13);
            this.lblToolBox.TabIndex = 0;
            this.lblToolBox.Text = "ToolBox";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(867, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // DesignerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 644);
            this.Controls.Add(this.pnlToolBox);
            this.Controls.Add(this.pnlRowCol);
            this.Controls.Add(this.menuStrip1);
            this.Name = "DesignerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DesignerForm";
            this.Load += new System.EventHandler(this.DesignerForm_Load);
            this.pnlRowCol.ResumeLayout(false);
            this.pnlRowCol.PerformLayout();
            this.pnlToolBox.ResumeLayout(false);
            this.pnlToolBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlRowCol;
        private System.Windows.Forms.Label lblColumns;
        private System.Windows.Forms.TextBox txtColumn;
        private System.Windows.Forms.TextBox txtRow;
        private System.Windows.Forms.Label lblRow;
        private System.Windows.Forms.Panel pnlToolBox;
        private System.Windows.Forms.Button btnGreenBox;
        private System.Windows.Forms.Button btnRedBox;
        private System.Windows.Forms.Button btnGreenDoor;
        private System.Windows.Forms.Button btnRedDoor;
        private System.Windows.Forms.Button btnWall;
        private System.Windows.Forms.Button btnNone;
        private System.Windows.Forms.Label lblToolBox;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}