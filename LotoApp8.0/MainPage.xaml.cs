namespace LotoApp8._0
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
           
        }
        /// <summary>
        /// Изменение значения слайдера 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void Slider_ValueChanged(object sender, ValueChangedEventArgs args)
        {
            int value = (int)args.NewValue;
            LabelCurrentPosition.Text = Convert.ToString(value);
           
        }
        /// <summary>
        /// Фиксация нажатия на текущее число
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelCurrentNumber_Clicked(object sender, TappedEventArgs e)
        {
            LabelCurrentNumber.Text = Convert.ToString(Convert.ToInt32(LabelCurrentNumber.Text) + 1);
        }
    }

}
