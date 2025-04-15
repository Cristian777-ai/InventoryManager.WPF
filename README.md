# 📦 InventoryManager.WPF

Una aplicación de escritorio desarrollada en C# con WPF y base de datos SQLite para gestionar productos de inventario. Ideal para puntos de venta, gestión de stock y prácticas profesionales.

---

## 🚀 Funcionalidades principales

✅ Interfaz moderna con WPF  
✅ CRUD completo de productos  
✅ Base de datos local con SQLite  
✅ DataGrid editable y responsivo  
✅ Almacenamiento persistente  
✅ Código limpio y mantenible  

---

## 📁 Estructura del proyecto

```
InventoryManager.WPF/
├── Models/             # Modelo Producto.cs
├── Data/               # AppDbContext con EF Core
├── Migrations/         # Archivos de migración EF
├── MainWindow.xaml     # Interfaz principal
├── App.xaml            # Configuración de aplicación
├── inventory.db        # Base de datos SQLite
```

---

## 🛠 Tecnologías utilizadas

- C# con WPF (.NET)
- Entity Framework Core
- SQLite
- MVVM simplificado
- Visual Studio

---

## 🧪 Cómo usar la app localmente

```bash
git clone https://github.com/tuusuario/InventoryManager.WPF.git
cd InventoryManager.WPF
dotnet restore
dotnet ef database update
dotnet run
```

---

## ✨ Captura de pantalla (opcional)

> Agrega aquí una imagen de la interfaz si quieres mejorar la presentación visual.

---

## 👤 Autor

Desarrollado por [Cristian Stiven Ramírez Giraldo](https://www.linkedin.com/in/cristianstivenramirezgiraldo/)