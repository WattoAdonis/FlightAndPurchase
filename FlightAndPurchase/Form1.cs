/*
Team members and the contributions that each has been assigned.
    Team Name:
    Project Name:
    Project Manager:    Lambert Munyawera   857-244-5746    lmunyawera94@gmail.com

                        Anthony Mousoulis   603-727-6422    anthony.mousoulis2015@hotmail.com
                        Leiyanka Daellani   571-699-8127    daellaniP9@gmail.com                FAILED DAEMONED MAIL
                        Kola Yves   		240-423-2539    yvris993@gmail.com
                        Sameal Molla		202-390-8865    sammydmolla@gmail.com
                        Welton Tyler		434-594-5735    wtyler1@gmail.com
                        
    Team evaluators and class instructors:
                        Vasu                703-855-7426	vasu@ispaninc.com
                        Nancy               703-597-3098	nancy@ispaninc.com
                        Karishma                    		karishma@ebsolutioninc.com
*/
// FlightExpedia is an example refference to guide us...
/*
    Requirements:       Part 01:    At least 10 flight options
                        Part 02:    Sorted by Price
                                    Sorted by Duration of flight
                                    Sorted by number of Stops/Connections
                        Part 03:    Show flight information and send a confirmation by e-mail containing:
                                        One way as well as return flight
                                        Airline
                                        Departure time
                                        Arrival time
                                        Duration flight
                                        Number of stops
                                        Price
    Date started:       Wednesday May 12, 2016
    Due date:           Friday May 13, 2016 Documentation, Wireframe Layout.
                        Monday May 13, 2016 User Interface.
*/

/*
image retrieved from "Free Images"  http://www.bigfoto.com/themes/aviation/glider-h6w.jpg
 */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightAndPurchase
{
    public partial class FlightForm : Form
    {
        #region Part 01:    At least 10 flight options
        #endregion

        #region Part 02:
        /*
            Sorted by Price
            Sorted by Duration of flight
            Sorted by number of Stops/Connections
        */
        #endregion

        #region Part 03:
        /*
            Show flight information and send a confirmation by e-mail containing:
                One way as well as return flight
                Airline
                Departure time
                Arrival time
                Duration flight
                Number of stops
                Price
        */
        #endregion

        public FlightForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the form and exit
            Application.Exit();
        }
    }
}
