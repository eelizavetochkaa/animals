﻿namespace animals
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            file = new ToolStripMenuItem();
            open = new ToolStripMenuItem();
            exit = new ToolStripMenuItem();
            справкаToolStripMenuItem = new ToolStripMenuItem();
            aboutprogram = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            image = new PictureBox();
            type = new Label();
            name = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)image).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { file, справкаToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(990, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // file
            // 
            file.DropDownItems.AddRange(new ToolStripItem[] { open, exit });
            file.Name = "file";
            file.Size = new Size(59, 24);
            file.Text = "Файл";
            // 
            // open
            // 
            open.Name = "open";
            open.Size = new Size(150, 26);
            open.Text = "Открыть";
            open.Click += open_Click;
            // 
            // exit
            // 
            exit.Name = "exit";
            exit.Size = new Size(150, 26);
            exit.Text = "Выход";
            exit.Click += exit_Click_1;
            // 
            // справкаToolStripMenuItem
            // 
            справкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutprogram });
            справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            справкаToolStripMenuItem.Size = new Size(81, 24);
            справкаToolStripMenuItem.Text = "Справка";
            // 
            // aboutprogram
            // 
            aboutprogram.Name = "aboutprogram";
            aboutprogram.Size = new Size(224, 26);
            aboutprogram.Text = "О программе";
            aboutprogram.Click += aboutprogram_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 31);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(437, 416);
            dataGridView1.TabIndex = 1;
            // 
            // image
            // 
            image.Location = new Point(617, 43);
            image.Name = "image";
            image.Size = new Size(174, 160);
            image.TabIndex = 2;
            image.TabStop = false;
            // 
            // type
            // 
            type.AutoSize = true;
            type.Location = new Point(529, 261);
            type.Name = "type";
            type.Size = new Size(35, 20);
            type.TabIndex = 3;
            type.Text = "Тип";
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(536, 315);
            name.Name = "name";
            name.Size = new Size(58, 20);
            name.TabIndex = 4;
            name.Text = "Кличка";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(990, 453);
            Controls.Add(name);
            Controls.Add(type);
            Controls.Add(image);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Приют для животных";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)image).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem file;
        private ToolStripMenuItem open;
        private ToolStripMenuItem exit;
        private ToolStripMenuItem справкаToolStripMenuItem;
        private ToolStripMenuItem aboutprogram;
        private DataGridView dataGridView1;
        private PictureBox image;
        private Label type;
        private Label name;
    }
}
