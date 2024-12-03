using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            listSubjectMain.Items.Add("Hoa");
            listSubjectMain.Items.Add("Toan");
            listSubjectMain.Items.Add("Anh Van");
            listSubjectMain.Items.Add("Ngu Van");
            listSubjectMain.Items.Add("Vat Ly");
            listSubjectMain.Items.Add("Lich Su");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string mainSubject = listSubjectMain.SelectedItem.ToString() + "_" + mainSubjectScore.Value.ToString();
            int length = listStudents.Items.Count;
            double literature = Convert.ToDouble(literatureScore.Value);
            double math = Convert.ToDouble(MathScore.Value);
            double english = Convert.ToDouble(englishScore.Value);
            double totalScore = ((literature + math) * 2)  + english;
            listStudents.Items.Add(name);
            listStudents.Items[length].SubItems.Add(literature.ToString("#.#0"));
            listStudents.Items[length].SubItems.Add(math.ToString("#.#0"));
            listStudents.Items[length].SubItems.Add(english.ToString("#.#0"));
            listStudents.Items[length].SubItems.Add(mainSubject);
            listStudents.Items[length].SubItems.Add(totalScore.ToString("#.#0"));

        }

        string stringChange(string text)
        {
            string result = "";
            int index = 0;
            while (text[index] != '_')
            {
                result += text[index];
                index++;
            }

            return result;
        }
        bool search(string name, ListView list)
        {
            for(int i=0; i<list.Items.Count; i++)
            {
                if (list.Items[i].SubItems[0].Text == name) return true;
            }
            return false;
        }
        private void btnStatistical_Click(object sender, EventArgs e)
        {
            for(int i=0; i < listStudents.Items.Count; i++)
            {
                string subject = stringChange(listStudents.Items[i].SubItems[4].Text);
                
                if(!search(subject, mainSubjectStatistical))
                {
                    int count = 0;
                    for(int j=0; j<listStudents.Items.Count; j++)
                    {
                        string another_subject = stringChange(listStudents.Items[j].SubItems[4].Text);
                        if (subject == another_subject) count++;
                    }
                    int currentLength = mainSubjectStatistical.Items.Count;
                    mainSubjectStatistical.Items.Add(subject);
                    mainSubjectStatistical.Items[currentLength].SubItems.Add(count.ToString());
                }
          
            }
            
        }
    }
}
