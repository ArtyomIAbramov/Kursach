   M S B A M L   `   `   `  ����D  @AutoSalon, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:AutoSalon.ViewsAutoSalon.Views  5   	   "    AutoSalon.Views.EmployeeView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:AutoSalon.Views     5   	     � Title$  EmployeeView��5   	   $��563.048��6   $
��1100��60    � 	Resources 5	      ��%    5      .��5      ��  �� Orientation$ Vertical=�6   $��0,0,0,0q�6(   .+�5   
   �� $	��211��6   .+�5      &   System.Windows.Controls.DataGrid     AutoGenerateColumns .     
IsReadOnly .    SelectionUnit$ FullRow=�6n   $��Center=�6�   $
��1060��6�   $	��210��6�   ��63   �� *Employee_list+z�5      V� 5      .~�5      ��  �� ScaleY$ 1Q�6)   �� 5      �� 5      T� 5      5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$  ��6@   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 0 6J   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6)   �� *Id+6J     5      $ Имя��6B   $	 70 6O   
 6)   �� *Name+6O     5      $ Фамилия��6E   $		 100 6V   
 6)   �� *	Surname+6V     5      $ Должность��6B   $		 110 6U   
 6)   �� *Post+6U     5      $ Телефон��6L   $		 100 6]   
 6)   �� *Empphonenumber+6]     5      $ 
Адрес��6H   $	 80 6W   
 6)   �� *
Empaddress+6W     5      $ Паспорт��6I   $	 90 6Z   
 6)   �� *Emppassport+6Z     5       $ Аккаунт��6E   $	 90 6V   
 6)   �� *	Account+6V     5!      $ Пароль��6F   $	 90 6V   
 6)   �� *
Password+6V     5"      $ Зарплата��6D   $	 90 6V   
 6)   �� *Salary+6V     5#      $ Продано на��6G   $		 110 6[   
 6)   �� *	TotalSold+6[   4  .System.Windows.Controls.DataGridTemplateColumn  5$      $		 150 6-      CellTemplate 5%      �� 5&      .R�5'   "   �� $��Выбрать��6)   ��6;   ��  �� Path$ Id���5(   )   �� $ DataContext.EditCommand� �� RelativeSource �� *FindAncestor+ �� AncestorType$ WindowL�5*      5,        5-      $		 150 6-    5.      �� 5/      .R�50   "   �� $��Удалить��6)   ��6<   �� $ Id���51   )   �� $ DataContext.DeleteCommand� �� *FindAncestor+$ WindowL�53      55      57      58      �� 59   
   $��40��6   $ 
Horizontal=�6!   $��Center=�6:   .+�5:      �� $��Добавить��6   $��30��6)   $	��123��65   ��5;      �� *SaveCommand+5=      �� 5>   
   $��Сотрудник��6   $��10q�6'   $	��229��63   $	��760��6@   .��5?      � $��0,10,0,0q�6   $	��760��6%    � RowDefinitions 5@      �� 5A      $��1* �6$   �� 5B      $��1* �6$   �� 5C      $��1* �6$   �� 5D      $��1* �6$    � ColumnDefinitions 5G      �� 5H      $��80 �6'   �� 5I      $	��170 �6'   �� 5J      $��80 �6'   �� 5K      $	��180 �6'   �� 5L      $��80 �6'   �� 5M      $	��170 �6'   .+�5O      �� $��Имя��6   $
��Left=�6&   $��Center=�5P      $��0��6:   $��0��6J   $	��100��6W   �� 5Q      $��0��6   $��1��6'   $��5,8,5,8q�5R   k   $	��160��6}   $
��Left=�6�   ��6   �� $ Entity.Name� �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5S      $��Фамилия��6   $
��Left=�6*   $��Center=�5T      $��0��6:   $��1��6J   $	��100��6W   �� 5U      $��1��6   $��1��6'   $��5,8,5,8q�5V   o   $	��160��6�   $
��Left=�6�   ��6   �� $ Entity.Surname�$ TwoWay=�$ PropertyChanged=�6�   �� 5W      $��Должность��6   $
��Left=�6,   $��Center=�6G   $��2��5X      $��0��6%   $	��100��65   �� 5Y      $��2��6   $��1��6'   $��5,8,5,8q�5Z   k   $	��160��6|   $
��Left=�6�   ��6   �� $ Entity.Post�$ TwoWay=�$ PropertyChanged=�6�   �� 5[      $��Телефон��6   $
��Left=�6*   $��Center=�6E   $��3��5\      $��0��6%   $	��100��65   �� 5]      $��3��6   $��1��6'   $��5,8,5,8q�5^   u   $	��160��6�   $
��Left=�6�   ��6   �� $ Entity.Empphonenumber�$ TwoWay=�$ PropertyChanged=�6�   �� 5_      $��
Адрес��6   $
��Left=�6(   $��Center=�6C   $��0��5`      $��2��6%   $	��100��65   �� 5a      $��0��6   $��3��6'   $��5,8,5,8q�5b   r   $	��170��6�   $
��Left=�6�   ��6   �� $ Entity.Empaddress�$ TwoWay=�$ PropertyChanged=�6�   �� 5c      $��
Почта��6   $
��Left=�6(   $��Center=�6C   $��1��5d      $��2��6%   $	��100��65   �� 5e      $��1��6   $��3��6'   $��5,8,5,8q�5f   l   $	��170��6}   $
��Left=�6�   ��6   �� $ Entity.Email�$ TwoWay=�$ PropertyChanged=�6�   �� 5g      $��Зарплата��6   $
��Left=�6+   $��Center=�6F   $��2��5h      $��2��6%   $	��100��65   �� 5i      $��2��6   $��3��6'   $��5,8,5,8q�5j   m   $	��170��6~   $
��Left=�6�   ��6   �� $ Entity.Salary�$ TwoWay=�$ PropertyChanged=�6�   �� 5k      $��Пасспорт��6   $
��Left=�6+   $��Center=�6F   $��0��5l      $��4��6%   $	��100��65   �� 5m      $��0��6   $��5��6'   $��5,8,5,8q�5n   s   $	��160��6�   $
��Left=�6�   ��6   �� $ Entity.Emppassport�$ TwoWay=�$ PropertyChanged=�6�   �� 5o      $��Аккаунт��6   $
��Left=�6*   $��Center=�6E   $��1��5p      $��4��6%   $	��100��65   �� 5q      $��1��6   $��5��6'   $��5,8,5,8q�5r   n   $	��160��6   $
��Left=�6�   ��6   �� $ Entity.Account�$ TwoWay=�$ PropertyChanged=�6�   �� 5s      $��Пароль��6   $
��Left=�6)   $��Center=�6D   $��2��5t      $��4��6%   $	��100��65   �� 5u      $��2��6   $��5��6'   $��5,8,5,8q�5v   p   $	��160��6�   $
��Left=�6�   ��6   �� $ Entity.Password�$ TwoWay=�$ PropertyChanged=�6�   5w      5x      5y      5z      