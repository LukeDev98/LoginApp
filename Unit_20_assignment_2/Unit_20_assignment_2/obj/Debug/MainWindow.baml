   M S B A M L   `   `   `  ����O  KUnit_20_assignment_2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Unit_20_assignment_2Unit_20_assignment_2  5   	   %    Unit_20_assignment_2.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:Unit_20_assignment_2     5   	   -   5          �Name$  Form1��5   	    � Title$ Login��5   	   $	��350��6   $	��525��6$   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��20* �6   �� 5      $
��240* �6   �� 5      $
��239* �6   �� 5      $	��18* �6    � RowDefinitions 5   
   �� 5      $	��22* �6   �� 5      $	��59* �6   �� 5      $
��142* �6   �� 5      $	��74* �6   �� 5      $	��22* �6   .+�5   
   �� -   5         ��Name$ usernameBox��5      $��2��6'   $
��Left=�67   $��23��6R   $��	64,40,0,0q�6^   $��2��6q    �� TextWrapping$
 Wrap=�6~   $	��Top=�6�   $	��120��6�    � ToolTip$ Username entry box.��6�   �� 5   
   -   5         ��Name$ Title��5      $��NIAP Health Care��6   $��1��6:   $
��Left=�6J   $��	52,18,0,0q�6e   $��1��6x   $	��Top=�6�   $��16(�6�   �� 5   
   -   5        $ usernameLable��5      $��	Username:��6'   $��1��6;   $
��Left=�6K   $��	81,36,0,0q�6f   $��2��6y   $	��Top=�6�   $��14(�6�   �� 5   
   -   5        $ passwordLable��5      $��	Password:��6'   $��1��6;   $
��Left=�6K   $��	81,79,0,0q�6f   $��2��6y   $	��Top=�6�   $��14(�6�   G� 5   
   -   5         G�Name$ passwordBox��5      $��2��6+   $
��Left=�6;   $��	64,87,0,0q�6V   $��2��6i   $	��Top=�6v   $	��120��6�   $��24��6�   $ Password entry box.��6�   �� 5   
   -   5        	 ��Name$	 Login_button��5      $��Login��6'   $��2��67   $
��Left=�6G   $��	79,28,0,0q�6b   $��3��6u   $	��Top=�6�   $��90��6�   $��27��6�   $9 3Login button, press when details have been entered.��6�   �� 5   
   -   5        $ errorBox��5      $��1��6$   $
��Left=�64   $��54��6O   $��	10,10,0,0q�6[   $��3��6n   $
 Wrap=�6{   $	��Top=�6�   $	��220��6�   $ Error message box.��6�   5      5       