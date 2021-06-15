using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace FnF_Character_Reverser
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string src = "";

        int countWords(string Data, string Word)
        {
            int Count = 0;
            foreach (Match m in Regex.Matches(Data, Word))
            {
                Count++;
            }
            return Count;
        }

        private void Form2_Load(object sender, EventArgs e) //spaghetti code pls dont look
        {
            if (countWords(src, "                        ") != 0)
            {
                //pretty printed charts
                int LeftNotesBF = countWords(src, ",0\n                        ,");
                int DownNotesBF = countWords(src, ",1\n                        ,");
                int UpNotesBF = countWords(src, ",2\n                        ,");
                int RightNotesBF = countWords(src, ",3\n                        ,");

                int LeftNotesOS = countWords(src, ",4\n                        ,");
                int DownNotesOS = countWords(src, ",5\n                        ,");
                int UpNotesOS = countWords(src, ",6\n                        ,");
                int RightNotesOS = countWords(src, ",7\n                        ,");

                int NotesBF = LeftNotesBF + DownNotesBF + UpNotesBF + RightNotesBF;
                int NotesOS = LeftNotesOS + DownNotesOS + UpNotesOS + RightNotesOS;

                label33.Text = "Left notes: " + LeftNotesBF;
                label30.Text = "Down notes: " + DownNotesBF;
                label29.Text = "Up notes: " + UpNotesBF;
                label24.Text = "Right notes: " + RightNotesBF;
                label32.Text = "Notes: " + NotesBF;
                

                label22.Text = "Left notes: " + LeftNotesOS;
                label21.Text = "Down notes: " + DownNotesOS;
                label20.Text = "Up notes: " + UpNotesOS;
                label16.Text = "Right notes: " + RightNotesOS;
                label5.Text = "Notes: " + NotesOS;

            } else
            {
                int LeftNotesBF = countWords(src, ",0,");
                int DownNotesBF = countWords(src, ",1,");
                int UpNotesBF = countWords(src, ",2,");
                int RightNotesBF = countWords(src, ",3,");

                int LeftNotesOS = countWords(src, ",4,");
                int DownNotesOS = countWords(src, ",5,");
                int UpNotesOS = countWords(src, ",6,");
                int RightNotesOS = countWords(src, ",7,");

                int NotesBF = LeftNotesBF + DownNotesBF + UpNotesBF + RightNotesBF;
                int NotesOS = LeftNotesOS + DownNotesOS + UpNotesOS + RightNotesOS;

                label33.Text = "Left notes: " + LeftNotesBF;
                label30.Text = "Down notes: " + DownNotesBF;
                label29.Text = "Up notes: " + UpNotesBF;
                label24.Text = "Right notes: " + RightNotesBF;
                label32.Text = "Notes: " + NotesBF;

                label22.Text = "Left notes: " + LeftNotesOS;
                label21.Text = "Down notes: " + DownNotesOS;
                label20.Text = "Up notes: " + UpNotesOS;
                label16.Text = "Right notes: " + RightNotesOS;
                label5.Text = "Notes: " + NotesOS;
            }
            //sliders dont work if somebody wants to help me out cause idk how to detect the [0,1,2,3,4,5,6,7],[holdtime]
            /*
            label11.Text = "Left sliders: " + countWords(src, ",0,").ToString();
            label12.Text = "Down sliders: " + countWords(src, ",1,").ToString();
            label13.Text = "Up sliders: " + countWords(src, ",2,").ToString();
            label14.Text = "Right sliders: " + countWords(src, ",3,").ToString();

            label18.Text = "Left sliders: " + countWords(src, ",4,").ToString();
            label19.Text = "Down sliders: " + countWords(src, ",5,").ToString();
            label17.Text = "Up sliders: " + countWords(src, ",6,").ToString();
            label15.Text = "Right sliders: " + countWords(src, ",7,").ToString();

            //pretty printed charts
            label11.Text = "Left sliders: " + countWords(src, ",0\n                        ,").ToString();
            label12.Text = "Down sliders: " + countWords(src, ",1\n                        ,").ToString();
            label13.Text = "Up sliders: " + countWords(src, ",2\n                        ,").ToString();
            label14.Text = "Right sliders: " + countWords(src, ",3\n                        ,").ToString();

            label18.Text = "Left sliders: " + countWords(src, ",4\n                        ,").ToString();
            label19.Text = "Down sliders: " + countWords(src, ",5\n                        ,").ToString();
            label17.Text = "Up sliders: " + countWords(src, ",6\n                        ,").ToString();
            label15.Text = "Right sliders: " + countWords(src, ",7\n                        ,").ToString();
            */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }
    }
}
