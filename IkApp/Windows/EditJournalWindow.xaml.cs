using IkApp.Model;
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
using System.Windows.Shapes;

namespace IkApp.Windows
{
    /// <summary>
    /// Логика взаимодействия для EditJournalWindow.xaml
    /// </summary>
    public partial class EditJournalWindow : Window
    {
        BibEntities bibEntities = new BibEntities();
        Journal _journal = new Journal();

        public EditJournalWindow()
        {
            InitializeComponent();
        }

        public EditJournalWindow(Journal journal)
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            if (ModelCheck())
            {
                try
                {


                    if (_journal.Id == 0)
                    {
                        Journal tempJournal = bibEntities.Journal.FirstOrDefault(u => u.Id == _journal.Id);
                        tempJournal.I = I.Text;
                        tempJournal.F = F.Text;
                        tempJournal.O = O.Text;
                        tempJournal.IdBook = (bool)IdBook.Text;




                        Kniga tempKniga = bibEntities.Kniga.FirstOrDefault(u => u.Id == _kniga.Id);
                        tempKniga.Author = Author.Text;
                        tempKniga.Name = Name.Text;
                        tempKniga.MestoIzdaniya = Mesto.Text;
                        tempKniga.RazdelSistematicheskogoKataloga = Razdel.Text;
                        tempKniga.Keyword = Keyword.Text;
                        tempKniga.NoteToEmployees = NoteToEmployees.Text;
                        tempKniga.GodIzdaniya = (DateTime)God.SelectedDate;
                        tempKniga.KodInventarnoyKnigi = KodComboBox.SelectedIndex + 1;
                        tempKniga.Availability = (bool)Availability.IsChecked;
                        MessageBox.Show("книга изменена");
                    }
                }
            }


        }

        private bool ModelCheck()
        {
            StringBuilder error = new StringBuilder();
            if (F.Text == "")
                error.AppendLine("Укажите фамилию");
            if (I.Text == "")
                error.AppendLine("Укажите имя");
            if (IdBook.Text == "")
                error.AppendLine("Укажите № книги");
            if (IdBook.Text == "")
                error.AppendLine("Укажите статус бронироания");


            if (error.Length > 0)
            {
                MessageBox.Show(error.ToString());
                return false;
            }
            else
                return true;
        }

    }
}
