   M S B A M L   `   `   `  ����D  @Warehouse, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Warehouse	Warehouse  5   	       Warehouse.CustomerWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Warehouse     5   	   -   5          � Title$  	Customers��5   	   $	��490��6   $	��450��6(    � 
ResizeMode$ CanMinimize=�6K   .��5	      � .+�5
   
   �� $��Available customers��6   $
��Left=�6.   $��
130,10,0,0q�6I   $	��Top=�6]   $��20(�6u   &   System.Windows.Controls.DataGrid  5   
   -   5        $��CustomerDataGrid��5      $
��Left=�6+   $��	10,50,0,0q�6F   $	��Top=�6Y   $	��360��6q   $	��420��6~   $��20(�6�      
IsReadOnly . 6�   �� 5   
   -   5         ��Name$ AddCustomerButton��5      $��Add Customer��6,   $
��Left=�6C   $��
10,410,0,0q�6^   $	��Top=�6r   $��40��6�   $	��210��6�   $��20(�6�   6�   �� 5   
   -   5        $ RemoveCustomerButton��5      $��Remove Customer��6/   $
��Left=�6I   $��220,410,0,0q�6d   $	��Top=�6y   $��40��6�   $	��210��6�   $��20(�6�   $��2��6�   5      5      