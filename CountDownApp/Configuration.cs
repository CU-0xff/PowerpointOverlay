﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace CountDownApp
{
    public class Configuration
    {
        public bool IsLoaded = false;

        public int MarqueeSpeed { get; set; }
        public bool AutoCenterX { get; set; }

        public string FontName { get; set; }
        public float FontSize { get; set; }

        public System.Drawing.Point Location { get; set; }

        public System.Drawing.Color FontColor { get; set; }

        public SortedList<DateTime, ProgramEntry> program { get; set; }
        
        public Configuration ShallowCopy()
        {
            return (Configuration)this.MemberwiseClone();
        }

        public void ParseJSON(JObject raw_config)
        {
            JObject config = JObject.Parse(@"{
                'FontName' : 'Microsoft Sans Serif',
                'FontSize' : 32.0,
                'AutoCenterX' : 'True',
                'Location' : { 'X' : 20, 'Y' : 100 },
                'FontColor': { 'R' : 255, 'G' : 128, 'B' : 0},
                'MarqueeSpeed' : '5',
                'Program' : [ 
                    {'Text' : 'Django Dance and Limbo Mumbo Jitter Ditter Hango Dango Plumbo Mumbo Django Dance and Limbo Mumbo Jitter Ditter Hango Dango Plumbo Mumbo - Paulseph',
                     'TimeStart' : '7:25 PM',
                     'TimeEnd' : '8:00 PM'},
                    {'Text' : 'Mumbay Libretto - Hayley',
                     'TimeStart' : '8:25 PM',
                     'TimeEnd' : '9:00 PM'},
                    {'Text' : 'Mumbay Libretto - Hayley',
                     'TimeStart' : '9:00 PM',
                     'TimeEnd' : '10:00 PM'}]
             }");

            MarqueeSpeed = (int)config.SelectToken("MarqueeSpeed");
            FontName = (string)config.SelectToken("FontName");
            FontSize = (float)config.SelectToken("FontSize");
            FontColor = System.Drawing.Color.FromArgb((int)config.SelectToken("FontColor.R"), (int)config.SelectToken("FontColor.G"), (int)config.SelectToken("FontColor.B"));

            Location = new System.Drawing.Point((int)config.SelectToken("Location.X"), (int)config.SelectToken("Location.Y"));

            AutoCenterX = Boolean.Parse((string)config.SelectToken("AutoCenterX")); 
            JEnumerable<JToken> programTokens = config.SelectToken("Program").Children();

            program = new SortedList<DateTime, ProgramEntry>();

            foreach (var item in programTokens)
            {
                var newEntry = new ProgramEntry();
                newEntry.Text = (string)item.SelectToken("Text");
                newEntry.start = DateTime.Parse((string)item.SelectToken("TimeStart"));
                newEntry.end = DateTime.Parse((string)item.SelectToken("TimeEnd"));

                program.Add(newEntry.start, newEntry);
            }

            IsLoaded = true;
        }
    }
}
