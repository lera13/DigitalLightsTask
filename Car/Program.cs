using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRequirement
{
    public class Program
    {
        public Car car { get; set; }

        static void Main(string[] args) { }       
        
        public void ChechParameters()
        {
          
            if (car.StateOfTheCar == "On") //car ON
            {
                if ((car.CarSpeed > 0.0) && (car.CarSpeed <= 2500.0))
                {
                    car.IsCarMoveing = true;
                    car.StateOfTheCar = "On";
                    //car.Speedometer = Convert.ToInt32(car.CarSpeed / 10);
                    car.Speedometer = Convert.ToInt32(Math.Round(car.CarSpeed) / 10);
                    //Math.Round(car.CarSpeed)

                    if ((car.CarSpeed > 250.0) && (car.IsSeatBeltBuckled == false))
                    {
                        car.SeatbeltIndication = "Blibking"; //Req-8
                    }
                    else if ((car.CarSpeed <= 250.0) && (car.IsSeatBeltBuckled == false))
                    {
                        car.SeatbeltIndication = "On"; //Req-7
                    }
                    else
                    {
                        car.SeatbeltIndication = "Off";
                    }

                    if (car.CarSpeed > 1280)
                    {
                        car.SpeedLimitIndication = true; //Req-4
                    }

                }
                else if (car.CarSpeed > 2500.0 && car.CarSpeed <= 4098.0) // if speed is OVER 250км/ч
                {
                    car.IsCarMoveing = true;
                    car.StateOfTheCar = "On";
                    car.Speedometer = 250;

                    if (car.IsSeatBeltBuckled == false)
                    {
                        car.SeatbeltIndication = "Blibking"; //Req-8
                    }
                    else
                    {
                        car.SeatbeltIndication = "Off";
                    }

                    car.SpeedLimitIndication = true; //Req-4
                }
                else if ((car.CarSpeed < 0.0) || (car.CarSpeed > 4098.0))
                {
                    car.ErrMsg = "invalid data";
                }
                else
                {
                    car.IsCarMoveing = false; // car is ON but doesn't move
                    car.Speedometer = 0;
                    car.SpeedLimitIndication = false;
                    car.SeatbeltIndication = "Off"; //Req-6 
                }
                }
                else if (car.StateOfTheCar == "OnContact") // car is OnContact  Req-1
                {

                car.IsCarMoveing = false;
                car.SpeedLimitIndication = true; // because all the lights are ON
                car.SeatbeltIndication = "On"; // because all the lights are ON
                car.Speedometer = 0;
                car.CarSpeed = 0.0;
                //isSeatBeltBuckled = false; //The belt doesn't matter
                }
                else // car is OFF
                {
                car.StateOfTheCar = "Off";
                car.IsCarMoveing = false;
                car.CarSpeed = 0.0;
                car.SpeedLimitIndication = false;
                car.SeatbeltIndication = "Off";
                car.Speedometer = 0;
                //car.IsSeatBeltBuckled = false; // //The belt doesn't matter
            }

        }
        

    public class Car
    {
        private string stateOfTheCar;  //Off, OnContact, On
        private bool isCarMoveing;

        private bool speedLimitIndication; // false = off; true = on
        private string seatbeltIndication;   // On, Off, Blibking
        private int speedometer;

        private double carSpeed;
        private int carSpeedLimit; //128km/h;
        private bool isSeatBeltBuckled; // true = Buckled; false = Not Buckled*/
        private string errMsg;

        public string StateOfTheCar
        {
            get { return stateOfTheCar; }
            set { stateOfTheCar = value; }
        }
        public bool IsCarMoveing
        {
            get { return isCarMoveing; }
            set { isCarMoveing = value; }
        }
        public bool SpeedLimitIndication
        {
            get { return speedLimitIndication; }
            set { speedLimitIndication = value; }
        }
        public string SeatbeltIndication
        {
            get { return seatbeltIndication; }
            set { seatbeltIndication = value; }
        }
        public int Speedometer
        {
            get { return speedometer; }
            set { speedometer = value; }
        }
        public double CarSpeed
        {
            get { return carSpeed; }
            set { carSpeed = value; }
        }
        public int CarSpeedLimit
        {
            get { return carSpeedLimit; }
            set { carSpeedLimit = value; }
        }
        public bool IsSeatBeltBuckled
        {
            get { return isSeatBeltBuckled; }
            set { isSeatBeltBuckled = value; }
        }
            public string ErrMsg 
            { 
                get {return errMsg; }
                set {errMsg = value;} 
            }
        }

    }
}
