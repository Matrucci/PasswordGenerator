   M S B A M L   `   `   `  ����M  IPassword Generator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Password_GeneratorPassword_Generator  5   	   #    Password_Generator.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Password_Generator     5   	     � Title$  Password Generator��5   	   $	��300��6$   $	��700��61   .��5	      �  � RowDefinitions 5
   
   �� 5      $��* �6   �� 5      $	��100 �6   .+�5   
   ��  �� Orientation$ Vertical=�6   $��0��6,   .+�5      �� $ 
Horizontal=�6   $��0��62   $��Center=�6?   $��0,10,0,0q�6\   .+�5      �� $��Length: ��6   �� 5      -   5        $��passwordLength��5      $��20��61   $	��Top=�6=   $��10,0,0,0q�6U    �� SelectedIndex$ 0��6g   .@�5      �� $��8��6#   �� 5      $��16��6#   �� 5      $��32��6#   5      �� 5      -   5         ��Name$ allowUpperCase��5      $��Allow upper case��63   $��	10,0,10,0q�6N   �� 5      -   5        $ allowNumbers��5      $��Allow numbers��61   $��	10,0,10,0q�6I   �� 5      -   5        $ allowSymbols��5      $(��"Allow special characters (symbols)��61   $��	10,0,10,0q�6^   5      �� 5      -   5         ��Name$ generatePassword��5      $��30��6/   $��Generate password��6;   $	��150��6W   $��0,30,0,0q�6c   6u   �� 5       -   5         ��Name$ generatedPassword��5        �� TextAlignment$ Center=�61   $��30(�6�   $��0,20,0,0q�6�   ��6H   �� *GeneratedPassword+ �� Mode$ OneWay=�	 �� UpdateSourceTrigger$	 PropertyChanged=�6�   5!      �� 5%   
   $ Vertical=�6   $��1��6,   .+�5&      �� 	
 �� X1$
 0��6   	 �� Y1$ 0��6   	 �� X2$	 700��6!   	 �� Y2$ 0��6*   
���   �$��2��6@   �� 5'      $��Check your password:��6   $��Center=�64   �� 5)      -   5        $��userPassword��5)      $ Center=�6�   $��1��6�   $��30(�6�   ��6*   �� *UserPassword+$ OneWayToSource=�$	 PropertyChanged=�6�   �� 5+      $ 
Horizontal=�6   $��Center=�62   $��Center=�6O   .+�5,      �� -   5         ��Name$ redRec��5,      $��1q�6G    �� CornerRadius$ 	10,0,0,10��6[   
���   �
���  ��$��20��6�   $	��140��6�   y�6)   �� *IsWeak+6�   �� 5-      -	   5        $ 	orangeRec��5-      $��1q�6L   
���   �
��� ���$��20��6�   $	��140��6�   y�6,   �� *
IsNormal+6�   �� 5.      -
   5        $ 	yellowRec��5.      $��1q�6N   
���   �
��� ���$��20��6�   $	��140��6�   y�6,   �� *
IsModerate+6�   �� 5/      -   5        $ greenRec��5/      $��1q�6K   $ 	0,10,10,0��6_   
���   �
��� � �$��20��6�   $	��140��6�   y�6+   �� *
IsStrong+6�   50      � 51      .+�52      �� $
��Weak��6   $��70,0,0,0q�6(   �� 53      $��Strong��6   $��0,0,70,0q�6*   $��Right=�6<   54      55      57      58      