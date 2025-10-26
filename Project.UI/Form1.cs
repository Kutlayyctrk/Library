using Project.Bll.DesingPatterns.RepositoryPattern.EFConcretes;
using Project.Entity.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.UI
{
    public partial class Form1 : Form
    {
        AuthorRepository authorRepository;
        public Form1()
        {
            InitializeComponent();
            authorRepository = new AuthorRepository();
            LstAuthor.DisplayMember = "Name";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            LstAuthor.DataSource = authorRepository.GetActives();

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Author a = new Author
            {
                Name = TxtName.Text
            };
            authorRepository.Create(a);
            Listele();
        }

        Author _selected;
        private void LstAuthor_Click(object sender, EventArgs e)
        {
            if (LstAuthor.SelectedItem != null)
            {
                _selected = LstAuthor.SelectedItem as Author;
                TxtName.Text = _selected.Name;
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (_selected != null)
            {
                _selected.Name = TxtName.Text;
                authorRepository.Update(_selected);
                Listele();
                TxtName.Text = string.Empty;
                LstAuthor.SelectedItem = -1;
            }
            else
            {
                MessageBox.Show("Önce Listeden seçim yapın.");
            }
        }

        private void BtnSoftDelete_Click(object sender, EventArgs e)
        {
            if (_selected != null)
            {
                authorRepository.SoftDelete(_selected.Id);
                TxtName.Text = string.Empty;
                Listele();
            }
        }

        private void BtnHardDelete_Click(object sender, EventArgs e)
        {
            if(_selected != null)
            {
                authorRepository.HardDelete(_selected.Id);
                TxtName.Text= string.Empty;
                Listele();
            }
        }

        private void BtnActiveEntity_Click(object sender, EventArgs e)
        {
            LstAuthor.DataSource = authorRepository.GetActives();
        }

        private void BtnPassiveEntity_Click(object sender, EventArgs e)
        {
            LstAuthor.DataSource = authorRepository.GetPassives();
        }

        private void BtnUpdatedEntity_Click(object sender, EventArgs e)
        {
            LstAuthor.DataSource = authorRepository.GetUpdates();
        }

        private void BtnAllEntity_Click(object sender, EventArgs e)
        {
            LstAuthor.DataSource=authorRepository.GetAll();
        }
    }
}
