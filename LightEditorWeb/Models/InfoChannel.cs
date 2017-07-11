using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LightEditorWeb.Models
{
    public class InfoChannel
    {
        public InfoChannel()
        {
            listInfoChannel = new List<ItemChannel>();
        }
        public List<ItemChannel> listInfoChannel { get; set; }
    }
    public class ItemChannel
    {
        public ItemChannel()
        {
            listValueDMX = new List<InfoValueDMX>();
        }
        public int channel { get; set; }
        public string fonction { get; set; }
        public string image { get; set; }
        public List<InfoValueDMX> listValueDMX { get; set; }
    }
}