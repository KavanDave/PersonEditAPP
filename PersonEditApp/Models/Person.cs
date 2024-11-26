using System;
using System.Collections.Generic;

namespace PersonEditApp.Models;

public partial class Person
{
    public int Id { get; set; }

    public string Fname { get; set; }

    public string Lname { get; set; }

    public string Email { get; set; }

    public string Phone { get; set; }

    public string Pass { get; set; }
}
