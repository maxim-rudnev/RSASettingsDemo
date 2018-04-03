using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSASettingsDemo
{
    public partial class Form1 : Form
    {
        // Настройки приложения
        Settings _settings = null;

        public Form1()
        {
            InitializeComponent();

            // получение данных настроек приложения
            _settings = Settings.GetSettings();

            _initControlls();
        }

        /// <summary>
        /// Инициализация элементов управления. Заполнения данными соответствующих полей
        /// </summary>
        private void _initControlls()
        {
            textBoxName.Text = _settings.GetName();
            textBoxSecondname.Text = _settings.GetSecondname();
            textBoxFamilyname.Text = _settings.GetFamilyname();

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            _settings.SetName( textBoxName.Text);
            _settings.Secondname = textBoxSecondname.Text;
            _settings.Familyname = textBoxFamilyname.Text;

            _settings.Save();
        }
    }
}
