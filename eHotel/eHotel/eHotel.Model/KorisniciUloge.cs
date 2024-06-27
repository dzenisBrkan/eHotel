﻿using System.ComponentModel.DataAnnotations;

namespace eHotel.eHotel.Model;

public class KorisniciUloge
{
    [Key]
    public int KorisnikUlogaId { get; set; }

    public int KorisnikId { get; set; }

    public int UlogaId { get; set; }

    public DateTime DatumIzmjene { get; set; }

    public virtual Uloge Uloga { get; set; } = null!;
}
