   M S B A M L   `   `   `  ����D  @Warehouse, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Warehouse	Warehouse  5   	       Warehouse.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Warehouse     5   	   -   5          � Title$  	Warehouse��5   	   $	��550��6   $	��880��6(    � 
ResizeMode$ CanMinimize=�6K   .��5	      � .+�5
   
   �� -   5        $��ConnectButton��5
      $��Connect��6&   $
��Left=�68   $	��Top=�6S   $��40��6k   $	��200��6w   $��20(�6�   6�   �� 5   
   -   5        $��CustomerButton��5      $��	Customers��6'   $
��Left=�6;   $��	200,0,0,0q�6V   $	��Top=�6i   $��40��6�   $	��200��6�   $��20(�6�   6�   �� 5   
   -   5        $��
PlotButton��5      $
��Plot��6#   $
��Left=�62   $��	400,0,0,0q�6M   $	��Top=�6`   $��40��6x   $	��200��6�   $��20(�6�   6�   �� 5   
   $
��Left=�6   $��	600,0,0,0q�6,   $	��Top=�6?   $��40��6W   $	��274��6c   &   System.Windows.Controls.DataGrid  5   
   -   5        $��ProductDataGrid��5      $
��Left=�6*   $	��360��6E   $	��420��6R   $��
10,110,0,0q�6^   $	��Top=�6r      
IsReadOnly . $��20(�6�   �� 5   
   $%��Available products in warehouse��6   $
��Left=�6:   $��	35,60,0,0q�6U   $	��Top=�6h   $��24(�6�   �� 5   
   -   5        $��AddProductButton��5      $��Add Product��6)   $
��Left=�6?   $��
10,470,0,0q�6Z   $	��Top=�6n   $��40��6�   $	��210��6�   $��20(�6�   6�   �� 5   
   -   5        $��RemoveProductButton��5      $��Remove Product��6,   $
��Left=�6E   $��220,470,0,0q�6`   $	��Top=�6u   $��40��6�   $	��210��6�   $��20(�6�   6�     5   
   -   5        $��OrderDataGrid��5      $
��Left=�6(   $	��360��6C   $	��420��6P   $��440,110,0,0q�6\   $	��Top=�6q    . $��20(�6�   6�   �� 5   
   $��Pending orders��6   $
��Left=�6)   $��
565,60,0,0q�6D   $	��Top=�6X   $��24(�6p   �� 5   
   -	   5        $��CreateOrderButton��5      $��Create Order��6*   $
��Left=�6A   $��440,470,0,0q�6\   $	��Top=�6q   $��40��6�   $	��210��6�   $��20(�6�   6�   �� 5   
   -
   5        $��DeleteOrderButton��5      $��Delete Order��6*   $
��Left=�6A   $��650,470,0,0q�6\   $	��Top=�6q   $��40��6�   $	��210��6�   $��20(�6�   6�   5      5      