using MyTestGame.Classes;
using MyTestGame.MongoDB;
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

namespace MyTestGame.Pages
{
    /// <summary>
    /// Логика взаимодействия для CreateUnit.xaml
    /// </summary>
    public partial class CreateUnit : Page
    {
        UnitType unitType {  get; set; }
        UnitType minMaxWarrior;
        int iter;
        int lvl = 0, point = 0;
        
        public CreateUnit(string names)
        {
            InitializeComponent();
            minMaxWarrior = CRUD.GetUnit(names);
            UnitType unitWarrior = App.users;
            MinStrengthTb.Text = (unitWarrior.MinStrength).ToString();
            MaxStrengthTb.Text = (unitWarrior.MaxStrength).ToString();
            MinInteligenceTb.Text = (unitWarrior.MinInteligence).ToString();
            MaxInteligenceTb.Text = (unitWarrior.MaxInteligence).ToString();
            MinDexterityTb.Text = (unitWarrior.MinDexterity).ToString();
            MaxDexterityTb.Text = (unitWarrior.MaxDexterity).ToString();
            MinVitalityTb.Text = (unitWarrior.MinVitality).ToString();
            MaxVitalityTb.Text = (unitWarrior.MaxVitality).ToString(); ;

        }

        private void PlusStrBtn_Click(object sender, RoutedEventArgs e)
        {
            if ( Convert.ToInt32(MinStrengthTb.Text) >= minMaxWarrior.MaxStrength ) 
            {
                MinStrengthTb.Text = minMaxWarrior.MaxStrength.ToString();

            }
            else
            {
               
                if (Convert.ToInt32(PointTb.Text) <= 0)
                {
                    MessageBox.Show("Не хвататет опыта!");
                }
                else
                {
                    iter = Convert.ToInt32(MinStrengthTb.Text);
                    iter++;
                    MinStrengthTb.Text = iter.ToString();
                    point--;
                    PointTb.Text = point.ToString();
                }
                
                
            }
        }

        private void MinusStrBtn_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt32(MinStrengthTb.Text) <= minMaxWarrior.MinStrength)
            {
                MinStrengthTb.Text = minMaxWarrior.MinStrength.ToString();
            }
            else
            {
                iter = Convert.ToInt32(MinStrengthTb.Text);
                iter--;
                MinStrengthTb.Text = iter.ToString();
                point++;
                PointTb.Text = point.ToString();
            }
        }

        private void PlusDexBtn_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt32(MinDexterityTb.Text) >= minMaxWarrior.MaxDexterity)
            {
                MinDexterityTb.Text = minMaxWarrior.MaxDexterity.ToString();

            }
            else
            {
                if (Convert.ToInt32(PointTb.Text) <= 0)
                {
                    MessageBox.Show("Не хвататет опыта!");
                }
                else
                {
                    iter = Convert.ToInt32(MinDexterityTb.Text);
                    iter++;
                    MinDexterityTb.Text = iter.ToString();
                    point--;
                    PointTb.Text = point.ToString();
                }
                

            }
        }

        private void MinusDexBtn_Click(object sender, RoutedEventArgs e)
        {
            
            if (Convert.ToInt32(MinDexterityTb.Text) <= minMaxWarrior.MinDexterity)
            {
                MinDexterityTb.Text = minMaxWarrior.MinDexterity.ToString();
            }
            else
            {
                iter = Convert.ToInt32(MinDexterityTb.Text);
                iter--;
                MinDexterityTb.Text = iter.ToString();
                point++;
                PointTb.Text = point.ToString();
            }
        }

        private void PlusIntBtn_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt32(MinInteligenceTb.Text) >= minMaxWarrior.MaxInteligence)
            {
                MinInteligenceTb.Text = minMaxWarrior.MaxInteligence.ToString();

            }
            else
            {
                if (Convert.ToInt32(PointTb.Text) <= 0)
                {
                    MessageBox.Show("Не хвататет опыта!");
                }
                else
                {
                    iter = Convert.ToInt32(MinInteligenceTb.Text);
                    iter++;
                    MinInteligenceTb.Text = iter.ToString();
                    point--;
                    PointTb.Text = point.ToString();
                }
                

            }
        }

        private void MinusIntBtn_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt32(MinInteligenceTb.Text) <= minMaxWarrior.MinInteligence)
            {
                MinInteligenceTb.Text = minMaxWarrior.MinInteligence.ToString();
            }
            else
            {
                iter = Convert.ToInt32(MinInteligenceTb.Text);
                iter--;
                MinInteligenceTb.Text = iter.ToString();
                point++;
                PointTb.Text = point.ToString();
            }
        }

        private void PlusVitBtn_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt32(MinVitalityTb.Text) >= minMaxWarrior.MaxVitality)
            {
                MinVitalityTb.Text = minMaxWarrior.MaxVitality.ToString();

            }
            else
            {
                if (Convert.ToInt32(PointTb.Text) <= 0)
                {
                    MessageBox.Show("Не хвататет опыта!");
                }
                else
                {
                    iter = Convert.ToInt32(MinVitalityTb.Text);
                    iter++;
                    MinVitalityTb.Text = iter.ToString();
                    point--;
                    PointTb.Text = point.ToString();

                }
                

            }
        }

        private void MinusVitBtn_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt32(MinVitalityTb.Text) <= minMaxWarrior.MinVitality)
            {
                MinVitalityTb.Text = minMaxWarrior.MinVitality.ToString();
            }
            else
            {
                iter = Convert.ToInt32(MinVitalityTb.Text);
                iter--;
                MinVitalityTb.Text = iter.ToString();
                point++;
                PointTb.Text = point.ToString();
            }
        }

        private void EditUnitUsers_Click(object sender, RoutedEventArgs e)
        {
            CRUD.EditSkillUnit(unitType);
            MinStrengthTb.Text = unitType.MinStrength.ToString();
            MinInteligenceTb.Text = unitType.MinInteligence.ToString();
            MinDexterityTb.Text = unitType.MinDexterity.ToString();
            MinVitalityTb.Text = unitType.MinVitality.ToString();
        }

        private void PludLvlBtn_Click(object sender, RoutedEventArgs e)
        {
               
            if(lvl >= 50)
            {
                MessageBox.Show("Максимальный уровень!");
                lvl = 50;
            }
            else
            {
                lvl ++;
                point += 10;
                LvlTb.Text = lvl.ToString();
                PointTb.Text = point.ToString(); 
            }
            
        }
    }
}
