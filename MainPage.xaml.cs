using Microsoft.UI.Xaml.Controls;
using static System.Net.Mime.MediaTypeNames;

namespace MauiApp3
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }
        // все значения отвечаюшие за переключения цвета и не только кнопок определённого помешения
        int mod_0 = 0;
        int mod_1 = 0;
        int mod_2 = 0;
        int mod_3 = 0;
        int mod_4 = 0;
        int mod_i_information = 0;
        int summ = 0;
        // все значения отвечаюшие за переключения цвета и не только кнопок определённого блюда заметка изменеия самого блюда в зависимости от кухни

        int kuhna_1_ = 0;
        int kuhna_2_ = 0;
        int kuhna_3_ = 0;
        int kuhna_4_ = 0;
        int kuhna_5_ = 0;
        // все значения отвечаюшие за переключения цвета и не только кнопок определённой машины на выбор
        int mod_10 = 0;
        int mod_11 = 0;
        int mod_12 = 0;
        int mod_13 = 0;
        int mod_14 = 0;
        int mod_d_information = 0;
        // все значения отвечаюшие за переключения цвета и не только кнопок определённого букета на выбор
        int mod_20 = 0;
        int mod_21 = 0;
        int mod_22 = 0;
        int mod_23 = 0;
        int mod_24 = 0;
        // дебил этого хватит не дай боже ты ещё сделаеш потом сам себе моск выыебаш в таком сколичестве неструктурированых элементов

                                                                                                                                                        

        private void Kofe_1(object sender, EventArgs e)
        {
            if (mod_0 == 0)
            {
                mod_0 = 1;
                Kofe_01.BackgroundColor = Colors.Violet;
                Kofe_info_1.IsVisible = true;
                Kofe_02.IsVisible = false;
                Kofe_03.IsVisible = false;
                Kofe_04.IsVisible = false;
                Kofe_05.IsVisible = false;

                Kofe_lible_02.IsVisible = false;
                Kofe_lible_03.IsVisible = false;
                Kofe_lible_04.IsVisible = false;
                Kofe_lible_05.IsVisible = false;
                Kofe_info_1.Text = "Ресторанов, который предлагает уникальный опыт гастрономии и великолепные виды на город. Ресторан расположен на 16-м этаже здания и славится своим современным подходом к русской кухне.";

                fixsed_2.Spacing = 0;
                fixsed_3.Spacing = 0;
                fixsed_4.Spacing = 0;
                fixsed_5.Spacing = 0;

                kuhna_01.IsVisible = true;
                kuhna_02.IsVisible = true;
                kuhna_03.IsVisible = true;
                kuhna_04.IsVisible = true;
                kuhna_05.IsVisible = true;

                kuhna_1.IsVisible = true;
                kuhna_2.IsVisible = true;
                kuhna_3.IsVisible = true;
                kuhna_4.IsVisible = true;
                kuhna_5.IsVisible = true;

                mod_i_information = 1;

                kuhna_01.Text = "Салаты с сезонными ингредиентами       ." + Environment.NewLine + "13560 р.";
                kuhna_02.Text = "Рыба, запеченная с травами и лимоном ." + Environment.NewLine + "20200 р.";
                kuhna_03.Text = "Традиционные русские сладости              ." + Environment.NewLine + "7000 р.";
                kuhna_04.Text = "Вина                                                                  ." + Environment.NewLine + "16000 р.";
                kuhna_05.Text = "Тартар из рыбы или мяса                           ." + Environment.NewLine + "5600 р.";

                summ = summ + 58000;
                Sum_imput.Text = "Текушяя цена   " + summ;
            }
            else
            {
                Kofe_01.BackgroundColor = Colors.Grey;
                mod_0 = 0;
                Kofe_info_1.IsVisible = false;
                Kofe_02.IsVisible = true;
                Kofe_03.IsVisible = true;
                Kofe_04.IsVisible = true;
                Kofe_05.IsVisible = true;

                Kofe_lible_02.IsVisible = true;
                Kofe_lible_03.IsVisible = true;
                Kofe_lible_04.IsVisible = true;
                Kofe_lible_05.IsVisible = true;
                Kofe_lible_01.Text = "White Rabbit                                    58000 р.";

                 mod_1 = 0;
                 mod_2 = 0;
                 mod_3 = 0;
                 mod_4 = 0;

                Kofe_02.BackgroundColor = Colors.Grey;
                Kofe_03.BackgroundColor = Colors.Grey;
                Kofe_04.BackgroundColor = Colors.Grey;
                Kofe_05.BackgroundColor = Colors.Grey;

                fixsed_2.Spacing = 10;
                fixsed_3.Spacing = 10;
                fixsed_4.Spacing = 10;
                fixsed_5.Spacing = 10;

                kuhna_01.IsVisible = false;
                kuhna_02.IsVisible = false;
                kuhna_03.IsVisible = false;
                kuhna_04.IsVisible = false;
                kuhna_05.IsVisible = false;

                kuhna_1.IsVisible = false;
                kuhna_2.IsVisible = false;
                kuhna_3.IsVisible = false;
                kuhna_4.IsVisible = false;
                kuhna_5.IsVisible = false;

                switch (mod_i_information)
                {
                    case 1:
                        summ = summ - 58000;
                        Sum_imput.Text = "Текушяя цена   " + summ;
                        break;
                    case 2:
                        summ = summ - 46000;
                        Sum_imput.Text = "Текушяя цена   " + summ;
                        break;
                    case 3:
                        summ = summ - 70000;
                        Sum_imput.Text = "Текушяя цена   " + summ;
                        break;
                    case 4:
                        summ = summ - 38000;
                        Sum_imput.Text = "Текушяя цена   " + summ;
                        break;
                    case 5:
                        summ = summ - 50000;
                        Sum_imput.Text = "Текушяя цена   " + summ;
                        break;
                }
            }  
        }
        private void Kofe_2(object sender, EventArgs e)
        {
            if (mod_1 == 0)
            {
                mod_1 = 1;
                Kofe_02.BackgroundColor = Colors.Violet;
                Kofe_info_1.IsVisible = true;
                Kofe_02.IsVisible = false;
                Kofe_03.IsVisible = false;
                Kofe_04.IsVisible = false;
                Kofe_05.IsVisible = false;

                Kofe_lible_02.IsVisible = false;
                Kofe_lible_03.IsVisible = false;
                Kofe_lible_04.IsVisible = false;
                Kofe_lible_05.IsVisible = false;
                Kofe_lible_01.Text = "Café Pushkin                                    46000 р.";
                Kofe_info_1.Text = "Ресторанов, который предлагает своим гостям атмосферу старинной русской культуры и высококачественную кухню. Заведение расположено в историческом здании и оформлено в стиле, напоминающем о начале XX века.";
                mod_0 = 1;
                Kofe_01.BackgroundColor = Colors.Violet;

                fixsed_2.Spacing = 0;
                fixsed_3.Spacing = 0;
                fixsed_4.Spacing = 0;
                fixsed_5.Spacing = 0;

                mod_i_information = 2;

                kuhna_01.IsVisible = true;
                kuhna_02.IsVisible = true;
                kuhna_03.IsVisible = true;
                kuhna_04.IsVisible = true;
                kuhna_05.IsVisible = true;

                kuhna_1.IsVisible = true;
                kuhna_2.IsVisible = true;
                kuhna_3.IsVisible = true;
                kuhna_4.IsVisible = true;
                kuhna_5.IsVisible = true;

                summ = summ + 46000;
                Sum_imput.Text = "Текушяя цена   " + summ;

                kuhna_01.Text = "Селедка под шубой                                        ." + Environment.NewLine + "15300 р.";
                kuhna_02.Text = "Блины с различными начинками              ." + Environment.NewLine + "7350 р.";
                kuhna_03.Text = "Рассольник                                                       ." + Environment.NewLine + "6500 р.";
                kuhna_04.Text = "Пельмени с мясом                                         ." + Environment.NewLine + "8700 р.";
                kuhna_05.Text = "Алкоголь                                                           ." + Environment.NewLine + "7600 р.";

            }

        }
        private void Kofe_3(object sender, EventArgs e)
        {
            if (mod_2 == 0)
            {
                mod_2 = 1;
                Kofe_03.BackgroundColor = Colors.Violet;
                Kofe_info_1.IsVisible = true;
                Kofe_02.IsVisible = false;
                Kofe_03.IsVisible = false;
                Kofe_04.IsVisible = false;
                Kofe_05.IsVisible = false;

                Kofe_lible_02.IsVisible = false;
                Kofe_lible_03.IsVisible = false;
                Kofe_lible_04.IsVisible = false;
                Kofe_lible_05.IsVisible = false;
                Kofe_lible_01.Text = "Beluga                                               70000 р.";
                Kofe_info_1.Text = "Заведение, которое предлагает своим гостям разнообразные блюда русской кухни, а также широкий выбор водки и других напитков. Он расположен в центре города и часто привлекает как местных жителей, так и туристов.";
                mod_0 = 1;
                Kofe_01.BackgroundColor = Colors.Violet;

                fixsed_2.Spacing = 0;
                fixsed_3.Spacing = 0;
                fixsed_4.Spacing = 0;
                fixsed_5.Spacing = 0;

                mod_i_information = 3;

                kuhna_01.IsVisible = true;
                kuhna_02.IsVisible = true;
                kuhna_03.IsVisible = true;
                kuhna_04.IsVisible = true;
                kuhna_05.IsVisible = true;

                kuhna_1.IsVisible = true;
                kuhna_2.IsVisible = true;
                kuhna_3.IsVisible = true;
                kuhna_4.IsVisible = true;
                kuhna_5.IsVisible = true;

                summ = summ + 70000;
                Sum_imput.Text = "Текушяя цена   " + summ;

                kuhna_01.Text = "Традиционные русские сладости              ." + Environment.NewLine + "8000 р.";
                kuhna_02.Text = "Тартар из рыбы или мяса                           ." + Environment.NewLine + "14700 р.";
                kuhna_03.Text = "Рассольник                                                      ." + Environment.NewLine + "13300 р.";
                kuhna_04.Text = "Пельмени с мясом                                         ." + Environment.NewLine + "11500 р.";
                kuhna_05.Text = "Вина                                                                  ." + Environment.NewLine + "8500 р.";
            }

        }
        private void Kofe_4(object sender, EventArgs e)
        {
            if (mod_3 == 0)
            {
                mod_3 = 1;
                Kofe_04.BackgroundColor = Colors.Violet;
                Kofe_info_1.IsVisible = true;
                Kofe_02.IsVisible = false;
                Kofe_03.IsVisible = false;
                Kofe_04.IsVisible = false;
                Kofe_05.IsVisible = false;

                Kofe_lible_02.IsVisible = false;
                Kofe_lible_03.IsVisible = false;
                Kofe_lible_04.IsVisible = false;
                Kofe_lible_05.IsVisible = false;
                Kofe_lible_01.Text = "Ketch Up                                           38000 р.";
                Kofe_info_1.Text = "Это заведение, которое предлагает разнообразное меню с акцентом на современные интерпретации классических блюд. Ресторан может быть известен своей атмосферой, стильным интерьером и качественным обслуживанием.";
                mod_0 = 1;
                Kofe_01.BackgroundColor = Colors.Violet;

                fixsed_2.Spacing = 0;
                fixsed_3.Spacing = 0;
                fixsed_4.Spacing = 0;
                fixsed_5.Spacing = 0;

                mod_i_information = 4;

                kuhna_01.IsVisible = true;
                kuhna_02.IsVisible = true;
                kuhna_03.IsVisible = true;
                kuhna_04.IsVisible = true;
                kuhna_05.IsVisible = true;

                kuhna_1.IsVisible = true;
                kuhna_2.IsVisible = true;
                kuhna_3.IsVisible = true;
                kuhna_4.IsVisible = true;
                kuhna_5.IsVisible = true;

                summ = summ + 38000;
                Sum_imput.Text = "Текушяя цена   " + summ;

                kuhna_01.Text = "Традиционные русские сладости              ." + Environment.NewLine + "20000 р.";
                kuhna_02.Text = "Блины с различными начинками              ." + Environment.NewLine + "15000 р.";
                kuhna_03.Text = "Салаты с сезонными ингредиентами       ." + Environment.NewLine + "10000 р.";
                kuhna_04.Text = "Пельмени с мясом                                         ." + Environment.NewLine + "18500 р.";
                kuhna_05.Text = "Алкоголь                                                           ." + Environment.NewLine + "12300 р.";
            }

        }
        private void Kofe_5(object sender, EventArgs e)
        {
            if (mod_4 == 0)
            {
                mod_4 = 1;
                Kofe_05.BackgroundColor = Colors.Violet;
                Kofe_info_1.IsVisible = true;
                Kofe_02.IsVisible = false;
                Kofe_03.IsVisible = false;
                Kofe_04.IsVisible = false;
                Kofe_05.IsVisible = false;

                Kofe_lible_02.IsVisible = false;
                Kofe_lible_03.IsVisible = false;
                Kofe_lible_04.IsVisible = false;
                Kofe_lible_05.IsVisible = false;
                Kofe_lible_01.Text = "Moscow City Grill                            50000 р.";
                Kofe_info_1.Text = "Ресторан, который предлагает разнообразное меню с акцентом на блюда, приготовленные на гриле. Заведение может быть популярным как среди местных жителей, так и среди туристов благодаря своему разнообразному меню и уютной атмосфере.";
                mod_0 = 1;
                Kofe_01.BackgroundColor = Colors.Violet;

                fixsed_2.Spacing = 0;
                fixsed_3.Spacing = 0;
                fixsed_4.Spacing = 0;
                fixsed_5.Spacing = 0;

                mod_i_information = 5;

                kuhna_01.IsVisible = true;
                kuhna_02.IsVisible = true;
                kuhna_03.IsVisible = true;
                kuhna_04.IsVisible = true;
                kuhna_05.IsVisible = true;

                kuhna_1.IsVisible = true;
                kuhna_2.IsVisible = true;
                kuhna_3.IsVisible = true;
                kuhna_4.IsVisible = true;
                kuhna_5.IsVisible = true;

                summ = summ + 50000;
                Sum_imput.Text = "Текушяя цена   " + summ;

                kuhna_01.Text = "Селедка под шубой                                        ." + Environment.NewLine + "17000 р.";
                kuhna_02.Text = "Рыба, запеченная с травами и лимоном ." + Environment.NewLine + "7000 р.";
                kuhna_03.Text = "Рассольник                                                       ." + Environment.NewLine + "8500 р.";
                kuhna_04.Text = "Тартар из рыбы или мяса                            ." + Environment.NewLine + "15600 р.";
                kuhna_05.Text = "Алкоголь                                                           ." + Environment.NewLine + "15000 р.";
            }

        }
        private void kuhna_01_(object sender, EventArgs e)
        {
            if (kuhna_1_ == 0)
            {
                kuhna_1.BackgroundColor = Colors.Violet;
                kuhna_1_ = 1;
                switch (mod_i_information)
                {
                    case 1:
                        summ = summ + 13560;
                        Sum_imput.Text = "Текушяя цена   " + summ;
                        break;
                    case 2:
                        summ = summ + 20000;
                        Sum_imput.Text = "Текушяя цена   " + summ;
                        break;
                    case 3:
                        summ = summ + 15300;
                        Sum_imput.Text = "Текушяя цена   " + summ;
                        break;
                    case 4:
                        summ = summ + 8000;
                        Sum_imput.Text = "Текушяя цена   " + summ;
                        break;
                    case 5:
                        summ = summ + 17000;
                        Sum_imput.Text = "Текушяя цена   " + summ;
                        break;


                }
            }
            else
            {
                switch (mod_i_information)
                {
                    case 1:
                        summ = summ - 13560;
                        Sum_imput.Text = "Текушяя цена   " + summ;
                        break;
                    case 2:
                        summ = summ - 20000;
                        Sum_imput.Text = "Текушяя цена   " + summ;
                        break;
                    case 3:
                        summ = summ - 15300;
                        Sum_imput.Text = "Текушяя цена   " + summ;
                        break;
                    case 4:
                        summ = summ - 8000;
                        Sum_imput.Text = "Текушяя цена   " + summ;
                        break;
                    case 5:
                        summ = summ - 17000;
                        Sum_imput.Text = "Текушяя цена   " + summ;
                        break;
                }
                kuhna_1.BackgroundColor = Colors.Grey;
                kuhna_1_ = 0;
            }
        }
        private void kuhna_02_(object sender, EventArgs e)
        {
            if (kuhna_2_ == 0)
            {
                switch (mod_i_information)
                {
                    case 1:
                        summ = summ + 20200;
                        Sum_imput.Text = "Текушяя цена   " + summ;
                        break;
                    case 2:
                        summ = summ + 15000;
                        Sum_imput.Text = "Текушяя цена   " + summ;
                        break;
                    case 3:
                        summ = summ + 7350;
                        Sum_imput.Text = "Текушяя цена   " + summ;
                        break;
                    case 4:
                        summ = summ + 14700;
                        Sum_imput.Text = "Текушяя цена   " + summ;
                        break;
                    case 5:
                        summ = summ + 7000;
                        Sum_imput.Text = "Текушяя цена   " + summ;
                        break;
                }
                kuhna_2.BackgroundColor = Colors.Violet;
                kuhna_2_ = 1;
            }
            else
            {
                kuhna_2.BackgroundColor = Colors.Grey;
                kuhna_2_ = 0;

                switch (mod_i_information)
                {
                    case 1:
                        summ = summ - 20200;
                        Sum_imput.Text = "Текушяя цена   " + summ;
                        break;
                    case 2:
                        summ = summ - 15000;
                        Sum_imput.Text = "Текушяя цена   " + summ;
                        break;
                    case 3:
                        summ = summ - 7350;
                        Sum_imput.Text = "Текушяя цена   " + summ;
                        break;
                    case 4:
                        summ = summ - 14700;
                        Sum_imput.Text = "Текушяя цена   " + summ;
                        break;
                    case 5:
                        summ = summ - 7000;
                        Sum_imput.Text = "Текушяя цена   " + summ;
                        break;
                }
            }
        }

        private void kuhna_03_(object sender, EventArgs e)
        {
            if (kuhna_3_ == 0)
            {
                kuhna_3.BackgroundColor = Colors.Violet;
                kuhna_3_ = 1;

                switch (mod_i_information)
                {
                    case 1:
                        summ = summ + 7000;
                        Sum_imput.Text = "Текушяя цена   " + summ;
                        break;
                    case 2:
                        summ = summ + 10000;
                        Sum_imput.Text = "Текушяя цена   " + summ;
                        break;
                    case 3:
                        summ = summ + 6500;
                        Sum_imput.Text = "Текушяя цена   " + summ;
                        break;
                    case 4:
                        summ = summ + 13300;
                        Sum_imput.Text = "Текушяя цена   " + summ;
                        break;
                    case 5:
                        summ = summ + 8500;
                        Sum_imput.Text = "Текушяя цена   " + summ;
                        break;
                }
            }
            else
            {
                kuhna_3.BackgroundColor = Colors.Grey;
                kuhna_3_ = 0;

                switch (mod_i_information)
                {
                    case 1:
                        summ = summ - 7000;
                        Sum_imput.Text = "Текушяя цена   " + summ;
                        break;
                    case 2:
                        summ = summ - 10000;
                        Sum_imput.Text = "Текушяя цена   " + summ;
                        break;
                    case 3:
                        summ = summ - 6500;
                        Sum_imput.Text = "Текушяя цена   " + summ;
                        break;
                    case 4:
                        summ = summ - 13300;
                        Sum_imput.Text = "Текушяя цена   " + summ;
                        break;
                    case 5:
                        summ = summ - 8500;
                        Sum_imput.Text = "Текушяя цена   " + summ;
                        break;
                }
            }
        }

        private void kuhna_04_(object sender, EventArgs e)
        {
            if (kuhna_4_ == 0)
            {
                kuhna_4.BackgroundColor = Colors.Violet;
                kuhna_4_ = 1;

                switch (mod_i_information)
                {
                    case 1:
                        summ = summ + 16000;
                        Sum_imput.Text = "Текушяя цена   " + summ;
                        break;
                    case 2:
                        summ = summ + 18500;
                        Sum_imput.Text = "Текушяя цена   " + summ;
                        break;
                    case 3:
                        summ = summ + 8700;
                        Sum_imput.Text = "Текушяя цена   " + summ;
                        break;
                    case 4:
                        summ = summ + 11500;
                        Sum_imput.Text = "Текушяя цена   " + summ;
                        break;
                    case 5:
                        summ = summ + 15600;
                        Sum_imput.Text = "Текушяя цена   " + summ;
                        break;
                }
            }
            else
            {
                switch (mod_i_information)
                {
                    case 1:
                        summ = summ - 16000;
                        Sum_imput.Text = "Текушяя цена   " + summ;
                        break;
                    case 2:
                        summ = summ - 18500;
                        Sum_imput.Text = "Текушяя цена   " + summ;
                        break;
                    case 3:
                        summ = summ - 8700;
                        Sum_imput.Text = "Текушяя цена   " + summ;
                        break;
                    case 4:
                        summ = summ - 11500;
                        Sum_imput.Text = "Текушяя цена   " + summ;
                        break;
                    case 5:
                        summ = summ - 15600;
                        Sum_imput.Text = "Текушяя цена   " + summ;
                        break;
                }
                kuhna_4.BackgroundColor = Colors.Grey;
                kuhna_4_ = 0;
            }
        }

        private void kuhna_05_(object sender, EventArgs e)
        {
            if (kuhna_5_ == 0)
            {
                kuhna_5.BackgroundColor = Colors.Violet;
                kuhna_5_ = 1;

                switch (mod_i_information)
                {
                    case 1:
                        summ = summ + 7500;
                        Sum_imput.Text = "Текушяя цена   " + summ;
                        break;
                    case 2:
                        summ = summ + 12300;
                        Sum_imput.Text = "Текушяя цена   " + summ;
                        break;
                    case 3:
                        summ = summ + 7600;
                        Sum_imput.Text = "Текушяя цена   " + summ;
                        break;
                    case 4:
                        summ = summ + 8500;
                        Sum_imput.Text = "Текушяя цена   " + summ;
                        break;
                    case 5:
                        summ = summ + 15000;
                        Sum_imput.Text = "Текушяя цена   " + summ;
                        break;
                }
            }
            else
            {
                switch (mod_i_information)
                {
                    case 1:
                        summ = summ - 7500;
                        Sum_imput.Text = "Текушяя цена   " + summ;
                        break;
                    case 2:
                        summ = summ - 12300;
                        Sum_imput.Text = "Текушяя цена   " + summ;
                        break;
                    case 3:
                        summ = summ - 7600;
                        Sum_imput.Text = "Текушяя цена   " + summ;
                        break;
                    case 4:
                        summ = summ - 8500;
                        Sum_imput.Text = "Текушяя цена   " + summ;
                        break;
                    case 5:
                        summ = summ - 15000;
                        Sum_imput.Text = "Текушяя цена   " + summ;
                        break;
                }
                kuhna_5.BackgroundColor = Colors.Grey;
                kuhna_5_ = 0;


            }
        }
        private void trabsport_01_(object sender, EventArgs e)
        {
            if (mod_10 == 0)
            {
                trabsport_1.BackgroundColor = Colors.Violet;
                mod_10 = 1;
                mod_d_information = 1;
                trabsport_02.IsVisible = false;
                trabsport_03.IsVisible = false;
                trabsport_04.IsVisible = false;
                trabsport_05.IsVisible = false;

                trabsport_2.IsVisible = false;
                trabsport_3.IsVisible = false;
                trabsport_4.IsVisible = false;
                trabsport_5.IsVisible = false;

                summ = summ + 39000;
                Sum_imput.Text = "Текушяя цена   " + summ;
            }
            else
            {
                trabsport_1.BackgroundColor = Colors.Grey;
                mod_10 = 0;

                trabsport_02.IsVisible = true;
                trabsport_03.IsVisible = true;
                trabsport_04.IsVisible = true;
                trabsport_05.IsVisible = true;

                trabsport_2.IsVisible = true;
                trabsport_3.IsVisible = true;
                trabsport_4.IsVisible = true;
                trabsport_5.IsVisible = true;
                trabsport_01.Text = "Мерседес W221                             39000 р.";
                switch (mod_d_information)
                {
                    case 1:
                        summ = summ - 39000;
                        Sum_imput.Text = "Текушяя цена   " + summ;
                        break;
                    case 2:
                        summ = summ - 38000;
                        Sum_imput.Text = "Текушяя цена   " + summ;
                        break;
                    case 3:
                        summ = summ - 46000;
                        Sum_imput.Text = "Текушяя цена   " + summ;
                        break;
                    case 4:
                        summ = summ - 48000;
                        Sum_imput.Text = "Текушяя цена   " + summ;
                        break;
                    case 5:
                        summ = summ - 55000;
                        Sum_imput.Text = "Текушяя цена   " + summ;
                        break;
                }
            }
        }
        private void trabsport_02_(object sender, EventArgs e)
        {
            trabsport_1.BackgroundColor = Colors.Violet;
            mod_10 = 1;
            mod_11 = 1;
                mod_d_information = 2;
            trabsport_02.IsVisible = false;
            trabsport_03.IsVisible = false;
            trabsport_04.IsVisible = false;
            trabsport_05.IsVisible = false;

            trabsport_2.IsVisible = false;
            trabsport_3.IsVisible = false;
            trabsport_4.IsVisible = false;
            trabsport_5.IsVisible = false;

            trabsport_01.Text = "BMW E65                                         38000 р.";
            summ = summ + 38000;
            Sum_imput.Text = "Текушяя цена   " + summ;

        }

        private void trabsport_03_(object sender, EventArgs e)
        {
            trabsport_1.BackgroundColor = Colors.Violet;
            mod_10 = 1;
            mod_12 = 1;
                mod_d_information = 3;
            trabsport_02.IsVisible = false;
            trabsport_03.IsVisible = false;
            trabsport_04.IsVisible = false;
            trabsport_05.IsVisible = false;

            trabsport_2.IsVisible = false;
            trabsport_3.IsVisible = false;
            trabsport_4.IsVisible = false;
            trabsport_5.IsVisible = false;

            trabsport_01.Text = "Ауди А8                                            46000 р.";
            summ = summ + 46000;
            Sum_imput.Text = "Текушяя цена   " + summ;
        }

        private void trabsport_04_(object sender, EventArgs e)
        {
            trabsport_1.BackgroundColor = Colors.Violet;
            mod_10 = 1;
            mod_13 = 1;
                mod_d_information = 4;
            trabsport_02.IsVisible = false;
            trabsport_03.IsVisible = false;
            trabsport_04.IsVisible = false;
            trabsport_05.IsVisible = false;

            trabsport_2.IsVisible = false;
            trabsport_3.IsVisible = false;
            trabsport_4.IsVisible = false;
            trabsport_5.IsVisible = false;

            trabsport_01.Text = "БМВ E46                                           48000 р.";

            summ = summ + 48000;
            Sum_imput.Text = "Текушяя цена   " + summ;
        }

        private void trabsport_05_(object sender, EventArgs e)
        {
            trabsport_1.BackgroundColor = Colors.Violet;
            mod_10 = 1;
            mod_14 = 1;
                mod_d_information = 5;
            trabsport_02.IsVisible = false;
            trabsport_03.IsVisible = false;
            trabsport_04.IsVisible = false;
            trabsport_05.IsVisible = false;

            trabsport_2.IsVisible = false;
            trabsport_3.IsVisible = false;
            trabsport_4.IsVisible = false;
            trabsport_5.IsVisible = false;

            trabsport_01.Text = "Крайслер 300С                               55000 р.";
            summ = summ + 55000;
            Sum_imput.Text = "Текушяя цена   " + summ;
        }
    }

}
