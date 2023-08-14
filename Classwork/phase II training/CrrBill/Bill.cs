using System;
using System.Collections.Generic;
using System.Text;

namespace CrrBill
{
    class Bill
    {
        private int consumernumber;
        private string consumername;
        private string consumertype;
        private int prevread;
        private int currentread;
        private readonly int _subsity;

        public int Consumernumber { get => consumernumber; set => consumernumber = value; }
        public string Consumername { get => consumername; set => consumername = value; }
        public string Consumertype { get => consumertype; set => consumertype = value; }
        public int Prevread { get => prevread; set => prevread = value; }
        public int Currentread { get => currentread; set => currentread = value; }

        public Bill (int consumernumber,string consumername,int prevread,int currentread,string consumertype)
        {
            Consumernumber=consumernumber;
            Consumername=consumername;
            Consumertype=consumertype;
            Prevread = prevread;
            Currentread=currentread;
            _subsity = 50;
        }
        public int Calculate()
        {
            
            int billamt = 0;
            if(Consumertype.Equals("domestic"))
            {
                int consumption = Currentread - Prevread;
                if(consumption<=100)
                {
                    billamt = 0;
                }
                else if (consumption >100 && consumption <=200)
                {
                    billamt = (consumption-100)*2;
                }
                else if (consumption > 200 && consumption <= 500)
                {
                    billamt = (consumption - 100) * 20;
                }
                else 
                {
                    billamt = (consumption - 100) * 50;
                }
                
            }
            if(Consumertype.Equals("commercial"))
            {
                int consumption = Currentread - Prevread;
                if (consumption <= 100)
                {
                    billamt = 50;
                }
                else if (consumption > 100 && consumption <= 200)
                {
                    billamt = (consumption - 100) * 20;
                }
                else if (consumption > 200 && consumption <= 500)
                {
                    billamt = (consumption - 100) * 50;
                }
                else
                {
                    billamt = (consumption - 100) * 100;
                }
            
            }
            return billamt;
        }

    }
}
