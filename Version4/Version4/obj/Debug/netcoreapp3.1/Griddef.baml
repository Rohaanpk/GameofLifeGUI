   M S B A M L   `   `   `  ����C  ?Version4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:Version4Version4  5   	       Version4.Griddef   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Version4     5   	   $��	Helvetica)�5   	   $��16(�6      � Title$  Griddef��5	   	   $	��400��6   $	��800��6&    � 
ResizeMode$ NoResize=�62   .��5
      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��50 �6   �� 5      $
��Auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��Center=�6   $
��Auto��61   $��3��6>   $��0��6R    �� Padding$ 10, 10, 10, 10q�6_   $��36(�6x   Please Choose your Grid Size5      �� 5   
   -   5         ��Name$ 
GridSlider��5      $
��Auto��6%   $��0��62   $��1��6B   $��3��6O    � Minimum$ 10Q�6c    � Maximum$ 50Q�6p   $��Center=�6}    �� IsSnapToTickEnabled$
 True��6�   	 �� TickFrequency$	 1Q�6�   
 � Value$
 20Q�6�   �� 5   
   $��Center=�6   $
��auto��61   $��1��6>   $��2��6R   $ 10 10 10 10q�6_   $��36(�6u   �� 5      $�Grid Size =��6    �� 5      �6   ��  �� ElementName$ 
GridSlider�� �� Path$ Value�5       �� 5"   
   -   5         ��Name$ RunApp��5"      $
��Auto��6!   $��3��6.   $��3��6;   $��20, 20, 20, 20q�6O   $8��2Please click this button to confirm the grid size.��6g   6�   5#      5$      