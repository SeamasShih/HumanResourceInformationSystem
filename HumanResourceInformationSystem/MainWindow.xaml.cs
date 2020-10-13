using HumanResourceInformationSystem.Adapter;
using HumanResourceInformationSystem.EntityClasses;
using HumanResourceInformationSystem.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HumanResourceInformationSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MainView _mainView = new MainView();
        public MainWindow()
        {
            InitializeComponent();
            _mainView.TopLevel = false;
            MainForm.Child = _mainView;
            _mainView.Show();
        }

    }
}
