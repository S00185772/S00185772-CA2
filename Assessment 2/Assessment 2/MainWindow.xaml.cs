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

namespace Assessment_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Activities> allactivities = new List<Activities>();
        List<Activities> selectedActivities = new List<Activities>();
        List<Activities> FliterdActivities = new List<Activities>();
        decimal total = 0;
        public MainWindow()
        {
            InitializeComponent();
        }
        





        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Activities l1 = new Activities("Mountain Biking", "Going up mountain on bike", new DateTime(2019, 6, 2), 40, ActivityType.Land);
            Activities l2 = new Activities("Abseiling", "controlled descent off a vertical drop", new DateTime(2019, 6, 3), 65, ActivityType.Land);
            Activities l3 = new Activities("Treking", "hiking up mountains", new DateTime(2019, 6, 1), 92, ActivityType.Land);
            Activities w1 = new Activities("Kayaking", "Boat Rowing", new DateTime(2019, 6, 1), 20, ActivityType.Water);
            Activities w2 = new Activities("Sailing", "Sailing", new DateTime(2019, 6, 3), 35, ActivityType.Water);
            Activities w3 = new Activities("Surfing", "Riding the waves", new DateTime(2019, 6, 5), 92, ActivityType.Water);
            Activities a1 = new Activities("Parachuting", "Droping from big height with parachute ", new DateTime(2019, 6, 1), 100, ActivityType.Air);
            Activities a2 = new Activities("Hang Gliding", "Flying with a glider", new DateTime(2019, 6, 2), 50, ActivityType.Air);
            Activities a3 = new Activities("Helicopter Tour", "sight seeing in helicopter", new DateTime(2019, 6, 4), 92, ActivityType.Air);



            allactivities.Add(l1);
            allactivities.Add(l2);
            allactivities.Add(l3);
            allactivities.Add(w1);
            allactivities.Add(w2);
            allactivities.Add(w3);
            allactivities.Add(a1);
            allactivities.Add(a2);
            allactivities.Add(a3);


        }

        



private void LbxAllActivities_Loaded(object sender, RoutedEventArgs e)
        {
           lbxAllActivities.ItemsSource = allactivities;
            
          
            }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Activities selectedactivities = lbxAllActivities.SelectedItem as Activities;

            if(selectedactivities != null)
            {
                allactivities.Remove(selectedactivities);
                selectedActivities.Add(selectedactivities);

                lbxAllActivities.ItemsSource = null;
                lbxAllActivities.ItemsSource = allactivities;

                lbxSelectedActivities.ItemsSource = null;
                lbxSelectedActivities.ItemsSource = selectedActivities;

              
                     total = selectedactivities.Cost + total;
             
               
                tbxTotal.Text = total.ToString();
            }
        }

      

        private void BtnRemove_Click(object sender, RoutedEventArgs e)
        {
            Activities selectedactivities = lbxSelectedActivities.SelectedItem as Activities;

            if (selectedactivities != null)
            {
                allactivities.Add(selectedactivities);
                selectedActivities.Remove(selectedactivities);

                lbxAllActivities.ItemsSource = null;
                lbxAllActivities.ItemsSource = allactivities;

                lbxSelectedActivities.ItemsSource = null;
                lbxSelectedActivities.ItemsSource = selectedActivities;


                total = total - selectedactivities.Cost ;

                tbxTotal.Text = total.ToString();
            }
        }

        private void RefreshScreen()
        {
            lbxAllActivities.ItemsSource = null;
            lbxAllActivities.ItemsSource = allactivities;

            lbxSelectedActivities.ItemsSource = null;
            lbxSelectedActivities.ItemsSource = selectedActivities;

        }

        private void RBtnAll_Click(object sender, RoutedEventArgs e)

        {
            FliterdActivities.Clear();
            if(RBtnAll.IsChecked == true)
            {
                RefreshScreen();
            }
            else if(RBtnLand.IsChecked == true)
            {
                foreach(Activities activitie in allactivities)
                {
                    if (activitie.TypeofActivity == ActivityType.Land)
                    {
                        FliterdActivities.Add(activitie);
                        lbxAllActivities.ItemsSource = null;
                        lbxAllActivities.ItemsSource = FliterdActivities;
                    }
                }
            }
            else if (RBtnWater.IsChecked == true)
            {
                foreach (Activities activitie in allactivities)
                {
                    if (activitie.TypeofActivity == ActivityType.Water)
                    {
                        FliterdActivities.Add(activitie);
                        lbxAllActivities.ItemsSource = null;
                        lbxAllActivities.ItemsSource = FliterdActivities;
                    }
                }
            }
            else if (RBtnAir.IsChecked == true)
            {
                foreach (Activities activitie in allactivities)
                {
                    if (activitie.TypeofActivity == ActivityType.Air)
                    {
                        FliterdActivities.Add(activitie);
                        lbxAllActivities.ItemsSource = null;
                        lbxAllActivities.ItemsSource = FliterdActivities;
                    }
                }
            }

        }

        private void LbxAllActivities_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Activities selectedactivities = lbxAllActivities.SelectedItem as Activities;
            if (selectedactivities != null)
            {
                TxblkDescription.Text = selectedactivities.Description;
            }
        }

        private void LbxSelectedActivities_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Activities selectedactivities = lbxAllActivities.SelectedItem as Activities;
            if (selectedactivities != null)
            {
                TxblkDescription.Text = selectedactivities.Description;
            }
        }
    }
}
