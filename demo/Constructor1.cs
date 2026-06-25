namespace demo
{
    internal class Constructor1
    {
        //These are the member variables which is private 
        private string _model = "";
        private string _brand = "";
        private Boolean _isLuxuary ;

        //Property in encaptulation helps to access the data from its Property
        public string Model
        {
            get 
            {
                return _model;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("You Entered NOTHING!");
                    _model = "Default Value";
                }
                else
                {
                    _model = value;
                }
            }
        }
        public string Brand
        {
            get { return _brand; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("You Entered NOTHING!");
                    _brand = "Default Value";
                }
                else
                {
                    _brand = value;
                }
            }
        }

        public bool IsLuxuary {
            get => _isLuxuary;
            set => _isLuxuary = value; }

        public Constructor1(string brand, string model,bool isLuxuary)
        {
            Model = model;
            Brand = brand;
            IsLuxuary = isLuxuary;
            Console.WriteLine($"Car brand is : {Brand}" + $" model {Model}has been Launched");

        }
    }
}
