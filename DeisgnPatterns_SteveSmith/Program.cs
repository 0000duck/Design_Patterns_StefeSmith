using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeisgnPatterns_SteveSmith
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }


    //Singleton Pattern
    // CEL : +zapewnienie by klasa miała tylko 1 instancję 
    //       +udostępnienie globalnego punktu dostępu do tej instancji  
    //public class Singleton
    //{
    //    private static Singleton _instance;
    //    private Singleton()
    //    {

    //    }
    //    public static Singleton Instance
    //    {
    //        get
    //        {
    //            if (_instance == null)
    //            {
    //                _instance = new Singleton();
    //            }
    //            return _instance;
    //        }
    //    }
    //}
    public class Factory
    {
        private static Factory _factory;
        private static Object _classLock = typeof(Factory);
        private long _wipMoves;
        private Factory()
        {
            _wipMoves = 0;
        }
        //
        public static Factory GetFactory()
        {
            lock (_classLock)
            {
                if (_factory == null)
                {
                    _factory = new Factory();
                }
                return _factory;
            }
        }

        public void RecordWipMove()
        {

            //zadanie
        }
    }
}
