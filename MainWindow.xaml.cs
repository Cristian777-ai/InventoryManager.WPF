using InventoryManager.WPF.Data;
using InventoryManager.WPF.Models;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace InventoryManager.WPF;

public partial class MainWindow : Window
{
    private ObservableCollection<Producto> productos;

    public MainWindow()
    {
        InitializeComponent();
        CargarProductos();
    }

    private void CargarProductos()
    {
        using var db = new AppDbContext();
        productos = new ObservableCollection<Producto>(db.Productos.ToList());
        dgProductos.ItemsSource = productos;
    }

    private void Agregar_Click(object sender, RoutedEventArgs e)
    {
        using var db = new AppDbContext();

        var producto = new Producto
        {
            Nombre = txtNombre.Text,
            Categoria = txtCategoria.Text,
            Precio = decimal.TryParse(txtPrecio.Text, out var precio) ? precio : 0,
            Stock = int.TryParse(txtStock.Text, out var stock) ? stock : 0
        };

        db.Productos.Add(producto);
        db.SaveChanges();

        productos.Add(producto);

        txtNombre.Clear();
        txtCategoria.Clear();
        txtPrecio.Clear();
        txtStock.Clear();
    }

    private void Eliminar_Click(object sender, RoutedEventArgs e)
    {
        if (dgProductos.SelectedItem is Producto seleccionado)
        {
            using var db = new AppDbContext();
            db.Productos.Remove(seleccionado);
            db.SaveChanges();
            productos.Remove(seleccionado);
        }
    }

    private void dgProductos_RowEditEnding(object sender, DataGridRowEditEndingEventArgs e)
    {
        if (e.EditAction == DataGridEditAction.Commit)
        {
            var productoEditado = e.Row.Item as Producto;

            if (productoEditado != null)
            {
                using var db = new AppDbContext();
                db.Productos.Update(productoEditado);
                db.SaveChanges();
            }
        }
    }
}
