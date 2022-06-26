using System.Windows;
using System.Xml;

namespace z1
{
    /// <summary>
    /// Логика взаимодействия для xmlAddWindows.xaml
    /// </summary>
    public partial class xmlAddWindows : Window
    {
        public string path = "";
        static XmlDocument xDoc;
        static XmlElement xRoot;

        public xmlAddWindows()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            var point_of_departure = pointOfDeparture.Text;
            var number = busNumber.Text;
            var dest = destination.Text;


            if (point_of_departure != string.Empty && number != string.Empty && dest != string.Empty)
            {
                XmlElement userElem = xDoc.CreateElement($"book");

                // создаем атрибут name
                XmlAttribute pointOfDeparture = xDoc.CreateAttribute($"pointOfDeparture");
                XmlElement companyElem = xDoc.CreateElement($"busNumber");
                XmlElement destin = xDoc.CreateElement("destination");



                // создаем текстовые значения для элементов и атрибута
                XmlText point = xDoc.CreateTextNode($"{point_of_departure}");
                XmlText bus_number = xDoc.CreateTextNode($"{number}");
                XmlText destination = xDoc.CreateTextNode($"{dest}");

                //добавляем узлы
                pointOfDeparture.AppendChild(point);
                companyElem.AppendChild(bus_number);
                destin.AppendChild(destination);
                userElem.Attributes.Append(pointOfDeparture);
                userElem.AppendChild(companyElem);
                userElem.AppendChild(destin);
                xRoot.AppendChild(userElem);
                xDoc.Save(path);

                MessageBox.Show("Запись успено добавлена!");
            }
            else MessageBox.Show("Заполните поля!");
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                xDoc = new XmlDocument();
                xDoc.Load(path);
                xRoot = xDoc.DocumentElement;
            }
            catch (System.Exception)
            {
                this.Close();
                MessageBox.Show("Неверный путь к файлу!", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
