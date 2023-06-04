using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace inventory_managemnt_system.Models
{
    public class Computer
    {
        public int ID { get; set; }
        public int SerialNum { get; set; }
        public string RoomNum { get; set; }
        public string desc { get; set; }
        public string operatingSystem { get; set; }
        public string owner { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
    }
}
