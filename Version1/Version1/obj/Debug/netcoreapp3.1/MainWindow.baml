   M S B A M L   `   `   `  ����C  ?Version1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:Version1Version1  5   	       Version1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Version1     5   	     � Title$  Game of Life��5   	   $	��900��5	   	   $	��900��6   $��	Helvetica)�5
   	   $��16(�6     � UseLayoutRounding$
 True��5   	    � WindowStartupLocation$ CenterScreen=�5   	   $��1q�5   	    � 
ResizeMode$ NoResize=�5   	   .��5      � -   5        $��MainGrid��5       � ShowGridLines$ False��6   $
 True��61   $
}�True��6J    � RowDefinitions 5   
   �� 5      $
��auto �6    � ColumnDefinitions 5   
   �� 5      $
��auto �6   .+�5   
   �� -   5         ��Name$ autoGenerator��5      $��0��6(   $��0��68   
���   �$��
10,10,10,1q�6f   $��50��6z   .��6�   Start6�   �� 5   
   -   5        $ Reset��5      $��0��6    $��1��60   
���   �$��	10,1,10,1q�6_   .��6r   Reset6y   �� 5   
   -   5        $ 	generator��5      $��0��6$   $��2��64   
���   �$��	10,1,10,1q�6h   .��6{   Generate Once6�   �� 5   
   -   5        $ 
exitButton��5      $��0��6%   $��3��65   
���   �$��	10,1,10,1q�6j   .��6}   Exit6�   5      5      