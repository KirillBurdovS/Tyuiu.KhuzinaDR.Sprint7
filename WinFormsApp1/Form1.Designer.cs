namespace WinFormsApp1
{
    partial class MainForm_KDR
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
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            buttonClose_KDR = new Button();
            button2 = new Button();
            btnOpenTable_KDR = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(490, 131);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Menu;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(185, 59);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(168, 16);
            textBox1.TabIndex = 0;
            textBox1.Text = "МЕНЕДЖЕР ЗАКАЗОВ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonClose_KDR);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(btnOpenTable_KDR);
            groupBox2.Location = new Point(12, 149);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(490, 182);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // buttonClose_KDR
            // 
            buttonClose_KDR.Location = new Point(120, 107);
            buttonClose_KDR.Name = "buttonClose_KDR";
            buttonClose_KDR.Size = new Size(258, 46);
            buttonClose_KDR.TabIndex = 2;
            buttonClose_KDR.Text = "Выход";
            buttonClose_KDR.UseVisualStyleBackColor = true;
            buttonClose_KDR.Click += buttonClose_KDR_Click;
            // 
            // button2
            // 
            button2.Location = new Point(120, 65);
            button2.Name = "button2";
            button2.Size = new Size(258, 36);
            button2.TabIndex = 1;
            button2.Text = "Справка";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnOpenTable_KDR
            // 
            btnOpenTable_KDR.Location = new Point(120, 22);
            btnOpenTable_KDR.Name = "btnOpenTable_KDR";
            btnOpenTable_KDR.Size = new Size(258, 37);
            btnOpenTable_KDR.TabIndex = 0;
            btnOpenTable_KDR.Text = "Открыть таблицу заказов";
            btnOpenTable_KDR.UseVisualStyleBackColor = true;
            btnOpenTable_KDR.Click += btnOpenTable_KDR_Click;
            // 
            // MainForm_KDR
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 343);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "MainForm_KDR";
            Text = "Главное меню";
            MinimumSizeChanged += MainForm_KDR_MinimumSizeChanged;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox textBox1;
        private Button buttonClose_KDR;
        private Button button2;
        private Button btnOpenTable_KDR;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
