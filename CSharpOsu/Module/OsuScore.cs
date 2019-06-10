﻿using CSharpOsu.Util.Converters;
using CSharpOsu.Util.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOsu.Module
{
    public class OsuScore : ScoreModel
    {
        public string username { get; set; }

        public DateTime date { get; set; }
        public string rank { get; set; }
        public float pp { get; set; }
        [JsonConverter(typeof(BoolConvert))]
        public bool replay_available { get; set; }
    }
}