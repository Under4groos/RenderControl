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

namespace RenderControl
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        WPFRenderControl renderControl;
        public MainWindow()
        {
            InitializeComponent();

            this.Loaded += MainWindow_Loaded;

         
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            renderControl = new WPFRenderControl(border);
            renderControl.Name = "image_border";
            renderControl.Render();

            renderControl = new WPFRenderControl(this);
            renderControl.Name = "image_main";
            renderControl.Render();

            renderControl = new WPFRenderControl(text);
            renderControl.Name = "image_border_text";
            renderControl.Render();
            this.Close();
        }
    }
}
