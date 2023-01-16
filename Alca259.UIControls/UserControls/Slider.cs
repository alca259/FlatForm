using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Alca259.UIControls.UserControls
{
    public partial class Slider : UserControl
    {
        private const string NameSlider = "Slider";
        private Color defaultBarColor;
        private int multiplier = 1;
        private int steps = 1;

        public event EventHandler<int>? SliderChanged;

        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always), Category(NameSlider)]
        public int MinValue
        {
            get => sliderBar.Minimum;
            set
            {
                sliderBar.Minimum = value;
                sliderMin.Text = value.ToString();
            }
        }

        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always), Category(NameSlider)]
        public int MaxValue
        {
            get => sliderBar.Maximum;
            set
            {
                sliderBar.Maximum = value;
                sliderMax.Text = value.ToString();
            }
        }

        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always), Category(NameSlider)]
        public int CurrentValue
        {
            get => sliderBar.Value;
            set
            {
                sliderBar.Value = value;
                sliderValue.Text = value.ToString();
            }
        }

        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always), Category(NameSlider)]
        public int Steps
        {
            get => steps;
            set
            {
                sliderBar.TickFrequency = value;
                steps = value;
            }
        }

        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always), Category(NameSlider)]
        public string LabelToShow
        {
            get => sliderLabel.Text;
            set
            {
                sliderLabel.Text = value;
            }
        }

        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always), Category(NameSlider)]
        public bool IsEnabled
        {
            get => sliderBar.Enabled;
            set
            {
                sliderBar.Enabled = value;
                sliderBar.ForeColor = value ? defaultBarColor : Color.LightGray;
            }
        }

        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always), Category(NameSlider)]
        public int Multiplier
        {
            get => multiplier;
            set
            {
                multiplier = value;
            }
        }

        public void SetMilliseconds(int value)
        {
            CurrentValue = value / Multiplier;
        }

        public int GetMilliseconds()
        {
            return CurrentValue * Multiplier;
        }

        public Slider()
        {
            InitializeComponent();
            defaultBarColor = sliderBar.ForeColor;
            sliderBar.ValueChanged += SliderBar_ValueChanged;
        }

        private void SliderBar_ValueChanged(object? sender, EventArgs e)
        {
            sliderValue.Text = sliderBar.Value.ToString();

            if (sender != null && sender.GetType() == typeof(TrackBar))
            {
                SliderChanged?.Invoke(this, GetMilliseconds());
            }
        }
    }
}