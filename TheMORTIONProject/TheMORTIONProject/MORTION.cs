using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace TheMORTIONProject
{
    public partial class frmMORTION : Form
    {
        SpeechRecognitionEngine Jarvis = new SpeechRecognitionEngine();

        string Temperature;
        string Condition;
        string Humidity;
        string WindSpeed;
        string Town;
        string TFCond;
        string TFHigh;
        string TFLow;
      
        Random rnd = new Random();

        public frmMORTION()
        {
            InitializeComponent();
          
        }
        private void frmMORTION_Load(object sender, EventArgs e)
        {
            GetWeather();
            lblWeather.Text = convertToCelcius(int.Parse(Temperature)).ToString("#") + " °C";

            Choices commands = new Choices();
            commands.Add(new string[] { "say hello", "print my name" });
            GrammarBuilder gBuilder = new GrammarBuilder();
            gBuilder.Append(commands);
            Grammar grammar = new Grammar(gBuilder);

        //    Jarvis.LoadGrammar(grammar);

            Jarvis.SetInputToDefaultAudioDevice();


        }


        private double convertToCelcius(int Temperature)
        {
            return (Temperature - 32) / 1.8;
        }



        private void GetWeather()
        {

            string query = String.Format("http://weather.yahooapis.com/forecastrss?w=970985");
            XmlDocument wData = new XmlDocument();
            wData.Load(query);

            XmlNamespaceManager manager = new XmlNamespaceManager(wData.NameTable);
            manager.AddNamespace("yweather", "http://xml.weather.yahoo.com/ns/rss/1.0");

            XmlNode channel = wData.SelectSingleNode("rss").SelectSingleNode("channel");
            XmlNodeList nodes = wData.SelectNodes("/rss/channel/item/yweather:forecast", manager);

            Temperature = channel.SelectSingleNode("item").SelectSingleNode("yweather:condition", manager).Attributes["temp"].Value;
            Condition = channel.SelectSingleNode("item").SelectSingleNode("yweather:condition", manager).Attributes["text"].Value;
            Humidity = channel.SelectSingleNode("yweather:atmosphere", manager).Attributes["humidity"].Value;
            WindSpeed = channel.SelectSingleNode("yweather:wind", manager).Attributes["speed"].Value;
            Town = channel.SelectSingleNode("yweather:location", manager).Attributes["city"].Value;
            TFCond = channel.SelectSingleNode("item", manager).SelectSingleNode("yweather:forecast", manager).Attributes["text"].Value;
            TFHigh = channel.SelectSingleNode("item", manager).SelectSingleNode("yweather:forecast", manager).Attributes["high"].Value;
            TFLow = channel.SelectSingleNode("item", manager).SelectSingleNode("yweather:forecast", manager).Attributes["low"].Value;
        }

       
       
    }
}
