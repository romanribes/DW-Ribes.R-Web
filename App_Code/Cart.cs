using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Carrito de compra de MitjaMarkt
/// </summary>
public class Cart
{
    private List<CartItem> _Items = new List<CartItem>();

	public List<CartItem> Items { get { return _Items; } }

    public decimal TotalValue { get { return _Items.Sum(p => p.Precio); } }

    public void AddItem(int productoID, string idioma, decimal precio)
    {
        _Items.Add(new CartItem { ProductoID = productoID, IdiomaManual = idioma, Precio = precio });
    }

    public void Clear()
    {
        this._Items.Clear();
    }

    public void RemoveItem(int index)
    {
        this._Items.RemoveAt(index);
    }

}
