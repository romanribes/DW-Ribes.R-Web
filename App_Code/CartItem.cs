using System;
using System.Collections.Generic;
using System.Web;

/// <summary>
/// Elemento de un carrito de compras
/// </summary>
public class CartItem
{
    public int ProductoID {get; set; }
	public string IdiomaManual { get; set; }
	public decimal Precio { get; set; }
}
