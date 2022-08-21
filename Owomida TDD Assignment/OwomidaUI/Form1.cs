namespace OwomidaForms
{
    public partial class Owomida : Form
    {
        enum vehicles
        {
            Bus = 1000, Minibus = 800, Tricycle = 500, MotorCycle = 300
        }
        enum isNURTW
        {
            Yes = 30, No = 0 
        }
        public Owomida()
        {
            InitializeComponent();
            vehicleType.Items.AddRange(typeof(vehicles).GetEnumNames());
            vehicleType.Sorted = true;
            isNURTW_member.Items.AddRange(typeof(isNURTW).GetEnumNames());
            isNURTW_member.Sorted = true;   
        }

        private void btnClickThis_Click(object sender, EventArgs e)
        {
            lblHelloWorld.Text = "Hello World";
        }

        private void vehicleType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tollFee = (string)vehicleType.SelectedItem;
            float toll = (int)Enum.Parse(typeof(vehicles), tollFee);
            vehicleToll.Text = toll.ToString("0.00");
        }

        private void isNURTW_member_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tollFee = (string)vehicleType.SelectedItem;
            float toll = (int)Enum.Parse(typeof(vehicles), tollFee);

            string membership = (string)isNURTW_member.SelectedItem;
            float discountPercent = (int)Enum.Parse(typeof(isNURTW), membership);

            float discount = toll * (discountPercent / 100);
            discountBox.Text = discount.ToString("0.00") + " discount";

        }

        private void calcToll_Click(object sender, EventArgs e)
        {
            

            try
            {
                string tollFee = (string)vehicleType.SelectedItem;
                string membership = (string)isNURTW_member.SelectedItem;
                Int32.TryParse(numTrip.Text, out int numOfTrips);
                int numTrips = numOfTrips;
                double totalTollPaid = CalcTolls(numTrips, tollFee, membership);
                tollPaid.Text = totalTollPaid.ToString("0.00");
            }
            catch(Exception)
            {
                numTrip.Text = "Wrong value";
            }

            
        }

        /// <summary>
        /// Calculates the toll members.
        /// </summary>
        /// <param name="numberOfTrips">The number of trips for a driver</param>
        /// <param name="tollsForVehicle">Enter 'Bus', 'MiniBus', 'Tricycle' or 'Motorcycle'</param>
        /// <param name="unionMember">Is driver a union member? Enter 'Yes' or 'No'</param>
        /// <returns></returns>

        public double CalcTolls(int numberOfTrips, string tollsForVehicle, string unionMember)
        {
            double tollExpected;
            double vehicleToll = (int)Enum.Parse(typeof(vehicles), tollsForVehicle);
            double discount = (int)Enum.Parse(typeof(isNURTW), unionMember);
            tollExpected = numberOfTrips * (vehicleToll - (vehicleToll * (discount / 100)));
            return tollExpected;
        }

        private void numTrip_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}