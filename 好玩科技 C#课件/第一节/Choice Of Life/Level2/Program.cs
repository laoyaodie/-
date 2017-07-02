using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 第二关 爱情
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("第二关\n");
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
            }
            #endregion
        }
    }
}
