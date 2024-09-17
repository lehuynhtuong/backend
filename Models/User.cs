using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using BackEnd.Models;

namespace BackEnd.Models;

[Table("User")]
public partial class User
{
    public long id { get; set; }

    public string? email { get; set; }

    public string? full_name { get; set; }

    public string? password { get; set; }

    public string? role { get; set; }
}
