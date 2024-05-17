using System;

namespace tehenAdatok
{
    public partial class Form1 : Form
    {
        string[] Cows = {
            "CAE3;4;17","CAE3;3;21","BAB1F2;6;28","BA;5;16","H7;2;24","BAB2;4;21","D1;0;30","BA;2;27",
            "DF;4;26","CAB1;3;27","CAE3;6;22","BA;1;26","BAB1F2AS;0;28","BAB2;2;30","CAA8FV;0;18","BAB5;5;24",
            "D1;4;20","DF;6;22","H7;0;24","CAB1;4;25","BA;6;25","H7C2;6;19","CAA8;0;16","BAB1F2AS;4;15",
            "BAB5;2;18","DFG2;0;29","H7;3;27","CAE3;0;21","DF;0;22","D1;5;28","D1;1;27","DFG2;2;24",
            "CAA8;3;17","BAB1;2;25","H7C2;3;16","CA;4;22","DFG2;6;28","BAB1;6;20","CAA8;4;23","BAB1F2SC;6;25",
            "BAB1F2AS;1;18","CAB1;2;26","BAB1F2SC;0;30","H7;4;23","H7C2;5;29","BAB5;6;17","DFF1;3;20","CAB1;6;30",
            "CAA8;1;17","BAB1;5;20","BAB5;0;26","CB;5;17","H7S3;6;18","BAB1;3;18","CAA8;2;30","BAB1F2AS;5;25",
            "CAA8FV;4;16","H7S3;5;23","BA;4;28","BAB2;5;21","CAB1;1;24","DFF1;5;27","BAB1F2AS;2;17","DFF1;6;25",
            "DFF1;4;23","CA;2;20","DFG2;4;17","DF;1;20","D1;6;18","CAE3;2;27","CAA8;5;30","BAB2;3;28",
            "DFG2;3;18","BAB1F2SC;2;30","CB;4;16","BAB1F2AS;3;15","BAB1F2SC;3;22","DFG2;1;18","BA;3;17","CB;6;17",
            "BAB1F2;4;21","DFF1;0;27","BAB2;0;18","CB;2;24","H7S3;3;24","BAB2;6;16","CAB1;0;30","CA;6;27",
            "BAB1F2SC;1;25","BAB1F2SC;4;26","BAB2;1;27","CAA8FV;2;20","H7;5;24","CA;0;21","BAB1F2AS;6;24","H7S3;0;28",
            "H7;1;17","MKW1;3;18","BAB1F2;3;25","CB;3;15","MKW1;5;20","DFG2;5;25","CAA8;6;22","CA;3;20",
            "H7C2;0;30","BAB1;0;18","H7C2;4;16","CAA8FV;6;23","D1;3;26","TF;2;20","TF;4;20","H7C2;2;15",
            "CAB1;5;29","H7S3;1;23","DFF1;1;23","CAA8FV;1;15","CB;1;15","BAB1;1;23","D1;2;30","DF;3;15",
            "CA;1;15","CAE3;1;19","H7S3;4;16","H7;6;17","H7S3;2;29","DF;2;16","BAB1F2;2;29","CAA8FV;5;18",
            "BAB5;1;29"
        };
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("H�tf�");
            comboBox1.Items.Add("Kedd");
            comboBox1.Items.Add("Szerda");
            comboBox1.Items.Add("Cs�t�rt�k");
            comboBox1.Items.Add("P�ntek");
            comboBox1.Items.Add("Szombat");
            comboBox1.Items.Add("Vas�rnap");
            comboBox1.SelectedIndex = 2;
            trackBar1.Value = 20;
            label6.Text = "Be�ll�tott �rt�k: " + trackBar1.Value.ToString() + " liter";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label6.Text = "Be�l�tott �rt�k: " + trackBar1.Value.ToString() + " liter";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string azon = textBox1.Text;
            int nap = comboBox1.SelectedIndex;
            int fejes_menny = trackBar1.Value;
            string tazon = "";
            int tnap = 0;
            int tfejes_menny = 0;
            foreach (var i in Cows)
            {
                tazon = i.Split(";")[0];
                tnap = int.Parse(i.Split(";")[1]);
                tfejes_menny= int.Parse(i.Split(";")[2]);
                    if (azon == tazon && nap == tnap)
                    {
                        if (tfejes_menny == 0)  MessageBox.Show("Nem volt fej�s");
                        if (tfejes_menny < fejes_menny) MessageBox.Show("Az adott napon a mennyis�g nem �rte el a limitet");
                        if (tfejes_menny >= fejes_menny) MessageBox.Show($"Az adott mennyis�g {tfejes_menny} liter volt");
                    }
            }
            bool talalt = false;
            foreach (var i in Cows)
            {
                tazon = i.Split(";")[0];
                if (tazon == azon) talalt = true;
            }
            if(talalt==false) MessageBox.Show("Nem volt fej�s");
        }
    }
}
