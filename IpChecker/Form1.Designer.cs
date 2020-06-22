namespace IpChecker
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.IpAdress = new System.Windows.Forms.TextBox();
            this.Country = new System.Windows.Forms.Label();
            this.Continent = new System.Windows.Forms.Label();
            this.Region = new System.Windows.Forms.Label();
            this.City = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.Country_res = new System.Windows.Forms.Label();
            this.Continent_res = new System.Windows.Forms.Label();
            this.Region_res = new System.Windows.Forms.Label();
            this.City_res = new System.Windows.Forms.Label();
            this.Time_res = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Latitude = new System.Windows.Forms.Label();
            this.Longitude = new System.Windows.Forms.Label();
            this.Currencly = new System.Windows.Forms.Label();
            this.Dollar = new System.Windows.Forms.Label();
            this.IpType = new System.Windows.Forms.Label();
            this.NetProvider = new System.Windows.Forms.Label();
            this.Latitude_res = new System.Windows.Forms.Label();
            this.Longitude_res = new System.Windows.Forms.Label();
            this.Currencly_res = new System.Windows.Forms.Label();
            this.Dollar_res = new System.Windows.Forms.Label();
            this.IpType_res = new System.Windows.Forms.Label();
            this.NetProvider_res = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MapChange = new System.Windows.Forms.ComboBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Map = new GMap.NET.WindowsForms.GMapControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите Ip адрес: ";
            // 
            // IpAdress
            // 
            this.IpAdress.Location = new System.Drawing.Point(205, 46);
            this.IpAdress.Name = "IpAdress";
            this.IpAdress.Size = new System.Drawing.Size(126, 26);
            this.IpAdress.TabIndex = 1;
            this.IpAdress.TextChanged += new System.EventHandler(this.IpAdress_TextChanged);
            this.IpAdress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.IpAdress.MouseDown += new System.Windows.Forms.MouseEventHandler(this.IpAdress_MouseDown);
            // 
            // Country
            // 
            this.Country.AutoSize = true;
            this.Country.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.Country.Location = new System.Drawing.Point(65, 110);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(77, 25);
            this.Country.TabIndex = 2;
            this.Country.Text = "Страна:";
            // 
            // Continent
            // 
            this.Continent.AutoSize = true;
            this.Continent.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.Continent.Location = new System.Drawing.Point(65, 150);
            this.Continent.Name = "Continent";
            this.Continent.Size = new System.Drawing.Size(104, 25);
            this.Continent.TabIndex = 3;
            this.Continent.Text = "Континент:";
            // 
            // Region
            // 
            this.Region.AutoSize = true;
            this.Region.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.Region.Location = new System.Drawing.Point(65, 190);
            this.Region.Name = "Region";
            this.Region.Size = new System.Drawing.Size(75, 25);
            this.Region.TabIndex = 4;
            this.Region.Text = "Регион:";
            // 
            // City
            // 
            this.City.AutoSize = true;
            this.City.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.City.Location = new System.Drawing.Point(65, 230);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(67, 25);
            this.City.TabIndex = 5;
            this.City.Text = "Город:";
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.Time.Location = new System.Drawing.Point(65, 270);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(71, 25);
            this.Time.TabIndex = 6;
            this.Time.Text = "Время:";
            // 
            // Country_res
            // 
            this.Country_res.AutoSize = true;
            this.Country_res.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.Country_res.Location = new System.Drawing.Point(245, 110);
            this.Country_res.MaximumSize = new System.Drawing.Size(160, 0);
            this.Country_res.Name = "Country_res";
            this.Country_res.Size = new System.Drawing.Size(39, 25);
            this.Country_res.TabIndex = 7;
            this.Country_res.Text = "???";
            // 
            // Continent_res
            // 
            this.Continent_res.AutoSize = true;
            this.Continent_res.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.Continent_res.Location = new System.Drawing.Point(245, 150);
            this.Continent_res.MaximumSize = new System.Drawing.Size(160, 0);
            this.Continent_res.Name = "Continent_res";
            this.Continent_res.Size = new System.Drawing.Size(39, 25);
            this.Continent_res.TabIndex = 8;
            this.Continent_res.Text = "???";
            // 
            // Region_res
            // 
            this.Region_res.AutoSize = true;
            this.Region_res.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.Region_res.Location = new System.Drawing.Point(245, 190);
            this.Region_res.MaximumSize = new System.Drawing.Size(160, 0);
            this.Region_res.Name = "Region_res";
            this.Region_res.Size = new System.Drawing.Size(39, 25);
            this.Region_res.TabIndex = 9;
            this.Region_res.Text = "???";
            // 
            // City_res
            // 
            this.City_res.AutoSize = true;
            this.City_res.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.City_res.Location = new System.Drawing.Point(245, 230);
            this.City_res.MaximumSize = new System.Drawing.Size(160, 0);
            this.City_res.Name = "City_res";
            this.City_res.Size = new System.Drawing.Size(39, 25);
            this.City_res.TabIndex = 10;
            this.City_res.Text = "???";
            // 
            // Time_res
            // 
            this.Time_res.AutoSize = true;
            this.Time_res.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.Time_res.Location = new System.Drawing.Point(245, 270);
            this.Time_res.MaximumSize = new System.Drawing.Size(160, 0);
            this.Time_res.Name = "Time_res";
            this.Time_res.Size = new System.Drawing.Size(39, 25);
            this.Time_res.TabIndex = 11;
            this.Time_res.Text = "???";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.button1.Location = new System.Drawing.Point(57, 582);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "Пробить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Latitude
            // 
            this.Latitude.AutoSize = true;
            this.Latitude.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.Latitude.Location = new System.Drawing.Point(65, 310);
            this.Latitude.Name = "Latitude";
            this.Latitude.Size = new System.Drawing.Size(79, 25);
            this.Latitude.TabIndex = 13;
            this.Latitude.Text = "Широта:";
            // 
            // Longitude
            // 
            this.Longitude.AutoSize = true;
            this.Longitude.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.Longitude.Location = new System.Drawing.Point(65, 350);
            this.Longitude.Name = "Longitude";
            this.Longitude.Size = new System.Drawing.Size(85, 25);
            this.Longitude.TabIndex = 14;
            this.Longitude.Text = "Долгота:";
            // 
            // Currencly
            // 
            this.Currencly.AutoSize = true;
            this.Currencly.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.Currencly.Location = new System.Drawing.Point(65, 390);
            this.Currencly.Name = "Currencly";
            this.Currencly.Size = new System.Drawing.Size(79, 25);
            this.Currencly.TabIndex = 15;
            this.Currencly.Text = "Валюта:";
            // 
            // Dollar
            // 
            this.Dollar.AutoSize = true;
            this.Dollar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.Dollar.Location = new System.Drawing.Point(65, 430);
            this.Dollar.Name = "Dollar";
            this.Dollar.Size = new System.Drawing.Size(53, 25);
            this.Dollar.TabIndex = 16;
            this.Dollar.Text = "1$ =";
            // 
            // IpType
            // 
            this.IpType.AutoSize = true;
            this.IpType.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.IpType.Location = new System.Drawing.Point(65, 470);
            this.IpType.Name = "IpType";
            this.IpType.Size = new System.Drawing.Size(134, 25);
            this.IpType.TabIndex = 17;
            this.IpType.Text = "Тип IP адреса:";
            // 
            // NetProvider
            // 
            this.NetProvider.AutoSize = true;
            this.NetProvider.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.NetProvider.Location = new System.Drawing.Point(65, 510);
            this.NetProvider.Name = "NetProvider";
            this.NetProvider.Size = new System.Drawing.Size(191, 25);
            this.NetProvider.TabIndex = 18;
            this.NetProvider.Text = "Интернет провайдер:";
            // 
            // Latitude_res
            // 
            this.Latitude_res.AutoSize = true;
            this.Latitude_res.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.Latitude_res.Location = new System.Drawing.Point(245, 310);
            this.Latitude_res.MaximumSize = new System.Drawing.Size(160, 0);
            this.Latitude_res.Name = "Latitude_res";
            this.Latitude_res.Size = new System.Drawing.Size(39, 25);
            this.Latitude_res.TabIndex = 7;
            this.Latitude_res.Text = "???";
            // 
            // Longitude_res
            // 
            this.Longitude_res.AutoSize = true;
            this.Longitude_res.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.Longitude_res.Location = new System.Drawing.Point(245, 350);
            this.Longitude_res.MaximumSize = new System.Drawing.Size(160, 0);
            this.Longitude_res.Name = "Longitude_res";
            this.Longitude_res.Size = new System.Drawing.Size(39, 25);
            this.Longitude_res.TabIndex = 8;
            this.Longitude_res.Text = "???";
            // 
            // Currencly_res
            // 
            this.Currencly_res.AutoSize = true;
            this.Currencly_res.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.Currencly_res.Location = new System.Drawing.Point(245, 390);
            this.Currencly_res.MaximumSize = new System.Drawing.Size(160, 0);
            this.Currencly_res.Name = "Currencly_res";
            this.Currencly_res.Size = new System.Drawing.Size(39, 25);
            this.Currencly_res.TabIndex = 9;
            this.Currencly_res.Text = "???";
            // 
            // Dollar_res
            // 
            this.Dollar_res.AutoSize = true;
            this.Dollar_res.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.Dollar_res.Location = new System.Drawing.Point(245, 430);
            this.Dollar_res.MaximumSize = new System.Drawing.Size(160, 0);
            this.Dollar_res.Name = "Dollar_res";
            this.Dollar_res.Size = new System.Drawing.Size(39, 25);
            this.Dollar_res.TabIndex = 10;
            this.Dollar_res.Text = "???";
            // 
            // IpType_res
            // 
            this.IpType_res.AutoSize = true;
            this.IpType_res.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.IpType_res.Location = new System.Drawing.Point(245, 470);
            this.IpType_res.MaximumSize = new System.Drawing.Size(160, 0);
            this.IpType_res.Name = "IpType_res";
            this.IpType_res.Size = new System.Drawing.Size(39, 25);
            this.IpType_res.TabIndex = 11;
            this.IpType_res.Text = "???";
            // 
            // NetProvider_res
            // 
            this.NetProvider_res.AutoSize = true;
            this.NetProvider_res.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.NetProvider_res.Location = new System.Drawing.Point(245, 510);
            this.NetProvider_res.MaximumSize = new System.Drawing.Size(160, 0);
            this.NetProvider_res.Name = "NetProvider_res";
            this.NetProvider_res.Size = new System.Drawing.Size(39, 25);
            this.NetProvider_res.TabIndex = 11;
            this.NetProvider_res.Text = "???";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.MapChange);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MaximumSize = new System.Drawing.Size(430, 0);
            this.panel1.MinimumSize = new System.Drawing.Size(430, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 852);
            this.panel1.TabIndex = 22;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(427, 0);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // MapChange
            // 
            this.MapChange.FormattingEnabled = true;
            this.MapChange.Items.AddRange(new object[] {
            "Google Map",
            "GoogleTerrainMap",
            "Yandex Map",
            "Bing Map",
            "Czech Map",
            "OpenStreet Map"});
            this.MapChange.Location = new System.Drawing.Point(57, 690);
            this.MapChange.Name = "MapChange";
            this.MapChange.Size = new System.Drawing.Size(314, 28);
            this.MapChange.TabIndex = 4;
            this.MapChange.Text = "Карта";
            this.MapChange.SelectedIndexChanged += new System.EventHandler(this.MapChange_SelectedIndexChanged);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 852);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.button2.Location = new System.Drawing.Point(224, 582);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 42);
            this.button2.TabIndex = 2;
            this.button2.Text = "Показать на карте";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(109, 352);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(213, 117);
            this.button3.TabIndex = 2;
            this.button3.Text = "Я сам знаю";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(109, 203);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(213, 117);
            this.button4.TabIndex = 2;
            this.button4.Text = "Как протльзоваться программой";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.button5.Location = new System.Drawing.Point(142, 637);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(147, 42);
            this.button5.TabIndex = 2;
            this.button5.Text = "Сохранить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            this.button5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button5_MouseDown);
            // 
            // Map
            // 
            this.Map.Bearing = 0F;
            this.Map.CanDragMap = true;
            this.Map.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Map.EmptyTileColor = System.Drawing.Color.Navy;
            this.Map.GrayScaleMode = false;
            this.Map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.Map.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.Map.LevelsKeepInMemory = 5;
            this.Map.Location = new System.Drawing.Point(514, 0);
            this.Map.MarkersEnabled = true;
            this.Map.MaxZoom = 20;
            this.Map.MinimumSize = new System.Drawing.Size(500, 500);
            this.Map.MinZoom = 0;
            this.Map.MouseWheelZoomEnabled = true;
            this.Map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionWithoutCenter;
            this.Map.Name = "Map";
            this.Map.NegativeMode = false;
            this.Map.PolygonsEnabled = false;
            this.Map.RetryLoadTile = 0;
            this.Map.RoutesEnabled = false;
            this.Map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.Map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.Map.ShowTileGridLines = false;
            this.Map.Size = new System.Drawing.Size(699, 860);
            this.Map.TabIndex = 21;
            this.Map.Visible = false;
            this.Map.Zoom = 2D;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(415, 852);
            this.Controls.Add(this.Map);
            this.Controls.Add(this.NetProvider);
            this.Controls.Add(this.IpType);
            this.Controls.Add(this.Dollar);
            this.Controls.Add(this.Currencly);
            this.Controls.Add(this.Longitude);
            this.Controls.Add(this.Latitude);
            this.Controls.Add(this.NetProvider_res);
            this.Controls.Add(this.IpType_res);
            this.Controls.Add(this.Time_res);
            this.Controls.Add(this.Dollar_res);
            this.Controls.Add(this.City_res);
            this.Controls.Add(this.Currencly_res);
            this.Controls.Add(this.Region_res);
            this.Controls.Add(this.Longitude_res);
            this.Controls.Add(this.Continent_res);
            this.Controls.Add(this.Latitude_res);
            this.Controls.Add(this.Country_res);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.City);
            this.Controls.Add(this.Region);
            this.Controls.Add(this.Continent);
            this.Controls.Add(this.Country);
            this.Controls.Add(this.IpAdress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IpChecker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IpAdress;
        private System.Windows.Forms.Label Country;
        private System.Windows.Forms.Label Continent;
        private System.Windows.Forms.Label Region;
        private System.Windows.Forms.Label City;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label Country_res;
        private System.Windows.Forms.Label Continent_res;
        private System.Windows.Forms.Label Region_res;
        private System.Windows.Forms.Label City_res;
        private System.Windows.Forms.Label Time_res;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Latitude;
        private System.Windows.Forms.Label Longitude;
        private System.Windows.Forms.Label Currencly;
        private System.Windows.Forms.Label Dollar;
        private System.Windows.Forms.Label IpType;
        private System.Windows.Forms.Label NetProvider;
        private System.Windows.Forms.Label Latitude_res;
        private System.Windows.Forms.Label Longitude_res;
        private System.Windows.Forms.Label Currencly_res;
        private System.Windows.Forms.Label Dollar_res;
        private System.Windows.Forms.Label IpType_res;
        private System.Windows.Forms.Label NetProvider_res;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Splitter splitter1;
        public GMap.NET.WindowsForms.GMapControl Map;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox MapChange;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip4;
    }
}

