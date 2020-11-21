using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventTest
{
    delegate void EventHandler(string message);

    class MyNotifier
    {
        public event EventHandler SomethingHappened;
        public void DoSomething(int number)
        {
            int temp = number % 10;

            if( temp != 0 && temp % 3 == 0)
            {
                SomethingHappened(String.Format("{0} : 짝 ",number));
            }
        }
    }
    class MainApp
    {
        static public void MyHandler(string message)
        {
            Console.WriteLine(message);
        }
        static void Main(string[] args)
        {
            MyNotifier notifier = new MyNotifier();
            notifier.SomethingHappened += new EventHandler(MyHandler);

            // notifier.SomethingHappened(String.Format("aaa ");  이벤트와 대리자의 차이. 이벤트는 바로 호출할수 없다.

            for( int i = 1; i < 30; i++ )
            {
                notifier.DoSomething(i);
            }

        }
    }
}
