   M S B A M L   `   `   `  ����O  KUnit_20_assignment_2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Unit_20_assignment_2Unit_20_assignment_2  5   	        Unit_20_assignment_2.Form2   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:Unit_20_assignment_2     5   	     � Title$  Medical Test��5   	   $	��500��6   $
��1000��6+   .��5	      �  � RowDefinitions 5
   
   �� 5      $��9* �6   �� 5      $
��266* �6   �� 5      $
��189* �6   �� 5      $��5* �6    � ColumnDefinitions 5   
   �� 5      $	��18* �6   �� 5      $
��838* �6   �� 5      $
��119* �6   �� 5      $	��17* �6   .+�5   
   �� -   5         ��Name$ Continue_button��5      $��Continue��6*   $��2��6=   $��9,42,0,0q�6M   $	��Top=�6_   $��91��6w    J� RenderTransformOrigin$ 0.5,0.5&�6�   $��2��6�    � ToolTip$> 8Continue button, press when an answer has been selected.��6�   $
��Left=�6  $	��105��6#  $��20(�6/  z�5      V� 5      .~�5      �� �� 5      �� 5       �� Angle$ -0.12Q�6&   T� 5      5      5      �� 5    
   -   5         ��Name$ 	Questions��5       $��1��6%   $
��Left=�65   $	��214��6P   $��	10,15,0,0q�6]    �� TextWrapping$
 Wrap=�6p   $	��Top=�6�   $	��332��6�   	 �� 	IsEnabled	 . $ Question box.��6�   $��1��6�   $��18(�6�   6�   	� 5!   
   -   5        
 	�Name$
 QuestionButton2��5!      $�� ��6/   $��1��6:   $
��Left=�6J   $��395,127,0,0q�6e   $	��Top=�6z   $	��542��6�   $��31��6�   $��2��6�   $ Answer select button 2.��6�   $��1��6  	� 5"   
   -   5        $
 QuestionButton3��5"      $�� ��6/   $��1��6:   $
��Left=�6J   $��
395,0,0,49q�6e   $��Bottom=�6y   $	��542��6�   $��31��6�   $��2��6�   $ Answer select button 3.��6�   $��1��6  �� 5#   
   -   5         ��Name$ label��5#      $��NIAP Health Care��6   $��1��6:   $��395,1,222,0q�6J   $��24(�6_   $��47��6m   $	��Top=�6y   $��1��6�   	� 5$   
   -   5        $
 QuestionButton1��5$      $�� ��6/   $��1��6:   $
��Left=�6J   $��
395,71,0,0q�6e   $	��Top=�6y   $	��542��6�   4  .System.Windows.Automation.AutomationProperties   HelpText$
 Poop��6�   $��31��6�   $��2��6�   $ Answer select button 1.��6  $��1��6&  �� 5%   
   -   5         ��Name$ 	Rectangle��5%      $��1��6'   ���	#FFF4F4F5$��56,0,0,5q�6H   
���   �$ 
Dashboard.��6i   $��2��6~   $	��175��6�   $��Bottom=�6�   $
��Left=�6�   $	��746��6�   &   System.Windows.Controls.Calendar  5&   
   $��1��6   $��	90,10,0,0q�6#   $��2��66   $ Calendar��6C   $
��Left=�6V   $	��179��6q   $	��168��6}   $	��Top=�6�   �� 5'   
   -   5        $ Clock��5'      $��1��6!   $��
322,82,0,0q�61   $��2��6E   $
 Wrap=�6R   $��18(�6f   $ Clock��6t   $
��Left=�6�   $	��102��6�   $��31��6�   $	��Top=�6�   �� 5(   
   -	   5        $ Calculator_Button��5(      $��
Calculator��6,   $��1��6A   $��
477,62,0,0q�6Q   $��2��6e   $ Opens the calculator.��6r   $��20(�6�   $
��Left=�6�   $	��124��6�   $��66��6�   $	��Top=�6�   �� 5)   
   -
   5        $ NotepadButton��5)      $��Notepad��6(   $��1��6:   $��
644,62,0,0q�6J   $��2��6^   $ Press to open the Notepad��6k   $��20(�6�   $
��Left=�6�   $	��124��6�   $��66��6�   $	��Top=�6�   5*      5+      