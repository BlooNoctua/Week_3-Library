
namespace Library
{
    class Member
    {
        private int memberId;
        private string name;
        private string address;
        private int phone;

        //public properties
        public int MemberId
        {
            get { return memberId; }
            private set { memberId = value; } // Private setter makes it read-only
        }
        public string Name
        {
            get { return name; }  // get method
            set { name = value; } // set method
        }
        public string Address
        {
            get { return address; }  // get method
            set { address = value; } // set method
        }
        public int Phone
        {
            get { return phone; }  // get method
            set { phone = value; } // set method
        }

        // Constructor for new member
        public Member(int memberId, string name, string address, int phone)
        {
            this.memberId = memberId;
            this.name = name;
            this.address = address;
            this.phone = phone;
        }
        // Method to display information about a book
        public void DisplayInfo()
        {
            Console.WriteLine($"Member ID: {memberId}");
            Console.WriteLine($"Member Name: {name}");
            Console.WriteLine($"Member address: {address}");
            Console.WriteLine($"Member Phone No: {phone}");
            Console.WriteLine();
        }
    }
}
    

