﻿using shcool.Models.Person;

namespace shcool.Models.Teacher
{
    public class TeacherInfo : InfoPerson
    {
        public int Id { get; set; }
        public string Melicode { get; set; }
        public string Htadris { get; set; }
    }
}
