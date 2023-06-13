using RoomLib;
using System;
using System.Windows;

namespace FlatCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Room room = new Room();
        LivingRoom livingRoom = new LivingRoom();
        Office office = new Office();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BAddRoom_Click(object sender, RoutedEventArgs e)
        {
            room.RoomLength = Convert.ToDouble(TBLengthR.Text);
            room.RoomWidth = Convert.ToDouble(TBWidthR.Text);
        }

        private void BAddLivingRoom_Click(object sender, RoutedEventArgs e)
        {
            livingRoom.RoomLength = Convert.ToDouble(TBLengthL.Text);
            livingRoom.RoomWidth = Convert.ToDouble(TBWidthL.Text);
            livingRoom.NumWin = Convert.ToInt32(TBNumW.Text);
        }

        private void BAddOffice_Click(object sender, RoutedEventArgs e)
        {
            office.RoomLength = Convert.ToDouble(TBLengthO.Text);
            office.RoomWidth = Convert.ToDouble(TBWidthO.Text);
            office.NumSocets = Convert.ToInt32(TBNumS.Text);
        }

        private void BGetList_Click(object sender, RoutedEventArgs e)
        {
            ListRooms.Content = "";
            ListRooms.Content += room.Info() + "\n";
            ListRooms.Content += livingRoom.Info() + "\n";
            ListRooms.Content += office.Info();
        }
    }
}
