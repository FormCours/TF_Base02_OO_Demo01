namespace Demo_OO_01.Models
{
    class Student
    {

        // Fields
        private string _Firstname;
        private string _Lastname;
        private double _Result;

        // Properties
        public string Firstname
        {
            get { return _Firstname; }
            set { _Firstname = value; }
        }

        public string Lastname
        {
            get 
            { 
                return _Lastname.ToUpper();
            }
            set { _Lastname = value; }
        }

        public string FullName
        {
            get
            {
                return Firstname + " " + Lastname;
            }
        }

        public double Result
        {
            get { return _Result; }
            set 
            {
                // Test si la valeur est erroné
                if(value > 20 || value < 0)
                {
                    // Générer une erreur (quand on aura vu comment)
                    return;
                }

                _Result = value;
            }
        }
    }
}
