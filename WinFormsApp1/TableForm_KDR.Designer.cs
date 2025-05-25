namespace WinFormsApp1
{
    partial class TableForm_KDR
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
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            textBox2 = new TextBox();
            buttonClear = new Button();
            buttonLoad = new Button();
            buttonSave = new Button();
            buttonDeleteRow = new Button();
            buttonAddRow = new Button();
            buttonAddColumn = new Button();
            dataGridView1 = new DataGridView();
            saveFileDialog1 = new SaveFileDialog();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            buttonMenu = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1163, 50);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Menu;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(499, 22);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(172, 16);
            textBox1.TabIndex = 0;
            textBox1.Text = "ТАБЛИЦА ЗАКАЗОВ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonMenu);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(buttonClear);
            groupBox2.Controls.Add(buttonLoad);
            groupBox2.Controls.Add(buttonSave);
            groupBox2.Controls.Add(buttonDeleteRow);
            groupBox2.Controls.Add(buttonAddRow);
            groupBox2.Controls.Add(buttonAddColumn);
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(12, 68);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1163, 427);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Menu;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(6, 344);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(100, 16);
            textBox2.TabIndex = 7;
            textBox2.Text = "Функционал";
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(411, 372);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(75, 49);
            buttonClear.TabIndex = 6;
            buttonClear.Text = "Очистить";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonLoad
            // 
            buttonLoad.Location = new Point(330, 372);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(75, 49);
            buttonLoad.TabIndex = 5;
            buttonLoad.Text = "Открыть";
            buttonLoad.UseVisualStyleBackColor = true;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(249, 372);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 49);
            buttonSave.TabIndex = 4;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonDeleteRow
            // 
            buttonDeleteRow.Location = new Point(168, 372);
            buttonDeleteRow.Name = "buttonDeleteRow";
            buttonDeleteRow.Size = new Size(75, 49);
            buttonDeleteRow.TabIndex = 3;
            buttonDeleteRow.Text = "Удалить";
            buttonDeleteRow.UseVisualStyleBackColor = true;
            buttonDeleteRow.Click += buttonDeleteRow_Click;
            // 
            // buttonAddRow
            // 
            buttonAddRow.Location = new Point(87, 372);
            buttonAddRow.Name = "buttonAddRow";
            buttonAddRow.Size = new Size(75, 49);
            buttonAddRow.TabIndex = 2;
            buttonAddRow.Text = "Строка";
            buttonAddRow.UseVisualStyleBackColor = true;
            buttonAddRow.Click += buttonAddRow_Click;
            // 
            // buttonAddColumn
            // 
            buttonAddColumn.Location = new Point(6, 372);
            buttonAddColumn.Name = "buttonAddColumn";
            buttonAddColumn.Size = new Size(75, 49);
            buttonAddColumn.TabIndex = 1;
            buttonAddColumn.Text = "Колонка";
            buttonAddColumn.UseVisualStyleBackColor = true;
            buttonAddColumn.Click += buttonAddColumn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1151, 316);
            dataGridView1.TabIndex = 0;
            // 
            // buttonMenu
            // 
            buttonMenu.Location = new Point(1071, 372);
            buttonMenu.Name = "buttonMenu";
            buttonMenu.Size = new Size(75, 44);
            buttonMenu.TabIndex = 8;
            buttonMenu.Text = "Вернутся в меню";
            buttonMenu.UseVisualStyleBackColor = true;
            buttonMenu.Click += buttonMenu_Click;
            // 
            // TableForm_KDR
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1187, 507);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "TableForm_KDR";
            Text = "TableForm_KDR";
            FormClosing += TableForm_KDR_FormClosing;
            Load += TableForm_KDR_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private Button buttonAddColumn;
        private Button buttonAddRow;
        private Button buttonDeleteRow;
        private SaveFileDialog saveFileDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button buttonLoad;
        private Button buttonSave;
        private Button buttonClear;
        private TextBox textBox2;
        private Button buttonMenu;
    }
}