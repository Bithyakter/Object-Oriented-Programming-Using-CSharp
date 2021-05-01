namespace Association
{
    public class Employee
    {
        public int id;
        public string name;
        public Address address;     //Employee HAS-A Address  

        public Employee(int id, string name, Address address)
        {
            this.id = id;
            this.name = name;
            this.address = address;
        }
        public void GetEmployeeInfo()
        {
            Console.WriteLine(id + " " + name + " " +
            address.addressLine + " " + address.city + " " + address.state);
        }
    }

}
