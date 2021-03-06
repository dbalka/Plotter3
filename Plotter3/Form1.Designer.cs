﻿namespace Plotter3
{
    partial class Form1
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
            this.ControlsBox = new System.Windows.Forms.GroupBox();
            this.RestartMButton = new System.Windows.Forms.Button();
            this.PlotsTable = new System.Windows.Forms.TableLayoutPanel();
            this.PlotBox1 = new PlotBox();
            this.internalAxis2 = new Plotter3.InternalAxis();
            this.internalAxis1 = new Plotter3.InternalAxis();
            this.PlotBox2 = new PlotBox();
            this.internalAxis3 = new Plotter3.InternalAxis();
            this.internalAxis4 = new Plotter3.InternalAxis();
            this.ControlsBox.SuspendLayout();
            this.PlotsTable.SuspendLayout();
            this.PlotBox1.SuspendLayout();
            this.PlotBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ControlsBox
            // 
            this.ControlsBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlsBox.AutoSize = true;
            this.ControlsBox.BackColor = System.Drawing.Color.PapayaWhip;
            this.ControlsBox.Controls.Add(this.RestartMButton);
            this.ControlsBox.Font = new System.Drawing.Font("Monospac821 BT", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ControlsBox.Location = new System.Drawing.Point(894, 12);
            this.ControlsBox.Name = "ControlsBox";
            this.ControlsBox.Size = new System.Drawing.Size(132, 801);
            this.ControlsBox.TabIndex = 0;
            this.ControlsBox.TabStop = false;
            this.ControlsBox.Text = "Controls";
            // 
            // RestartMButton
            // 
            this.RestartMButton.Location = new System.Drawing.Point(6, 28);
            this.RestartMButton.Name = "RestartMButton";
            this.RestartMButton.Size = new System.Drawing.Size(120, 55);
            this.RestartMButton.TabIndex = 0;
            this.RestartMButton.Text = "Restart Matrix";
            this.RestartMButton.UseVisualStyleBackColor = true;
            this.RestartMButton.Click += new System.EventHandler(this.RestartM_Click);
            // 
            // PlotsTable
            // 
            this.PlotsTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlotsTable.ColumnCount = 1;
            this.PlotsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PlotsTable.Controls.Add(this.PlotBox2, 0, 1);
            this.PlotsTable.Controls.Add(this.PlotBox1, 0, 0);
            this.PlotsTable.Location = new System.Drawing.Point(12, 12);
            this.PlotsTable.Name = "PlotsTable";
            this.PlotsTable.RowCount = 2;
            this.PlotsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.01748F));
            this.PlotsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 254F));
            this.PlotsTable.Size = new System.Drawing.Size(876, 801);
            this.PlotsTable.TabIndex = 2;
            // 
            // PlotBox1
            // 
            this.PlotBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlotBox1.BackColor = System.Drawing.Color.White;
            this.PlotBox1.Controls.Add(this.internalAxis2);
            this.PlotBox1.Controls.Add(this.internalAxis1);
            this.PlotBox1.Location = new System.Drawing.Point(3, 3);
            this.PlotBox1.Name = "PlotBox1";
            this.PlotBox1.NOVAPROPA = "sfgdfg";
            this.PlotBox1.Size = new System.Drawing.Size(870, 541);
            this.PlotBox1.TabIndex = 1;
            this.PlotBox1.TabStop = true;
            // 
            // internalAxis2
            // 
            this.internalAxis2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.internalAxis2.BackColor = System.Drawing.Color.White;
            this.internalAxis2.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.internalAxis2.Location = new System.Drawing.Point(0, 30);
            this.internalAxis2.Margin = new System.Windows.Forms.Padding(0);
            this.internalAxis2.Name = "internalAxis2";
            this.internalAxis2.Orientation = Plotter3.InternalAxis.OrientationType.Vertical;
            this.internalAxis2.Size = new System.Drawing.Size(66, 511);
            this.internalAxis2.TabIndex = 1;
            // 
            // internalAxis1
            // 
            this.internalAxis1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.internalAxis1.BackColor = System.Drawing.Color.White;
            this.internalAxis1.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.internalAxis1.Location = new System.Drawing.Point(0, 0);
            this.internalAxis1.Margin = new System.Windows.Forms.Padding(0);
            this.internalAxis1.Name = "internalAxis1";
            this.internalAxis1.Size = new System.Drawing.Size(870, 30);
            this.internalAxis1.TabIndex = 0;
            // 
            // PlotBox2
            // 
            this.PlotBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlotBox2.BackColor = System.Drawing.Color.White;
            this.PlotBox2.Controls.Add(this.internalAxis3);
            this.PlotBox2.Controls.Add(this.internalAxis4);
            this.PlotBox2.Location = new System.Drawing.Point(3, 550);
            this.PlotBox2.Name = "PlotBox2";
            this.PlotBox2.NOVAPROPA = "sfgdfg";
            this.PlotBox2.Size = new System.Drawing.Size(870, 248);
            this.PlotBox2.TabIndex = 2;
            this.PlotBox2.TabStop = true;
            // 
            // internalAxis3
            // 
            this.internalAxis3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.internalAxis3.BackColor = System.Drawing.Color.White;
            this.internalAxis3.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.internalAxis3.Location = new System.Drawing.Point(0, 30);
            this.internalAxis3.Margin = new System.Windows.Forms.Padding(0);
            this.internalAxis3.Name = "internalAxis3";
            this.internalAxis3.Orientation = Plotter3.InternalAxis.OrientationType.Vertical;
            this.internalAxis3.Size = new System.Drawing.Size(66, 218);
            this.internalAxis3.TabIndex = 1;
            // 
            // internalAxis4
            // 
            this.internalAxis4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.internalAxis4.BackColor = System.Drawing.Color.White;
            this.internalAxis4.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.internalAxis4.Location = new System.Drawing.Point(0, 0);
            this.internalAxis4.Margin = new System.Windows.Forms.Padding(0);
            this.internalAxis4.Name = "internalAxis4";
            this.internalAxis4.Size = new System.Drawing.Size(870, 30);
            this.internalAxis4.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 825);
            this.Controls.Add(this.PlotsTable);
            this.Controls.Add(this.ControlsBox);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Plotter3";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ControlsBox.ResumeLayout(false);
            this.PlotsTable.ResumeLayout(false);
            this.PlotBox1.ResumeLayout(false);
            this.PlotBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox ControlsBox;
        private System.Windows.Forms.Button RestartMButton;
        private PlotBox PlotBox1;
        private System.Windows.Forms.TableLayoutPanel PlotsTable;
        private InternalAxis internalAxis2;
        private InternalAxis internalAxis1;
        private PlotBox PlotBox2;
        private InternalAxis internalAxis3;
        private InternalAxis internalAxis4;
    }
}

