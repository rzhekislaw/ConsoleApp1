namespace ns
{
    class tClass
    {
        public static void Main()
        {
            string decision1 = "";
            string decision2 = "";
            string decision3 = "";
            string decision4 = "";
            List<string> statuses = new List<string>();

            Console.WriteLine("Почалось");
            Console.WriteLine("Ти стоїш перед трьома воротами, кожне з яких веде у різний район загубленого міста.\nОбирай куди підеш:\n1 - Ліс\n2 - Магазин\n3 - Замок");
            var input1 = Console.ReadLine();
            if(input1 == "1" || input1 == "Ліс")
            {
                decision1 = "Forest";
                Console.WriteLine("Пішли до лісу");
            }
            else if (input1 == "2" || input1 == "Магазин")
            {
                decision1 = "Shop";
                Console.WriteLine("Пішли у магазин");
            }
            else if(input1 == "3" || input1 == "Замок")
            {
                decision1 = "Castle";
                Console.WriteLine("Пішли до замку");
            }
            else
            {
                Console.WriteLine("Шось не туди ти повернув. Спробуй ще раз");
                Console.WriteLine("Ти стоїш перед трьома воротами, кожне з яких веде у різний район загубленого міста.\nОбирай куди підеш:\n1 - Ліс\n2 - Магазин\n3 - Замок");
                input1 = Console.ReadLine();
                if (input1 == "1" || input1 == "Ліс")
                {
                    decision1 = "Forest";
                    Console.WriteLine("Пішли до лісу");
                }
                else if (input1 == "2" || input1 == "Магазин")
                {
                    decision1 = "Shop";
                    Console.WriteLine("Пішли у магазин");
                }
                else if (input1 == "3" || input1 == "Замок")
                {
                    decision1 = "Castle";
                    Console.WriteLine("Пішли до замку");
                }
                else
                {
                    Console.WriteLine("Мда, не повезло. GG");
                    Console.ReadLine();
                    return;
                }
            }
            if(decision1 == "Forest")
            {
                Console.WriteLine("Ну шо, ось ти і у лісі. Шо робитимемо далі?\n1 - Підем на свинів полювати\n2 - Порубаємо дрова\n3 - Нічого");
                var input2 = Console.ReadLine();
                if (input2 == "1" || input2 == "Підем на свинів полювати" || input2 == "Свині")
                {
                    decision2 = "Hunt";
                    Console.WriteLine("Ну пішли");
                    Console.WriteLine("Свиня сама вийшла на полювання і загнала тебе на дерево, де було гніздо бджіл.\nВони тебе погризли і ти впав в обійми ведмедя.\nВін цього не оцінив");
                    Console.WriteLine("Отримано статус: Натураліст");
                    statuses.Add("Натураліст");
                    return;
                }
                else if (input2 == "2" || input2 == "Порубаємо дрова" || input2 == "Дрова")
                {
                    decision2 = "Woods";
                    Console.WriteLine("Діставай сокиру");
                    Console.WriteLine("Ти так захопився, що прорубав наскрізь печеру, в якій була чиясь ничка.\nХазяїн тої нички був не у захваті, але твоя сокира таки вмовила його завалити і звалити, а тобі дісталося трохи гривень і файний рєжик");
                    Console.WriteLine("Отримано статус: Дипломат");
                    statuses.Add("Дипломат");
                }
                else if (input2 == "3" || input2 == "Нічого")
                {
                    decision2 = "Nothing in forest";
                    Console.WriteLine("Хто б сумнівався");
                    Console.WriteLine("Ну, ти просто лежав у тіні та жер малинку");
                }
                else
                {
                    Console.WriteLine("Промахнувсь. Спробуй ще раз");
                    Console.WriteLine("Ось ти і у лісі. Шо робитимемо далі?\n1 - Підем на свинів полювати\n2 - Порубаємо дрова\n3 - Нічого");
                    input2 = Console.ReadLine();
                    if (input2 == "1" || input2 == "Підем на свинів полювати" || input2 == "Свині")
                    {
                        decision2 = "Hunt";
                        Console.WriteLine("Ну пішли");
                        Console.WriteLine("Свиня сама вийшла на полювання і загнала тебе на дерево, де було гніздо бджіл.\nВони тебе погризли і ти впав в обійми ведмедя.\nВін цього не оцінив");
                        Console.WriteLine("Отримано статус: Натураліст");
                        statuses.Add("Натураліст");
                        return;
                    }
                    else if (input2 == "2" || input2 == "Порубаємо дрова" || input2 == "Дрова")
                    {
                        decision2 = "Woods";
                        Console.WriteLine("Діставай сокиру");
                        Console.WriteLine("Ти так захопився, що прорубав наскрізь печеру, в якій була чиясь ничка.\nХазяїн тої нички був не у захваті, але твоя сокира таки вмовила його завалити і звалити, а тобі дісталося трохи гривень і файний рєжик");
                        Console.WriteLine("Отримано статус: Дипломат");
                        statuses.Add("Дипломат");
                    }
                    else if (input2 == "3" || input2 == "Нічого")
                    {
                        decision2 = "Nothing in forest";
                        Console.WriteLine("Хто б сумнівався");
                        Console.WriteLine("Ну, ти просто лежав у тіні та жер малинку");
                    }
                    else
                    {
                        Console.WriteLine("Мда, не повезло. GG");
                        Console.ReadLine();
                        return;
                    }
                }
            }
            if (decision1 == "Shop")
            {
                Console.WriteLine("Прийшли в магаз. Шо берем?\n1 - Прикраси\n2 - Стару карту\n3 - Нічого");
                var input2 = Console.ReadLine();
                if (input2 == "1" || input2 == "Прикраси")
                {
                    decision2 = "Jewelry";
                    Console.WriteLine("Ну і нашо воно тобі треба?");
                    Console.WriteLine("Ще у магазині ти начепив на себе нову цяцьку. Через декілька кварталів тебе зустріли пара хлопців, \nякі ввічливо поцікавились за шмот, а ти і справді почав про свої кальсони і лапті.\nЗрештою, тебе відлупцювали та віджали цяцьку.\nА я питав, нашо воно тобі треба");
                    Console.WriteLine("Отримано статус: Моднік");
                    statuses.Add("Моднік");
                }
                else if (input2 == "2" || input2 == "Стару карту")
                {
                    decision2 = "Old map";
                    Console.WriteLine("Типу ти читати вмієш");
                    Console.WriteLine("Продавець виявився на диво товариським дідом, докинув зверху компас та пояснив як цим усім користуватись.\nЗа дідовим гайдом за 3 дні ти зміг таки дістатись до меж міста\nШо ж то там за місто таке?");

                }
                else if (input2 == "3" || input2 == "Нічого")
                {
                    decision2 = "Nothing in shop";
                    Console.WriteLine("А нашо тоді прийшли");
                    Console.WriteLine("Ти розвернувся і пішов туди, звідки прийшов. Ще один цікавий день позаду. Головне нічого не забути");
                }
                else
                {
                    Console.WriteLine("Промахнувсь. Спробуй ще раз");
                    Console.WriteLine("Ми в магазі. Шо берем?\n1 - Прикраси\n2 - Стару карту\n3 - Нічого");
                    input2 = Console.ReadLine();
                    if (input2 == "1" || input2 == "Прикраси")
                    {
                        decision2 = "Jewelry";
                        Console.WriteLine("Ну і нашо воно тобі треба?");
                        Console.WriteLine("Ще у магазині ти начепив на себе нову цяцьку. Через декілька кварталів тебе зустріли пара хлопців, \nякі ввічливо поцікавились за шмот, а ти і справді почав про свої кальсони і лапті.\nЗрештою, тебе відлупцювали та віджали цяцьку.\nА я питав, нашо воно тобі треба");
                        Console.WriteLine("Отримано статус: Моднік");
                        statuses.Add("Моднік");
                    }
                    else if (input2 == "2" || input2 == "Стару карту")
                    {
                        decision2 = "Old map";
                        Console.WriteLine("Типу ти читати вмієш");
                        Console.WriteLine("Продавець виявився на диво товариським дідом, докинув зверху компас та пояснив як цим усім користуватись.\nЗа дідовим гайдом за 3 дні ти зміг таки дістатись до меж міста\nШо ж то там за місто таке?");

                    }
                    else if (input2 == "3" || input2 == "Нічого")
                    {
                        decision2 = "Nothing in shop";
                        Console.WriteLine("А нашо тоді прийшли");
                        Console.WriteLine("Ти розвернувся і пішов туди, звідки прийшов. Такий насичений день позаду, розкажеш про нього онукам");
                    }
                    else
                    {
                        Console.WriteLine("Мда, не повезло. GG");
                        Console.ReadLine();
                        return;
                    }
                }
            }
            if (decision1 == "Castle")
            {
                Console.WriteLine("Ти підійшов до замку. Шо далі?\n1 - Пробратися в кімнату яку охороняють солдати\n2 - Поговорити з вельможою\n3 - Нічого");
                var input2 = Console.ReadLine();
                if (input2 == "1" || input2 == "Пробратися в кімнату яку охороняють солдати" || input2 == "Кімната")
                {
                    decision2 = "Guarded room";
                    Console.WriteLine("Головне не спалитись");
                    Console.WriteLine("Насправді, ця кімната лише називається кімнатою, що охороняється.\nТі солдати, що є, мирно сплять обпершись на свої алебарди.\nТи пробираєшся вглиб кімнати і знаходиш дорожню грамоту");
                    Console.WriteLine("Отримано статус: Сем Фішер");
                    statuses.Add("Сем Фішер");
                }
                else if (input2 == "2" || input2 == "Поговорити з вельможою" || input2 == "Вельможа")
                {
                    decision2 = "Nobleman";
                    Console.WriteLine("Тебе не пустили навіть до внутрішнього двору. Ти себе бачив? Куди тобі говорити з вельможою");
                }
                else if (input2 == "3" || input2 == "Нічого")
                {
                    decision2 = "Nothing in castle";
                    Console.WriteLine("Поки ти стояв під стіною і гадав думу, королівські діти кидали каміння зі стін у перехожих.\nОдним із них тобі прилетіло по макітрі. Наслідки очевидні");
                    Console.WriteLine("Мда, не повезло. GG");
                    return;
                }
                else
                {
                    Console.WriteLine("Промахнувсь. Спробуй ще раз");
                    Console.WriteLine("Ми в магазі. Шо берем?\n1 - Прикраси\n2 - Стару карту\n3 - Нічого");
                    input2 = Console.ReadLine();
                    if (input2 == "1" || input2 == "Пробратися в кімнату яку охороняють солдати" || input2 == "Кімната")
                    {
                        decision2 = "Guarded room";
                        Console.WriteLine("Головне не спалитись");
                        Console.WriteLine("Насправді, ця кімната лише називається кімнатою, що охороняється.\nТі солдати, що є, мирно сплять обпершись на свої алебарди.\nТи пробираєшся вглиб кімнати і знаходиш дорожню грамоту");
                        Console.WriteLine("Отримано статус: Сем Фішер");
                        statuses.Add("Сем Фішер");
                    }
                    else if (input2 == "2" || input2 == "Поговорити з вельможою" || input2 == "Вельможа")
                    {
                        decision2 = "Nobleman";
                        Console.WriteLine("Тебе не пустили навіть до внутрішнього двору. Ти себе бачив? Куди тобі говорити з вельможою");
                    }
                    else if (input2 == "3" || input2 == "Нічого")
                    {
                        decision2 = "Nothing in castle";
                        Console.WriteLine("Поки ти стояв під стіною і гадав думу, королівські діти кидали каміння зі стін у перехожих.\nОдним із них тобі прилетіло по макітрі. Наслідки очевидні");
                        Console.WriteLine("Мда, не повезло. GG");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Мда, не повезло. GG");
                        Console.ReadLine();
                        return;
                    }
                }
            }
            Console.WriteLine("Зрештою у тебе виникає питання: і як таки звалити з цього міста. Ти можеш:\n1 - Попитати місцевих\n2 - Продовжити шукати вихід самостійно");
            var input3 = Console.ReadLine();
            if(input3 == "1" || input3 == "Попитати місцевих")
            {
                decision3 = "Ask";
                Console.WriteLine("Ти зупиняєш якогось мужика, і:");
                Console.WriteLine("1 - Питаєш де вихід");
                if(decision2 == "Woods")
                {
                    Console.WriteLine("2 - Приставляєш йому рєжика до пуза і поясняєш, шо ти трохи втомився");
                    Console.WriteLine("3 - Пропонуєш заплатити за супровід до виходу");
                }
                var input4 = Console.ReadLine();
                if(input4 == "1" || input4 == "Питаєш де вихід")
                {
                    decision4 = "Ask";
                    Console.WriteLine("Мужик морозиться, де вихід то твої проблеми");
                    Console.WriteLine("Здається, ти залишишся тут назавжди");
                }
                if ((input4 == "2" || input4 == "Приставляєш йому рєжика до пуза і поясняєш, шо ти трохи втомився" || input4 == "Рєжик") && decision2 == "Woods")
                {
                    decision4 = "Knife";
                    Console.WriteLine("Мужик починає волати і звати охорону.\nВони-то і пояснили тобі, що тут так не прийнято.\nНайближчі 10 років ти проведеш за гратами");
                    Console.WriteLine("Здається, ти залишишся тут назавжди");
                }
                if ((input4 == "3" || input4 == "Пропонуєш заплатити за супровід до виходу" || input4 == "Заплатити") && decision2 == "Woods")
                {
                    decision4 = "Escort";
                    Console.WriteLine("Мужик не проти, але хоче гривнів. На щастя, вони в тебе є.\nВласне, він тебе проводить до виходу, ти віддаєш йому гривні та виходиш з міста підкупивши солдат");
                    Console.WriteLine("GG");
                    Console.ReadLine();
                }
            }
            else if(input3 == "2" || input3 == "Продовжити шукати вихід самостійно" || input3 == "Продовжити самостійно")
            {
                decision3 = "On your own";
                if(decision2 == "Old map")
                {
                    Console.WriteLine("Завдяки старій карті ти знаходиш діру у стіні міста і залишаєш його назавжди");
                    Console.WriteLine("GG");
                }
                else if(decision2 == "Guarded room")
                {
                    Console.WriteLine("Ти підходиш до солдата і показуєш йому грамоту.\nВиявляється, вони зобов'язані сприяти усім, хто має таку грамоту.\nВін проводжає тебе до воріт міста, де тебе навіть не зупиняють");
                    Console.WriteLine("GG");
                }
                else
                {
                    Console.WriteLine("Здається, ти вічно шукатимеш вихід і залишишся тут назавжди");
                }
            }
            else
            {
                Console.WriteLine("Промахнувсь. Спробуй ще раз");
                Console.WriteLine("Шо робим далі. Ти можеш:\n1 - Попитати місцевих\n2 - Продовжити шукати вихід самостійно");
                input3 = Console.ReadLine();
                if (input3 == "1" || input3 == "Попитати місцевих")
                {
                    decision3 = "Ask";
                    Console.WriteLine("Ти зупиняєш якогось мужика, і:");
                    Console.WriteLine("1 - Питаєш де вихід");
                    if (decision2 == "Woods")
                    {
                        Console.WriteLine("2 - Приставляєш йому рєжика до пуза і поясняєш, шо ти трохи втомився");
                        Console.WriteLine("3 - Пропонуєш заплатити за супровід до виходу");
                    }
                    var input4 = Console.ReadLine();
                    if (input4 == "1" || input4 == "Питаєш де вихід")
                    {
                        decision4 = "Ask";
                        Console.WriteLine("Мужик морозиться, де вихід то твої проблеми");
                        Console.WriteLine("Здається, ти залишишся тут назавжди");
                    }
                    if ((input4 == "2" || input4 == "Приставляєш йому рєжика до пуза і поясняєш, шо ти трохи втомився" || input4 == "Рєжик") && decision2 == "Woods")
                    {
                        decision4 = "Knife";
                        Console.WriteLine("Мужик починає волати і звати охорону.\nВони-то і пояснили тобі, що тут так не прийнято.\nНайближчі 10 років ти проведеш за гратами");
                        Console.WriteLine("Здається, ти залишишся тут назавжди");
                    }
                    if ((input4 == "3" || input4 == "Пропонуєш заплатити за супровід до виходу" || input4 == "Заплатити") && decision2 == "Woods")
                    {
                        decision4 = "Escort";
                        Console.WriteLine("Мужик не проти, але хоче гривнів. На щастя, вони в тебе є.\nВласне, він тебе проводить до виходу, ти віддаєш йому гривні та виходиш з міста підкупивши солдат");
                        Console.WriteLine("GG");
                        Console.ReadLine();
                    }
                }
                else if (input3 == "2" || input3 == "Продовжити шукати вихід самостійно" || input3 == "Продовжити самостійно")
                {
                    decision3 = "On your own";
                    if (decision2 == "Old map")
                    {
                        Console.WriteLine("Завдяки старій карті ти знаходиш діру у стіні міста і залишаєш його назавжди");
                        Console.WriteLine("GG");
                    }
                    else if (decision3 == "Guarded room")
                    {
                        Console.WriteLine("Ти підходиш до солдата і показуєш йому грамоту.\nВиявляється, вони зобов'язані сприяти усім, хто має таку грамоту.\nВін проводжає тебе до воріт міста, де тебе навіть не зупиняють");
                        Console.WriteLine("GG");
                    }
                    else
                    {
                        Console.WriteLine("Здається, ти вічно шукатимеш вихід і залишишся тут назавжди");
                    }
                }
                else
                {
                    Console.WriteLine("Мда, не повезло. GG");
                    Console.ReadLine();
                    return;
                }
            }

            Console.ReadLine();
        }
    }
}