using _3_2_6_CarDelegate;

Car c1 = new Car("SlugBug", 100, 10);

c1.RegisterWithCarEngine(new Car.CarEngineHandler(OnCarEngineEvent));
c1.RegisterWithCarEngine(new Car.CarEngineHandler(OnCarEngineEvent1));

for (int i = 0; i < 6; i++)
    c1.Accelerate(20);

static void OnCarEngineEvent(string msg)
{
    Console.WriteLine("\n***** Message From Car Object *****");
    Console.WriteLine("=> {0}", msg);
    Console.WriteLine("***********************************\n");
}
static void OnCarEngineEvent1(string msg)
{
    Console.WriteLine("\n***** Message From Car Object *****");
    Console.WriteLine("=> {0}", msg);
    Console.WriteLine("***********************************\n");
}