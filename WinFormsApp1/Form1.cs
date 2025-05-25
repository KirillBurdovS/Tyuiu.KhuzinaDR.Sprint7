using System.Reflection;
using System.Windows.Forms.Design;


namespace WinFormsApp1
{
    public partial class MainForm_KDR : Form
    {
        public MainForm_KDR()
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

        private void btnOpenTable_KDR_Click(object sender, EventArgs e)
        {
            TableForm_KDR formWithGrid = new TableForm_KDR();
            formWithGrid.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            qwe formWithGrid = new qwe();
            formWithGrid.Show();
        }

        private void MainForm_KDR_MinimumSizeChanged(object sender, EventArgs e)
        {

        }

        private void buttonClose_KDR_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите выйти?",
                       "Подтверждение",
                       MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
