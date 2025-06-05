using System;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class TableForm_KDR : Form
    {
        // Храним данные в DataTable для удобства
        private DataTable dataTable = new DataTable();

        public TableForm_KDR()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            // Убираем кнопки управления окномhfhdh
            this.ControlBox = false;

            // Запрещаем развертывание и сворачивание
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // Запрещаем изменение размеров
            this.SizeGripStyle = SizeGripStyle.Hide;
            InitializeComponent();
            SetupDataGrid();
        }

        private void SetupDataGrid()
        {
            // Настройка DataGridView
            dataGridView1.AllowUserToAddRows = true;
            dataGridView1.AllowUserToDeleteRows = true;
            dataGridView1.ReadOnly = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;

            // Добавляем начальные колонки
            dataTable.Columns.Add("ФИО", typeof(string));
            dataTable.Columns.Add("Товар", typeof(string));
            dataTable.Columns.Add("Ценна", typeof(string));


            // Добавляем тестовые данные
            dataTable.Rows.Add("Иванов И.И.", "Пылесос", "24000");
            dataTable.Rows.Add("Елизавета П.Я.", "Утка", "1700");
            dataTable.Rows.Add("Рональдо С.К.", "Футбольный мяч", "2000");


            // Привязываем DataTable к DataGridView
            dataGridView1.DataSource = dataTable;
        }

        private void buttonAddColumn_Click(object sender, EventArgs e)
        {

            string columnName = Microsoft.VisualBasic.Interaction.InputBox(
                "Введите название новой колонки:",
                "Добавление колонки",
                "Новая колонка");

            if (!string.IsNullOrWhiteSpace(columnName))
            {
                // Добавляем колонку
                dataTable.Columns.Add(columnName.Trim(), typeof(string));
            }
        }

        private void buttonAddRow_Click(object sender, EventArgs e)
        {
            dataTable.Rows.Add();
        }

        private void buttonDeleteRow_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (!row.IsNewRow)
                {
                    dataGridView1.Rows.Remove(row);
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "CSV файлы (*.csv)|*.csv";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StringBuilder sb = new StringBuilder();

                    // Заголовки колонок
                    foreach (DataGridViewColumn column in dataGridView1.Columns)
                    {
                        sb.Append(column.HeaderText + ",");
                    }
                    sb.AppendLine();

                    // Данные
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                sb.Append((cell.Value ?? "").ToString() + ",");
                            }
                            sb.AppendLine();
                        }
                    }

                    File.WriteAllText(saveDialog.FileName, sb.ToString(), Encoding.UTF8);
                    MessageBox.Show("Данные сохранены успешно!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при сохранении: " + ex.Message);
                }
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "CSV файлы (*.csv)|*.csv";

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable newTable = new DataTable();
                    string[] lines = File.ReadAllLines(openDialog.FileName, Encoding.UTF8);

                    if (lines.Length == 0) return;

                    // Заголовки колонок
                    string[] headers = lines[0].Split(',');
                    foreach (string header in headers)
                    {
                        newTable.Columns.Add(header.Trim());
                    }

                    // Данные (начинаем со второй строки)
                    for (int i = 1; i < lines.Length; i++)
                    {
                        string[] values = lines[i].Split(',');

                        // Проверяем, чтобы количество значений не превышало количество колонок
                        if (values.Length > newTable.Columns.Count)
                        {
                            // Обрезаем лишние значения
                            Array.Resize(ref values, newTable.Columns.Count);
                        }
                        else if (values.Length < newTable.Columns.Count)
                        {
                            // Дополняем недостающие значения пустыми строками
                            Array.Resize(ref values, newTable.Columns.Count);
                            for (int j = values.Length; j < newTable.Columns.Count; j++)
                            {
                                values[j] = string.Empty;
                            }
                        }

                        newTable.Rows.Add(values);
                    }

                    dataTable = newTable;
                    dataGridView1.DataSource = dataTable;
                    MessageBox.Show("Данные загружены успешно!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при загрузке: {ex.Message}");
                }
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            // Запрашиваем имя для первой колонки
            string columnName = Microsoft.VisualBasic.Interaction.InputBox(
                "Введите название для первой колонки:",
                "Новая таблица",
                "Колонка 1");

            // Если пользователь нажал Отмена или оставил пустым
            if (string.IsNullOrWhiteSpace(columnName))
            {
                columnName = "Колонка 1";
            }

            // Очищаем и создаем новую таблицу
            dataTable = new DataTable();
            dataTable.Columns.Add(columnName.Trim(), typeof(string));

            // Обновляем привязку
            dataGridView1.DataSource = dataTable;

            // Добавляем пустую строку
            dataTable.Rows.Add();
        }
        

        private void TableForm_KDR_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void TableForm_KDR_Load(object sender, EventArgs e)
        {

        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            MainForm_KDR formWithGrid = new MainForm_KDR();
            formWithGrid.Show();

            




        }

        //private void buttonSave_Click(object sender, EventArgs e)
        //{

        //}

        //private void buttonLoad_Click(object sender, EventArgs e)
        //{

        //}

        //private void buttonClear_Click(object sender, EventArgs e)
        //{

        //}
    }
}
