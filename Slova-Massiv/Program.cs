using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slova_Massiv
{
    class Program
    {
        static void Main(string[] args)
        {
            ///http://qrcoder.ru/code/?Liturgy+of+Activation%0D%0A%0D%0AI+convert+this+instrument+of+art%2C%0D%0ATo+breathe+in+electronic+breathe%0D%0ATo+convulse+in+sonic+wave%0D%0AThat+which+thou+desirest+is+accomplished%2C%0D%0Abe+thy+will+performed%2C%0D%0Aand+all+mine+demands+fulfilled.%0D%0Agrant+that+unto+succour%2C+favour+and+unison%2C%0D%0Aby+the+Invocation+of+thy+Holy+Name%2C%0D%0Aso+that+these+things+may+serve+us+for+aid+in+all+that+we+wish+to+perform+therewith%0D%0A%0D%0ARite+of+Re-Activation%0D%0A%0D%0AI+conjure+thee+anew%0D%0Aby+the+Holy+and+Indivisible+Name+of+Omnissiah%0D%0AI+exhort+you%0D%0Athat+none+move+from+thy+appointed+stations%0D%0ABe+thou+regenerate%2C+cleansed%2C+and+purified%2C%0D%0AHear+ye%2C+and+be+ye+ready%2C%0D%0Athrough+which+may+I+conduct+unto+the+desired+end%0D%0Athose+things+which+I+ardently+wish%0D%0ASuscitatio+quod+pulse.&4&0

            Console.WriteLine("Вводится Массив Слов | Выберите что необходимо с ним сделать:");
            Console.WriteLine("а) Найти 2 повторно идущих слова в предложении");
            Console.WriteLine("б) Начать все предложения с Большой буквы [Бета]");
            Console.WriteLine("в) Убрать все лишние пробелы в Тексте");
            string variant = Console.ReadLine();

            if (variant == "а")
            {
                Console.WriteLine(" Будте добры, введите Ваш массив слов ");
                string text = Console.ReadLine();
                var sb = new StringBuilder(text);
                var words = new Dictionary<String, int>();
                var word = new StringBuilder();
                for (var i = 0; i < sb.Length; i++)
                {
                    if (sb[i] == ' ')
                    {
                        if (word.Length != 0)
                            if (words.ContainsKey(word.ToString()))
                            {
                                var count = ++words[word.ToString()];
                                if (count == 3)
                                {
                                    Console.WriteLine("Больше двух");
                                    Console.ReadKey();
                                }
                            }
                            else
                            {
                                words.Add(word.ToString(), 1);
                                word.Clear();
                            }
                        continue;
                    }
                    word.Append(sb[i]);
                }
                var result = words.FirstOrDefault(c => c.Value == 2).Key;



                
                var resultMsg = result ?? "Нету одинаковых";
                Console.WriteLine("Повторяющиеся слова " + resultMsg);
                Console.ReadKey();
            }


            if (variant == "б")
            {
                string[] string2 = {"Я быстро смазал краску будня",   //На самом деле можно сделать нормально, 
                                "плеснувши краску из стакана.",  // но в час ночи не особо думается, сделал как сделал, 
                                  "Я показал на блюде студня",  //если нужно сделать по нормальному переделаю
                                     "косые скулы океана"};
                StringBuilder sb1;
                for (int i = 0; i < string2.Length; i++)
                {
                    sb1 = new StringBuilder();
                    sb1.Append(string2[i].TrimStart());
                    sb1[0] = Char.ToUpper(sb1[0]);
                    string2[i] = sb1.ToString();
                    Console.WriteLine(string2[i]);
                    Console.ReadKey();
                }
            }

            if (variant == "в")
            {
                Console.WriteLine(" Будте добры, введите Ваш массив слов ");
                string text = Console.ReadLine();
                StringBuilder sb1;
                for (int i = 0; i < text.Length; i++)
                {
                    sb1 = new StringBuilder();

                    text = System.Text.RegularExpressions.Regex.Replace(text, @"\s+", " ");

                    Console.WriteLine(text);
                    Console.ReadKey();

                }
            }
        }
    }
}

