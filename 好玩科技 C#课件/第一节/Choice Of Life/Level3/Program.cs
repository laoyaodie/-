using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 第三关 工作
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("第三关\n");
            Console.WriteLine("三年后,浪仔的媳妇终于完成了学业,而浪仔也在干活的间隙考过了成人高考的各门课程,现在该是去找工作的季节了\n");
            Console.ReadKey();
            Console.WriteLine("身边的同学有的回家继承了自家的商业帝国--包子铺,有人出去做了销售代表,还有人忙的团团转到处串招聘会...\n");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("浪仔家你是回不去了,培训你也没钱,下面的人生路你该怎么走,抉择者该你上场了...\n");
            Console.WriteLine("1.去做个销售吧,做销售干好了很挣钱的!!!\n");
            Console.WriteLine("2.找个培训机构再深造,学习几个月,出去就能拿高薪.\n");
            Console.WriteLine("3.买两本C++的书,自己好好看一下,自己做个东西出来再去找工作.\n");
            int iii = int.Parse(Console.ReadLine());
            if (1 == iii)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("想做销售,你还会来这里培训吗?你都不会做的选择凭啥给浪子?浪仔是不会听从你的劝告的\n");
                Console.ReadKey();
                Console.WriteLine("你不是一个实在人啊,你的游戏结束了,浪仔下线了");
                return;
            }
            else if (2 == iii)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("游戏玩到这里,你还不知道浪仔是个可怜的穷光蛋吗?他怎么可能有钱去培训?\n");
                Console.ReadKey();
                Console.WriteLine("不过浪仔听从了你学技术的建议,买了两本C++,自己学了起来");
                Console.ReadKey();
                Console.WriteLine("一个月后,浪仔学会了C++,学会了VC,自己做了个扫雷的游戏,走上了找工作的征程");
                Console.ReadKey();
                return;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("你是浪仔的知音啊,浪仔愉快的听从了你的建议,买了两本C++,愉快的看了起来\n");
                Console.ReadKey();
                Console.WriteLine("一个月后,浪仔学会了C++,学会了VC,自己做了个扫雷的游戏,走上了找工作的征程");
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("浪仔一波三折的找到了一家真正做软件的工作，由于没有学历，浪仔只能以高中生的身份进入这个行业，他的工资是八百\n");
            Console.ReadKey();
            Console.WriteLine("后来公司有找了几个本科生，浪仔由于有编程的经验，一直带着这几个本科生做公司的项目\n");
            Console.ReadKey();
            Console.WriteLine("偶然的一个机会，浪仔发现他带的几个本科生的工资是两千，而自己的公司还是稳定在八百没有懂的迹象。。。\n");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("如果你是浪仔，你该怎么办？决定浪仔生命轨迹的机会摆在你的面前...\n");
            Console.WriteLine("1.向公司要求加薪，我干的多，得的也应该多\n");
            Console.WriteLine("2.立马辞职，再找下一家公司.\n");
            Console.WriteLine("3.默默的干活,积攒经验，等待证明自己的机会.\n");
            int iiii = int.Parse(Console.ReadLine());
            if (1 == iiii)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("老板说你一个高中生屌什么屌，毫不犹豫的辞掉了浪仔...\n");
                Console.ReadKey();
                Console.WriteLine("可怜的浪仔因为你的抉择，失去了自己第一份工作，浪仔重进进入了找工作的人流中， 游戏结束。");
                return;
            }
            else if (2 == iiii)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("浪仔辞职了以后，进了另外一家公司，本来以为世界会更美好，但是浪仔可悲的发现，同样的情况再次发生了...\n");
                Console.ReadKey();
                Console.WriteLine("浪仔遭到二次的打击之后，对这个行业失去了信心，他感觉自己这个学历再也找不到好工作了...\n");
                Console.ReadKey();
                Console.WriteLine("浪仔最终放弃了软件开发这个行业，开始跑销售去了，他觉得销售这个不需要专业技能行业，不会再歧视他的学历。。。\n");
                Console.ReadKey();
                Console.WriteLine("浪仔开始闯荡他的商业帝国以后的人生，已经不是我们这里要讲的故事了，游戏结束。");
                Console.ReadKey();
                return;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("浪仔听从了你的劝告，选择了默默工作，半年后，他所在的项目圆满完成了，他的工作技能得到了所有人的认可。\n");
                Console.ReadKey();
                Console.WriteLine("就在浪仔的光芒再不会被任何事情所掩盖的时候，浪仔对公司提出了离职，公司把他的工资涨到了五千，但是浪仔还是离开了...\n");
                Console.ReadKey();
                Console.WriteLine("浪仔离开了郑州，到了南方一个城市，在那里他接触到了游戏开发，浪仔如饥似渴的学习，工作...\n");
                Console.ReadKey();
                Console.WriteLine("浪仔的人生终于走上了慢慢的走上了正轨，解决者这一切都是你的功劳！！！");

                Console.ReadKey();
            }
            #endregion
        }
    }
}
