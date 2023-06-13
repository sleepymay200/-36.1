using lab_3.Mob;
using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Media;
using System.Windows.Navigation;

namespace lab_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Monster monster = new Monster();
        public int _countMeat { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            
            monsterActionLabel.Text = monster._monsterAction;
            DataContext = this;

            MeatCountLabel.Text = $"Количество мяса {_countMeat}";
            UpdateMonsterHealText();
        }

        private void UpdateMonsterHealText()
        {
            monsterHPLabel.Text = $"Здоровья монстра: {monster._currentHP}";
            monsterHPCurrent2.Width = monster._currentHP;
            if(monster._currentHP < 50)
            {
                monsterHPCurrent2.Fill = new SolidColorBrush(Color.FromRgb(255,0,0));
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (monster.CheckMonsterHP())
            {
                monsterActionLabel.Text = monster._monsterAction;
                return;
            }

            monster.DealDamage(5);
            Thread.Sleep(500);
            monsterActionLabel.Text = monster._monsterAction;

            var rnd = new Random();
            if(rnd.Next(0,5) == 3)
            {
                monster.Heal();
                monsterActionLabel.Text = monster._monsterAction;
            }

            UpdateMonsterHealText();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (monster.CheckMonsterHP())
            {
                monsterActionLabel.Text = monster._monsterAction;
                return;
            }

            _countMeat++;
            monster.CutMeat();
            monsterActionLabel.Text = monster._monsterAction;

            MeatCountLabel.Text = $"Количество мяса {_countMeat}";
            UpdateMonsterHealText();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (_countMeat <= 0)
            {
                _countMeat = 0;
                return;
            }

            var rnd = new Random();
            monsterActionLabel.Text = $"Вы продали мясо и получили {rnd.Next(0,1000)}";
            _countMeat--;
            MeatCountLabel.Text = $"Количество мяса {_countMeat}";
            UpdateMonsterHealText();
        }
    }
}
