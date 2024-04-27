using lab_4;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Lab_4
{
    internal partial class MainForm : Form
    {
        private PanelEx panel;
        private TrackBar trackBar;
        private Button applyButton;

        public MainForm()
        {
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            // Настройка главной формы
            this.Text = "Графический Редактор";
            this.Size = new Size(400, 450);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Создание панели синего цвета
            panel = new PanelEx();
            panel.BackColor = Color.Blue;
            panel.Size = new Size(200, 200);
            panel.Location = new Point((this.ClientSize.Width - panel.Width) / 2, (this.ClientSize.Height - panel.Height) / 2);
            this.Controls.Add(panel);

            // Создание слайдера
            trackBar = new TrackBar();
            trackBar.Minimum = 0;
            trackBar.Maximum = 180;
            trackBar.Value = 0;
            trackBar.TickFrequency = 10;
            trackBar.Orientation = Orientation.Horizontal;
            trackBar.Size = new Size(200, 20);
            trackBar.Location = new Point((this.ClientSize.Width - trackBar.Width) / 2, panel.Bottom + 20);
            this.Controls.Add(trackBar);

            // Создание кнопки "Применить"
            applyButton = new Button();
            applyButton.Text = "Применить";
            applyButton.Size = new Size(100, 30);
            applyButton.Location = new Point((this.ClientSize.Width - applyButton.Width) / 2, trackBar.Bottom + 20);
            this.Controls.Add(applyButton);

            // Привязка событий к слайдеру
            trackBar.Scroll += (sender, e) =>
            {
                RotatePanel(trackBar.Value);
            };

            // Привязка события нажатия кнопки "Применить"
            applyButton.Click += (sender, e) =>
            {
                RotatePanel(trackBar.Value);
            };
        }

        private void RotatePanel(int angle)
        {
            // Поворот панели относительно её центра
            panel.Location = new Point((this.ClientSize.Width - panel.Width) / 2, (this.ClientSize.Height - panel.Height) / 2);
            panel.Anchor = AnchorStyles.None;
            panel.Top = (this.ClientSize.Height - panel.Height) / 2;
            panel.Left = (this.ClientSize.Width - panel.Width) / 2;
            panel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            panel.RotateAngle = angle;
            panel.Invalidate();
        }



    }
}
