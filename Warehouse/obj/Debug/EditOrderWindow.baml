   M S B A M L   `   `   `  ����D  @Warehouse, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Warehouse	Warehouse  5   	       Warehouse.EditOrderWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Warehouse     5   	   -   5          � Title$  EditOrderWindow��5   	   $	��230��6!   $	��330��6.    � WindowStyle$
 None=�6:    � 
ResizeMode$ CanMinimize=�6�   .��5	      � .+�5
   
   �� $��	Customer:��6   $
��Left=�6$   $��	10,10,0,0q�6?   $	��Top=�6R   $��20(�6j   �� 5   
   -   5        $��CustomerNameComboBox��5      $
��Left=�6/   $��
120,10,0,0q�6J   $	��Top=�6^   $	��200��6v   $��40��6�   $��20(�6�   �� 5   
   $��Product:��6   $
��Left=�6#   $��	10,60,0,0q�6>   $	��Top=�6Q   $��20(�6i   $��40��6w   �� 5   
   -   5        $��ProductNameComboBox��5      $
��Left=�6.   $��
120,60,0,0q�6I   $	��Top=�6]   $	��200��6u   $��40��6�   $��20(�6�   �� 5   
   $��	Quantity:��6   $
��Left=�6$   $��
10,110,0,0q�6?   $	��Top=�6S   $��20(�6k   �� 5   
   -   5        $��QuantityTextBox��5      $
��Left=�6)   $	��Top=�6D   $��40��6\   $	��200��6h   $��120,110,0,0q�6t   $��Center=�6�   $��20(�6�    �� 	MaxLength$ 4��6�   �� 5   
   -   5        $��
SaveButton��5      $
��Save��6#   $
��Left=�62   $��
10,170,0,0q�6M   $	��Top=�6a   $��40��6y   $	��150��6�   $��20(�6�   6�   �� 5   
   -   5        $��DiscardButton��5      $��Discard��6&   $
��Left=�68   $��165,170,0,0q�6S   $	��Top=�6h   $��40��6�   $	��150��6�   $��20(�6�   6�   5      5      