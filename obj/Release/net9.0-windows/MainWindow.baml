   M S B A M L   `   `   `  ����   InventoryManager.WPF%    InventoryManager.WPF.MainWindow   W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  Sistema de Inventario��$	��500��$	��800��.��� $��10q� � RowDefinitions �� $
��Auto ��� $��* ��� $
��Auto �.+���  �� Orientation$ 
Horizontal=�$��0 0 0 10q�.+��� $��5q�.+��� $��Nombre���� -    ��Name$ 	txtNombre��$	��120���� $��5q�.+��� $��
Categoría���� -   $ txtCategoria��$	��120���� $��5q�.+��� $��Precio���� -   $ 	txtPrecio��$��80���� $��5q�.+��� $��Stock���� -   $ txtStock��$��80���� -   $��Agregar��$��80��$��5q�&   System.Windows.Controls.DataGrid  -     Name$ dgProductos��$��1��   AutoGenerateColumns$ False��   CanUserAddRows$ False��$��0 0 0 10q�   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ ID��	   
IsReadOnly$
	 True��1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 �� *Id+  $ Nombre��
 �� *Nombre+  $ 
Categoría��
 �� *	Categoria+  $ Precio��
 �� *Precio+  $ Stock��
 �� *Stock+�� -   $��Eliminar seleccionado��$��2��$��30��