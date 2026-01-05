namespace TaskManager.WinForm
{
    partial class MainForm
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

         
            

            this.dataGridViewTasks = new System.Windows.Forms.DataGridView();
            this.Controls.Add(this.dataGridViewTasks);
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsDone = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnToggleDone = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.txtTitel = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.chkIsDone = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTasks
            // 
            this.dataGridViewTasks.AccessibleDescription = "Liste aller Aufgaben mit Titel, Datum und Statu";
            this.dataGridViewTasks.AccessibleName = "Aufgabenliste";
            this.dataGridViewTasks.AllowUserToDeleteRows = false;
            this.dataGridViewTasks.AllowUserToResizeRows = false;
            this.dataGridViewTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTitle,
            this.colId,
            this.colDueDate,
            this.colDescription,
            this.colIsDone});
            this.dataGridViewTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTasks.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewTasks.MultiSelect = false;
            this.dataGridViewTasks.Name = "dataGridViewTasks";
            this.dataGridViewTasks.ReadOnly = true;
            this.dataGridViewTasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTasks.Size = new System.Drawing.Size(1320, 450);
            this.dataGridViewTasks.TabIndex = 0;
            this.dataGridViewTasks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTasks_CellContentClick);
            this.dataGridViewTasks.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridViewTasks_RowPrePaint);

            // 
            // colTitle
            // 
            this.colTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTitle.DataPropertyName = "Title";
            this.colTitle.HeaderText = "Title";
            this.colTitle.Name = "colTitle";
            this.colTitle.ReadOnly = true;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // colDueDate
            // 
            this.colDueDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDueDate.DataPropertyName = "DueDate";
            this.colDueDate.HeaderText = "Fällig am";
            this.colDueDate.Name = "colDueDate";
            this.colDueDate.ReadOnly = true;
            // 
            // colDescription
            // 
            this.colDescription.DataPropertyName = "Description";
            this.colDescription.HeaderText = "Beschreibung";
            this.colDescription.Name = "colDescription";
            this.colDescription.ReadOnly = true;
            // 
            // colIsDone
            // 
            this.colIsDone.DataPropertyName = "IsDone";
            this.colIsDone.HeaderText = "Erledigt";
            this.colIsDone.Name = "colIsDone";
            this.colIsDone.ReadOnly = true;
            // 
            // btnNew
            // 
            this.btnNew.AccessibleDescription = "Neue Aufgabe ";
            this.btnNew.AccessibleName = "Neue Aufgabe erstellen";
            this.btnNew.Location = new System.Drawing.Point(67, 112);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 4;
            this.btnNew.Text = "Neu";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.AccessibleName = "ufgabe bearbeiten";
            this.btnEdit.Location = new System.Drawing.Point(255, 112);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Bearbeiten";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AccessibleName = "Aufgabe löschen";
            this.btnDelete.Location = new System.Drawing.Point(511, 112);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Löschen";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnToggleDone
            // 
            this.btnToggleDone.AccessibleName = "Aufgabe erledigt umschalten";
            this.btnToggleDone.Location = new System.Drawing.Point(772, 112);
            this.btnToggleDone.Name = "btnToggleDone";
            this.btnToggleDone.Size = new System.Drawing.Size(75, 23);
            this.btnToggleDone.TabIndex = 7;
            this.btnToggleDone.Text = "Erledigt/Unerledigt";
            this.btnToggleDone.UseVisualStyleBackColor = true;
            this.btnToggleDone.Click += new System.EventHandler(this.btnToggleDone_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.AccessibleName = "Aufgabenliste neu laden";
            this.btnRefresh.Location = new System.Drawing.Point(972, 102);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Aktualisieren";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.AccessibleName = "Abmelden";
            this.btnLogout.Location = new System.Drawing.Point(1139, 102);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // txtTitel
            // 
            this.txtTitel.AccessibleDescription = "Hier den Titel der Aufgabe eingeben";
            this.txtTitel.AccessibleName = "Titel Eingabe";
            this.txtTitel.Location = new System.Drawing.Point(165, 198);
            this.txtTitel.Name = "txtTitel";
            this.txtTitel.Size = new System.Drawing.Size(100, 20);
            this.txtTitel.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(64, 205);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Titel";
            // 
            // txtDescription
            // 
            this.txtDescription.AccessibleDescription = "Hier Beschreibung eingeben";
            this.txtDescription.AccessibleName = "Beschreibung Eingabe";
            this.txtDescription.Location = new System.Drawing.Point(165, 243);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(100, 20);
            this.txtDescription.TabIndex = 1;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(64, 246);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(75, 13);
            this.lblDescription.TabIndex = 10;
            this.lblDescription.Text = "Beschreibung:";
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.AccessibleDescription = "Wählen Sie das Fälligkeitsdatum";
            this.dtpDueDate.AccessibleName = "Fälligkeitsdatum";
            this.dtpDueDate.Location = new System.Drawing.Point(165, 282);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDueDate.TabIndex = 2;
            // 
            // chkIsDone
            // 
            this.chkIsDone.AccessibleDescription = "Markieren, wenn Aufgabe erledigt ist";
            this.chkIsDone.AccessibleName = "Erledigt Checkbox";
            this.chkIsDone.AutoSize = true;
            this.chkIsDone.Location = new System.Drawing.Point(165, 329);
            this.chkIsDone.Name = "chkIsDone";
            this.chkIsDone.Size = new System.Drawing.Size(61, 17);
            this.chkIsDone.TabIndex = 3;
            this.chkIsDone.Text = "Erledigt";
            this.chkIsDone.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "lblDueDate";


            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkIsDone);
            this.Controls.Add(this.dtpDueDate);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtTitel);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnToggleDone);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.dataGridViewTasks);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTasks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTasks;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnToggleDone;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colIsDone;
        private System.Windows.Forms.TextBox txtTitel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.CheckBox chkIsDone;
        private System.Windows.Forms.Label label3;
    }
}

