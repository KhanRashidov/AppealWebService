﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using Appeal.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;

namespace Appeal.Entities.Concretes
{
    public partial class File :  IEntity
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public int? FileSize { get; set; }
        public string ContentType { get; set; }
        public byte[] FileContent { get; set; }
        public int InsertedUser { get; set; }
        public DateTime InsertedTime { get; set; }
        public bool Status { get; set; }
    }
}