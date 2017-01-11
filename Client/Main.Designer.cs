namespace Client
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_add = new System.Windows.Forms.Button();
            this.dataGridView_student = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_exit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_update_other_data = new System.Windows.Forms.Button();
            this.button_showOtherData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_student)).BeginInit();
            this.SuspendLayout();
            // 
            // button_add
            // 
            this.button_add.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_add.Location = new System.Drawing.Point(395, 14);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(110, 23);
            this.button_add.TabIndex = 0;
            this.button_add.Text = "Add student";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // dataGridView_student
            // 
            this.dataGridView_student.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_student.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.date});
            this.dataGridView_student.Location = new System.Drawing.Point(15, 12);
            this.dataGridView_student.Name = "dataGridView_student";
            this.dataGridView_student.Size = new System.Drawing.Size(366, 237);
            this.dataGridView_student.TabIndex = 1;
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.Width = 50;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.Width = 150;
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.Width = 120;
            // 
            // button_exit
            // 
            this.button_exit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_exit.Location = new System.Drawing.Point(395, 228);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(110, 23);
            this.button_exit.TabIndex = 2;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.Location = new System.Drawing.Point(395, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Remove student";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_update
            // 
            this.button_update.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_update.Location = new System.Drawing.Point(395, 109);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(110, 23);
            this.button_update.TabIndex = 4;
            this.button_update.Text = "Update table";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_update_other_data
            // 
            this.button_update_other_data.Location = new System.Drawing.Point(395, 79);
            this.button_update_other_data.Name = "button_update_other_data";
            this.button_update_other_data.Size = new System.Drawing.Size(110, 23);
            this.button_update_other_data.TabIndex = 6;
            this.button_update_other_data.Text = "Update other data";
            this.button_update_other_data.UseVisualStyleBackColor = true;
            this.button_update_other_data.Click += new System.EventHandler(this.button_update_other_data_Click);
            // 
            // button_showOtherData
            // 
            this.button_showOtherData.Location = new System.Drawing.Point(395, 139);
            this.button_showOtherData.Name = "button_showOtherData";
            this.button_showOtherData.Size = new System.Drawing.Size(110, 23);
            this.button_showOtherData.TabIndex = 7;
            this.button_showOtherData.Text = "Show detail data";
            this.button_showOtherData.UseVisualStyleBackColor = true;
            this.button_showOtherData.Click += new System.EventHandler(this.button_showOtherData_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 265);
            this.Controls.Add(this.button_showOtherData);
            this.Controls.Add(this.button_update_other_data);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.dataGridView_student);
            this.Controls.Add(this.button_add);
            this.Name = "Main";
            this.Text = "Client";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_student)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_update_other_data;
        private System.Windows.Forms.Button button_showOtherData;
        public System.Windows.Forms.DataGridView dataGridView_student;
    }
}

