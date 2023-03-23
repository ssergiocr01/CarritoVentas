using System;
using System.Collections.Generic;

namespace CarritoVentas.Models.Models;

public partial class Venta
{
    public int IdVenta { get; set; }

    public int? IdCliente { get; set; }

    public int? TotalProducto { get; set; }

    public decimal? MontoTotal { get; set; }

    public string? Contacto { get; set; }

    public string? IdDistrito { get; set; }

    public string? Telefono { get; set; }

    public string? Direccion { get; set; }

    public string? IdTransaccion { get; set; }

    public DateTime? FechaVenta { get; set; }

    public virtual ICollection<DetalleVenta> DetalleVenta { get; } = new List<DetalleVenta>();

    public virtual Cliente? IdClienteNavigation { get; set; }
}
