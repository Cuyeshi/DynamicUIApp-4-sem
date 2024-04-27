using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Lab_4_WPF
{
    public partial class MainWindow : Window
    {
        private Slider slider;
        private RotateTransform rotateTransform;
        private Rectangle rectangle;

        public MainWindow()
        {
            InitializeComponent();
            CreateUI();
        }

        private void CreateUI()
        {
            // Создаем главное окно
            this.Width = 400;
            this.Height = 400;
            this.Title = "Графический Редактор";

            // Создаем панель для размещения элементов
            StackPanel panel = new StackPanel();
            panel.Orientation = Orientation.Vertical;
            panel.HorizontalAlignment = HorizontalAlignment.Center;
            panel.VerticalAlignment = VerticalAlignment.Center;
            this.Content = panel;

            // Создаем квадрат
            rectangle = new Rectangle();
            rectangle.Width = 100;
            rectangle.Height = 100;
            rectangle.Fill = Brushes.Blue;
            rectangle.RenderTransformOrigin = new Point(0.5, 0.5); // Устанавливаем точку вращения в центр
            panel.Children.Add(rectangle);

            
        }
    }
}
