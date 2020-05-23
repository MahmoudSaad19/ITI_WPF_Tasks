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

namespace Wpf_Lab1_ass3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
                
        private void setColor(object sender, RoutedEventArgs e)
        {
            if (Red.IsChecked ?? false)
                ctx.DefaultDrawingAttributes.Color = Color.FromRgb(255, 0, 0);
            else if (Green.IsChecked ?? false)
                ctx.DefaultDrawingAttributes.Color = Color.FromRgb(0, 255, 0);
            else if (Blue.IsChecked ?? false)
                ctx.DefaultDrawingAttributes.Color = Color.FromRgb(0, 0, 255);
            else if (Magenta.IsChecked ?? false)
                ctx.DefaultDrawingAttributes.Color = Color.FromRgb(255, 0, 255);
            else
                ctx.DefaultDrawingAttributes.Color = Color.FromRgb(0, 0, 0);
        }

        private void setMode(object sender, RoutedEventArgs e)
        {
            if (ik.IsChecked ?? false)
                ctx.EditingMode = InkCanvasEditingMode.Ink;
            else if (select.IsChecked ?? false)
                ctx.EditingMode = InkCanvasEditingMode.Select;
            else if (erase.IsChecked ?? false)
                ctx.EditingMode = InkCanvasEditingMode.EraseByPoint;
            else if (eraseStroke.IsChecked ?? false)
                ctx.EditingMode = InkCanvasEditingMode.EraseByStroke;
            else
                ctx.EditingMode = InkCanvasEditingMode.None;
        }

        private void setShape(object sender, RoutedEventArgs e)
        {
            if (ellipse.IsChecked ?? false)
                ctx.DefaultDrawingAttributes.StylusTip = System.Windows.Ink.StylusTip.Ellipse;
            else if (rect.IsChecked ?? false)
                ctx.DefaultDrawingAttributes.StylusTip = System.Windows.Ink.StylusTip.Rectangle;
        }

        private void setSize(object sender, RoutedEventArgs e)
        {
            if (small.IsChecked ?? false)
            {
                ctx.DefaultDrawingAttributes.Width = 3;
                ctx.DefaultDrawingAttributes.Height = 3;
            }
            else if (normal.IsChecked??false)
            {
                ctx.DefaultDrawingAttributes.Width = 6;
                ctx.DefaultDrawingAttributes.Height = 6;
            }
            else if(large.IsChecked??false)
            {
                ctx.DefaultDrawingAttributes.Width = 12;
                ctx.DefaultDrawingAttributes.Height = 12;
            }
            else
            {
                ctx.DefaultDrawingAttributes.Width = 2;
                ctx.DefaultDrawingAttributes.Height = 2;
            }
        }

        private void bt_new(object sender, RoutedEventArgs e)
        {
            ctx.Strokes.Clear();
        }
        private void bt_copy(object sender, RoutedEventArgs e)
        {
            ctx.CopySelection();
        }

        private void bt_save(object sender, RoutedEventArgs e)
        {
            
        }

        private void bt_cut(object sender, RoutedEventArgs e)
        {
            ctx.CutSelection();
        }

        private void bt_load(object sender, RoutedEventArgs e)
        {

        }

        private void bt_paste(object sender, RoutedEventArgs e)
        {
            ctx.Paste();
        }
    }
}
