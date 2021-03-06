﻿namespace TimeTable
{
    partial class StationTable
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
            this.btnClose = new System.Windows.Forms.Button();
            this.livStationtable = new System.Windows.Forms.ListView();
            this.colLine = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDeparture = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblStation = new System.Windows.Forms.Label();
            this.lblFromStation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(638, 351);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 39);
            this.btnClose.TabIndex = 38;
            this.btnClose.Text = "Schliessen";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // livStationtable
            // 
            this.livStationtable.AutoArrange = false;
            this.livStationtable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colLine,
            this.colDeparture,
            this.colTo});
            this.livStationtable.Location = new System.Drawing.Point(21, 68);
            this.livStationtable.Margin = new System.Windows.Forms.Padding(4);
            this.livStationtable.Name = "livStationtable";
            this.livStationtable.Size = new System.Drawing.Size(717, 275);
            this.livStationtable.TabIndex = 37;
            this.livStationtable.UseCompatibleStateImageBehavior = false;
            this.livStationtable.View = System.Windows.Forms.View.Details;
            // 
            // colLine
            // 
            this.colLine.Text = "Linie";
            this.colLine.Width = 83;
            // 
            // colDeparture
            // 
            this.colDeparture.Text = "Abfahrt Zeit";
            this.colDeparture.Width = 99;
            // 
            // colTo
            // 
            this.colTo.Text = "Bis Station";
            this.colTo.Width = 358;
            // 
            // lblStation
            // 
            this.lblStation.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblStation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStation.Location = new System.Drawing.Point(21, 26);
            this.lblStation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStation.Name = "lblStation";
            this.lblStation.Size = new System.Drawing.Size(133, 24);
            this.lblStation.TabIndex = 40;
            this.lblStation.Text = "Von Station:";
            this.lblStation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFromStation
            // 
            this.lblFromStation.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblFromStation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFromStation.Location = new System.Drawing.Point(163, 26);
            this.lblFromStation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFromStation.Name = "lblFromStation";
            this.lblFromStation.Size = new System.Drawing.Size(575, 25);
            this.lblFromStation.TabIndex = 39;
            this.lblFromStation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StationTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(780, 400);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.livStationtable);
            this.Controls.Add(this.lblStation);
            this.Controls.Add(this.lblFromStation);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StationTable";
            this.Text = "StationTable";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListView livStationtable;
        private System.Windows.Forms.ColumnHeader colLine;
        private System.Windows.Forms.ColumnHeader colDeparture;
        private System.Windows.Forms.ColumnHeader colTo;
        private System.Windows.Forms.Label lblStation;
        private System.Windows.Forms.Label lblFromStation;
    }
}