using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choice_Of_Life
{
    class Program
    {
        static void Main(string[] args)
        {
            int level = 0;
            while(  level >= 0)
            {
                if (0 == level)
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
                        level = 1;
                    }
                    Console.WriteLine();
                    Console.ReadKey();
                    #endregion
                }
                else if (1 == level)
                {
                    #region 第二关 爱情
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n\n\n第二关\n");
                    Console.WriteLine("浪仔来到了你为他选择的学校，发现这个学校是一个正经的假大学，整个学校也就比自己家的院子大了一点\n");
                    Console.ReadKey();
                    Console.WriteLine("这个学校真的可以让他考上大学吗？浪仔深深的怀疑，但是没有后路的浪仔还有任何其他的选择吗?\n");
                    Console.ReadKey();
                    Console.WriteLine("深感无望的浪仔犹犹豫豫在这个大学学习的时候，他遇到一个很特别的姑娘...\n");
                    Console.ReadKey();
                    Console.WriteLine("浪仔深深的被这个特别的女孩吸引，但是他深深的怀疑自己该认真的学习还是勇敢的去追这个女孩...\n");
                    Console.ReadKey();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("面对人生的十字路口，请你帮浪仔拿一个主意，记住你的选择会改变浪仔的一生\n");
                    Console.WriteLine("请输入1、2，来帮浪仔拿一个主意:\n");
                    Console.WriteLine("1.勇敢起来去追这个女孩\n");
                    Console.WriteLine("2.好好学习吧,学习好了在谈恋爱吧.\n");
             
                    int i = int.Parse(Console.ReadLine());
                    if (1 == i)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("兄弟做的对,现在男女比例那么大,不趁早行事,还能等到以后去找个好基友吗?\n");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("只会学习,不懂生活的人,是浪仔最鄙视的人,浪仔不会听从你的选择,他还是向那个女孩发起了猛烈的攻势...\n");
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n\n\n\n跟这个女孩认识了之后,浪子才知道,这个女孩是在家里人的拦阻下来到这个学校的,\n");
                    Console.ReadKey();
                    Console.WriteLine("他们家里的条件是只有她自己想上学可以,除了第一年,自己掏学费,生活费\n");
                    Console.ReadKey();
                    Console.WriteLine("所以这个女孩一到下课就回去发传单,为了挣那么30块钱,在太阳地下各种被暴晒\n");
                    Console.ReadKey();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("听到了这个女孩的遭遇该怎么做,请你给浪仔一个答案:\n");
                    Console.WriteLine("1.这个一听就是个女骗子,好好学习吧,这个社会水太深,被骗了怎么办?\n");
                    Console.WriteLine("2.遇到一个女孩子愿意跟自己谈恋爱多不容易,放弃自己的学业吧,帮她一下吧,自己买本书,也能学得会.\n");
                    int ii = int.Parse(Console.ReadLine());
                    if (1 == ii)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("骗子哪有那么多,你的戒备心理太严重了,浪仔因为你的选择失去了他现在的媳妇...\n");
                        Console.ReadKey();
                        Console.WriteLine("浪仔已经不愿意跟你再玩下去了,你是他孤独一生的罪魁祸首,你的游戏失败了!!!\n");
                        Console.ReadKey();
                        return;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("从此浪仔不再去上课,他去双汇杀过猪,去物流运过货,去工地搬过砖,总之他想尽一切办法挣钱,来帮助他心中的女神...\n");
                        Console.ReadKey();
                        Console.WriteLine("时间检验的了他们的爱情,七年以后,他们结婚了,现在他们已经有了一个漂亮的女儿,叫做李布尔...\n");
                        Console.ReadKey();
                        Console.WriteLine("兄弟,感谢你英明神武的抉择,你在浪仔的膜拜下过关了...");
                        Console.ReadKey();
                        level = 2;

                    }
                    #endregion
                }
                else if (2 == level)
                {
                    #region 第三关 工作
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n\n\n第三关\n");
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
                        level = 3;
                    }
                    
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("在其他同学还没找到工作的情况下，浪仔一波三折的找到了一家真正做软件的工作，由于没有学历，浪仔只能以高中生的身份进入这个行业，他的工资是八百\n");
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
                        level = 4;
                    }
                    #endregion
                }
                else if (3 == level)
                {
                    #region 第四关 如今
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n\n\n结语\n");
                    Console.WriteLine("浪仔在几年中，碾转于各个公司，在每个公司，他都回去学到这个公司里程序中各个代码。当他感觉学不到东西的时候，他会在项目完结时提出离职\n");
                    Console.ReadKey();
                    Console.WriteLine("这几年间浪仔从新人变成老人，从普通程序变成一个公司的主程，在他手下成了N个项目，也死过2N个项目...\n");
                    Console.ReadKey();
                    Console.WriteLine("以前的他找工作靠投简历，现在的他靠别人挖墙脚和猎头主动联系找工作...\n");
                    Console.ReadKey();
                    Console.WriteLine("以前的他自己写代码，现在的他来到了好玩的讲台上，教别人写代码...\n");
                    Console.ReadKey();
                    Console.WriteLine("现在的浪仔就是你们面前的领路人，请大家给我那个主意，我应该把你们带好，给你们的程序人生一个良好的开端吗？\n");
                    Console.ReadKey();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("这个问题浪仔不需要你们帮他抉择了，浪仔自己下了决定，他会一定把你们带好。\n");
                    Console.WriteLine("也希望你们好好学习，在好玩的四个月里，开始你们真正的程序人生！！！\n");
                    #endregion
                }
            }

           
        }
    }
}
