using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IpChecker
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }
        
        private void Help_Load(object sender, EventArgs e)
        {
            textBox1.Text = "1. Помощь в программе вызывается сочетанием клавиш Ctrl + H.\r\n\r\n" +
                "2. Программе необходим доступ к интернету, если он отсутствует, программа не будет работать.\r\n\r\n" +
                "3. В начле нужно ввести IP адрес в поле для ввода IP адресов, после чего нажать кнопку \"Пробить\". Программа покажет доступную информацию по этому IP адресу.\r\n\r\n" +
                "4. После того, как информация по IP адресу найдена, можно просмотреть месторасположение этого IP адреса на мировой карте, для этого нужно нажать на кнопку \"Показать на карте\".Программа откроет карту и укажет место маркером.\r\n\r\n" +
                "5. Есть возможность выбрать карту из списка, который появится на левой панели вместе с картой. После выбора другой карты, новая карта автоматически загрузится и укажет на то же место маркером.\r\n\r\n" +
                "6. Горячие клавиши:\r\n" +
                "Ctrl + H — Вызов помощи.\r\n" +
                "Enter — Пробитие IP адреса, находящегося в поле для ввода IP адресов.\r\n" +
                "Левый клик по полю ввода IP адреса — очистка поля.\r\n" +
                "Левый клик по кнопке сохранить — Выбор места сохранения данных.\r\n\r\n" +
                "Существуют IP адреса двух версий IPv4 и IPv6.\r\n" +
                "Ipv4 состоят из четырёх чисел от 0 до 255, раздёленных точкой ( например 1.34.255.56 ).\r\n" +
                "Ipv6 состоят из восьми чисел от 0 до 255 разделённых двоеточием ( например 1:2:13:55:16:105:97:111 ).";
        }

        private void OK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Help_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
                OK_Click(OK, null);
        }
    }
}
