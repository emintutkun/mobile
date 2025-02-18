﻿using OgrenciProjeCodeFirst.Models.Data;
using OgrenciProjeCodeFirst.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OgrenciProjeCodeFirst.Models.Views
{
    public class StudentModel
    {
        public Student Student { get; set; }
        public string BtnValue { get; set; }
        public string BtnClass { get; set; }
        public string Header { get; set; }
        public List<CityDTO> cityList { get; set; }
    }
}