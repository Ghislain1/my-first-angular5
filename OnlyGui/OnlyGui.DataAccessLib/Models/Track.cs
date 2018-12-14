﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OnlyGui.DataAccessLib.Models
{
    public class Track
    {
        public int AlbumId { get; set; }
        public int Bytes { get; set; }
        public int Id { get; set; }
        public string Length { get; set; }
        public string SongName { get; set; }
        public decimal UnitPrice { get; set; }

        public override string ToString()
        {
            return SongName;
        }
    }
}