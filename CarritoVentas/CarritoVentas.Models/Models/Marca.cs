﻿using System;
using System.Collections.Generic;

namespace CarritoVentas.Models.Models;

public partial class Marca
{
    public int IdMarca { get; set; }

    public string? Descripcion { get; set; }

    public bool? Activo { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual ICollection<Producto> Productos { get; } = new List<Producto>();
}
