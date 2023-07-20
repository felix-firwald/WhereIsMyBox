using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WhereIsMyBox.Forms.ReusableElements
{
    /// <summary>
    /// Логика взаимодействия для WhiteButton.xaml
    /// </summary>
    public partial class WhiteButton : UserControl
    {
        public string Text = "Текст кнопки";
        public WhiteButton()
        {
            InitializeComponent();
        }

        private void OnLeftMouseClick(object sender, MouseButtonEventArgs e)
        {
            this.IsEnabled = false;
        }
    }
}
