﻿using Point = System.Drawing.Point;
using Size = System.Drawing.Size;
using SizeF = System.Drawing.SizeF;

namespace BakeTool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            btnSelectAO = new Button();
            labelSelectedAO = new Label();
            openFileDialog1 = new OpenFileDialog();
            labelSelectedDirt = new Label();
            btnSelectDirt = new Button();
            labelSelectedWear = new Label();
            btnSelectWear = new Button();
            saveFileDialog1 = new SaveFileDialog();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 117);
            button1.Name = "button1";
            button1.Size = new Size(206, 29);
            button1.TabIndex = 0;
            button1.Text = "Combine and save as";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnSelectAO
            // 
            btnSelectAO.Location = new Point(12, 12);
            btnSelectAO.Name = "btnSelectAO";
            btnSelectAO.Size = new Size(206, 29);
            btnSelectAO.TabIndex = 1;
            btnSelectAO.Text = "Select AO (green)";
            btnSelectAO.UseVisualStyleBackColor = true;
            btnSelectAO.Click += btnSelectAO_Click;
            // 
            // labelSelectedAO
            // 
            labelSelectedAO.AutoSize = true;
            labelSelectedAO.Location = new Point(224, 16);
            labelSelectedAO.Name = "labelSelectedAO";
            labelSelectedAO.Size = new Size(42, 20);
            labelSelectedAO.TabIndex = 2;
            labelSelectedAO.Text = "none";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // labelSelectedDirt
            // 
            labelSelectedDirt.AutoSize = true;
            labelSelectedDirt.Location = new Point(224, 51);
            labelSelectedDirt.Name = "labelSelectedDirt";
            labelSelectedDirt.Size = new Size(42, 20);
            labelSelectedDirt.TabIndex = 4;
            labelSelectedDirt.Text = "none";
            // 
            // btnSelectDirt
            // 
            btnSelectDirt.Location = new Point(12, 47);
            btnSelectDirt.Name = "btnSelectDirt";
            btnSelectDirt.Size = new Size(206, 29);
            btnSelectDirt.TabIndex = 3;
            btnSelectDirt.Text = "Select Dirt/Metal (blue)";
            btnSelectDirt.UseVisualStyleBackColor = true;
            btnSelectDirt.Click += btnSelectDirt_Click;
            // 
            // labelSelectedWear
            // 
            labelSelectedWear.AutoSize = true;
            labelSelectedWear.Location = new Point(224, 86);
            labelSelectedWear.Name = "labelSelectedWear";
            labelSelectedWear.Size = new Size(42, 20);
            labelSelectedWear.TabIndex = 6;
            labelSelectedWear.Text = "none";
            // 
            // btnSelectWear
            // 
            btnSelectWear.Location = new Point(12, 82);
            btnSelectWear.Name = "btnSelectWear";
            btnSelectWear.Size = new Size(206, 29);
            btnSelectWear.TabIndex = 5;
            btnSelectWear.Text = "Select Wear / Smooth (red)";
            btnSelectWear.UseVisualStyleBackColor = true;
            btnSelectWear.Click += btnSelectWear_Click;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.DefaultExt = "png";
            saveFileDialog1.FileName = "specular";
            saveFileDialog1.Filter = "png|*.png";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 164);
            Controls.Add(labelSelectedWear);
            Controls.Add(btnSelectWear);
            Controls.Add(labelSelectedDirt);
            Controls.Add(btnSelectDirt);
            Controls.Add(labelSelectedAO);
            Controls.Add(btnSelectAO);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimizeBox = false;
            Name = "Form1";
            Text = "Bake Tool by Achimobil";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button btnSelectAO;
        private Label labelSelectedAO;
        private OpenFileDialog openFileDialog1;
        private Label labelSelectedDirt;
        private Button btnSelectDirt;
        private Label labelSelectedWear;
        private Button btnSelectWear;
        private SaveFileDialog saveFileDialog1;
    }
}