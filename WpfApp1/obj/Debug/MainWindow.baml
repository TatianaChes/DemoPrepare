   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  Авторизация��5   	   $	��250��6   $	��200��6-   .��5	      � $��Center=�6   $��Center=�6(    � ColumnDefinitions 5
   
   �� 5      6!   �� 5      6!    � RowDefinitions 5   
   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   .+�5   
   �� $��Вход��6   $��Center=�6   $��Center=�6<   $��2��6W   $��5q�6l   �� 5   
   $��
Логин��6   $��Center=�6    $��Center=�6=   $��0��6X   $��1��6h   $��5q�6v   �� 5   
   -   5         ��Name$ login��5      $��30��6!   $	��200��6-   $��1��69   $��1��6I   $��5q�6W   �� 5   
   $��Пароль��6   $��Center=�6!   $��Center=�6>   $��0��6Y   $��2��6i   $��5q�6w   G� 5   
   -   5         G�Name$ password��5      $��30��6(   $	��200��64   $��1��6@   $��2��6P   $��5q�6^   �� 5   
   -   5         ��Name$ enter��5      $��
Войти��6    $��2��60   $��3��6D   $��30��6Q   $	��150��6]   $��5q�6j   6u   �� 5   
   -   5         ��Name$ guest��5      $��2��6   $��4��63   $"��Войти как гость��6@   $��Center=�6Z   $��Center=�6w   $��5q�6�   6�   5      5      