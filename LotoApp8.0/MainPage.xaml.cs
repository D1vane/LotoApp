namespace LotoApp8._0
{
    public partial class MainPage : ContentPage
    {
        const int countOfNumbers = 90;
        int[] numbers = new int[countOfNumbers];
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

            LabelCurrentNumber.Text = Convert.ToString(numbers[value-1]);

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
        /// <summary>
        /// Создание цепочки случайных чисел
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonStart_Clicked(object sender, EventArgs e)
        {
            Random r = new();
            numbers = new int[countOfNumbers];
            for (int i = 0; i < countOfNumbers; i++)
            {
                var tempNum = r.Next(1,countOfNumbers+1);
                if (numbers.Contains(tempNum)) i--;
                else numbers[i] = tempNum;
            }
            if (numbers.Length != numbers.Distinct().Count()) SliderOfNumbers.Value = 10;
            else SliderOfNumbers.Value = 1;
            LabelCurrentNumber.Text = Convert.ToString(numbers[0]);
        }
    }

}
