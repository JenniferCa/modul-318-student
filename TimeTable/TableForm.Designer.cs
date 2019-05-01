namespace TimeTable
{
    partial class TableForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableForm));
            this.lblTime = new System.Windows.Forms.Label();
            this.tpFromTime = new System.Windows.Forms.DateTimePicker();
            this.txtToStation = new System.Windows.Forms.TextBox();
            this.txtStation = new System.Windows.Forms.TextBox();
            this.lblConnections = new System.Windows.Forms.Label();
            this.btnMap = new System.Windows.Forms.Button();
            this.btnDepartureBoard = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.tpFromDate = new System.Windows.Forms.DateTimePicker();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvConnections = new System.Windows.Forms.ListView();
            this.cmbToStation = new System.Windows.Forms.ComboBox();
            this.cmbFromStation = new System.Windows.Forms.ComboBox();
            this.lblToPosition = new System.Windows.Forms.Label();
            this.lblFromPosition = new System.Windows.Forms.Label();
            this.btnSearchForConnections = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(43, 186);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(41, 20);
            this.lblTime.TabIndex = 54;
            this.lblTime.Text = "Zeit:";
            // 
            // tpFromTime
            // 
            this.tpFromTime.Checked = false;
            this.tpFromTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpFromTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.tpFromTime.Location = new System.Drawing.Point(116, 186);
            this.tpFromTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpFromTime.Name = "tpFromTime";
            this.tpFromTime.ShowUpDown = true;
            this.tpFromTime.Size = new System.Drawing.Size(137, 27);
            this.tpFromTime.TabIndex = 53;
            // 
            // txtToStation
            // 
            this.txtToStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtToStation.Location = new System.Drawing.Point(580, 52);
            this.txtToStation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtToStation.Name = "txtToStation";
            this.txtToStation.Size = new System.Drawing.Size(425, 27);
            this.txtToStation.TabIndex = 40;
            // 
            // txtStation
            // 
            this.txtStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtStation.Location = new System.Drawing.Point(45, 52);
            this.txtStation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStation.Name = "txtStation";
            this.txtStation.Size = new System.Drawing.Size(425, 27);
            this.txtStation.TabIndex = 39;
            // 
            // lblConnections
            // 
            this.lblConnections.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblConnections.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblConnections.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblConnections.Location = new System.Drawing.Point(47, 249);
            this.lblConnections.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConnections.Name = "lblConnections";
            this.lblConnections.Size = new System.Drawing.Size(958, 32);
            this.lblConnections.TabIndex = 52;
            this.lblConnections.Text = "Verbindungen:";
            this.lblConnections.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnMap
            // 
            this.btnMap.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMap.BackgroundImage")));
            this.btnMap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMap.Location = new System.Drawing.Point(280, 146);
            this.btnMap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMap.Name = "btnMap";
            this.btnMap.Size = new System.Drawing.Size(101, 65);
            this.btnMap.TabIndex = 43;
            this.btnMap.UseVisualStyleBackColor = false;
            // 
            // btnDepartureBoard
            // 
            this.btnDepartureBoard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDepartureBoard.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDepartureBoard.Location = new System.Drawing.Point(791, 159);
            this.btnDepartureBoard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDepartureBoard.Name = "btnDepartureBoard";
            this.btnDepartureBoard.Size = new System.Drawing.Size(213, 46);
            this.btnDepartureBoard.TabIndex = 42;
            this.btnDepartureBoard.Text = "Abfahr Tabelle";
            this.btnDepartureBoard.UseVisualStyleBackColor = true;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(42, 151);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(64, 20);
            this.lblDate.TabIndex = 50;
            this.lblDate.Text = "Datum:";
            // 
            // tpFromDate
            // 
            this.tpFromDate.Checked = false;
            this.tpFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tpFromDate.Location = new System.Drawing.Point(118, 146);
            this.tpFromDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpFromDate.Name = "tpFromDate";
            this.tpFromDate.Size = new System.Drawing.Size(135, 27);
            this.tpFromDate.TabIndex = 49;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Dauer";
            this.columnHeader5.Width = 92;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ankunft";
            this.columnHeader4.Width = 92;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Abfahrt";
            this.columnHeader2.Width = 102;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Nach";
            this.columnHeader3.Width = 200;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Von";
            this.columnHeader1.Width = 200;
            // 
            // lvConnections
            // 
            this.lvConnections.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader5});
            this.lvConnections.Location = new System.Drawing.Point(47, 284);
            this.lvConnections.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvConnections.Name = "lvConnections";
            this.lvConnections.Size = new System.Drawing.Size(959, 422);
            this.lvConnections.TabIndex = 51;
            this.lvConnections.TileSize = new System.Drawing.Size(168, 30);
            this.lvConnections.UseCompatibleStateImageBehavior = false;
            this.lvConnections.View = System.Windows.Forms.View.Details;
            // 
            // cmbToStation
            // 
            this.cmbToStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbToStation.FormattingEnabled = true;
            this.cmbToStation.Location = new System.Drawing.Point(580, 87);
            this.cmbToStation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbToStation.Name = "cmbToStation";
            this.cmbToStation.Size = new System.Drawing.Size(425, 28);
            this.cmbToStation.TabIndex = 48;
            // 
            // cmbFromStation
            // 
            this.cmbFromStation.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbFromStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFromStation.FormattingEnabled = true;
            this.cmbFromStation.Location = new System.Drawing.Point(45, 87);
            this.cmbFromStation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFromStation.Name = "cmbFromStation";
            this.cmbFromStation.Size = new System.Drawing.Size(425, 28);
            this.cmbFromStation.TabIndex = 47;
            // 
            // lblToPosition
            // 
            this.lblToPosition.AutoSize = true;
            this.lblToPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToPosition.Location = new System.Drawing.Point(576, 27);
            this.lblToPosition.Name = "lblToPosition";
            this.lblToPosition.Size = new System.Drawing.Size(58, 20);
            this.lblToPosition.TabIndex = 46;
            this.lblToPosition.Text = "Nach: ";
            // 
            // lblFromPosition
            // 
            this.lblFromPosition.AutoSize = true;
            this.lblFromPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromPosition.Location = new System.Drawing.Point(41, 27);
            this.lblFromPosition.Name = "lblFromPosition";
            this.lblFromPosition.Size = new System.Drawing.Size(43, 20);
            this.lblFromPosition.TabIndex = 45;
            this.lblFromPosition.Text = "Von:";
            // 
            // btnSearchForConnections
            // 
            this.btnSearchForConnections.BackColor = System.Drawing.Color.DimGray;
            this.btnSearchForConnections.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchForConnections.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSearchForConnections.Location = new System.Drawing.Point(580, 159);
            this.btnSearchForConnections.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchForConnections.Name = "btnSearchForConnections";
            this.btnSearchForConnections.Size = new System.Drawing.Size(197, 46);
            this.btnSearchForConnections.TabIndex = 41;
            this.btnSearchForConnections.Text = "Suchen";
            this.btnSearchForConnections.UseVisualStyleBackColor = false;
            // 
            // TableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1077, 814);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.tpFromTime);
            this.Controls.Add(this.txtToStation);
            this.Controls.Add(this.txtStation);
            this.Controls.Add(this.lblConnections);
            this.Controls.Add(this.btnMap);
            this.Controls.Add(this.btnDepartureBoard);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.tpFromDate);
            this.Controls.Add(this.lvConnections);
            this.Controls.Add(this.cmbToStation);
            this.Controls.Add(this.cmbFromStation);
            this.Controls.Add(this.lblToPosition);
            this.Controls.Add(this.lblFromPosition);
            this.Controls.Add(this.btnSearchForConnections);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TableForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.DateTimePicker tpFromTime;
        private System.Windows.Forms.TextBox txtToStation;
        private System.Windows.Forms.TextBox txtStation;
        private System.Windows.Forms.Label lblConnections;
        private System.Windows.Forms.Button btnMap;
        private System.Windows.Forms.Button btnDepartureBoard;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker tpFromDate;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView lvConnections;
        private System.Windows.Forms.ComboBox cmbToStation;
        private System.Windows.Forms.ComboBox cmbFromStation;
        private System.Windows.Forms.Label lblToPosition;
        private System.Windows.Forms.Label lblFromPosition;
        private System.Windows.Forms.Button btnSearchForConnections;
    }
}

