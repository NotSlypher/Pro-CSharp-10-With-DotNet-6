using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_2_6_CarDelegate
{
    class Car
    {
        public int CurrSpeed { get; set; }
        public int MaxSpeed { get; set; }
        public string PetName { get; set; }

        private bool _carIsDead;

        public Car() { }
        public Car(string name, int maxSp, int currSp)
        {
            CurrSpeed = currSp;
            MaxSpeed = maxSp;
            PetName = name;
        }

        //Define a delegate type
        public delegate void CarEngineHandler(string msgForCaller);

        //Define a member variable of this delegate
        private CarEngineHandler _listOfHandlers;

        //Add registration function for the caller
        public void RegisterWithCarEngine(CarEngineHandler methodToCall)
        {
            _listOfHandlers += methodToCall;
        }

        public void UnRegisterWithCarEngine(CarEngineHandler methodToCall)
        {
            _listOfHandlers -= methodToCall;
        }

        public void Accelerate(int delta)
        {
            //if car is dead send dead message
            if(_carIsDead)
                _listOfHandlers?.Invoke("Sorry, this car is dead...");
            else
            {
                CurrSpeed += delta;
                //is this car "almost dead"?
                if (10 == (MaxSpeed - CurrSpeed))
                    _listOfHandlers("Careful buddy! Gonna blow");
                if (CurrSpeed >= MaxSpeed)
                    _carIsDead = true;
                else
                    Console.WriteLine("CurrentSpeed = {0}", CurrSpeed);
            }
        }
    }
}
