using NUnit.Framework;
using CarRequirement;
using System;
using static CarRequirement.Program;

namespace Car_TestCases
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Car car = new Car();

            Program program = new Program();
            car.StateOfTheCar = "Off";  //Off, OnContact, On
            car.IsSeatBeltBuckled = false; // true = Buckled; false = Not Buckled*/
            car.CarSpeed = 0.0;
            car.CarSpeedLimit = 1280; //128km/h;
            program.car = car;
            program.ChechParameters();
            // Check indicators!
            Assert.AreEqual(false, car.SpeedLimitIndication);
            Assert.AreEqual(0, car.Speedometer);
            Assert.AreEqual("Off", car.SeatbeltIndication);
        }
        [Test]
        public void Test2() //Загасена кола
        {
            Car car = new Car();
            Program program = new Program();
            car.StateOfTheCar = "Off";  //Off, OnContact, On
            car.IsSeatBeltBuckled = true; // true = Buckled; false = Not Buckled*/
            car.CarSpeed = 0.0;
            car.CarSpeedLimit = 1280; //128km/h;
            program.car = car;
            program.ChechParameters();
            // Check indicators!
            Assert.AreEqual(false, car.SpeedLimitIndication);
            Assert.AreEqual(0, car.Speedometer);
            Assert.AreEqual("Off", car.SeatbeltIndication);
        }
        [Test]
        public void Test3()
        {
            Car car = new Car();
            Program program = new Program();
            car.StateOfTheCar = "On";  //Off, OnContact, On
            car.IsSeatBeltBuckled = true; // true = Buckled; false = Not Buckled*/
            car.CarSpeed = 10.0;         // Speed 1km/h
            car.CarSpeedLimit = 1280; //128km/h;
            program.car = car;
            program.ChechParameters();
            // Check indicators!
            Assert.AreEqual(false, car.SpeedLimitIndication);
            Assert.AreEqual(1, car.Speedometer);
            Assert.AreEqual("Off", car.SeatbeltIndication);
        }
        [Test]
        public void Test4()
        {
            Car car = new Car();
            Program program = new Program();
            car.StateOfTheCar = "On";  //Off, OnContact, On
            car.IsSeatBeltBuckled = true; // true = Buckled; false = Not Buckled*/
            car.CarSpeed = 240.0;         // Speed 24km/h
            car.CarSpeedLimit = 1280; //128km/h;
            program.car = car;
            program.ChechParameters();
            // Check indicators!
            Assert.AreEqual(false, car.SpeedLimitIndication);
            Assert.AreEqual(24, car.Speedometer);
            Assert.AreEqual("Off", car.SeatbeltIndication);
        }
        [Test]
        public void Test5()
        {
            Car car = new Car();
            Program program = new Program();
            car.StateOfTheCar = "On";  //Off, OnContact, On
            car.IsSeatBeltBuckled = true; // true = Buckled; false = Not Buckled*/
            car.CarSpeed = 250.0;         // Speed 25km/h
            car.CarSpeedLimit = 1280; //128km/h;
            program.car = car;
            program.ChechParameters();
            // Check indicators!
            Assert.AreEqual(false, car.SpeedLimitIndication);
            Assert.AreEqual(25, car.Speedometer);
            Assert.AreEqual("Off", car.SeatbeltIndication);
        }
        [Test]
        public void Test6()
        {
            Car car = new Car();
            Program program = new Program();
            car.StateOfTheCar = "On";  //Off, OnContact, On
            car.IsSeatBeltBuckled = true; // true = Buckled; false = Not Buckled*/
            car.CarSpeed = 260.0;         // Speed 26km/h
            car.CarSpeedLimit = 1280; //128km/h;
            program.car = car;
            program.ChechParameters();
            // Check indicators!
            Assert.AreEqual(false, car.SpeedLimitIndication);
            Assert.AreEqual(26, car.Speedometer);
            Assert.AreEqual("Off", car.SeatbeltIndication);
        }

        [Test]
        public void Test7() //need or not???
        { }

        [Test]
        public void Test8()
        {
            Car car = new Car();
            Program program = new Program();
            car.StateOfTheCar = "On";  //Off, OnContact, On
            car.IsSeatBeltBuckled = true; // true = Buckled; false = Not Buckled*/
            car.CarSpeed = 1270.0;         // Speed 127km/h
            car.CarSpeedLimit = 1280; //128km/h;
            program.car = car;
            program.ChechParameters();
            // Check indicators!
            Assert.AreEqual(false, car.SpeedLimitIndication);
            Assert.AreEqual(127, car.Speedometer);
            Assert.AreEqual("Off", car.SeatbeltIndication);
        }

        [Test]
        public void Test9()
        {
            Car car = new Car();
            Program program = new Program();
            car.StateOfTheCar = "On";  //Off, OnContact, On
            car.IsSeatBeltBuckled = true; // true = Buckled; false = Not Buckled*/
            car.CarSpeed = 1280.0;         // Speed 128km/h
            car.CarSpeedLimit = 1280; //128km/h;
            program.car = car;
            program.ChechParameters();
            // Check indicators!
            Assert.AreEqual(false, car.SpeedLimitIndication);
            Assert.AreEqual(128, car.Speedometer);
            Assert.AreEqual("Off", car.SeatbeltIndication);
        }
        [Test]
        public void Test10()
        {
            Car car = new Car();
            Program program = new Program();
            car.StateOfTheCar = "On";  //Off, OnContact, On
            car.IsSeatBeltBuckled = true; // true = Buckled; false = Not Buckled*/
            car.CarSpeed = 1290.0;         // Speed 129km/h
            car.CarSpeedLimit = 1280; //128km/h;
            program.car = car;
            program.ChechParameters();
            // Check indicators!
            Assert.AreEqual(true, car.SpeedLimitIndication);
            Assert.AreEqual(129, car.Speedometer);
            Assert.AreEqual("Off", car.SeatbeltIndication);
        }
        [Test]
        public void Test11()
        {
            Car car = new Car();
            Program program = new Program();
            car.StateOfTheCar = "On";  //Off, OnContact, On
            car.IsSeatBeltBuckled = true; // true = Buckled; false = Not Buckled*/
            car.CarSpeed = 2490.0;         // Speed 249km/h
            car.CarSpeedLimit = 1280; //128km/h;
            program.car = car;
            program.ChechParameters();
            // Check indicators!
            Assert.AreEqual(true, car.SpeedLimitIndication);
            Assert.AreEqual(249, car.Speedometer);
            Assert.AreEqual("Off", car.SeatbeltIndication);
        }
        [Test]
        public void Test12()
        {
            Car car = new Car();
            Program program = new Program();
            car.StateOfTheCar = "On";  //Off, OnContact, On
            car.IsSeatBeltBuckled = true; // true = Buckled; false = Not Buckled*/
            car.CarSpeed = 2500.0;         // Speed 250km/h
            car.CarSpeedLimit = 1280; //128km/h;
            program.car = car;
            program.ChechParameters();
            // Check indicators!
            Assert.AreEqual(true, car.SpeedLimitIndication);
            Assert.AreEqual(250, car.Speedometer);
            Assert.AreEqual("Off", car.SeatbeltIndication);
        }
        [Test]
        public void Test13()
        {
            Car car = new Car();
            Program program = new Program();
            car.StateOfTheCar = "On";  //Off, OnContact, On
            car.IsSeatBeltBuckled = true; // true = Buckled; false = Not Buckled*/
            car.CarSpeed = 2510.0;         // Speed 251km/h
            car.CarSpeedLimit = 1280; //128km/h;
            program.car = car;
            program.ChechParameters();
            program.car = car;
            // Check indicators!
            Assert.AreEqual(true, car.SpeedLimitIndication);
            Assert.AreEqual(250, car.Speedometer);
            Assert.AreEqual("Off", car.SeatbeltIndication);
        }

        [Test]
        public void Test14()
        {
            Car car = new Car();
            Program program = new Program();
            car.StateOfTheCar = "On";  //Off, OnContact, On
            car.IsSeatBeltBuckled = false; // true = Buckled; false = Not Buckled*/
            car.CarSpeed = 0.0;         // Speed 0km/h
            car.CarSpeedLimit = 1280; //128km/h;
            program.car = car;
            program.ChechParameters();
            program.car = car;
            // Check indicators!
            Assert.AreEqual(false, car.SpeedLimitIndication);
            Assert.AreEqual(0, car.Speedometer);
            Assert.AreEqual("Off", car.SeatbeltIndication);
        }

        [Test]
        public void Test15()
        {
            Car car = new Car();
            Program program = new Program();
            car.StateOfTheCar = "On";  //Off, OnContact, On
            car.IsSeatBeltBuckled = false; // true = Buckled; false = Not Buckled*/
            car.CarSpeed = 10.0;         // Speed 1km/h
            car.CarSpeedLimit = 1280; //128km/h;
            program.car = car;
            program.ChechParameters();
            program.car = car;
            // Check indicators!
            Assert.AreEqual(false, car.SpeedLimitIndication);
            Assert.AreEqual(1, car.Speedometer);
            Assert.AreEqual("On", car.SeatbeltIndication);
        }
        [Test]
        public void Test16()
        {
            Car car = new Car();
            Program program = new Program();
            car.StateOfTheCar = "On";  //Off, OnContact, On
            car.IsSeatBeltBuckled = false; // true = Buckled; false = Not Buckled*/
            car.CarSpeed = 240.0;         // Speed 24km/h
            car.CarSpeedLimit = 1280; //128km/h;
            program.car = car;
            program.ChechParameters();
            program.car = car;
            // Check indicators!
            Assert.AreEqual(false, car.SpeedLimitIndication);
            Assert.AreEqual(24, car.Speedometer);
            Assert.AreEqual("On", car.SeatbeltIndication);
        }

        [Test]
        public void Test17()
        {
            Car car = new Car();
            Program program = new Program();
            car.StateOfTheCar = "On";  //Off, OnContact, On
            car.IsSeatBeltBuckled = false; // true = Buckled; false = Not Buckled*/
            car.CarSpeed = 250.0;         // Speed 25km/h
            car.CarSpeedLimit = 1280; //128km/h;
            program.car = car;
            program.ChechParameters();
            program.car = car;
            // Check indicators!
            Assert.AreEqual(false, car.SpeedLimitIndication);
            Assert.AreEqual(25, car.Speedometer);
            Assert.AreEqual("On", car.SeatbeltIndication);
        }
        [Test]
        public void Test18()
        {
            Car car = new Car();
            Program program = new Program();
            car.StateOfTheCar = "On";  //Off, OnContact, On
            car.IsSeatBeltBuckled = false; // true = Buckled; false = Not Buckled*/
            car.CarSpeed = 260.0;         // Speed 26km/h
            car.CarSpeedLimit = 1280; //128km/h;
            program.car = car;
            program.ChechParameters();
            program.car = car;
            // Check indicators!
            Assert.AreEqual(false, car.SpeedLimitIndication);
            Assert.AreEqual(26, car.Speedometer);
            Assert.AreEqual("Blibking", car.SeatbeltIndication);
        }

        [Test]
        public void Test19() { }

        [Test]
        public void Test20()
        {
            Car car = new Car();
            Program program = new Program();
            car.StateOfTheCar = "On";  //Off, OnContact, On
            car.IsSeatBeltBuckled = false; // true = Buckled; false = Not Buckled*/
            car.CarSpeed = 1260.0;         // Speed 126km/h
            car.CarSpeedLimit = 1280; //128km/h;
            program.car = car;
            program.ChechParameters();
            program.car = car;
            // Check indicators!
            Assert.AreEqual(false, car.SpeedLimitIndication);
            Assert.AreEqual(126, car.Speedometer);
            Assert.AreEqual("Blibking", car.SeatbeltIndication);
        }
        [Test]
        public void Test21()
        {
            Car car = new Car();
            Program program = new Program();
            car.StateOfTheCar = "On";  //Off, OnContact, On
            car.IsSeatBeltBuckled = false; // true = Buckled; false = Not Buckled*/
            car.CarSpeed = 1280.0;         // Speed 126km/h
            car.CarSpeedLimit = 1280; //128km/h;
            program.car = car;
            program.ChechParameters();
            program.car = car;
            // Check indicators!
            Assert.AreEqual(false, car.SpeedLimitIndication);
            Assert.AreEqual(128, car.Speedometer);
            Assert.AreEqual("Blibking", car.SeatbeltIndication);
        }
        [Test]
        public void Test22()
        {
            Car car = new Car();
            Program program = new Program();
            car.StateOfTheCar = "On";  //Off, OnContact, On
            car.IsSeatBeltBuckled = false; // true = Buckled; false = Not Buckled*/
            car.CarSpeed = 1290.0;         // Speed 129km/h
            car.CarSpeedLimit = 1290; //129km/h;
            program.car = car;
            program.ChechParameters();
            program.car = car;
            // Check indicators!
            Assert.AreEqual(true, car.SpeedLimitIndication);
            Assert.AreEqual(129, car.Speedometer);
            Assert.AreEqual("Blibking", car.SeatbeltIndication);
        }
        [Test]
        public void Test23()
        {
            Car car = new Car();
            Program program = new Program();
            car.StateOfTheCar = "On";  //Off, OnContact, On
            car.IsSeatBeltBuckled = false; // true = Buckled; false = Not Buckled*/
            car.CarSpeed = 2490.0;         // Speed 249km/h
            car.CarSpeedLimit = 1280; //128km/h;
            program.car = car;
            program.ChechParameters();
            program.car = car;
            // Check indicators!
            Assert.AreEqual(true, car.SpeedLimitIndication);
            Assert.AreEqual(249, car.Speedometer);
            Assert.AreEqual("Blibking", car.SeatbeltIndication);
        }
        [Test]
        public void Test24()
        {
            Car car = new Car();
            Program program = new Program();
            car.StateOfTheCar = "On";  //Off, OnContact, On
            car.IsSeatBeltBuckled = false; // true = Buckled; false = Not Buckled*/
            car.CarSpeed = 2500.0;         // Speed 250km/h
            car.CarSpeedLimit = 1280; //128km/h;
            program.car = car;
            program.ChechParameters();
            program.car = car;
            // Check indicators!
            Assert.AreEqual(true, car.SpeedLimitIndication);
            Assert.AreEqual(250, car.Speedometer);
            Assert.AreEqual("Blibking", car.SeatbeltIndication);
        }
        [Test]
        public void Test25()
        {
            Car car = new Car();
            Program program = new Program();
            car.StateOfTheCar = "On";  //Off, OnContact, On
            car.IsSeatBeltBuckled = false; // true = Buckled; false = Not Buckled*/
            car.CarSpeed = 2510.0;         // Speed 251km/h
            car.CarSpeedLimit = 1280; //128km/h;
            program.car = car;
            program.ChechParameters();
            program.car = car;
            // Check indicators!
            Assert.AreEqual(true, car.SpeedLimitIndication);
            Assert.AreEqual(250, car.Speedometer);
            Assert.AreEqual("Blibking", car.SeatbeltIndication);
        }
        [Test]
        public void Test26()
        {
            Car car = new Car();
            Program program = new Program();
            car.StateOfTheCar = "On";  //Off, OnContact, On
            car.IsSeatBeltBuckled = true; // true = Buckled; false = Not Buckled*/
            car.CarSpeed = -10.0;         // Speed -1km/h
            car.CarSpeedLimit = 1280; //128km/h;
            program.car = car;
            program.ChechParameters();
            // Check indicators!
            Assert.AreEqual("invalid data", car.ErrMsg);
            
        }
        [Test]
        public void Test27()
        {
            Car car = new Car();
            Program program = new Program();
            car.StateOfTheCar = "On";  //Off, OnContact, On
            car.IsSeatBeltBuckled = false; // true = Buckled; false = Not Buckled*/
            car.CarSpeed = -10.0;         // Speed -1km/h
            car.CarSpeedLimit = 1280; //128km/h;
            program.car = car;
            program.ChechParameters();
            // Check indicators!
            Assert.AreEqual("invalid data", car.ErrMsg);
        }
        [Test]
        public void Test28()
        {
            Car car = new Car();
            Program program = new Program();
            car.StateOfTheCar = "On";  //Off, OnContact, On
            car.IsSeatBeltBuckled = true; // true = Buckled; false = Not Buckled*/
            car.CarSpeed = 4100.0;         // Speed 410km/h
            car.CarSpeedLimit = 1280; //128km/h;
            program.car = car;
            program.ChechParameters();
            // Check indicators!
            Assert.AreEqual("invalid data", car.ErrMsg);

        }
        [Test]
        public void Test29()
        {
            Car car = new Car();
            Program program = new Program();
            car.StateOfTheCar = "On";  //Off, OnContact, On
            car.IsSeatBeltBuckled = false; // true = Buckled; false = Not Buckled*/
            car.CarSpeed = 4100.0;         // Speed 410km/h
            car.CarSpeedLimit = 1280; //128km/h;
            program.car = car;
            program.ChechParameters();
            // Check indicators!
            Assert.AreEqual("invalid data", car.ErrMsg);
        }
        [Test]
        public void Test30()
        {
            Car car = new Car();
            Program program = new Program();
            car.StateOfTheCar = "On";  //Off, OnContact, On
            car.IsSeatBeltBuckled = true; // true = Buckled; false = Not Buckled*/
            car.CarSpeed = 4090.0;         // Speed 409km/h
            car.CarSpeedLimit = 1280; //128km/h;
            program.car = car;
            program.ChechParameters();
            program.car = car;
            // Check indicators!
            Assert.AreEqual(true, car.SpeedLimitIndication);
            Assert.AreEqual(250, car.Speedometer);
            Assert.AreEqual("Off", car.SeatbeltIndication);
        }

        [Test]
        public void Test31()
        {
            Car car = new Car();
            Program program = new Program();
            car.StateOfTheCar = "On";  //Off, OnContact, On
            car.IsSeatBeltBuckled = false; // true = Buckled; false = Not Buckled*/
            car.CarSpeed = 4090.0;         // Speed 409km/h
            car.CarSpeedLimit = 1280; //128km/h;
            program.car = car;
            program.ChechParameters();
            program.car = car;
            // Check indicators!
            Assert.AreEqual(true, car.SpeedLimitIndication);
            Assert.AreEqual(250, car.Speedometer);
            Assert.AreEqual("Blibking", car.SeatbeltIndication);
        }

        [Test]
        public void Test32()
        {
            Car car = new Car();
            Program program = new Program();
            car.StateOfTheCar = "On";  //Off, OnContact, On
            car.IsSeatBeltBuckled = true; // true = Buckled; false = Not Buckled*/
            car.CarSpeed = 4098.0;         // Speed 409.8km/h
            car.CarSpeedLimit = 1280; //128km/h;
            program.car = car;
            program.ChechParameters();
            program.car = car;
            // Check indicators!
            Assert.AreEqual(true, car.SpeedLimitIndication);
            Assert.AreEqual(250, car.Speedometer);
            Assert.AreEqual("Off", car.SeatbeltIndication);
        }

        [Test]
        public void Test33()
        {
            Car car = new Car();
            Program program = new Program();
            car.StateOfTheCar = "On";  //Off, OnContact, On
            car.IsSeatBeltBuckled = false; // true = Buckled; false = Not Buckled*/
            car.CarSpeed = 4098.0;         // Speed 409.8km/h
            car.CarSpeedLimit = 1280; //128km/h;
            program.car = car;
            program.ChechParameters();
            program.car = car;
            // Check indicators!
            Assert.AreEqual(true, car.SpeedLimitIndication);
            Assert.AreEqual(250, car.Speedometer);
            Assert.AreEqual("Blibking", car.SeatbeltIndication);
        }

        [Test]
        public void Test34()
        {
            Car car = new Car();
            Program program = new Program();
            car.StateOfTheCar = "On";  //Off, OnContact, On
            car.IsSeatBeltBuckled = false; // true = Buckled; false = Not Buckled*/
            car.CarSpeed = -0.1;         // Speed -0,01km/h
            car.CarSpeedLimit = 1280; //128km/h;
            program.car = car;
            program.ChechParameters();
            // Check indicators!
            Assert.AreEqual("invalid data", car.ErrMsg);
        }
        [Test]
        public void Test35()
        {
            Car car = new Car();
            Program program = new Program();
            car.StateOfTheCar = "On";  //Off, OnContact, On
            car.IsSeatBeltBuckled = true; // true = Buckled; false = Not Buckled*/
            car.CarSpeed = -0.1;         // Speed -0,01km/h
            car.CarSpeedLimit = 1280; //128km/h;
            program.car = car;
            program.ChechParameters();
            // Check indicators!
            Assert.AreEqual("invalid data", car.ErrMsg);
        }
        [Test]
        public void Test36()
        {
            Car car = new Car();
            Program program = new Program();
            car.StateOfTheCar = "On";  //Off, OnContact, On
            car.IsSeatBeltBuckled = true; // true = Buckled; false = Not Buckled*/
            car.CarSpeed = 4098.1;         // Speed 409,81km/h
            car.CarSpeedLimit = 1280; //128km/h;
            program.car = car;
            program.ChechParameters();
            // Check indicators!
            Assert.AreEqual("invalid data", car.ErrMsg);
        }
        [Test]
        public void Test37()
        {
            Car car = new Car();
            Program program = new Program();
            car.StateOfTheCar = "On";  //Off, OnContact, On
            car.IsSeatBeltBuckled = false; // true = Buckled; false = Not Buckled*/
            car.CarSpeed = 4098.1;         // Speed 409,81km/h
            car.CarSpeedLimit = 1280; //128km/h;
            program.car = car;
            program.ChechParameters();
            // Check indicators!
            Assert.AreEqual("invalid data", car.ErrMsg);
        }
        [Test]
        public void Test38()
        {
            Car car = new Car();
            Program program = new Program();
            car.StateOfTheCar = "On";  //Off, OnContact, On
            car.IsSeatBeltBuckled = true; // true = Buckled; false = Not Buckled*/
            car.CarSpeed = 0.1;         // Speed 0,01km/h
            car.CarSpeedLimit = 1280; //128km/h;
            program.car = car;
            program.ChechParameters();
            // Check indicators!
            Assert.AreEqual(false, car.SpeedLimitIndication);
            Assert.AreEqual(0, car.Speedometer);
            Assert.AreEqual("Off", car.SeatbeltIndication);
        }
        [Test]
        public void Test39()
        {
            Car car = new Car();
            Program program = new Program();
            car.StateOfTheCar = "On";  //Off, OnContact, On
            car.IsSeatBeltBuckled = true; // true = Buckled; false = Not Buckled*/
            car.CarSpeed = 4097.9;         // Speed 409,79km/h
            car.CarSpeedLimit = 1280; //128km/h;
            program.car = car;
            program.ChechParameters();
            // Check indicators!
            Assert.AreEqual(true, car.SpeedLimitIndication);
            Assert.AreEqual(250, car.Speedometer);
            Assert.AreEqual("Off", car.SeatbeltIndication);
        }
        [Test]
        public void Test40()
        {
            Car car = new Car();
            Program program = new Program();
            car.StateOfTheCar = "On";  //Off, OnContact, On
            car.IsSeatBeltBuckled = true; // true = Buckled; false = Not Buckled*/
            car.CarSpeed = 249.9;         // Speed 24,99km/h
            car.CarSpeedLimit = 1280; //128km/h;
            program.car = car;
            program.ChechParameters();
            // Check indicators!
            Assert.AreEqual(false, car.SpeedLimitIndication);
            Assert.AreEqual(25, car.Speedometer);
            Assert.AreEqual("Off", car.SeatbeltIndication);
        }
        [Test]
        public void Test41()
        {
            Car car = new Car();
            Program program = new Program();
            car.StateOfTheCar = "On";  //Off, OnContact, On
            car.IsSeatBeltBuckled = true; // true = Buckled; false = Not Buckled*/
            car.CarSpeed = 250.1;         // Speed 25,01km/h
            car.CarSpeedLimit = 1280; //128km/h;
            program.car = car;
            program.ChechParameters();
            // Check indicators!
            Assert.AreEqual(false, car.SpeedLimitIndication);
            Assert.AreEqual(25, car.Speedometer);
            Assert.AreEqual("Off", car.SeatbeltIndication);
        }
        [Test]
        public void Test42()
        {
            Car car = new Car();
            Program program = new Program();
            car.StateOfTheCar = "On";  //Off, OnContact, On
            car.IsSeatBeltBuckled = true; // true = Buckled; false = Not Buckled*/
            car.CarSpeed = 1280.1;         // Speed 128,01km/h
            car.CarSpeedLimit = 1280; //128km/h;
            program.car = car;
            program.ChechParameters();
            // Check indicators!
            Assert.AreEqual(true, car.SpeedLimitIndication);
            Assert.AreEqual(128, car.Speedometer);
            Assert.AreEqual("Off", car.SeatbeltIndication);
        }
        [Test]
        public void Test43()
        {
            Car car = new Car();
            Program program = new Program();
            car.StateOfTheCar = "On";  //Off, OnContact, On
            car.IsSeatBeltBuckled = true; // true = Buckled; false = Not Buckled*/
            car.CarSpeed = 2499.9;         // Speed 249,99km/h
            car.CarSpeedLimit = 1280; //128km/h;
            program.car = car;
            program.ChechParameters();
            // Check indicators!
            Assert.AreEqual(true, car.SpeedLimitIndication);
            Assert.AreEqual(250, car.Speedometer);
            Assert.AreEqual("Off", car.SeatbeltIndication);
        }
        [Test]
        public void Test44()
        {
            Car car = new Car();
            Program program = new Program();
            car.StateOfTheCar = "On";  //Off, OnContact, On
            car.IsSeatBeltBuckled = true; // true = Buckled; false = Not Buckled*/
            car.CarSpeed = 2500.1;         // Speed 250,01km/h
            car.CarSpeedLimit = 1280; //128km/h;
            program.car = car;
            program.ChechParameters();
            // Check indicators!
            Assert.AreEqual(true, car.SpeedLimitIndication);
            Assert.AreEqual(250, car.Speedometer);
            Assert.AreEqual("Off", car.SeatbeltIndication);
        }
        [Test]
        public void Test45()
        {
            Car car = new Car();
            Program program = new Program();
            car.StateOfTheCar = "On";  //Off, OnContact, On
            car.IsSeatBeltBuckled = false; // true = Buckled; false = Not Buckled*/
            car.CarSpeed = 0.1;         // Speed 0,01km/h
            car.CarSpeedLimit = 1280; //128km/h;
            program.car = car;
            program.ChechParameters();
            // Check indicators!
            Assert.AreEqual(false, car.SpeedLimitIndication);
            Assert.AreEqual(0, car.Speedometer);
            Assert.AreEqual("On", car.SeatbeltIndication);
        }
        [Test]
        public void Test46()
        {
            Car car = new Car();
            Program program = new Program();
            car.StateOfTheCar = "On";  //Off, OnContact, On
            car.IsSeatBeltBuckled = false; // true = Buckled; false = Not Buckled*/
            car.CarSpeed = 249.9;         // Speed 24,99km/h
            car.CarSpeedLimit = 1280; //128km/h;
            program.car = car;
            program.ChechParameters();
            // Check indicators!
            Assert.AreEqual(false, car.SpeedLimitIndication);
            Assert.AreEqual(25, car.Speedometer);
            Assert.AreEqual("On", car.SeatbeltIndication);
        }
        [Test]
        public void Test47()
        {
            Car car = new Car();
            Program program = new Program();
            car.StateOfTheCar = "On";  //Off, OnContact, On
            car.IsSeatBeltBuckled = false; // true = Buckled; false = Not Buckled*/
            car.CarSpeed = 250.1;         // Speed 25,01km/h
            car.CarSpeedLimit = 1280; //128km/h;
            program.car = car;
            program.ChechParameters();
            // Check indicators!
            Assert.AreEqual(false, car.SpeedLimitIndication);
            Assert.AreEqual(25, car.Speedometer);
            Assert.AreEqual("Blibking", car.SeatbeltIndication);
        }
        [Test]
        public void Test48()
        {
            Car car = new Car();
            Program program = new Program();
            car.StateOfTheCar = "On";  //Off, OnContact, On
            car.IsSeatBeltBuckled = false; // true = Buckled; false = Not Buckled*/
            car.CarSpeed = 1280.1;         // Speed 128,01km/h
            car.CarSpeedLimit = 1280; //128km/h;
            program.car = car;
            program.ChechParameters();
            // Check indicators!
            Assert.AreEqual(true, car.SpeedLimitIndication);
            Assert.AreEqual(128, car.Speedometer);
            Assert.AreEqual("Blibking", car.SeatbeltIndication);
        }
        [Test]
        public void Test49()
        {
            Car car = new Car();
            Program program = new Program();
            car.StateOfTheCar = "On";  //Off, OnContact, On
            car.IsSeatBeltBuckled = false; // true = Buckled; false = Not Buckled*/
            car.CarSpeed = 2499.9;         // Speed 249,99km/h
            car.CarSpeedLimit = 1280; //128km/h;
            program.car = car;
            program.ChechParameters();
            // Check indicators!
            Assert.AreEqual(true, car.SpeedLimitIndication);
            Assert.AreEqual(250, car.Speedometer);
            Assert.AreEqual("Blibking", car.SeatbeltIndication);
        }
        [Test]
        public void Test50()
        {
            Car car = new Car();
            Program program = new Program();
            car.StateOfTheCar = "On";  //Off, OnContact, On
            car.IsSeatBeltBuckled = false; // true = Buckled; false = Not Buckled*/
            car.CarSpeed = 2500.1;         // Speed 250,01km/h
            car.CarSpeedLimit = 1280; //128km/h;
            program.car = car;
            program.ChechParameters();
            // Check indicators!
            Assert.AreEqual(true, car.SpeedLimitIndication);
            Assert.AreEqual(250, car.Speedometer);
            Assert.AreEqual("Blibking", car.SeatbeltIndication);
        }
        [Test]
        public void Test51()
        {
            Car car = new Car();
            Program program = new Program();
            car.StateOfTheCar = "On";  //Off, OnContact, On
            car.IsSeatBeltBuckled = false; // true = Buckled; false = Not Buckled*/
            car.CarSpeed = 4097.9;         // Speed 409,79km/h
            car.CarSpeedLimit = 1280; //128km/h;
            program.car = car;
            program.ChechParameters();
            // Check indicators!
            Assert.AreEqual(true, car.SpeedLimitIndication);
            Assert.AreEqual(250, car.Speedometer);
            Assert.AreEqual("Blibking", car.SeatbeltIndication);
        }
    }
}