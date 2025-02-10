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
        readonly IAudioManager audioManger;

        /// <summary>
        /// Массив чисел текущего раунда
        /// </summary>
        int[] numbers = new int[countOfNumbers];

        /// <summary>
        /// Стоит ли на паузе счет
        /// </summary>
        bool isPaused = false;
        /// <summary>
        /// Завершение счета
        /// </summary>
        bool isStoped = false;

        /// <summary>
        /// Начало счета
        /// </summary>
        readonly int startIndex = 0;

        /// <summary>
        /// Продолжение счета
        /// </summary>
        int currentIndex = 0;

        /// <summary>
        /// Задержка при скорости 1х
        /// </summary>
        readonly int delayOne = 2000;

        /// <summary>
        /// Задержка при скорости 1.25x
        /// </summary>
        readonly int delayOneTwoFive = 1750;

        /// <summary>
        /// Задержка при скорости 1.5x
        /// </summary>
        readonly int delayOneFive = 1500;

        /// <summary>
        /// Задержка при скорости 1.75x
        /// </summary>
        readonly int delayOneSevenFive = 1250;

        /// <summary>
        /// Задержка при скорости 2x
        /// </summary>
        readonly int delayTwo = 1000;
        /// <summary>
        /// Скорость воспроизведения
        /// </summary>
        int currentSpeed = 1;
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
            currentIndex = value-1;
        }
        /// <summary>
        /// Определение порядкого номера искомого числа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        async private void LabelCurrentNumber_Clicked(object sender, TappedEventArgs e)
        {
            var number = await DisplayPromptAsync("Число", "Введите Число:", "OK", "Отмена", null, 2, Keyboard.Numeric);
            if (number != null)
            {
                LabelCurrentNumber.Text = number;
                SliderOfNumbers.Value = Array.IndexOf(numbers, Convert.ToInt32(number)) + 1;
            }
        }
        /// <summary>
        /// Создание цепочки случайных чисел
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonStart_Clicked(object sender, EventArgs e)
        {
            LabelSpeedOne.IsVisible = LabelSpeedOneTwoFive.IsVisible =  LabelSpeedOneFive.IsVisible = LabelSpeedOneSevenFive.IsVisible = LabelSpeedTwo.IsVisible = false;
            Random r = new();
            numbers = new int[countOfNumbers];
            for (int i = 0; i < countOfNumbers; i++)
            {
                var tempNum = r.Next(1, countOfNumbers + 1);
                if (numbers.Contains(tempNum)) i--;
                else numbers[i] = tempNum;
            }
            LabelCurrentNumber.Text = Convert.ToString(numbers[0]);
            ButtonStart.IsVisible = false;
            ButtonPause.IsVisible = true;
            ButtonStop.IsVisible = true;
            if (isStoped) isStoped = false;
            Speaker(startIndex);
            
        }
        /// <summary>
        /// Воспроизведение счета
        /// </summary>
        /// <param name="currentIndex"></param>
        private async void Speaker (int currentIndex)
        {
            for (int i = currentIndex; i < countOfNumbers; i++)
            {
                var player = audioManger.CreatePlayer(await FileSystem.OpenAppPackageFileAsync(NumbersInVoice.SwitchNumbers(numbers[i],currentSpeed)));
                LabelCurrentNumber.Text = Convert.ToString(numbers[i]);
                SliderOfNumbers.Value = i + 1;
                
                // Воспроизведение записи
                player.Play();
                if (currentSpeed == 1) await Task.Delay(delayOne);
                else if (currentSpeed == 125) await Task.Delay(delayOneTwoFive);
                else if (currentSpeed == 15) await Task.Delay(delayOneFive);
                else if (currentSpeed == 175) await Task.Delay(delayOneSevenFive);
                else await Task.Delay(delayTwo);

                if (isStoped)
                {
                    player.Dispose();
                    isStoped = false;
                    return;
                }
                if (isPaused)
                {
                    player.Dispose();
                    // При возобновлении воспроизведения начнется со след числа
                    this.currentIndex = i+1;
                    return;
                }
            }
        }
        private void ButtonPause_Clicked(object sender, EventArgs e)
        {
            isPaused = true;
            ButtonContinue.IsVisible = true;
            ButtonPause.IsVisible = false;

        }

        private void ButtonStop_Clicked(object sender, EventArgs e)
        {
            LabelSpeedOne.IsVisible = LabelSpeedOneTwoFive.IsVisible = LabelSpeedOneFive.IsVisible = LabelSpeedOneSevenFive.IsVisible = LabelSpeedTwo.IsVisible = true;
            isStoped = true;
            if (ButtonPause.IsVisible) ButtonPause.IsVisible = false;
            if (ButtonContinue.IsVisible) ButtonContinue.IsVisible = false;
            ButtonStop.IsVisible = false;
            ButtonStart.IsVisible = true;
            SliderOfNumbers.Value = 1;
            if (isPaused) isPaused = false;
        }

        private void ButtonContinue_Clicked(object sender, EventArgs e)
        {
            isPaused = false;
            ButtonContinue.IsVisible = false;
            ButtonPause.IsVisible = true;
            Speaker(currentIndex);
        }

        private void LabelSpeedOne_Clicked(object sender, TappedEventArgs e)
        {
            currentSpeed = 1;
            LabelCurrentSpeed.Text = "1x";
            
        }

        private void LabelSpeedOneTwoFive_Clicked(object sender, TappedEventArgs e)
        {
            currentSpeed = 125;
            LabelCurrentSpeed.Text = "1.25x";
        }
        private void LabelSpeedOneFive_Clicked(object sender, TappedEventArgs e)
        {
            currentSpeed = 15;
            LabelCurrentSpeed.Text = "1.5x";
        }

        private void LabelSpeedOneSevenFive_Clicked(object sender, TappedEventArgs e)
        {
            currentSpeed = 175;
            LabelCurrentSpeed.Text = "1.75x";
        }

        private void LabelSpeedTwo_Clicked(object sender, TappedEventArgs e)
        {
            currentSpeed = 2;
            LabelCurrentSpeed.Text = "2x";
        }
    }

}
