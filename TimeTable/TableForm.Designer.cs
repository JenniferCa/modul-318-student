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
            this.tpTime = new System.Windows.Forms.DateTimePicker();
            this.txtToStation = new System.Windows.Forms.TextBox();
            this.txtFromStation = new System.Windows.Forms.TextBox();
            this.lblTable = new System.Windows.Forms.Label();
            this.btnMap = new System.Windows.Forms.Button();
            this.btnDepartureTable = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.tpDate = new System.Windows.Forms.DateTimePicker();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvTable = new System.Windows.Forms.ListView();
            this.cmbToStation = new System.Windows.Forms.ComboBox();
            this.cmbFromStation = new System.Windows.Forms.ComboBox();
            this.lblToPosition = new System.Windows.Forms.Label();
            this.lblFromPosition = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnEmail = new System.Windows.Forms.Button();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(255, 144);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(41, 20);
            this.lblTime.TabIndex = 54;
            this.lblTime.Text = "Zeit:";
            // 
            // tpTime
            // 
            this.tpTime.Checked = false;
            this.tpTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.tpTime.Location = new System.Drawing.Point(302, 139);
            this.tpTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpTime.Name = "tpTime";
            this.tpTime.ShowUpDown = true;
            this.tpTime.Size = new System.Drawing.Size(145, 27);
            this.tpTime.TabIndex = 53;
            // 
            // txtToStation
            // 
            this.txtToStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtToStation.Location = new System.Drawing.Point(604, 45);
            this.txtToStation.Margin = new System.Windows.Forms.Padding(4);
            this.txtToStation.Name = "txtToStation";
            this.txtToStation.Size = new System.Drawing.Size(425, 27);
            this.txtToStation.TabIndex = 40;
            // 
            // txtFromStation
            // 
            this.txtFromStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtFromStation.Location = new System.Drawing.Point(22, 45);
            this.txtFromStation.Margin = new System.Windows.Forms.Padding(4);
            this.txtFromStation.Name = "txtFromStation";
            this.txtFromStation.Size = new System.Drawing.Size(425, 27);
            this.txtFromStation.TabIndex = 39;
            // 
            // lblTable
            // 
            this.lblTable.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTable.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTable.Location = new System.Drawing.Point(24, 298);
            this.lblTable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(1005, 32);
            this.lblTable.TabIndex = 52;
            this.lblTable.Text = "Verbindungen:";
            this.lblTable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnMap
            // 
            this.btnMap.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMap.BackgroundImage")));
            this.btnMap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMap.Location = new System.Drawing.Point(474, 124);
            this.btnMap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMap.Name = "btnMap";
            this.btnMap.Size = new System.Drawing.Size(101, 63);
            this.btnMap.TabIndex = 43;
            this.btnMap.UseVisualStyleBackColor = false;
            this.btnMap.Click += new System.EventHandler(this.btnMap_Click);
            // 
            // btnDepartureTable
            // 
            this.btnDepartureTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDepartureTable.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDepartureTable.Location = new System.Drawing.Point(24, 231);
            this.btnDepartureTable.Margin = new System.Windows.Forms.Padding(4);
            this.btnDepartureTable.Name = "btnDepartureTable";
            this.btnDepartureTable.Size = new System.Drawing.Size(200, 46);
            this.btnDepartureTable.TabIndex = 42;
            this.btnDepartureTable.Text = "Abfahrt Tabelle";
            this.btnDepartureTable.UseVisualStyleBackColor = true;
            this.btnDepartureTable.Click += new System.EventHandler(this.btnDepartureTable_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(19, 144);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(64, 20);
            this.lblDate.TabIndex = 50;
            this.lblDate.Text = "Datum:";
            // 
            // tpDate
            // 
            this.tpDate.Checked = false;
            this.tpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tpDate.Location = new System.Drawing.Point(89, 139);
            this.tpDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpDate.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.tpDate.Name = "tpDate";
            this.tpDate.Size = new System.Drawing.Size(135, 27);
            this.tpDate.TabIndex = 49;
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
            // lvTable
            // 
            this.lvTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader5});
            this.lvTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvTable.Location = new System.Drawing.Point(24, 333);
            this.lvTable.Margin = new System.Windows.Forms.Padding(4);
            this.lvTable.Name = "lvTable";
            this.lvTable.Size = new System.Drawing.Size(1006, 195);
            this.lvTable.TabIndex = 51;
            this.lvTable.TileSize = new System.Drawing.Size(168, 30);
            this.lvTable.UseCompatibleStateImageBehavior = false;
            this.lvTable.View = System.Windows.Forms.View.Details;
            // 
            // cmbToStation
            // 
            this.cmbToStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbToStation.FormattingEnabled = true;
            this.cmbToStation.Location = new System.Drawing.Point(604, 80);
            this.cmbToStation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbToStation.Name = "cmbToStation";
            this.cmbToStation.Size = new System.Drawing.Size(425, 28);
            this.cmbToStation.TabIndex = 48;
            this.cmbToStation.Click += new System.EventHandler(this.txtToStation_TextChanged);
            // 
            // cmbFromStation
            // 
            this.cmbFromStation.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbFromStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFromStation.FormattingEnabled = true;
            this.cmbFromStation.Location = new System.Drawing.Point(22, 80);
            this.cmbFromStation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFromStation.Name = "cmbFromStation";
            this.cmbFromStation.Size = new System.Drawing.Size(425, 28);
            this.cmbFromStation.TabIndex = 47;
            this.cmbFromStation.Click += new System.EventHandler(this.txtFromStation_TextChanged);
            // 
            // lblToPosition
            // 
            this.lblToPosition.AutoSize = true;
            this.lblToPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToPosition.Location = new System.Drawing.Point(600, 20);
            this.lblToPosition.Name = "lblToPosition";
            this.lblToPosition.Size = new System.Drawing.Size(58, 20);
            this.lblToPosition.TabIndex = 46;
            this.lblToPosition.Text = "Nach: ";
            // 
            // lblFromPosition
            // 
            this.lblFromPosition.AutoSize = true;
            this.lblFromPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromPosition.Location = new System.Drawing.Point(18, 20);
            this.lblFromPosition.Name = "lblFromPosition";
            this.lblFromPosition.Size = new System.Drawing.Size(43, 20);
            this.lblFromPosition.TabIndex = 45;
            this.lblFromPosition.Text = "Von:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DimGray;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSearch.Location = new System.Drawing.Point(832, 231);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(197, 46);
            this.btnSearch.TabIndex = 41;
            this.btnSearch.Text = "Suchen";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearchForConnections_Click);
            // 
            // btnEmail
            // 
            this.btnEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmail.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEmail.Location = new System.Drawing.Point(259, 231);
            this.btnEmail.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(188, 46);
            this.btnEmail.TabIndex = 55;
            this.btnEmail.Text = "Email";
            this.btnEmail.UseVisualStyleBackColor = true;
            this.btnEmail.Click += new System.EventHandler(this.btnEmail_click);
            // 
            // btnSwitch
            // 
            this.btnSwitch.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSwitch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSwitch.BackgroundImage")));
            this.btnSwitch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSwitch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSwitch.Location = new System.Drawing.Point(474, 45);
            this.btnSwitch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(101, 63);
            this.btnSwitch.TabIndex = 56;
            this.btnSwitch.UseVisualStyleBackColor = false;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // TableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1051, 555);
            this.Controls.Add(this.btnSwitch);
            this.Controls.Add(this.btnEmail);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.tpTime);
            this.Controls.Add(this.txtToStation);
            this.Controls.Add(this.txtFromStation);
            this.Controls.Add(this.lblTable);
            this.Controls.Add(this.btnMap);
            this.Controls.Add(this.btnDepartureTable);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.tpDate);
            this.Controls.Add(this.lvTable);
            this.Controls.Add(this.cmbToStation);
            this.Controls.Add(this.cmbFromStation);
            this.Controls.Add(this.lblToPosition);
            this.Controls.Add(this.lblFromPosition);
            this.Controls.Add(this.btnSearch);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TableForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.DateTimePicker tpTime;
        private System.Windows.Forms.TextBox txtToStation;
        private System.Windows.Forms.TextBox txtFromStation;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.Button btnMap;
        private System.Windows.Forms.Button btnDepartureTable;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker tpDate;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView lvTable;
        private System.Windows.Forms.ComboBox cmbToStation;
        private System.Windows.Forms.ComboBox cmbFromStation;
        private System.Windows.Forms.Label lblToPosition;
        private System.Windows.Forms.Label lblFromPosition;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnEmail;
        private System.Windows.Forms.Button btnSwitch;
    }
}

