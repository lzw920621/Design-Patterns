using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 单例模式
{
    sealed class Singleton
    {
        static readonly Singleton singleton = new Singleton();
        private Singleton()
        {

        }

        public static Singleton GetSingleton
        {
            get
            {
                return singleton;
            }
        }
    }

    sealed class Singleton2
    {
        private static Singleton2 singleton;
        private Singleton2()
        {

        }

        static object obj = new object();

        public static Singleton2 GetSingleton()
        {
            if(singleton==null)
            {
                lock(obj)
                {
                    if(singleton==null)
                    {
                        singleton = new Singleton2();
                    }
                }
            }
            return singleton;
        }
    }

    public sealed class Singleton3
    {
        private static readonly Lazy<Singleton3> lazy =
          new Lazy<Singleton3>(() => new Singleton3());

        public static Singleton3 Instance { get { return lazy.Value; } }

        private Singleton3()
        {
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
