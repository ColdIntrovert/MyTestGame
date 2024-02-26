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
using MyTestGame.Classes;
using MyTestGame.MongoDB;
using MyTestGame.Pages;

namespace MyTestGame.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddUnit.xaml
    /// </summary>
    public partial class AddUnit : Page
    {
        public static UnitType unitType;
        public static UnitType unitWarrior;
        public static UnitType unitRogue;
        public static UnitType unitWizard;
        public AddUnit()
        {
            InitializeComponent();
            unitWarrior = CRUD.GetUnit("Warrior");
            WarStrengthTb.Text = (unitWarrior.MinStrength).ToString() + "/" + (unitWarrior.MaxStrength).ToString();
            WarInteligenceTb.Text = (unitWarrior.MinInteligence).ToString() + "/" + (unitWarrior.MaxInteligence).ToString();
            WarDexterityTb.Text = (unitWarrior.MinDexterity).ToString() + "/" + (unitWarrior.MaxDexterity).ToString();
            WarVitalityTb.Text = (unitWarrior.MinVitality).ToString() + "/" + (unitWarrior.MaxVitality).ToString();

            unitRogue = CRUD.GetUnit("Rogue");
            RogStrengthTb.Text = (unitRogue.MinStrength).ToString() + "/" + (unitRogue.MaxStrength).ToString();
            RogInteligenceTb.Text = (unitRogue.MinInteligence).ToString() + "/" + (unitRogue.MaxInteligence).ToString();
            RogDexterityTb.Text = (unitRogue.MinDexterity).ToString() + "/" + (unitRogue.MaxDexterity).ToString();
            RogVitalityTb.Text = (unitRogue.MinVitality).ToString() + "/" + (unitRogue.MaxVitality).ToString();

            unitWizard = CRUD.GetUnit("Warrior");
            WizStrengthTb.Text = (unitWizard.MinStrength).ToString() + "/" + (unitWizard.MaxStrength).ToString();
            WizInteligenceTb.Text = (unitWizard.MinInteligence).ToString() + "/" + (unitWizard.MaxInteligence).ToString();
            WizDexterityTb.Text = (unitWizard.MinDexterity).ToString() + "/" + (unitWizard.MaxDexterity).ToString();
            WizVitalityTb.Text = (unitWizard.MinVitality).ToString() + "/" + (unitWizard.MaxVitality).ToString();
        }

        private void WarriorImg_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(NickNameTb.Text == "")
            {
                MessageBox.Show("Напишите имя пользователя:");

            }
            else
            {
                //unitWarrior.Name = NickNameTb.Text;
                //CRUD.CreateUser(unitWarrior);
                App.users = unitWarrior;
                NavigationService.Navigate(new CreateUnit("Warrior"));

            }
        }

        private void RogueImg_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (NickNameTb.Text == "")
            {
                MessageBox.Show("Напишите имя пользователя:");

            }
            else
            {
                unitRogue.Name = NickNameTb.Text;
                CRUD.CreateUser(unitWarrior);
                App.users = unitRogue;
                NavigationService.Navigate(new CreateUnit("Rogue"));

            }
        }
    }
}
