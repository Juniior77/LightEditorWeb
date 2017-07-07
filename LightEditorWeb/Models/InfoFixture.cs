using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LightEditorWeb.Models
{
    public class InfoFixture
    {
        public string id            { get; set; }
        public string marque        { get; set; }
        public string version       { get; set; }
        public string type          { get; set; }
        public string lamp_type     { get; set; }
        public string lamp_power    { get; set; }
        public string beam          { get; set; }
        public string beam_angle    { get; set; }
        public string pan_angle     { get; set; }
        public string pan_speed     { get; set; }
        public string tilt_angle    { get; set; }
        public string tilt_speed    { get; set; }
    }
}