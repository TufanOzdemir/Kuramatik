using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kuramatik
{
    public partial class Kuramatik : Form
    {
        public Kuramatik()
        {
            InitializeComponent();
        }

        private void ListAddButtons(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (!string.IsNullOrEmpty(valueTextBox.Text))
            {
                if (button.Tag.ToString() == "main")
                {
                    mainListbox.Items.Add(valueTextBox.Text);
                }
                else if (button.Tag.ToString() == "choose")
                {
                    chooseListbox.Items.Add(valueTextBox.Text);
                }
                valueTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Değer alanı boş geçilemez!");
            }
        }

        private void DeleteButtons(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Bu işlemi yapmak istediğinize emin misiniz?", "Uyarı!", buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                if(button.Tag.ToString() == "reset")
                {
                    mainListbox.Items.Clear();
                    chooseListbox.Items.Clear();
                }
                else if(button.Tag.ToString() == "main")
                {
                    mainListbox.Items.Clear();
                }
                else if (button.Tag.ToString() == "choose")
                {
                    chooseListbox.Items.Clear();
                }
                else if (button.Tag.ToString() == "mainItem")
                {
                    if(mainListbox.SelectedItem == null)
                    {
                        return;
                    }
                    mainListbox.Items.Remove(mainListbox.SelectedItem);
                }
                else if (button.Tag.ToString() == "chooseItem")
                {
                    if (chooseListbox.SelectedItem == null)
                    {
                        return;
                    }
                    chooseListbox.Items.Remove(chooseListbox.SelectedItem);
                }
            }
        }

        private void MoveButtons(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            ListItemTransport(button.Tag.ToString());
        }

        private void ListItemTransport(string tag)
        {
            object selected;
            if (tag == "right")
            {
                if (mainListbox.SelectedItem == null)
                {
                    return;
                }
                selected = mainListbox.SelectedItem;
                chooseListbox.Items.Add(selected);
                mainListbox.Items.Remove(selected);
            }
            else if (tag == "left")
            {
                if (chooseListbox.SelectedItem == null)
                {
                    return;
                }
                selected = chooseListbox.SelectedItem;
                mainListbox.Items.Add(selected);
                chooseListbox.Items.Remove(selected);
            }
        }

        private void RandomChooseButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int count = mainListbox.Items.Count;

            if(count == 0)
            {
                MessageBox.Show("Lütfen ana listeye eleman ekleyin!");
                return;
            }
            int randomNumber = random.Next(0, count);
            mainListbox.SelectedIndex = randomNumber;
            string name = mainListbox.SelectedItem.ToString();
            ListItemTransport("right");
            MessageBox.Show(name + " kurada seçildi!");
        }

        private void Info(object sender, EventArgs e)
        {
            MessageBox.Show("Uygulama Tufan Özdemir tarafından yapılmış olup, IEEE Malatya ekibinin kullanımına sunulmuştur!");
        }
    }
}
