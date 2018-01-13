using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace JARVIS
{
    public class Weather
    {
        public string[] getWeather()
        {
            //Gets weather for area
            string findWeather = String.Format("http://weather.yahooapis.com/forecastrss?w=22165");

            //Get XML from webpage from the webpage
            XmlDocument wData = new XmlDocument();
            wData.Load(findWeather);

            XmlNamespaceManager manager = new XmlNamespaceManager(wData.NameTable);
            manager.AddNamespace("yweather", "http://xml.weather.yahoo.com/ns/rss/1.0");

            XmlNode channel = wData.SelectSingleNode("rss").SelectSingleNode("channel");
            XmlNodeList nodes = wData.SelectNodes("/rss/channel/item/yweather:forecast", manager);

            //Get each attribute
            string tempC = channel.SelectSingleNode("item").SelectSingleNode("yweather:condition", manager).Attributes["temp"].Value;
            string condition = channel.SelectSingleNode("item").SelectSingleNode("yweather:condition", manager).Attributes["text"].Value;
            string wind = channel.SelectSingleNode("yweather:wind", manager).Attributes["speed"].Value;
            string high = channel.SelectSingleNode("item").SelectSingleNode("yweather:forecast", manager).Attributes["high"].Value;
            string low = channel.SelectSingleNode("item").SelectSingleNode("yweather:forecast", manager).Attributes["low"].Value;
            string forecastCond = channel.SelectSingleNode("item").SelectSingleNode("yweather:forecast", manager).Attributes["text"].Value;
            string forecastHigh = channel.SelectSingleNode("item").SelectSingleNode("yweather:forecast", manager).Attributes["high"].Value;
            string forecastLow = channel.SelectSingleNode("item").SelectSingleNode("yweather:forecast", manager).Attributes["low"].Value;

            string[] foundConditions = new string[8];
            foundConditions[1] = (((Convert.ToInt32(tempC) - 32) * 5) / 9).ToString();
            foundConditions[0] = condition;
            foundConditions[2] = wind;
            foundConditions[3] = (((Convert.ToInt32(high) - 32) * 5) / 9).ToString();
            foundConditions[4] = (((Convert.ToInt32(low) - 32) * 5) / 9).ToString();
            foundConditions[5] = forecastCond;
            foundConditions[6] = (((Convert.ToInt32(forecastHigh) - 32) * 5) / 9).ToString();
            foundConditions[7] = (((Convert.ToInt32(forecastLow) - 32) * 5) / 9).ToString();

            return foundConditions;
        }
    }
}
