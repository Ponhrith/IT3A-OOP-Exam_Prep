using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try
{
    class GrandFather
    {
        private int GrandFatherPrivate = 1;
        protected int GrandFatherProtected = 2;
        public int GrandFatherPublic = 3;
    }

    class Father : GrandFather
    {
        private int FatherPrivate = 4;
        protected int FatherProtected = 5;
        public int FatherPublic = 6;

        public virtual string ShowInfo()
        {
            GrandFatherProtected = 20; //can access protected
            return FatherPrivate.ToString();
        }
    }

    class Son : Father 
    {
        private int SonPrivate = 7;
        protected int SpnProtected = 8;
        public int SonPublic = 9;

        public override string ShowInfo()
        {
            return SonPrivate.ToString();
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            Son me = new Son();
        }
    }
}
