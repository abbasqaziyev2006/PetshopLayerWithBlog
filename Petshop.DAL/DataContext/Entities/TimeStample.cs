﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Petshop.DAL.DataContext.Entities;

public class TimeStample : Entity
{
    public DateTime CreatedAt { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime? UpdateAt { get; set; }

    //public string? CreatedBy {  get; set; }
    //public string? UpdatedBy { get;set; }
}
