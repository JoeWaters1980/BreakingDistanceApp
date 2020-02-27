using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
//Joseph Waters
// breaking distance app 
//Project sem 2 2019
namespace BreakingDistanceApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Vechicle v1;
        List<Vechicle> allVechicles = new List<Vechicle>();

        public MainWindow()
        {

            // this screenLoad = new AssignmentSem2.MainWindow;
            //InitializeComponent();



        }

        private void Stopping_Distance_App_Loaded(object sender, RoutedEventArgs e)
        {// creates a car which will be the default vechile in the app
            try
            {
                v1 = new Vechicle("Car");



                // add to the vechicle list
                allVechicles.Add(v1);
                //allVechicles.Add(v1.speed);

                //displays the vechicle type
                lbx1.Text = v1.ToString();
            }
            catch (Exception)
            {
            }


        }


        private void RBdry_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void BtnSpeedEnter_Click(object sender, RoutedEventArgs e)
        {
            // adds the number from the text box calulates the breaking distance
            //and displays it in the breaking distance textblock in feet

            int speed;
            double breaking_distance = 0.0;
            double totalThinkingDis = 0;
            string outputThink = "thinking distance in meters :";
            string outputtotalDis = "Total braking distance Feet :";
            double speedInKph;
            double totalCarLenght;

            // speed entered by the user
            speed = int.Parse(tbxEnterSpeed.Text);

            // speed sent to the vechicle class to get the speed in kph
            speedInKph = v1.GetSpeedInMPH(speed);

            // breaking disatance is calulated from the vechicle class
            breaking_distance = v1.GetBreakingDistanceInMPH(speed);

            totalThinkingDis = v1.getDistances(breaking_distance, speed);

            totalCarLenght = v1.GetCarLength(breaking_distance);
            // displaying the breaking distance in feet
            TbxBreakingDis.Text = outputThink + "" + totalThinkingDis.ToString() + "\r" + outputtotalDis + "\r " + breaking_distance.ToString() + "\r" + totalCarLenght.ToString();



            // ucSpeedo.rotateDial.Angle = -45;



        }

        private void UserControlSpeedO_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
