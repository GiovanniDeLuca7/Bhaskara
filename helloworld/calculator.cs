using System;

namespace helloworld
{
    class Calculator{
        private double Rest;
        private double Voltage;
        private double Corrent;

 
        public double SetRest
        {
            set{Rest = value;}
        }
        public double SetVoltage
        {
            set{Voltage = value;}
        }
        public double SetCorrent
        {   
            set{Corrent = value;}
        }
        public double getRest
        {
            get{return Rest;}
        }
        public double getVoltage
        {
            get{return Voltage;}
        } 
        public double getCorrent{
            get{return Corrent;}
        }
        public double CalculateCorrent()
        {
            return Voltage / Rest ;
        } 
    }

}