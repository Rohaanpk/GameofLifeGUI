   M S B A M L   `   `   `  ����C  ?Version4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:Version4Version4  5   	       Version4.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Version4     5   	     � Title$  Game of Life��5   	   $	��900��5	   	   $	��900��6   $��	Helvetica)�5
   	   $��16(�6     � UseLayoutRounding$
 True��5   	    � WindowStartupLocation$ CenterScreen=�5   	   $��1q�5   	    � 
ResizeMode$ NoResize=�5   	   .��5      � -   5        $��MainGrid��5       � ShowGridLines$ False��6   $
 True��61   $
}�True��6J    � RowDefinitions 5   
   �� 5      $
��auto �6    � ColumnDefinitions 5   
   �� 5      $
��auto �6   .+�5   
   �� -   5         ��Name$ Generations��5      $�� ��6%   $
��auto��60   $��5q�6=   $��30��6I   $��314,6,-349,59q�6U   �� 5   
   -   5        $ 
AliveCells��5      $�� ��6$   $
��Auto��6/   $��5q�6<   $��30��6H   $��314,38,-349,28q�6T   �� 5   
   -   5        $ Delay��5       J� RenderTransformOrigin$ 100,0&�6    $��Delay:��6>   $��Center=�6O   $	��Top=�6m   $��30��6�   $	��150��6�   $��0,13,0,0q�6�   �� 5   
   -   5        $ MS��5      $
��(ms)��6   $��40��6+   $��30��66   $��92,10,20,43q�6B   �� 5   
   -   5        	 ��Name$	 autoGenerator��5      $��50��66   
���   �$��173,10,-161,33q�6V   .��6n   Start6u   �� 5   
   -   5        
 ��Name$
 SpeedSlider��5       � Minimum$ 1Q�6&    �� IsSnapToTickEnabled$
 True��62    �� TickFrequency$ 1Q�6M    � Maximum$	 500Q�6_   $��
0,48,12,23q�6m    � Value$	 200Q�6�   �� 5   
   -   5         ��Name$ SpeedInt��5       �� 	MaxLength$ 3��6$    �� TextAlignment$ Center=�62   $��Center=�6I   $��30��6k   $��56,10,61,43q�6w   ��6�   ��  �� ElementName$ SpeedSlider�� �� Mode$ TwoWay=� �� Path$ Value� �� UpdateSourceTrigger$ PropertyChanged=��� 5!   
   -	   5        $	 	generator��5!      $��0��6$   $��50��64   
���   �$��10q�6g   $��0,68,12,-42q�6t   .��6�   Generate Once6�   �� 5"   
   -
   5        $	 Reset��5"      $��50��6/   
���   �$��10q�6O   $��0,118,12,-92q�6\   .��6r   Reset6y   �� 5#   
   -   5        $	 
saveButton��5#      $��50��67   
���   �$��10q�6W   $��0,168,12,-142q�6d   .��6{   Save6�   �� 5$   
   -   5        $	 loadingButton��5$      $��50��66   
���   �$��10q�6V   $��0,218,12,-192q�6c   .��6z   Load6�   �� 5%   
   -   5        $	 
exitButton��5%      
���   �$��10q�6N   $��50��6[   $��0,268,12,-242q�6g   .��6~   Exit6�   5&      5'      