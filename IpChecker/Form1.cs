using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using Microsoft.Win32;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IpChecker
{
    public partial class Form1 : Form
    {

        [DllImport("user32.dll")]
        public static extern int GetForegroundWindow();
        public bool IsWindowFocus() // Проверка на активность окна
        {
            return GetForegroundWindow() == (int)Handle;
        }
        public Thread receiveThread;
        public bool check;
        public bool openmap = false;
        public string path = ""; // Путь сохранения инфы

        public Form1()
        {
            InitializeComponent();
            ClientSize = new Size(415, 690);
            KeyPreview = true;
            KeyPreview = true;
            Location = new Point(285, 180);

            Map.DragButton = MouseButtons.Left;
            try
            { // Загрузка последней используемой карты с реестра
                string CurrentMap = Registry.LocalMachine.CreateSubKey(@"Software\IPChecker").GetValue("Map").ToString();
                    MapChange.Text = CurrentMap;
                switch (CurrentMap)
                {
                    case "GoogleMap":
                        Map.MapProvider = GMapProviders.GoogleMap;
                        break;
                    case "GoogleTerrainMap":
                        Map.MapProvider = GMapProviders.GoogleTerrainMap;
                        break;
                    case "YandexMap":
                        Map.MapProvider = GMapProviders.YandexMap;
                        break;
                    case "YahooMap":
                        Map.MapProvider = GMapProviders.YahooMap;
                        break;
                    case "BingMap":
                        Map.MapProvider = GMapProviders.BingMap;
                        break;
                    case "CzechMap":
                        Map.MapProvider = GMapProviders.CzechMap;
                        break;
                    case "OpenStreetMap":
                        Map.MapProvider = GMapProviders.OpenStreetMap;
                        break;
                }
            }
            catch { Map.MapProvider = GMapProviders.GoogleMap; }
            Map.MinZoom = 3;
            Map.MaxZoom = 20;
            Map.Zoom = 10;
            Map.ShowCenter = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(IpAdress, "Поле для ввода IP адресов\nНапример 122.25.80.6 или 1:1:87:24:200:155:32:241");
            toolTip2.SetToolTip(button1, "Пробитие информации об IP адресе, она отобразится сверху");
            toolTip3.SetToolTip(button2, "Показ места на карте, по пробитому IP");
            toolTip4.SetToolTip(button5, "Сохранение информации по пробитому IP адресу");
            if (Registry.LocalMachine.CreateSubKey("Software\\IPChecker").GetValue("Help")?.ToString() != "1")
            {
                WindowState = FormWindowState.Normal;
                panel1.BackColor = Color.White;
                foreach (Label l in Controls.OfType<Label>())
                {
                    l.Visible = false;
                }
                button1.Visible = false;
                button2.Visible = false;
                button5.Visible = false;
                IpAdress.Visible = false;
                button3.Visible = true;
                button4.Visible = true;
            }
            else
            {
                timer1.Enabled = true;
            }
        }

        string ip = "";
        //        https://ipwhois.io/ru/documentation
        //        http://free.ipwhois.io/json/1.1.1.1
        //        https://24timezones.com/Iran/time

        /*=================

          Горячие клавиши           

        =====================*/
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
                button1_Click(button1, null);
            /* DELETE */
            if (e.KeyValue == (char)Keys.Down)
                IpAdress.Text = "7.10.101.111";
            /* DELETE */
        }
        private void IpAdress_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                IpAdress.Text = "";
                IpAdress.ContextMenu = new ContextMenu();
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.H && e.Control)
            {
                Help help = new Help();
                help.ShowDialog();
            }
            if (e.KeyCode == Keys.S && e.Control)
                button5_Click(button5, null);
        }

        void Checking()
        {
            Net net = new Net();
            if (net.Connect() == true)
                check = true;
            else
                check = false;
        }

        void Connect(bool check)
        {

            if (check == true)
            {
                if (openmap == true)
                {
                    bool active = IsWindowFocus();
                    if (active == true)
                        WindowState = FormWindowState.Maximized;
                }
                IpAdress.Visible = true;
                pictureBox1.Visible = false;
                panel1.BackColor = Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(218)))));
                foreach (Label l in Controls.OfType<Label>())
                {
                    l.BackColor = Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(218)))));
                    l.Visible = true;
                }
                foreach (Button B in Controls.OfType<Button>())
                {
                    B.Visible = true;
                }
            }
            else
            {
                if (WindowState == FormWindowState.Maximized)
                    openmap = true;
                WindowState = FormWindowState.Normal;
                panel1.BackColor = Color.White;
                foreach (Label l in Controls.OfType<Label>())
                {
                    l.Visible = false;
                }
                foreach (Button B in Controls.OfType<Button>())
                {
                    B.Visible = false;
                }

                IpAdress.Visible = false;
                pictureBox1.BringToFront();
                pictureBox1.Visible = true;
                pictureBox1.Dock = DockStyle.Top;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.Image = Properties.Resources.Error;
                pictureBox1.Location = new Point(0, 0);
                pictureBox1.Size = new Size(427, 690);
            }
        }

        void Parse(string link, Label label) //Парсинг информации
        {
            Task.Run(() =>
            {
                Match value = Regex.Match(ip, link);
                label.Text = value.Groups[1].Value;
                if (label.Text == "")
                    label.Text = "Неизвестно";
            });
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (IpAdress.Text == "")
                MessageBox.Show("Введите какой-нибудь IP адрес", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                try
                {
                    using (WebClient wc = new WebClient())
                        ip = wc.DownloadString($"http://free.ipwhois.io/json/{IpAdress.Text}");
                    {
                        //Страна
                        Parse("\"country\":\"(.*?)\"", Country_res);
                        //Континент
                        Parse("\"continent\":\"(.*?)\"", Continent_res);
                        //Регион
                        Parse("\"region\":\"(.*?)\"", Region_res);
                        //Город
                        Parse("\"city\":\"(.*?)\"", City_res);
                        //Время
                        Parse("\"timezone_gmt\":\"(.*?)\"", Time_res);
                        //Широта
                        Parse("\"latitude\":\"(.*?)\"", Latitude_res);
                        //Долгота
                        Parse("\"longitude\":\"(.*?)\"", Longitude_res);
                        //Валюта
                        Match value = Regex.Match(ip, "\"currency\":\"(.*?)\"");
                        Currencly_res.Text = value.Groups[1].Value;
                        value = Regex.Match(ip, "\"currency_code\":\"(.*?)\"");
                        Currencly_res.Text += "(" + value.Groups[1].Value + ")";
                        //1$ =
                        value = Regex.Match(ip, "\"currency_rates\":\"(.*?)\"");
                        Dollar_res.Text = value.Groups[1].Value;
                        value = Regex.Match(ip, "\"currency_code\":\"(.*?)\"");
                        Dollar_res.Text += "(" + value.Groups[1].Value + ")";
                        //Тип Ip адреса
                        Parse("\"type\":\"(.*?)\"", IpType_res);
                        //Интернет провайдер
                        Parse("\"isp\":\"(.*?)\"", NetProvider_res);
                    }
                }
                catch { }
            }
        }

        private void IpAdress_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(IpAdress.Text, "[^0-9-.-:]"))
            {
                IpAdress.Text = IpAdress.Text.Remove(IpAdress.Text.Length - 1);
                IpAdress.SelectionStart = IpAdress.TextLength;
            }
        }


        /*==============
        
        Карта
        
        ================*/
        private void button2_Click(object sender, EventArgs e)
        {
            if (Longitude_res.Text == "???")
                MessageBox.Show("Сначала пробей какой-нибудь IP адрес", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                try
                {
                    openmap = true;
                    WindowState = FormWindowState.Maximized;
                    Map.Visible = true;
                    int height = Screen.PrimaryScreen.Bounds.Height;
                    int width = Screen.PrimaryScreen.Bounds.Width;
                    Map.Width = width - 430;
                    Map.Height = height - 15;
                    Map.Location = new Point(430, 0);

                    double Lat = Convert.ToDouble(Latitude_res.Text.Replace(".", ","));
                    double Lng = Convert.ToDouble(Longitude_res.Text.Replace(".", ","));
                    Map.Position = new PointLatLng(Lat, Lng);

                    //Маркер
                    PointLatLng Point = new PointLatLng(Lat, Lng);
                    GMapMarker marker = new GMarkerGoogle(Point, GMarkerGoogleType.red_dot);
                    GMapOverlay markers = new GMapOverlay("markers");
                    Map.Overlays.Clear();
                    markers.Markers.Add(marker);
                    Map.Overlays.Add(markers);
                }
                catch { }
            }
        }

        private void MapChange_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MapChange.Text == "Google Map")
            {
                Map.MapProvider = GMapProviders.GoogleMap;
                button2_Click(button2, null);
                try
                {
                    Registry.LocalMachine.CreateSubKey(@"Software\IPChecker").SetValue("Map", "GoogleMap");
                }
                catch { }
            }
            if (MapChange.Text == "GoogleTerrainMap")
            {
                Map.MapProvider = GMapProviders.GoogleTerrainMap;
                button2_Click(button2, null);
                try
                {
                    Registry.LocalMachine.CreateSubKey(@"Software\IPChecker").SetValue("Map", "GoogleTerrainMap");
                }
                catch { }
            }
            if (MapChange.Text == "Yandex Map")
            {
                Map.MapProvider = GMapProviders.YandexMap;
                button2_Click(button2, null);
                try
                {
                    Registry.LocalMachine.CreateSubKey(@"Software\IPChecker").SetValue("Map", "YandexMap");
                }
                catch { }
            }
            if (MapChange.Text == "Yahoo Map")
            {
                Map.MapProvider = GMapProviders.YahooMap;
                button2_Click(button2, null);
                try
                {
                    Registry.LocalMachine.CreateSubKey(@"Software\IPChecker").SetValue("Map", "YahooMap");
                }
                catch { }
            }
            if (MapChange.Text == "Bing Map")
            {
                Map.MapProvider = GMapProviders.BingMap;
                button2_Click(button2, null);
                try
                {
                    Registry.LocalMachine.CreateSubKey(@"Software\IPChecker").SetValue("Map", "BingMap");
                }
                catch { }
            }
            if (MapChange.Text == "Czech Map")
            {
                Map.MapProvider = GMapProviders.CzechMap;
                button2_Click(button2, null);
                try
                {
                    Registry.LocalMachine.CreateSubKey(@"Software\IPChecker").SetValue("Map", "CzechMap");
                }
                catch { }
            }
            if (MapChange.Text == "OpenStreet Map")
            {
                Map.MapProvider = GMapProviders.OpenStreetMap;
                button2_Click(button2, null);
                try
                {
                    Registry.LocalMachine.CreateSubKey(@"Software\IPChecker").SetValue("Map", "OpenStreetMap");
                }
                catch { }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GC.Collect();
            Checking();
            bool active = IsWindowFocus();
            if (active == true)
                Connect(this.check);
            timer1.Interval = 1000;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Registry.LocalMachine.CreateSubKey("Software\\IPChecker").SetValue("Help", "1");
            button3.Visible = false;
            button4.Visible = false;

            IpAdress.Visible = true;
            pictureBox1.Visible = false;
            button1.Visible = true;
            button2.Visible = true;
            button5.Visible = true;
            panel1.BackColor = Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(218)))));
            foreach (Label l in Controls.OfType<Label>())
            {
                l.BackColor = Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(218)))));
                l.Visible = true;
            }
            timer1.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.ShowDialog();
        }

        /*====================
         
             Сохранение
             
        ====================*/
        private void button5_Click(object sender, EventArgs e)
        {
            if (Country_res.Text == "???")
            {
                MessageBox.Show("Сначала нужно пробить IP", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                try
                {
                    if (path == "")
                    {
                        path = Registry.LocalMachine.CreateSubKey(@"Software\IPChecker").GetValue("Path").ToString();
                        using (FileStream file = new FileStream(path + "IpInfo.txt", FileMode.Append))
                        {
                            using (StreamWriter stream = new StreamWriter(file))
                            {

                                stream.WriteLine(IpAdress.Text + "\n");
                                stream.WriteLine($"{Country.Text}  {Country_res.Text}\n{Continent.Text}  {Continent_res.Text}\n{Region.Text}  {Region_res.Text}\n" +
                                    $"{City.Text}  {City_res.Text}\n{Time.Text}  {Time_res.Text}\n{Latitude.Text}  {Latitude_res.Text}\n{Longitude.Text}  {Longitude_res.Text}" +
                                    $"\n{Currencly.Text}  {Currencly_res.Text}\n{Dollar.Text}  {Dollar_res.Text}\n{IpType.Text}  {IpType_res.Text}\n{NetProvider.Text}  {NetProvider_res.Text}\n");
                            }
                        }
                        MessageBox.Show($"Данные сохранены по пути {path}IpInfo.txt", "Сохранение прошло успешно", MessageBoxButtons.OK);
                    }

                    else
                    {
                        using (FileStream file = new FileStream(path + "IpInfo.txt", FileMode.Append))
                        {
                            using (StreamWriter stream = new StreamWriter(file))
                            {

                                stream.WriteLine(IpAdress.Text + "\n");
                                stream.WriteLine($"{Country.Text}  {Country_res.Text}\n{Continent.Text}  {Continent_res.Text}\n{Region.Text}  {Region_res.Text}\n" +
                                    $"{City.Text}  {City_res.Text}\n{Time.Text}  {Time_res.Text}\n{Latitude.Text}  {Latitude_res.Text}\n{Longitude.Text}  {Longitude_res.Text}" +
                                    $"\n{Currencly.Text}  {Currencly_res.Text}\n{Dollar.Text}  {Dollar_res.Text}\n{IpType.Text}  {IpType_res.Text}\n{NetProvider.Text}  {NetProvider_res.Text}\n");
                            }
                        }
                        MessageBox.Show($"Данные сохранены по пути {path}IpInfo.txt", "Сохранение прошло успешно", MessageBoxButtons.OK);
                    }
                }
                catch
                {
                    MessageBox.Show($"Не уадалось сохранить информацию об IP, укажите место сохранения данных(Ctrl + H - помощь)", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void button5_MouseDown(object sender, MouseEventArgs e) //Выбор папки для сохранения
        {
            if (e.Button == MouseButtons.Right)
            {
                using (var path_dialog = new FolderBrowserDialog())
                    if (path_dialog.ShowDialog() == DialogResult.OK)
                    {
                        //Путь к директории
                        path = path_dialog.SelectedPath;
                        MessageBox.Show("Путь сохранения изменён на \"" + path_dialog.SelectedPath.ToString() + "\"");
                        if (path.LastIndexOf("\\") != path.Length-1)
                            path += "\\";
                        Registry.LocalMachine.CreateSubKey(@"Software\IPChecker").SetValue("Path", path);
                    };
            }
        }
    }
}