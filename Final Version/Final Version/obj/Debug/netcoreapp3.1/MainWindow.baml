   M S B A M L   `   `   `  ����H  DFinal Version, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Final_VersionFinal_Version  5   	       Final_Version.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:Final_Version     5   	     � Title$  Game of Life��5   	   $��	Helvetica)�5	   	   $��16(�6     � UseLayoutRounding$
 True��5
   	    � WindowStartupLocation$ CenterScreen=�5   	   $��1q�5   	   
�������.��5      � -   5        $��MainGrid��5       � ShowGridLines$ False��6   $
 True��61   $
}�True��6J    � RowDefinitions 5   
   �� 5      $
��auto �6    � ColumnDefinitions 5   
   �� 5      $
��auto �6   .+�5   
   �� -   5         ��Name$ Generations��5      $�� ��6%   $
��Auto��60   $��5q�6=   $��30��6I   $��314,6,-349,59q�6U    � ToolTip$= 7Number of generation/iterations that has been generated��6l   �� 5   
   -   5        $ 
AliveCells��5      $�� ��6$   $
��Auto��6/   $��5q�6<   $��30��6H   $��314,38,-349,28q�6T   $ Number of living cells��6l   �� 5   
   -   5        $ Delay��5       J� RenderTransformOrigin$ 100,0&�6   $��  Delay:��6=   $��Center=�6P   $	��Top=�6n   $��30��6�   $	��150��6�   $��0,13,0,0q�6�   $H BDelay between subsequent generations when automatically generating��6�   �� 5   
   -   5        $ MS��5      $
��(ms)��6   $��40��6+   $��30��66   $��102,13,13,62q�6B   �� 5   
   -   5        	 ��Name$	 autoGenerator��5      $��50��6>   
�������$��170,14,-158,42q�6^   ${�False��6v   
 ^� ShowOnDisabled$

 True��6�   $j dClick to start automatic generation progression.
If the button is disabled, there are no alive cells��6�   .��6!  Start Generation63  �� 5   
   -   5         ��Name$ SpeedSlider��5       � Minimum$ 1Q�6&    �� IsSnapToTickEnabled$
 True��62    �� TickFrequency$ 1Q�6M    � Maximum$	 500Q�6_   $��10,48,13,23q�6m    � Value$	 200Q�6�   $, &Slider to change auto generation delay��6�   �� 5   
   -   5         ��Name$ SpeedInt��5       �� 	MaxLength$ 3��6$    �� TextAlignment$ Center=�62   $��Center=�6I   $��0q�6k   $��30��6   $��63,13,53,61q�6�   $( "Textbox to change generation delay��6�   ��6�   ��  �� ElementName$ SpeedSlider�� �� Mode$ TwoWay=� �� Path$ Value� �� UpdateSourceTrigger$ PropertyChanged=��� 5    
   -	   5        $	 rules��5       $��50��62   
�������$��10q�6R   $��10,78,12,-31q�6_   $	��130��6u   $  Click to display the rules��6�   .��6�   Rules6�   �� 5!   
   -
   5        $	 	generator��5!      $��0��6$   $��50��64   
�������$��10q�6g   $��10,128,12,-81q�6t   $	��130��6�   ${�False��6�   $

 True��6�   $b \Click to move forward by one generation.
If the button is disabled, there are no alive cells��6�   .��6:  Generate Once6I  �� 5"   
   -   5        $	 gridsize��5"      $��50��6;   
�������$��10,178,12,-131q�6[   $	��130��6s   $. (Go Back to the Grid Size selector window��6   .��6�   Change Grid Size6�   �� 5#   
   -   5        $	 reset��5#      $��50��6/   
�������$��10q�6O   $��10,228,12,-181q�6\   $	��130��6t   $ Clear/Reset the Grid��6�   .��6�   Clear6�   �� 5$   
   -   5        $	 	randomise��5$      $��50��67   
�������$��10q�6W   $��10,278,12,-231q�6d   $	��130��6|   $1 +Load the grid with a random layout of cells��6�   .��6�   	Randomise6�   �� 5%   
   -   5        $	 glider��5%      $��50��64   
�������$��5q�6T   $��10, 328, 12, -281q�6`   $	��130��6{   $. (Load the grid with a glider cell cluster��6�   .��6�   Load Glider6�   �� 5&   
   -   5        $	 oscillators��5&      $��50��6>   
�������$��5q�6^   $��10, 378, 12, -331q�6j   $	��130��6�   $5 /Load the grid with cell clusters that oscillate��6�   .��6�   Load Oscillators6�   �� 5'   
   -   5        $	 	glidergun��5'      $��50��67   
�������$��5q�6W   $��10, 428, 12, -381q�6c   $	��130��6~   $��Load Glider Gun��6�   $

 True��6�   $z tLoad the grid with a Gosper Glider Gun cell cluster.
The Grid must be at least 36*36 for the Glider gun to be loaded��6�   6O  �� 5(   
   -   5        $	 
exitButton��5(      $��50��64   
�������$��10q�6T   $��10, 478, 12, -431q�6a   $	��130��6|   $ Close the app��6�   .��6�   Exit6�   5)      5*      