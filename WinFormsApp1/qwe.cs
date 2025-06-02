using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class qwe : Form
    {
        public qwe()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            // Убираем кнопки управления окном
            this.ControlBox = false;

            // Запрещаем развертывание и сворачивание
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // Запрещаем изменение размеров
            this.SizeGripStyle = SizeGripStyle.Hide;
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm_KDR formWithGrid = new MainForm_KDR();
            formWithGrid.Show();
        }
    }
}
