using System.Windows.Forms;
namespace ConversionUtility
{
    partial class ConversionForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConversionForm));
            this.SourceValue = new System.Windows.Forms.TextBox();
            this.ConvertedValue = new System.Windows.Forms.TextBox();
            this.SourceLabel = new System.Windows.Forms.Label();
            this.ConvertedLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitGumpStudioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.classBreakdownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Quit = new System.Windows.Forms.Button();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // SourceValue
            // 
            this.SourceValue.Location = new System.Drawing.Point(114, 32);
            this.SourceValue.Name = "SourceValue";
            this.SourceValue.Size = new System.Drawing.Size(154, 20);
            this.SourceValue.TabIndex = 2;
            this.toolTip1.SetToolTip(this.SourceValue, "enter your value to be converted here!");
            this.SourceValue.TextChanged += new System.EventHandler(this.SourceValue_TextChanged);
            // 
            // ConvertedValue
            // 
            this.ConvertedValue.Location = new System.Drawing.Point(114, 65);
            this.ConvertedValue.Name = "ConvertedValue";
            this.ConvertedValue.ReadOnly = true;
            this.ConvertedValue.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.ConvertedValue.Size = new System.Drawing.Size(154, 20);
            this.ConvertedValue.TabIndex = 9;
            // 
            // SourceLabel
            // 
            this.SourceLabel.AutoSize = true;
            this.SourceLabel.BackColor = System.Drawing.SystemColors.Control;
            this.SourceLabel.Location = new System.Drawing.Point(9, 38);
            this.SourceLabel.Name = "SourceLabel";
            this.SourceLabel.Size = new System.Drawing.Size(71, 13);
            this.SourceLabel.TabIndex = 10;
            this.SourceLabel.Text = "Source Value";
            // 
            // ConvertedLabel
            // 
            this.ConvertedLabel.AutoSize = true;
            this.ConvertedLabel.Location = new System.Drawing.Point(9, 71);
            this.ConvertedLabel.Name = "ConvertedLabel";
            this.ConvertedLabel.Size = new System.Drawing.Size(86, 13);
            this.ConvertedLabel.TabIndex = 11;
            this.ConvertedLabel.Text = "Converted Value";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Khaki;
            this.comboBox1.ForeColor = System.Drawing.Color.Crimson;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Hexidecimal(0x3e2a)  to  Integer(15914)",
            "Integer(15914)  to  Hexidecimal(0x3e2a)"});
            this.comboBox1.Location = new System.Drawing.Point(8, 93);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(260, 21);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.Text = "Select your Conversion Type here.";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(278, 24);
            this.MainMenu.TabIndex = 13;
            this.MainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.exitGumpStudioToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit Converter";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // exitGumpStudioToolStripMenuItem
            // 
            this.exitGumpStudioToolStripMenuItem.Name = "exitGumpStudioToolStripMenuItem";
            this.exitGumpStudioToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitGumpStudioToolStripMenuItem.Text = "Exit GumpStudio";
            this.exitGumpStudioToolStripMenuItem.Click += new System.EventHandler(this.exitGumpStudioToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1,
            this.classBreakdownToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(155, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // classBreakdownToolStripMenuItem
            // 
            this.classBreakdownToolStripMenuItem.Name = "classBreakdownToolStripMenuItem";
            this.classBreakdownToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.classBreakdownToolStripMenuItem.Text = "Class Breakdown";
            this.classBreakdownToolStripMenuItem.Click += new System.EventHandler(this.classBreakdownToolStripMenuItem_Click);
            // 
            // Quit
            // 
            this.Quit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Quit.Location = new System.Drawing.Point(8, 120);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(46, 23);
            this.Quit.TabIndex = 14;
            this.Quit.Text = "Exit";
            this.Quit.UseVisualStyleBackColor = true;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // ConversionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.Quit;
            this.ClientSize = new System.Drawing.Size(278, 151);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.SourceLabel);
            this.Controls.Add(this.ConvertedLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ConvertedValue);
            this.Controls.Add(this.SourceValue);
            this.Controls.Add(this.MainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.MainMenu;
            this.Name = "ConversionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hex Conversion Utility";
            this.TopMost = true;
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SourceValue;
        private System.Windows.Forms.TextBox ConvertedValue;
        private System.Windows.Forms.Label SourceLabel;
        private System.Windows.Forms.Label ConvertedLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private ToolTip toolTip1;
        private MenuStrip MainMenu;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem1;
        private ToolStripMenuItem classBreakdownToolStripMenuItem;
        private Button Quit;
        private ToolStripMenuItem exitGumpStudioToolStripMenuItem;
    }
}