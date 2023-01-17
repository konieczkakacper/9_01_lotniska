namespace lotniska
{
    
    public partial class Form1 : Form
    {
        List<Lotnisko_Csv> lotnisko = new List<Lotnisko_Csv>();

        public Form1()
        {
            InitializeComponent();
            LoadData();
            DisplayInfo();
        }

        private void LoadData()
        {
            string path = "C:\\Users\\konie\\source\\repos\\lotniska\\lotniska\\DaneTestowe.csv";
            string data = File.ReadAllText(path);

            string[] splitnewlin = data.Split("\n");
            string[] resultinfo = splitnewlin.Skip(1).ToArray();

            foreach (string i in resultinfo)
            {
                string[] values = i.Split(",");
                Lotnisko_Csv lotniska = new Lotnisko_Csv();
                if (values.Length > 6)
                {
                    lotniska.miasto = values[0];
                    lotniska.wojewodztwo = values[1];
                    lotniska.ICAO = values[2];
                    lotniska.IATA = values[3];
                    lotniska.nazwa = values[4];
                    lotniska.pasazer = values[5];
                    lotniska.zmiana = values[6];
                    lotnisko.Add(lotniska);
                }
            }

        }
        public class Lotnisko_Csv
        {
            public string miasto { get; set; }
            public string wojewodztwo { get; set; }
            public string ICAO { get; set; }
            public string IATA { get; set; }
            public string nazwa { get; set; }
            public string pasazer { get; set; }
            public string zmiana { get; set; }
        }

        private void DisplayInfo()
        {
            listBox1.DataSource = lotnisko;
            listBox1.DisplayMember= "nazwa";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Lotnisko_Csv pick = (Lotnisko_Csv)listBox1.SelectedItem;

            string res = "";

            if(checkBox1.Checked)
            {
                res += "Glowne miasto portu: " + pick.miasto + "\n";
            }
            if(checkBox2.Checked) 
            {
                res += "Wojewodztwo: " + pick.wojewodztwo + "\n";
            }
            if(checkBox3.Checked) 
            {
                res += "Kod lotniczy ICAO: " + pick.ICAO + "\n";
            }
            if(checkBox4.Checked) 
            {
                res += "Kod lotniczy IATA: " + pick.IATA + "\n";
            }
            if(checkBox5.Checked) 
            {
                res += "Nazwa portu lotniczego: " + pick.nazwa + "\n";
            }
            if(checkBox6.Checked) 
            {
                res += "Liczba pasazerow: " + pick.pasazer + "\n";
            }
            if (checkBox7.Checked) 
            {
                res += "Procentowa zmiana 2018-2019: " + pick.zmiana +"\n";
            }
            if(res != "")
            {
                Form2 info= new Form2(res);
                info.ShowDialog();
            }
        }
    }
}