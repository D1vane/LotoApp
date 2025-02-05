using Plugin.Maui.Audio;
using System.Xml;

namespace LotoApp8._0
{
    public partial class MainPage : ContentPage
    {
        /// <summary>
        /// Количество чисел для игры в лото
        /// </summary>
        const int countOfNumbers = 90;

        /// <summary>
        /// Воспроизведение звуков
        /// </summary>
        private readonly IAudioManager audioManger;

        /// <summary>
        /// Массив чисел текущего раунда
        /// </summary>
        int[] numbers = new int[countOfNumbers];

        public MainPage(IAudioManager audioManager)
        {
            InitializeComponent();
            this.audioManger = audioManager;
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
        /// Определение порядкого номера искомого числа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        async private void LabelCurrentNumber_Clicked(object sender, TappedEventArgs e)
        {
            var number = await DisplayPromptAsync("Число", "Введите Число:", "OK", "Отмена", null, 2, Keyboard.Numeric);
            
            LabelCurrentNumber.Text = number;
            SliderOfNumbers.Value = Array.IndexOf(numbers, Convert.ToInt32(number))+1;
        }
        /// <summary>
        /// Создание цепочки случайных чисел
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void ButtonStart_Clicked(object sender, EventArgs e)
        {
            Random r = new();
            numbers = new int[countOfNumbers];
            for (int i = 0; i < countOfNumbers; i++)
            {
                var tempNum = r.Next(1, countOfNumbers + 1);
                if (numbers.Contains(tempNum)) i--;
                else numbers[i] = tempNum;
            }
            if (numbers.Length != numbers.Distinct().Count()) SliderOfNumbers.Value = 10;
            else SliderOfNumbers.Value = 1;
            LabelCurrentNumber.Text = Convert.ToString(numbers[0]);

            // Воспроизведение записи
            var player = audioManger.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("voiceOne.wav"));

            player.Play();
            
            // Очитка кэша после воспроизведений
            if (!player.IsPlaying)
                player.Dispose();
        }
    }

}
