   M S B A M L   `   `   `  ����C  ?Version5, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:Version5Version5  5   	       Version5.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Version5     5   	     � Title$  Game of Life��5   	   $��	Helvetica)�5	   	   $��16(�6     � UseLayoutRounding$
 True��5
   	    � WindowStartupLocation$ CenterScreen=�5   	   $��1q�5   	   $	��900��5   	   $	��900��6    � 
ResizeMode$ NoResize=�6"   .��5      � -   5        $��MainGrid��5       � ShowGridLines$ False��6   $
 True��61   $
}�True��6J    � RowDefinitions 5   
   �� 5      $
��auto �6    � ColumnDefinitions 5   
   �� 5      $
��auto �6   .+�5   
   �� -   5         ��Name$ Generations��5      $�� ��6%   $
��auto��60   $��5q�6=   $��30��6I   $��314,6,-349,59q�6U   �� 5   
   -   5        $ 
AliveCells��5      $�� ��6$   $
��Auto��6/   $��5q�6<   $��30��6H   $��314,38,-349,28q�6T   �� 5   
   -   5        $ Delay��5       J� RenderTransformOrigin$ 100,0&�6    $��  Delay:��6>   $��Center=�6Q   $	��Top=�6o   $��30��6�   $	��150��6�   $��0,13,0,0q�6�   �� 5   
   -   5        $ MS��5      $
��(ms)��6   $��40��6+   $��30��66   $��102,13,13,62q�6B   �� 5   
   -   5        	 ��Name$	 autoGenerator��5      $��50��6>   
�������$��170,14,-158,42q�6^   ${�False��6v   .��6�   Start6�   �� 5   
   -   5        
 ��Name$
 SpeedSlider��5       � Minimum$ 1Q�6&    �� IsSnapToTickEnabled$
 True��62    �� TickFrequency$ 1Q�6M    � Maximum$	 500Q�6_   $��10,48,13,23q�6m    � Value$	 200Q�6�   �� 5   
   -   5         ��Name$ SpeedInt��5       �� 	MaxLength$ 3��6$    �� TextAlignment$ Center=�62   $��Center=�6I   $��0q�6k   $��30��6   $��63,13,53,61q�6�   ��6�   ��  �� ElementName$ SpeedSlider�� �� Mode$ TwoWay=� �� Path$ Value� �� UpdateSourceTrigger$ PropertyChanged=��� 5    
   -	   5        $	 rules��5       $��50��62   
�������$��10q�6R   $��10,78,12,-31q�6_   $	��130��6u   .��6�   Rules6�   �� 5!   
   -
   5        $	 	generator��5!      $��0��6$   $��50��64   
�������$��10q�6g   $��10,128,12,-81q�6t   $	��130��6�   ${�False��6�   .��6�   Generate Once6�   �� 5"   
   -   5        $	 gridsize��5"      $��50��6;   
�������$��10,178,12,-131q�6[   $	��130��6s   .��6   Change Grid Size6�   �� 5#   
   -   5        $	 reset��5#      $��50��6/   
�������$��10q�6O   $��10,228,12,-181q�6\   $	��130��6t   .��6�   Clear6�   �� 5$   
   -   5        $	 	randomise��5$      $��50��67   
�������$��10q�6W   $��10,278,12,-231q�6d   $	��130��6|   .��6�   	Randomise6�   �� 5%   
   -   5        $	 
exitButton��5%      $��50��64   
�������$��10q�6T   $��10, 328, 12, -281q�6a   $	��130��6|   .��6�   Exit6�   5&      5'      