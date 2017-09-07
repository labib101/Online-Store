using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MobileStore.DAL
{
    public class RandomNumber
    {
        public string Generate()
        {
            Random _rdm = new Random();

            int _mini = 10;
            int _maxi = 14;
            
            int year = _rdm.Next(_mini, _maxi);

            int _minj = 24000;
            int _maxj = 27000;
           
            int code = _rdm.Next(_minj, _maxj);

            int _mink = 1;
            int _maxk = 3;

            int sem = _rdm.Next(_mink, _maxk);

            string pass = year.ToString() + "-" + code.ToString()+"-"+ sem.ToString();
            return pass;
        }
    }
}