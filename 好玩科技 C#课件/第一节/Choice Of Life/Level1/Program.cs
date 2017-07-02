using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  第一关  起点
            Console.WriteLine("这是一个关于抉择的故事，人生的十字路口，你总是面临各种抉择...");
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine("而你的每个抉择，都决定了你现在的样子.");
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine("现在我们来重复一遍浪仔的人生，看看他关于人生的抉择...");
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine("........................................................................................................");
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine("........................................................................................................");
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine("........................................................................................................");
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine("2008年6月，四川汶川地震发生的那段日子，是一段爱心和伤痛交织的日子，在河南的一个小村子里，浪仔面临着人生的第一个抉择:");
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine("上了半年的大学，已经在5个月前办了退学手续，再也回不去了，人生路上再也没有人给浪仔任何指引。");
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine("只留下一个宅基地，宅基地上的几间破房子，几亩薄田和一堆债务...");
            Console.WriteLine();
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("现在浪仔面临3个选择：\n");
            Console.WriteLine("1.留在家里种地,靠勤劳致富，把日子过起来！！！\n");
            Console.WriteLine("2.跟其他人去外地打工，出去创一片新天地...\n");
            Console.WriteLine("3.统招的大学上不了，可以去上成人自考，还是要把学业继续下去。\n");
            Console.WriteLine("面对人生的十字路口，请你帮浪仔拿一个主意，记住你的选择会改变浪仔的一生\n");
            Console.WriteLine("请输入1、2、3，来帮浪仔拿一个主意:\n");

            int i = int.Parse(Console.ReadLine());
            if (1 == i)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("浪仔选择了在家务农，在农田里抛洒了十年的汗水，终于把外债还清了，现在他准备再包十亩地，挣一个娶媳妇的彩礼钱。。。。\n");
                Console.ReadKey();
                Console.WriteLine("看来浪仔的生活再无其他的变数，只能年复一年的种地攒钱了,你给浪仔选择的人生不能再有趣一些吗？\n");
                Console.ReadKey();
                Console.WriteLine("你的选择导致游戏浪仔的人生了无生趣，游戏结束了，你是个乏味的抉择者\n");
                Console.ReadKey();
                return;
            }
            else if (2 == i)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("浪仔选择了在南方的电子加工厂进行一些电子产品的组装,挣到的钱仅仅够交上每个月的房租和简单的吃穿。\n");
                Console.ReadKey();
                Console.WriteLine("老家的债主越催越紧，浪仔正在考虑是不是卖掉老家的房子来抵债。。。\n");
                Console.ReadKey();
                Console.WriteLine("越来越重的生活压力之下，浪仔的人生不是在苦闷中沉沦，就是去学人家当个小混混了...\n");
                Console.ReadKey();
                Console.WriteLine("你的抉择毁了浪仔的一生,游戏结束了,你是个糟糕的抉择者\n");
                Console.ReadKey();
                return;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("浪仔变卖了家里所有的宅基地，还清了家里的债务，选择了去了一家号称能帮他完成大学梦的学校\n");
                Console.WriteLine("可怜的浪仔，等待他的是再圆大学梦的康庄大道，还是一个让他一无所有的骗局？？？？\n");
                Console.WriteLine("你的选择让浪仔有了一个再上大学的机会，但是假如生命欺骗了你呢？欢迎来到第二关，继续为浪仔的人生进行抉择\n\n\n\n");
                Console.ReadKey();
            }
            Console.WriteLine();
            Console.ReadKey();
            #endregion
        }
    }
}
