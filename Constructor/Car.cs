namespace Constructor
{
    public class Car
    {
        public string carModel { get; set; }
        public int carYear { get; set; }
        public int carWheels { get; set; }

        public Car()        //Default Constructor
        {

        }
        public Car(string model, int year)        //Parameterized Constructor
        {
            this.carModel = model;
            this.carYear = year;
        }

        public Car(int year, string model, int wheel)     //Overloaded Constructor
        {
            this.carModel = model;
            carYear = year;
            carWheels = wheel;
        }
    }




}
