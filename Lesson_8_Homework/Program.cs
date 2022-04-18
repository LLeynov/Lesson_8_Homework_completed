using System;
using Lesson_8_Homework.Properties;
using Lev_helloproj_library;



namespace Lesson_8_Homework
{
    internal class Program
    {
        //Выполнено! (Создать консольное приложение, которое при старте выводит приветствие, записанное в настройках
        //приложения(application-scope)). Запросить у пользователя имя, возраст и род деятельности, а затем сохранить данные в настройках.
        //При следующем запуске отобразить эти сведения.Задать приложению версию и описание.

        static void Main(string[] args)
        {
            String strVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            Console.Title = Settings.Default.ApplicationName + " , Version : " + strVersion + " P.s сам версию поставил)";
            Console.WriteLine(Settings.Default.Hello);
            Utils.PrintInfoLev(8, "Лейнов Лев Максимович.");


            Console.WriteLine(Settings.Default.Username + " - имя текущего пользователя.");
            Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
            Console.WriteLine(Settings.Default.Userage + " - возраст текущего пользователя. ");

            Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
            Console.WriteLine(Settings.Default.UserRabota + " - место работы текущего пользователя. ");
            Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");

            //Запрашиваем имя текущего пользователя для сохранения и последующего вывода. 
            Console.WriteLine("Как Вас зовут?");
            Settings.Default.Username = Console.ReadLine();

            //Запрашиваем возраст текущего пользователя для сохранения и последующего вывода.
            Console.WriteLine("А сколько Вам лет?");
            Settings.Default.Userage = int.Parse(Console.ReadLine());

            //Запрашиваем место работы текущего пользователя для сохранения и последующего вывода.
            Console.WriteLine("А где вы работаете? ");
            Settings.Default.UserRabota = (Console.ReadLine());
            Settings.Default.Save(); //Сохраняем настройки.

        }

    }
}



