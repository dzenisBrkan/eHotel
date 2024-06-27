﻿using System.ComponentModel.DataAnnotations;

namespace eHotel.eHotel.Model;

public class Korisnici
{
    [Key]
    public int KorisnikId { get; set; }

    public string Ime { get; set; } = null!;

    public string Prezime { get; set; } = null!;

    public string? Email { get; set; }

    public string? Telefon { get; set; }

    public string KorisnickoIme { get; set; } = null!;

    public bool? Status { get; set; }
    public virtual ICollection<KorisniciUloge> KorisniciUloges { get; } = new List<KorisniciUloge>();
}
